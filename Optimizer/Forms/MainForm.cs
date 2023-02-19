using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class MainForm : Form
    {
        Dictionary<string, string> translationList;

        ListViewColumnSorter _columnSorter;

        List<StartupItem> _startUpItems = new List<StartupItem>();
        List<StartupBackupItem> _backupItems = new List<StartupBackupItem>();

        List<string> _hostsEntries = new List<string>();
        List<string> _customCommands = new List<string>();
        List<string> _desktopItems = new List<string>();
        List<KeyValuePair<string, string>> _modernApps = new List<KeyValuePair<string, string>>();

        bool _trayMenu = false;

        List<PingReply> _pingResults;
        string _shodanIP = string.Empty;
        PingReply tmpReply;

        //NetworkMonitor _networkMonitor;
        //double uploadSpeed = 0;
        //double downloadSpeed = 0;
        //bool _networkMonitoringSupported = true;

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        public List<FeedApp> AppsFromFeed = new List<FeedApp>();
        readonly string _feedLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/feed.json";
        readonly string _feedImages = "https://raw.githubusercontent.com/hellzerg/optimizer/master/images/feed.zip";

        readonly string _licenseLink = "https://www.gnu.org/licenses/gpl-3.0.en.html";
        readonly string _discordLink = "https://discord.gg/rZh8BhmmQv";
        readonly string _githubProjectLink = "https://github.com/hellzerg/optimizer";
        readonly string _paypalSupportLink = "https://www.paypal.com/paypalme/supportoptimizer";

        readonly string _latestVersionLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/version.txt";
        //readonly string _changelogLink = "https://github.com/hellzerg/optimizer/blob/master/CHANGELOG.md";
        readonly string _changelogRawLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/CHANGELOG.md";

        string _noNewVersionMessage = "You already have the latest version!";
        string _betaVersionMessage = "You are using an experimental version!";
        string _newVersionMessage = "There is a new version available! Do you want to download it now?\nApp will restart in a few seconds.";

        readonly string _blockedIP = "0.0.0.0";

        string _restartMessage = "Restart to apply changes?";
        string _removeStartupItemsMessage = "Are you sure you want to delete these startup items?\n\n";
        string _removeHostsEntriesMessage = "Are you sure you want to delete all hosts entries?";
        string _removeDesktopItemsMessage = "Are you sure you want to delete all desktop items?";
        string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";
        string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled:\n";
        string _repairMessage = "Are you sure you want to reset configuration?\n\nThis will reset all your preferences, including any icons you extracted or downloaded using Integrator, but will not touch anything on your computer!";
        string _flushDNSMessage = "Are you sure you wish to flush the DNS cache of Windows?\n\nThis will cause internet disconnection for a moment and it may be needed a restart to function properly.";
        string _uwpRestoreMessage = "Are you sure you want to do this?";

        string _byteSizeNullString = " b";
        string _primaryItemTag = "_primary";

        bool _skipOneDrive = false;
        bool _skipSystemRestore = false;

        string[] _currentDNS;

        ColorOverrider _colorOverrider;

        List<TreeNode> _hwDetailed;
        TreeNode[] _hwSummarized;

        //Size _sizeDefault = new Size(1100, 784);
        //Size _sizeRussian = new Size(1410, 784);
        //Size _sizeHellenic = new Size(1125, 784);
        //Size _sizeTurkish = new Size(1130, 784);
        //Size _sizeFrench = new Size(1085, 784);

        bool _cleanSelectAll = true;
        List<string> _cleanPreviewList;

        UpdateForm _updateForm;

        private string NewDownloadLink(string latestVersion)
        {
            return string.Format("https://github.com/hellzerg/optimizer/releases/download/{0}/Optimizer-{0}.exe", latestVersion);
        }

        private void CheckForUpdate(bool silentCheck = false)
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            string latestVersion = string.Empty;
            try
            {
                latestVersion = client.DownloadString(_latestVersionLink).Trim();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.CheckForUpdate", ex.Message, ex.StackTrace);
                MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!string.IsNullOrEmpty(latestVersion))
            {
                if (float.Parse(latestVersion) > Program.GetCurrentVersion())
                {
                    // show UPDATE AVAILABLE on app launch
                    if (silentCheck)
                    {
                        picUpdate.Visible = true;
                        return;
                    }

                    _updateForm = new UpdateForm(_newVersionMessage, true, ParseChangelog(), latestVersion);
                    if (_updateForm.ShowDialog() == DialogResult.Yes)
                    {
                        try
                        {
                            Assembly currentAssembly = Assembly.GetEntryAssembly();

                            if (currentAssembly == null)
                            {
                                currentAssembly = Assembly.GetCallingAssembly();
                            }

                            string appFolder = Path.GetDirectoryName(currentAssembly.Location);
                            string appName = Path.GetFileNameWithoutExtension(currentAssembly.Location);
                            string appExtension = Path.GetExtension(currentAssembly.Location);

                            string archiveFile = Path.Combine(appFolder, "Optimizer_old" + appExtension);
                            string appFile = Path.Combine(appFolder, appName + appExtension);
                            string tempFile = Path.Combine(appFolder, "Optimizer_tmp" + appExtension);

                            // DOWNLOAD NEW VERSION
                            client.DownloadFile(NewDownloadLink(latestVersion), tempFile);

                            // DELETE PREVIOUS BACK-UP
                            if (File.Exists(archiveFile))
                            {
                                File.Delete(archiveFile);
                            }

                            // MAKE BACK-UP
                            File.Move(appFile, archiveFile);

                            // PATCH
                            File.Move(tempFile, appFile);

                            // BYPASS SINGLE-INSTANCE MECHANISM
                            _trayMenu = false;
                            if (Program.MUTEX != null)
                            {
                                Program.MUTEX.ReleaseMutex();
                                Program.MUTEX.Dispose();
                                Program.MUTEX = null;
                            }

                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            ErrorLogger.LogError("MainForm.CheckForUpdate", ex.Message, ex.StackTrace);
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (float.Parse(latestVersion) == Program.GetCurrentVersion())
                {
                    if (!silentCheck)
                    {
                        _updateForm = new UpdateForm(_noNewVersionMessage, false, string.Empty, latestVersion);
                        _updateForm.ShowDialog();
                    }
                }
                else
                {
                    if (!silentCheck)
                    {
                        _updateForm = new UpdateForm(_betaVersionMessage, false, string.Empty, latestVersion);
                        _updateForm.ShowDialog();
                    }
                }
            }
        }

        private void EnableToggleEvents()
        {
            officeTelemetrySw.ToggleClicked += new EventHandler(toggleSwitch12_Click);
            telemetryTasksSw.ToggleClicked += new EventHandler(toggleSwitch11_Click);
            superfetchSw.ToggleClicked += new EventHandler(toggleSwitch10_Click);
            homegroupSw.ToggleClicked += new EventHandler(toggleSwitch9_Click);
            reportingSw.ToggleClicked += new EventHandler(toggleSwitch8_Click);
            mediaSharingSw.ToggleClicked += new EventHandler(toggleSwitch6_Click);
            printSw.ToggleClicked += new EventHandler(toggleSwitch5_Click);
            systemRestoreSw.ToggleClicked += new EventHandler(toggleSwitch4_Click);
            performanceSw.ToggleClicked += new EventHandler(toggleSwitch1_Click);
            defenderSw.ToggleClicked += new EventHandler(toggleSwitch3_Click);
            networkSw.ToggleClicked += new EventHandler(toggleSwitch2_Click);
            spellSw.ToggleClicked += new EventHandler(toggleSwitch28_Click);
            inkSw.ToggleClicked += new EventHandler(toggleSwitch29_Click);
            driversSw.ToggleClicked += new EventHandler(toggleSwitch30_Click);
            sensorSw.ToggleClicked += new EventHandler(toggleSwitch20_Click);
            privacySw.ToggleClicked += new EventHandler(toggleSwitch21_Click);
            telemetryServicesSw.ToggleClicked += new EventHandler(toggleSwitch23_Click);
            autoUpdatesSw.ToggleClicked += new EventHandler(toggleSwitch24_Click);
            peopleSw.ToggleClicked += new EventHandler(toggleSwitch25_Click);
            adsSw.ToggleClicked += new EventHandler(toggleSwitch26_Click);
            xboxSw.ToggleClicked += new EventHandler(toggleSwitch17_Click);
            cortanaSw.ToggleClicked += new EventHandler(toggleSwitch16_Click);
            gameBarSw.ToggleClicked += new EventHandler(toggleSwitch15_Click);
            uODSw.ToggleClicked += new EventHandler(toggleSwitch14_Click);
            oldMixerSw.ToggleClicked += new EventHandler(toggleSwitch13_Click);
            disableOneDriveSw.ToggleClicked += new EventHandler(toggleSwitch31_Click);
            oldExplorerSw.ToggleClicked += new EventHandler(toggleSwitch18_Click);
            compatSw.ToggleClicked += new EventHandler(toggleSwitch32_Click);
            faxSw.ToggleClicked += new EventHandler(ToggleSwitch33_Click);
            insiderSw.ToggleClicked += new EventHandler(ToggleSwitch34_Click);
            storeUpdatesSw.ToggleClicked += new EventHandler(ToggleSwitch35_Click);
            smartScreenSw.ToggleClicked += new EventHandler(ToggleSwitch36_Click);
            ccSw.ToggleClicked += new EventHandler(ToggleSwitch37_Click);
            stickySw.ToggleClicked += new EventHandler(ToggleSwitch38_Click);
            longPathsSw.ToggleClicked += new EventHandler(ToggleSwitch39_Click);
            castSw.ToggleClicked += new EventHandler(ToggleSwitch40_Click);
            leftTaskbarSw.ToggleClicked += new EventHandler(LeftTaskbarSw_Click);
            snapAssistSw.ToggleClicked += new EventHandler(SnapAssistSw_Click);
            widgetsSw.ToggleClicked += new EventHandler(WidgetsSw_Click);
            smallerTaskbarSw.ToggleClicked += new EventHandler(SmallerTaskbarSw_Click);
            chatSw.ToggleClicked += new EventHandler(chatSw_Click);
            stickersSw.ToggleClicked += new EventHandler(StickersSw_ToggleClicked);
            classicRibbonSw.ToggleClicked += new EventHandler(ClassicRibbonSw_Click);
            classicContextSw.ToggleClicked += new EventHandler(ClassicContextSw_Click);
            ffTelemetrySw.ToggleClicked += new EventHandler(FfTelemetrySw_ToggleClicked);
            chromeTelemetrySw.ToggleClicked += new EventHandler(ChromeTelemetrySw_ToggleClicked);
            vsSw.ToggleClicked += new EventHandler(VsSw_ToggleClicked);
            gameModeSw.ToggleClicked += new EventHandler(GameModeSw_ToggleClicked);
            compactModeSw.ToggleClicked += CompactModeSw_ToggleClicked;
            tpmSw.ToggleClicked += TpmSw_ToggleClicked;
            hibernateSw.ToggleClicked += HibernateSw_ToggleClicked;
            smb1Sw.ToggleClicked += Smb1Sw_ToggleClicked;
            smb2Sw.ToggleClicked += Smb2Sw_ToggleClicked;
            ntfsStampSw.ToggleClicked += NtfsStampSw_ToggleClicked;
            winSearchSw.ToggleClicked += WinSearchSw_ToggleClicked;
            nvidiaTelemetrySw.ToggleClicked += NvidiaTelemetrySw_ToggleClicked;
            vbsSw.ToggleClicked += VbsSw_ToggleClicked;

            PMB.ToggleClicked += PMB_ToggleClicked;
            SSB.ToggleClicked += SSB_ToggleClicked;
            WAB.ToggleClicked += WAB_ToggleClicked;
            STB.ToggleClicked += STB_ToggleClicked;
            DSB.ToggleClicked += DSB_ToggleClicked;
            AddCMDB.ToggleClicked += AddCMDB_ToggleClicked;
            AddOwnerB.ToggleClicked += AddOwnerB_ToggleClicked;
        }

        private void WinSearchSw_ToggleClicked(object sender, EventArgs e)
        {
            if (winSearchSw.ToggleChecked)
            {
                Optimize.DisableSearch();
            }
            else
            {
                Optimize.EnableSearch();
            }
            Options.CurrentOptions.DisableSearch = winSearchSw.ToggleChecked;
        }

        private void VbsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (vbsSw.ToggleChecked)
            {
                Optimize.DisableVirtualizationBasedSecurity();
            }
            else
            {
                Optimize.EnableVirtualizationBasedSecurity();
            }
            Options.CurrentOptions.DisableVBS = vbsSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void NvidiaTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (nvidiaTelemetrySw.ToggleChecked)
            {
                Optimize.DisableNvidiaTelemetry();
            }
            else
            {
                Optimize.EnableNvidiaTelemetry();
            }
            Options.CurrentOptions.DisableNVIDIATelemetry = nvidiaTelemetrySw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void NtfsStampSw_ToggleClicked(object sender, EventArgs e)
        {
            if (ntfsStampSw.ToggleChecked)
            {
                Optimize.DisableNTFSTimeStamp();
            }
            else
            {
                Optimize.EnableNTFSTimeStamp();
            }
            Options.CurrentOptions.DisableNTFSTimeStamp = ntfsStampSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void Smb2Sw_ToggleClicked(object sender, EventArgs e)
        {
            if (smb2Sw.ToggleChecked)
            {
                Optimize.DisableSMB("2");
            }
            else
            {
                Optimize.EnableSMB("2");
            }
            Options.CurrentOptions.DisableSMB2 = smb2Sw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void Smb1Sw_ToggleClicked(object sender, EventArgs e)
        {
            if (smb1Sw.ToggleChecked)
            {
                Optimize.DisableSMB("1");
            }
            else
            {
                Optimize.EnableSMB("1");
            }
            Options.CurrentOptions.DisableSMB1 = smb1Sw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void HibernateSw_ToggleClicked(object sender, EventArgs e)
        {
            if (hibernateSw.ToggleChecked)
            {
                Utilities.DisableHibernation();
            }
            else
            {
                Utilities.EnableHibernation();
            }
            Options.CurrentOptions.DisableHibernation = hibernateSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void StickersSw_ToggleClicked(object sender, EventArgs e)
        {
            if (stickersSw.ToggleChecked)
            {
                Optimize.DisableStickers();
            }
            else
            {
                Optimize.EnableStickers();
            }
            Options.CurrentOptions.DisableStickers = stickersSw.ToggleChecked;
        }

        private void TpmSw_ToggleClicked(object sender, EventArgs e)
        {
            if (tpmSw.ToggleChecked)
            {
                Optimize.DisableTPMCheck();
            }
            else
            {
                Optimize.EnableTPMCheck();
            }
            Options.CurrentOptions.DisableTPMCheck = tpmSw.ToggleChecked;
        }

        private void CompactModeSw_ToggleClicked(object sender, EventArgs e)
        {
            if (compactModeSw.ToggleChecked)
            {
                Optimize.EnableFilesCompactMode();
            }
            else
            {
                Optimize.DisableFilesCompactMode();
            }
            Options.CurrentOptions.CompactMode = compactModeSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void GameModeSw_ToggleClicked(object sender, EventArgs e)
        {
            if (gameModeSw.ToggleChecked)
            {
                Optimize.EnableGamingMode();
            }
            else
            {
                Optimize.DisableGamingMode();
            }
            Options.CurrentOptions.EnableGamingMode = gameModeSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void VsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (vsSw.ToggleChecked)
            {
                Optimize.DisableVisualStudioTelemetry();
            }
            else
            {
                Optimize.EnableVisualStudioTelemetry();
            }
            Options.CurrentOptions.DisableVisualStudioTelemetry = vsSw.ToggleChecked;
        }

        private void ChromeTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (chromeTelemetrySw.ToggleChecked)
            {
                Optimize.DisableChromeTelemetry();
            }
            else
            {
                Optimize.EnableChromeTelemetry();
            }
            Options.CurrentOptions.DisableChromeTelemetry = chromeTelemetrySw.ToggleChecked;
        }

        private void FfTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (ffTelemetrySw.ToggleChecked)
            {
                Optimize.DisableFirefoxTelemetry();
            }
            else
            {
                Optimize.EnableFirefoxTelemetry();
            }
            Options.CurrentOptions.DisableFirefoxTemeletry = ffTelemetrySw.ToggleChecked;
        }

        private void ClassicContextSw_Click(object sender, EventArgs e)
        {
            if (classicContextSw.ToggleChecked)
            {
                Optimize.DisableShowMoreOptions();
            }
            else
            {
                Optimize.EnableShowMoreOptions();
            }
            Options.CurrentOptions.ClassicMenu = classicContextSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void ClassicRibbonSw_Click(object sender, EventArgs e)
        {
            if (classicRibbonSw.ToggleChecked)
            {
                Optimize.EnableFileExplorerClassicRibbon();
            }
            else
            {
                Optimize.DisableFileExplorerClassicRibbon();
            }
            Options.CurrentOptions.ClassicRibbon = classicContextSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void chatSw_Click(object sender, EventArgs e)
        {
            if (chatSw.ToggleChecked)
            {
                Optimize.DisableChat();
            }
            else
            {
                Optimize.EnableChat();
            }
            Options.CurrentOptions.DisableChat = chatSw.ToggleChecked;
        }

        private void SmallerTaskbarSw_Click(object sender, EventArgs e)
        {
            if (smallerTaskbarSw.ToggleChecked)
            {
                Optimize.SmallerTaskbar();
            }
            else
            {
                Optimize.DefaultTaskbarSize();
            }
            Options.CurrentOptions.TaskbarSmaller = smallerTaskbarSw.ToggleChecked;
        }

        private void WidgetsSw_Click(object sender, EventArgs e)
        {
            if (widgetsSw.ToggleChecked)
            {
                Optimize.DisableWidgets();
            }
            else
            {
                Optimize.EnableWidgets();
            }
            Options.CurrentOptions.DisableWidgets = widgetsSw.ToggleChecked;
        }

        private void SnapAssistSw_Click(object sender, EventArgs e)
        {
            if (snapAssistSw.ToggleChecked)
            {
                Optimize.DisableSnapAssist();
            }
            else
            {
                Optimize.EnableSnapAssist();
            }
            Options.CurrentOptions.DisableSnapAssist = snapAssistSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void LeftTaskbarSw_Click(object sender, EventArgs e)
        {
            if (leftTaskbarSw.ToggleChecked)
            {
                Optimize.AlignTaskbarToLeft();
            }
            else
            {
                Optimize.AlignTaskbarToCenter();
            }
            Options.CurrentOptions.TaskbarToLeft = leftTaskbarSw.ToggleChecked;
        }

        private void TranslateTips()
        {
            performanceSw.Label.Tag = Options.TranslationList["performanceTip"].ToString();
            networkSw.Label.Tag = Options.TranslationList["networkTip"].ToString();
            defenderSw.Label.Tag = Options.TranslationList["defenderTip"].ToString();
            smartScreenSw.Label.Tag = Options.TranslationList["smartScreenTip"].ToString();
            systemRestoreSw.Label.Tag = Options.TranslationList["systemRestoreTip"].ToString();
            reportingSw.Label.Tag = Options.TranslationList["reportingTip"].ToString();
            telemetryTasksSw.Label.Tag = Options.TranslationList["telemetryTasksTip"].ToString();
            officeTelemetrySw.Label.Tag = Options.TranslationList["officeTelemetryTip"].ToString();
            printSw.Label.Tag = Options.TranslationList["printTip"].ToString();
            faxSw.Label.Tag = Options.TranslationList["faxTip"].ToString();
            mediaSharingSw.Label.Tag = Options.TranslationList["mediaSharingTip"].ToString();
            stickySw.Label.Tag = Options.TranslationList["stickyTip"].ToString();
            homegroupSw.Label.Tag = Options.TranslationList["homegroupTip"].ToString();
            superfetchSw.Label.Tag = Options.TranslationList["superfetchTip"].ToString();
            compatSw.Label.Tag = Options.TranslationList["compatTip"].ToString();
            disableOneDriveSw.Label.Tag = Options.TranslationList["disableOneDriveTip"].ToString();
            oldMixerSw.Label.Tag = Options.TranslationList["oldMixerTip"].ToString();
            oldExplorerSw.Label.Tag = Options.TranslationList["oldExplorerTip"].ToString();
            adsSw.Label.Tag = Options.TranslationList["adsTip"].ToString();
            uODSw.Label.Tag = Options.TranslationList["uODTip"].ToString();
            peopleSw.Label.Tag = Options.TranslationList["peopleTip"].ToString();
            longPathsSw.Label.Tag = Options.TranslationList["longPathsTip"].ToString();
            inkSw.Label.Tag = Options.TranslationList["inkTip"].ToString();
            spellSw.Label.Tag = Options.TranslationList["spellTip"].ToString();
            xboxSw.Label.Tag = Options.TranslationList["xboxTip"].ToString();
            autoUpdatesSw.Label.Tag = Options.TranslationList["autoUpdatesTip"].ToString();
            driversSw.Label.Tag = Options.TranslationList["driversTip"].ToString();
            telemetryServicesSw.Label.Tag = Options.TranslationList["telemetryServicesTip"].ToString();
            privacySw.Label.Tag = Options.TranslationList["privacyTip"].ToString();
            ccSw.Label.Tag = Options.TranslationList["ccTip"].ToString();
            cortanaSw.Label.Tag = Options.TranslationList["cortanaTip"].ToString();
            sensorSw.Label.Tag = Options.TranslationList["sensorTip"].ToString();
            castSw.Label.Tag = Options.TranslationList["castTip"].ToString();
            gameBarSw.Label.Tag = Options.TranslationList["gameBarTip"].ToString();
            insiderSw.Label.Tag = Options.TranslationList["insiderTip"].ToString();
            storeUpdatesSw.Label.Tag = Options.TranslationList["storeUpdatesTip"].ToString();
            tpmSw.Label.Tag = Options.TranslationList["tpmTip"].ToString();
            leftTaskbarSw.Label.Tag = Options.TranslationList["leftTaskbarTip"].ToString();
            snapAssistSw.Label.Tag = Options.TranslationList["snapAssistTip"].ToString();
            widgetsSw.Label.Tag = Options.TranslationList["widgetsTip"].ToString();
            chatSw.Label.Tag = Options.TranslationList["chatTip"].ToString();
            stickersSw.Label.Tag = Options.TranslationList["stickersTip"].ToString();
            smallerTaskbarSw.Label.Tag = Options.TranslationList["smallerTaskbarTip"].ToString();
            classicRibbonSw.Label.Tag = Options.TranslationList["classicRibbonTip"].ToString();
            classicContextSw.Label.Tag = Options.TranslationList["classicContextTip"].ToString();
            picUpdate.Tag = Options.TranslationList["linkUpdate"].ToString() + "!";
            picLab.Tag = Options.TranslationList["lblLab"].ToString();
            picRestartNeeded.Tag = Options.TranslationList["restartAndApply"].ToString();
            ffTelemetrySw.Label.Tag = Options.TranslationList["ffTelemetryTip"].ToString();
            vsSw.Label.Tag = Options.TranslationList["vsTip"].ToString();
            chromeTelemetrySw.Label.Tag = Options.TranslationList["chromeTelemetryTip"].ToString();
            gameModeSw.Label.Tag = Options.TranslationList["gameModeTip"].ToString();
            compactModeSw.Label.Tag = Options.TranslationList["compactModeTip"].ToString();
            hibernateSw.Label.Tag = Options.TranslationList["hibernateTip"].ToString();
            winSearchSw.Label.Tag = Options.TranslationList["winSearchTip"].ToString();
            smb1Sw.Label.Tag = Options.TranslationList["smbTip"].ToString().Replace("{v}", "v1");
            smb2Sw.Label.Tag = Options.TranslationList["smbTip"].ToString().Replace("{v}", "v2");
            ntfsStampSw.Label.Tag = Options.TranslationList["ntfsStampTip"].ToString();
            nvidiaTelemetrySw.Label.Tag = Options.TranslationList["nvidiaTelemetrySw"].ToString();
            vbsSw.Label.Tag = Options.TranslationList["vbsTip"].ToString();
        }

        private void ToggleSwitch40_Click(object sender, EventArgs e)
        {
            if (castSw.ToggleChecked)
            {
                Optimize.RemoveCastToDevice();
            }
            else
            {
                Optimize.AddCastToDevice();
            }
            Options.CurrentOptions.RemoveCastToDevice = castSw.ToggleChecked;
        }

        private void ToggleSwitch39_Click(object sender, EventArgs e)
        {
            if (longPathsSw.ToggleChecked)
            {
                Optimize.EnableLongPaths();
            }
            else
            {
                Optimize.DisableLongPaths();
            }
            Options.CurrentOptions.EnableLongPaths = longPathsSw.ToggleChecked;
        }

        private void ToggleSwitch38_Click(object sender, EventArgs e)
        {
            if (stickySw.ToggleChecked)
            {
                Optimize.DisableStickyKeys();
            }
            else
            {
                Optimize.EnableStickyKeys();
            }
            Options.CurrentOptions.DisableStickyKeys = stickySw.ToggleChecked;
        }

        private void ToggleSwitch37_Click(object sender, EventArgs e)
        {
            if (ccSw.ToggleChecked)
            {
                Optimize.DisableCloudClipboard();
            }
            else
            {
                Optimize.EnableCloudClipboard();
            }
            Options.CurrentOptions.DisableCloudClipboard = ccSw.ToggleChecked;
        }

        private void ToggleSwitch36_Click(object sender, EventArgs e)
        {
            if (smartScreenSw.ToggleChecked)
            {
                Optimize.DisableSmartScreen();
            }
            else
            {
                Optimize.EnableSmartScreen();
            }
            Options.CurrentOptions.DisableSmartScreen = smartScreenSw.ToggleChecked;
        }

        private void ToggleSwitch35_Click(object sender, EventArgs e)
        {
            if (storeUpdatesSw.ToggleChecked)
            {
                Optimize.DisableStoreUpdates();
            }
            else
            {
                Optimize.EnableStoreUpdates();
            }
            Options.CurrentOptions.DisableStoreUpdates = storeUpdatesSw.ToggleChecked;
        }

        private void ToggleSwitch34_Click(object sender, EventArgs e)
        {
            if (insiderSw.ToggleChecked)
            {
                Optimize.DisableInsiderService();
            }
            else
            {
                Optimize.EnableInsiderService();
            }
            Options.CurrentOptions.DisableInsiderService = insiderSw.ToggleChecked;
        }

        private void ToggleSwitch33_Click(object sender, EventArgs e)
        {
            if (faxSw.ToggleChecked)
            {
                Optimize.DisableFaxService();
            }
            else
            {
                Optimize.EnableFaxService();
            }
            Options.CurrentOptions.DisableFaxService = faxSw.ToggleChecked;
        }

        //INIT
        public MainForm(SplashForm _splashForm, bool disableIndicium = false, bool disableHostsEditor = false, bool disableCommonApps = false, bool disableUWPApps = false, bool disableStartups = false, bool disableCleaner = false, bool disableIntegrator = false, bool disablePinger = false)
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            CheckForIllegalCrossThreadCalls = false;

            _splashForm.LoadingStatus.Text = "checking for requirements";

            // theming
            Options.ApplyTheme(this);
            pictureBox1.BackColor = Options.CurrentOptions.Theme;
            colorPicker1.Color = Options.CurrentOptions.Theme;

            launcherMenu.Renderer = new MoonMenuRenderer();
            indiciumMenu.Renderer = new MoonMenuRenderer();

            progressDownloader.BackColor = Options.ForegroundColor;
            progressDownloader.ForeColor = Options.ForegroundAccentColor;

            // quick access
            _trayMenu = Options.CurrentOptions.EnableTray;
            quickAccessToggle.ToggleChecked = Options.CurrentOptions.EnableTray;
            launcherIcon.Visible = Options.CurrentOptions.EnableTray;
            autoStartToggle.ToggleChecked = Options.CurrentOptions.AutoStart;
            telemetrySvcToggle.ToggleChecked = Options.CurrentOptions.DisableOptimizerTelemetry;

            //seperatorNetMon.Visible = Options.CurrentOptions.EnableTray;
            //trayDownSpeed.Visible = Options.CurrentOptions.EnableTray;
            //trayUpSpeed.Visible = Options.CurrentOptions.EnableTray;

            // fix SSL/TLS error when contacting internet
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // initial states
            checkDefaultIcon.Checked = true;
            radioProgram.Checked = true;
            radioTop.Checked = true;
            c64.Checked = Environment.Is64BitOperatingSystem;
            c32.Checked = !Environment.Is64BitOperatingSystem;

            // Windows version, architecture, .NET Framework
            txtOS.Text = Utilities.GetOS();
            txtBitness.Text = Utilities.GetBitness();
            txtNetFw.Text = ".NET Framework " + Utilities.GetNETFramework();

            // system color overriding
            _colorOverrider = new ColorOverrider();
            _colorOverrider.SetColor(KnownColor.Highlight, Color.FromArgb(50, 50, 50).ToArgb());
            _colorOverrider.SetColor(KnownColor.HighlightText, Color.White.ToArgb());

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Unsupported)
            {
                tabCollection.TabPages.Remove(universalTab);
                tabCollection.TabPages.Remove(windows8Tab);
                tabCollection.TabPages.Remove(windows10Tab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
            {
                LoadUniversalToggleStates();

                tabCollection.TabPages.Remove(windows8Tab);
                tabCollection.TabPages.Remove(windows10Tab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
            {
                LoadUniversalToggleStates();
                LoadWindowsVIIIToggleStates();

                tabCollection.TabPages.Remove(windows10Tab);

                if (!disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
            {
                LoadUniversalToggleStates();
                LoadWindowsXToggleStates();

                tabCollection.TabPages.Remove(windows8Tab);
                defenderSw.Visible = false;
                vbsSw.Visible = false;
                oldMixerSw.Visible = true;
                this.Controls.Remove(panelWin11Tweaks);

                if (!disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
            {
                LoadUniversalToggleStates();
                LoadWindowsXToggleStates();
                LoadWindowsXIToggleStates();

                tabCollection.TabPages.Remove(windows8Tab);
                windows10Tab.Text = "Windows 11";
                defenderSw.Visible = false;
                vbsSw.Visible = true;
                panelWin11Tweaks.Visible = true;
                oldMixerSw.Visible = false;

                if (!disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            // Show Uninstall OneDrive ONLY in UNSAFE MODE!
            // Reasons should be apparent by now...
            uODSw.Visible = Program.UNSAFE_MODE;

            _splashForm.LoadingStatus.Text = "loading startup && hosts items";

            _columnSorter = new ListViewColumnSorter();
            listStartupItems.ListViewItemSorter = _columnSorter;

            specsTree.ImageList = imagesHw;

            // STARTUP ITEMS
            if (!disableStartups)
            {
                GetStartupItems();
            }
            else
            {
                tabCollection.TabPages.Remove(startupTab);
                launcherMenu.Items.RemoveByKey("trayStartup");
            }

            // HOSTS EDITOR
            if (!disableHostsEditor)
            {
                GetHostsEntries();
            }
            else
            {
                tabCollection.TabPages.Remove(hostsEditorTab);
                launcherMenu.Items.RemoveByKey("trayHosts");
            }

            // INTEGRATOR
            if (!disableIntegrator)
            {
                LoadReadyMenusState();
                GetDesktopItems();
                GetCustomCommands();
            }
            else
            {
                tabCollection.TabPages.Remove(integratorTab);
            }

            _splashForm.LoadingStatus.Text = "fetching feed";

            // APPS DOWNLOADER
            if (!disableCommonApps)
            {
                GetFeed();
            }
            else
            {
                tabCollection.TabPages.Remove(appsTab);
                launcherMenu.Items.RemoveByKey("trayAD");
            }

            // CLEANER
            if (!disableCleaner)
            {
                GetFootprint();
            }
            else
            {
                tabCollection.TabPages.Remove(cleanerTab);
                launcherMenu.Items.RemoveByKey("trayCleaner");
            }

            _splashForm.LoadingStatus.Text = "inspecting hardware";

            // INDICIUM
            if (!disableIndicium)
            {
                GetHardwareSpecs();
            }
            else
            {
                tabCollection.TabPages.Remove(indiciumTab);
                launcherMenu.Items.RemoveByKey("trayHW");
            }

            // PINGER
            if (!disablePinger)
            {
                LoadPingerDNSConfig();
                DisplayCurrentDNS();

                boxDNS.SelectedIndexChanged += boxDNS_SelectedIndexChanged;
                boxAdapter.SelectedIndexChanged += boxAdapter_SelectedIndexChanged;
            }
            else
            {
                tabCollection.TabPages.Remove(pingerTab);
                launcherMenu.Items.RemoveByKey("trayPinger");
            }

            Program._MainForm = this;

            if (string.IsNullOrEmpty(Options.CurrentOptions.AppsFolder))
            {
                txtDownloadFolder.Text = Path.Combine(Application.StartupPath, "OptimizerDownloads");
                Options.CurrentOptions.AppsFolder = Path.Combine(Application.StartupPath, "OptimizerDownloads");
                Directory.CreateDirectory(Options.CurrentOptions.AppsFolder);
                Options.SaveSettings();
            }
            else
            {
                if (!Directory.Exists(Options.CurrentOptions.AppsFolder))
                {
                    try
                    {
                        Directory.CreateDirectory(Options.CurrentOptions.AppsFolder);
                    }
                    catch (Exception ex)
                    {
                        txtDownloadFolder.Text = string.Empty;
                        ErrorLogger.LogError("MainForm.INIT", ex.Message, ex.StackTrace);
                    }
                }
                txtDownloadFolder.Text = Options.CurrentOptions.AppsFolder;
            }

            if (!Program.EXPERIMENTAL_BUILD && PingerHelper.IsInternetAvailable())
            {
                CheckForUpdate(true);
            }

            if (Program.EXPERIMENTAL_BUILD)
            {
                btnUpdate.Enabled = false;
                picLab.Visible = true;
            }

            LoadTranslationAndSetSize();
            //InitNetworkMonitoring();
            EnableToggleEvents();

            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadReadyMenusState()
        {
            AddCMDB.ToggleChecked = Integrator.OpenWithCMDExists();
            AddOwnerB.ToggleChecked = Integrator.TakeOwnershipExists();
            DSB.ToggleChecked = Integrator.DesktopItemExists("DesktopShortcuts");
            PMB.ToggleChecked = Integrator.DesktopItemExists("Power Menu");
            SSB.ToggleChecked = Integrator.DesktopItemExists("SystemShortcuts");
            STB.ToggleChecked = Integrator.DesktopItemExists("SystemTools");
            WAB.ToggleChecked = Integrator.DesktopItemExists("WindowsApps");
        }

        private void LoadPingerDNSConfig()
        {
            NetworkInterface[] nics = PingerHelper.GetActiveNetworkAdapters();
            if (nics == null) return;
            if (nics.Length == 0) return;

            boxAdapter.Items.AddRange(nics.Select(z => z.Description).ToArray());
            if (boxAdapter.Items.Count > 0) boxAdapter.SelectedIndex = 0;

            linkDNSv4.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv4A.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6A.LinkClicked += linkDNSIP_LinkClicked;

            LoadNetworkAdapterConfig();
        }

        private void LoadNetworkAdapterConfig()
        {
            if (boxAdapter.Items.Count <= 0) return;

            PingerHelper.GetActiveNetworkAdapters();
            if (PingerHelper.NetworkAdapters == null) return;
            if (PingerHelper.NetworkAdapters.Length == 0) return;

            _currentDNS = PingerHelper.GetDNSFromNetworkAdapter(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();
            if (_currentDNS == null) return;
            if (_currentDNS.Length == 0) return;

            if (PingerHelper.CloudflareDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Cloudflare DNS";
                return;
            }
            else if (PingerHelper.OpenDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Open DNS";
                return;
            }
            else if (PingerHelper.Quad9DNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Quad9 DNS";
                return;
            }
            else if (PingerHelper.GoogleDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Google DNS";
                return;
            }
            else if (PingerHelper.AlternateDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Alternate DNS";
                return;
            }
            else if (PingerHelper.AdguardDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "Adguard DNS";
                return;
            }
            else if (PingerHelper.CleanBrowsingDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "CleanBrowsing";
                return;
            }
            else if (PingerHelper.CleanBrowsingAdultDNSv4.Any(x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = "CleanBrowsing (adult filter)";
                return;
            }
            else
            {
                boxDNS.Text = "Automatic";
                return;
            }
        }

        private void LoadTranslationAndSetSize()
        {
            if (Options.CurrentOptions.LanguageCode == LanguageCode.EN)
            {
                boxLang.Text = "English";
                Translate(true);
            }
            else
            {
                Translate();
            }

            // set default window size to fit content
            if (Options.CurrentOptions.LanguageCode == LanguageCode.RU)
            {
                boxLang.Text = "русский";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.TR)
            {
                boxLang.Text = "Türkçe";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.EL)
            {
                boxLang.Text = "Ελληνικά";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.DE)
            {
                boxLang.Text = "Deutsch";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.PT)
            {
                boxLang.Text = "Português";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.FR)
            {
                boxLang.Text = "Français";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.ES)
            {
                boxLang.Text = "Español";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.IT)
            {
                boxLang.Text = "Italiano";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.CN)
            {
                boxLang.Text = "简体中文";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.TW)
            {
                boxLang.Text = "繁體中文";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.CZ)
            {
                boxLang.Text = "Čeština";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.KO)
            {
                boxLang.Text = "한국어";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.PL)
            {
                boxLang.Text = "Polski";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.AR)
            {
                boxLang.Text = "العربية";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.KU)
            {
                boxLang.Text = "کوردی";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.HU)
            {
                boxLang.Text = "Magyar";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.RO)
            {
                boxLang.Text = "Română";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.NL)
            {
                boxLang.Text = "Nederlands";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.UA)
            {
                boxLang.Text = "українська";
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.JA)
            {
                boxLang.Text = "日本語";
            }
        }

        private void GetHardwareSpecs()
        {
            GetCPUs();
            GetRAM();
            GetGPUs();
            GetMotherboards();
            GetStorage();
            GetNetworkAdapters();
            GetAudioDevices();
            GetPeripherals();
            GetOSInfo();

            _hwDetailed = specsTree.Nodes.Cast<TreeNode>().ToList();
            _hwSummarized = BuildHardwareSummaryNodes();

            specsTree.ExpandAll();
            if (specsTree.Nodes.Count > 0) specsTree.Nodes[0].EnsureVisible();

        }

        private TreeNode[] BuildHardwareSummaryNodes()
        {
            TreeNode osNode = new TreeNode("Operating System");
            osNode.Name = "os";
            osNode.Tag = _primaryItemTag;
            osNode.SelectedImageIndex = 8;
            HardwareSummary.OSInfo.ForEach(x => osNode.Nodes.Add(x));

            TreeNode cpuNode = new TreeNode("Processors");
            cpuNode.Name = "scpu";
            cpuNode.Tag = _primaryItemTag;
            cpuNode.SelectedImageIndex = 0;
            HardwareSummary.CPUs.ForEach(x => cpuNode.Nodes.Add(x));

            TreeNode ramNode = new TreeNode("Memory");
            ramNode.Name = "sram";
            ramNode.Tag = _primaryItemTag;
            ramNode.SelectedImageIndex = 1;
            ramNode.Nodes.Add(HardwareSummary.TotalRAM);

            TreeNode moboNode = new TreeNode("Motherboards");
            moboNode.Name = "smobo";
            moboNode.Tag = _primaryItemTag;
            moboNode.SelectedImageIndex = 3;
            HardwareSummary.Motherboards.ForEach(x => moboNode.Nodes.Add(x));

            TreeNode gpuNode = new TreeNode("Graphics");
            gpuNode.Name = "sgpu";
            gpuNode.Tag = _primaryItemTag;
            gpuNode.SelectedImageIndex = 2;
            HardwareSummary.GPUs.ForEach(x => gpuNode.Nodes.Add(x));

            TreeNode diskNode = new TreeNode("Disk Drives");
            diskNode.Name = "sdisk";
            diskNode.Tag = _primaryItemTag;
            diskNode.SelectedImageIndex = 4;
            HardwareSummary.Disks.ForEach(x => diskNode.Nodes.Add(x));

            TreeNode networkNode = new TreeNode("Network Adapters");
            networkNode.Name = "sinet";
            networkNode.Tag = _primaryItemTag;
            networkNode.SelectedImageIndex = 5;
            HardwareSummary.NetworkAdapters.ForEach(x => networkNode.Nodes.Add(x));

            TreeNode biosNode = new TreeNode("BIOS");
            biosNode.Tag = _primaryItemTag;
            biosNode.SelectedImageIndex = 3;
            HardwareSummary.BIOS.ForEach(x => biosNode.Nodes.Add(x));

            return new TreeNode[]
            {
                osNode, cpuNode, ramNode, moboNode, gpuNode, diskNode, networkNode, biosNode
            };
        }

        private void GetOSInfo()
        {
            HardwareSummary.OSInfo.Add($"{Utilities.GetOS()} ({(Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit")})");
            if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
                HardwareSummary.OSInfo.Add($"Desktop ({Environment.MachineName})");
            }
            else
            {
                HardwareSummary.OSInfo.Add($"Laptop ({Environment.MachineName})");
            }
        }

        private void GetAudioDevices()
        {
            List<AudioDevice> audios = IndiciumHelper.GetAudioDevices();

            if (audios.Count > 0)
            {
                foreach (AudioDevice device in audios)
                {
                    TreeNode node = new TreeNode(device.ProductName);

                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Manufacturer: " + device.Manufacturer);
                    node.Nodes.Add("Status: " + device.Status);
                    specsTree.Nodes["audio"].Nodes.Add(node);
                }
            }
        }

        private void GetPeripherals()
        {
            IndiciumHelper.GetPeripherals();

            if (IndiciumHelper.Keyboards.Count > 0)
            {
                TreeNode kbNodes = new TreeNode("Keyboards");
                kbNodes.Name = "keyboards";

                foreach (Keyboard keyboard in IndiciumHelper.Keyboards)
                {
                    TreeNode node = new TreeNode(keyboard.Name);
                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Layout: " + keyboard.Layout);
                    node.Nodes.Add("Function Keys: " + keyboard.FunctionKeys);
                    node.Nodes.Add("Status: " + keyboard.Status);
                    node.Nodes.Add("Locked: " + keyboard.Locked);
                    kbNodes.Nodes.Add(node);
                }
                specsTree.Nodes["dev"].Nodes.Add(kbNodes);
            }

            if (IndiciumHelper.PointingDevices.Count > 0)
            {
                TreeNode pdNodes = new TreeNode("Pointing Devices");
                pdNodes.Name = "pointings";

                foreach (PointingDevice pointingDevice in IndiciumHelper.PointingDevices)
                {
                    TreeNode node = new TreeNode(pointingDevice.Name);
                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Manufacturer: " + pointingDevice.Manufacturer);
                    node.Nodes.Add("Buttons: " + pointingDevice.Buttons);
                    node.Nodes.Add("Pointing Type: " + pointingDevice.PointingType);
                    node.Nodes.Add("Device Interface: " + pointingDevice.DeviceInterface);
                    node.Nodes.Add("Hardware Type: " + pointingDevice.HardwareType);
                    node.Nodes.Add("Status: " + pointingDevice.Status);
                    node.Nodes.Add("Locked: " + pointingDevice.Locked);
                    pdNodes.Nodes.Add(node);
                }
                specsTree.Nodes["dev"].Nodes.Add(pdNodes);
            }
        }

        private void GetNetworkAdapters()
        {
            IndiciumHelper.GetNetworkAdapters();

            if (IndiciumHelper.PhysicalAdapters.Count > 0)
            {
                TreeNode physicalsNode = new TreeNode("Physical Adapters");
                physicalsNode.Name = "physicalAdapters";

                foreach (NetworkDevice adapter in IndiciumHelper.PhysicalAdapters)
                {
                    TreeNode node = new TreeNode(adapter.ProductName);
                    HardwareSummary.NetworkAdapters.Add(adapter.ProductName);

                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Manufacturer: " + adapter.Manufacturer);
                    node.Nodes.Add("Adapter Type: " + adapter.AdapterType);
                    node.Nodes.Add("MAC Address: " + adapter.MacAddress);
                    //node.Nodes.Add("Physical Adapter: " + adapter.PhysicalAdapter);
                    node.Nodes.Add("Service Name: " + adapter.ServiceName);
                    physicalsNode.Nodes.Add(node);
                }
                specsTree.Nodes["inet"].Nodes.Add(physicalsNode);
            }

            if (IndiciumHelper.VirtualAdapters.Count > 0)
            {
                TreeNode virtualsNode = new TreeNode("Virtual Adapters");
                virtualsNode.Name = "virtualAdapters";

                foreach (NetworkDevice adapter in IndiciumHelper.VirtualAdapters)
                {
                    TreeNode node = new TreeNode(adapter.ProductName);

                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Manufacturer: " + adapter.Manufacturer);
                    node.Nodes.Add("Adapter Type: " + adapter.AdapterType);
                    node.Nodes.Add("MAC Address: " + adapter.MacAddress);
                    //node.Nodes.Add("Physical Adapter: " + adapter.PhysicalAdapter);
                    node.Nodes.Add("Service Name: " + adapter.ServiceName);
                    virtualsNode.Nodes.Add(node);
                }
                specsTree.Nodes["inet"].Nodes.Add(virtualsNode);
            }
        }

        private void GetStorage()
        {
            List<Disk> disks = IndiciumHelper.GetDisks();
            IndiciumHelper.GetVolumes();

            if (disks.Count > 0)
            {
                TreeNode disksNode = new TreeNode("Disk Drives");
                disksNode.Name = "drives";

                foreach (Disk disk in disks)
                {
                    TreeNode node = new TreeNode(disk.Model);
                    node.Tag = _primaryItemTag;

                    if (disk.Capacity.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Size: " + disk.Capacity);
                        HardwareSummary.Disks.Add($"{disk.Model} ({disk.Capacity})");
                    }
                    else
                    {
                        node.Nodes.Add("Size: -");
                    }
                    node.Nodes.Add("Firmware Revision: " + disk.FirmwareRevision);
                    node.Nodes.Add("Media Type: " + disk.MediaType);
                    node.Nodes.Add("Bytes/Sector: " + disk.BytesPerSector);

                    disksNode.Nodes.Add(node);
                }
                specsTree.Nodes["disk"].Nodes.Add(disksNode);
            }

            if (IndiciumHelper.Opticals.Count > 0)
            {
                TreeNode opticalsNode = new TreeNode("Optical Drives");
                opticalsNode.Name = "opticals";

                foreach (Volume optical in IndiciumHelper.Opticals)
                {
                    string tmp = string.Empty;
                    if (!string.IsNullOrEmpty(optical.DriveLetter))
                    {
                        tmp = " (" + optical.DriveLetter + ")";
                    }
                    else
                    {
                        tmp = "-";
                    }

                    TreeNode node = new TreeNode(optical.Label + tmp);
                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("File System: " + optical.FileSystem);

                    if (optical.Capacity.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Size: " + optical.Capacity);
                    }
                    else
                    {
                        node.Nodes.Add("Size: -");
                    }
                    if (optical.UsedSpace.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Used Space: " + optical.UsedSpace);
                    }
                    else
                    {
                        node.Nodes.Add("Used Space: -");
                    }
                    if (optical.FreeSpace.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Free Space: " + optical.FreeSpace);
                    }
                    else
                    {
                        node.Nodes.Add("Free Space: -");
                    }
                    node.Nodes.Add("Indexing: " + optical.Indexing);
                    node.Nodes.Add("Compressed: " + optical.Compressed);
                    node.Nodes.Add("Drive Type: " + optical.DriveType);
                    node.Nodes.Add("Block Size: " + optical.BlockSize);

                    opticalsNode.Nodes.Add(node);
                }
                specsTree.Nodes["disk"].Nodes.Add(opticalsNode);
            }

            if (IndiciumHelper.Volumes.Count > 0)
            {
                TreeNode volumesNode = new TreeNode("Partitions");
                volumesNode.Name = "volumes";

                foreach (Volume volume in IndiciumHelper.Volumes)
                {
                    string tmp = string.Empty;
                    if (!string.IsNullOrEmpty(volume.DriveLetter))
                    {
                        tmp = " (" + volume.DriveLetter + ")";
                    }
                    else
                    {
                        tmp = "-";
                    }

                    TreeNode node = new TreeNode(volume.Label + tmp);
                    node.Tag = _primaryItemTag;

                    node.Nodes.Add("File System: " + volume.FileSystem);
                    if (volume.Capacity.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Size: " + volume.Capacity);
                    }
                    else
                    {
                        node.Nodes.Add("Size: -");
                    }
                    if (volume.UsedSpace.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Used Space: " + volume.UsedSpace);
                    }
                    else
                    {
                        node.Nodes.Add("Used Space: -");
                    }
                    if (volume.FreeSpace.ToString() != _byteSizeNullString)
                    {
                        node.Nodes.Add("Free Space: " + volume.FreeSpace);
                    }
                    else
                    {
                        node.Nodes.Add("Free Space: -");
                    }
                    node.Nodes.Add("Indexing: " + volume.Indexing);
                    node.Nodes.Add("Compressed: " + volume.Compressed);
                    node.Nodes.Add("Drive Type: " + volume.DriveType);
                    node.Nodes.Add("Block Size: " + volume.BlockSize);

                    volumesNode.Nodes.Add(node);
                }
                specsTree.Nodes["disk"].Nodes.Add(volumesNode);

                if (IndiciumHelper.Removables.Count > 0)
                {
                    TreeNode removablesNode = new TreeNode("Removable Drives");
                    removablesNode.Name = "removables";

                    foreach (Volume removable in IndiciumHelper.Removables)
                    {
                        string tmp = string.Empty;
                        if (!string.IsNullOrEmpty(removable.DriveLetter))
                        {
                            tmp = " (" + removable.DriveLetter + ")";
                        }
                        else
                        {
                            tmp = "-";
                        }

                        TreeNode node = new TreeNode(removable.Label + tmp);

                        node.Tag = _primaryItemTag;

                        node.Nodes.Add("File System: " + removable.FileSystem);
                        if (removable.Capacity.ToString() != _byteSizeNullString)
                        {
                            node.Nodes.Add("Size: " + removable.Capacity);
                        }
                        else
                        {
                            node.Nodes.Add("Size: -");
                        }
                        if (removable.UsedSpace.ToString() != _byteSizeNullString)
                        {
                            node.Nodes.Add("Used Space: " + removable.UsedSpace);
                        }
                        else
                        {
                            node.Nodes.Add("Used Space: -");
                        }
                        if (removable.FreeSpace.ToString() != _byteSizeNullString)
                        {
                            node.Nodes.Add("Free Space: " + removable.FreeSpace);
                        }
                        else
                        {
                            node.Nodes.Add("Free Space: -");
                        }
                        node.Nodes.Add("Indexing: " + removable.Indexing);
                        node.Nodes.Add("Compressed: " + removable.Compressed);
                        node.Nodes.Add("Drive Type: " + removable.DriveType);
                        node.Nodes.Add("Block Size: " + removable.BlockSize);
                        removablesNode.Nodes.Add(node);
                    }
                    specsTree.Nodes["disk"].Nodes.Add(removablesNode);
                }
            }
        }

        private void GetCPUs()
        {
            List<CPU> cpus = IndiciumHelper.GetCPUs();

            if (cpus.Count > 0)
            {
                foreach (CPU cpu in cpus)
                {
                    TreeNode node = new TreeNode(cpu.Name);
                    node.Tag = _primaryItemTag;

                    HardwareSummary.CPUs.Add($"{cpu.Name} ({cpu.Cores} Cores, {cpu.LogicalCpus} Threads)");

                    node.Nodes.Add("Cores: " + cpu.Cores);
                    node.Nodes.Add("Threads: " + cpu.LogicalCpus);
                    node.Nodes.Add("Virtualization: " + cpu.Virtualization);
                    node.Nodes.Add("Data Execution Prevention: " + cpu.DataExecutionPrevention);
                    node.Nodes.Add("L2 Cache: " + cpu.L2CacheSize);
                    node.Nodes.Add("L3 Cache: " + cpu.L3CacheSize);
                    node.Nodes.Add("Stepping: " + cpu.Stepping);
                    node.Nodes.Add("Revision: " + cpu.Revision);

                    specsTree.Nodes["cpu"].Nodes.Add(node);
                }
            }
        }

        private void GetMotherboards()
        {
            List<Motherboard> mobos = IndiciumHelper.GetMotherboards();

            if (mobos.Count > 0)
            {
                foreach (Motherboard mobo in mobos)
                {
                    TreeNode node = new TreeNode(mobo.Manufacturer);
                    TreeNode node2 = new TreeNode("BIOS");
                    node.Tag = _primaryItemTag;
                    node2.Tag = _primaryItemTag;

                    HardwareSummary.Motherboards.Add($"{mobo.Manufacturer} ({mobo.SystemModel}) ({mobo.Product})");
                    HardwareSummary.BIOS.Add($"{mobo.BIOSManufacturer} {mobo.BIOSName}");

                    node.Nodes.Add("System: " + mobo.SystemModel);
                    node.Nodes.Add("Chipset: " + mobo.Chipset);
                    node.Nodes.Add("Product: " + mobo.Product);
                    node.Nodes.Add("Model: " + mobo.Model);
                    node.Nodes.Add("Version: " + mobo.Version);
                    node.Nodes.Add("Revision: " + mobo.Revision);

                    node2.Nodes.Add("Manufacturer: " + mobo.BIOSManufacturer);
                    node2.Nodes.Add("Manufacturer: " + mobo.BIOSName);
                    node2.Nodes.Add("Version: " + mobo.BIOSVersion);
                    node2.Nodes.Add("Build Number: " + mobo.BIOSBuildNumber);

                    specsTree.Nodes["mobo"].Nodes.Add(node);
                    specsTree.Nodes["mobo"].Nodes.Add(node2);
                }
            }
        }

        private void GetGPUs()
        {
            List<GPU> gpus = IndiciumHelper.GetGPUs();

            if (gpus.Count > 0)
            {
                foreach (GPU gpu in gpus)
                {
                    TreeNode node = new TreeNode(gpu.Name);
                    node.Tag = _primaryItemTag;

                    HardwareSummary.GPUs.Add($"{gpu.Name} ({gpu.Memory.ToString("GiB")})");

                    node.Nodes.Add("Video Memory: " + gpu.Memory.ToString("GiB"));
                    node.Nodes.Add("Video Memory Type: " + gpu.VideoMemoryType);
                    node.Nodes.Add("DAC Type: " + gpu.DACType);
                    node.Nodes.Add("Current Resolution: " + gpu.ResolutionX + " x " + gpu.ResolutionY);
                    node.Nodes.Add("Current Refresh Rate: " + gpu.RefreshRate + " Hz");

                    specsTree.Nodes["gpu"].Nodes.Add(node);
                }
            }
        }

        private void GetRAM()
        {
            List<RAM> ramInfo = IndiciumHelper.GetRAM();
            VirtualMemory vm = IndiciumHelper.GetVM();

            ByteSize totalRAM = new ByteSize(0);
            string memoryType = string.Empty;
            uint memorySpeed = 0;

            if (ramInfo.Count > 0)
            {
                foreach (RAM ram in ramInfo)
                {
                    TreeNode node = new TreeNode(ram.BankLabel.ToLowerInvariant().Replace("bank", "Module"));
                    node.Tag = _primaryItemTag;

                    totalRAM += ram.Capacity;
                    memorySpeed = ram.Speed;
                    memoryType = ram.MemoryType;

                    node.Nodes.Add("Manufacturer: " + ram.Manufacturer);
                    node.Nodes.Add("Size: " + ram.Capacity.ToString("GiB"));
                    node.Nodes.Add("Memory Type: " + ram.MemoryType);
                    node.Nodes.Add("Speed: " + ram.Speed + " MHz");
                    node.Nodes.Add("Form Factor: " + ram.FormFactor);

                    specsTree.Nodes["ram"].Nodes.Add(node);
                }

                HardwareSummary.TotalRAM = $"{totalRAM.ToString("GiB")} {memoryType} @ {memorySpeed} MHz";
            }

            if (vm != null)
            {
                TreeNode node = new TreeNode("Virtual Memory");
                node.Name = "vm";
                node.Tag = _primaryItemTag;

                node.Nodes.Add("Total: " + vm.TotalVirtualMemory.ToString("GiB"));
                node.Nodes.Add("Available : " + vm.AvailableVirtualMemory.ToString("GiB"));
                node.Nodes.Add("Used: " + vm.UsedVirtualMemory.ToString("GiB"));

                specsTree.Nodes["ram"].Nodes.Add(node);
            }
        }

        //private void InitNetworkMonitoring()
        //{
        //    try
        //    {
        //        _networkMonitor = new NetworkMonitor();

        //        if (Options.CurrentOptions.EnableTray)
        //        {
        //            _networkMonitor.StartMonitoring();
        //            _networkMonitoringSupported = true;
        //            NetworkLiveMonitoring();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _networkMonitoringSupported = false;
        //        DisposeNetworkMonitoring();
        //        ErrorLogger.LogError("MainForm.NETWORK-MONITORING", ex.Message, ex.StackTrace);
        //    }
        //    finally
        //    {
        //        seperatorNetMon.Visible = _networkMonitoringSupported;
        //        trayDownSpeed.Visible = _networkMonitoringSupported;
        //        trayUpSpeed.Visible = _networkMonitoringSupported;
        //    }
        //}

        //private void DisposeNetworkMonitoring()
        //{
        //    if (_networkMonitor != null) _networkMonitor.StopMonitoring();
        //}

        //private void NetworkLiveMonitoring()
        //{
        //    if (!_networkMonitoringSupported) return;

        //    Task.Factory.StartNew(() =>
        //    {
        //        while (Options.CurrentOptions.EnableTray)
        //        {
        //            // in BYTES
        //            downloadSpeed = 0;
        //            uploadSpeed = 0;

        //            foreach (NetworkAdapter adapter in _networkMonitor.Adapters)
        //            {
        //                //adapter.Refresh();
        //                downloadSpeed += Math.Round(adapter.DownloadSpeedKbps, 2);
        //                uploadSpeed += Math.Round(adapter.UploadSpeedKbps, 2);
        //            }

        //            this.Invoke(new Action(() =>
        //            {
        //                trayDownSpeed.Text = $"{downloadSpeed} KB/s";
        //                trayUpSpeed.Text = $"{uploadSpeed} KB/s";
        //            }));

        //            Thread.Sleep(1000);
        //        }
        //    });
        //}

        //private void TranslateIndicium()
        //{
        //    if (hwDetailed.ToggleChecked)
        //    {
        //        // DETAILS TRANSLATION
        //        TreeNode cpu = specsTree.Nodes["cpu"];
        //        TreeNode ram = specsTree.Nodes["ram"];
        //        TreeNode gpu = specsTree.Nodes["gpu"];
        //        TreeNode mobo = specsTree.Nodes["mobo"];
        //        TreeNode disk = specsTree.Nodes["disk"];
        //        TreeNode inet = specsTree.Nodes["inet"];
        //        TreeNode audio = specsTree.Nodes["audio"];
        //        TreeNode dev = specsTree.Nodes["dev"];

        //        if (cpu != null) cpu.Text = translationList["cpu"];
        //        if (ram != null)
        //        {
        //            ram.Text = translationList["ram"];
        //            TreeNode vm = ram.Nodes["vm"];
        //            if (vm != null) vm.Text = translationList["vm"];
        //        }
        //        if (gpu != null) gpu.Text = translationList["gpu"];
        //        if (mobo != null) mobo.Text = translationList["mobo"];
        //        if (disk != null)
        //        {
        //            disk.Text = translationList["disk"];
        //            TreeNode disks = disk.Nodes["drives"];
        //            TreeNode vols = disk.Nodes["volumes"];
        //            TreeNode opticals = disk.Nodes["opticals"];
        //            TreeNode removables = disk.Nodes["removables"];
        //            if (disks != null) disks.Text = translationList["drives"];
        //            if (vols != null) vols.Text = translationList["volumes"];
        //            if (opticals != null) opticals.Text = translationList["opticals"];
        //            if (removables != null) removables.Text = translationList["removables"];
        //        }
        //        if (inet != null)
        //        {
        //            inet.Text = translationList["inet"];
        //            TreeNode pas = inet.Nodes["physicalAdapters"];
        //            TreeNode vas = inet.Nodes["virtualAdapters"];
        //            if (pas != null) pas.Text = translationList["physicalAdapters"];
        //            if (vas != null) vas.Text = translationList["virtualAdapters"];
        //        }
        //        if (audio != null) audio.Text = translationList["audio"];
        //        if (dev != null)
        //        {
        //            dev.Text = translationList["dev"];
        //            TreeNode kbs = dev.Nodes["keyboards"];
        //            TreeNode pds = dev.Nodes["pointings"];
        //            if (kbs != null) kbs.Text = translationList["keyboards"];
        //            if (pds != null) pds.Text = translationList["pointings"];
        //        }
        //    }
        //    else
        //    {
        //        // SUMMARY TRANSLATION
        //        TreeNode os = specsTree.Nodes["os"];
        //        TreeNode scpu = specsTree.Nodes["scpu"];
        //        TreeNode sram = specsTree.Nodes["sram"];
        //        TreeNode sgpu = specsTree.Nodes["sgpu"];
        //        TreeNode smobo = specsTree.Nodes["smobo"];
        //        TreeNode sdisk = specsTree.Nodes["sdisk"];
        //        TreeNode sinet = specsTree.Nodes["sinet"];

        //        if (os != null) os.Text = translationList["os"];
        //        if (scpu != null) scpu.Text = translationList["cpu"];
        //        if (sram != null) sram.Text = translationList["ram"];
        //        if (sgpu != null) sgpu.Text = translationList["gpu"];
        //        if (smobo != null) smobo.Text = translationList["mobo"];
        //        if (sdisk != null) sdisk.Text = translationList["disk"];
        //        if (sinet != null) sinet.Text = translationList["inet"];
        //    }
        //}

        private void Translate(bool skipFull = false)
        {
            translationList = Options.TranslationList.ToObject<Dictionary<string, string>>();

            if (Environment.Is64BitOperatingSystem)
            {
                translationList["txtBitness"] = translationList["txtBitness"].Replace("{BITS}", translationList["c64"]);
            }
            else
            {
                translationList["txtBitness"] = translationList["txtBitness"].Replace("{BITS}", translationList["c32"]);
            }

            TranslateTips();
            //TranslateIndicium();

            if (!skipFull)
            {
                _noNewVersionMessage = Options.TranslationList["noNewVersion"];
                _betaVersionMessage = Options.TranslationList["betaVersion"];
                _newVersionMessage = Options.TranslationList["newVersion"];
                _restartMessage = Options.TranslationList["restartAndApply"];
                _removeStartupItemsMessage = Options.TranslationList["removeAllStartup"];
                _removeHostsEntriesMessage = Options.TranslationList["removeAllHosts"];
                _removeDesktopItemsMessage = Options.TranslationList["removeAllItems"];
                _removeModernAppsMessage = Options.TranslationList["removeModernApps"];
                _errorModernAppsMessage = Options.TranslationList["errorModernApps"];
                _repairMessage = Options.TranslationList["resetMessage"];
                _uwpRestoreMessage = Options.TranslationList["restoreUwpMessage"];
                _flushDNSMessage = Options.TranslationList["flushDNSMessage"];

                listStartupItems.Columns[0].Text = translationList["startupItemName"];
                listStartupItems.Columns[1].Text = translationList["startupItemLocation"];
                listStartupItems.Columns[2].Text = translationList["startupItemType"];

                trayStartup.Text = translationList["trayStartup"];
                trayCleaner.Text = translationList["trayCleaner"];
                trayPinger.Text = translationList["trayPinger"];
                trayHosts.Text = translationList["trayHosts"];
                trayAD.Text = translationList["trayAD"];
                trayUnlocker.Text = translationList["trayUnlocker"];
                trayOptions.Text = translationList["trayOptions"];
                trayRegistry.Text = translationList["trayRegistry"];
                trayRestartExplorer.Text = translationList["trayRestartExplorer"];
                trayExit.Text = translationList["trayExit"];
                trayHW.Text = translationList["trayHW"];

                toolHWCopy.Text = translationList["toolHWCopy"];
                toolHWDuck.Text = translationList["toolHWDuck"];
                toolHWGoogle.Text = translationList["toolHWGoogle"];

                label14s.Text = translationList["subSystem"];
                label14.Text = translationList["subSystem"];
                label4a.Text = translationList["appsTab"];
                label13.Text = translationList["subPrivacy"];
                label16.Text = translationList["subPrivacy"];
                label17.Text = translationList["subGaming"];
                label18.Text = translationList["subTouch"];
                label19.Text = translationList["subTaskbar"];
                label20.Text = translationList["subExtras"];
                label21.Text = translationList["subSystem"];

                Control element;
                foreach (var x in translationList)
                {
                    if (x.Key == null || x.Key == string.Empty) continue;
                    element = this.Controls.Find(x.Key, true).FirstOrDefault();

                    if (element == null) continue;

                    if (element is ToggleCard)
                    {
                        ((ToggleCard)element).LabelText = x.Value;
                        continue;
                    }

                    element.Text = x.Value;
                }
            }

            txtVersion.Text = txtVersion.Text.Replace("{VN}", Program.GetCurrentVersionTostring());
        }

        private void GetFootprint()
        {
            ByteSize footprint = CleanHelper.PreviewSizeToBeFreed;
            if (footprint > ByteSize.FromBytes(0)) lblFootprint.Text = footprint.ToString();
            else lblFootprint.Text = "-";
        }

        private void GetFeed()
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            client.Headers.Add("Cache-Control", "no-cache");

            try
            {
                byte[] feedData;
                string tmpImageFileName = string.Empty;

                feedData = client.DownloadData(_feedImages);

                using (ZipArchive zip = new ZipArchive(new MemoryStream(feedData)))
                {
                    var zipEntries = zip.Entries;

                    try
                    {
                        string feed = client.DownloadString(_feedLink);
                        AppsFromFeed = JsonConvert.DeserializeObject<List<FeedApp>>(feed);

                        AppCard appCard;
                        groupSystemTools.Controls.Clear();
                        groupInternet.Controls.Clear();
                        groupCoding.Controls.Clear();
                        groupSoundVideo.Controls.Clear();

                        foreach (FeedApp x in AppsFromFeed)
                        {
                            appCard = new AppCard();
                            appCard.AutoSize = true;
                            appCard.Anchor = AnchorStyles.None;
                            appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                            appCard.appTitle.Text = x.Title;
                            appCard.appTitle.Name = x.Tag;
                            appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;

                            tmpImageFileName = x.Image.Substring(x.Image.LastIndexOf("/") + 1, x.Image.Length - (x.Image.LastIndexOf("/") + 1));
                            appCard.appImage.Image = Image.FromStream(zipEntries.First(ifn => ifn.Name == tmpImageFileName).Open());

                            switch (x.Group)
                            {
                                case "SystemTools":
                                    appCard.Location = new Point(0, groupSystemTools.Controls.Count * (Program.DPI_PREFERENCE / 3));
                                    groupSystemTools.Controls.Add(appCard);
                                    break;
                                case "Internet":
                                    appCard.Location = new Point(0, groupInternet.Controls.Count * (Program.DPI_PREFERENCE / 3));
                                    groupInternet.Controls.Add(appCard);
                                    break;
                                case "Coding":
                                    appCard.Location = new Point(0, groupCoding.Controls.Count * (Program.DPI_PREFERENCE / 3));
                                    groupCoding.Controls.Add(appCard);
                                    break;
                                case "GraphicsSound":
                                    appCard.Location = new Point(0, groupSoundVideo.Controls.Count * (Program.DPI_PREFERENCE / 3));
                                    groupSoundVideo.Controls.Add(appCard);
                                    break;
                                default:
                                    break;
                            }
                        }

                        // UI handling
                        btnDownloadApps.Enabled = true;
                        txtFeedError.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        btnDownloadApps.Enabled = false;
                        txtFeedError.Visible = true;

                        ErrorLogger.LogError("MainForm.GetFeed", ex.Message, ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                btnDownloadApps.Enabled = false;
                txtFeedError.Visible = true;

                ErrorLogger.LogError("MainForm.GetFeed-DownloadImages", ex.Message, ex.StackTrace);
            }
        }

        private void PreviewCleanPC()
        {
            try
            {
                if (checkTemp.Checked) CleanHelper.PreviewTemp();
                if (checkMiniDumps.Checked) CleanHelper.PreviewMinidumps();
                if (checkErrorReports.Checked) CleanHelper.PreviewErrorReports();
                CleanHelper.PreviewChromeClean(chromeCache.Checked, chromeCookies.Checked, chromeHistory.Checked, chromeSession.Checked, chromePws.Checked);
                CleanHelper.PreviewFireFoxClean(firefoxCache.Checked, firefoxCookies.Checked, firefoxHistory.Checked);
                CleanHelper.PreviewEdgeClean(edgeCache.Checked, edgeCookies.Checked, edgeHistory.Checked, edgeSession.Checked);
                CleanHelper.PreviewBraveClean(braveCache.Checked, braveCookies.Checked, braveHistory.Checked, braveSession.Checked, bravePasswords.Checked);
                if (IECache.Checked) CleanHelper.PreviewInternetExplorerCache();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.CleanPC", ex.Message, ex.StackTrace);
            }
            finally
            {
                _cleanPreviewList = CleanHelper.PreviewCleanList;

                _cleanPreviewList.Sort();
                listCleanPreview.Items.AddRange(_cleanPreviewList.ToArray());

                for (int i = 0; i < listCleanPreview.Items.Count; i++)
                {
                    listCleanPreview.SetItemChecked(i, true);
                }

                GetFootprint();
            }
        }

        private void CleanPC()
        {
            for (int i = 0; i < listCleanPreview.CheckedItems.Count; i++)
            {
                CleanHelper.PreviewCleanList.Add(listCleanPreview.CheckedItems[i].ToString());
            }

            if (checkBin.Checked) CleanHelper.EmptyRecycleBin();

            CleanHelper.Clean();

            listCleanPreview.Items.Clear();
            CleanHelper.PreviewCleanList.Clear();
        }

        private bool FixRegistry()
        {
            bool changeDetected = false;

            try
            {
                if (checkFirewall.Checked)
                {
                    Utilities.EnableFirewall();
                    changeDetected = true;
                }
                if (checkCommandPrompt.Checked)
                {
                    Utilities.EnableCommandPrompt();
                    changeDetected = true;
                }
                if (checkControlPanel.Checked)
                {
                    Utilities.EnableControlPanel();
                    changeDetected = true;
                }
                if (checkFolderOptions.Checked)
                {
                    Utilities.EnableFolderOptions();
                    changeDetected = true;
                }
                if (checkRunDialog.Checked)
                {
                    Utilities.EnableRunDialog();
                    changeDetected = true;
                }
                if (checkContextMenu.Checked)
                {
                    Utilities.EnableContextMenu();
                    changeDetected = true;
                }
                if (checkTaskManager.Checked)
                {
                    Utilities.EnableTaskManager();
                    changeDetected = true;
                }
                if (checkRegistryEditor.Checked)
                {
                    Utilities.EnableRegistryEditor();
                    changeDetected = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.FixRegistry", ex.Message, ex.StackTrace);
            }

            return changeDetected;
        }

        private void LoadUniversalToggleStates()
        {
            performanceSw.ToggleChecked = Options.CurrentOptions.EnablePerformanceTweaks;
            networkSw.ToggleChecked = Options.CurrentOptions.DisableNetworkThrottling;
            defenderSw.ToggleChecked = Options.CurrentOptions.DisableWindowsDefender;
            systemRestoreSw.ToggleChecked = Options.CurrentOptions.DisableSystemRestore;
            printSw.ToggleChecked = Options.CurrentOptions.DisablePrintService;
            mediaSharingSw.ToggleChecked = Options.CurrentOptions.DisableMediaPlayerSharing;
            reportingSw.ToggleChecked = Options.CurrentOptions.DisableErrorReporting;
            homegroupSw.ToggleChecked = Options.CurrentOptions.DisableHomeGroup;
            superfetchSw.ToggleChecked = Options.CurrentOptions.DisableSuperfetch;
            telemetryTasksSw.ToggleChecked = Options.CurrentOptions.DisableTelemetryTasks;
            officeTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableOffice2016Telemetry;
            compatSw.ToggleChecked = Options.CurrentOptions.DisableCompatibilityAssistant;
            faxSw.ToggleChecked = Options.CurrentOptions.DisableFaxService;
            smartScreenSw.ToggleChecked = Options.CurrentOptions.DisableSmartScreen;
            stickySw.ToggleChecked = Options.CurrentOptions.DisableStickyKeys;
            hibernateSw.ToggleChecked = Options.CurrentOptions.DisableHibernation;
            smb1Sw.ToggleChecked = Options.CurrentOptions.DisableSMB1;
            smb2Sw.ToggleChecked = Options.CurrentOptions.DisableSMB2;
            ntfsStampSw.ToggleChecked = Options.CurrentOptions.DisableNTFSTimeStamp;
            winSearchSw.ToggleChecked = Options.CurrentOptions.DisableSearch;
            ffTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableFirefoxTemeletry;
            vsSw.ToggleChecked = Options.CurrentOptions.DisableVisualStudioTelemetry;
            chromeTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableChromeTelemetry;
            nvidiaTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableNVIDIATelemetry;
        }

        private void LoadWindowsVIIIToggleStates()
        {
            disableOneDriveSw.ToggleChecked = Options.CurrentOptions.DisableOneDrive;
        }

        private void LoadWindowsXToggleStates()
        {
            oldMixerSw.ToggleChecked = Options.CurrentOptions.EnableLegacyVolumeSlider;
            uODSw.ToggleChecked = Options.CurrentOptions.UninstallOneDrive;
            gameBarSw.ToggleChecked = Options.CurrentOptions.DisableGameBar;
            cortanaSw.ToggleChecked = Options.CurrentOptions.DisableCortana;
            xboxSw.ToggleChecked = Options.CurrentOptions.DisableXboxLive;
            oldExplorerSw.ToggleChecked = Options.CurrentOptions.DisableQuickAccessHistory;
            sensorSw.ToggleChecked = Options.CurrentOptions.DisableSensorServices;
            privacySw.ToggleChecked = Options.CurrentOptions.DisablePrivacyOptions;
            telemetryServicesSw.ToggleChecked = Options.CurrentOptions.DisableTelemetryServices;
            autoUpdatesSw.ToggleChecked = Options.CurrentOptions.DisableAutomaticUpdates;
            peopleSw.ToggleChecked = Options.CurrentOptions.DisableMyPeople;
            adsSw.ToggleChecked = Options.CurrentOptions.DisableStartMenuAds;
            spellSw.ToggleChecked = Options.CurrentOptions.DisableSpellingTyping;
            inkSw.ToggleChecked = Options.CurrentOptions.DisableWindowsInk;
            driversSw.ToggleChecked = Options.CurrentOptions.ExcludeDrivers;
            insiderSw.ToggleChecked = Options.CurrentOptions.DisableInsiderService;
            storeUpdatesSw.ToggleChecked = Options.CurrentOptions.DisableStoreUpdates;
            ccSw.ToggleChecked = Options.CurrentOptions.DisableCloudClipboard;
            longPathsSw.ToggleChecked = Options.CurrentOptions.EnableLongPaths;
            castSw.ToggleChecked = Options.CurrentOptions.RemoveCastToDevice;
            gameModeSw.ToggleChecked = Options.CurrentOptions.EnableGamingMode;
            tpmSw.ToggleChecked = Options.CurrentOptions.DisableTPMCheck;
        }

        private void LoadWindowsXIToggleStates()
        {
            leftTaskbarSw.ToggleChecked = Options.CurrentOptions.TaskbarToLeft;
            snapAssistSw.ToggleChecked = Options.CurrentOptions.DisableSnapAssist;
            widgetsSw.ToggleChecked = Options.CurrentOptions.DisableWidgets;
            chatSw.ToggleChecked = Options.CurrentOptions.DisableChat;
            stickersSw.ToggleChecked = Options.CurrentOptions.DisableStickers;
            smallerTaskbarSw.ToggleChecked = Options.CurrentOptions.TaskbarSmaller;
            classicRibbonSw.ToggleChecked = Options.CurrentOptions.ClassicRibbon;
            classicContextSw.ToggleChecked = Options.CurrentOptions.ClassicMenu;
            tpmSw.ToggleChecked = Options.CurrentOptions.DisableTPMCheck;
            compactModeSw.ToggleChecked = Options.CurrentOptions.CompactMode;
            vbsSw.ToggleChecked = Options.CurrentOptions.DisableVBS;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void GetDesktopItems()
        {
            _desktopItems = Integrator.GetDesktopItems();
            listDesktopItems.Items.Clear();

            for (int i = 0; i < _desktopItems.Count; i++)
            {
                if (!string.IsNullOrEmpty(_desktopItems[i]))
                {
                    listDesktopItems.Items.Add(_desktopItems[i]);
                }
            }

            if (_desktopItems.Count > 0) listDesktopItems.SelectedIndex = 0;
        }

        private void GetHostsEntries()
        {
            ((Control)this.hostsEditorTab).Enabled = false;

            _hostsEntries = HostsHelper.GetHostsEntries();
            listHostEntries.Items.Clear();

            listHostEntries.Items.AddRange(_hostsEntries.ToArray());

            chkReadOnly.Checked = HostsHelper.GetReadOnly();

            addHostB.Enabled = !chkReadOnly.Checked;
            removeAllHostsB.Enabled = !chkReadOnly.Checked;
            removeHostB.Enabled = !chkReadOnly.Checked;
            refreshHostsB.Enabled = !chkReadOnly.Checked;
            linkRestoreDefault.Enabled = !chkReadOnly.Checked;
            chkBlock.Enabled = !chkReadOnly.Checked;
            txtDomain.Enabled = !chkReadOnly.Checked;
            txtIP.Enabled = !chkReadOnly.Checked;

            ((Control)this.hostsEditorTab).Enabled = true;

            if (_hostsEntries.Count > 0) listHostEntries.SelectedIndex = 0;
        }

        private void GetStartupItems()
        {
            _startUpItems = StartupHelper.GetStartupItems();
            listStartupItems.Items.Clear();

            for (int i = 0; i < _startUpItems.Count; i++)
            {
                ListViewItem list = new ListViewItem(_startUpItems[i].Name);
                list.SubItems.Add(_startUpItems[i].FileLocation);
                list.SubItems.Add(_startUpItems[i].ToString());

                listStartupItems.Items.Add(list);
            }
        }

        private void GetModernApps(bool showAll)
        {
            uninstallModernAppsButton.Enabled = false;
            refreshModernAppsButton.Enabled = false;

            panelUwp.Controls.Clear();
            _modernApps = UWPHelper.GetUWPApps(showAll);

            AppCard appCard;
            FileInfo pngTmp;

            foreach (var x in _modernApps)
            {

                appCard = new AppCard();
                appCard.AutoSize = true;
                appCard.Anchor = AnchorStyles.None;
                appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                appCard.appTitle.Text = x.Key;
                appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;

                // gets largest picture
                try
                {
                    pngTmp = new DirectoryInfo(x.Value)
                    .EnumerateFiles("*.png", SearchOption.AllDirectories)
                    .OrderByDescending(f => f.Length)
                    .FirstOrDefault();
                }
                catch
                {
                    pngTmp = null;
                }

                if (pngTmp != null)
                {
                    try
                    {
                        appCard.appImage.Image = Image.FromFile(pngTmp.FullName);
                    }
                    catch { }
                }

                appCard.Location = new Point(0, panelUwp.Controls.Count * (Program.DPI_PREFERENCE / 3));
                panelUwp.Controls.Add(appCard);

            }

            uninstallModernAppsButton.Enabled = true;
            refreshModernAppsButton.Enabled = true;
        }

        private async void UninstallModernApps()
        {
            List<string> selectedApps = new List<string>();

            foreach (Control c in Utilities.GetSelfAndChildrenRecursive(panelUwp))
            {
                //if ((c.Name == "chkSelectAllModernApps") || (c.Name == "chkOnlyRemovable")) continue;
                if (c is MoonCheck && ((MoonCheck)c).Checked)
                {
                    selectedApps.Add(c.Text);
                }
            }

            if (selectedApps.Count <= 0) return;

            if (MessageBox.Show(_removeModernAppsMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uninstallModernAppsButton.Enabled = false;
                refreshModernAppsButton.Enabled = false;

                bool errorOccured = false;
                string failedApps = string.Empty;

                foreach (string app in selectedApps)
                {
                    await Task.Run(() => errorOccured = UWPHelper.UninstallUWPApp(app));

                    if (errorOccured)
                    {
                        failedApps += Environment.NewLine + app;
                    }
                }

                if (!string.IsNullOrEmpty(failedApps))
                {
                    MessageBox.Show(_errorModernAppsMessage + failedApps, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GetModernApps(!chkOnlyRemovable.Checked);
            }
        }

        private void GetCustomCommands()
        {
            _customCommands = Integrator.GetCustomCommands();
            listCustomCommands.Items.Clear();

            foreach (string s in _customCommands)
            {
                listCustomCommands.Items.Add(s);
            }

            if (_customCommands.Count > 0) listCustomCommands.SelectedIndex = 0;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_trayMenu)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                Options.CurrentOptions.AppsFolder = txtDownloadFolder.Text;
                Options.SaveSettings();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (listStartupItems.CheckedItems.Count <= 0) return;

            string report = string.Empty;

            foreach (ListViewItem i in listStartupItems.CheckedItems)
            {
                report += i.Text + Environment.NewLine;
            }
            if (MessageBox.Show(_removeStartupItemsMessage + Environment.NewLine + Environment.NewLine + report, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (int x in listStartupItems.CheckedIndices)
                {
                    _startUpItems[x].Remove();
                }

                GetStartupItems();
            }

            //foreach (int x in listStartupItems.CheckedIndices)
            //{
            //    MessageBox.Show(x.ToString());
            //}
            //if (listStartupItems.SelectedItems.Count == 1)
            //{
            //    _startUpItems[listStartupItems.SelectedIndices[0]].Remove();
            //    GetStartupItems();
            //}
        }

        internal void RemoveAllStartupItems()
        {
            foreach (ListViewItem i in listStartupItems.Items)
            {
                _startUpItems[i.Index].Remove();
            }

            GetStartupItems();
        }

        // REMOVE ALL STARTUP ITEMS BUTTON
        //private void button22_Click(object sender, EventArgs e)
        //{
        //    if (listStartupItems.Items.Count > 0)
        //    {
        //        HelperForm r = new HelperForm(this, MessageType.Startup, _removeStartupItemsMessage);
        //        r.ShowDialog(this);
        //    }
        //}

        private void button31_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].LocateFile();
            }
        }

        private void checkEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            checkTaskManager.Checked = checkEnableAll.Checked;
            checkCommandPrompt.Checked = checkEnableAll.Checked;
            checkControlPanel.Checked = checkEnableAll.Checked;
            checkFolderOptions.Checked = checkEnableAll.Checked;
            checkRunDialog.Checked = checkEnableAll.Checked;
            checkContextMenu.Checked = checkEnableAll.Checked;
            checkFirewall.Checked = checkEnableAll.Checked;
            checkRegistryEditor.Checked = checkEnableAll.Checked;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            bool flag = FixRegistry();

            if (flag)
            {
                panel2.Enabled = false;
                regFixB.Enabled = false;

                if (checkRestartExplorer.Checked)
                {
                    Utilities.RestartExplorer();
                }

                panel2.Enabled = true;
                regFixB.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            GetStartupItems();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsHelper.LocateHosts();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsEditorForm f = new HostsEditorForm();
            f.ShowDialog(this);
            GetHostsEntries();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HostsHelper.RestoreDefaultHosts();
            GetHostsEntries();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if ((txtIP.Text != string.Empty) && (txtDomain.Text != string.Empty))
            {
                string ip = txtIP.Text.Trim();
                string domain = txtDomain.Text.Trim();

                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));

                GetHostsEntries();

                txtIP.Clear();
                txtDomain.Clear();

                chkBlock.Checked = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            GetHostsEntries();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (listHostEntries.SelectedItems.Count == 1)
            {
                HostsHelper.RemoveEntry(listHostEntries.SelectedItem.ToString().Replace(" : ", " "));
                GetHostsEntries();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (listHostEntries.Items.Count > 0)
            {
                HelperForm r = new HelperForm(this, MessageType.Hosts, _removeHostsEntriesMessage);
                r.ShowDialog(this);
            }
        }

        internal void RemoveAllHostsEntries()
        {
            List<string> collection = new List<string>();

            foreach (string item in listHostEntries.Items)
            {
                collection.Add(item.Replace(" : ", " "));
            }

            HostsHelper.RemoveAllEntries(collection);
            GetHostsEntries();
        }

        private void aio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCollection.SelectedTab == hostsEditorTab) txtIP.Focus();

            if (tabCollection.SelectedTab == pingerTab) txtPingInput.Focus();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            defineCommandDialog.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRunFile.Text) && !string.IsNullOrEmpty(txtRunKeyword.Text))
            {
                Integrator.CreateCustomCommand(txtRunFile.Text, txtRunKeyword.Text);

                txtRunFile.Clear();
                txtRunKeyword.Clear();

                GetCustomCommands();
            }
        }

        private void DefineCmd_FileOk(object sender, CancelEventArgs e)
        {
            txtRunFile.Text = defineCommandDialog.FileName;
            txtRunKeyword.Text = Path.GetFileNameWithoutExtension(txtRunFile.Text).ToLower();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            GetDesktopItems();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (listDesktopItems.SelectedItems.Count == 1)
            {
                Integrator.RemoveItem(listDesktopItems.SelectedItem.ToString());
                GetDesktopItems();
            }
        }

        internal void RemoveAllDesktopItems()
        {
            List<string> collection = new List<string>();
            foreach (string item in listDesktopItems.Items)
            {
                collection.Add(item);
            }

            Integrator.RemoveAllItems(collection);

            GetDesktopItems();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (listDesktopItems.Items.Count > 0)
            {
                HelperForm r = new HelperForm(this, MessageType.Integrator, _removeDesktopItemsMessage);
                r.ShowDialog(this);
            }
        }

        private void radioProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProgram.Checked)
            {
                btnBrowseItem.Enabled = true;
                txtItem.Clear();
                checkDefaultIcon.Checked = true;
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
                itemtoaddgroup.Text = Options.TranslationList["itemtoaddgroup"];
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = Options.TranslationList["checkDefaultIcon"];
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Program;
            }
        }

        private void radioFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFolder.Checked)
            {
                checkDefaultIcon.Checked = true;
                btnBrowseItem.Enabled = true;
                txtItem.Clear();
                itemtoaddgroup.Text = Options.TranslationList["folderToAdd"];
                checkDefaultIcon.Text = Options.TranslationList["checkDefaultFolderIcon"];
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Folder;
            }
        }

        private void radioLink_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLink.Checked)
            {
                checkDefaultIcon.Checked = true;
                checkDefaultIcon.Text = Options.TranslationList["checkFavicon"];
                btnBrowseItem.Enabled = false;
                itemtoaddgroup.Text = Options.TranslationList["linkToAdd"];
                checkDefaultIcon.Visible = true;
                txtItem.Text = "http://";
                txtItemName.Clear();
                txtItem.ReadOnly = false;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Link;
            }
        }

        private void radioFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFile.Checked)
            {
                checkDefaultIcon.Checked = true;
                checkDefaultIcon.Text = Options.TranslationList["checkNoIcon"];
                btnBrowseItem.Enabled = true;
                itemtoaddgroup.Text = Options.TranslationList["fileToAdd"];
                checkDefaultIcon.Visible = true;
                txtItem.Clear();
                txtItemName.Clear();
                txtItem.ReadOnly = true;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.File;
            }
        }

        private void radioCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCommand.Checked)
            {
                btnBrowseItem.Enabled = false;
                txtItem.Clear();
                checkDefaultIcon.Checked = true;
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
                itemtoaddgroup.Text = Options.TranslationList["commandToAdd"];
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = Options.TranslationList["checkNoIcon"];
                txtItemName.Clear();
                txtItem.ReadOnly = false;
                txtIcon.ReadOnly = true;
                _desktopItemType = DesktopItemType.Command;
            }
        }

        private void checkDefaultIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDefaultIcon.Checked)
            {
                txtIcon.Clear();
                txtIcon.Enabled = false;
                btnBrowseIcon.Enabled = false;
            }
            else
            {
                txtIcon.Clear();
                txtIcon.Enabled = true;
                btnBrowseIcon.Enabled = true;
            }
        }

        private void btnBrowseItem_Click(object sender, EventArgs e)
        {
            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    defineProgramDialog.ShowDialog();
                    break;
                case DesktopItemType.Folder:
                    defineFolderDialog.ShowDialog();
                    txtItem.Text = defineFolderDialog.SelectedPath;
                    int i = defineFolderDialog.SelectedPath.LastIndexOf("\\");
                    txtItemName.Text = defineFolderDialog.SelectedPath.Remove(0, i + 1);
                    break;
                case DesktopItemType.File:
                    defineFileDialog.ShowDialog();
                    break;
            }
        }

        private void DefineProgramDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtItem.Text = defineProgramDialog.FileName;
            txtItemName.Text = defineProgramDialog.SafeFileName.Replace(".exe", string.Empty);
        }

        private void DefineFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtItem.Text = defineFileDialog.FileName;
            txtItemName.Text = defineFileDialog.SafeFileName;
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    DefineProgramIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Folder:
                    DefineFolderIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Link:
                    DefineURLIconDialog.ShowDialog();
                    break;
                case DesktopItemType.File:
                    DefineFileIconDialog.ShowDialog();
                    break;
                case DesktopItemType.Command:
                    DefineCommandIconDialog.ShowDialog();
                    break;
            }
        }

        private void DefineProgramIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineProgramIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineProgramIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFolderIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFolderIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineFolderIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineURLIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineURLIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineURLIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFileIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFileIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineFileIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineCommandIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineCommandIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = Integrator.ExtractIconFromExecutable(txtItemName.Text, DefineCommandIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!checkDefaultIcon.Checked && (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtIcon.Text)))
            {
                return;
            }

            if (checkDefaultIcon.Checked && (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtItemName.Text)))
            {
                return;
            }

            string icon = string.Empty;

            switch (_desktopItemType)
            {
                case DesktopItemType.Program:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = txtItem.Text;
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Program);

                    break;
                case DesktopItemType.Folder:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = Integrator.FolderDefaultIcon;
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Folder);

                    break;
                case DesktopItemType.Link:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = Integrator.DownloadFavicon(txtItem.Text, txtItemName.Text);
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Link);

                    break;
                case DesktopItemType.File:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.File);

                    break;
                case DesktopItemType.Command:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    Integrator.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Command);

                    break;
            }

            GetDesktopItems();
            ResetIntegratorForm();
        }

        private void radioTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTop.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Top;
            }
        }

        private void radioMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMiddle.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Middle;
            }
        }

        private void radioBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBottom.Checked)
            {
                _desktopItemPosition = DesktopTypePosition.Bottom;
            }
        }

        private void ResetIntegratorForm()
        {
            txtItem.Clear();
            txtIcon.Clear();
            checkDefaultIcon.Checked = true;
            txtItemName.Clear();

            if (radioLink.Checked)
            {
                txtItem.Text = "http://";
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].LocateKey();
            }
        }

        private void listStartupItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _columnSorter.CurrentColumn)
            {
                if (_columnSorter.SortOrder == SortOrder.Ascending)
                {
                    _columnSorter.SortOrder = SortOrder.Descending;
                }
                else
                {
                    _columnSorter.SortOrder = SortOrder.Ascending;
                }
            }
            else
            {
                _columnSorter.CurrentColumn = e.Column;
                _columnSorter.SortOrder = SortOrder.Ascending;
            }

            listStartupItems.Sort();
        }

        private void chkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlock.Checked)
            {
                txtIP.Text = _blockedIP;
                txtIP.Enabled = false;
            }
            else
            {
                txtIP.Clear();
                txtIP.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GetCustomCommands();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (listCustomCommands.SelectedItems.Count == 1)
            {
                Integrator.DeleteCustomCommand(listCustomCommands.SelectedItem.ToString());
                GetCustomCommands();
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            GetModernApps(!chkOnlyRemovable.Checked);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            UninstallModernApps();
        }

        private void chkSelectAllModernApps_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in Utilities.GetSelfAndChildrenRecursive(panelUwp))
            {
                if (c is MoonCheck) ((MoonCheck)c).Checked = chkSelectAllModernApps.Checked;
            }
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_repairMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilities.Repair();
            }
        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            if (performanceSw.ToggleChecked)
            {
                Optimize.EnablePerformanceTweaks();
            }
            else
            {
                Optimize.DisablePerformanceTweaks();
            }
            Options.CurrentOptions.EnablePerformanceTweaks = performanceSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch2_Click(object sender, EventArgs e)
        {
            if (networkSw.ToggleChecked)
            {
                Optimize.DisableNetworkThrottling();
            }
            else
            {
                Optimize.EnableNetworkThrottling();
            }
            Options.CurrentOptions.DisableNetworkThrottling = networkSw.ToggleChecked;
        }

        private void toggleSwitch3_Click(object sender, EventArgs e)
        {
            if (defenderSw.ToggleChecked)
            {
                Optimize.DisableDefender();
            }
            else
            {
                Optimize.EnableDefender();
            }
            Options.CurrentOptions.DisableWindowsDefender = defenderSw.ToggleChecked;
        }

        private void toggleSwitch4_Click(object sender, EventArgs e)
        {
            if (systemRestoreSw.ToggleChecked)
            {
                if (MessageBox.Show(Options.TranslationList["systemRestoreM"].ToString(), "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    _skipSystemRestore = true;
                    systemRestoreSw.ToggleChecked = false;
                    return;
                }

                _skipSystemRestore = false;
                Optimize.DisableSystemRestore();
            }
            else
            {
                if (_skipSystemRestore) return;

                Optimize.EnableSystemRestore();
            }
            if (!_skipSystemRestore) Options.CurrentOptions.DisableSystemRestore = systemRestoreSw.ToggleChecked;
        }

        private void toggleSwitch5_Click(object sender, EventArgs e)
        {
            if (printSw.ToggleChecked)
            {
                Optimize.DisablePrintService();
            }
            else
            {
                Optimize.EnablePrintService();
            }
            Options.CurrentOptions.DisablePrintService = printSw.ToggleChecked;
        }

        private void toggleSwitch6_Click(object sender, EventArgs e)
        {
            if (mediaSharingSw.ToggleChecked)
            {
                Optimize.DisableMediaPlayerSharing();
            }
            else
            {
                Optimize.EnableMediaPlayerSharing();
            }
            Options.CurrentOptions.DisableMediaPlayerSharing = mediaSharingSw.ToggleChecked;
        }

        private void toggleSwitch8_Click(object sender, EventArgs e)
        {
            if (reportingSw.ToggleChecked)
            {
                Optimize.DisableErrorReporting();
            }
            else
            {
                Optimize.EnableErrorReporting();
            }
            Options.CurrentOptions.DisableErrorReporting = reportingSw.ToggleChecked;
        }

        private void toggleSwitch9_Click(object sender, EventArgs e)
        {
            if (homegroupSw.ToggleChecked)
            {
                Optimize.DisableHomeGroup();
            }
            else
            {
                Optimize.EnableHomeGroup();
            }
            Options.CurrentOptions.DisableHomeGroup = homegroupSw.ToggleChecked;
        }

        private void toggleSwitch10_Click(object sender, EventArgs e)
        {
            if (superfetchSw.ToggleChecked)
            {
                Optimize.DisableSuperfetch();
            }
            else
            {
                Optimize.EnableSuperfetch();
            }
            Options.CurrentOptions.DisableSuperfetch = superfetchSw.ToggleChecked;
        }

        private void toggleSwitch11_Click(object sender, EventArgs e)
        {
            if (telemetryTasksSw.ToggleChecked)
            {
                Optimize.DisableTelemetryTasks();
            }
            else
            {
                Optimize.EnableTelemetryTasks();
            }
            Options.CurrentOptions.DisableTelemetryTasks = telemetryTasksSw.ToggleChecked;
        }

        private void toggleSwitch12_Click(object sender, EventArgs e)
        {
            if (officeTelemetrySw.ToggleChecked)
            {
                Optimize.DisableOffice2016Telemetry();
            }
            else
            {
                Optimize.EnableOffice2016Telemetry();
            }
            Options.CurrentOptions.DisableOffice2016Telemetry = officeTelemetrySw.ToggleChecked;
        }

        private void toggleSwitch13_Click(object sender, EventArgs e)
        {
            if (oldMixerSw.ToggleChecked)
            {
                Optimize.EnableLegacyVolumeSlider();
            }
            else
            {
                Optimize.DisableLegacyVolumeSlider();
            }
            Options.CurrentOptions.EnableLegacyVolumeSlider = oldMixerSw.ToggleChecked;
        }

        private void toggleSwitch18_Click(object sender, EventArgs e)
        {
            if (oldExplorerSw.ToggleChecked)
            {
                Optimize.DisableQuickAccessHistory();
            }
            else
            {
                Optimize.EnableQuickAccessHistory();
            }
            Options.CurrentOptions.DisableQuickAccessHistory = oldExplorerSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch26_Click(object sender, EventArgs e)
        {
            if (adsSw.ToggleChecked)
            {
                Optimize.DisableStartMenuAds();
            }
            else
            {
                Optimize.EnableStartMenuAds();
            }
            Options.CurrentOptions.DisableStartMenuAds = adsSw.ToggleChecked;
        }

        private void toggleSwitch14_Click(object sender, EventArgs e)
        {
            if (uODSw.ToggleChecked)
            {
                if (MessageBox.Show(Options.TranslationList["onedriveM"].ToString(), "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    _skipOneDrive = true;
                    uODSw.ToggleChecked = false;
                    return;
                }

                _skipOneDrive = false;

                Task t = new Task(() => Optimize.UninstallOneDrive());
                t.Start();
            }
            else
            {
                if (_skipOneDrive) return;

                Task t = new Task(() => Optimize.InstallOneDrive());
                t.Start();
            }

            if (!_skipOneDrive) Options.CurrentOptions.UninstallOneDrive = uODSw.ToggleChecked;
        }

        private void toggleSwitch25_Click(object sender, EventArgs e)
        {
            if (peopleSw.ToggleChecked)
            {
                Optimize.DisableMyPeople();
            }
            else
            {
                Optimize.EnableMyPeople();
            }
            Options.CurrentOptions.DisableMyPeople = peopleSw.ToggleChecked;
        }

        private void toggleSwitch24_Click(object sender, EventArgs e)
        {
            if (autoUpdatesSw.ToggleChecked)
            {
                Optimize.DisableAutomaticUpdates();
            }
            else
            {
                Optimize.EnableAutomaticUpdates();
            }
            Options.CurrentOptions.DisableAutomaticUpdates = autoUpdatesSw.ToggleChecked;
        }

        private void toggleSwitch30_Click(object sender, EventArgs e)
        {
            if (driversSw.ToggleChecked)
            {
                Optimize.ExcludeDrivers();
            }
            else
            {
                Optimize.IncludeDrivers();
            }
            Options.CurrentOptions.ExcludeDrivers = driversSw.ToggleChecked;
        }

        private void toggleSwitch23_Click(object sender, EventArgs e)
        {
            if (telemetryServicesSw.ToggleChecked)
            {
                Optimize.DisableTelemetryServices();
            }
            else
            {
                Optimize.EnableTelemetryServices();
            }
            Options.CurrentOptions.DisableTelemetryServices = telemetryServicesSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch21_Click(object sender, EventArgs e)
        {
            if (privacySw.ToggleChecked)
            {
                Task t = new Task(() => Optimize.EnhancePrivacy());
                t.Start();
            }
            else
            {
                Task t = new Task(() => Optimize.CompromisePrivacy());
                t.Start();
            }
            Options.CurrentOptions.DisablePrivacyOptions = privacySw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch16_Click(object sender, EventArgs e)
        {
            if (cortanaSw.ToggleChecked)
            {
                Optimize.DisableCortana();
            }
            else
            {
                Optimize.EnableCortana();
            }
            Options.CurrentOptions.DisableCortana = cortanaSw.ToggleChecked;
        }

        private void toggleSwitch20_Click(object sender, EventArgs e)
        {
            if (sensorSw.ToggleChecked)
            {
                Optimize.DisableSensorServices();
            }
            else
            {
                Optimize.EnableSensorServices();
            }
            Options.CurrentOptions.DisableSensorServices = sensorSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch29_Click(object sender, EventArgs e)
        {
            if (inkSw.ToggleChecked)
            {
                Optimize.DisableWindowsInk();
            }
            else
            {
                Optimize.EnableWindowsInk();
            }
            Options.CurrentOptions.DisableWindowsInk = inkSw.ToggleChecked;
        }

        private void toggleSwitch28_Click(object sender, EventArgs e)
        {
            if (spellSw.ToggleChecked)
            {
                Optimize.DisableSpellingAndTypingFeatures();
            }
            else
            {
                Optimize.EnableSpellingAndTypingFeatures();
            }
            Options.CurrentOptions.DisableSpellingTyping = spellSw.ToggleChecked;
        }

        private void toggleSwitch17_Click(object sender, EventArgs e)
        {
            if (xboxSw.ToggleChecked)
            {
                Optimize.DisableXboxLive();
            }
            else
            {
                Optimize.EnableXboxLive();
            }
            Options.CurrentOptions.DisableXboxLive = xboxSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch15_Click(object sender, EventArgs e)
        {
            if (gameBarSw.ToggleChecked)
            {
                Optimize.DisableGameBar();
            }
            else
            {
                Optimize.EnableGameBar();
            }
            Options.CurrentOptions.DisableGameBar = gameBarSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch31_Click(object sender, EventArgs e)
        {
            if (disableOneDriveSw.ToggleChecked)
            {
                Optimize.DisableOneDrive();
            }
            else
            {
                Optimize.EnableOneDrive();
            }
            Options.CurrentOptions.DisableOneDrive = disableOneDriveSw.ToggleChecked;
        }

        private void toggleSwitch32_Click(object sender, EventArgs e)
        {
            if (compatSw.ToggleChecked)
            {
                Optimize.DisableCompatibilityAssistant();
            }
            else
            {
                Optimize.EnableCompatibilityAssistant();
            }
            Options.CurrentOptions.DisableCompatibilityAssistant = compatSw.ToggleChecked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdate();
        }

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            HostsHelper.ReadOnly(chkReadOnly.Checked);

            addHostB.Enabled = !chkReadOnly.Checked;
            removeAllHostsB.Enabled = !chkReadOnly.Checked;
            removeHostB.Enabled = !chkReadOnly.Checked;
            refreshHostsB.Enabled = !chkReadOnly.Checked;
            linkRestoreDefault.Enabled = !chkReadOnly.Checked;
            chkBlock.Enabled = !chkReadOnly.Checked;
            txtDomain.Enabled = !chkReadOnly.Checked;
            txtIP.Enabled = !chkReadOnly.Checked;

            txtIP.Focus();
        }

        private void RenderAppDownloaderBusy()
        {
            btnDownloadApps.Enabled = false;
            changeDownDirB.Enabled = false;
            txtDownloadFolder.ReadOnly = true;

            linkWarnings.Visible = false;
        }

        private void RenderAppDownloaderFree()
        {
            btnDownloadApps.Enabled = true;
            changeDownDirB.Enabled = true;
            txtDownloadFolder.ReadOnly = false;

            linkWarnings.Visible = !string.IsNullOrEmpty(downloadLog);

            txtDownloadStatus.Text = Options.TranslationList["downloadsFinished"];
        }

        string appNameTemp = string.Empty;
        int maxCount = 0;
        int count = 0;
        Process p;
        string downloadLog = string.Empty;

        private async void btnDownloadApps_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtDownloadFolder.Text))
            {
                MessageBox.Show(Options.TranslationList["downloadDirInvalid"].ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RenderAppDownloaderBusy();

            maxCount = 0;
            count = 0;
            downloadLog = string.Empty;

            foreach (Control c in Utilities.GetSelfAndChildrenRecursive(appsTab))
            {
                if (c.Name == "cAutoInstall") continue;
                if (c is MoonCheck && ((MoonCheck)c).Checked) maxCount++;
            }

            MoonCheck currentCheck;
            Control[] temp;

            foreach (FeedApp x in AppsFromFeed)
            {
                if (string.IsNullOrEmpty(x.Tag)) continue;
                temp = appsTab.Controls.Find(x.Tag, true);
                if (temp.Count() == 0) continue;
                currentCheck = (MoonCheck)temp[0];
                if (currentCheck == null) continue;
                if (!currentCheck.Checked) continue;

                appNameTemp = x.Title;

                if (c64.Checked)
                {
                    count++;
                    if (string.IsNullOrEmpty(x.Link64))
                    {
                        downloadLog += "• " + x.Title + ":" + Environment.NewLine + Options.TranslationList["no64Download"] + Environment.NewLine + Environment.NewLine;
                        await DownloadApp(x, false);
                    }
                    else
                    {
                        await DownloadApp(x, true);
                    }
                }
                else
                {
                    count++;
                    if (!string.IsNullOrEmpty(x.Link))
                    {
                        await DownloadApp(x, false);
                    }
                    else
                    {
                        downloadLog += "• " + x.Title + ":" + Environment.NewLine + Options.TranslationList["no32Download"] + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            if (cAutoInstall.Checked)
            {
                count = 0;
                foreach (string a in Directory.GetFiles(txtDownloadFolder.Text, "*.*", SearchOption.TopDirectoryOnly))
                {
                    using (p = new Process())
                    {
                        count++;
                        p.StartInfo.FileName = a;
                        p.EnableRaisingEvents = true;
                        p.StartInfo.WorkingDirectory = txtDownloadFolder.Text;

                        // APP-SPECIFIC HACKS //
                        if (a.ToLowerInvariant().Contains("sumatra")) p.StartInfo.Arguments = " -install";
                        // *** //

                        txtDownloadStatus.Text = string.Format("{0}/{1} - {2} {3} ...", count, maxCount, Options.TranslationList["installing"], Path.GetFileNameWithoutExtension(a));

                        await p.RunAsync();
                    };
                }
            }

            // reset all checkboxes
            foreach (Control c in Utilities.GetSelfAndChildrenRecursive(appsTab))
            {
                if (c.Name == "cAutoInstall") continue;
                if (c is MoonCheck && ((MoonCheck)c).Checked) ((MoonCheck)c).Checked = false;
            }

            RenderAppDownloaderFree();
        }

        string fileExtension = ".exe";
        private async Task DownloadApp(FeedApp app, bool pref64)
        {
            try
            {
                using (WebClient downloader = new WebClient())
                {
                    downloader.Headers.Add("User-Agent: Other");
                    downloader.Encoding = Encoding.UTF8;

                    downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                    downloader.DownloadFileCompleted += Downloader_DownloadFileCompleted;

                    if (pref64)
                    {
                        if (app.Link64.Contains(".msi"))
                        {
                            fileExtension = ".msi";
                        }
                        else
                        {
                            fileExtension = ".exe";
                        }

                        await downloader.DownloadFileTaskAsync(new Uri(app.Link64), Path.Combine(txtDownloadFolder.Text, app.Title + "-x64" + fileExtension));
                    }
                    else
                    {
                        if (app.Link.Contains(".msi"))
                        {
                            fileExtension = ".msi";
                        }
                        else
                        {
                            fileExtension = ".exe";
                        }

                        await downloader.DownloadFileTaskAsync(new Uri(app.Link), Path.Combine(txtDownloadFolder.Text, app.Title + "-x86" + fileExtension));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.DownloadApp", ex.Message, ex.StackTrace);
                downloadLog += "• " + app.Title + ":" + Environment.NewLine + Options.TranslationList["linkInvalid"] + Environment.NewLine + Environment.NewLine;

                if (pref64) try { File.Delete(Path.Combine(txtDownloadFolder.Text, app.Title + "-x64.exe")); } catch { }
                if (!pref64) try { File.Delete(Path.Combine(txtDownloadFolder.Text, app.Title + "-x86.exe")); } catch { }
                if (pref64) try { File.Delete(Path.Combine(txtDownloadFolder.Text, app.Title + "-x64.msi")); } catch { }
                if (!pref64) try { File.Delete(Path.Combine(txtDownloadFolder.Text, app.Title + "-x86.msi")); } catch { }
            }
        }

        private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                //txtDownloadStatus.Text = "Finished";
            });
        }

        int tempProgress;
        private void Downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;

                tempProgress = int.Parse(Math.Truncate(percentage).ToString());

                // if Content-Length header is missing, just show an animation
                if (Math.Abs(tempProgress) > 100)
                {
                    txtDownloadStatus.Text = string.Format("({1}/{2}) - {0} ...", appNameTemp, count, maxCount);
                    progressDownloader.Style = ProgressBarStyle.Marquee;
                }
                // if not, show actual progress
                else
                {
                    txtDownloadStatus.Text = string.Format("({1}/{2}) - {0} - {3} / {4}", appNameTemp, count, maxCount, ByteSize.FromBytes(e.BytesReceived).ToString("MB"), ByteSize.FromBytes(e.TotalBytesToReceive).ToString("MB"));
                    progressDownloader.Style = ProgressBarStyle.Continuous;
                    progressDownloader.Value = tempProgress;
                }
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                txtDownloadFolder.Text = d.SelectedPath;
                Options.CurrentOptions.AppsFolder = d.SelectedPath;
                Options.SaveSettings();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(txtDownloadFolder.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoForm lf = new InfoForm(downloadLog);
            lf.ShowDialog(this);
        }

        private void txtDownloadFolder_TextChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.AppsFolder = txtDownloadFolder.Text;
            Options.SaveSettings();
        }

        private void chkOnlyRemovable_CheckedChanged(object sender, EventArgs e)
        {
            GetModernApps(!chkOnlyRemovable.Checked);
        }

        private void btnGetFeed_Click(object sender, EventArgs e)
        {
            GetFeed();
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(ErrorLogger.ErrorLogFile))
            {
                InfoForm iform = new InfoForm(File.ReadAllText(ErrorLogger.ErrorLogFile, Encoding.UTF8));
                iform.ShowDialog();
            }
            else
            {
                MessageBox.Show(Options.TranslationList["noErrorsM"].ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenConf_Click(object sender, EventArgs e)
        {
            Process.Start(Required.CoreFolder);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPingInput.Text)) return;

            _pingResults = new List<PingReply>();

            listPingResults.Items.Clear();

            if (PingerHelper.PingHost(txtPingInput.Text) == null)
            {
                listPingResults.Items.Add(string.Format("{0} [{1}]", Options.TranslationList["hostNotFound"], txtPingInput.Text));
                return;
            }

            Task pinger = new Task(() =>
            {
                btnShodan.Enabled = false;
                btnPing.Enabled = false;

                listPingResults.Items.Add(string.Format("{0}", Options.TranslationList["pinging"]));
                listPingResults.Items.Add("");

                for (int i = 0; i < 9; i++)
                {
                    // wait before each pinging
                    Thread.Sleep(1000);

                    tmpReply = PingerHelper.PingHost(txtPingInput.Text);

                    if (tmpReply.Address == null)
                    {
                        listPingResults.Items.Add(tmpReply.Status);
                    }
                    else
                    {
                        _pingResults.Add(tmpReply);
                        _shodanIP = _pingResults[i].Address.ToString();
                        listPingResults.Items.Add(string.Format("{0} - {1}: {2} ms - TTL: {3}", _pingResults[i].Status, Options.TranslationList["latency"], _pingResults[i].RoundtripTime, _pingResults[i].Options.Ttl));
                    }
                }

                listPingResults.Items.Add("");

                // calculate statistics
                if (_pingResults.Count > 0)
                {
                    long maxLatency = _pingResults.Max(x => x.RoundtripTime);
                    long minLatency = _pingResults.Min(x => x.RoundtripTime);
                    double averageLatency = _pingResults.Average(x => x.RoundtripTime);

                    listPingResults.Items.Add(string.Format("{0} = {1}, {2} = {3}, {4} = {5:F2}", Options.TranslationList["min"], minLatency, Options.TranslationList["max"], maxLatency, Options.TranslationList["avg"], averageLatency));
                }
                else
                {
                    listPingResults.Items.Add(Options.TranslationList["timeout"]);
                }

                btnPing.Enabled = true;
                btnShodan.Enabled = true;
            });

            pinger.Start();
        }

        private void btnShodan_Click(object sender, EventArgs e)
        {
            IPAddress tryIP;
            if (IPAddress.TryParse(txtPingInput.Text, out tryIP))
            {
                Process.Start(string.Format("https://www.shodan.io/host/{0}", txtPingInput.Text));
                return;
            }

            if (!string.IsNullOrEmpty(_shodanIP))
            {
                Process.Start(string.Format("https://www.shodan.io/host/{0}", _shodanIP));
                return;
            }
        }

        private void copyB_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(_shodanIP);
            }
            catch { }
        }

        private void copyIPB_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtPingInput.Text);
            }
            catch { }
        }

        private void txtPingInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPing.PerformClick();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(ExportDialog.FileName, listPingResults.Items.Cast<string>());
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("btnExport.Click", ex.Message, ex.StackTrace);
                    MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void startupItem_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = startupTab;
            RestoreWindow();
        }

        private void cleanerItem_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = cleanerTab;
            RestoreWindow();
        }

        private void pingerItem_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = pingerTab;
            RestoreWindow();
            txtPingInput.Focus();
        }

        private void hostsItem_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = hostsEditorTab;
            RestoreWindow();
            txtIP.Focus();
        }

        private void appsItem_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = appsTab;
            RestoreWindow();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            _trayMenu = false;

            Options.CurrentOptions.AppsFolder = txtDownloadFolder.Text;
            Options.SaveSettings();

            Application.Exit();
        }

        private void RestoreWindow()
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Activate();
            this.Focus();
        }

        private void launcherIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
                this.Hide();
            }
            else
            {
                RestoreWindow();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_licenseLink);
        }

        private void restartExpolorerItem_Click(object sender, EventArgs e)
        {
            Utilities.RestartExplorer();
        }

        private void flushCacheB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_flushDNSMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PingerHelper.FlushDNSCache();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowBackupConfirm();
        }

        private void ShowBackupConfirm()
        {
            removeStartupItemB.Visible = false;
            locateFileB.Visible = false;
            findInRegB.Visible = false;
            refreshStartupB.Visible = false;
            restoreStartupB.Visible = false;
            backupStartupB.Visible = false;

            lblBackupTitle.Visible = true;
            doBackup.Visible = true;
            cancelBackup.Visible = true;
            txtBackupTitle.Visible = true;
        }

        private void HideBackupConfirm()
        {
            removeStartupItemB.Visible = true;
            locateFileB.Visible = true;
            findInRegB.Visible = true;
            refreshStartupB.Visible = true;
            restoreStartupB.Visible = true;
            backupStartupB.Visible = true;

            lblBackupTitle.Visible = false;
            doBackup.Visible = false;
            cancelBackup.Visible = false;
            txtBackupTitle.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StartupRestoreForm f = new StartupRestoreForm();
            f.ShowDialog(this);

            GetStartupItems();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideBackupConfirm();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackupTitle.Text.Trim()))
            {
                HideBackupConfirm();

                _backupItems.Clear();

                foreach (var x in _startUpItems)
                {
                    _backupItems.Add(new StartupBackupItem(x.Name, x.FileLocation, x.RegistryLocation.ToString(), x.StartupType.ToString()));
                }

                try
                {
                    File.WriteAllText(Required.StartupItemsBackupFolder + Utilities.SanitizeFileFolderName(txtBackupTitle.Text + " - [" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString()) + "].json", JsonConvert.SerializeObject(_backupItems, Formatting.Indented));
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("MainForm.BackupStartupItems", ex.Message, ex.StackTrace);
                }
            }
        }

        private void btnOpenNetwork_Click(object sender, EventArgs e)
        {
            Process.Start("NCPA.cpl");
        }

        private void listStartupItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.ForeColor = Options.ForegroundColor;
            }
            else
            {
                e.Item.ForeColor = Color.White;
            }
        }

        private void trayOptions_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = optionsTab;
            RestoreWindow();
        }

        private void trayRegistry_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = registryFixerTab;
            RestoreWindow();
        }

        private void quickAccessToggle_ToggleClicked(object sender, EventArgs e)
        {
            Options.CurrentOptions.EnableTray = quickAccessToggle.ToggleChecked;
            Options.SaveSettings();

            _trayMenu = quickAccessToggle.ToggleChecked;
            launcherIcon.Visible = quickAccessToggle.ToggleChecked;

            //if (Options.CurrentOptions.EnableTray)
            //{
            //    InitNetworkMonitoring();
            //}
            //else
            //{
            //    DisposeNetworkMonitoring();
            //}
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdate();
        }

        private void hwDetailed_ToggleClicked(object sender, EventArgs e)
        {
            specsTree.Nodes.Clear();

            if (hwDetailed.ToggleChecked)
            {
                specsTree.Nodes.AddRange(_hwDetailed.ToArray());
            }
            else
            {
                specsTree.Nodes.AddRange(_hwSummarized);
            }

            //TranslateIndicium();
            specsTree.ExpandAll();
            specsTree.Nodes[0].EnsureVisible();
        }

        private void trayHW_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = indiciumTab;
            RestoreWindow();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(specsTree.SelectedNode.Text);
            }
            catch { }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (specsTree.Nodes.Count > 0)
            {
                Utilities.SearchWith(specsTree.SelectedNode.Text, false);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (specsTree.Nodes.Count > 0)
            {
                Utilities.SearchWith(specsTree.SelectedNode.Text, true);
            }
        }

        private string GetSpecsToString(TreeView trv)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TreeNode node in trv.Nodes)
            {
                WriteNodeIntoString(0, node, sb);
            }

            return sb.ToString();
        }

        private void WriteNodeIntoString(int level, TreeNode node, StringBuilder sb)
        {
            sb.AppendLine(new string('\t', level) + node.Text);

            foreach (TreeNode child in node.Nodes)
            {
                WriteNodeIntoString(level + 1, child, sb);
            }
        }

        private void specsTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                specsTree.SelectedNode = e.Node;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_discordLink);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_githubProjectLink);
        }

        private void btnCopyHW_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(GetSpecsToString(specsTree));
            }
            catch { }
        }

        private void btnSaveHW_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.InitialDirectory = Application.StartupPath;
            d.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            d.FileName = $"Optimizer_Hardware_{Environment.MachineName}_{DateTime.Now.ToString("dd-MM-yyyy")}.txt";

            if (d.ShowDialog() == DialogResult.OK) File.WriteAllText(d.FileName, GetSpecsToString(specsTree), Encoding.UTF8);
        }

        private string ParseChangelog()
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            List<string> changelogText = new List<string>();

            try
            {
                changelogText = client.DownloadString(_changelogRawLink).Trim().Split(
                    new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.ParseChangelog", ex.Message, ex.StackTrace);
                MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }

            if (changelogText.Count == 0) return string.Empty;

            int markVersion = 0;
            for (int d = 0; d < changelogText.Count; d++)
            {
                if (changelogText[d].Contains($"## [{Program.GetCurrentVersionTostring()}]"))
                {
                    markVersion = d;
                    break;
                }
                else continue;
            }

            changelogText.RemoveRange(markVersion, changelogText.Count - markVersion);

            if (changelogText.Count <= 0)
            {
                MessageBox.Show(_noNewVersionMessage, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return string.Empty;
            }

            return string.Join(Environment.NewLine, changelogText).Replace("##", "➤");
        }

        private void boxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // LANGUAGE SELECTION PROCESSING

            if (boxLang.Text == "English")
            {
                picFlag.Image = Properties.Resources.united_kingdom;
                Options.CurrentOptions.LanguageCode = LanguageCode.EN;
            }
            else if (boxLang.Text == "русский")
            {
                picFlag.Image = Properties.Resources.russia;
                Options.CurrentOptions.LanguageCode = LanguageCode.RU;
            }
            else if (boxLang.Text == "Ελληνικά")
            {
                picFlag.Image = Properties.Resources.greece;
                Options.CurrentOptions.LanguageCode = LanguageCode.EL;
            }
            else if (boxLang.Text == "Deutsch")
            {
                picFlag.Image = Properties.Resources.germany;
                Options.CurrentOptions.LanguageCode = LanguageCode.DE;
            }
            else if (boxLang.Text == "Italiano")
            {
                picFlag.Image = Properties.Resources.italy;
                Options.CurrentOptions.LanguageCode = LanguageCode.IT;
            }
            else if (boxLang.Text == "Čeština")
            {
                picFlag.Image = Properties.Resources.czech;
                Options.CurrentOptions.LanguageCode = LanguageCode.CZ;
            }
            else if (boxLang.Text == "Türkçe")
            {
                picFlag.Image = Properties.Resources.turkey;
                Options.CurrentOptions.LanguageCode = LanguageCode.TR;
            }
            else if (boxLang.Text == "Español")
            {
                picFlag.Image = Properties.Resources.spain;
                Options.CurrentOptions.LanguageCode = LanguageCode.ES;
            }
            else if (boxLang.Text == "Português")
            {
                picFlag.Image = Properties.Resources.brazil;
                Options.CurrentOptions.LanguageCode = LanguageCode.PT;
            }
            else if (boxLang.Text == "Français")
            {
                picFlag.Image = Properties.Resources.france;
                Options.CurrentOptions.LanguageCode = LanguageCode.FR;
            }
            else if (boxLang.Text == "简体中文")
            {
                picFlag.Image = Properties.Resources.china;
                Options.CurrentOptions.LanguageCode = LanguageCode.CN;
            }
            else if (boxLang.Text == "繁體中文")
            {
                picFlag.Image = Properties.Resources.taiwan;
                Options.CurrentOptions.LanguageCode = LanguageCode.TW;
            }
            else if (boxLang.Text == "한국어")
            {
                picFlag.Image = Properties.Resources.korea;
                Options.CurrentOptions.LanguageCode = LanguageCode.KO;
            }
            else if (boxLang.Text == "Polski")
            {
                picFlag.Image = Properties.Resources.poland;
                Options.CurrentOptions.LanguageCode = LanguageCode.PL;
            }
            else if (boxLang.Text == "العربية")
            {
                picFlag.Image = Properties.Resources.egypt;
                Options.CurrentOptions.LanguageCode = LanguageCode.AR;
            }
            else if (boxLang.Text == "کوردی")
            {
                picFlag.Image = Properties.Resources.kurdish;
                Options.CurrentOptions.LanguageCode = LanguageCode.KU;
            }
            else if (boxLang.Text == "Magyar")
            {
                picFlag.Image = Properties.Resources.hungary;
                Options.CurrentOptions.LanguageCode = LanguageCode.HU;
            }
            else if (boxLang.Text == "Română")
            {
                picFlag.Image = Properties.Resources.romania;
                Options.CurrentOptions.LanguageCode = LanguageCode.RO;
            }
            else if (boxLang.Text == "Nederlands")
            {
                picFlag.Image = Properties.Resources.dutch;
                Options.CurrentOptions.LanguageCode = LanguageCode.NL;
            }
            else if (boxLang.Text == "українська")
            {
                picFlag.Image = Properties.Resources.ukraine;
                Options.CurrentOptions.LanguageCode = LanguageCode.UA;
            }
            else if (boxLang.Text == "日本語")
            {
                picFlag.Image = Properties.Resources.japan;
                Options.CurrentOptions.LanguageCode = LanguageCode.JA;
            }

            this.CenterToScreen();
            Options.SaveSettings();
            Options.LoadTranslation();
            Translate();

            optionsTab.Focus();
        }

        private void cleanDriveB_Click(object sender, EventArgs e)
        {
            CleanPC();
        }

        private void checkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _cleanSelectAll = !_cleanSelectAll;
            for (int i = 0; i < listCleanPreview.Items.Count; i++)
            {
                listCleanPreview.SetItemChecked(i, _cleanSelectAll);
            }
        }

        private void analyzeDriveB_Click(object sender, EventArgs e)
        {
            CleanHelper.PreviewSizeToBeFreed = new ByteSize(0);
            CleanHelper.PreviewCleanList.Clear();
            listCleanPreview.Items.Clear();
            PreviewCleanPC();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_paypalSupportLink);
        }

        private void linkDNSIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Clipboard.SetText(((LinkLabel)sender).Text);
            }
            catch { }
        }

        private void boxDNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;

            if (boxDNS.Text == "Automatic")
            {
                PingerHelper.ResetDefaultDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Cloudflare DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.CloudflareDNSv4, PingerHelper.CloudflareDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Open DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.OpenDNSv4, PingerHelper.OpenDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Quad9 DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.Quad9DNSv4, PingerHelper.Quad9DNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Google DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.GoogleDNSv4, PingerHelper.GoogleDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Alternate DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.AlternateDNSv4, PingerHelper.AlternateDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "Adguard DNS")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.AdguardDNSv4, PingerHelper.AdguardDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "CleanBrowsing")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.CleanBrowsingDNSv4, PingerHelper.CleanBrowsingDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
            else if (boxDNS.Text == "CleanBrowsing (adult filter)")
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, PingerHelper.CleanBrowsingAdultDNSv4, PingerHelper.CleanBrowsingAdultDNSv6);
                PingerHelper.GetActiveNetworkAdapters();
                DisplayCurrentDNS();
                return;
            }
        }

        private void DisplayCurrentDNS()
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;

            _currentDNS = PingerHelper.GetDNSFromNetworkAdapter(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();

            if (_currentDNS == null) return;
            if (_currentDNS.Length == 0) return;

            try
            {
                if (_currentDNS.Length == 1)
                {
                    linkDNSv4.Text = _currentDNS[0];
                }
                else if (_currentDNS.Length == 2)
                {
                    linkDNSv4.Text = _currentDNS[0];
                    linkDNSv4A.Text = _currentDNS[1];
                }
                else if (_currentDNS.Length == 3)
                {
                    linkDNSv6.Text = _currentDNS[0];
                    linkDNSv4.Text = _currentDNS[1];
                    linkDNSv4A.Text = _currentDNS[2];
                }
                else if (_currentDNS.Length == 4)
                {
                    linkDNSv4.Text = _currentDNS[2];
                    linkDNSv4A.Text = _currentDNS[3];
                    linkDNSv6.Text = _currentDNS[0];
                    linkDNSv6A.Text = _currentDNS[1];
                }
            }
            catch { }
            finally { pingerTab.Focus(); }
        }

        private void boxAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNetworkAdapterConfig();
            pingerTab.Focus();
        }

        // FIX FOR LAGGING WHEN MOVING THE FORM
        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            bpanel.Controls.Remove(tabCollection);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            bpanel.Controls.Add(tabCollection);
            tabCollection.Dock = DockStyle.Fill;
        }
        // END FIX

        private void PMB_ToggleClicked(object sender, EventArgs e)
        {
            if (PMB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\PowerMenu.reg");
            }
            else
            {
                Integrator.RemoveItem("Power Menu");
            }

            GetDesktopItems();
        }

        private void AddOwnerB_ToggleClicked(object sender, EventArgs e)
        {
            if (AddOwnerB.ToggleChecked)
            {
                Integrator.InstallTakeOwnership(false);
            }
            else
            {
                Integrator.InstallTakeOwnership(true);
            }

            GetDesktopItems();
        }

        private void AddCMDB_ToggleClicked(object sender, EventArgs e)
        {
            if (AddCMDB.ToggleChecked)
            {
                Integrator.InstallOpenWithCMD();
            }
            else
            {
                Integrator.DeleteOpenWithCMD();
            }

            GetDesktopItems();
        }

        private void DSB_ToggleClicked(object sender, EventArgs e)
        {
            if (DSB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\DesktopShortcuts.reg");
            }
            else
            {
                Integrator.RemoveItem("DesktopShortcuts");
            }

            GetDesktopItems();
        }

        private void STB_ToggleClicked(object sender, EventArgs e)
        {
            if (STB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\SystemTools.reg");
            }
            else
            {
                Integrator.RemoveItem("SystemTools");
            }

            GetDesktopItems();
        }

        private void WAB_ToggleClicked(object sender, EventArgs e)
        {
            if (WAB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\WindowsApps.reg");
            }
            else
            {
                Integrator.RemoveItem("WindowsApps");
            }

            GetDesktopItems();
        }

        private void SSB_ToggleClicked(object sender, EventArgs e)
        {
            if (SSB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\SystemShortcuts.reg");
            }
            else
            {
                Integrator.RemoveItem("SystemShortcuts");
            }

            GetDesktopItems();
        }

        private void trayUnlocker_Click(object sender, EventArgs e)
        {
            FileUnlockForm fuf = new FileUnlockForm();
            fuf.ShowDialog(this);
        }

        private void picRestartNeeded_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            Utilities.Reboot();
        }

        private void ShowRestartNeeded()
        {
            restartAndApply.Visible = true;
            picRestartNeeded.Visible = true;
        }

        private void btnWinClean_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }

        private void restartAndApply_MouseLeave(object sender, EventArgs e)
        {
            restartAndApply.Font = new Font(restartAndApply.Font, FontStyle.Regular);
        }

        private void restartAndApply_MouseHover(object sender, EventArgs e)
        {
            restartAndApply.Font = new Font(restartAndApply.Font, FontStyle.Underline);
        }

        private void restartAndApply_MouseEnter(object sender, EventArgs e)
        {
            restartAndApply.Font = new Font(restartAndApply.Font, FontStyle.Underline);
        }

        private void restartAndApply_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            Utilities.Reboot();
        }

        private void colorPicker1_ColorChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = colorPicker1.Color;
            Options.CurrentOptions.Theme = colorPicker1.Color;
            Options.ApplyTheme(this);

            Options.SaveSettings();
        }

        private void autoStartToggle_ToggleClicked(object sender, EventArgs e)
        {
            Options.CurrentOptions.AutoStart = autoStartToggle.ToggleChecked;
            Options.SaveSettings();

            if (Options.CurrentOptions.AutoStart)
            {
                Utilities.RegisterAutoStart();
            }
            else
            {
                Utilities.UnregisterAutoStart();
            }
        }

        private void picLab_Click(object sender, EventArgs e)
        {
            SubForm sf = new SubForm();
            sf.SetTip(translationList["lblLab"].ToString());
            sf.ShowDialog(this);
        }

        private void btnRestoreUwp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UWPHelper.RestoreAllUWPApps();
            }
        }

        private void telemetrySvcToggle_ToggleClicked(object sender, EventArgs e)
        {
            Options.CurrentOptions.DisableOptimizerTelemetry = telemetrySvcToggle.ToggleChecked;
            Options.SaveSettings();

            if (!Options.CurrentOptions.DisableOptimizerTelemetry)
            {
                TelemetryHelper.EnableTelemetryService();
            }
        }
    }
}
