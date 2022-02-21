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
    public partial class MainForm : Form
    {
        Dictionary<string, string> translationList;

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

        NetworkMonitor _networkMonitor;
        double uploadSpeed = 0;
        double downloadSpeed = 0;
        bool _networkMonitoringSupported = true;

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        public List<FeedApp> AppsFromFeed = new List<FeedApp>();
        readonly string _feedLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/feed.json";
        readonly string _feedImages = "https://raw.githubusercontent.com/hellzerg/optimizer/master/images/feed.zip";

        readonly string _licenseLink = "https://www.gnu.org/licenses/gpl-3.0.en.html";
        readonly string _discordLink = "https://discord.gg/rZh8BhmmQv";

        readonly string _latestVersionLink = "https://raw.githubusercontent.com/hellzerg/optimizer/master/version.txt";
        readonly string _changelogLink = "https://github.com/hellzerg/optimizer/blob/master/CHANGELOG.md";

        string _noNewVersionMessage = "You already have the latest version!";
        string _betaVersionMessage = "You are using an experimental version!";

        readonly string _blockedIP = "0.0.0.0";

        string _restartMessage = "Restart to apply changes?";
        string _removeStartupItemsMessage = "Are you sure you want to delete these startup items?\n\n";
        string _removeHostsEntriesMessage = "Are you sure you want to delete all hosts entries?";
        string _removeDesktopItemsMessage = "Are you sure you want to delete all desktop items?";
        string _removeModernAppsMessage = "Are you sure you want to uninstall the following app(s)?";
        string _errorModernAppsMessage = "The following app(s) couldn't be uninstalled:\n";
        string _resetMessage = "Are you sure you want to reset configuration?\n\nThis will reset all your preferences, including any icons you extracted or downloaded using Integrator, but will not touch anything on your computer!";

        string _byteSizeNullString = " b";
        string _primaryItemTag = "_primary";

        ColorOverrider _colorOverrider;

        List<TreeNode> _hwDetailed;
        TreeNode[] _hwSummarized;

        Size _sizeDefault = new Size(1025, 744);
        Size _sizeRussian = new Size(1298, 744);
        Size _sizeHellenic = new Size(1076, 744);
        Size _sizeTurkish = new Size(1081, 744);
        Size _sizeFrench = new Size(1037, 744);

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
                        picUpdate.Visible = true;
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
            actionSw.ToggleClicked += new EventHandler(ToggleSwitch7_Click);
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
            featuresSw.ToggleClicked += new EventHandler(ToggleSwitch35_Click);
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
            classicRibbonSw.ToggleClicked += new EventHandler(ClassicRibbonSw_Click);
            classicContextSw.ToggleClicked += new EventHandler(ClassicContextSw_Click);
            ffTelemetrySw.ToggleClicked += new EventHandler(FfTelemetrySw_ToggleClicked);
            chromeTelemetrySw.ToggleClicked += new EventHandler(ChromeTelemetrySw_ToggleClicked);
            vsSw.ToggleClicked += new EventHandler(VsSw_ToggleClicked);
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

        private void SetHelpBoxTranslation()
        {
            helpBox.SetToolTip(performanceSw.Label, Options.TranslationList["performanceTip"].ToString());
            helpBox.SetToolTip(networkSw.Label, Options.TranslationList["networkTip"].ToString());
            helpBox.SetToolTip(defenderSw.Label, Options.TranslationList["defenderTip"].ToString());
            helpBox.SetToolTip(smartScreenSw.Label, Options.TranslationList["smartScreenTip"].ToString());
            helpBox.SetToolTip(systemRestoreSw.Label, Options.TranslationList["systemRestoreTip"].ToString());
            helpBox.SetToolTip(reportingSw.Label, Options.TranslationList["reportingTip"].ToString());
            helpBox.SetToolTip(telemetryTasksSw.Label, Options.TranslationList["telemetryTasksTip"].ToString());
            helpBox.SetToolTip(officeTelemetrySw.Label, Options.TranslationList["officeTelemetryTip"].ToString());
            helpBox.SetToolTip(printSw.Label, Options.TranslationList["printTip"].ToString());
            helpBox.SetToolTip(faxSw.Label, Options.TranslationList["faxTip"].ToString());
            helpBox.SetToolTip(mediaSharingSw.Label, Options.TranslationList["mediaSharingTip"].ToString());
            helpBox.SetToolTip(stickySw.Label, Options.TranslationList["stickyTip"].ToString());
            helpBox.SetToolTip(homegroupSw.Label, Options.TranslationList["homegroupTip"].ToString());
            helpBox.SetToolTip(superfetchSw.Label, Options.TranslationList["superfetchTip"].ToString());
            helpBox.SetToolTip(compatSw.Label, Options.TranslationList["compatTip"].ToString());
            helpBox.SetToolTip(disableOneDriveSw.Label, Options.TranslationList["disableOneDriveTip"].ToString());
            helpBox.SetToolTip(oldMixerSw.Label, Options.TranslationList["oldMixerTip"].ToString());
            helpBox.SetToolTip(oldExplorerSw.Label, Options.TranslationList["oldExplorerTip"].ToString());
            helpBox.SetToolTip(adsSw.Label, Options.TranslationList["adsTip"].ToString());
            helpBox.SetToolTip(uODSw.Label, Options.TranslationList["uODTip"].ToString());
            helpBox.SetToolTip(peopleSw.Label, Options.TranslationList["peopleTip"].ToString());
            helpBox.SetToolTip(longPathsSw.Label, Options.TranslationList["longPathsTip"].ToString());
            helpBox.SetToolTip(inkSw.Label, Options.TranslationList["inkTip"].ToString());
            helpBox.SetToolTip(spellSw.Label, Options.TranslationList["spellTip"].ToString());
            helpBox.SetToolTip(xboxSw.Label, Options.TranslationList["xboxTip"].ToString());
            helpBox.SetToolTip(actionSw.Label, Options.TranslationList["actionTip"].ToString());
            helpBox.SetToolTip(autoUpdatesSw.Label, Options.TranslationList["autoUpdatesTip"].ToString());
            helpBox.SetToolTip(driversSw.Label, Options.TranslationList["driversTip"].ToString());
            helpBox.SetToolTip(telemetryServicesSw.Label, Options.TranslationList["telemetryServicesTip"].ToString());
            helpBox.SetToolTip(privacySw.Label, Options.TranslationList["privacyTip"].ToString());
            helpBox.SetToolTip(ccSw.Label, Options.TranslationList["ccTip"].ToString());
            helpBox.SetToolTip(cortanaSw.Label, Options.TranslationList["cortanaTip"].ToString());
            helpBox.SetToolTip(sensorSw.Label, Options.TranslationList["sensorTip"].ToString());
            helpBox.SetToolTip(castSw.Label, Options.TranslationList["castTip"].ToString());
            helpBox.SetToolTip(gameBarSw.Label, Options.TranslationList["gameBarTip"].ToString());
            helpBox.SetToolTip(insiderSw.Label, Options.TranslationList["insiderTip"].ToString());
            helpBox.SetToolTip(featuresSw.Label, Options.TranslationList["featuresTip"].ToString());
            helpBox.SetToolTip(tpmSw.Label, Options.TranslationList["tpmTip"].ToString());
            helpBox.SetToolTip(leftTaskbarSw.Label, Options.TranslationList["leftTaskbarTip"].ToString());
            helpBox.SetToolTip(snapAssistSw.Label, Options.TranslationList["snapAssistTip"].ToString());
            helpBox.SetToolTip(widgetsSw.Label, Options.TranslationList["widgetsTip"].ToString());
            helpBox.SetToolTip(chatSw.Label, Options.TranslationList["chatTip"].ToString());
            helpBox.SetToolTip(smallerTaskbarSw.Label, Options.TranslationList["smallerTaskbarTip"].ToString());
            helpBox.SetToolTip(classicRibbonSw.Label, Options.TranslationList["classicRibbonTip"].ToString());
            helpBox.SetToolTip(classicContextSw.Label, Options.TranslationList["classicContextTip"].ToString());
            helpBox.SetToolTip(picUpdate, Options.TranslationList["linkUpdate"].ToString() + "!");
            helpBox.SetToolTip(ffTelemetrySw.Label, Options.TranslationList["ffTelemetryTip"].ToString());
            helpBox.SetToolTip(vsSw.Label, Options.TranslationList["vsTip"].ToString());
            helpBox.SetToolTip(chromeTelemetrySw.Label, Options.TranslationList["chromeTelemetryTip"].ToString());

            //helpBox.ToolTipTitle = Options.TranslationList["tipWhatsThis"].ToString();
        }

        private void ToggleSwitch7_Click(object sender, EventArgs e)
        {
            if (actionSw.ToggleChecked)
            {
                Optimize.DisableActionCenter();
            }
            else
            {
                Optimize.EnableActionCenter();
            }
            Options.CurrentOptions.DisableActionCenter = actionSw.ToggleChecked;
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
            if (featuresSw.ToggleChecked)
            {
                Optimize.DisableForcedFeatureUpdates();
            }
            else
            {
                Optimize.EnableForcedFeatureUpdates();
            }
            Options.CurrentOptions.DisableFeatureUpdates = featuresSw.ToggleChecked;
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

        private void LoadSettings()
        {
            switch (Options.CurrentOptions.Color)
            {
                case Theme.Amber:
                    rAmber.Checked = true;
                    break;
                case Theme.Jade:
                    rJade.Checked = true;
                    break;
                case Theme.Ruby:
                    rRuby.Checked = true;
                    break;
                case Theme.Silver:
                    rSilver.Checked = true;
                    break;
                case Theme.Azurite:
                    rAzurite.Checked = true;
                    break;
                case Theme.Amethyst:
                    rAmethyst.Checked = true;
                    break;
            }
        }

        //INIT
        public MainForm(SplashForm _splashForm, bool disableIndicium = false, bool disableHostsEditor = false, bool disableCommonApps = false, bool disableUWPApps = false, bool disableStartups = false, bool disableCleaner = false, bool disableIntegrator = false)
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            CheckForIllegalCrossThreadCalls = false;

            EnableToggleEvents();

            _splashForm.LoadingStatus.Text = "checking for requirements ...";

            // theming
            Options.ApplyTheme(this);
            launcherMenu.Renderer = new MoonMenuRenderer();
            indiciumMenu.Renderer = new MoonMenuRenderer();

            progressDownloader.BackColor = Options.ForegroundColor;
            progressDownloader.ForeColor = Options.ForegroundAccentColor;

            // quick access
            _trayMenu = Options.CurrentOptions.EnableTray;
            quickAccessToggle.ToggleChecked = Options.CurrentOptions.EnableTray;
            launcherIcon.Visible = Options.CurrentOptions.EnableTray;
            seperatorNetMon.Visible = Options.CurrentOptions.EnableTray;
            trayDownSpeed.Visible = Options.CurrentOptions.EnableTray;
            trayUpSpeed.Visible = Options.CurrentOptions.EnableTray;

            // help tips
            helpBox.Active = Options.CurrentOptions.ShowHelp;
            helpTipsToggle.ToggleChecked = Options.CurrentOptions.ShowHelp;

            // fix SSL/TLS error when contacting internet
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // initial states
            chkOnlyRemovable.Checked = true;
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
                    GetModernApps(false);
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
                this.Controls.Remove(panelWin11Tweaks);

                if (!disableUWPApps)
                {
                    GetModernApps(false);
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
                panelWin11Tweaks.Visible = true;
                actionSw.Visible = false;
                oldMixerSw.Visible = false;

                if (!disableUWPApps)
                {
                    GetModernApps(false);
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            _splashForm.LoadingStatus.Text = "loading startup && hosts items ...";

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
                GetDesktopItems();
                GetCustomCommands();
            }
            else
            {
                tabCollection.TabPages.Remove(integratorTab);
            }

            _splashForm.LoadingStatus.Text = "getting feed ...";

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

            _splashForm.LoadingStatus.Text = "loading hardware specifications ...";

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

            LoadSettings();

            // Translation-related
            if (Options.CurrentOptions.LanguageCode == LanguageCode.EN)
            {
                radioEnglish.Checked = true;
                Translate(true);
            }
            else
            {
                Translate();
            }

            // set default window size to fit content
            if (Options.CurrentOptions.LanguageCode == LanguageCode.RU)
            {
                radioRussian.Checked = true;
                this.MinimumSize = _sizeRussian;
                this.Size = _sizeRussian;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.TR)
            {
                radioTurkish.Checked = true;
                this.MinimumSize = _sizeTurkish;
                this.Size = _sizeTurkish;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.EL)
            {
                radioHellenic.Checked = true;
                this.MinimumSize = _sizeHellenic;
                this.Size = _sizeHellenic;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.DE)
            {
                radioGerman.Checked = true;
                this.MinimumSize = _sizeDefault;
                this.Size = _sizeDefault;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.PT)
            {
                radioPortuguese.Checked = true;
                this.MinimumSize = _sizeDefault;
                this.Size = _sizeDefault;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.FR)
            {
                radioFrench.Checked = true;
                this.MinimumSize = _sizeFrench;
                this.Size = _sizeFrench;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.ES)
            {
                radioSpanish.Checked = true;
                this.MinimumSize = _sizeDefault;
                this.Size = _sizeDefault;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.IT)
            {
                radioItalian.Checked = true;
                this.MinimumSize = _sizeDefault;
                this.Size = _sizeDefault;
            }
            if (Options.CurrentOptions.LanguageCode == LanguageCode.CN)
            {
                radioChinese.Checked = true;
                this.MinimumSize = _sizeDefault;
                this.Size = _sizeDefault;
            }

            Program._MainForm = this;

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

            // network monitoring
            InitNetworkMonitoring();
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

        private void InitNetworkMonitoring()
        {
            try
            {
                _networkMonitor = new NetworkMonitor();

                if (Options.CurrentOptions.EnableTray)
                {
                    _networkMonitor.StartMonitoring();
                    _networkMonitoringSupported = true;
                    NetworkLiveMonitoring();
                }
            }
            catch (Exception ex)
            {
                _networkMonitoringSupported = false;
                DisposeNetworkMonitoring();
                ErrorLogger.LogError("MainForm.NETWORK-MONITORING", ex.Message, ex.StackTrace);
            }
            finally
            {
                seperatorNetMon.Visible = _networkMonitoringSupported;
                trayDownSpeed.Visible = _networkMonitoringSupported;
                trayUpSpeed.Visible = _networkMonitoringSupported;
            }
        }

        private void DisposeNetworkMonitoring()
        {
            if (_networkMonitor != null) _networkMonitor.StopMonitoring();
        }

        private void NetworkLiveMonitoring()
        {
            if (!_networkMonitoringSupported) return;

            Task.Factory.StartNew(() =>
            {
                while (Options.CurrentOptions.EnableTray)
                {
                    // in BYTES
                    downloadSpeed = 0;
                    uploadSpeed = 0;

                    foreach (NetworkAdapter adapter in _networkMonitor.Adapters)
                    {
                        //adapter.Refresh();
                        downloadSpeed += Math.Round(adapter.DownloadSpeedKbps, 2);
                        uploadSpeed += Math.Round(adapter.UploadSpeedKbps, 2);
                    }

                    this.Invoke(new Action(() =>
                    {
                        trayDownSpeed.Text = $"{downloadSpeed} KB/s";
                        trayUpSpeed.Text = $"{uploadSpeed} KB/s";
                    }));

                    Thread.Sleep(1000);
                }
            });
        }

        private void TranslateIndicium()
        {
            if (hwDetailed.ToggleChecked)
            {
                // DETAILS TRANSLATION
                TreeNode cpu = specsTree.Nodes["cpu"];
                TreeNode ram = specsTree.Nodes["ram"];
                TreeNode gpu = specsTree.Nodes["gpu"];
                TreeNode mobo = specsTree.Nodes["mobo"];
                TreeNode disk = specsTree.Nodes["disk"];
                TreeNode inet = specsTree.Nodes["inet"];
                TreeNode audio = specsTree.Nodes["audio"];
                TreeNode dev = specsTree.Nodes["dev"];

                if (cpu != null) cpu.Text = translationList["cpu"];
                if (ram != null)
                {
                    ram.Text = translationList["ram"];
                    TreeNode vm = ram.Nodes["vm"];
                    if (vm != null) vm.Text = translationList["vm"];
                }
                if (gpu != null) gpu.Text = translationList["gpu"];
                if (mobo != null) mobo.Text = translationList["mobo"];
                if (disk != null)
                {
                    disk.Text = translationList["disk"];
                    TreeNode disks = disk.Nodes["drives"];
                    TreeNode vols = disk.Nodes["volumes"];
                    TreeNode opticals = disk.Nodes["opticals"];
                    TreeNode removables = disk.Nodes["removables"];
                    if (disks != null) disks.Text = translationList["drives"];
                    if (vols != null) vols.Text = translationList["volumes"];
                    if (opticals != null) opticals.Text = translationList["opticals"];
                    if (removables != null) removables.Text = translationList["removables"];
                }
                if (inet != null)
                {
                    inet.Text = translationList["inet"];
                    TreeNode pas = inet.Nodes["physicalAdapters"];
                    TreeNode vas = inet.Nodes["virtualAdapters"];
                    if (pas != null) pas.Text = translationList["physicalAdapters"];
                    if (vas != null) vas.Text = translationList["virtualAdapters"];
                }
                if (audio != null) audio.Text = translationList["audio"];
                if (dev != null)
                {
                    dev.Text = translationList["dev"];
                    TreeNode kbs = dev.Nodes["keyboards"];
                    TreeNode pds = dev.Nodes["pointings"];
                    if (kbs != null) kbs.Text = translationList["keyboards"];
                    if (pds != null) pds.Text = translationList["pointings"];
                }
            }
            else
            {
                // SUMMARY TRANSLATION
                TreeNode os = specsTree.Nodes["os"];
                TreeNode scpu = specsTree.Nodes["scpu"];
                TreeNode sram = specsTree.Nodes["sram"];
                TreeNode sgpu = specsTree.Nodes["sgpu"];
                TreeNode smobo = specsTree.Nodes["smobo"];
                TreeNode sdisk = specsTree.Nodes["sdisk"];
                TreeNode sinet = specsTree.Nodes["sinet"];

                if (os != null) os.Text = translationList["os"];
                if (scpu != null) scpu.Text = translationList["cpu"];
                if (sram != null) sram.Text = translationList["ram"];
                if (sgpu != null) sgpu.Text = translationList["gpu"];
                if (smobo != null) smobo.Text = translationList["mobo"];
                if (sdisk != null) sdisk.Text = translationList["disk"];
                if (sinet != null) sinet.Text = translationList["inet"];
            }
        }

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

            SetHelpBoxTranslation();
            TranslateIndicium();

            if (!skipFull)
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

                listStartupItems.Columns[0].Text = translationList["startupItemName"];
                listStartupItems.Columns[1].Text = translationList["startupItemLocation"];
                listStartupItems.Columns[2].Text = translationList["startupItemType"];

                trayStartup.Text = translationList["trayStartup"];
                trayCleaner.Text = translationList["trayCleaner"];
                trayPinger.Text = translationList["trayPinger"];
                trayHosts.Text = translationList["trayHosts"];
                trayAD.Text = translationList["trayAD"];
                trayOptions.Text = translationList["trayOptions"];
                trayRegistry.Text = translationList["trayRegistry"];
                trayRestartExplorer.Text = translationList["trayRestartExplorer"];
                trayExit.Text = translationList["trayExit"];
                trayHW.Text = translationList["trayHW"];

                toolHWCopy.Text = translationList["toolHWCopy"];
                toolHWDuck.Text = translationList["toolHWDuck"];
                toolHWGoogle.Text = translationList["toolHWGoogle"];

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
            ByteSize footprint = CleanHelper.CheckFootprint();
            lblFootprint.Text = footprint.ToString();
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
                                    appCard.Location = new Point(0, groupSystemTools.Controls.Count * 30);
                                    groupSystemTools.Controls.Add(appCard);
                                    break;
                                case "Internet":
                                    appCard.Location = new Point(0, groupInternet.Controls.Count * 30);
                                    groupInternet.Controls.Add(appCard);
                                    break;
                                case "Coding":
                                    appCard.Location = new Point(0, groupCoding.Controls.Count * 30);
                                    groupCoding.Controls.Add(appCard);
                                    break;
                                case "GraphicsSound":
                                    appCard.Location = new Point(0, groupSoundVideo.Controls.Count * 30);
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

        private void CleanPC()
        {
            try
            {
                if (checkTemp.Checked) CleanHelper.PreviewTemp();
                if (checkMiniDumps.Checked) CleanHelper.PreviewMinidumps();
                if (checkErrorReports.Checked) CleanHelper.PreviewErrorReports();
                if (checkBin.Checked) CleanHelper.EmptyRecycleBin();
                CleanHelper.PreviewChromeClean(chromeCache.Checked, chromeCookies.Checked, chromeHistory.Checked, chromeSession.Checked, chromePws.Checked);
                CleanHelper.PreviewFireFoxClean(firefoxCache.Checked, firefoxCookies.Checked, firefoxHistory.Checked);
                CleanHelper.PreviewEdgeClean(edgeCache.Checked, edgeCookies.Checked, edgeHistory.Checked, edgeSession.Checked);
                if (IECache.Checked) CleanHelper.PreviewInternetExplorerCache();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.CleanPC", ex.Message, ex.StackTrace);
            }
            finally
            {
                if (CleanHelper.PreviewCleanList.Count > 0) new CleanPreviewForm(CleanHelper.PreviewCleanList).ShowDialog();
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
            ffTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableFirefoxTemeletry;
            vsSw.ToggleChecked = Options.CurrentOptions.DisableVisualStudioTelemetry;
            chromeTelemetrySw.ToggleChecked = Options.CurrentOptions.DisableChromeTelemetry;
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
            featuresSw.ToggleChecked = Options.CurrentOptions.DisableFeatureUpdates;
            ccSw.ToggleChecked = Options.CurrentOptions.DisableCloudClipboard;
            longPathsSw.ToggleChecked = Options.CurrentOptions.EnableLongPaths;
            castSw.ToggleChecked = Options.CurrentOptions.RemoveCastToDevice;
            actionSw.ToggleChecked = Options.CurrentOptions.DisableActionCenter;
        }

        private void LoadWindowsXIToggleStates()
        {
            leftTaskbarSw.ToggleChecked = Options.CurrentOptions.TaskbarToLeft;
            snapAssistSw.ToggleChecked = Options.CurrentOptions.DisableSnapAssist;
            widgetsSw.ToggleChecked = Options.CurrentOptions.DisableWidgets;
            chatSw.ToggleChecked = Options.CurrentOptions.DisableChat;
            smallerTaskbarSw.ToggleChecked = Options.CurrentOptions.TaskbarSmaller;
            classicRibbonSw.ToggleChecked = Options.CurrentOptions.ClassicRibbon;
            classicContextSw.ToggleChecked = Options.CurrentOptions.ClassicMenu;
            tpmSw.ToggleChecked = Options.CurrentOptions.DisableTPMCheck;
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
            adblockBasic.Enabled = !chkReadOnly.Checked;
            adblockS.Enabled = !chkReadOnly.Checked;
            adblockP.Enabled = !chkReadOnly.Checked;
            adblockUlti.Enabled = !chkReadOnly.Checked;

            ((Control)this.hostsEditorTab).Enabled = true;

            if (_hostsEntries.Count > 0) listHostEntries.SelectedIndex = 0;
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

            if (_modernApps.Count > 0) listModernApps.SelectedIndex = 0;
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

        private void checkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            checkTemp.Checked = checkSelectAll.Checked;
            checkMiniDumps.Checked = checkSelectAll.Checked;
            checkErrorReports.Checked = checkSelectAll.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            CleanHelper.PreviewCleanList.Clear();
            CleanPC();
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
            Options.CurrentOptions.Color = Theme.Azurite;
            Options.ApplyTheme(this);
        }

        private void radioMagma_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Ruby;
            Options.ApplyTheme(this);
        }

        private void radioZerg_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Amethyst;
            Options.ApplyTheme(this);
        }

        private void radioMinimal_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Silver;
            Options.ApplyTheme(this);
        }

        private void radioCaramel_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Amber;
            Options.ApplyTheme(this);
        }

        private void radioLime_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.Color = Theme.Jade;
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
            Integrator.InstallTakeOwnership(false);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Integrator.InstallTakeOwnership(true);
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
            if (performanceSw.ToggleChecked)
            {
                Optimize.EnablePerformanceTweaks();
            }
            else
            {
                Optimize.DisablePerformanceTweaks();
            }
            Options.CurrentOptions.EnablePerformanceTweaks = performanceSw.ToggleChecked;
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
                Optimize.DisableSystemRestore();
            }
            else
            {
                Optimize.EnableSystemRestore();
            }
            Options.CurrentOptions.DisableSystemRestore = systemRestoreSw.ToggleChecked;
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
                Task t = new Task(() => Optimize.UninstallOneDrive());
                t.Start();
            }
            else
            {
                Task t = new Task(() => Optimize.InstallOneDrive());
                t.Start();
            }
            Options.CurrentOptions.UninstallOneDrive = uODSw.ToggleChecked;
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
        }

        private void toggleSwitch21_Click(object sender, EventArgs e)
        {
            if (privacySw.ToggleChecked)
            {
                Optimize.EnhancePrivacy();
            }
            else
            {
                Optimize.CompromisePrivacy();
            }
            Options.CurrentOptions.DisablePrivacyOptions = privacySw.ToggleChecked;
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
                    Thread.Sleep(888);

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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_licenseLink);
        }

        private void restartExpolorerItem_Click(object sender, EventArgs e)
        {
            Utilities.RestartExplorer();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Utilities.FlushDNSCache();
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
            radioEnglish.PerformClick();
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            radioRussian.PerformClick();
        }

        private void radioEnglish_Click(object sender, EventArgs e)
        {
            radioEnglish.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.EN;
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();
            Options.SaveSettings();

            Options.LoadTranslation();
            Translate();
        }

        private void radioRussian_Click(object sender, EventArgs e)
        {
            radioRussian.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.RU;
            Options.SaveSettings();
            this.MinimumSize = _sizeRussian;
            this.Size = _sizeRussian;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            radioHellenic.PerformClick();
        }

        private void radioHellenic_Click(object sender, EventArgs e)
        {
            radioHellenic.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.EL;
            Options.SaveSettings();
            this.MinimumSize = _sizeHellenic;
            this.Size = _sizeHellenic;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            radioTurkish.PerformClick();
        }

        private void radioTurkish_Click(object sender, EventArgs e)
        {
            radioTurkish.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.TR;
            Options.SaveSettings();
            this.MinimumSize = _sizeTurkish;
            this.Size = _sizeTurkish;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void radioGerman_Click(object sender, EventArgs e)
        {
            radioGerman.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.DE;
            Options.SaveSettings();
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioGerman.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioSpanish.PerformClick();
        }

        private void radioSpanish_Click(object sender, EventArgs e)
        {
            radioSpanish.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.ES;
            Options.SaveSettings();
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void radioPortuguese_Click(object sender, EventArgs e)
        {
            radioPortuguese.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.PT;
            Options.SaveSettings();
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioPortuguese.PerformClick();
        }

        private void txtIPv4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtIPv4.Text);
        }

        private void txtIPv4A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtIPv4A.Text);
        }

        private void txtIPv6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtIPv6.Text);
        }

        private void txtIPv6A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtIPv6A.Text);
        }

        private void btnOpenNetwork_Click(object sender, EventArgs e)
        {
            Process.Start("NCPA.cpl");
        }

        private void radioFrench_Click(object sender, EventArgs e)
        {
            radioFrench.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.FR;
            Options.SaveSettings();
            this.MinimumSize = _sizeFrench;
            this.Size = _sizeFrench;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioFrench.PerformClick();
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

        private void radioItalian_Click(object sender, EventArgs e)
        {
            radioItalian.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.IT;
            Options.SaveSettings();
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioItalian.PerformClick();
        }

        private void AddCMDB_Click(object sender, EventArgs e)
        {
            Integrator.InstallOpenWithCMD();
        }

        private void DeleteCMDB_Click(object sender, EventArgs e)
        {
            Integrator.DeleteOpenWithCMD();
        }

        private void radioChinese_Click(object sender, EventArgs e)
        {
            radioChinese.Checked = true;
            Options.CurrentOptions.LanguageCode = LanguageCode.CN;
            Options.SaveSettings();
            this.MinimumSize = _sizeDefault;
            this.Size = _sizeDefault;
            this.CenterToScreen();

            Options.LoadTranslation();
            Translate();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioChinese.PerformClick();
        }

        private void quickAccessToggle_ToggleClicked(object sender, EventArgs e)
        {
            Options.CurrentOptions.EnableTray = quickAccessToggle.ToggleChecked;
            Options.SaveSettings();

            _trayMenu = quickAccessToggle.ToggleChecked;
            launcherIcon.Visible = quickAccessToggle.ToggleChecked;

            if (Options.CurrentOptions.EnableTray)
            {
                InitNetworkMonitoring();
            }
            else
            {
                DisposeNetworkMonitoring();
            }
        }

        private void helpTipsToggle_ToggleClicked(object sender, EventArgs e)
        {
            Options.CurrentOptions.ShowHelp = helpTipsToggle.ToggleChecked;
            Options.SaveSettings();

            helpBox.Active = helpTipsToggle.ToggleChecked;
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

            TranslateIndicium();
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

        private void btnCopyHW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Clipboard.SetText(GetSpecsToString(specsTree));
            }
            catch { }
        }

        private void btnSaveHW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.InitialDirectory = Application.StartupPath;
            d.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            d.FileName = $"Optimizer_Hardware_{Environment.MachineName}_{DateTime.Now.ToShortDateString()}.txt";

            if (d.ShowDialog() == DialogResult.OK) File.WriteAllText(d.FileName, GetSpecsToString(specsTree), Encoding.UTF8);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_discordLink);
        }
    }
}
