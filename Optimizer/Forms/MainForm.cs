using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class MainForm : Form {
        Dictionary<string, string> translationList;

        List<StartupItem> _startUpItems = new List<StartupItem>();
        List<BackupStartupItem> _backupItems = new List<BackupStartupItem>();

        List<string> _hostsEntries = new List<string>();
        List<string> _customCommands = new List<string>();
        List<string> _desktopItems = new List<string>();
        List<UwpApp> _modernApps = new List<UwpApp>();
        int _modernAppsLoad;

        bool _trayMenu = false;

        List<PingReply> _pingResults;
        string _shodanIP = string.Empty;

        int _tabHeaderHeightMargin = Draw.SI(18);
        int _tabHeaderWidthMargin = Draw.SI(32);

        //NetworkMonitor _networkMonitor;
        //double uploadSpeed = 0;
        //double downloadSpeed = 0;
        //bool _networkMonitoringSupported = true;

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        public List<AppInfo> AppsFromFeed = new List<AppInfo>();
        readonly string _feedLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/feed.json";
        readonly string _feedImages = "https://raw.githubusercontent.com/hellzerg/optimizer/master/images/feed.zip";

        readonly string _licenseLink = "https://www.gnu.org/licenses/gpl-3.0.en.html";
        readonly string _discordLink = "https://discord.gg/RmHYWMxWfJ";
        readonly string _githubProjectLink = "https://github.com/hellzerg/optimizer";
        readonly string _paypalSupportLink = "https://www.paypal.com/paypalme/supportoptimizer";

        readonly string _latestVersionLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/version.txt";
        readonly string _changelogRawLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/CHANGELOG.md";
        readonly string _faqSectionLink = "https://github.com/hellzerg/optimizer/blob/master/FAQ.md";

        readonly string _bugReportLink = "https://github.com/hellzerg/optimizer/issues/new?assignees=&labels=&projects=&template=bug_report.md&title=";
        readonly string _featureRequestLink = "https://github.com/hellzerg/optimizer/issues/new?assignees=&labels=&projects=&template=feature_request.md&title=";

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
        string _reinforcePoliciesMessage = "Are you sure you want to re-apply your current active policies?";

        string _byteSizeNullString = " b";
        string _primaryItemTag = "_primary";

        bool _skipOneDrive = false;
        bool _skipSystemRestore = false;

        string[] _currentDNS;
        string[] _availableFonts;
        List<string> _systemVariables = new List<string>();

        ColorOverrider _colorOverrider;

        List<TreeNode> _hwDetailed;
        TreeNode[] _hwSummarized;

        bool _cleanSelectAll = true;

        UpdateForm _updateForm;

        bool _disableIndicium;
        bool _disableAppsTool;
        bool _disableHostsEditor;
        bool _disableUWPApps;
        bool _disableStartupTool;
        bool _disableCleaner;
        bool _disableIntegrator;
        bool _disablePinger;

        private int GetItemPadding()
        {
            return Program.DPI_PREFERENCE / 2;
        }

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
                Logger.LogError("MainForm.CheckForUpdate", ex.Message, ex.StackTrace);
                MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrEmpty(latestVersion))
            {
                bool conversionSuccess = float.TryParse(latestVersion, out float latestVersionFloat);
                if (!conversionSuccess)
                {
                    return;
                }

                if (latestVersionFloat > Program.GetCurrentVersionToFloat())
                {
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
                            Logger.LogError("MainForm.CheckForUpdate", ex.Message, ex.StackTrace);
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (latestVersionFloat == Program.GetCurrentVersionToFloat())
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
            noMenuDelaySw.ToggleClicked += new EventHandler(NoMenuDelaySw_ToggleClicked);
            allTrayIconsSw.ToggleClicked += new EventHandler(AllTrayIconsSw_ToggleClicked);
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
            edgeAiSw.ToggleClicked += new EventHandler(EdgeAiSw_ToggleClicked);
            edgeTelemetrySw.ToggleClicked += new EventHandler(EdgeTelemetrySw_ToggleClicked);
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
            chatSw.ToggleClicked += new EventHandler(chatSw_Click);
            stickersSw.ToggleClicked += new EventHandler(StickersSw_ToggleClicked);
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
            hpetSw.ToggleClicked += HpetSw_ToggleClicked;
            loginVerboseSw.ToggleClicked += LoginVerboseSw_ToggleClicked;
            classicPhotoViewerSw.ToggleClicked += ClassicPhotoViewerSw_ToggleClicked;
            copilotSw.ToggleClicked += CopilotSw_ToggleClicked;
            hideWeatherSw.ToggleClicked += HideWeatherSw_ToggleClicked;
            hideSearchSw.ToggleClicked += HideSearchSw_ToggleClicked;
            modernStandbySw.ToggleClicked += ModernStandbySw_ToggleClicked;
            newsInterestsSw.ToggleClicked += NewsInterestsSw_ToggleClicked;
            enableUtcSw.ToggleClicked += EnableUtcSw_ToggleClicked;
            regBackupSw.ToggleClicked += RegBackupSw_ToggleClicked;

            PMB.ToggleClicked += PMB_ToggleClicked;
            SSB.ToggleClicked += SSB_ToggleClicked;
            WAB.ToggleClicked += WAB_ToggleClicked;
            STB.ToggleClicked += STB_ToggleClicked;
            DSB.ToggleClicked += DSB_ToggleClicked;
            AddCMDB.ToggleClicked += AddCMDB_ToggleClicked;
            AddOwnerB.ToggleClicked += AddOwnerB_ToggleClicked;
        }

        private void RegBackupSw_ToggleClicked(object sender, EventArgs e)
        {
            if (regBackupSw.ToggleChecked)
            {
                OptimizeHelper.EnablePeriodicRegistryBackup();
            }
            else
            {
                OptimizeHelper.DisablePeriodicRegistryBackup();
            }
            OptionsHelper.CurrentOptions.EnableRegistryBackups = regBackupSw.ToggleChecked;
        }

        private void EnableUtcSw_ToggleClicked(object sender, EventArgs e)
        {
            if (enableUtcSw.ToggleChecked)
            {
                OptimizeHelper.EnableUTCTime();
            }
            else
            {
                OptimizeHelper.DisableUTCTime();
            }
            OptionsHelper.CurrentOptions.EnableUtcTime = enableUtcSw.ToggleChecked;
        }

        private void NewsInterestsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (newsInterestsSw.ToggleChecked)
            {
                OptimizeHelper.DisableNewsInterests();
            }
            else
            {
                OptimizeHelper.EnableNewsInterests();
            }
            OptionsHelper.CurrentOptions.DisableNewsInterests = newsInterestsSw.ToggleChecked;
        }

        private void ModernStandbySw_ToggleClicked(object sender, EventArgs e)
        {
            if (modernStandbySw.ToggleChecked)
            {
                OptimizeHelper.DisableModernStandby();
            }
            else
            {
                OptimizeHelper.EnableModernStandby();
            }
            OptionsHelper.CurrentOptions.DisableModernStandby = modernStandbySw.ToggleChecked;
        }

        private void HideSearchSw_ToggleClicked(object sender, EventArgs e)
        {
            if (hideSearchSw.ToggleChecked)
            {
                OptimizeHelper.HideTaskbarSearch();
            }
            else
            {
                OptimizeHelper.ShowTaskbarSearch();
            }
            OptionsHelper.CurrentOptions.HideTaskbarSearch = hideSearchSw.ToggleChecked;
        }

        private void HideWeatherSw_ToggleClicked(object sender, EventArgs e)
        {
            if (hideWeatherSw.ToggleChecked)
            {
                OptimizeHelper.HideTaskbarWeather();
            }
            else
            {
                OptimizeHelper.ShowTaskbarWeather();
            }
            OptionsHelper.CurrentOptions.HideTaskbarWeather = hideWeatherSw.ToggleChecked;
        }

        private void AllTrayIconsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (allTrayIconsSw.ToggleChecked)
            {
                OptimizeHelper.ShowAllTrayIcons();
            }
            else
            {
                OptimizeHelper.HideTrayIcons();
            }
            OptionsHelper.CurrentOptions.ShowAllTrayIcons = allTrayIconsSw.ToggleChecked;
        }

        private void NoMenuDelaySw_ToggleClicked(object sender, EventArgs e)
        {
            if (noMenuDelaySw.ToggleChecked)
            {
                OptimizeHelper.RemoveMenusDelay();
            }
            else
            {
                OptimizeHelper.RestoreMenusDelay();
            }
            OptionsHelper.CurrentOptions.RemoveMenusDelay = noMenuDelaySw.ToggleChecked;
        }

        private void CopilotSw_ToggleClicked(object sender, EventArgs e)
        {
            if (copilotSw.ToggleChecked)
            {
                OptimizeHelper.DisableCoPilotAI();
            }
            else
            {
                OptimizeHelper.EnableCoPilotAI();
            }
            OptionsHelper.CurrentOptions.DisableCoPilotAI = copilotSw.ToggleChecked;
        }

        private void ClassicPhotoViewerSw_ToggleClicked(object sender, EventArgs e)
        {
            if (classicPhotoViewerSw.ToggleChecked)
            {
                OptimizeHelper.RestoreClassicPhotoViewer();
            }
            else
            {
                OptimizeHelper.DisableClassicPhotoViewer();
            }
            OptionsHelper.CurrentOptions.RestoreClassicPhotoViewer = classicPhotoViewerSw.ToggleChecked;
        }

        private void LoginVerboseSw_ToggleClicked(object sender, EventArgs e)
        {
            if (loginVerboseSw.ToggleChecked)
            {
                Utilities.EnableLoginVerbose();
            }
            else
            {
                Utilities.DisableLoginVerbose();
            }
            OptionsHelper.CurrentOptions.EnableLoginVerbose = loginVerboseSw.ToggleChecked;
        }

        private void HpetSw_ToggleClicked(object sender, EventArgs e)
        {
            if (hpetSw.ToggleChecked)
            {
                Utilities.DisableHPET();
            }
            else
            {
                Utilities.EnableHPET();
            }
            OptionsHelper.CurrentOptions.DisableHPET = hpetSw.ToggleChecked;
        }

        private void EdgeTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (edgeTelemetrySw.ToggleChecked)
            {
                OptimizeHelper.DisableEdgeTelemetry();
            }
            else
            {
                OptimizeHelper.EnableEdgeTelemetry();
            }
            OptionsHelper.CurrentOptions.DisableEdgeTelemetry = edgeTelemetrySw.ToggleChecked;
        }

        private void EdgeAiSw_ToggleClicked(object sender, EventArgs e)
        {
            if (edgeAiSw.ToggleChecked)
            {
                OptimizeHelper.DisableEdgeDiscoverBar();
            }
            else
            {
                OptimizeHelper.EnableEdgeDiscoverBar();
            }
            OptionsHelper.CurrentOptions.DisableEdgeDiscoverBar = edgeAiSw.ToggleChecked;
        }

        private void WinSearchSw_ToggleClicked(object sender, EventArgs e)
        {
            if (winSearchSw.ToggleChecked)
            {
                OptimizeHelper.DisableSearch();
            }
            else
            {
                OptimizeHelper.EnableSearch();
            }
            OptionsHelper.CurrentOptions.DisableSearch = winSearchSw.ToggleChecked;
        }

        private void VbsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (vbsSw.ToggleChecked)
            {
                OptimizeHelper.DisableVirtualizationBasedSecurity();
            }
            else
            {
                OptimizeHelper.EnableVirtualizationBasedSecurity();
            }
            OptionsHelper.CurrentOptions.DisableVBS = vbsSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void NvidiaTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (nvidiaTelemetrySw.ToggleChecked)
            {
                OptimizeHelper.DisableNvidiaTelemetry();
            }
            else
            {
                OptimizeHelper.EnableNvidiaTelemetry();
            }
            OptionsHelper.CurrentOptions.DisableNVIDIATelemetry = nvidiaTelemetrySw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void NtfsStampSw_ToggleClicked(object sender, EventArgs e)
        {
            if (ntfsStampSw.ToggleChecked)
            {
                OptimizeHelper.DisableNTFSTimeStamp();
            }
            else
            {
                OptimizeHelper.EnableNTFSTimeStamp();
            }
            OptionsHelper.CurrentOptions.DisableNTFSTimeStamp = ntfsStampSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void Smb2Sw_ToggleClicked(object sender, EventArgs e)
        {
            if (smb2Sw.ToggleChecked)
            {
                OptimizeHelper.DisableSMB("2");
            }
            else
            {
                OptimizeHelper.EnableSMB("2");
            }
            OptionsHelper.CurrentOptions.DisableSMB2 = smb2Sw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void Smb1Sw_ToggleClicked(object sender, EventArgs e)
        {
            if (smb1Sw.ToggleChecked)
            {
                OptimizeHelper.DisableSMB("1");
            }
            else
            {
                OptimizeHelper.EnableSMB("1");
            }
            OptionsHelper.CurrentOptions.DisableSMB1 = smb1Sw.ToggleChecked;
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
            OptionsHelper.CurrentOptions.DisableHibernation = hibernateSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void StickersSw_ToggleClicked(object sender, EventArgs e)
        {
            if (stickersSw.ToggleChecked)
            {
                OptimizeHelper.DisableStickers();
            }
            else
            {
                OptimizeHelper.EnableStickers();
            }
            OptionsHelper.CurrentOptions.DisableStickers = stickersSw.ToggleChecked;
        }

        private void TpmSw_ToggleClicked(object sender, EventArgs e)
        {
            if (tpmSw.ToggleChecked)
            {
                OptimizeHelper.DisableTPMCheck();
            }
            else
            {
                OptimizeHelper.EnableTPMCheck();
            }
            OptionsHelper.CurrentOptions.DisableTPMCheck = tpmSw.ToggleChecked;
        }

        private void CompactModeSw_ToggleClicked(object sender, EventArgs e)
        {
            if (compactModeSw.ToggleChecked)
            {
                OptimizeHelper.EnableFilesCompactMode();
            }
            else
            {
                OptimizeHelper.DisableFilesCompactMode();
            }
            OptionsHelper.CurrentOptions.CompactMode = compactModeSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void GameModeSw_ToggleClicked(object sender, EventArgs e)
        {
            if (gameModeSw.ToggleChecked)
            {
                OptimizeHelper.EnableGamingMode();
            }
            else
            {
                OptimizeHelper.DisableGamingMode();
            }
            OptionsHelper.CurrentOptions.EnableGamingMode = gameModeSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void VsSw_ToggleClicked(object sender, EventArgs e)
        {
            if (vsSw.ToggleChecked)
            {
                OptimizeHelper.DisableVisualStudioTelemetry();
            }
            else
            {
                OptimizeHelper.EnableVisualStudioTelemetry();
            }
            OptionsHelper.CurrentOptions.DisableVisualStudioTelemetry = vsSw.ToggleChecked;
        }

        private void ChromeTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (chromeTelemetrySw.ToggleChecked)
            {
                OptimizeHelper.DisableChromeTelemetry();
            }
            else
            {
                OptimizeHelper.EnableChromeTelemetry();
            }
            OptionsHelper.CurrentOptions.DisableChromeTelemetry = chromeTelemetrySw.ToggleChecked;
        }

        private void FfTelemetrySw_ToggleClicked(object sender, EventArgs e)
        {
            if (ffTelemetrySw.ToggleChecked)
            {
                OptimizeHelper.DisableFirefoxTelemetry();
            }
            else
            {
                OptimizeHelper.EnableFirefoxTelemetry();
            }
            OptionsHelper.CurrentOptions.DisableFirefoxTemeletry = ffTelemetrySw.ToggleChecked;
        }

        private void ClassicContextSw_Click(object sender, EventArgs e)
        {
            if (classicContextSw.ToggleChecked)
            {
                OptimizeHelper.DisableShowMoreOptions();
            }
            else
            {
                OptimizeHelper.EnableShowMoreOptions();
            }
            OptionsHelper.CurrentOptions.ClassicMenu = classicContextSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void chatSw_Click(object sender, EventArgs e)
        {
            if (chatSw.ToggleChecked)
            {
                OptimizeHelper.DisableChat();
            }
            else
            {
                OptimizeHelper.EnableChat();
            }
            OptionsHelper.CurrentOptions.DisableChat = chatSw.ToggleChecked;
        }

        private void WidgetsSw_Click(object sender, EventArgs e)
        {
            if (widgetsSw.ToggleChecked)
            {
                OptimizeHelper.DisableWidgets();
            }
            else
            {
                OptimizeHelper.EnableWidgets();
            }
            OptionsHelper.CurrentOptions.DisableWidgets = widgetsSw.ToggleChecked;
        }

        private void SnapAssistSw_Click(object sender, EventArgs e)
        {
            if (snapAssistSw.ToggleChecked)
            {
                OptimizeHelper.DisableSnapAssist();
            }
            else
            {
                OptimizeHelper.EnableSnapAssist();
            }
            OptionsHelper.CurrentOptions.DisableSnapAssist = snapAssistSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void LeftTaskbarSw_Click(object sender, EventArgs e)
        {
            if (leftTaskbarSw.ToggleChecked)
            {
                OptimizeHelper.AlignTaskbarToLeft();
            }
            else
            {
                OptimizeHelper.AlignTaskbarToCenter();
            }
            OptionsHelper.CurrentOptions.TaskbarToLeft = leftTaskbarSw.ToggleChecked;
        }

        private void TranslateTips()
        {
            try
            {
                performanceSw.Label.Tag = OptionsHelper.TranslationList["performanceTip"].ToString();
                noMenuDelaySw.Label.Tag = OptionsHelper.TranslationList["noMenuDelaySw"].ToString();
                allTrayIconsSw.Label.Tag = OptionsHelper.TranslationList["allTrayIconsSw"].ToString();
                networkSw.Label.Tag = OptionsHelper.TranslationList["networkTip"].ToString();
                defenderSw.Label.Tag = OptionsHelper.TranslationList["defenderTip"].ToString();
                smartScreenSw.Label.Tag = OptionsHelper.TranslationList["smartScreenTip"].ToString();
                systemRestoreSw.Label.Tag = OptionsHelper.TranslationList["systemRestoreTip"].ToString();
                reportingSw.Label.Tag = OptionsHelper.TranslationList["reportingTip"].ToString();
                telemetryTasksSw.Label.Tag = OptionsHelper.TranslationList["telemetryTasksTip"].ToString();
                officeTelemetrySw.Label.Tag = OptionsHelper.TranslationList["officeTelemetryTip"].ToString();
                printSw.Label.Tag = OptionsHelper.TranslationList["printTip"].ToString();
                faxSw.Label.Tag = OptionsHelper.TranslationList["faxTip"].ToString();
                mediaSharingSw.Label.Tag = OptionsHelper.TranslationList["mediaSharingTip"].ToString();
                stickySw.Label.Tag = OptionsHelper.TranslationList["stickyTip"].ToString();
                homegroupSw.Label.Tag = OptionsHelper.TranslationList["homegroupTip"].ToString();
                superfetchSw.Label.Tag = OptionsHelper.TranslationList["superfetchTip"].ToString();
                compatSw.Label.Tag = OptionsHelper.TranslationList["compatTip"].ToString();
                disableOneDriveSw.Label.Tag = OptionsHelper.TranslationList["disableOneDriveTip"].ToString();
                oldMixerSw.Label.Tag = OptionsHelper.TranslationList["oldMixerTip"].ToString();
                oldExplorerSw.Label.Tag = OptionsHelper.TranslationList["oldExplorerTip"].ToString();
                adsSw.Label.Tag = OptionsHelper.TranslationList["adsTip"].ToString();
                uODSw.Label.Tag = OptionsHelper.TranslationList["uODTip"].ToString();
                peopleSw.Label.Tag = OptionsHelper.TranslationList["peopleTip"].ToString();
                longPathsSw.Label.Tag = OptionsHelper.TranslationList["longPathsTip"].ToString();
                inkSw.Label.Tag = OptionsHelper.TranslationList["inkTip"].ToString();
                spellSw.Label.Tag = OptionsHelper.TranslationList["spellTip"].ToString();
                xboxSw.Label.Tag = OptionsHelper.TranslationList["xboxTip"].ToString();
                autoUpdatesSw.Label.Tag = OptionsHelper.TranslationList["autoUpdatesTip"].ToString();
                driversSw.Label.Tag = OptionsHelper.TranslationList["driversTip"].ToString();
                telemetryServicesSw.Label.Tag = OptionsHelper.TranslationList["telemetryServicesTip"].ToString();
                privacySw.Label.Tag = OptionsHelper.TranslationList["privacyTip"].ToString();
                ccSw.Label.Tag = OptionsHelper.TranslationList["ccTip"].ToString();
                cortanaSw.Label.Tag = OptionsHelper.TranslationList["cortanaTip"].ToString();
                edgeAiSw.Label.Tag = OptionsHelper.TranslationList["edgeAiTip"].ToString();
                edgeTelemetrySw.Label.Tag = OptionsHelper.TranslationList["edgeTelemetryTip"].ToString();
                sensorSw.Label.Tag = OptionsHelper.TranslationList["sensorTip"].ToString();
                castSw.Label.Tag = OptionsHelper.TranslationList["castTip"].ToString();
                gameBarSw.Label.Tag = OptionsHelper.TranslationList["gameBarTip"].ToString();
                insiderSw.Label.Tag = OptionsHelper.TranslationList["insiderTip"].ToString();
                storeUpdatesSw.Label.Tag = OptionsHelper.TranslationList["storeUpdatesTip"].ToString();
                tpmSw.Label.Tag = OptionsHelper.TranslationList["tpmTip"].ToString();
                leftTaskbarSw.Label.Tag = OptionsHelper.TranslationList["leftTaskbarTip"].ToString();
                snapAssistSw.Label.Tag = OptionsHelper.TranslationList["snapAssistTip"].ToString();
                widgetsSw.Label.Tag = OptionsHelper.TranslationList["widgetsTip"].ToString();
                chatSw.Label.Tag = OptionsHelper.TranslationList["chatTip"].ToString();
                stickersSw.Label.Tag = OptionsHelper.TranslationList["stickersTip"].ToString();
                classicContextSw.Label.Tag = OptionsHelper.TranslationList["classicContextTip"].ToString();
                picUpdate.Tag = OptionsHelper.TranslationList["linkUpdate"].ToString() + "!";
                picLab.Tag = OptionsHelper.TranslationList["lblLab"].ToString();
                picRestartNeeded.Tag = OptionsHelper.TranslationList["restartAndApply"].ToString();
                ffTelemetrySw.Label.Tag = OptionsHelper.TranslationList["ffTelemetryTip"].ToString();
                vsSw.Label.Tag = OptionsHelper.TranslationList["vsTip"].ToString();
                chromeTelemetrySw.Label.Tag = OptionsHelper.TranslationList["chromeTelemetryTip"].ToString();
                gameModeSw.Label.Tag = OptionsHelper.TranslationList["gameModeTip"].ToString();
                compactModeSw.Label.Tag = OptionsHelper.TranslationList["compactModeTip"].ToString();
                hibernateSw.Label.Tag = OptionsHelper.TranslationList["hibernateTip"].ToString();
                winSearchSw.Label.Tag = OptionsHelper.TranslationList["winSearchTip"].ToString();
                smb1Sw.Label.Tag = OptionsHelper.TranslationList["smbTip"].ToString().Replace("{v}", "v1");
                smb2Sw.Label.Tag = OptionsHelper.TranslationList["smbTip"].ToString().Replace("{v}", "v2");
                ntfsStampSw.Label.Tag = OptionsHelper.TranslationList["ntfsStampTip"].ToString();
                nvidiaTelemetrySw.Label.Tag = OptionsHelper.TranslationList["nvidiaTelemetrySw"].ToString();
                vbsSw.Label.Tag = OptionsHelper.TranslationList["vbsTip"].ToString();
                hpetSw.Label.Tag = OptionsHelper.TranslationList["hpetSw"].ToString();
                loginVerboseSw.Label.Tag = OptionsHelper.TranslationList["loginVerboseSw"].ToString();
                classicPhotoViewerSw.Label.Tag = OptionsHelper.TranslationList["classicPhotoViewerSw"].ToString();
                copilotSw.Label.Tag = OptionsHelper.TranslationList["copilotTip"].ToString();
                hideWeatherSw.Label.Tag = OptionsHelper.TranslationList["hideWeatherSw"].ToString();
                modernStandbySw.Label.Tag = OptionsHelper.TranslationList["modernStandbySw"].ToString();
                hideSearchSw.Label.Tag = OptionsHelper.TranslationList["hideSearchSw"].ToString();
                newsInterestsSw.Label.Tag = OptionsHelper.TranslationList["newsInterestsSw"].ToString();
                enableUtcSw.Label.Tag = OptionsHelper.TranslationList["enableUtcSw"].ToString();
                regBackupSw.Label.Tag = OptionsHelper.TranslationList["regBackupSw"].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ToggleSwitch40_Click(object sender, EventArgs e)
        {
            if (castSw.ToggleChecked)
            {
                OptimizeHelper.RemoveCastToDevice();
            }
            else
            {
                OptimizeHelper.AddCastToDevice();
            }
            OptionsHelper.CurrentOptions.RemoveCastToDevice = castSw.ToggleChecked;
        }

        private void ToggleSwitch39_Click(object sender, EventArgs e)
        {
            if (longPathsSw.ToggleChecked)
            {
                OptimizeHelper.EnableLongPaths();
            }
            else
            {
                OptimizeHelper.DisableLongPaths();
            }
            OptionsHelper.CurrentOptions.EnableLongPaths = longPathsSw.ToggleChecked;
        }

        private void ToggleSwitch38_Click(object sender, EventArgs e)
        {
            if (stickySw.ToggleChecked)
            {
                OptimizeHelper.DisableStickyKeys();
            }
            else
            {
                OptimizeHelper.EnableStickyKeys();
            }
            OptionsHelper.CurrentOptions.DisableStickyKeys = stickySw.ToggleChecked;
        }

        private void ToggleSwitch37_Click(object sender, EventArgs e)
        {
            if (ccSw.ToggleChecked)
            {
                OptimizeHelper.DisableCloudClipboard();
            }
            else
            {
                OptimizeHelper.EnableCloudClipboard();
            }
            OptionsHelper.CurrentOptions.DisableCloudClipboard = ccSw.ToggleChecked;
        }

        private void ToggleSwitch36_Click(object sender, EventArgs e)
        {
            if (smartScreenSw.ToggleChecked)
            {
                OptimizeHelper.DisableSmartScreen();
            }
            else
            {
                OptimizeHelper.EnableSmartScreen();
            }
            OptionsHelper.CurrentOptions.DisableSmartScreen = smartScreenSw.ToggleChecked;
        }

        private void ToggleSwitch35_Click(object sender, EventArgs e)
        {
            if (storeUpdatesSw.ToggleChecked)
            {
                OptimizeHelper.DisableStoreUpdates();
            }
            else
            {
                OptimizeHelper.EnableStoreUpdates();
            }
            OptionsHelper.CurrentOptions.DisableStoreUpdates = storeUpdatesSw.ToggleChecked;
        }

        private void ToggleSwitch34_Click(object sender, EventArgs e)
        {
            if (insiderSw.ToggleChecked)
            {
                OptimizeHelper.DisableInsiderService();
            }
            else
            {
                OptimizeHelper.EnableInsiderService();
            }
            OptionsHelper.CurrentOptions.DisableInsiderService = insiderSw.ToggleChecked;
        }

        private void ToggleSwitch33_Click(object sender, EventArgs e)
        {
            if (faxSw.ToggleChecked)
            {
                OptimizeHelper.DisableFaxService();
            }
            else
            {
                OptimizeHelper.EnableFaxService();
            }
            OptionsHelper.CurrentOptions.DisableFaxService = faxSw.ToggleChecked;
        }

        //ROOT
        public MainForm(bool? disableIndicium = null, bool? disableHostsEditor = null, bool? disableCommonApps = null, bool? disableUWPApps = null, bool? disableStartups = null, bool? disableCleaner = null, bool? disableIntegrator = null, bool? disablePinger = null)
        {
            InitializeComponent();
            InitModernTabs();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            CheckForIllegalCrossThreadCalls = false;

            boxLang.Items.AddRange(new string[]
            {
                Constants.ENGLISH,
                Constants.RUSSIAN,
                Constants.TURKISH,
                Constants.HELLENIC,
                Constants.GERMAN,
                Constants.PORTUGUESE,
                Constants.FRENCH,
                Constants.SPANISH,
                Constants.ITALIAN,
                Constants.CHINESE,
                Constants.TAIWANESE,
                Constants.CZECH,
                Constants.KOREAN,
                Constants.POLISH,
                Constants.ARABIC,
                Constants.KURDISH,
                Constants.HUNGARIAN,
                Constants.ROMANIAN,
                Constants.DUTCH,
                Constants.UKRAINIAN,
                Constants.JAPANESE,
                Constants.PERSIAN,
                Constants.NEPALI,
                Constants.BULGARIAN,
                Constants.VIETNAMESE,
                Constants.URDU,
                Constants.INDONESIAN,
                Constants.CROATIAN
            });

            // override tool launch configurations
            _disableStartupTool = (disableStartups.HasValue) ? disableStartups.Value : OptionsHelper.CurrentOptions.DisableStartupTool;
            _disableUWPApps = (disableUWPApps.HasValue) ? disableUWPApps.Value : OptionsHelper.CurrentOptions.DisableUWPApps;
            _disableAppsTool = (disableCommonApps.HasValue) ? disableCommonApps.Value : OptionsHelper.CurrentOptions.DisableAppsTool;
            _disablePinger = (disablePinger.HasValue) ? disablePinger.Value : OptionsHelper.CurrentOptions.DisablePinger;
            _disableCleaner = (disableCleaner.HasValue) ? disableCleaner.Value : OptionsHelper.CurrentOptions.DisableCleaner;
            _disableHostsEditor = (disableHostsEditor.HasValue) ? disableHostsEditor.Value : OptionsHelper.CurrentOptions.DisableHostsEditor;
            _disableIndicium = (disableIndicium.HasValue) ? disableIndicium.Value : OptionsHelper.CurrentOptions.DisableIndicium;
            _disableIntegrator = (disableIntegrator.HasValue) ? disableIntegrator.Value : OptionsHelper.CurrentOptions.DisableIntegrator;

            // theming
            OptionsHelper.ApplyTheme(this);
            LogoArt.Apply(pictureBox1);
            // the theme was just applied; only re-theme if the picker normalized the stored color
            colorPicker1.ColorChanged -= colorPicker1_ColorChanged;
            colorPicker1.Color = OptionsHelper.CurrentOptions.Theme;
            colorPicker1.ColorChanged += colorPicker1_ColorChanged;
            if (colorPicker1.Color.ToArgb() != OptionsHelper.CurrentOptions.Theme.ToArgb()) colorPicker1_ColorChanged(colorPicker1, EventArgs.Empty);

            TagMenuGlyphs();
            ThemeManager.ApplyMenu(launcherMenu);
            ThemeManager.ApplyMenu(indiciumMenu);
            SetupNavigation();

            // quick access
            _trayMenu = OptionsHelper.CurrentOptions.EnableTray;
            quickAccessToggle.ToggleChecked = OptionsHelper.CurrentOptions.EnableTray;
            launcherIcon.Visible = OptionsHelper.CurrentOptions.EnableTray;
            autoStartToggle.ToggleChecked = OptionsHelper.CurrentOptions.AutoStart;
            autoUpdateToggle.ToggleChecked = OptionsHelper.CurrentOptions.UpdateOnLaunch;
            themeModeToggle.ToggleChecked = OptionsHelper.CurrentOptions.ThemeMode == ThemeMode.Dark;
            //telemetrySvcToggle.ToggleChecked = Options.CurrentOptions.DisableOptimizerTelemetry;

            //seperatorNetMon.Visible = Options.CurrentOptions.EnableTray;
            //trayDownSpeed.Visible = Options.CurrentOptions.EnableTray;
            //trayUpSpeed.Visible = Options.CurrentOptions.EnableTray;

            // fix SSL/TLS error when contacting internet
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // initial states
            checkDefaultIcon.Checked = true;
            radioProgram.Checked = true;
            radioTop.Checked = true;
            disableOneDriveSw.Visible = false;
            c64.Checked = Environment.Is64BitOperatingSystem;
            c32.Checked = !Environment.Is64BitOperatingSystem;

            // Windows version, architecture, .NET Framework
            txtOS.Text = Utilities.GetOS();
            txtBitness.Text = Utilities.GetBitness();
            txtNetFw.Text = ".NET Framework " + Utilities.GetNETFramework();

            // system color overriding
            _colorOverrider = new ColorOverrider();
            ApplySystemColors();

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Unsupported)
            {
                tabCollection.TabPages.Remove(universalTab);
                tabCollection.TabPages.Remove(windows10Tab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
            {
                LoadUniversalToggleStates();

                tabCollection.TabPages.Remove(windows10Tab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
            {
                LoadUniversalToggleStates();
                LoadWindows8ToggleStates();
                disableOneDriveSw.Visible = true;

                tabCollection.TabPages.Remove(windows10Tab);

                if (!_disableUWPApps)
                {
                    chkOnlyRemovable.Visible = false;
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
                LoadWindows10ToggleStates();

                defenderSw.Visible = false;
                vbsSw.Visible = false;
                oldMixerSw.Visible = true;
                this.Controls.Remove(panelWin11Tweaks);

                if (!_disableUWPApps)
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
                LoadWindows10ToggleStates();
                LoadWindows11ToggleStates();

                windows10Tab.Text = "Windows 11";
                defenderSw.Visible = false;
                vbsSw.Visible = true;
                panelWin11Tweaks.Visible = true;
                oldMixerSw.Visible = false;

                if (!_disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            InitStartupUi();

            specsTree.ImageList = imagesHw;

            // STARTUP ITEMS
            if (!_disableStartupTool)
            {
                GetStartupItems();
            }
            else
            {
                tabCollection.TabPages.Remove(startupTab);
                launcherMenu.Items.RemoveByKey("trayStartup");
            }

            // HOSTS EDITOR
            if (!_disableHostsEditor)
            {
                GetHostsEntries();
            }
            else
            {
                tabCollection.TabPages.Remove(hostsEditorTab);
                launcherMenu.Items.RemoveByKey("trayHosts");
            }

            // INTEGRATOR
            if (!_disableIntegrator)
            {
                LoadReadyMenusState();
                GetDesktopItems();
                GetCustomCommands();
                LoadAvailableFonts();
                LoadSystemVariables();
            }
            else
            {
                tabCollection.TabPages.Remove(integratorTab);
            }

            // APPS DOWNLOADER
            if (!_disableAppsTool)
            {
                GetFeedAsync();
                txtDownloadFolder.ReadOnly = true;
            }
            else
            {
                tabCollection.TabPages.Remove(appsTab);
                launcherMenu.Items.RemoveByKey("trayAD");
            }

            // CLEANER
            if (!_disableCleaner)
            {
                GetFootprint();
            }
            else
            {
                tabCollection.TabPages.Remove(cleanerTab);
                launcherMenu.Items.RemoveByKey("trayCleaner");
            }

            // INDICIUM
            if (!_disableIndicium)
            {
                LoadHardwareSpecsAsync();
            }
            else
            {
                tabCollection.TabPages.Remove(indiciumTab);
                launcherMenu.Items.RemoveByKey("trayHW");
            }

            // PINGER
            if (!_disablePinger)
            {
                boxDNS.Items.AddRange(PingerHelper.DNSOptions);
                LoadPingerDNSConfig();
                DisplayCurrentDNS();
                boxAdapter.SelectedIndexChanged += boxAdapter_SelectedIndexChanged;
            }
            else
            {
                tabCollection.TabPages.Remove(pingerTab);
                launcherMenu.Items.RemoveByKey("trayPinger");
            }

            // ADVANCED
            if (Program.UNSAFE_MODE)
            {
                LoadAdvancedToggleStates();
            }
            else
            {
                tabCollection.TabPages.Remove(advancedTab);
            }

            Program._MainForm = this;

            // if AppsFolder is a malformed or non-existent path, reset it to default
            if (!string.IsNullOrWhiteSpace(OptionsHelper.CurrentOptions.AppsFolder) && !Directory.Exists(OptionsHelper.CurrentOptions.AppsFolder))
            {
                OptionsHelper.CurrentOptions.AppsFolder = string.Empty;
                OptionsHelper.SaveSettings();
            }

            if (OptionsHelper.CurrentOptions.UpdateOnLaunch)
            {
                if (!Program.EXPERIMENTAL_BUILD)
                {
                    CheckForUpdateOnLaunchAsync();
                }
            }

            if (Program.EXPERIMENTAL_BUILD)
            {
                btnUpdate.Enabled = false;
                picLab.Visible = true;
            }

            //InitNetworkMonitoring();
            LoadTranslation();
            EnableToggleEvents();

            WindowState = FormWindowState.Maximized;
        }

        private void LoadSystemVariables()
        {
            listSystemVariables.Items.Clear();
            _systemVariables = IntegratorHelper.GetPathSystemVariables().ToList();
            listSystemVariables.Items.AddRange(_systemVariables.ToArray());
            UpdateIntegratorCounts();
        }

        private void LoadAvailableFonts()
        {
            listFonts.Items.Clear();
            _availableFonts = FontHelper.GetAvailableFonts().ToArray();
            listFonts.Items.AddRange(_availableFonts);
            string currentFont = FontHelper.GetCurrentGlobalFont();
            lblCurrentFont.Text = !string.IsNullOrEmpty(currentFont) ? currentFont : "-";
            lblFontsNumber.Text = _availableFonts.Length.ToString();
            UpdateIntegratorCounts();
        }

        private void FixTabHeaderWidth(TabControl tabControl)
        {
            int maxTextWidth = 0;
            int maxTextHeight = 0;

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var tabWidth = TextRenderer.MeasureText(tabControl.TabPages[i]?.Text, tabControl.TabPages[i]?.Font).Width;
                var tabHeight = TextRenderer.MeasureText(tabControl.TabPages[i]?.Text, tabControl.TabPages[i]?.Font).Height;
                if (tabWidth > maxTextWidth) maxTextWidth = tabWidth;
                if (tabHeight > maxTextHeight) maxTextHeight = tabHeight;
            }

            tabControl.ItemSize = new Size(maxTextWidth + _tabHeaderWidthMargin, maxTextHeight + _tabHeaderHeightMargin);
        }

        private void LoadReadyMenusState()
        {
            AddCMDB.ToggleChecked = IntegratorHelper.OpenWithCMDExists();
            AddOwnerB.ToggleChecked = IntegratorHelper.TakeOwnershipExists();
            DSB.ToggleChecked = IntegratorHelper.DesktopItemExists("DesktopShortcuts");
            PMB.ToggleChecked = IntegratorHelper.DesktopItemExists("Power Menu");
            SSB.ToggleChecked = IntegratorHelper.DesktopItemExists("SystemShortcuts");
            STB.ToggleChecked = IntegratorHelper.DesktopItemExists("SystemTools");
            WAB.ToggleChecked = IntegratorHelper.DesktopItemExists("WindowsApps");
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
            if (boxAdapter.SelectedIndex < 0 || boxAdapter.SelectedIndex >= PingerHelper.NetworkAdapters.Length) return;

            _currentDNS = PingerHelper.GetDNSFromNetworkAdapter(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();
            ShowCurrentDNS();
            if (_currentDNS == null || _currentDNS.Length == 0) return;

            string provider = MatchDnsProvider(_currentDNS);
            if (provider != null)
            {
                boxDNS.Text = provider;
                chkCustomDns.Checked = false;
                return;
            }

            boxDNS.Text = Constants.CustomDNS;
            chkCustomDns.Checked = true;
            string[] v4, v6;
            SplitDnsByFamily(_currentDNS, out v4, out v6);
            txtDns4A.Text = v4.Length > 0 ? v4[0] : string.Empty;
            txtDns4B.Text = v4.Length > 1 ? v4[1] : string.Empty;
            txtDns6A.Text = v6.Length > 0 ? v6[0] : string.Empty;
            txtDns6B.Text = v6.Length > 1 ? v6[1] : string.Empty;
        }

        internal static string MatchDnsProvider(string[] current)
        {
            foreach (KeyValuePair<string, string[]> p in new[]
            {
                new KeyValuePair<string, string[]>(Constants.CloudflareDNS, PingerHelper.CloudflareDNSv4),
                new KeyValuePair<string, string[]>(Constants.OpenDNS, PingerHelper.OpenDNSv4),
                new KeyValuePair<string, string[]>(Constants.Quad9DNS, PingerHelper.Quad9DNSv4),
                new KeyValuePair<string, string[]>(Constants.GoogleDNS, PingerHelper.GoogleDNSv4),
                new KeyValuePair<string, string[]>(Constants.AlternateDNS, PingerHelper.AlternateDNSv4),
                new KeyValuePair<string, string[]>(Constants.AdguardDNS, PingerHelper.AdguardDNSv4),
                new KeyValuePair<string, string[]>(Constants.CleanBrowsingDNS, PingerHelper.CleanBrowsingDNSv4),
                new KeyValuePair<string, string[]>(Constants.CleanBrowsingAdultFilterDNS, PingerHelper.CleanBrowsingAdultDNSv4),
            })
            {
                if (Array.Exists(p.Value, x => current.Contains(x))) return p.Key;
            }
            return null;
        }

        internal static void SplitDnsByFamily(string[] all, out string[] v4, out string[] v6)
        {
            List<string> a = new List<string>(), b = new List<string>();
            foreach (string s in all ?? new string[0])
            {
                IPAddress ip;
                if (!IPAddress.TryParse(s, out ip)) continue;
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6) b.Add(s);
                else a.Add(s);
            }
            v4 = a.ToArray();
            v6 = b.ToArray();
        }

        private void ShowCurrentDNS()
        {
            string[] v4, v6;
            SplitDnsByFamily(_currentDNS, out v4, out v6);
            linkDNSv4.Text = v4.Length > 0 ? v4[0] : "-";
            linkDNSv4A.Text = v4.Length > 1 ? v4[1] : "-";
            linkDNSv6.Text = v6.Length > 0 ? v6[0] : "-";
            linkDNSv6A.Text = v6.Length > 1 ? v6[1] : "-";
            if (_dnsCurrentCard != null) LayoutDnsTab();
        }
        private void SetDNS(string[] v4, string[] v6)
        {
            if (chkAllNics.Checked)
            {
                PingerHelper.SetDNSForAllNICs(v4, v6);
            }
            else
            {
                PingerHelper.SetDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, v4, v6);
            }
            PingerHelper.GetActiveNetworkAdapters();
            DisplayCurrentDNS();
        }

        private void ResetDNS()
        {
            if (chkAllNics.Checked)
            {
                PingerHelper.ResetDefaultDNSForAllNICs();
            }
            else
            {
                PingerHelper.ResetDefaultDNS(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name);
            }
            PingerHelper.GetActiveNetworkAdapters();
            DisplayCurrentDNS();
        }

        private void ApplyCustomDNS()
        {
            string[] customDns4 =
            {
                txtDns4A.Text,
                txtDns4B.Text
            };
            string[] customDns6 =
            {
                txtDns6A.Text,
                txtDns6B.Text
            };

            if (Array.Exists(customDns4, x => string.IsNullOrEmpty(x)) || Array.Exists(customDns6, x => string.IsNullOrEmpty(x)))
            {
                return;
            }

            SetDNS(customDns4, customDns6);

            txtDns4A.Text = string.Empty;
            txtDns4B.Text = string.Empty;
            txtDns6A.Text = string.Empty;
            txtDns6B.Text = string.Empty;
        }

        private void ApplySelectedDNS()
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;

            if (boxDNS.Text == Constants.AutomaticDNS)
            {
                ResetDNS();
                return;
            }
            else if (boxDNS.Text == Constants.CloudflareDNS)
            {
                SetDNS(PingerHelper.CloudflareDNSv4, PingerHelper.CloudflareDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.OpenDNS)
            {
                SetDNS(PingerHelper.OpenDNSv4, PingerHelper.OpenDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.Quad9DNS)
            {
                SetDNS(PingerHelper.Quad9DNSv4, PingerHelper.Quad9DNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.GoogleDNS)
            {
                SetDNS(PingerHelper.GoogleDNSv4, PingerHelper.GoogleDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.AlternateDNS)
            {
                SetDNS(PingerHelper.AlternateDNSv4, PingerHelper.AlternateDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.AdguardDNS)
            {
                SetDNS(PingerHelper.AdguardDNSv4, PingerHelper.AdguardDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.CleanBrowsingDNS)
            {
                SetDNS(PingerHelper.CleanBrowsingDNSv4, PingerHelper.CleanBrowsingDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.CleanBrowsingAdultFilterDNS)
            {
                SetDNS(PingerHelper.CleanBrowsingAdultDNSv4, PingerHelper.CleanBrowsingAdultDNSv6);
                return;
            }
        }

        private void LoadTranslation()
        {
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.EN)
            {
                boxLang.Text = Constants.ENGLISH;
                Translate(true);
            }
            else
            {
                Translate();
            }

            // set default window size to fit content
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.RU)
            {
                boxLang.Text = Constants.RUSSIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.TR)
            {
                boxLang.Text = Constants.TURKISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.EL)
            {
                boxLang.Text = Constants.HELLENIC;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.DE)
            {
                boxLang.Text = Constants.GERMAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.PT)
            {
                boxLang.Text = Constants.PORTUGUESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.FR)
            {
                boxLang.Text = Constants.FRENCH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.ES)
            {
                boxLang.Text = Constants.SPANISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.IT)
            {
                boxLang.Text = Constants.ITALIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.CN)
            {
                boxLang.Text = Constants.CHINESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.TW)
            {
                boxLang.Text = Constants.TAIWANESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.CZ)
            {
                boxLang.Text = Constants.CZECH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.KO)
            {
                boxLang.Text = Constants.KOREAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.PL)
            {
                boxLang.Text = Constants.POLISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.AR)
            {
                boxLang.Text = Constants.ARABIC;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.KU)
            {
                boxLang.Text = Constants.KURDISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.HU)
            {
                boxLang.Text = Constants.HUNGARIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.RO)
            {
                boxLang.Text = Constants.ROMANIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.NL)
            {
                boxLang.Text = Constants.DUTCH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.UA)
            {
                boxLang.Text = Constants.UKRAINIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.JA)
            {
                boxLang.Text = Constants.JAPANESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.FA)
            {
                boxLang.Text = Constants.PERSIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.NE)
            {
                boxLang.Text = Constants.NEPALI;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.BG)
            {
                boxLang.Text = Constants.BULGARIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.VN)
            {
                boxLang.Text = Constants.VIETNAMESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.UR)
            {
                boxLang.Text = Constants.URDU;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.ID)
            {
                boxLang.Text = Constants.INDONESIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.HR)
            {
                boxLang.Text = Constants.CROATIAN;
            }
        }

        private void BuildHardwareTree(HardwareSnapshot hw)
        {
            specsTree.BeginUpdate();
            GetCPUs(hw);
            GetRAM(hw);
            GetGPUs(hw);
            GetMotherboards(hw);
            GetStorage(hw);
            GetNetworkAdapters(hw);
            GetAudioDevices(hw);
            GetPeripherals(hw);
            GetOSInfo();

            _hwDetailed = specsTree.Nodes.Cast<TreeNode>().ToList();
            _hwSummarized = BuildHardwareSummaryNodes();

            specsTree.ExpandAll();
            if (specsTree.Nodes.Count > 0) specsTree.Nodes[0].EnsureVisible();
            specsTree.EndUpdate();

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

        private void GetAudioDevices(HardwareSnapshot hw)
        {
            List<AudioDevice> audios = hw.Audio;

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

        private void GetPeripherals(HardwareSnapshot hw)
        {

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

        private void GetNetworkAdapters(HardwareSnapshot hw)
        {

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

        private void GetStorage(HardwareSnapshot hw)
        {
            List<Disk> disks = hw.Disks;

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

        private void GetCPUs(HardwareSnapshot hw)
        {
            List<CPU> cpus = hw.CPUs;

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

        private void GetMotherboards(HardwareSnapshot hw)
        {
            List<Motherboard> mobos = hw.Motherboards;

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

        private void GetGPUs(HardwareSnapshot hw)
        {
            List<GPU> gpus = hw.GPUs;

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

        private void GetRAM(HardwareSnapshot hw)
        {
            List<RAM> ramInfo = hw.RAM;
            VirtualMemory vm = hw.VM;

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

        private void Translate(bool skipFull = false)
        {
            translationList = OptionsHelper.TranslationList.ToObject<Dictionary<string, string>>();

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
                _noNewVersionMessage = OptionsHelper.TranslationList["noNewVersion"];
                _betaVersionMessage = OptionsHelper.TranslationList["betaVersion"];
                _newVersionMessage = OptionsHelper.TranslationList["newVersion"];
                _restartMessage = OptionsHelper.TranslationList["restartAndApply"];
                _removeStartupItemsMessage = OptionsHelper.TranslationList["removeAllStartup"];
                _removeHostsEntriesMessage = OptionsHelper.TranslationList["removeAllHosts"];
                _removeDesktopItemsMessage = OptionsHelper.TranslationList["removeAllItems"];
                _removeModernAppsMessage = OptionsHelper.TranslationList["removeModernApps"];
                _errorModernAppsMessage = OptionsHelper.TranslationList["errorModernApps"];
                _repairMessage = OptionsHelper.TranslationList["resetMessage"];
                _uwpRestoreMessage = OptionsHelper.TranslationList["restoreUwpMessage"];
                _reinforcePoliciesMessage = OptionsHelper.TranslationList["msgReinforce"];
                _flushDNSMessage = OptionsHelper.TranslationList["flushDNSMessage"];

                _startupSortNames = new[] { translationList["startupItemName"], translationList["startupItemLocation"], translationList["startupItemType"] };
                ApplyStartupSortNames();
                chkStartupSelectAll.Text = translationList["chkSelectAllModernApps"];
                StartupCard.LocateFileText = translationList["locateFileB"];
                StartupCard.LocateKeyText = translationList["findInRegB"];
                StartupCard.DeleteText = translationList["removeStartupItemB"];
                LayoutStartupTab();
                RefreshModernTabStrings();

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

                Control element;
                foreach (var x in translationList)
                {
                    if (x.Key == null || x.Key == string.Empty) continue;
                    element = this.Controls.Find(x.Key, true).FirstOrDefault();

                    if (element == null) continue;

                    if (element is ToggleCard tc)
                    {
                        tc.LabelText = x.Value;
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

        private void PopulateEmbeddedFeed()
        {
            // online feed unavailable: fall back to the copy embedded at build time
            try
            {
                var assembly = typeof(MainForm).Assembly;
                string feed;
                using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(EmbeddedFeedResource), Encoding.UTF8))
                {
                    feed = reader.ReadToEnd();
                }
                PopulateFeed(feed, null);
            }
            catch (Exception ex)
            {
                btnDownloadApps.Enabled = false;
                txtFeedError.Visible = true;
                LayoutAppsTab();

                Logger.LogError("MainForm.GetFeed-Embedded", ex.Message, ex.StackTrace);
            }
        }

        const string EmbeddedFeedResource = "Optimizer.Feed.feed.json";

        static Bitmap _placeholderAppIcon;

        // The embedded feed ships without icons; a white glyph lets GlyphTint recolor it per theme.
        static Bitmap PlaceholderAppIcon
        {
            get
            {
                if (_placeholderAppIcon == null)
                {
                    Bitmap bmp = new Bitmap(64, 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        SidebarNav.PaintGlyph(g, SidebarNav.Glyph.Apps, new Rectangle(8, 8, 48, 48), Color.White);
                    }
                    _placeholderAppIcon = bmp;
                }
                return _placeholderAppIcon;
            }
        }

        sealed class FeedWebClient : WebClient {
            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest request = base.GetWebRequest(address);
                request.Timeout = 15000;
                return request;
            }
        }

        private void PopulateFeed(string feed, Func<string, Stream> openImage)
        {
            AppsFromFeed = JsonConvert.DeserializeObject<List<AppInfo>>(feed);
            string tmpImageFileName;

            AppCard appCard;
            Control[] feedGroups = { groupSystemTools, groupInternet, groupCoding, groupSoundVideo };
            foreach (Control group in feedGroups) group.SuspendLayout();
            try
            {
                groupSystemTools.Controls.Clear();
                groupInternet.Controls.Clear();
                groupCoding.Controls.Clear();
                groupSoundVideo.Controls.Clear();

                foreach (AppInfo x in AppsFromFeed)
                {
                    appCard = new AppCard();
                    appCard.AutoSize = true;
                    appCard.Anchor = AnchorStyles.None;
                    appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    appCard.appTitle.Text = x.Title;
                    appCard.appTitle.Name = x.Tag;
                    appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;

                    if (openImage == null)
                    {
                        appCard.appImage.Image = PlaceholderAppIcon;
                        GlyphTint.Apply(appCard.appImage, ThemeManager.Current);
                    }
                    else
                    {
                        tmpImageFileName = x.Image.Substring(x.Image.LastIndexOf("/") + 1, x.Image.Length - (x.Image.LastIndexOf("/") + 1));
                        using (Stream entry = openImage(tmpImageFileName))
                        using (Image loaded = Image.FromStream(entry))
                        {
                            // GDI+ decodes lazily, so detach the image from the zip stream
                            appCard.appImage.Image = new Bitmap(loaded);
                        }
                    }

                    switch (x.Group)
                    {
                        case "SystemTools":
                            appCard.Location = new Point(0, groupSystemTools.Controls.Count * GetItemPadding());
                            groupSystemTools.Controls.Add(appCard);
                            break;
                        case "Internet":
                            appCard.Location = new Point(0, groupInternet.Controls.Count * GetItemPadding());
                            groupInternet.Controls.Add(appCard);
                            break;
                        case "Coding":
                            appCard.Location = new Point(0, groupCoding.Controls.Count * GetItemPadding());
                            groupCoding.Controls.Add(appCard);
                            break;
                        case "GraphicsSound":
                            appCard.Location = new Point(0, groupSoundVideo.Controls.Count * GetItemPadding());
                            groupSoundVideo.Controls.Add(appCard);
                            break;
                        default:
                            break;
                    }
                }
            }
            finally
            {
                foreach (Control group in feedGroups) group.ResumeLayout();
            }

            // UI handling
            btnDownloadApps.Enabled = true;
            txtFeedError.Visible = false;
            OnAppsFeedPopulated();
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
                Logger.LogError("MainForm.FixRegistry", ex.Message, ex.StackTrace);
            }

            return changeDetected;
        }

        private void LoadAdvancedToggleStates()
        {
            hpetSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableHPET;
            loginVerboseSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableLoginVerbose;
            regBackupSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableRegistryBackups;
        }

        private void LoadUniversalToggleStates()
        {
            performanceSw.ToggleChecked = OptionsHelper.CurrentOptions.EnablePerformanceTweaks;
            allTrayIconsSw.ToggleChecked = OptionsHelper.CurrentOptions.ShowAllTrayIcons;
            noMenuDelaySw.ToggleChecked = OptionsHelper.CurrentOptions.RemoveMenusDelay;
            networkSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableNetworkThrottling;
            defenderSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableWindowsDefender;
            systemRestoreSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSystemRestore;
            printSw.ToggleChecked = OptionsHelper.CurrentOptions.DisablePrintService;
            mediaSharingSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableMediaPlayerSharing;
            reportingSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableErrorReporting;
            homegroupSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableHomeGroup;
            superfetchSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSuperfetch;
            telemetryTasksSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableTelemetryTasks;
            officeTelemetrySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableOffice2016Telemetry;
            compatSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableCompatibilityAssistant;
            faxSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableFaxService;
            smartScreenSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSmartScreen;
            stickySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableStickyKeys;
            hibernateSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableHibernation;
            smb1Sw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSMB1;
            smb2Sw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSMB2;
            ntfsStampSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableNTFSTimeStamp;
            winSearchSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSearch;
            ffTelemetrySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableFirefoxTemeletry;
            vsSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableVisualStudioTelemetry;
            chromeTelemetrySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableChromeTelemetry;
            nvidiaTelemetrySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableNVIDIATelemetry;
            enableUtcSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableUtcTime;
        }

        private void LoadWindows8ToggleStates()
        {
            disableOneDriveSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableOneDrive;
        }

        private void LoadWindows10ToggleStates()
        {
            oldMixerSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableLegacyVolumeSlider;
            uODSw.ToggleChecked = OptionsHelper.CurrentOptions.UninstallOneDrive;
            gameBarSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableGameBar;
            cortanaSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableCortana;
            edgeTelemetrySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableEdgeTelemetry;
            edgeAiSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableEdgeDiscoverBar;
            xboxSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableXboxLive;
            oldExplorerSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableQuickAccessHistory;
            sensorSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSensorServices;
            privacySw.ToggleChecked = OptionsHelper.CurrentOptions.DisablePrivacyOptions;
            telemetryServicesSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableTelemetryServices;
            autoUpdatesSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableAutomaticUpdates;
            peopleSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableMyPeople;
            adsSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableStartMenuAds;
            spellSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSpellingTyping;
            inkSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableWindowsInk;
            driversSw.ToggleChecked = OptionsHelper.CurrentOptions.ExcludeDrivers;
            insiderSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableInsiderService;
            storeUpdatesSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableStoreUpdates;
            ccSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableCloudClipboard;
            longPathsSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableLongPaths;
            castSw.ToggleChecked = OptionsHelper.CurrentOptions.RemoveCastToDevice;
            gameModeSw.ToggleChecked = OptionsHelper.CurrentOptions.EnableGamingMode;
            tpmSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableTPMCheck;
            classicPhotoViewerSw.ToggleChecked = OptionsHelper.CurrentOptions.RestoreClassicPhotoViewer;
            modernStandbySw.ToggleChecked = OptionsHelper.CurrentOptions.DisableModernStandby;
            hideWeatherSw.ToggleChecked = OptionsHelper.CurrentOptions.HideTaskbarWeather;
            hideSearchSw.ToggleChecked = OptionsHelper.CurrentOptions.HideTaskbarSearch;
            newsInterestsSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableNewsInterests;
        }

        private void LoadWindows11ToggleStates()
        {
            leftTaskbarSw.ToggleChecked = OptionsHelper.CurrentOptions.TaskbarToLeft;
            snapAssistSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableSnapAssist;
            widgetsSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableWidgets;
            chatSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableChat;
            stickersSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableStickers;
            classicContextSw.ToggleChecked = OptionsHelper.CurrentOptions.ClassicMenu;
            tpmSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableTPMCheck;
            compactModeSw.ToggleChecked = OptionsHelper.CurrentOptions.CompactMode;
            vbsSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableVBS;
            copilotSw.ToggleChecked = OptionsHelper.CurrentOptions.DisableCoPilotAI;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FixTabHeaderWidth(tabCollection);
            FixTabHeaderWidth(synapse);
            FixTabHeaderWidth(netTools);

            if (OptionsHelper.CurrentOptions.AutoStart && OptionsHelper.CurrentOptions.EnableTray)
            {
                this.Hide();
            }

            //DebugHelper.FindDifferenceInTwoJsons();
        }

        // launch reveal: keep the window off-screen until its first themed frame is painted (no white flash)
        bool _revealPending = true, _launchCloaked, _launchFaded;

        protected override void OnHandleCreated(EventArgs e)
        {
            // the window is created already visible (Load fires later), so hide it as soon as the HWND exists
            if (_revealPending && !_launchCloaked && !_launchFaded)
            {
                _launchCloaked = WindowChrome.Cloak(this, true);
                if (!_launchCloaked)
                {
                    Opacity = 0;
                    _launchFaded = true;
                }
            }
            base.OnHandleCreated(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            // queued messages run before WM_PAINT, so this reveals right after the first real paint
            if (_revealPending && Visible && IsHandleCreated) BeginInvoke(new Action(RevealAfterFirstPaint));
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RevealAfterFirstPaint();
        }

        void RevealAfterFirstPaint()
        {
            if (!_revealPending || IsDisposed || !Visible) return;
            _revealPending = false;
            try
            {
                WindowChrome.PaintNow(this);
            }
            finally
            {
                if (_launchCloaked) WindowChrome.Cloak(this, false);
                if (_launchFaded) Opacity = 1;
            }
        }

        private void SetupNavigation()
        {
            sidebarNav.SetGlyph(universalTab, SidebarNav.Glyph.Shield);
            sidebarNav.SetGlyph(windows10Tab, SidebarNav.Glyph.Windows);
            sidebarNav.SetGlyph(advancedTab, SidebarNav.Glyph.Gear);
            sidebarNav.SetGlyph(modernAppsTab, SidebarNav.Glyph.Apps);
            sidebarNav.SetGlyph(startupTab, SidebarNav.Glyph.Rocket);
            sidebarNav.SetGlyph(appsTab, SidebarNav.Glyph.Download);
            sidebarNav.SetGlyph(cleanerTab, SidebarNav.Glyph.Broom);
            sidebarNav.SetGlyph(fileHandlesTab, SidebarNav.Glyph.Lock);
            sidebarNav.SetGlyph(diskActivityTab, SidebarNav.Glyph.Drive);
            sidebarNav.SetGlyph(pingerTab, SidebarNav.Glyph.Pulse);
            sidebarNav.SetGlyph(hostsEditorTab, SidebarNav.Glyph.Globe);
            sidebarNav.SetGlyph(registryFixerTab, SidebarNav.Glyph.Wrench);
            sidebarNav.SetGlyph(indiciumTab, SidebarNav.Glyph.Chip);
            sidebarNav.SetGlyph(integratorTab, SidebarNav.Glyph.Puzzle);
            sidebarNav.SetGlyph(optionsTab, SidebarNav.Glyph.Options);

            foreach (TabPage page in tabCollection.TabPages)
            {
                page.TextChanged += (s, e) => UpdatePageTitle();
            }
            tabCollection.SelectedIndexChanged += (s, e) => UpdatePageTitle();

            _titleIconInset = lblPageTitle.Padding.Left;
            Padding titlePadding = lblPageTitle.Padding;
            titlePadding.Left = _titleIconInset + TitleIconSize + Draw.SI(14);
            lblPageTitle.Padding = titlePadding;
            lblPageTitle.Paint += LblPageTitle_Paint;

            UpdatePageTitle();
        }

        private int _titleIconInset;
        private static int TitleIconSize { get { return Draw.SI(28); } }

        private void LblPageTitle_Paint(object sender, PaintEventArgs e)
        {
            TabPage page = tabCollection.SelectedTab;
            if (page == null) return;

            int size = TitleIconSize;
            Rectangle bounds = new Rectangle(_titleIconInset, (lblPageTitle.Height - size) / 2, size, size);
            SidebarNav.PaintGlyph(e.Graphics, sidebarNav.GetGlyph(page), bounds, ThemeManager.Current.AccentText);
        }

        private void UpdatePageTitle()
        {
            lblPageTitle.Text = tabCollection.SelectedTab != null ? tabCollection.SelectedTab.Text : string.Empty;
            lblPageTitle.Invalidate();
        }

        private void TagMenuGlyphs()
        {
            trayStartup.Tag = SidebarNav.Glyph.Rocket;
            trayCleaner.Tag = SidebarNav.Glyph.Broom;
            trayPinger.Tag = SidebarNav.Glyph.Pulse;
            trayHosts.Tag = SidebarNav.Glyph.Globe;
            trayAD.Tag = SidebarNav.Glyph.Download;
            trayHW.Tag = SidebarNav.Glyph.Chip;
            trayRegistry.Tag = SidebarNav.Glyph.Wrench;
            trayOptions.Tag = SidebarNav.Glyph.Options;
            trayRestartExplorer.Tag = SidebarNav.Glyph.Refresh;
            trayUnlocker.Tag = SidebarNav.Glyph.Lock;
            trayExit.Tag = SidebarNav.Glyph.Power;
            toolHWCopy.Tag = SidebarNav.Glyph.Document;
            toolHWGoogle.Tag = SidebarNav.Glyph.Search;
            toolHWDuck.Tag = SidebarNav.Glyph.Search;

            toolStripSeparator1.BackColor = Color.Empty;
            toolStripSeparator2.BackColor = Color.Empty;
        }

        private void ApplySystemColors()
        {
            if (_colorOverrider == null) return;
            _colorOverrider.SetColor(KnownColor.Highlight, ThemeManager.Current.Selection.ToArgb());
            _colorOverrider.SetColor(KnownColor.HighlightText, ThemeManager.Current.TextPrimary.ToArgb());
        }

        private void RefreshTheme()
        {
            OptionsHelper.ApplyTheme(this);
            LogoArt.Apply(pictureBox1);
            ThemeManager.ApplyMenu(launcherMenu);
            ThemeManager.ApplyMenu(indiciumMenu);
            ApplySystemColors();
            // The bubble bakes its colors into a layered bitmap; reopen it fresh instead of re-theming it.
            TipBubble.CloseAll();

            Form[] openForms;
            try { openForms = Application.OpenForms.Cast<Form>().ToArray(); }
            catch (InvalidOperationException) { openForms = new Form[0]; }

            foreach (Form form in openForms)
            {
                if (form == this || form.IsDisposed || form is TipBubble || form.InvokeRequired) continue;
                OptionsHelper.ApplyTheme(form);
            }
        }

        private void GetDesktopItems()
        {
            _desktopItems = IntegratorHelper.GetDesktopItems();
            listDesktopItems.BeginUpdate();
            listDesktopItems.Items.Clear();

            for (int i = 0; i < _desktopItems.Count; i++)
            {
                if (!string.IsNullOrEmpty(_desktopItems[i]))
                {
                    listDesktopItems.Items.Add(_desktopItems[i]);
                }
            }
            listDesktopItems.EndUpdate();

            if (_desktopItems.Count > 0) listDesktopItems.SelectedIndex = 0;
            UpdateIntegratorCounts();
        }

        private void GetHostsEntries()
        {
            ((Control)this.hostsEditorTab).Enabled = false;

            _hostsEntries = HostsHelper.GetHostsEntries();
            ApplyHostsFilter();

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

            if (listHostEntries.Items.Count > 0) listHostEntries.SelectedIndex = 0;
        }

        private void GetStartupItems()
        {
            _startUpItems = StartupHelper.GetStartupItems();
            PopulateStartupCards();
        }

        #region Startup tab UI

        static class StartupNative {
            internal const int EM_SETCUEBANNER = 0x1501;

            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            internal static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);
        }

        readonly List<StartupCard> _startupCards = new List<StartupCard>();
        readonly HashSet<string> _startupMissing = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        ToolTip _startupTips;
        string[] _startupSortNames = { "Name", "Location", "Type" };
        bool _startupSortDescending;
        bool _startupSyncingSelectAll;
        bool _startupBackupOpen;
        int _startupIconLoad;

        private void InitStartupUi()
        {
            _startupTips = new ToolTip { InitialDelay = 400, ReshowDelay = 100, AutoPopDelay = 10000 };

            cmbStartupFilter.Items.AddRange(new object[]
            {
                "All sources",
                "Current user (HKCU)",
                "Local machine (HKLM)",
                "Local machine 32-bit",
                "Startup folder (user)",
                "Startup folder (all users)"
            });
            cmbStartupFilter.SelectedIndex = 0;

            cmbStartupStatus.Items.AddRange(new object[] { "Any status", "Enabled", "Disabled" });
            cmbStartupStatus.SelectedIndex = 0;

            // Windows 7 has no per-item enable/disable state (StartupApproved), so the controls are hidden there
            bool toggles = StartupApproval.IsSupported;
            cmbStartupStatus.Visible = toggles;
            enableStartupB.Visible = toggles;
            disableStartupB.Visible = toggles;

            cmbStartupSort.Items.AddRange(_startupSortNames);
            cmbStartupSort.SelectedIndex = 0;
            UpdateStartupSortGlyph();

            txtStartupSearch.HandleCreated += (s, e) => SetStartupSearchCue();
            if (txtStartupSearch.IsHandleCreated) SetStartupSearchCue();

            panelStartup.EmptyText = "No startup items found";
            UpdateStartupFooter();
        }

        private void SetStartupSearchCue()
        {
            StartupNative.SendMessage(txtStartupSearch.Handle, StartupNative.EM_SETCUEBANNER, (IntPtr)1, "Search startup items");
        }

        private void ApplyStartupSortNames()
        {
            if (cmbStartupSort.Items.Count != _startupSortNames.Length) return;

            int selected = cmbStartupSort.SelectedIndex;
            for (int i = 0; i < _startupSortNames.Length; i++)
            {
                cmbStartupSort.Items[i] = _startupSortNames[i];
            }
            cmbStartupSort.SelectedIndex = selected;
        }

        private void UpdateStartupSortGlyph()
        {
            sortDirStartupB.Text = _startupSortDescending ? "\u2193" : "\u2191";
            _startupTips.SetToolTip(sortDirStartupB, _startupSortDescending ? "Descending" : "Ascending");
        }

        private void PopulateStartupCards()
        {
            panelStartup.SuspendLayout();
            try
            {
                foreach (StartupCard old in _startupCards)
                {
                    old.CheckedChanged -= StartupCard_CheckedChanged;
                    old.ActionInvoked -= StartupCard_ActionInvoked;
                    _startupTips.SetToolTip(old, null);
                    old.Dispose();
                }
                _startupCards.Clear();
                panelStartup.Controls.Clear();

                StartupCard[] cards = new StartupCard[_startUpItems.Count];
                for (int i = 0; i < _startUpItems.Count; i++)
                {
                    StartupCard card = new StartupCard(_startUpItems[i]) { Tips = _startupTips };
                    card.CheckedChanged += StartupCard_CheckedChanged;
                    card.ActionInvoked += StartupCard_ActionInvoked;
                    cards[i] = card;
                }
                _startupCards.AddRange(cards);
                panelStartup.Controls.AddRange(cards);

                if (ThemeManager.Current != null)
                {
                    foreach (StartupCard card in cards) card.ApplyTheme(ThemeManager.Current);
                }
            }
            finally
            {
                panelStartup.ResumeLayout(false);
            }

            panelStartup.AutoScrollPosition = Point.Empty;
            ApplyStartupView();
            LoadStartupIcons();
        }

        private void LoadStartupIcons()
        {
            int load = ++_startupIconLoad;
            Dictionary<StartupCard, string> pending = new Dictionary<StartupCard, string>();

            foreach (StartupCard card in _startupCards)
            {
                string path = StartupIcons.ResolvePath(card.Item);
                Image icon;
                if (path != null && StartupIcons.TryGetCached(path, out icon))
                {
                    card.SetIcon(icon, _startupMissing.Contains(path));
                }
                else if (path != null)
                {
                    pending[card] = path;
                }
            }

            if (pending.Count == 0) return;

            if (SynchronizationContext.Current == null)
            {
                if (!IsHandleCreated)
                {
                    EventHandler onHandle = null;
                    onHandle = (s, e) => { HandleCreated -= onHandle; if (load == _startupIconLoad) LoadStartupIcons(); };
                    HandleCreated += onHandle;
                    return;
                }
                BeginInvoke(new Action(() => { if (load == _startupIconLoad) LoadStartupIcons(); }));
                return;
            }

            string[] paths = pending.Values.Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
            Task.Run(() => paths.Select(StartupIcons.Load).ToList()).ContinueWith(t =>
            {
                if (t.IsFaulted || IsDisposed) return;

                Dictionary<string, Image> icons = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
                foreach (StartupIcons.Result r in t.Result)
                {
                    icons[r.Path] = StartupIcons.Store(r.Path, r.Icon);
                    if (r.Missing) _startupMissing.Add(r.Path);
                    else _startupMissing.Remove(r.Path);
                }

                if (load != _startupIconLoad) return;
                foreach (KeyValuePair<StartupCard, string> kv in pending)
                {
                    Image icon;
                    if (!kv.Key.IsDisposed && icons.TryGetValue(kv.Value, out icon))
                    {
                        kv.Key.SetIcon(icon, _startupMissing.Contains(kv.Value));
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private bool StartupMatchesFilter(StartupItem item)
        {
            if (StartupApproval.IsSupported)
            {
                bool enabled = !item.CanToggle || item.Enabled;
                if (cmbStartupStatus.SelectedIndex == 1 && !enabled) return false;
                if (cmbStartupStatus.SelectedIndex == 2 && enabled) return false;
            }

            switch (cmbStartupFilter.SelectedIndex)
            {
                case 1: return item.RegistryLocation == StartupItemLocation.HKCU;
                case 2: return item.RegistryLocation == StartupItemLocation.HKLM;
                case 3: return item.RegistryLocation == StartupItemLocation.HKLMWoW;
                case 4: return item.RegistryLocation == StartupItemLocation.CUStartupFolder;
                case 5: return item.RegistryLocation == StartupItemLocation.LMStartupFolder;
                default: return true;
            }
        }

        private static bool ContainsText(string haystack, string needle)
        {
            return !string.IsNullOrEmpty(haystack) && haystack.IndexOf(needle, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void ApplyStartupView()
        {
            string query = txtStartupSearch.Text.Trim();
            bool searching = query.Length > 0;
            int sort = cmbStartupSort.SelectedIndex;

            Func<StartupCard, string> key;
            if (sort == 1) key = c => c.Item.FileLocation ?? string.Empty;
            else if (sort == 2) key = c => c.Badge;
            else key = c => c.Item.Name ?? string.Empty;

            IEnumerable<StartupCard> ordered = _startupSortDescending
                ? _startupCards.OrderByDescending(key, StringComparer.CurrentCultureIgnoreCase)
                : _startupCards.OrderBy(key, StringComparer.CurrentCultureIgnoreCase);
            if (sort != 0)
            {
                ordered = ((IOrderedEnumerable<StartupCard>)ordered).ThenBy(c => c.Item.Name ?? string.Empty, StringComparer.CurrentCultureIgnoreCase);
            }
            List<StartupCard> order = ordered.ToList();

            panelStartup.SuspendLayout();
            foreach (StartupCard card in order)
            {
                StartupItem item = card.Item;
                bool visible = StartupMatchesFilter(item)
                    && (!searching || ContainsText(item.Name, query) || ContainsText(item.FileLocation, query) || ContainsText(card.Badge, query)
                        || (!card.IsItemEnabled && ContainsText(StartupCard.DisabledText, query)));
                card.Visible = visible;
            }
            panelStartup.ResumeLayout(false);

            panelStartup.EmptyText = (searching || cmbStartupFilter.SelectedIndex > 0 || cmbStartupStatus.SelectedIndex > 0) && _startupCards.Count > 0
                ? "No items match your search"
                : "No startup items found";
            panelStartup.SetOrder(order.Cast<Control>());
            UpdateStartupFooter();
        }

        private void UpdateStartupFooter()
        {
            int visible = 0, checkedVisible = 0, checkedTotal = 0, disabledVisible = 0, checkedOn = 0, checkedOff = 0;
            foreach (StartupCard card in _startupCards)
            {
                bool shown = LayoutUtil.IsShown(card);
                if (shown)
                {
                    visible++;
                    if (!card.IsItemEnabled) disabledVisible++;
                }
                if (card.Checked)
                {
                    checkedTotal++;
                    if (shown) checkedVisible++;
                    if (card.CanToggle)
                    {
                        if (card.Item.Enabled) checkedOn++;
                        else checkedOff++;
                    }
                }
            }

            string text = checkedTotal > 0
                ? string.Format(checkedTotal > checkedVisible ? "{0} selected ({1} hidden by filter)" : "{0} selected", checkedTotal, checkedTotal - checkedVisible)
                : string.Format(visible == 1 ? "{0} item" : "{0} items", visible);
            if (checkedTotal == 0 && disabledVisible > 0) text += string.Format("  \u00b7  {0} disabled", disabledVisible);
            lblStartupSelected.Text = text;
            removeStartupItemB.Enabled = checkedTotal > 0;
            clearStartupSelB.Visible = checkedTotal > 0;

            if (StartupApproval.IsSupported)
            {
                bool anyToggleable = checkedOn + checkedOff > 0;
                enableStartupB.Visible = anyToggleable;
                disableStartupB.Visible = anyToggleable;
                enableStartupB.Enabled = checkedOff > 0;
                disableStartupB.Enabled = checkedOn > 0;
            }
            chkStartupSelectAll.Enabled = visible > 0;

            _startupSyncingSelectAll = true;
            chkStartupSelectAll.Checked = visible > 0 && checkedVisible == visible;
            _startupSyncingSelectAll = false;

            LayoutStartupFooter();
        }

        private List<StartupCard> CheckedStartupCards()
        {
            return _startupCards.Where(c => c.Checked).ToList();
        }

        private void StartupCard_CheckedChanged(object sender, EventArgs e)
        {
            if (!_startupSyncingSelectAll) UpdateStartupFooter();
        }

        private void StartupCard_ActionInvoked(object sender, StartupCardActionEventArgs e)
        {
            StartupCard card = sender as StartupCard;
            if (card == null) return;

            switch (e.Action)
            {
                case StartupCardAction.LocateFile:
                    card.Item.LocateFile();
                    break;
                case StartupCardAction.LocateKey:
                    card.Item.LocateKey();
                    break;
                case StartupCardAction.Toggle:
                    SetStartupEnabled(new[] { card }, !card.Item.Enabled);
                    break;
                case StartupCardAction.Delete:
                    if (MessageBox.Show(_removeStartupItemsMessage + Environment.NewLine + Environment.NewLine + card.Item.Name + Environment.NewLine, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        card.Item.Remove();
                        GetStartupItems();
                    }
                    break;
            }
        }

        /// <summary>
        /// Writes the Task Manager enabled/disabled state for the given cards, then re-reads it so the UI
        /// always reflects what Windows actually stored.
        /// </summary>
        private void SetStartupEnabled(IEnumerable<StartupCard> cards, bool enabled)
        {
            int failed = 0;
            foreach (StartupCard card in cards)
            {
                if (!card.CanToggle || card.Item.Enabled == enabled) continue;
                if (!StartupApproval.SetEnabled(card.Item, enabled)) failed++;
                StartupApproval.Refresh(card.Item);
                card.RefreshState();
            }

            if (cmbStartupStatus.SelectedIndex > 0 || txtStartupSearch.TextLength > 0) ApplyStartupView();
            else UpdateStartupFooter();

            if (failed > 0)
            {
                MessageBox.Show(string.Format("Could not change the state of {0} item(s). See the error log for details.", failed),
                    "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void enableStartupB_Click(object sender, EventArgs e)
        {
            SetStartupEnabled(CheckedStartupCards(), true);
        }

        private void disableStartupB_Click(object sender, EventArgs e)
        {
            SetStartupEnabled(CheckedStartupCards(), false);
        }

        private void cmbStartupStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStartupView();
        }

        private void chkStartupSelectAll_Click(object sender, EventArgs e)
        {
            if (_startupSyncingSelectAll) return;

            bool check = chkStartupSelectAll.Checked;
            _startupSyncingSelectAll = true;
            foreach (StartupCard card in _startupCards)
            {
                if (LayoutUtil.IsShown(card)) card.Checked = check;
            }
            _startupSyncingSelectAll = false;
            UpdateStartupFooter();
        }

        private void clearStartupSelB_Click(object sender, EventArgs e)
        {
            _startupSyncingSelectAll = true;
            foreach (StartupCard card in _startupCards) card.Checked = false;
            _startupSyncingSelectAll = false;
            UpdateStartupFooter();
        }

        private void txtStartupSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyStartupView();
        }

        private void txtStartupSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && txtStartupSearch.TextLength > 0)
            {
                txtStartupSearch.Clear();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void cmbStartupFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStartupView();
        }

        private void cmbStartupSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStartupView();
        }

        private void sortDirStartupB_Click(object sender, EventArgs e)
        {
            _startupSortDescending = !_startupSortDescending;
            UpdateStartupSortGlyph();
            ApplyStartupView();
        }

        private void txtBackupTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button13_Click(doBackup, EventArgs.Empty);
                e.Handled = e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                HideBackupConfirm();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void startupTab_Layout(object sender, LayoutEventArgs e)
        {
            LayoutStartupTab();
        }

        private static int ButtonWidth(Control b, int min)
        {
            return Math.Max(min, TextRenderer.MeasureText(b.Text, b.Font).Width + Draw.SI(36));
        }

        private void LayoutStartupTab()
        {
            Size area = startupTab.ClientSize;
            if (area.Width <= 0 || area.Height <= 0) return;

            int margin = Draw.SI(16), gap = Draw.SI(8), rowH = Draw.SI(36);
            int left = margin, right = area.Width - margin;
            int top = startupTitle.Bottom + Draw.SI(14);

            int x = right;
            foreach (Control b in new Control[] { backupStartupB, restoreStartupB, refreshStartupB })
            {
                int w = ButtonWidth(b, Draw.SI(96));
                x -= w;
                b.SetBounds(x, top, w, rowH);
                x -= gap;
            }

            int toolsRight = x - Draw.SI(16);
            bool status = StartupApproval.IsSupported;
            int filterW = Draw.SI(210), statusW = status ? Draw.SI(140) : 0, sortW = Draw.SI(150), dirW = rowH;
            int gaps = gap * (status ? 4 : 3);
            int searchW = toolsRight - left - filterW - statusW - sortW - dirW - gaps;
            if (searchW < Draw.SI(140))
            {
                int deficit = Draw.SI(140) - searchW;
                filterW = Math.Max(Draw.SI(140), filterW - deficit);
                searchW = Math.Max(Draw.SI(100), toolsRight - left - filterW - statusW - sortW - dirW - gaps);
            }

            txtStartupSearch.SetBounds(left, top + (rowH - txtStartupSearch.Height) / 2, searchW, txtStartupSearch.Height);
            x = left + searchW + gap;
            cmbStartupFilter.SetBounds(x, top + (rowH - cmbStartupFilter.Height) / 2, filterW, cmbStartupFilter.Height);
            x += filterW + gap;
            if (status)
            {
                cmbStartupStatus.SetBounds(x, top + (rowH - cmbStartupStatus.Height) / 2, statusW, cmbStartupStatus.Height);
                x += statusW + gap;
            }
            cmbStartupSort.SetBounds(x, top + (rowH - cmbStartupSort.Height) / 2, sortW, cmbStartupSort.Height);
            x += sortW + gap;
            sortDirStartupB.SetBounds(x, top, dirW, rowH);

            int y = top + rowH + Draw.SI(14);

            if (_startupBackupOpen)
            {
                int stripH = Draw.SI(56);
                startupBackupStrip.SetBounds(left, y, right - left, stripH);
                LayoutStartupBackupStrip();
                y += stripH + gap;
            }

            int footerH = Draw.SI(56);
            int footerTop = area.Height - margin - footerH;
            startupFooter.SetBounds(left, footerTop, right - left, footerH);
            LayoutStartupFooter();

            panelStartup.SetBounds(left, y, right - left, Math.Max(Draw.SI(60), footerTop - gap - y));
        }

        private void LayoutStartupBackupStrip()
        {
            Size s = startupBackupStrip.ClientSize;
            int pad = Draw.SI(16), gap = Draw.SI(10), btnH = Draw.SI(36);
            int mid = s.Height / 2;

            lblBackupTitle.Location = new Point(pad, mid - lblBackupTitle.Height / 2);
            int x = lblBackupTitle.Right + Draw.SI(12);

            int cancelW = ButtonWidth(cancelBackup, Draw.SI(96));
            int okW = ButtonWidth(doBackup, Draw.SI(96));
            int txtW = Math.Max(Draw.SI(140), Math.Min(Draw.SI(380), s.Width - x - okW - cancelW - gap * 2 - pad));

            txtBackupTitle.SetBounds(x, mid - txtBackupTitle.Height / 2, txtW, txtBackupTitle.Height);
            x += txtW + gap;
            doBackup.SetBounds(x, mid - btnH / 2, okW, btnH);
            x += okW + gap;
            cancelBackup.SetBounds(x, mid - btnH / 2, cancelW, btnH);
        }

        private void LayoutStartupFooter()
        {
            Size s = startupFooter.ClientSize;
            if (s.Width <= 0) return;

            int pad = Draw.SI(16), gap = Draw.SI(8), btnH = Draw.SI(36);
            int mid = s.Height / 2;

            chkStartupSelectAll.Location = new Point(pad, mid - chkStartupSelectAll.Height / 2);
            lblStartupSelected.Location = new Point(chkStartupSelectAll.Right + Draw.SI(20), mid - lblStartupSelected.Height / 2);

            int x = s.Width - pad;
            int delW = ButtonWidth(removeStartupItemB, Draw.SI(110));
            x -= delW;
            removeStartupItemB.SetBounds(x, mid - btnH / 2, delW, btnH);

            int clearW = ButtonWidth(clearStartupSelB, Draw.SI(88));
            x -= gap + clearW;
            clearStartupSelB.SetBounds(x, mid - btnH / 2, clearW, btnH);

            // Enable/Disable sit apart from the destructive actions
            x -= Draw.SI(20);
            foreach (Control b in new Control[] { disableStartupB, enableStartupB })
            {
                int w = ButtonWidth(b, Draw.SI(96));
                x -= w;
                b.SetBounds(x, mid - btnH / 2, w, btnH);
                x -= gap;
            }
        }

        #endregion

        private async void GetModernApps(bool showAll)
        {
            int load = ++_modernAppsLoad;
            uninstallModernAppsButton.Enabled = false;
            refreshModernAppsButton.Enabled = false;

            List<UwpApp> apps;
            try
            {
                apps = await Task.Run(() => UWPHelper.GetUWPApps(showAll)
                    .OrderBy(a => a.Title, StringComparer.CurrentCultureIgnoreCase)
                    .ToList());
            }
            catch (Exception ex)
            {
                Logger.LogError("MainForm.GetModernApps", ex.Message, ex.StackTrace);
                apps = new List<UwpApp>();
            }

            // a newer refresh started meanwhile, or the window is gone
            if (load != _modernAppsLoad || IsDisposed)
            {
                DisposeLogos(apps);
                return;
            }

            PopulateModernApps(apps);

            uninstallModernAppsButton.Enabled = true;
            refreshModernAppsButton.Enabled = true;
        }

        private static void DisposeLogos(List<UwpApp> apps)
        {
            foreach (UwpApp app in apps)
            {
                if (app.Logo != null) app.Logo.Dispose();
                app.Logo = null;
            }
        }

        private void PopulateModernApps(List<UwpApp> apps)
        {
            List<UwpApp> previous = _modernApps;
            _modernApps = apps;

            AppCard[] cards = new AppCard[apps.Count];

            panelUwp.SuspendLayout();
            try
            {
                Control[] old = new Control[panelUwp.Controls.Count];
                panelUwp.Controls.CopyTo(old, 0);
                panelUwp.Controls.Clear();
                foreach (Control c in old) c.Dispose();
                panelUwp.AutoScrollPosition = Point.Empty;

                for (int i = 0; i < apps.Count; i++)
                {
                    AppCard appCard = new AppCard();
                    appCard.AutoSize = true;
                    appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;
                    appCard.App = apps[i];
                    cards[i] = appCard;
                }
                panelUwp.Controls.AddRange(cards);
            }
            finally
            {
                panelUwp.ResumeLayout();
            }

            // stack by the real (auto-sized, DPI-scaled) card height
            panelUwp.SuspendLayout();
            try
            {
                int y = 0;
                int gap = Draw.SI(6);
                foreach (AppCard appCard in cards)
                {
                    appCard.Location = new Point(0, y);
                    y += appCard.Height + gap;
                }
            }
            finally
            {
                panelUwp.ResumeLayout();
            }

            if (!ReferenceEquals(previous, apps)) DisposeLogos(previous);
        }

        private async void UninstallModernApps()
        {
            List<UwpApp> selectedApps = new List<UwpApp>();

            foreach (Control c in panelUwp.Controls)
            {
                AppCard card = c as AppCard;
                if (card != null && card.App != null && card.appTitle.Checked)
                {
                    selectedApps.Add(card.App);
                }
            }

            if (selectedApps.Count <= 0) return;

            if (MessageBox.Show(_removeModernAppsMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uninstallModernAppsButton.Enabled = false;
                refreshModernAppsButton.Enabled = false;

                string failedApps = string.Empty;

                foreach (UwpApp app in selectedApps)
                {
                    bool errorOccured = await Task.Run(() => UWPHelper.UninstallUWPApp(app));

                    if (errorOccured)
                    {
                        failedApps += Environment.NewLine + app.Title;
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
            _customCommands = IntegratorHelper.GetCustomCommands();
            listCustomCommands.BeginUpdate();
            listCustomCommands.Items.Clear();

            foreach (string s in _customCommands)
            {
                listCustomCommands.Items.Add(s);
            }
            listCustomCommands.EndUpdate();

            if (_customCommands.Count > 0) listCustomCommands.SelectedIndex = 0;
            UpdateIntegratorCounts();
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
                OptionsHelper.CurrentOptions.AppsFolder = txtDownloadFolder.Text;
                OptionsHelper.SaveSettings();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            List<StartupCard> selected = CheckedStartupCards();
            if (selected.Count <= 0) return;

            string report = string.Empty;

            foreach (StartupCard card in selected)
            {
                report += card.Item.Name + Environment.NewLine;
            }
            if (MessageBox.Show(_removeStartupItemsMessage + Environment.NewLine + Environment.NewLine + report, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (StartupCard card in selected)
                {
                    card.Item.Remove();
                }

                GetStartupItems();
            }
        }

        internal void RemoveAllStartupItems()
        {
            foreach (StartupItem item in _startUpItems)
            {
                item.Remove();
            }

            GetStartupItems();
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
                if (!ValidateHostsInput(ip, domain)) return;

                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));
                if (chkIncludeWww.Checked)
                {
                    domain = $"www.{domain}";
                    HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));
                }

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
            else if (listHostEntries.SelectedItems.Count > 1)
            {
                List<string> selected = listHostEntries.SelectedItems.Cast<object>().Select(x => x.ToString().Replace(" : ", " ")).ToList();
                string msg = string.Format(T("hostsRemoveSelected", "Remove {0} selected entries from the hosts file?"), selected.Count);
                if (MessageBox.Show(this, msg, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                HostsHelper.RemoveAllEntries(selected);
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

            foreach (string item in _hostsEntries)
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
                IntegratorHelper.CreateCustomCommand(txtRunFile.Text, txtRunKeyword.Text);

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
                IntegratorHelper.RemoveItem(listDesktopItems.SelectedItem.ToString());
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

            IntegratorHelper.RemoveAllItems(collection);

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
                itemtoaddgroup.Text = OptionsHelper.TranslationList["itemtoaddgroup"];
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = OptionsHelper.TranslationList["checkDefaultIcon"];
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
                itemtoaddgroup.Text = OptionsHelper.TranslationList["folderToAdd"];
                checkDefaultIcon.Text = OptionsHelper.TranslationList["checkDefaultFolderIcon"];
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
                checkDefaultIcon.Text = OptionsHelper.TranslationList["checkFavicon"];
                btnBrowseItem.Enabled = false;
                itemtoaddgroup.Text = OptionsHelper.TranslationList["linkToAdd"];
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
                checkDefaultIcon.Text = OptionsHelper.TranslationList["checkNoIcon"];
                btnBrowseItem.Enabled = true;
                itemtoaddgroup.Text = OptionsHelper.TranslationList["fileToAdd"];
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
                itemtoaddgroup.Text = OptionsHelper.TranslationList["commandToAdd"];
                checkDefaultIcon.Visible = true;
                checkDefaultIcon.Text = OptionsHelper.TranslationList["checkNoIcon"];
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
                string iconpath = IntegratorHelper.ExtractIconFromExecutable(txtItemName.Text, DefineProgramIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFolderIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFolderIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = IntegratorHelper.ExtractIconFromExecutable(txtItemName.Text, DefineFolderIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineURLIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineURLIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = IntegratorHelper.ExtractIconFromExecutable(txtItemName.Text, DefineURLIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineFileIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineFileIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = IntegratorHelper.ExtractIconFromExecutable(txtItemName.Text, DefineFileIconDialog.FileName);
                txtIcon.Text = iconpath;
            }
        }

        private void DefineCommandIconDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtIcon.Text = DefineCommandIconDialog.FileName;

            if (txtIcon.Text.Contains(".exe"))
            {
                string iconpath = IntegratorHelper.ExtractIconFromExecutable(txtItemName.Text, DefineCommandIconDialog.FileName);
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

                    IntegratorHelper.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Program);

                    break;
                case DesktopItemType.Folder:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = IntegratorHelper.FolderDefaultIcon;
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    IntegratorHelper.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Folder);

                    break;
                case DesktopItemType.Link:
                    if (checkDefaultIcon.Checked)
                    {
                        icon = IntegratorHelper.DownloadFavicon(txtItem.Text, txtItemName.Text);
                    }
                    else
                    {
                        icon = txtIcon.Text;
                    }

                    IntegratorHelper.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Link);

                    break;
                case DesktopItemType.File:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    IntegratorHelper.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.File);

                    break;
                case DesktopItemType.Command:
                    if (!checkDefaultIcon.Checked)
                    {
                        icon = txtIcon.Text;
                    }

                    IntegratorHelper.AddItem(txtItemName.Text, txtItem.Text, icon, _desktopItemPosition, checkShift.Checked, DesktopItemType.Command);

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
                IntegratorHelper.DeleteCustomCommand(listCustomCommands.SelectedItem.ToString());
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
                if (c is MoonCheck mc) mc.Checked = chkSelectAllModernApps.Checked;
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
                OptimizeHelper.EnablePerformanceTweaks();
            }
            else
            {
                OptimizeHelper.DisablePerformanceTweaks();
            }
            OptionsHelper.CurrentOptions.EnablePerformanceTweaks = performanceSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch2_Click(object sender, EventArgs e)
        {
            if (networkSw.ToggleChecked)
            {
                OptimizeHelper.DisableNetworkThrottling();
            }
            else
            {
                OptimizeHelper.EnableNetworkThrottling();
            }
            OptionsHelper.CurrentOptions.DisableNetworkThrottling = networkSw.ToggleChecked;
        }

        private void toggleSwitch3_Click(object sender, EventArgs e)
        {
            if (defenderSw.ToggleChecked)
            {
                OptimizeHelper.DisableDefender();
            }
            else
            {
                OptimizeHelper.EnableDefender();
            }
            OptionsHelper.CurrentOptions.DisableWindowsDefender = defenderSw.ToggleChecked;
        }

        private void toggleSwitch4_Click(object sender, EventArgs e)
        {
            if (systemRestoreSw.ToggleChecked)
            {
                if (MessageBox.Show(OptionsHelper.TranslationList["systemRestoreM"].ToString(), "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    _skipSystemRestore = true;
                    systemRestoreSw.ToggleChecked = false;
                    return;
                }

                _skipSystemRestore = false;
                OptimizeHelper.DisableSystemRestore();
            }
            else
            {
                if (_skipSystemRestore) return;

                OptimizeHelper.EnableSystemRestore();
            }
            if (!_skipSystemRestore) OptionsHelper.CurrentOptions.DisableSystemRestore = systemRestoreSw.ToggleChecked;
        }

        private void toggleSwitch5_Click(object sender, EventArgs e)
        {
            if (printSw.ToggleChecked)
            {
                OptimizeHelper.DisablePrintService();
            }
            else
            {
                OptimizeHelper.EnablePrintService();
            }
            OptionsHelper.CurrentOptions.DisablePrintService = printSw.ToggleChecked;
        }

        private void toggleSwitch6_Click(object sender, EventArgs e)
        {
            if (mediaSharingSw.ToggleChecked)
            {
                OptimizeHelper.DisableMediaPlayerSharing();
            }
            else
            {
                OptimizeHelper.EnableMediaPlayerSharing();
            }
            OptionsHelper.CurrentOptions.DisableMediaPlayerSharing = mediaSharingSw.ToggleChecked;
        }

        private void toggleSwitch8_Click(object sender, EventArgs e)
        {
            if (reportingSw.ToggleChecked)
            {
                OptimizeHelper.DisableErrorReporting();
            }
            else
            {
                OptimizeHelper.EnableErrorReporting();
            }
            OptionsHelper.CurrentOptions.DisableErrorReporting = reportingSw.ToggleChecked;
        }

        private void toggleSwitch9_Click(object sender, EventArgs e)
        {
            if (homegroupSw.ToggleChecked)
            {
                OptimizeHelper.DisableHomeGroup();
            }
            else
            {
                OptimizeHelper.EnableHomeGroup();
            }
            OptionsHelper.CurrentOptions.DisableHomeGroup = homegroupSw.ToggleChecked;
        }

        private void toggleSwitch10_Click(object sender, EventArgs e)
        {
            if (superfetchSw.ToggleChecked)
            {
                OptimizeHelper.DisableSuperfetch();
            }
            else
            {
                OptimizeHelper.EnableSuperfetch();
            }
            OptionsHelper.CurrentOptions.DisableSuperfetch = superfetchSw.ToggleChecked;
        }

        private void toggleSwitch11_Click(object sender, EventArgs e)
        {
            if (telemetryTasksSw.ToggleChecked)
            {
                OptimizeHelper.DisableTelemetryTasks();
            }
            else
            {
                OptimizeHelper.EnableTelemetryTasks();
            }
            OptionsHelper.CurrentOptions.DisableTelemetryTasks = telemetryTasksSw.ToggleChecked;
        }

        private void toggleSwitch12_Click(object sender, EventArgs e)
        {
            if (officeTelemetrySw.ToggleChecked)
            {
                OptimizeHelper.DisableOffice2016Telemetry();
            }
            else
            {
                OptimizeHelper.EnableOffice2016Telemetry();
            }
            OptionsHelper.CurrentOptions.DisableOffice2016Telemetry = officeTelemetrySw.ToggleChecked;
        }

        private void toggleSwitch13_Click(object sender, EventArgs e)
        {
            if (oldMixerSw.ToggleChecked)
            {
                OptimizeHelper.EnableLegacyVolumeSlider();
            }
            else
            {
                OptimizeHelper.DisableLegacyVolumeSlider();
            }
            OptionsHelper.CurrentOptions.EnableLegacyVolumeSlider = oldMixerSw.ToggleChecked;
        }

        private void toggleSwitch18_Click(object sender, EventArgs e)
        {
            if (oldExplorerSw.ToggleChecked)
            {
                OptimizeHelper.DisableQuickAccessHistory();
            }
            else
            {
                OptimizeHelper.EnableQuickAccessHistory();
            }
            OptionsHelper.CurrentOptions.DisableQuickAccessHistory = oldExplorerSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch26_Click(object sender, EventArgs e)
        {
            if (adsSw.ToggleChecked)
            {
                OptimizeHelper.DisableStartMenuAds();
            }
            else
            {
                OptimizeHelper.EnableStartMenuAds();
            }
            OptionsHelper.CurrentOptions.DisableStartMenuAds = adsSw.ToggleChecked;
        }

        private void toggleSwitch14_Click(object sender, EventArgs e)
        {
            if (uODSw.ToggleChecked)
            {
                if (MessageBox.Show(OptionsHelper.TranslationList["onedriveM"].ToString(), "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    _skipOneDrive = true;
                    uODSw.ToggleChecked = false;
                    return;
                }

                _skipOneDrive = false;

                Task t = new Task(() => OptimizeHelper.UninstallOneDrive());
                t.Start();
            }
            else
            {
                if (_skipOneDrive) return;

                Task t = new Task(() => OptimizeHelper.InstallOneDrive());
                t.Start();
            }

            if (!_skipOneDrive) OptionsHelper.CurrentOptions.UninstallOneDrive = uODSw.ToggleChecked;
        }

        private void toggleSwitch25_Click(object sender, EventArgs e)
        {
            if (peopleSw.ToggleChecked)
            {
                OptimizeHelper.DisableMyPeople();
            }
            else
            {
                OptimizeHelper.EnableMyPeople();
            }
            OptionsHelper.CurrentOptions.DisableMyPeople = peopleSw.ToggleChecked;
        }

        private void toggleSwitch24_Click(object sender, EventArgs e)
        {
            if (autoUpdatesSw.ToggleChecked)
            {
                OptimizeHelper.DisableAutomaticUpdates();
            }
            else
            {
                OptimizeHelper.EnableAutomaticUpdates();
            }
            OptionsHelper.CurrentOptions.DisableAutomaticUpdates = autoUpdatesSw.ToggleChecked;
        }

        private void toggleSwitch30_Click(object sender, EventArgs e)
        {
            if (driversSw.ToggleChecked)
            {
                OptimizeHelper.ExcludeDrivers();
            }
            else
            {
                OptimizeHelper.IncludeDrivers();
            }
            OptionsHelper.CurrentOptions.ExcludeDrivers = driversSw.ToggleChecked;
        }

        private void toggleSwitch23_Click(object sender, EventArgs e)
        {
            if (telemetryServicesSw.ToggleChecked)
            {
                OptimizeHelper.DisableTelemetryServices();
            }
            else
            {
                OptimizeHelper.EnableTelemetryServices();
            }
            OptionsHelper.CurrentOptions.DisableTelemetryServices = telemetryServicesSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch21_Click(object sender, EventArgs e)
        {
            if (privacySw.ToggleChecked)
            {
                Task t = new Task(() => OptimizeHelper.EnhancePrivacy());
                t.Start();
            }
            else
            {
                Task t = new Task(() => OptimizeHelper.CompromisePrivacy());
                t.Start();
            }
            OptionsHelper.CurrentOptions.DisablePrivacyOptions = privacySw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch16_Click(object sender, EventArgs e)
        {
            if (cortanaSw.ToggleChecked)
            {
                OptimizeHelper.DisableCortana();
            }
            else
            {
                OptimizeHelper.EnableCortana();
            }
            OptionsHelper.CurrentOptions.DisableCortana = cortanaSw.ToggleChecked;
        }

        private void toggleSwitch20_Click(object sender, EventArgs e)
        {
            if (sensorSw.ToggleChecked)
            {
                OptimizeHelper.DisableSensorServices();
            }
            else
            {
                OptimizeHelper.EnableSensorServices();
            }
            OptionsHelper.CurrentOptions.DisableSensorServices = sensorSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch29_Click(object sender, EventArgs e)
        {
            if (inkSw.ToggleChecked)
            {
                OptimizeHelper.DisableWindowsInk();
            }
            else
            {
                OptimizeHelper.EnableWindowsInk();
            }
            OptionsHelper.CurrentOptions.DisableWindowsInk = inkSw.ToggleChecked;
        }

        private void toggleSwitch28_Click(object sender, EventArgs e)
        {
            if (spellSw.ToggleChecked)
            {
                OptimizeHelper.DisableSpellingAndTypingFeatures();
            }
            else
            {
                OptimizeHelper.EnableSpellingAndTypingFeatures();
            }
            OptionsHelper.CurrentOptions.DisableSpellingTyping = spellSw.ToggleChecked;
        }

        private void toggleSwitch17_Click(object sender, EventArgs e)
        {
            if (xboxSw.ToggleChecked)
            {
                OptimizeHelper.DisableXboxLive();
            }
            else
            {
                OptimizeHelper.EnableXboxLive();
            }
            OptionsHelper.CurrentOptions.DisableXboxLive = xboxSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch15_Click(object sender, EventArgs e)
        {
            if (gameBarSw.ToggleChecked)
            {
                OptimizeHelper.DisableGameBar();
            }
            else
            {
                OptimizeHelper.EnableGameBar();
            }
            OptionsHelper.CurrentOptions.DisableGameBar = gameBarSw.ToggleChecked;
            ShowRestartNeeded();
        }

        private void toggleSwitch31_Click(object sender, EventArgs e)
        {
            if (disableOneDriveSw.ToggleChecked)
            {
                OptimizeHelper.DisableOneDrive();
            }
            else
            {
                OptimizeHelper.EnableOneDrive();
            }
            OptionsHelper.CurrentOptions.DisableOneDrive = disableOneDriveSw.ToggleChecked;
        }

        private void toggleSwitch32_Click(object sender, EventArgs e)
        {
            if (compatSw.ToggleChecked)
            {
                OptimizeHelper.DisableCompatibilityAssistant();
            }
            else
            {
                OptimizeHelper.EnableCompatibilityAssistant();
            }
            OptionsHelper.CurrentOptions.DisableCompatibilityAssistant = compatSw.ToggleChecked;
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
            linkRestoreDefault.Enabled = !chkReadOnly.Checked;
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

            txtDownloadStatus.Text = OptionsHelper.TranslationList["downloadsFinished"];
        }

        string appNameTemp = string.Empty;
        int maxCount = 0;
        int count = 0;
        Process p;
        string downloadLog = string.Empty;

        private async void btnDownloadApps_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDownloadFolder.Text) || !Directory.Exists(txtDownloadFolder.Text))
            {
                MessageBox.Show(OptionsHelper.TranslationList["downloadDirInvalid"].ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            foreach (AppInfo x in AppsFromFeed)
            {
                if (string.IsNullOrEmpty(x.Tag)) continue;
                temp = appsTab.Controls.Find(x.Tag, true);
                if (!temp.Any()) continue;
                currentCheck = (MoonCheck)temp[0];
                if (currentCheck == null) continue;
                if (!currentCheck.Checked) continue;

                appNameTemp = x.Title;

                if (c64.Checked)
                {
                    count++;
                    if (string.IsNullOrEmpty(x.Link64))
                    {
                        downloadLog += "• " + x.Title + ":" + Environment.NewLine + OptionsHelper.TranslationList["no64Download"] + Environment.NewLine + Environment.NewLine;
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
                        downloadLog += "• " + x.Title + ":" + Environment.NewLine + OptionsHelper.TranslationList["no32Download"] + Environment.NewLine + Environment.NewLine;
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

                        txtDownloadStatus.Text = string.Format("{0}/{1} - {2} {3} ...", count, maxCount, OptionsHelper.TranslationList["installing"], Path.GetFileNameWithoutExtension(a));

                        await p.RunAsync();
                    }
                    ;
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
        private async Task DownloadApp(AppInfo app, bool pref64)
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
                Logger.LogError("MainForm.DownloadApp", ex.Message, ex.StackTrace);
                downloadLog += "• " + app.Title + ":" + Environment.NewLine + OptionsHelper.TranslationList["linkInvalid"] + Environment.NewLine + Environment.NewLine;

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
                OptionsHelper.CurrentOptions.AppsFolder = d.SelectedPath;
                OptionsHelper.SaveSettings();
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

        private void chkOnlyRemovable_CheckedChanged(object sender, EventArgs e)
        {
            GetModernApps(!chkOnlyRemovable.Checked);
        }

        private void btnGetFeed_Click(object sender, EventArgs e)
        {
            GetFeedAsync();
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(Logger.ErrorLogFile))
            {
                InfoForm iform = new InfoForm(File.ReadAllText(Logger.ErrorLogFile, Encoding.UTF8));
                iform.ShowDialog();
            }
            else
            {
                MessageBox.Show(OptionsHelper.TranslationList["noErrorsM"].ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpenConf_Click(object sender, EventArgs e)
        {
            Process.Start(CoreHelper.CoreFolder);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            TogglePing();
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
                    File.WriteAllLines(ExportDialog.FileName, listPingResults.Items.Cast<object>().Select(x => x.ToString()));
                }
                catch (Exception ex)
                {
                    Logger.LogError("btnExport.Click", ex.Message, ex.StackTrace);
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

            OptionsHelper.CurrentOptions.AppsFolder = txtDownloadFolder.Text;
            OptionsHelper.SaveSettings();

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
            _startupBackupOpen = true;
            backupStartupB.Enabled = false;
            startupBackupStrip.Visible = true;
            LayoutStartupTab();
            txtBackupTitle.Focus();
            txtBackupTitle.SelectAll();
        }

        private void HideBackupConfirm()
        {
            _startupBackupOpen = false;
            backupStartupB.Enabled = true;
            startupBackupStrip.Visible = false;
            LayoutStartupTab();
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
                    _backupItems.Add(new BackupStartupItem(x.Name, x.FileLocation, x.RegistryLocation.ToString(), x.StartupType.ToString()));
                }

                try
                {
                    File.WriteAllText(CoreHelper.StartupItemsBackupFolder + Utilities.SanitizeFileFolderName(txtBackupTitle.Text + " - [" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString()) + "].json", JsonConvert.SerializeObject(_backupItems, Formatting.Indented));
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.BackupStartupItems", ex.Message, ex.StackTrace);
                }
            }
        }

        private void btnOpenNetwork_Click(object sender, EventArgs e)
        {
            Process.Start("NCPA.cpl");
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
            OptionsHelper.CurrentOptions.EnableTray = quickAccessToggle.ToggleChecked;
            OptionsHelper.SaveSettings();

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
            if (_hwDetailed == null || _hwSummarized == null) return;

            specsTree.BeginUpdate();
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
            specsTree.EndUpdate();
            if (specsTree.Nodes.Count > 0) specsTree.Nodes[0].EnsureVisible();
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
                Logger.LogError("MainForm.ParseChangelog", ex.Message, ex.StackTrace);
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
            if (boxLang.Text == Constants.ENGLISH)
            {
                picFlag.Image = Properties.Resources.united_kingdom;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EN;
            }
            else if (boxLang.Text == Constants.RUSSIAN)
            {
                picFlag.Image = Properties.Resources.russia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RU;
            }
            else if (boxLang.Text == Constants.HELLENIC)
            {
                picFlag.Image = Properties.Resources.greece;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EL;
            }
            else if (boxLang.Text == Constants.GERMAN)
            {
                picFlag.Image = Properties.Resources.germany;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.DE;
            }
            else if (boxLang.Text == Constants.ITALIAN)
            {
                picFlag.Image = Properties.Resources.italy;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.IT;
            }
            else if (boxLang.Text == Constants.CZECH)
            {
                picFlag.Image = Properties.Resources.czech;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CZ;
            }
            else if (boxLang.Text == Constants.TURKISH)
            {
                picFlag.Image = Properties.Resources.turkey;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TR;
            }
            else if (boxLang.Text == Constants.SPANISH)
            {
                picFlag.Image = Properties.Resources.spain;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ES;
            }
            else if (boxLang.Text == Constants.PORTUGUESE)
            {
                picFlag.Image = Properties.Resources.brazil;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PT;
            }
            else if (boxLang.Text == Constants.FRENCH)
            {
                picFlag.Image = Properties.Resources.france;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FR;
            }
            else if (boxLang.Text == Constants.CHINESE)
            {
                picFlag.Image = Properties.Resources.china;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CN;
            }
            else if (boxLang.Text == Constants.TAIWANESE)
            {
                picFlag.Image = Properties.Resources.china;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TW;
            }
            else if (boxLang.Text == Constants.KOREAN)
            {
                picFlag.Image = Properties.Resources.korea;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KO;
            }
            else if (boxLang.Text == Constants.POLISH)
            {
                picFlag.Image = Properties.Resources.poland;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PL;
            }
            else if (boxLang.Text == Constants.ARABIC)
            {
                picFlag.Image = Properties.Resources.egypt;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.AR;
            }
            else if (boxLang.Text == Constants.KURDISH)
            {
                picFlag.Image = Properties.Resources.kurdish;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KU;
            }
            else if (boxLang.Text == Constants.HUNGARIAN)
            {
                picFlag.Image = Properties.Resources.hungary;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HU;
            }
            else if (boxLang.Text == Constants.ROMANIAN)
            {
                picFlag.Image = Properties.Resources.romania;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RO;
            }
            else if (boxLang.Text == Constants.DUTCH)
            {
                picFlag.Image = Properties.Resources.dutch;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NL;
            }
            else if (boxLang.Text == Constants.UKRAINIAN)
            {
                picFlag.Image = Properties.Resources.ukraine;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UA;
            }
            else if (boxLang.Text == Constants.JAPANESE)
            {
                picFlag.Image = Properties.Resources.japan;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.JA;
            }
            else if (boxLang.Text == Constants.PERSIAN)
            {
                picFlag.Image = Properties.Resources.iran;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FA;
            }
            else if (boxLang.Text == Constants.NEPALI)
            {
                picFlag.Image = Properties.Resources.nepal;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NE;
            }
            else if (boxLang.Text == Constants.BULGARIAN)
            {
                picFlag.Image = Properties.Resources.bulgaria;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.BG;
            }
            else if (boxLang.Text == Constants.VIETNAMESE)
            {
                picFlag.Image = Properties.Resources.vietnam;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.VN;
            }
            else if (boxLang.Text == Constants.URDU)
            {
                picFlag.Image = Properties.Resources.pakistan;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UR;
            }
            else if (boxLang.Text == Constants.INDONESIAN)
            {
                picFlag.Image = Properties.Resources.indonesia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ID;
            }
            else if (boxLang.Text == Constants.CROATIAN)
            {
                picFlag.Image = Properties.Resources.indonesia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HR;
            }

            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
            Translate();

            FixTabHeaderWidth(tabCollection);
            FixTabHeaderWidth(synapse);
            FixTabHeaderWidth(netTools);

            btnUpdate.Focus();
        }

        private void cleanDriveB_Click(object sender, EventArgs e)
        {
            CleanSelectedAsync();
        }

        private void checkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listCleanPreview.Items.Count < 1)
            {
                foreach (CheckBox x in CleanerBoxes())
                {
                    x.Checked = !x.Checked;
                }
                return;
            }

            _cleanSelectAll = !_cleanSelectAll;
            _cleanBulk = true;
            listCleanPreview.BeginUpdate();
            for (int i = 0; i < listCleanPreview.Items.Count; i++)
            {
                listCleanPreview.SetItemChecked(i, _cleanSelectAll);
            }
            listCleanPreview.EndUpdate();
            _cleanBulk = false;
            UpdateCleanSelection();
        }

        private void analyzeDriveB_Click(object sender, EventArgs e)
        {
            AnalyzeCleanerAsync();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_paypalSupportLink);
        }

        private void linkDNSIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string ip = ((LinkLabel)sender).Text;
                if (string.IsNullOrWhiteSpace(ip) || ip == "-") return;
                Clipboard.SetText(ip);
                FlashDnsCopied();
            }
            catch { }
        }

        private void DisplayCurrentDNS()
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;
            if (PingerHelper.NetworkAdapters == null || boxAdapter.SelectedIndex >= PingerHelper.NetworkAdapters.Length) return;

            try
            {
                _currentDNS = PingerHelper.GetDNSFromNetworkAdapter(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();
                ShowCurrentDNS();
            }
            catch { }
            finally { pingerTab.Focus(); }
        }
        private void boxAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNetworkAdapterConfig();
            pingerTab.Focus();
        }

        // Freeze the content layout while the window is dragged or resized: the pages keep their last layout
        // (clipped or padded with the background) instead of re-flowing hundreds of controls per mouse move,
        // and everything re-flows once when the drag ends.
        bool _sizeMoveFrozen;

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            if (_sizeMoveFrozen) return;
            _sizeMoveFrozen = true;
            bpanel.SuspendLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (!_sizeMoveFrozen) return;
            _sizeMoveFrozen = false;
            bpanel.ResumeLayout(true);
        }

        private void PMB_ToggleClicked(object sender, EventArgs e)
        {
            if (PMB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(CoreHelper.ReadyMadeMenusFolder + "\\PowerMenu.reg");
            }
            else
            {
                IntegratorHelper.RemoveItem("Power Menu");
            }

            GetDesktopItems();
        }

        private void AddOwnerB_ToggleClicked(object sender, EventArgs e)
        {
            if (AddOwnerB.ToggleChecked)
            {
                IntegratorHelper.InstallTakeOwnership(false);
            }
            else
            {
                IntegratorHelper.InstallTakeOwnership(true);
            }

            GetDesktopItems();
        }

        private void AddCMDB_ToggleClicked(object sender, EventArgs e)
        {
            if (AddCMDB.ToggleChecked)
            {
                IntegratorHelper.InstallOpenWithCMD();
            }
            else
            {
                IntegratorHelper.DeleteOpenWithCMD();
            }

            GetDesktopItems();
        }

        private void DSB_ToggleClicked(object sender, EventArgs e)
        {
            if (DSB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(CoreHelper.ReadyMadeMenusFolder + "\\DesktopShortcuts.reg");
            }
            else
            {
                IntegratorHelper.RemoveItem("DesktopShortcuts");
            }

            GetDesktopItems();
        }

        private void STB_ToggleClicked(object sender, EventArgs e)
        {
            if (STB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(CoreHelper.ReadyMadeMenusFolder + "\\SystemTools.reg");
            }
            else
            {
                IntegratorHelper.RemoveItem("SystemTools");
            }

            GetDesktopItems();
        }

        private void WAB_ToggleClicked(object sender, EventArgs e)
        {
            if (WAB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(CoreHelper.ReadyMadeMenusFolder + "\\WindowsApps.reg");
            }
            else
            {
                IntegratorHelper.RemoveItem("WindowsApps");
            }

            GetDesktopItems();
        }

        private void SSB_ToggleClicked(object sender, EventArgs e)
        {
            if (SSB.ToggleChecked)
            {
                Utilities.ImportRegistryScript(CoreHelper.ReadyMadeMenusFolder + "\\SystemShortcuts.reg");
            }
            else
            {
                IntegratorHelper.RemoveItem("SystemShortcuts");
            }

            GetDesktopItems();
        }

        private void trayUnlocker_Click(object sender, EventArgs e)
        {
            tabCollection.SelectedTab = fileHandlesTab;
            RestoreWindow();
        }

        private void picRestartNeeded_Click(object sender, EventArgs e)
        {
            ConfirmAndReboot();
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
            restartAndApply.Font = Typography.WithStyle(restartAndApply.Font, FontStyle.Regular);
        }

        private void restartAndApply_MouseHover(object sender, EventArgs e)
        {
            restartAndApply.Font = Typography.WithStyle(restartAndApply.Font, FontStyle.Underline);
        }

        private void restartAndApply_MouseEnter(object sender, EventArgs e)
        {
            restartAndApply.Font = Typography.WithStyle(restartAndApply.Font, FontStyle.Underline);
        }

        private void restartAndApply_Click(object sender, EventArgs e)
        {
            ConfirmAndReboot();
        }

        private void colorPicker1_ColorChanged(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.Theme = colorPicker1.Color;
            RefreshTheme();

            OptionsHelper.SaveSettings();
        }

        private void themeModeToggle_ToggleClicked(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.ThemeMode = themeModeToggle.ToggleChecked ? ThemeMode.Dark : ThemeMode.Light;
            RefreshTheme();

            OptionsHelper.SaveSettings();
        }

        private void autoStartToggle_ToggleClicked(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.AutoStart = autoStartToggle.ToggleChecked;
            OptionsHelper.SaveSettings();

            if (OptionsHelper.CurrentOptions.AutoStart)
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
            TipBubble.Toggle(picLab, null, translationList["lblLab"].ToString());
        }

        private void btnRestoreUwp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UWPHelper.RestoreAllUWPApps();
            }
        }

        private void btnRestartSafe_Click(object sender, EventArgs e)
        {
            Program.RestartInSafeMode();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Program.RestartInNormalMode();
        }

        private void ConfirmAndReboot()
        {
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OptionsHelper.SaveSettings();
                Utilities.Reboot();
            }
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_bugReportLink);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_featureRequestLink);
        }

        private void btnRefreshFonts_Click(object sender, EventArgs e)
        {
            LoadAvailableFonts();
        }

        private void btnRestoreFont_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FontHelper.RestoreDefaultGlobalFont();
                ShowRestartNeeded();
            }
        }

        private void btnSetGlobalFont_Click(object sender, EventArgs e)
        {
            if (listFonts.SelectedIndex < 0)
            {
                return;
            }
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string fontName = listFonts.SelectedItem.ToString();
                FontHelper.ChangeGlobalFont(fontName);
                ShowRestartNeeded();
            }
        }

        private void txtSearchFonts_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchFonts.Text))
            {
                string query = txtSearchFonts.Text.ToLowerInvariant().Trim();
                listFonts.BeginUpdate();
                listFonts.Items.Clear();
                listFonts.Items.AddRange(_availableFonts.Where(x => x.ToLowerInvariant().Contains(query)).ToArray());
                listFonts.EndUpdate();
                UpdateIntegratorCounts();
            }
            else
            {
                LoadAvailableFonts();
            }
        }

        private void chkCustomDns_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = chkCustomDns.Checked;
            label12.Visible = chkCustomDns.Checked;
            txtDns4A.Visible = chkCustomDns.Checked;
            txtDns4B.Visible = chkCustomDns.Checked;
            txtDns6A.Visible = chkCustomDns.Checked;
            txtDns6B.Visible = chkCustomDns.Checked;
            boxDNS.Visible = !chkCustomDns.Checked;
        }

        private void btnSetDns_Click(object sender, EventArgs e)
        {
            if (chkCustomDns.Checked)
            {
                ApplyCustomDNS();
            }
            else
            {
                ApplySelectedDNS();
            }
        }

        private void btnReinforce_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_reinforcePoliciesMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilities.ReinforceCurrentTweaks();

                if (Program.MUTEX != null)
                {
                    Program.MUTEX.ReleaseMutex();
                    Program.MUTEX.Dispose();
                    Program.MUTEX = null;
                }
                Application.Restart();
            }
        }

        private void autoUpdateToggle_ToggleClicked(object sender, EventArgs e)
        {
            OptionsHelper.CurrentOptions.UpdateOnLaunch = autoUpdateToggle.ToggleChecked;
            OptionsHelper.SaveSettings();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_faqSectionLink);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSystemVariables();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSysVar.Text))
            {
                listSystemVariables.Items.Add(txtSysVar.Text);
                _systemVariables.Add(txtSysVar.Text);
                IntegratorHelper.UpdatePathSystemVariables(_systemVariables.ToArray());
                txtSysVar.Clear();
                LoadSystemVariables();
                IntegratorHelper.ApplyPathSystemVariables();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listSystemVariables.SelectedItems.Count == 1)
            {
                var indexToDelete = _systemVariables.FindIndex(x => x.Equals(listSystemVariables.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase));
                if (indexToDelete != -1)
                {
                    _systemVariables.RemoveAt(indexToDelete);
                }
                IntegratorHelper.UpdatePathSystemVariables(_systemVariables.ToArray());
                LoadSystemVariables();
                IntegratorHelper.ApplyPathSystemVariables();
            }
        }
    }
}
