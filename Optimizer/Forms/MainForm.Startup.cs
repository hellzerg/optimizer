using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Slow startup work (WMI, feed and update downloads) runs off the UI thread so the window
    /// can appear immediately; results are applied on the UI thread exactly as before.
    /// </summary>
    public sealed partial class MainForm {
        sealed class HardwareSnapshot {
            internal List<CPU> CPUs = new List<CPU>();
            internal List<RAM> RAM = new List<RAM>();
            internal VirtualMemory VM;
            internal List<GPU> GPUs = new List<GPU>();
            internal List<Motherboard> Motherboards = new List<Motherboard>();
            internal List<Disk> Disks = new List<Disk>();
            internal List<AudioDevice> Audio = new List<AudioDevice>();

            static T Safe<T>(Func<T> query, T fallback, string what) where T : class
            {
                try { return query() ?? fallback; }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.HardwareSnapshot." + what, ex.Message, ex.StackTrace);
                    return fallback;
                }
            }

            static void Safe(Action query, string what)
            {
                try { query(); }
                catch (Exception ex) { Logger.LogError("MainForm.HardwareSnapshot." + what, ex.Message, ex.StackTrace); }
            }

            internal static HardwareSnapshot Capture()
            {
                HardwareSnapshot hw = new HardwareSnapshot();
                hw.CPUs = Safe(IndiciumHelper.GetCPUs, hw.CPUs, "CPUs");
                hw.RAM = Safe(IndiciumHelper.GetRAM, hw.RAM, "RAM");
                hw.VM = Safe(IndiciumHelper.GetVM, null, "VM");
                hw.GPUs = Safe(IndiciumHelper.GetGPUs, hw.GPUs, "GPUs");
                hw.Motherboards = Safe(IndiciumHelper.GetMotherboards, hw.Motherboards, "Motherboards");
                hw.Disks = Safe(IndiciumHelper.GetDisks, hw.Disks, "Disks");
                Safe(IndiciumHelper.GetVolumes, "Volumes");
                Safe(IndiciumHelper.GetNetworkAdapters, "NetworkAdapters");
                hw.Audio = Safe(IndiciumHelper.GetAudioDevices, hw.Audio, "Audio");
                Safe(IndiciumHelper.GetPeripherals, "Peripherals");
                return hw;
            }
        }

        SynchronizationContext _uiContext;

        void CaptureUi()
        {
            if (_uiContext == null) _uiContext = SynchronizationContext.Current;
        }

        /// <summary>Posts to the UI thread; unlike BeginInvoke this also works before the window handle exists.</summary>
        void OnUi(Action a)
        {
            SynchronizationContext ctx = _uiContext;
            if (ctx == null) { UI(a); return; }
            ctx.Post(_ => { if (!IsDisposed) a(); }, null);
        }

        Panel _hwLoading;
        FluentLabel _hwLoadingText;
        BusyBar _hwBusy;

        void LoadHardwareSpecsAsync()
        {
            CaptureUi();
            ShowHardwareLoading(true);
            Task.Run(() => HardwareSnapshot.Capture()).ContinueWith(t =>
            {
                HardwareSnapshot hw = t.Status == TaskStatus.RanToCompletion ? t.Result : new HardwareSnapshot();
                OnUi(() =>
                {
                    try
                    {
                        BuildHardwareTree(hw);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError("MainForm.BuildHardwareTree", ex.Message, ex.StackTrace);
                    }
                    finally
                    {
                        ShowHardwareLoading(false);
                    }
                });
            }, TaskScheduler.Default);
        }

        void ShowHardwareLoading(bool loading)
        {
            if (_hwLoading == null && loading)
            {
                _hwLoading = new Panel { Dock = DockStyle.Fill };
                _hwLoadingText = new FluentLabel(Typography.Get(11f, Typography.Weight.Semibold), LabelTone.Secondary)
                {
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                _hwBusy = new BusyBar();
                _hwLoading.Controls.Add(_hwLoadingText);
                _hwLoading.Controls.Add(_hwBusy);
                _hwLoading.Layout += (s, e) =>
                {
                    int w = Math.Min(_hwLoading.ClientSize.Width - Draw.SI(32), Draw.SI(320));
                    int x = (_hwLoading.ClientSize.Width - w) / 2;
                    int y = Math.Max(Draw.SI(24), _hwLoading.ClientSize.Height / 3);
                    Place(_hwLoadingText, x, y, w, Draw.SI(28));
                    Place(_hwBusy, x, y + Draw.SI(36), w, Draw.SI(3));
                };
                panel12.Controls.Add(_hwLoading);
                _hwLoading.BringToFront();
                ThemeManager.Apply(_hwLoading);
            }
            if (_hwLoadingText != null) _hwLoadingText.Text = T("hwLoading", "Inspecting hardware…");

            specsTree.Visible = !loading;
            hwDetailed.Enabled = !loading;
            btnCopyHW.Enabled = !loading;
            btnSaveHW.Enabled = !loading;

            if (_hwLoading == null) return;
            _hwLoading.Visible = loading;
            _hwBusy.Running = loading;
            if (!loading)
            {
                panel12.Controls.Remove(_hwLoading);
                _hwLoading.Dispose();
                _hwLoading = null;
                _hwLoadingText = null;
                _hwBusy = null;
            }
        }

        bool _appsLoading;
        FluentLabel _appsLoadingText;
        BusyBar _appsBusy;

        /// <summary>Downloads the online feed in the background, falling back to the embedded copy.</summary>
        void GetFeedAsync()
        {
            if (_appsLoading) return;
            CaptureUi();
            SetAppsLoading(true);

            Task.Run(() =>
            {
                try
                {
                    using (WebClient client = new FeedWebClient { Encoding = Encoding.UTF8 })
                    {
                        client.Headers.Add("Cache-Control", "no-cache");
                        byte[] images = client.DownloadData(_feedImages);
                        string feed = client.DownloadString(_feedLink);
                        return Tuple.Create(feed, images);
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.GetFeed", ex.Message, ex.StackTrace);
                    return null;
                }
            }).ContinueWith(t =>
            {
                Tuple<string, byte[]> online = t.Status == TaskStatus.RanToCompletion ? t.Result : null;
                OnUi(() =>
                {
                    try
                    {
                        ApplyFeed(online);
                    }
                    finally
                    {
                        SetAppsLoading(false);
                    }
                });
            }, TaskScheduler.Default);
        }

        void ApplyFeed(Tuple<string, byte[]> online)
        {
            if (online != null)
            {
                try
                {
                    using (ZipArchive zip = new ZipArchive(new MemoryStream(online.Item2)))
                    {
                        PopulateFeed(online.Item1, name => zip.Entries.First(ifn => ifn.Name == name).Open());
                    }
                    return;
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.GetFeed", ex.Message, ex.StackTrace);
                }
            }
            PopulateEmbeddedFeed();
        }

        void SetAppsLoading(bool loading)
        {
            _appsLoading = loading;
            btnGetFeed.Enabled = !loading;
            if (loading) btnDownloadApps.Enabled = false;

            if (_appsHost == null) return;
            if (_appsLoadingText == null)
            {
                _appsLoadingText = NewLabel(_appsHost, 11f, Typography.Weight.Semibold, LabelTone.Secondary);
                _appsLoadingText.TextAlign = ContentAlignment.MiddleCenter;
                _appsBusy = new BusyBar();
                _appsHost.Controls.Add(_appsBusy);
            }
            _appsLoadingText.Text = T("appsLoading", "Loading apps…");
            _appsBusy.Running = loading;
            LayoutAppsCards();
        }

        /// <summary>Places the loading state; returns true while the placeholder replaces the error message.</summary>
        bool LayoutAppsLoading(bool anyTiles, int hostW, int hostH)
        {
            if (_appsLoadingText == null) return false;
            bool show = _appsLoading && !anyTiles;
            _appsLoadingText.Visible = show;
            _appsBusy.Visible = show;
            if (!show) return false;

            int w = Math.Min(hostW - Draw.SI(32), Draw.SI(320));
            int x = (hostW - w) / 2;
            int y = Math.Max(Draw.SI(24), Math.Min(hostH / 3, Draw.SI(160)));
            Place(_appsLoadingText, x, y, w, Draw.SI(28));
            Place(_appsBusy, x, y + Draw.SI(36), w, Draw.SI(3));
            return true;
        }

        /// <summary>Silent launch-time update check; same outcomes as <see cref="CheckForUpdate"/> with silentCheck.</summary>
        void CheckForUpdateOnLaunchAsync()
        {
            CaptureUi();
            Task.Run(() =>
            {
                if (!PingerHelper.IsInternetAvailable()) return null;
                using (WebClient client = new WebClient { Encoding = Encoding.UTF8 })
                {
                    return client.DownloadString(_latestVersionLink).Trim();
                }
            }).ContinueWith(t =>
            {
                OnUi(() =>
                {
                    if (t.IsFaulted)
                    {
                        Exception ex = t.Exception.GetBaseException();
                        Logger.LogError("MainForm.CheckForUpdate", ex.Message, ex.StackTrace);
                        MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string latestVersion = t.Result;
                    if (string.IsNullOrEmpty(latestVersion)) return;
                    if (float.TryParse(latestVersion, out float latest) && latest > Program.GetCurrentVersionToFloat())
                    {
                        picUpdate.Visible = true;
                    }
                });
            }, TaskScheduler.Default);
        }
    }
}
