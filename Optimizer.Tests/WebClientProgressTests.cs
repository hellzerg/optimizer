using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;

namespace Optimizer.Tests {
    public sealed class WebClientProgressTests {
        public enum FixtureOutcome { Complete, Cancel, Timeout }

        [Theory]
        [InlineData(FixtureOutcome.Complete)]
        [InlineData(FixtureOutcome.Cancel)]
        [InlineData(FixtureOutcome.Timeout)]
        public async Task ChunkedProgressAndCleanupWorkOnTheUiThread(FixtureOutcome outcome)
        {
            TaskCompletionSource<bool> completed = new TaskCompletionSource<bool>();
            Thread thread = new Thread(() =>
            {
                try
                {
                    DownloadOnUiThread(outcome);
                    completed.SetResult(true);
                }
                catch (Exception ex)
                {
                    completed.SetException(ex);
                }
            });
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            Assert.Same(completed.Task, await Task.WhenAny(completed.Task, Task.Delay(TimeSpan.FromSeconds(25))));
            if (outcome == FixtureOutcome.Timeout)
            {
                TimeoutException error = await Assert.ThrowsAsync<TimeoutException>(() => completed.Task);
                Assert.Equal("Fixture timeout after progress.", error.Message);
                Assert.Empty(error.Data);
            }
            else
                await completed.Task;
        }

