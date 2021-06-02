using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class MainForm : Form
    {
        ListViewColumnSorter _columnSorter;

        List<StartupItem> _startUpItems = new List<StartupItem>();
        List<StartupBackupItem> _backupItems = new List<StartupBackupItem>();

        List<string> _hostsEntries = new List<string>();
        List<string> _customCommands = new List<string>();
        List<string> _desktopItems = new List<string>();
        List<string> _modernApps = new List<string>();

        bool _trayMenu = false;

        List<PingReply> _pingResults;
        string _shodanIP = string.Empty;
        PingReply tmpReply;

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        public List<FeedApp> AppsFromFeed = new List<FeedApp>();
        readonly string _feedLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/feed.json";

        readonly string _licenseLink = "https://www.gnu.org/licenses/gpl-3.0.en.html";
        readonly string _openSourceLink = "https://opensource.org/";

        readonly string _latestVersionLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/version.txt";
        readonly string _changelogLink = "https://github.com/hellzerg/optimizer/blob/master/CHANGELOG.md";

        string _noNewVersionMessage = "You already have the latest version!";
        string _betaVersionMessage = "You are using an experimental version!";

        readonly string _blockedIP = "0.0.0.0";

        string _restartMessage = "Restart to apply changes?";
        string _removeStartupItemsMessage = "Are you sure you want to delete all startup items?";
        string _removeHostsEntriesMessage = "Are you sure you want to delete all hosts entries?";
        string _removeDesktopItemsMessage = "Are you sure you want to delete all desktop items?";
        string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";
        string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled:\n";
        string _resetMessage = "Are you sure you want to reset configuration?\n\nThis will reset all your preferences, including any icons you extracted or downloaded using Integrator, but will not touch anything on your computer!";

        private string NewVersionMessage(string latestVersion)
        {
            return Options.TranslationList["newVersion"].ToString().Replace("{LATEST}", latestVersion).Replace("{CURRENT}", Program.GetCurrentVersionTostring());
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
                        linkUpdate.Visible = true;
                        return;
                    }

                    if (MessageBox.Show(NewVersionMessage(latestVersion), "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // PATCHING PROCESS
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

                            _trayMenu = false;
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
                    if (!silentCheck) MessageBox.Show(_noNewVersionMessage, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!silentCheck) MessageBox.Show(_betaVersionMessage, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EnableToggleEvents()
        {
            actionSw.Click += new EventHandler(ToggleSwitch7_Click);
            officeTelemetrySw.Click += new EventHandler(toggleSwitch12_Click);
            telemetryTasksSw.Click += new EventHandler(toggleSwitch11_Click);
            superfetchSw.Click += new EventHandler(toggleSwitch10_Click);
            homegroupSw.Click += new EventHandler(toggleSwitch9_Click);
            reportingSw.Click += new EventHandler(toggleSwitch8_Click);
            mediaSharingSw.Click += new EventHandler(toggleSwitch6_Click);
            printSw.Click += new EventHandler(toggleSwitch5_Click);
            systemRestoreSw.Click += new EventHandler(toggleSwitch4_Click);
            performanceSw.Click += new EventHandler(toggleSwitch1_Click);
            defenderSw.Click += new EventHandler(toggleSwitch3_Click);
            networkSw.Click += new EventHandler(toggleSwitch2_Click);
            darkSw.Click += new EventHandler(toggleSwitch27_Click);
            spellSw.Click += new EventHandler(toggleSwitch28_Click);
            inkSw.Click += new EventHandler(toggleSwitch29_Click);
            driversSw.Click += new EventHandler(toggleSwitch30_Click);
            sensorSw.Click += new EventHandler(toggleSwitch20_Click);
            privacySw.Click += new EventHandler(toggleSwitch21_Click);
            telemetryServicesSw.Click += new EventHandler(toggleSwitch23_Click);
            autoUpdatesSw.Click += new EventHandler(toggleSwitch24_Click);
            peopleSw.Click += new EventHandler(toggleSwitch25_Click);
            adsSw.Click += new EventHandler(toggleSwitch26_Click);
            xboxSw.Click += new EventHandler(toggleSwitch17_Click);
            cortanaSw.Click += new EventHandler(toggleSwitch16_Click);
            gameBarSw.Click += new EventHandler(toggleSwitch15_Click);
            uODSw.Click += new EventHandler(toggleSwitch14_Click);
            oldMixerSw.Click += new EventHandler(toggleSwitch13_Click);
            disableOneDriveSw.Click += new EventHandler(toggleSwitch31_Click);
            oldExplorerSw.Click += new EventHandler(toggleSwitch18_Click);
            colorBarSw.Click += new EventHandler(toggleSwitch19_Click);
            compatSw.Click += new EventHandler(toggleSwitch32_Click);
            faxSw.Click += new EventHandler(ToggleSwitch33_Click);
            insiderSw.Click += new EventHandler(ToggleSwitch34_Click);
            featuresSw.Click += new EventHandler(ToggleSwitch35_Click);
            smartScreenSw.Click += new EventHandler(ToggleSwitch36_Click);
            ccSw.Click += new EventHandler(ToggleSwitch37_Click);
            stickySw.Click += new EventHandler(ToggleSwitch38_Click);
            longPathsSw.Click += new EventHandler(ToggleSwitch39_Click);
            castSw.Click += new EventHandler(ToggleSwitch40_Click);
        }

        private void SetHelpBoxTranslation()
        {
            helpBox.SetToolTip(performanceSw, Options.TranslationList["performanceTip"].ToString());
            helpBox.SetToolTip(networkSw, Options.TranslationList["networkTip"].ToString());
            helpBox.SetToolTip(defenderSw, Options.TranslationList["defenderTip"].ToString());
            helpBox.SetToolTip(smartScreenSw, Options.TranslationList["smartScreenTip"].ToString());
            helpBox.SetToolTip(systemRestoreSw, Options.TranslationList["systemRestoreTip"].ToString());
            helpBox.SetToolTip(reportingSw, Options.TranslationList["reportingTip"].ToString());
            helpBox.SetToolTip(telemetryTasksSw, Options.TranslationList["telemetryTasksTip"].ToString());
            helpBox.SetToolTip(officeTelemetrySw, Options.TranslationList["officeTelemetryTip"].ToString());
            helpBox.SetToolTip(printSw, Options.TranslationList["printTip"].ToString());
            helpBox.SetToolTip(faxSw, Options.TranslationList["faxTip"].ToString());
            helpBox.SetToolTip(mediaSharingSw, Options.TranslationList["mediaSharingTip"].ToString());
            helpBox.SetToolTip(stickySw, Options.TranslationList["stickyTip"].ToString());
            helpBox.SetToolTip(homegroupSw, Options.TranslationList["homegroupTip"].ToString());
            helpBox.SetToolTip(superfetchSw, Options.TranslationList["superfetchTip"].ToString());
            helpBox.SetToolTip(compatSw, Options.TranslationList["compatTip"].ToString());
            helpBox.SetToolTip(disableOneDriveSw, Options.TranslationList["disableOneDriveTip"].ToString());
            helpBox.SetToolTip(oldMixerSw, Options.TranslationList["oldMixerTip"].ToString());
            helpBox.SetToolTip(colorBarSw, Options.TranslationList["colorBarTip"].ToString());
            helpBox.SetToolTip(oldExplorerSw, Options.TranslationList["oldExplorerTip"].ToString());
            helpBox.SetToolTip(adsSw, Options.TranslationList["adsTip"].ToString());
            helpBox.SetToolTip(darkSw, Options.TranslationList["darkTip"].ToString());
            helpBox.SetToolTip(uODSw, Options.TranslationList["uODTip"].ToString());
            helpBox.SetToolTip(peopleSw, Options.TranslationList["peopleTip"].ToString());
            helpBox.SetToolTip(longPathsSw, Options.TranslationList["longPathsTip"].ToString());
            helpBox.SetToolTip(inkSw, Options.TranslationList["inkTip"].ToString());
            helpBox.SetToolTip(spellSw, Options.TranslationList["spellTip"].ToString());
            helpBox.SetToolTip(xboxSw, Options.TranslationList["xboxTip"].ToString());
            helpBox.SetToolTip(actionSw, Options.TranslationList["actionTip"].ToString());
            helpBox.SetToolTip(autoUpdatesSw, Options.TranslationList["autoUpdatesTip"].ToString());
            helpBox.SetToolTip(driversSw, Options.TranslationList["driversTip"].ToString());
            helpBox.SetToolTip(telemetryServicesSw, Options.TranslationList["telemetryServicesTip"].ToString());
            helpBox.SetToolTip(privacySw, Options.TranslationList["privacyTip"].ToString());
            helpBox.SetToolTip(ccSw, Options.TranslationList["ccTip"].ToString());
            helpBox.SetToolTip(cortanaSw, Options.TranslationList["cortanaTip"].ToString());
            helpBox.SetToolTip(sensorSw, Options.TranslationList["sensorTip"].ToString());
            helpBox.SetToolTip(castSw, Options.TranslationList["castTip"].ToString());
            helpBox.SetToolTip(gameBarSw, Options.TranslationList["gameBarTip"].ToString());
            helpBox.SetToolTip(insiderSw, Options.TranslationList["insiderTip"].ToString());
            helpBox.SetToolTip(featuresSw, Options.TranslationList["featuresTip"].ToString());
        }

        private void ToggleSwitch7_Click(object sender, EventArgs e)
        {
            if (!actionSw.Checked)
            {
                Optimize.DisableActionCenter();
            }
            else
            {
                Optimize.EnableActionCenter();
            }
            Options.CurrentOptions.DisableActionCenter = !actionSw.Checked;
        }

        private void ToggleSwitch40_Click(object sender, EventArgs e)
        {
            if (!castSw.Checked)
            {
                Optimize.RemoveCastToDevice();
            }
            else
            {
                Optimize.AddCastToDevice();
            }
            Options.CurrentOptions.RemoveCastToDevice = !castSw.Checked;
        }

        private void ToggleSwitch39_Click(object sender, EventArgs e)
        {
            if (!longPathsSw.Checked)
            {
                Optimize.EnableLongPaths();
            }
            else
            {
                Optimize.DisableLongPaths();
            }
            Options.CurrentOptions.EnableLongPaths = !longPathsSw.Checked;
        }

        private void ToggleSwitch38_Click(object sender, EventArgs e)
        {
            if (!stickySw.Checked)
            {
                Optimize.DisableStickyKeys();
            }
            else
            {
                Optimize.EnableStickyKeys();
            }
            Options.CurrentOptions.DisableStickyKeys = !stickySw.Checked;
        }

        private void ToggleSwitch37_Click(object sender, EventArgs e)
        {
            if (!ccSw.Checked)
            {
                Optimize.DisableCloudClipboard();
            }
            else
            {
                Optimize.EnableCloudClipboard();
            }
            Options.CurrentOptions.DisableCloudClipboard = !ccSw.Checked;
        }

        private void ToggleSwitch36_Click(object sender, EventArgs e)
        {
            if (!smartScreenSw.Checked)
            {
                Optimize.DisableSmartScreen();
            }
            else
            {
                Optimize.EnableSmartScreen();
            }
            Options.CurrentOptions.DisableSmartScreen = !smartScreenSw.Checked;
        }

        private void ToggleSwitch35_Click(object sender, EventArgs e)
        {
            if (!featuresSw.Checked)
            {
                Optimize.DisableForcedFeatureUpdates();
            }
            else
            {
                Optimize.EnableForcedFeatureUpdates();
            }
            Options.CurrentOptions.DisableFeatureUpdates = !featuresSw.Checked;
        }

        private void ToggleSwitch34_Click(object sender, EventArgs e)
        {
            if (!insiderSw.Checked)
            {
                Optimize.DisableInsiderService();
            }
            else
            {
                Optimize.EnableInsiderService();
            }
            Options.CurrentOptions.DisableInsiderService = !insiderSw.Checked;
        }

        private void ToggleSwitch33_Click(object sender, EventArgs e)
        {
            if (!faxSw.Checked)
            {
                Optimize.DisableFaxService();
            }
            else
            {
                Optimize.EnableFaxService();
            }
            Options.CurrentOptions.DisableFaxService = !faxSw.Checked;
        }

        private void LoadSettings()
        {
            switch (Options.CurrentOptions.Color)
            {
                case Theme.Caramel:
                    radioCaramel.Checked = true;
                    break;
                case Theme.Lime:
                    radioLime.Checked = true;
                    break;
                case Theme.Magma:
                    radioMagma.Checked = true;
                    break;
                case Theme.Minimal:
                    radioMinimal.Checked = true;
                    break;
                case Theme.Ocean:
                    radioOcean.Checked = true;
                    break;
                case Theme.Zerg:
                    radioZerg.Checked = true;
                    break;
            }
        }

        //INIT
        public MainForm()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            CheckForIllegalCrossThreadCalls = false;

            EnableToggleEvents();

            // theming
            Options.ApplyTheme(this);
            launcherMenu.Renderer = new ToolStripRendererMaterial();
            progressDownloader.BackColor = Options.ForegroundColor;
            progressDownloader.ForeColor = Options.ForegroundAccentColor;

            // quick access
            _trayMenu = Options.CurrentOptions.EnableTray;
            quickAccessToggle.Checked = Options.CurrentOptions.EnableTray;
            launcherIcon.Visible = Options.CurrentOptions.EnableTray;

            // help tips
            helpBox.Active = Options.CurrentOptions.ShowHelp;
            helpTipsToggle.Checked = Options.CurrentOptions.ShowHelp;

            // fix SSL/TLS error when contacting internet
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // initial states
            chkOnlyRemovable.Checked = true;
            checkDefaultIcon.Checked = true;
            radioProgram.Checked = true;
            radioTop.Checked = true;
            c64.Checked = Environment.Is64BitOperatingSystem;
            c32.Checked = !Environment.Is64BitOperatingSystem;

            // EXPERIMENTAL message
            lblLab.Visible = Program.EXPERIMENTAL_BUILD;

            txtOS.Text = "Microsoft " + Utilities.GetOS();
            txtBitness.Text = Utilities.GetBitness();

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Unsupported)
            {
                tabCollection.TabPages.Remove(universalTab);
                tabCollection.TabPages.Remove(windowsVIIITab);
                tabCollection.TabPages.Remove(windowsXTab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
            {
                LoadUniversalToggleStates();
                tabCollection.TabPages.Remove(windowsVIIITab);
                tabCollection.TabPages.Remove(windowsXTab);
                tabCollection.TabPages.Remove(modernAppsTab);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
            {
                LoadUniversalToggleStates();
                LoadWindowsVIIIToggleStates();
                tabCollection.TabPages.Remove(windowsXTab);
                GetModernApps(false);
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
            {
                LoadUniversalToggleStates();
                LoadWindowsXToggleStates();
                tabCollection.TabPages.Remove(windowsVIIITab);
                GetModernApps(false);
            }

            _columnSorter = new ListViewColumnSorter();
            listStartupItems.ListViewItemSorter = _columnSorter;

            GetStartupItems();
            GetHostsEntries();

            GetDesktopItems();
            GetCustomCommands();

            GetFeed();
            GetFootprint();

            LoadSettings();

            // Translation-related
            if (Options.CurrentOptions.LanguageCode != LanguageCode.EN) Translate();

            if (Options.CurrentOptions.LanguageCode == LanguageCode.EN)
            {
                radioEnglish.Checked = true;
                txtVersion.Text = txtVersion.Text.Replace("{VN}", Program.GetCurrentVersionTostring());
            }

            if (Options.CurrentOptions.LanguageCode == LanguageCode.RU) radioRussian.Checked = true;

            Program.MainForm = this;

            if (string.IsNullOrEmpty(Options.CurrentOptions.AppsFolder))
            {
                txtDownloadFolder.Text = Path.Combine(Application.StartupPath, "Optimizer Downloads");
                Options.CurrentOptions.AppsFolder = Path.Combine(Application.StartupPath, "Optimizer Downloads");
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

            if (!Program.EXPERIMENTAL_BUILD && Utilities.IsInternetAvailable()) CheckForUpdate(true);

            if (Program.EXPERIMENTAL_BUILD)
            {
                btnUpdate.Enabled = false;
                lblUpdateDisabled.Visible = true;
            }
        }

        private void Translate()
        {
            _noNewVersionMessage = Options.TranslationList["noNewVersion"];
            _betaVersionMessage = Options.TranslationList["betaVersion"];
            _restartMessage = Options.TranslationList["restartAndApply"];
            _removeStartupItemsMessage = Options.TranslationList["removeAllStartup"];
            _removeHostsEntriesMessage = Options.TranslationList["removeAllHosts"];
            _removeDesktopItemsMessage = Options.TranslationList["removeAllItems"];
            _removeModernAppsMessage = Options.TranslationList["removeModernApps"];
            _errorModernAppsMessage = Options.TranslationList["errorModernApps"];
            _resetMessage = Options.TranslationList["resetMessage"];

            SetHelpBoxTranslation();

            Dictionary<string, string> translationList = Options.TranslationList.ToObject<Dictionary<string, string>>();
            if (Environment.Is64BitOperatingSystem)
            {
                translationList["txtBitness"] = translationList["txtBitness"].Replace("{BITS}", translationList["c64"]);
            }
            else
            {
                translationList["txtBitness"] = translationList["txtBitness"].Replace("{BITS}", translationList["c32"]);
            }

            listStartupItems.Columns[0].Text = translationList["startupItemName"];
            listStartupItems.Columns[1].Text = translationList["startupItemLocation"];
            listStartupItems.Columns[2].Text = translationList["startupItemType"];
            trayStartup.Text = translationList["trayStartup"];
            trayCleaner.Text = translationList["trayCleaner"];
            trayPinger.Text = translationList["trayPinger"];
            trayHosts.Text = translationList["trayHosts"];
            trayAD.Text = translationList["trayAD"];
            trayRestartExplorer.Text = translationList["trayRestartExplorer"];
            trayExit.Text = translationList["trayExit"];

            Control element;

            foreach (var x in translationList)
            {
                if (x.Key == null || x.Key == string.Empty) continue;
                element = this.Controls.Find(x.Key, true).FirstOrDefault();

                if (element == null) continue;

                if (element is ToggleSwitch)
                {
                    ((ToggleSwitch)element).OnText = x.Value;
                    continue;
                }

                element.Text = x.Value;
            }

            txtVersion.Text = txtVersion.Text.Replace("{VN}", Program.GetCurrentVersionTostring());
        }

        private void GetFootprint()
        {
            ByteSize footprint = CleanHelper.CheckFootprint();
            lblFootprint.Text = footprint.ToString();
        }

        private void GetFeed()
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            try
            {
                string feed = client.DownloadString(_feedLink);
                AppsFromFeed = JsonConvert.DeserializeObject<List<FeedApp>>(feed);

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

        private void CleanPC()
        {
            try
            {
                if (checkTemp.Checked)
                {
                    CleanHelper.CleanTemporaries();
                }
                if (checkMiniDumps.Checked)
                {
                    CleanHelper.CleanMiniDumps();
                }
                if (checkMediaCache.Checked)
                {
                    CleanHelper.CleanMediaPlayersCache();
                }
                if (checkLogs.Checked)
                {
                    CleanHelper.CleanLogs();
                }
                if (checkErrorReports.Checked)
                {
                    CleanHelper.CleanErrorReports();
                }
                if (checkBin.Checked)
                {
                    CleanHelper.EmptyRecycleBin();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.CleanPC", ex.Message, ex.StackTrace);
            }
            finally
            {
                Cleaning(false);
                GetFootprint();
            }
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
            performanceSw.Checked = Options.CurrentOptions.EnablePerformanceTweaks;
            networkSw.Checked = Options.CurrentOptions.DisableNetworkThrottling;
            defenderSw.Checked = Options.CurrentOptions.DisableWindowsDefender;
            systemRestoreSw.Checked = Options.CurrentOptions.DisableSystemRestore;
            printSw.Checked = Options.CurrentOptions.DisablePrintService;
            mediaSharingSw.Checked = Options.CurrentOptions.DisableMediaPlayerSharing;
            reportingSw.Checked = Options.CurrentOptions.DisableErrorReporting;
            homegroupSw.Checked = Options.CurrentOptions.DisableHomeGroup;
            superfetchSw.Checked = Options.CurrentOptions.DisableSuperfetch;
            telemetryTasksSw.Checked = Options.CurrentOptions.DisableTelemetryTasks;
            officeTelemetrySw.Checked = Options.CurrentOptions.DisableOffice2016Telemetry;
            compatSw.Checked = Options.CurrentOptions.DisableCompatibilityAssistant;
            faxSw.Checked = Options.CurrentOptions.DisableFaxService;
            smartScreenSw.Checked = Options.CurrentOptions.DisableSmartScreen;
            stickySw.Checked = Options.CurrentOptions.DisableStickyKeys;
        }

        private void LoadWindowsVIIIToggleStates()
        {
            disableOneDriveSw.Checked = Options.CurrentOptions.DisableOneDrive;
        }

        private void LoadWindowsXToggleStates()
        {
            oldMixerSw.Checked = Options.CurrentOptions.EnableLegacyVolumeSlider;
            uODSw.Checked = Options.CurrentOptions.UninstallOneDrive;
            gameBarSw.Checked = Options.CurrentOptions.DisableGameBar;
            cortanaSw.Checked = Options.CurrentOptions.DisableCortana;
            xboxSw.Checked = Options.CurrentOptions.DisableXboxLive;
            oldExplorerSw.Checked = Options.CurrentOptions.DisableQuickAccessHistory;
            colorBarSw.Checked = Options.CurrentOptions.EnableTaskbarColor;
            sensorSw.Checked = Options.CurrentOptions.DisableSensorServices;
            privacySw.Checked = Options.CurrentOptions.DisablePrivacyOptions;
            telemetryServicesSw.Checked = Options.CurrentOptions.DisableTelemetryServices;
            autoUpdatesSw.Checked = Options.CurrentOptions.DisableAutomaticUpdates;
            peopleSw.Checked = Options.CurrentOptions.DisableMyPeople;
            adsSw.Checked = Options.CurrentOptions.DisableStartMenuAds;
            darkSw.Checked = Options.CurrentOptions.EnableDarkTheme;
            spellSw.Checked = Options.CurrentOptions.DisableSpellingTyping;
            inkSw.Checked = Options.CurrentOptions.DisableWindowsInk;
            driversSw.Checked = Options.CurrentOptions.ExcludeDrivers;
            insiderSw.Checked = Options.CurrentOptions.DisableInsiderService;
            featuresSw.Checked = Options.CurrentOptions.DisableFeatureUpdates;
            ccSw.Checked = Options.CurrentOptions.DisableCloudClipboard;
            longPathsSw.Checked = Options.CurrentOptions.EnableLongPaths;
            castSw.Checked = Options.CurrentOptions.RemoveCastToDevice;
            actionSw.Checked = Options.CurrentOptions.DisableActionCenter;
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
            adblockBasic.Enabled = !chkReadOnly.Checked;
            adblockS.Enabled = !chkReadOnly.Checked;
            adblockP.Enabled = !chkReadOnly.Checked;
            adblockUlti.Enabled = !chkReadOnly.Checked;

            ((Control)this.hostsEditorTab).Enabled = true;
        }

        private void GetStartupItems()
        {
            _startUpItems = Utilities.GetStartupItems();
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
            listModernApps.Enabled = false;

            listModernApps.Items.Clear();
            _modernApps = Utilities.GetModernApps(showAll);

            foreach (string x in _modernApps)
            {
                listModernApps.Items.Add(x);
            }

            uninstallModernAppsButton.Enabled = true;
            refreshModernAppsButton.Enabled = true;
            listModernApps.Enabled = true;
        }

        private async void UninstallModernApps()
        {
            string selectedApps = string.Empty;

            if (listModernApps.CheckedItems.Count > 0)
            {
                foreach (string x in listModernApps.CheckedItems)
                {
                    if (string.IsNullOrEmpty(selectedApps))
                    {
                        selectedApps = x;
                    }
                    else
                    {
                        selectedApps += Environment.NewLine + x;
                    }
                }

                if (MessageBox.Show(_removeModernAppsMessage + "\n\n" + selectedApps, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    uninstallModernAppsButton.Enabled = false;
                    refreshModernAppsButton.Enabled = false;
                    listModernApps.Enabled = false;

                    bool errorOccured = false;
                    string failedApps = string.Empty;

                    foreach (string app in listModernApps.CheckedItems)
                    {
                        await Task.Run(() => errorOccured = Utilities.UninstallModernApp(app));

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
        }

        private void GetCustomCommands()
        {
            _customCommands = Integrator.GetCustomCommands();
            listCustomCommands.Items.Clear();

            foreach (string s in _customCommands)
            {
                listCustomCommands.Items.Add(s);
            }
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

        private void button39_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            HelperForm f = new HelperForm(this, MessageType.Restart, _restartMessage);
            f.ShowDialog();
        }

        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            checkTemp.Checked = checkSelectAll.Checked;
            checkMiniDumps.Checked = checkSelectAll.Checked;
            checkMediaCache.Checked = checkSelectAll.Checked;
            checkLogs.Checked = checkSelectAll.Checked;
            checkBin.Checked = checkSelectAll.Checked;
            checkErrorReports.Checked = checkSelectAll.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Cleaning(true);
            Task t = new Task(() => CleanPC());
            t.Start();
        }

        private void Cleaning(bool enabled)
        {
            cleanDriveB.Enabled = !enabled;
            cleanDriveB.Text = (enabled) ? "..." : Options.TranslationList["cleanDriveB"];
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].Remove();
                GetStartupItems();
            }
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
                string recommendedDomain = string.Empty;

                if (!domain.StartsWith("www."))
                {
                    recommendedDomain = "www." + domain;
                }
                else
                {
                    recommendedDomain = domain.Replace("www.", string.Empty);
                }

                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(domain));

                if (!string.IsNullOrEmpty(recommendedDomain))
                {
                    HostsHelper.AddEntry(HostsHelper.SanitizeEntry(ip) + " " + HostsHelper.SanitizeEntry(recommendedDomain));
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

        private void button59_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\PowerMenu.reg");
            GetDesktopItems();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\SystemTools.reg");
            GetDesktopItems();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\WindowsApps.reg");
            GetDesktopItems();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\SystemShortcuts.reg");
            GetDesktopItems();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Utilities.ImportRegistryScript(Required.ReadyMadeMenusFolder + "\\DesktopShortcuts.reg");
            GetDesktopItems();
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

        private void radioOcean_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Ocean;
            Options.ApplyTheme(this);
        }

        private void radioMagma_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Magma;
            Options.ApplyTheme(this);
        }

        private void radioZerg_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Zerg;
            Options.ApplyTheme(this);
        }

        private void radioMinimal_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Minimal;
            Options.ApplyTheme(this);
        }

        private void radioCaramel_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Caramel;
            Options.ApplyTheme(this);
        }

        private void radioLime_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Lime;
            Options.ApplyTheme(this);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (listStartupItems.SelectedItems.Count == 1)
            {
                _startUpItems[listStartupItems.SelectedIndices[0]].LocateKey();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Integrator.TakeOwnership(false);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Integrator.TakeOwnership(true);
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
            for (int i = 0; i < listModernApps.Items.Count; i++)
            {
                listModernApps.SetItemChecked(i, chkSelectAllModernApps.Checked);
            }
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(_resetMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilities.ResetConfiguration();
            }
        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            if (!performanceSw.Checked)
            {
                Optimize.EnablePerformanceTweaks();
            }
            else
            {
                Optimize.DisablePerformanceTweaks();
            }
            Options.CurrentOptions.EnablePerformanceTweaks = !performanceSw.Checked;
        }

        private void toggleSwitch2_Click(object sender, EventArgs e)
        {
            if (!networkSw.Checked)
            {
                Optimize.DisableNetworkThrottling();
            }
            else
            {
                Optimize.EnableNetworkThrottling();
            }
            Options.CurrentOptions.DisableNetworkThrottling = !networkSw.Checked;
        }

        private void toggleSwitch3_Click(object sender, EventArgs e)
        {
            if (!defenderSw.Checked)
            {
                Optimize.DisableDefender();
            }
            else
            {
                Optimize.EnableDefender();
            }
            Options.CurrentOptions.DisableWindowsDefender = !defenderSw.Checked;
        }

        private void toggleSwitch4_Click(object sender, EventArgs e)
        {
            if (!systemRestoreSw.Checked)
            {
                Optimize.DisableSystemRestore();
            }
            else
            {
                Optimize.EnableSystemRestore();
            }
            Options.CurrentOptions.DisableSystemRestore = !systemRestoreSw.Checked;
        }

        private void toggleSwitch5_Click(object sender, EventArgs e)
        {
            if (!printSw.Checked)
            {
                Optimize.DisablePrintService();
            }
            else
            {
                Optimize.EnablePrintService();
            }
            Options.CurrentOptions.DisablePrintService = !printSw.Checked;
        }

        private void toggleSwitch6_Click(object sender, EventArgs e)
        {
            if (!mediaSharingSw.Checked)
            {
                Optimize.DisableMediaPlayerSharing();
            }
            else
            {
                Optimize.EnableMediaPlayerSharing();
            }
            Options.CurrentOptions.DisableMediaPlayerSharing = !mediaSharingSw.Checked;
        }

        private void toggleSwitch8_Click(object sender, EventArgs e)
        {
            if (!reportingSw.Checked)
            {
                Optimize.DisableErrorReporting();
            }
            else
            {
                Optimize.EnableErrorReporting();
            }
            Options.CurrentOptions.DisableErrorReporting = !reportingSw.Checked;
        }

        private void toggleSwitch9_Click(object sender, EventArgs e)
        {
            if (!homegroupSw.Checked)
            {
                Optimize.DisableHomeGroup();
            }
            else
            {
                Optimize.EnableHomeGroup();
            }
            Options.CurrentOptions.DisableHomeGroup = !homegroupSw.Checked;
        }

        private void toggleSwitch10_Click(object sender, EventArgs e)
        {
            if (!superfetchSw.Checked)
            {
                Optimize.DisableSuperfetch();
            }
            else
            {
                Optimize.EnableSuperfetch();
            }
            Options.CurrentOptions.DisableSuperfetch = !superfetchSw.Checked;
        }

        private void toggleSwitch11_Click(object sender, EventArgs e)
        {
            if (!telemetryTasksSw.Checked)
            {
                Optimize.DisableTelemetryTasks();
            }
            else
            {
                Optimize.EnableTelemetryTasks();
            }
            Options.CurrentOptions.DisableTelemetryTasks = !telemetryTasksSw.Checked;
        }

        private void toggleSwitch12_Click(object sender, EventArgs e)
        {
            if (!officeTelemetrySw.Checked)
            {
                Optimize.DisableOffice2016Telemetry();
            }
            else
            {
                Optimize.EnableOffice2016Telemetry();
            }
            Options.CurrentOptions.DisableOffice2016Telemetry = !officeTelemetrySw.Checked;
        }

        private void toggleSwitch13_Click(object sender, EventArgs e)
        {
            if (!oldMixerSw.Checked)
            {
                Optimize.EnableLegacyVolumeSlider();
            }
            else
            {
                Optimize.DisableLegacyVolumeSlider();
            }
            Options.CurrentOptions.EnableLegacyVolumeSlider = !oldMixerSw.Checked;
        }

        private void toggleSwitch19_Click(object sender, EventArgs e)
        {
            if (!colorBarSw.Checked)
            {
                Optimize.EnableTaskbarColor();
            }
            else
            {
                Optimize.DisableTaskbarColor();
            }
            Options.CurrentOptions.EnableTaskbarColor = !colorBarSw.Checked;
        }

        private void toggleSwitch18_Click(object sender, EventArgs e)
        {
            if (!oldExplorerSw.Checked)
            {
                Optimize.DisableQuickAccessHistory();
            }
            else
            {
                Optimize.EnableQuickAccessHistory();
            }
            Options.CurrentOptions.DisableQuickAccessHistory = !oldExplorerSw.Checked;
        }

        private void toggleSwitch26_Click(object sender, EventArgs e)
        {
            if (!adsSw.Checked)
            {
                Optimize.DisableStartMenuAds();
            }
            else
            {
                Optimize.EnableStartMenuAds();
            }
            Options.CurrentOptions.DisableStartMenuAds = !adsSw.Checked;
        }

        private void toggleSwitch27_Click(object sender, EventArgs e)
        {
            if (!darkSw.Checked)
            {
                Optimize.EnableDarkTheme();
            }
            else
            {
                Optimize.EnableLightTheme();
            }
            Options.CurrentOptions.EnableDarkTheme = !darkSw.Checked;
        }

        private void toggleSwitch14_Click(object sender, EventArgs e)
        {
            if (!uODSw.Checked)
            {
                Task t = new Task(() => Optimize.UninstallOneDrive());
                t.Start();
            }
            else
            {
                Task t = new Task(() => Optimize.InstallOneDrive());
                t.Start();
            }
            Options.CurrentOptions.UninstallOneDrive = !uODSw.Checked;
        }

        private void toggleSwitch25_Click(object sender, EventArgs e)
        {
            if (!peopleSw.Checked)
            {
                Optimize.DisableMyPeople();
            }
            else
            {
                Optimize.EnableMyPeople();
            }
            Options.CurrentOptions.DisableMyPeople = !peopleSw.Checked;
        }

        private void toggleSwitch24_Click(object sender, EventArgs e)
        {
            if (!autoUpdatesSw.Checked)
            {
                Optimize.DisableAutomaticUpdates();
            }
            else
            {
                Optimize.EnableAutomaticUpdates();
            }
            Options.CurrentOptions.DisableAutomaticUpdates = !autoUpdatesSw.Checked;
        }

        private void toggleSwitch30_Click(object sender, EventArgs e)
        {
            if (!driversSw.Checked)
            {
                Optimize.ExcludeDrivers();
            }
            else
            {
                Optimize.IncludeDrivers();
            }
            Options.CurrentOptions.ExcludeDrivers = !driversSw.Checked;
        }

        private void toggleSwitch23_Click(object sender, EventArgs e)
        {
            if (!telemetryServicesSw.Checked)
            {
                Optimize.DisableTelemetryServices();
            }
            else
            {
                Optimize.EnableTelemetryServices();
            }
            Options.CurrentOptions.DisableTelemetryServices = !telemetryServicesSw.Checked;
        }

        private void toggleSwitch21_Click(object sender, EventArgs e)
        {
            if (!privacySw.Checked)
            {
                Optimize.DisablePrivacyOptions();
            }
            else
            {
                Optimize.EnablePrivacyOptions();
            }
            Options.CurrentOptions.DisablePrivacyOptions = !privacySw.Checked;
        }

        private void toggleSwitch16_Click(object sender, EventArgs e)
        {
            if (!cortanaSw.Checked)
            {
                Optimize.DisableCortana();
            }
            else
            {
                Optimize.EnableCortana();
            }
            Options.CurrentOptions.DisableCortana = !cortanaSw.Checked;
        }

        private void toggleSwitch20_Click(object sender, EventArgs e)
        {
            if (!sensorSw.Checked)
            {
                Optimize.DisableSensorServices();
            }
            else
            {
                Optimize.EnableSensorServices();
            }
            Options.CurrentOptions.DisableSensorServices = !sensorSw.Checked;
        }

        private void toggleSwitch29_Click(object sender, EventArgs e)
        {
            if (!inkSw.Checked)
            {
                Optimize.DisableWindowsInk();
            }
            else
            {
                Optimize.EnableWindowsInk();
            }
            Options.CurrentOptions.DisableWindowsInk = !inkSw.Checked;
        }

        private void toggleSwitch28_Click(object sender, EventArgs e)
        {
            if (!spellSw.Checked)
            {
                Optimize.DisableSpellingAndTypingFeatures();
            }
            else
            {
                Optimize.EnableSpellingAndTypingFeatures();
            }
            Options.CurrentOptions.DisableSpellingTyping = !spellSw.Checked;
        }

        private void toggleSwitch17_Click(object sender, EventArgs e)
        {
            if (!xboxSw.Checked)
            {
                Optimize.DisableXboxLive();
            }
            else
            {
                Optimize.EnableXboxLive();
            }
            Options.CurrentOptions.DisableXboxLive = !xboxSw.Checked;
        }

        private void toggleSwitch15_Click(object sender, EventArgs e)
        {
            if (!gameBarSw.Checked)
            {
                Optimize.DisableGameBar();
            }
            else
            {
                Optimize.EnableGameBar();
            }
            Options.CurrentOptions.DisableGameBar = !gameBarSw.Checked;
        }

        private void toggleSwitch31_Click(object sender, EventArgs e)
        {
            if (!disableOneDriveSw.Checked)
            {
                Optimize.DisableOneDrive();
            }
            else
            {
                Optimize.EnableOneDrive();
            }
            Options.CurrentOptions.DisableOneDrive = !disableOneDriveSw.Checked;
        }

        private void toggleSwitch32_Click(object sender, EventArgs e)
        {
            if (!compatSw.Checked)
            {
                Optimize.DisableCompatibilityAssistant();
            }
            else
            {
                Optimize.EnableCompatibilityAssistant();
            }
            Options.CurrentOptions.DisableCompatibilityAssistant = !compatSw.Checked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdate();
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_changelogLink);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.btnChangelog_Click", ex.Message, ex.StackTrace);
                MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            adblockBasic.Enabled = !chkReadOnly.Checked;
            adblockS.Enabled = !chkReadOnly.Checked;
            adblockP.Enabled = !chkReadOnly.Checked;
            adblockUlti.Enabled = !chkReadOnly.Checked;

            txtIP.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HostsHelper.AdblockBasic();
            GetHostsEntries();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HostsHelper.AdBlockWithPorn();
            GetHostsEntries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HostsHelper.AdBlockWithSocial();
            GetHostsEntries();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HostsHelper.AdBlockWithSocial();
            GetHostsEntries();
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

            txtDownloadStatus.Text = Options.TranslationList["Finished"];
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
                if (c is ColoredCheckBox && ((ColoredCheckBox)c).Checked) maxCount++;
            }

            ColoredCheckBox currentCheck;
            Control[] temp;

            foreach (FeedApp x in AppsFromFeed)
            {
                if (string.IsNullOrEmpty(x.Tag)) continue;
                temp = appsTab.Controls.Find(x.Tag, true);
                if (temp.Count() == 0) continue;
                currentCheck = (ColoredCheckBox)temp[0];
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
                        if (a.Contains("Sumatra")) p.StartInfo.Arguments = " -install";
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
                if (c is ColoredCheckBox && ((ColoredCheckBox)c).Checked) ((ColoredCheckBox)c).Checked = false;
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
            //Process.Start("https://github.com/hellzerg/optimizer");
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

            if (Utilities.PingHost(txtPingInput.Text) == null)
            {
                listPingResults.Items.Add(string.Format("{0} [{1}]", Options.TranslationList["hostNotFound"], txtPingInput.Text));
                return;
            }

            Task pinger = new Task(() =>
            {
                btnShodan.Enabled = false;
                btnPing.Enabled = false;

                listPingResults.Items.Add(string.Format("{0} [{1}]", Options.TranslationList["pinging"], txtPingInput.Text));
                listPingResults.Items.Add("");

                for (int i = 0; i < 9; i++)
                {
                    // wait before each pinging
                    System.Threading.Thread.Sleep(700);

                    tmpReply = Utilities.PingHost(txtPingInput.Text);

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

        private void btnCheckFootprint_Click(object sender, EventArgs e)
        {
            CleanHelper.CheckFootprint();
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(_shodanIP);
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void quickAccessToggle_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.EnableTray = quickAccessToggle.Checked;
            Options.SaveSettings();

            _trayMenu = quickAccessToggle.Checked;
            launcherIcon.Visible = quickAccessToggle.Checked;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_licenseLink);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_openSourceLink);
        }

        private void linkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckForUpdate();
        }

        private void restartExpolorerItem_Click(object sender, EventArgs e)
        {
            Utilities.RestartExplorer();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Utilities.FlushDNSCache();
        }

        private void helpTipsToggle_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.ShowHelp = helpTipsToggle.Checked;
            Options.SaveSettings();

            helpBox.Active = helpTipsToggle.Checked;
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

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            radioEnglish.Checked = true;
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            radioRussian.Checked = true;
        }

        private void radioEnglish_Click(object sender, EventArgs e)
        {
            radioEnglish.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.EN;
            Options.SaveSettings();
            Options.LoadTranslation();
            Translate();
        }

        private void radioRussian_Click(object sender, EventArgs e)
        {
            radioRussian.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.RU;
            Options.SaveSettings();
            Options.LoadTranslation();
            Translate();
        }

        private void helpBox_Popup(object sender, PopupEventArgs e)
        {
            helpBox.ToolTipTitle = "What's this?";
        }
    }
}
