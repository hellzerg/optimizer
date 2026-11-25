using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Optimizer.Tests {
    public sealed class AppDownloadStateTests {
        static AppInfo App(string title)
        {
            return new AppInfo { Title = title, Tag = "c" + title, Link = "https://example.invalid/x86", Link64 = "https://example.invalid/x64" };
        }

        static AppDownloadState.Batch Begin(AppDownloadState state)
        {
            return state.TryBeginDownload(new[] { App("One") }, Path.GetTempPath(), true, false);
        }

        [Fact]
        public void IdleStateIsNotBusy()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.False(state.IsBusy);
            Assert.False(state.IsLoadingFeed);
            Assert.False(state.IsDownloading);
        }

        [Fact]
        public void FeedLoadBlocksAnotherRefreshAndDownloads()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.True(state.TryBeginFeedLoad());
            Assert.True(state.IsLoadingFeed);
            Assert.True(state.IsBusy);
            Assert.False(state.TryBeginFeedLoad());
            Assert.Null(Begin(state));
            Assert.False(state.IsDownloading);
        }

        [Fact]
        public void FeedCompletionAllowsDownloadsAgain()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.True(state.TryBeginFeedLoad());
            state.EndFeedLoad();
            Assert.False(state.IsLoadingFeed);
            Assert.NotNull(Begin(state));
        }

        [Fact]
        public void DownloadBlocksRefreshAndReentry()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.NotNull(Begin(state));
            Assert.True(state.IsDownloading);
            Assert.True(state.IsBusy);
            Assert.False(state.TryBeginFeedLoad());
            Assert.Null(Begin(state));
        }

        [Fact]
        public void DownloadCompletionRestoresIdleState()
        {
            AppDownloadState state = new AppDownloadState();
            AppDownloadState.Batch batch = Begin(state);
            state.EndDownload(batch);
            Assert.False(state.IsBusy);
            Assert.True(state.TryBeginFeedLoad());
        }

        [Fact]
        public void EmptySelectionDoesNotStartABatch()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.Null(state.TryBeginDownload(new AppInfo[0], Path.GetTempPath(), true, false));
            Assert.False(state.IsBusy);
            Assert.True(state.TryBeginFeedLoad());
        }

        [Fact]
        public void InvalidInputsDoNotLeaveTheDownloaderBusy()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.Throws<ArgumentNullException>(() => state.TryBeginDownload(null, Path.GetTempPath(), true, false));
            Assert.Throws<ArgumentException>(() => state.TryBeginDownload(new[] { App("One") }, string.Empty, true, false));
            Assert.False(state.IsBusy);
            Assert.NotNull(Begin(state));
        }

        [Fact]
        public void BatchCapturesSelectionAndAppMetadata()
        {
            AppInfo app = App("One");
            List<AppInfo> selected = new List<AppInfo> { app };
            AppDownloadState state = new AppDownloadState();
            AppDownloadState.Batch batch = state.TryBeginDownload(selected, Path.GetTempPath(), true, false);

            selected.Clear();
            app.Title = "Changed";
            app.Tag = "Changed";
            app.Link = "Changed";
            app.Link64 = "Changed";

            AppInfo captured = Assert.Single(batch.Apps);
            Assert.Equal("One", captured.Title);
            Assert.Equal("cOne", captured.Tag);
            Assert.Equal("https://example.invalid/x86", captured.Link);
            Assert.Equal("https://example.invalid/x64", captured.Link64);
            Assert.NotSame(app, captured);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void BatchCapturesArchitectureInstallationAndCanonicalFolder(bool prefer64, bool autoInstall)
        {
            string folder = Path.Combine(Path.GetTempPath(), "Optimizer fixture", "..", "Downloads");
            AppDownloadState.Batch batch = new AppDownloadState().TryBeginDownload(new[] { App("One") }, folder, prefer64, autoInstall);
            Assert.Equal(Path.GetFullPath(folder), batch.Folder);
            Assert.Equal(prefer64, batch.Prefer64);
            Assert.Equal(autoInstall, batch.AutoInstall);
        }

        [Fact]
        public void BatchSelectionCannotBeExtendedAfterStarting()
        {
            AppDownloadState.Batch batch = Begin(new AppDownloadState());
            IList<AppInfo> apps = Assert.IsAssignableFrom<IList<AppInfo>>(batch.Apps);
            Assert.Throws<NotSupportedException>(() => apps.Add(App("Two")));
            Assert.Single(batch.Apps);
        }

        [Fact]
        public void OldCompletionCannotUnlockANewerBatch()
        {
            AppDownloadState state = new AppDownloadState();
            AppDownloadState.Batch first = Begin(state);
            state.EndDownload(first);
            AppDownloadState.Batch second = Begin(state);
            state.EndDownload(first);
            state.EndDownload(null);

            Assert.True(state.IsDownloading);
            Assert.False(state.TryBeginFeedLoad());
            state.EndDownload(second);
            Assert.False(state.IsBusy);
        }

        [Fact]
        public void EndingAFeedLoadCannotUnlockAnActiveDownload()
        {
            AppDownloadState state = new AppDownloadState();
            AppDownloadState.Batch batch = Begin(state);
            state.EndFeedLoad();
            Assert.True(state.IsDownloading);
            Assert.False(state.TryBeginFeedLoad());
            Assert.Null(Begin(state));
            state.EndDownload(batch);
            Assert.False(state.IsBusy);
        }

        [Fact]
        public void FailedSnapshotEnumerationDoesNotStartAPartialBatch()
        {
            AppDownloadState state = new AppDownloadState();
            Assert.Throws<IOException>(() => state.TryBeginDownload(InterruptedSelection(), Path.GetTempPath(), true, false));
            Assert.False(state.IsBusy);
            Assert.NotNull(Begin(state));
        }

        static IEnumerable<AppInfo> InterruptedSelection()
        {
            yield return App("One");
            throw new IOException("Fixture selection failure");
        }
    }
}