        static void DownloadOnUiThread(FixtureOutcome outcome)
        {
            bool cancel = outcome != FixtureOutcome.Complete;
            string folder = Path.Combine(Path.GetTempPath(), "OptimizerDownloads-" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(folder);
            TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            int port = ((IPEndPoint)listener.LocalEndpoint).Port;
            SynchronizationContext previous = SynchronizationContext.Current;
            Exception failure = null;

            try
            {
                using (ManualResetEventSlim progressObserved = new ManualResetEventSlim())
                using (ManualResetEventSlim releaseResponse = new ManualResetEventSlim())
                using (WindowsFormsSynchronizationContext context = new WindowsFormsSynchronizationContext())
                using (ProgressBar bar = new ProgressBar())
                using (WebClient client = new WebClient { Proxy = null })
                {
                    SynchronizationContext.SetSynchronizationContext(context);
                    int uiThread = Thread.CurrentThread.ManagedThreadId;
                    bool unknownLength = false;
                    bool wrongThread = false;
                    bool determinateWithoutLength = false;
                    bool cancellationRequested = false;
                    bool cancelledCompletion = false;
                    Exception progressError = null;
                    client.DownloadFileCompleted += (sender, e) => cancelledCompletion = e.Cancelled;
                    client.DownloadProgressChanged += (sender, e) =>
                    {
                        try
                        {
                            wrongThread |= Thread.CurrentThread.ManagedThreadId != uiThread;
                            int? percentage = AppDownloadProgress.Percentage(e.BytesReceived, e.TotalBytesToReceive);
                            if (e.TotalBytesToReceive < 0 && e.BytesReceived > 0)
                            {
                                unknownLength = true;
                                determinateWithoutLength |= percentage.HasValue;
                                progressObserved.Set();
                            }
                            if (percentage.HasValue) bar.Value = percentage.Value;
                        }
                        catch (Exception ex)
                        {
                            progressError = ex;
                            progressObserved.Set();
                        }
                    };

                    Task server = ServeChunkedResponse(listener, progressObserved, releaseResponse, cancel);
                    Task download = null;
                    try
                    {
                        string file = Path.Combine(folder, "fixture.download");
                        download = client.DownloadFileTaskAsync(new Uri("http://127.0.0.1:" + port + "/fixture"), file);
                        Stopwatch timeout = Stopwatch.StartNew();
                        while (!download.IsCompleted && timeout.Elapsed < TimeSpan.FromSeconds(10))
                        {
                            Application.DoEvents();
                            if (outcome == FixtureOutcome.Timeout && unknownLength)
                                throw new TimeoutException("Fixture timeout after progress.");
                            if (cancel && unknownLength && !cancellationRequested)
                            {
                                cancellationRequested = true;
                                client.CancelAsync();
                                releaseResponse.Set();
                            }
                            Thread.Sleep(5);
                        }

                        Assert.True(download.IsCompleted, "Loopback download did not complete.");
                        if (cancel)
                        {
                            Assert.True(cancellationRequested);
                            Assert.True(cancelledCompletion);
                            Exception error = Record.Exception(() => download.GetAwaiter().GetResult());
                            Assert.True(error is OperationCanceledException || error is WebException, "WebClient must report cancellation or its aborted request error.");
                        }
                        else
                            download.GetAwaiter().GetResult();
                        Assert.True(WaitForCompletion(server), "Loopback server did not complete.");
                        server.GetAwaiter().GetResult();
                        Assert.True(unknownLength, "The response must exercise progress before its size is known.");
                        Assert.False(wrongThread);
                        Assert.False(determinateWithoutLength);
                        Assert.Null(progressError);
                        if (!cancel) Assert.Equal(65536, new FileInfo(file).Length);
                    }
                    catch (Exception ex)
                    {
                        failure = ex;
                        throw;
                    }
                    finally
                    {
                        client.CancelAsync();
                        listener.Stop();
                        releaseResponse.Set();
                        bool downloadStopped = WaitForCompletion(download);
                        bool serverStopped = WaitForCompletion(server);
                        if (download != null && download.IsFaulted) _ = download.Exception;
                        if (server.IsFaulted) _ = server.Exception;
                        if (!downloadStopped || !serverStopped)
                        {
                            TimeoutException cleanup = new TimeoutException("Loopback operations did not stop during cleanup.");
                            if (failure == null) throw cleanup;
                            failure.Data["CleanupFailure"] = cleanup;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                failure = ex;
                throw;
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(previous);
                listener.Stop();
                try { Directory.Delete(folder, true); }
                catch (Exception cleanup)
                {
                    if (failure == null) throw;
                    failure.Data["FixtureCleanupFailure"] = cleanup;
                }
            }
        }

        static bool WaitForCompletion(Task task)
        {
            Stopwatch timeout = Stopwatch.StartNew();
            while (task != null && !task.IsCompleted && timeout.Elapsed < TimeSpan.FromSeconds(2))
            {
                Application.DoEvents();
                Thread.Sleep(5);
            }
            return task == null || task.IsCompleted;
        }

        static async Task ServeChunkedResponse(TcpListener listener, ManualResetEventSlim progressObserved, ManualResetEventSlim releaseResponse, bool cancel)
        {
            using (TcpClient connection = await listener.AcceptTcpClientAsync().ConfigureAwait(false))
            using (NetworkStream stream = connection.GetStream())
            using (StreamReader reader = new StreamReader(stream, Encoding.ASCII, false, 1024, true))
            {
                string line;
                do { line = await reader.ReadLineAsync().ConfigureAwait(false); }
                while (!string.IsNullOrEmpty(line));

                byte[] header = Encoding.ASCII.GetBytes("HTTP/1.1 200 OK\r\nTransfer-Encoding: chunked\r\nConnection: close\r\n\r\n10000\r\n");
                await stream.WriteAsync(header, 0, header.Length).ConfigureAwait(false);
                byte[] content = new byte[65536];
                await stream.WriteAsync(content, 0, content.Length).ConfigureAwait(false);
                Assert.True(await Task.Run(() => progressObserved.Wait(TimeSpan.FromSeconds(5))).ConfigureAwait(false), "No unknown-length progress event was observed.");
                if (cancel) Assert.True(await Task.Run(() => releaseResponse.Wait(TimeSpan.FromSeconds(5))).ConfigureAwait(false), "Cancellation was not requested.");
                byte[] end = Encoding.ASCII.GetBytes("\r\n0\r\n\r\n");
                try { await stream.WriteAsync(end, 0, end.Length).ConfigureAwait(false); }
                catch (IOException) when (cancel) { }
            }
        }
    }
}
