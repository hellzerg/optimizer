using System.Windows.Forms;
using Optimizer;

namespace Optimizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Processors", 0, 0);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Memory", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Graphics", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Motherboard", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Storage", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Network Adapters", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Audio", 6, 6);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Peripherals", 7, 7);
            this.optionsLayout = new Optimizer.StackPanel();
            this.quickAccessToggle = new Optimizer.ToggleCard();
            this.autoStartToggle = new Optimizer.ToggleCard();
            this.autoUpdateToggle = new Optimizer.ToggleCard();
            this.lblTheming = new System.Windows.Forms.Label();
            this.themeModeToggle = new Optimizer.ToggleCard();
            this.colorPicker1 = new Optimizer.Controls.ColorPicker();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.btnUpdate = new Optimizer.FluentButton();
            this.lblTroubleshoot = new System.Windows.Forms.Label();
            this.btnViewLog = new Optimizer.FluentButton();
            this.btnOpenConf = new Optimizer.FluentButton();
            this.btnResetConfig = new Optimizer.FluentButton();
            this.btnReinforce = new Optimizer.FluentButton();
            this.cardSoundVideo = new Optimizer.CardPanel();
            this.groupSoundVideo = new System.Windows.Forms.Panel();
            this.cardCoding = new Optimizer.CardPanel();
            this.groupCoding = new System.Windows.Forms.Panel();
            this.cardInternet = new Optimizer.CardPanel();
            this.groupInternet = new System.Windows.Forms.Panel();
            this.cardSystemTools = new Optimizer.CardPanel();
            this.groupSystemTools = new System.Windows.Forms.Panel();
            this.tableApps = new System.Windows.Forms.TableLayoutPanel();
            this.lblSystemTools = new System.Windows.Forms.Label();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblCoding = new System.Windows.Forms.Label();
            this.lblVideoSound = new System.Windows.Forms.Label();
            this.cardUwp = new Optimizer.CardPanel();
            this.panelUwp = new System.Windows.Forms.Panel();
            this.advancedTabSection1 = new Optimizer.StackPanel();
            this.hpetSw = new Optimizer.ToggleCard();
            this.loginVerboseSw = new Optimizer.ToggleCard();
            this.uODSw = new Optimizer.ToggleCard();
            this.regBackupSw = new Optimizer.ToggleCard();
            this.btnRestartSafe = new Optimizer.FluentButton();
            this.btnRestart = new Optimizer.FluentButton();
            this.advancedTabLayout = new Optimizer.ColumnsPanel();
            this.win11Section2 = new Optimizer.StackPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.snapAssistSw = new Optimizer.ToggleCard();
            this.classicContextSw = new Optimizer.ToggleCard();
            this.compactModeSw = new Optimizer.ToggleCard();
            this.copilotSw = new Optimizer.ToggleCard();
            this.win11Section1 = new Optimizer.StackPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.leftTaskbarSw = new Optimizer.ToggleCard();
            this.widgetsSw = new Optimizer.ToggleCard();
            this.chatSw = new Optimizer.ToggleCard();
            this.stickersSw = new Optimizer.ToggleCard();
            this.windows10TabSection5 = new Optimizer.StackPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.autoUpdatesSw = new Optimizer.ToggleCard();
            this.storeUpdatesSw = new Optimizer.ToggleCard();
            this.insiderSw = new Optimizer.ToggleCard();
            this.driversSw = new Optimizer.ToggleCard();
            this.windows10TabSection4 = new Optimizer.StackPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.inkSw = new Optimizer.ToggleCard();
            this.spellSw = new Optimizer.ToggleCard();
            this.ccSw = new Optimizer.ToggleCard();
            this.windows10TabSection3 = new Optimizer.StackPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.gameModeSw = new Optimizer.ToggleCard();
            this.xboxSw = new Optimizer.ToggleCard();
            this.gameBarSw = new Optimizer.ToggleCard();
            this.windows10TabSection2 = new Optimizer.StackPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.telemetryServicesSw = new Optimizer.ToggleCard();
            this.cortanaSw = new Optimizer.ToggleCard();
            this.privacySw = new Optimizer.ToggleCard();
            this.newsInterestsSw = new Optimizer.ToggleCard();
            this.adsSw = new Optimizer.ToggleCard();
            this.edgeTelemetrySw = new Optimizer.ToggleCard();
            this.edgeAiSw = new Optimizer.ToggleCard();
            this.windows10TabSection1 = new Optimizer.StackPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.oldExplorerSw = new Optimizer.ToggleCard();
            this.hideWeatherSw = new Optimizer.ToggleCard();
            this.hideSearchSw = new Optimizer.ToggleCard();
            this.peopleSw = new Optimizer.ToggleCard();
            this.longPathsSw = new Optimizer.ToggleCard();
            this.tpmSw = new Optimizer.ToggleCard();
            this.sensorSw = new Optimizer.ToggleCard();
            this.castSw = new Optimizer.ToggleCard();
            this.oldMixerSw = new Optimizer.ToggleCard();
            this.vbsSw = new Optimizer.ToggleCard();
            this.classicPhotoViewerSw = new Optimizer.ToggleCard();
            this.modernStandbySw = new Optimizer.ToggleCard();
            this.windows10TabLayout = new Optimizer.ColumnsPanel();
            this.panelWin11Tweaks = new Optimizer.StackPanel();
            this.universalTabSection4 = new Optimizer.StackPanel();
            this.drives = new System.Windows.Forms.Label();
            this.systemRestoreSw = new Optimizer.ToggleCard();
            this.superfetchSw = new Optimizer.ToggleCard();
            this.hibernateSw = new Optimizer.ToggleCard();
            this.ntfsStampSw = new Optimizer.ToggleCard();
            this.winSearchSw = new Optimizer.ToggleCard();
            this.universalTabSection3 = new Optimizer.StackPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.telemetryTasksSw = new Optimizer.ToggleCard();
            this.mediaSharingSw = new Optimizer.ToggleCard();
            this.homegroupSw = new Optimizer.ToggleCard();
            this.smb1Sw = new Optimizer.ToggleCard();
            this.smb2Sw = new Optimizer.ToggleCard();
            this.disableOneDriveSw = new Optimizer.ToggleCard();
            this.universalTabSection2 = new Optimizer.StackPanel();
            this.label4a = new System.Windows.Forms.Label();
            this.officeTelemetrySw = new Optimizer.ToggleCard();
            this.ffTelemetrySw = new Optimizer.ToggleCard();
            this.chromeTelemetrySw = new Optimizer.ToggleCard();
            this.nvidiaTelemetrySw = new Optimizer.ToggleCard();
            this.vsSw = new Optimizer.ToggleCard();
            this.universalTabSection1 = new Optimizer.StackPanel();
            this.label14s = new System.Windows.Forms.Label();
            this.performanceSw = new Optimizer.ToggleCard();
            this.allTrayIconsSw = new Optimizer.ToggleCard();
            this.noMenuDelaySw = new Optimizer.ToggleCard();
            this.networkSw = new Optimizer.ToggleCard();
            this.reportingSw = new Optimizer.ToggleCard();
            this.compatSw = new Optimizer.ToggleCard();
            this.printSw = new Optimizer.ToggleCard();
            this.faxSw = new Optimizer.ToggleCard();
            this.stickySw = new Optimizer.ToggleCard();
            this.smartScreenSw = new Optimizer.ToggleCard();
            this.enableUtcSw = new Optimizer.ToggleCard();
            this.defenderSw = new Optimizer.ToggleCard();
            this.universalTabLayout = new Optimizer.ColumnsPanel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.sidebarNav = new Optimizer.SidebarNav();
            this.tabCollection = new Optimizer.MoonTabs();
            this.universalTab = new System.Windows.Forms.TabPage();
            this.windows10Tab = new System.Windows.Forms.TabPage();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.btnRestoreUwp = new Optimizer.FluentButton();
            this.uninstallModernAppsButton = new Optimizer.FluentButton();
            this.refreshModernAppsButton = new Optimizer.FluentButton();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.chkOnlyRemovable = new Optimizer.MoonCheck();
            this.chkSelectAllModernApps = new Optimizer.MoonCheck();
            this.startupTab = new System.Windows.Forms.TabPage();
            this.startupFooter = new Optimizer.CardPanel();
            this.chkStartupSelectAll = new Optimizer.MoonCheck();
            this.lblStartupSelected = new System.Windows.Forms.Label();
            this.clearStartupSelB = new Optimizer.FluentButton();
            this.enableStartupB = new Optimizer.FluentButton();
            this.disableStartupB = new Optimizer.FluentButton();
            this.removeStartupItemB = new Optimizer.FluentButton();
            this.panelStartup = new Optimizer.StartupList();
            this.startupBackupStrip = new Optimizer.CardPanel();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.txtBackupTitle = new System.Windows.Forms.TextBox();
            this.doBackup = new Optimizer.FluentButton();
            this.cancelBackup = new Optimizer.FluentButton();
            this.backupStartupB = new Optimizer.FluentButton();
            this.restoreStartupB = new Optimizer.FluentButton();
            this.refreshStartupB = new Optimizer.FluentButton();
            this.sortDirStartupB = new Optimizer.FluentButton();
            this.cmbStartupSort = new Optimizer.MoonSelect();
            this.cmbStartupFilter = new Optimizer.MoonSelect();
            this.cmbStartupStatus = new Optimizer.MoonSelect();
            this.txtStartupSearch = new System.Windows.Forms.TextBox();
            this.startupTitle = new System.Windows.Forms.Label();
            this.appsTab = new System.Windows.Forms.TabPage();
            this.txtFeedError = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.appsTitle = new System.Windows.Forms.Label();
            this.btnGetFeed = new Optimizer.FluentButton();
            this.panelCommonApps = new System.Windows.Forms.Panel();
            this.cAutoInstall = new Optimizer.MoonCheck();
            this.progressDownloader = new Optimizer.MoonProgress();
            this.c64 = new Optimizer.MoonRadio();
            this.c32 = new Optimizer.MoonRadio();
            this.btnDownloadApps = new Optimizer.FluentButton();
            this.setDownDirLbl = new System.Windows.Forms.Label();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.changeDownDirB = new Optimizer.FluentButton();
            this.txtDownloadStatus = new System.Windows.Forms.Label();
            this.linkWarnings = new System.Windows.Forms.LinkLabel();
            this.bitPref = new System.Windows.Forms.Label();
            this.goToDownloadsB = new Optimizer.FluentButton();
            this.cleanerTab = new System.Windows.Forms.TabPage();
            this.panel14 = new Optimizer.CardPanel();
            this.listCleanPreview = new Optimizer.MoonCheckList();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnWinClean = new Optimizer.FluentButton();
            this.analyzeDriveB = new Optimizer.FluentButton();
            this.checkSelectAll = new System.Windows.Forms.LinkLabel();
            this.lblPretext = new System.Windows.Forms.Label();
            this.cleanDriveB = new Optimizer.FluentButton();
            this.lblFootprint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bravePasswords = new Optimizer.MoonCheck();
            this.braveSession = new Optimizer.MoonCheck();
            this.braveHistory = new Optimizer.MoonCheck();
            this.braveCookies = new Optimizer.MoonCheck();
            this.braveCache = new Optimizer.MoonCheck();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edgeSession = new Optimizer.MoonCheck();
            this.edgeHistory = new Optimizer.MoonCheck();
            this.edgeCookies = new Optimizer.MoonCheck();
            this.edgeCache = new Optimizer.MoonCheck();
            this.IECache = new Optimizer.MoonCheck();
            this.firefoxHistory = new Optimizer.MoonCheck();
            this.firefoxCookies = new Optimizer.MoonCheck();
            this.firefoxCache = new Optimizer.MoonCheck();
            this.chromePws = new Optimizer.MoonCheck();
            this.chromeSession = new Optimizer.MoonCheck();
            this.chromeHistory = new Optimizer.MoonCheck();
            this.chromeCookies = new Optimizer.MoonCheck();
            this.chromeCache = new Optimizer.MoonCheck();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.checkErrorReports = new Optimizer.MoonCheck();
            this.checkTemp = new Optimizer.MoonCheck();
            this.checkBin = new Optimizer.MoonCheck();
            this.checkMiniDumps = new Optimizer.MoonCheck();
            this.pingerTab = new System.Windows.Forms.TabPage();
            this.netTools = new Optimizer.MoonTabs();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetDns = new Optimizer.FluentButton();
            this.txtDns6B = new System.Windows.Forms.TextBox();
            this.txtDns6A = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDns4B = new System.Windows.Forms.TextBox();
            this.txtDns4A = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCustomDns = new Optimizer.MoonCheck();
            this.chkAllNics = new Optimizer.MoonCheck();
            this.dnsTitle = new System.Windows.Forms.Label();
            this.linkDNSv6A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv6 = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenNetwork = new Optimizer.FluentButton();
            this.flushCacheB = new Optimizer.FluentButton();
            this.boxAdapter = new Optimizer.MoonSelect();
            this.boxDNS = new Optimizer.MoonSelect();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExport = new Optimizer.FluentButton();
            this.copyB = new Optimizer.FluentButton();
            this.copyIPB = new Optimizer.FluentButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listPingResults = new Optimizer.MoonList();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnShodan = new Optimizer.FluentButton();
            this.btnPing = new Optimizer.FluentButton();
            this.txtPingInput = new System.Windows.Forms.TextBox();
            this.lblPinger = new System.Windows.Forms.Label();
            this.pingerTitle = new System.Windows.Forms.Label();
            this.hostsEditorTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkIncludeWww = new Optimizer.MoonCheck();
            this.linkAdvancedEdit = new System.Windows.Forms.LinkLabel();
            this.linkRestoreDefault = new System.Windows.Forms.LinkLabel();
            this.lblLock = new System.Windows.Forms.Label();
            this.chkReadOnly = new Optimizer.MoonCheck();
            this.panelList = new System.Windows.Forms.Panel();
            this.listHostEntries = new Optimizer.MoonList();
            this.chkBlock = new Optimizer.MoonCheck();
            this.refreshHostsB = new Optimizer.FluentButton();
            this.removeHostB = new Optimizer.FluentButton();
            this.removeAllHostsB = new Optimizer.FluentButton();
            this.addHostB = new Optimizer.FluentButton();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.hostsTitle = new System.Windows.Forms.Label();
            this.linkLocate = new System.Windows.Forms.LinkLabel();
            this.registryFixerTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regFixB = new Optimizer.FluentButton();
            this.regLbl = new System.Windows.Forms.Label();
            this.checkRestartExplorer = new Optimizer.MoonCheck();
            this.checkRegistryEditor = new Optimizer.MoonCheck();
            this.checkEnableAll = new Optimizer.MoonCheck();
            this.checkContextMenu = new Optimizer.MoonCheck();
            this.checkTaskManager = new Optimizer.MoonCheck();
            this.checkCommandPrompt = new Optimizer.MoonCheck();
            this.checkFirewall = new Optimizer.MoonCheck();
            this.checkRunDialog = new Optimizer.MoonCheck();
            this.checkFolderOptions = new Optimizer.MoonCheck();
            this.checkControlPanel = new Optimizer.MoonCheck();
            this.registryTitle = new System.Windows.Forms.Label();
            this.indiciumTab = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.specsTree = new Optimizer.MoonTree();
            this.indiciumMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolHWCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHWGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHWDuck = new System.Windows.Forms.ToolStripMenuItem();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCopyHW = new Optimizer.FluentButton();
            this.btnSaveHW = new Optimizer.FluentButton();
            this.hwDetailed = new Optimizer.ToggleCard();
            this.integratorTab = new System.Windows.Forms.TabPage();
            this.synapse = new Optimizer.MoonTabs();
            this.integratorInfoTab = new System.Windows.Forms.TabPage();
            this.integrator7 = new System.Windows.Forms.Label();
            this.integrator6 = new System.Windows.Forms.Label();
            this.integrator5 = new System.Windows.Forms.Label();
            this.integrator4 = new System.Windows.Forms.Label();
            this.integrator3 = new System.Windows.Forms.Label();
            this.integrator2 = new System.Windows.Forms.Label();
            this.integrator1 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnAddItem = new Optimizer.FluentButton();
            this.itemnamegroup = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.security = new System.Windows.Forms.GroupBox();
            this.checkShift = new Optimizer.MoonCheck();
            this.itemposition = new System.Windows.Forms.GroupBox();
            this.radioTop = new Optimizer.MoonRadio();
            this.radioMiddle = new Optimizer.MoonRadio();
            this.radioBottom = new Optimizer.MoonRadio();
            this.icontoaddgroup = new System.Windows.Forms.GroupBox();
            this.checkDefaultIcon = new Optimizer.MoonCheck();
            this.btnBrowseIcon = new Optimizer.FluentButton();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseItem = new Optimizer.FluentButton();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.itemtype = new System.Windows.Forms.GroupBox();
            this.radioCommand = new Optimizer.MoonRadio();
            this.radioProgram = new Optimizer.MoonRadio();
            this.radioFolder = new Optimizer.MoonRadio();
            this.radioLink = new Optimizer.MoonRadio();
            this.radioFile = new Optimizer.MoonRadio();
            this.addItemL = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listDesktopItems = new Optimizer.MoonList();
            this.refreshIIB = new Optimizer.FluentButton();
            this.removeDIB = new Optimizer.FluentButton();
            this.removeAllIIB = new Optimizer.FluentButton();
            this.removeIntegratorItemsL = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.WAB = new Optimizer.ToggleCard();
            this.AddCMDB = new Optimizer.ToggleCard();
            this.AddOwnerB = new Optimizer.ToggleCard();
            this.DSB = new Optimizer.ToggleCard();
            this.SSB = new Optimizer.ToggleCard();
            this.STB = new Optimizer.ToggleCard();
            this.PMB = new Optimizer.ToggleCard();
            this.readyMenusL = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listCustomCommands = new Optimizer.MoonList();
            this.removeCCB = new Optimizer.FluentButton();
            this.refreshCCB = new Optimizer.FluentButton();
            this.removeCCL = new System.Windows.Forms.Label();
            this.btnCreateCustomCommand = new Optimizer.FluentButton();
            this.button48 = new Optimizer.FluentButton();
            this.txtRunKeyword = new System.Windows.Forms.TextBox();
            this.ccKeywordL = new System.Windows.Forms.Label();
            this.txtRunFile = new System.Windows.Forms.TextBox();
            this.ccFileL = new System.Windows.Forms.Label();
            this.ccL = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.listSystemVariables = new Optimizer.MoonList();
            this.button1 = new Optimizer.FluentButton();
            this.button2 = new Optimizer.FluentButton();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new Optimizer.FluentButton();
            this.txtSysVar = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFontsNumber = new System.Windows.Forms.Label();
            this.lblFontsCount = new System.Windows.Forms.Label();
            this.txtSearchFonts = new System.Windows.Forms.TextBox();
            this.btnRestoreFont = new Optimizer.FluentButton();
            this.btnSetGlobalFont = new Optimizer.FluentButton();
            this.lblCurrentFont = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRefreshFonts = new Optimizer.FluentButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listFonts = new Optimizer.MoonList();
            this.fontSetTitle = new System.Windows.Forms.Label();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.boxLang = new Optimizer.MoonSelect();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.languagesL = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.tpanel = new System.Windows.Forms.Panel();
            this.restartAndApply = new System.Windows.Forms.Label();
            this.picRestartNeeded = new System.Windows.Forms.PictureBox();
            this.picLab = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.txtNetFw = new System.Windows.Forms.Label();
            this.txtBitness = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpanel = new System.Windows.Forms.Panel();
            this.imagesHw = new System.Windows.Forms.ImageList(this.components);
            this.defineCommandDialog = new System.Windows.Forms.OpenFileDialog();
            this.defineProgramDialog = new System.Windows.Forms.OpenFileDialog();
            this.defineFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.defineFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineProgramIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineFolderIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineURLIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineFileIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.DefineCommandIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.launcherMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.trayCleaner = new System.Windows.Forms.ToolStripMenuItem();
            this.trayPinger = new System.Windows.Forms.ToolStripMenuItem();
            this.trayHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.trayAD = new System.Windows.Forms.ToolStripMenuItem();
            this.trayHW = new System.Windows.Forms.ToolStripMenuItem();
            this.trayRegistry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.trayRestartExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.trayUnlocker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.optionsLayout.SuspendLayout();
            this.cardSoundVideo.SuspendLayout();
            this.cardCoding.SuspendLayout();
            this.cardInternet.SuspendLayout();
            this.cardSystemTools.SuspendLayout();
            this.tableApps.SuspendLayout();
            this.cardUwp.SuspendLayout();
            this.advancedTabSection1.SuspendLayout();
            this.advancedTabLayout.SuspendLayout();
            this.win11Section2.SuspendLayout();
            this.win11Section1.SuspendLayout();
            this.windows10TabSection5.SuspendLayout();
            this.windows10TabSection4.SuspendLayout();
            this.windows10TabSection3.SuspendLayout();
            this.windows10TabSection2.SuspendLayout();
            this.windows10TabSection1.SuspendLayout();
            this.windows10TabLayout.SuspendLayout();
            this.panelWin11Tweaks.SuspendLayout();
            this.universalTabSection4.SuspendLayout();
            this.universalTabSection3.SuspendLayout();
            this.universalTabSection2.SuspendLayout();
            this.universalTabSection1.SuspendLayout();
            this.universalTabLayout.SuspendLayout();
            this.tabCollection.SuspendLayout();
            this.universalTab.SuspendLayout();
            this.windows10Tab.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.modernAppsTab.SuspendLayout();
            this.startupTab.SuspendLayout();
            this.startupFooter.SuspendLayout();
            this.startupBackupStrip.SuspendLayout();
            this.appsTab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCommonApps.SuspendLayout();
            this.cleanerTab.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pingerTab.SuspendLayout();
            this.netTools.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.hostsEditorTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelList.SuspendLayout();
            this.registryFixerTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.indiciumTab.SuspendLayout();
            this.panel12.SuspendLayout();
            this.indiciumMenu.SuspendLayout();
            this.panel11.SuspendLayout();
            this.integratorTab.SuspendLayout();
            this.synapse.SuspendLayout();
            this.integratorInfoTab.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.itemnamegroup.SuspendLayout();
            this.security.SuspendLayout();
            this.itemposition.SuspendLayout();
            this.icontoaddgroup.SuspendLayout();
            this.itemtoaddgroup.SuspendLayout();
            this.itemtype.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.optionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bpanel.SuspendLayout();
            this.launcherMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsLayout
            // 
            this.optionsLayout.Controls.Add(this.quickAccessToggle);
            this.optionsLayout.Controls.Add(this.autoStartToggle);
            this.optionsLayout.Controls.Add(this.autoUpdateToggle);
            this.optionsLayout.Controls.Add(this.lblTheming);
            this.optionsLayout.Controls.Add(this.themeModeToggle);
            this.optionsLayout.Controls.Add(this.colorPicker1);
            this.optionsLayout.Controls.Add(this.lblUpdating);
            this.optionsLayout.Controls.Add(this.btnUpdate);
            this.optionsLayout.Controls.Add(this.lblTroubleshoot);
            this.optionsLayout.Controls.Add(this.btnViewLog);
            this.optionsLayout.Controls.Add(this.btnOpenConf);
            this.optionsLayout.Controls.Add(this.btnResetConfig);
            this.optionsLayout.Controls.Add(this.btnReinforce);
            this.optionsLayout.Location = new System.Drawing.Point(16, 10);
            this.optionsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.optionsLayout.Name = "optionsLayout";
            this.optionsLayout.Size = new System.Drawing.Size(512, 611);
            this.optionsLayout.TabIndex = 0;
            // 
            // quickAccessToggle
            // 
            this.quickAccessToggle.AccessibleName = "Show Quick Access Menu";
            this.quickAccessToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.quickAccessToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quickAccessToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.quickAccessToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessToggle.LabelText = "Show Quick Access Menu";
            this.quickAccessToggle.Location = new System.Drawing.Point(0, 0);
            this.quickAccessToggle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.quickAccessToggle.Name = "quickAccessToggle";
            this.quickAccessToggle.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.quickAccessToggle.Size = new System.Drawing.Size(512, 42);
            this.quickAccessToggle.TabIndex = 88;
            this.quickAccessToggle.Tag = "themeable";
            this.quickAccessToggle.ToggleChecked = false;
            this.quickAccessToggle.ToggleClicked += new System.EventHandler(this.quickAccessToggle_ToggleClicked);
            // 
            // autoStartToggle
            // 
            this.autoStartToggle.AccessibleName = "Start with Windows";
            this.autoStartToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoStartToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoStartToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.autoStartToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoStartToggle.LabelText = "Start with Windows";
            this.autoStartToggle.Location = new System.Drawing.Point(0, 46);
            this.autoStartToggle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.autoStartToggle.Name = "autoStartToggle";
            this.autoStartToggle.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.autoStartToggle.Size = new System.Drawing.Size(512, 42);
            this.autoStartToggle.TabIndex = 98;
            this.autoStartToggle.Tag = "themeable";
            this.autoStartToggle.ToggleChecked = false;
            this.autoStartToggle.ToggleClicked += new System.EventHandler(this.autoStartToggle_ToggleClicked);
            // 
            // autoUpdateToggle
            // 
            this.autoUpdateToggle.AccessibleName = "Update on launch";
            this.autoUpdateToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoUpdateToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoUpdateToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.autoUpdateToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdateToggle.LabelText = "Update on launch";
            this.autoUpdateToggle.Location = new System.Drawing.Point(0, 92);
            this.autoUpdateToggle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.autoUpdateToggle.Name = "autoUpdateToggle";
            this.autoUpdateToggle.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.autoUpdateToggle.Size = new System.Drawing.Size(512, 42);
            this.autoUpdateToggle.TabIndex = 105;
            this.autoUpdateToggle.Tag = "themeable";
            this.autoUpdateToggle.ToggleChecked = false;
            this.autoUpdateToggle.ToggleClicked += new System.EventHandler(this.autoUpdateToggle_ToggleClicked);
            // 
            // lblTheming
            // 
            this.lblTheming.AutoSize = true;
            this.lblTheming.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheming.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTheming.Location = new System.Drawing.Point(2, 152);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(2, 14, 0, 8);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(153, 21);
            this.lblTheming.TabIndex = 55;
            this.lblTheming.Tag = "themeable";
            this.lblTheming.Text = "Choose your theme";
            // 
            // themeModeToggle
            // 
            this.themeModeToggle.AccessibleName = "Dark mode";
            this.themeModeToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.themeModeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeModeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.themeModeToggle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeModeToggle.LabelText = "Dark mode";
            this.themeModeToggle.Location = new System.Drawing.Point(0, 181);
            this.themeModeToggle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.themeModeToggle.Name = "themeModeToggle";
            this.themeModeToggle.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.themeModeToggle.Size = new System.Drawing.Size(512, 42);
            this.themeModeToggle.TabIndex = 89;
            this.themeModeToggle.ToggleChecked = false;
            this.themeModeToggle.ToggleClicked += new System.EventHandler(this.themeModeToggle_ToggleClicked);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorPicker1.Location = new System.Drawing.Point(3, 232);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(139, 98);
            this.colorPicker1.TabIndex = 97;
            this.colorPicker1.Text = "colorPicker1";
            this.colorPicker1.ColorChanged += new System.EventHandler(this.colorPicker1_ColorChanged);
            // 
            // lblUpdating
            // 
            this.lblUpdating.AutoSize = true;
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUpdating.Location = new System.Drawing.Point(2, 344);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(2, 14, 0, 8);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(125, 21);
            this.lblUpdating.TabIndex = 61;
            this.lblUpdating.Tag = "themeable";
            this.lblUpdating.Text = "Check && update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnUpdate.Kind = Optimizer.ButtonKind.Primary;
            this.btnUpdate.Location = new System.Drawing.Point(0, 373);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(288, 34);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Check for update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTroubleshoot
            // 
            this.lblTroubleshoot.AutoSize = true;
            this.lblTroubleshoot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleshoot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTroubleshoot.Location = new System.Drawing.Point(2, 426);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(2, 14, 0, 8);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(131, 21);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "themeable";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // btnViewLog
            // 
            this.btnViewLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnViewLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.Location = new System.Drawing.Point(0, 455);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(288, 34);
            this.btnViewLog.TabIndex = 60;
            this.btnViewLog.Text = "View errors";
            this.btnViewLog.UseVisualStyleBackColor = false;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnOpenConf
            // 
            this.btnOpenConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOpenConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenConf.Location = new System.Drawing.Point(0, 494);
            this.btnOpenConf.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnOpenConf.Name = "btnOpenConf";
            this.btnOpenConf.Size = new System.Drawing.Size(288, 34);
            this.btnOpenConf.TabIndex = 63;
            this.btnOpenConf.Text = "Show configuration folder";
            this.btnOpenConf.UseVisualStyleBackColor = false;
            this.btnOpenConf.Click += new System.EventHandler(this.btnOpenConf_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnResetConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetConfig.Location = new System.Drawing.Point(0, 533);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(288, 34);
            this.btnResetConfig.TabIndex = 56;
            this.btnResetConfig.Text = "Repair";
            this.btnResetConfig.UseVisualStyleBackColor = false;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // btnReinforce
            // 
            this.btnReinforce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReinforce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinforce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinforce.Location = new System.Drawing.Point(0, 572);
            this.btnReinforce.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnReinforce.Name = "btnReinforce";
            this.btnReinforce.Size = new System.Drawing.Size(288, 34);
            this.btnReinforce.TabIndex = 103;
            this.btnReinforce.Text = "Reinforce policies";
            this.btnReinforce.UseVisualStyleBackColor = false;
            this.btnReinforce.Click += new System.EventHandler(this.btnReinforce_Click);
            // 
            // cardSoundVideo
            // 
            this.cardSoundVideo.Controls.Add(this.groupSoundVideo);
            this.cardSoundVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSoundVideo.Location = new System.Drawing.Point(772, 34);
            this.cardSoundVideo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardSoundVideo.Name = "cardSoundVideo";
            this.cardSoundVideo.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardSoundVideo.Size = new System.Drawing.Size(244, 410);
            this.cardSoundVideo.TabIndex = 3;
            // 
            // groupSoundVideo
            // 
            this.groupSoundVideo.AutoScroll = true;
            this.groupSoundVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSoundVideo.Location = new System.Drawing.Point(5, 5);
            this.groupSoundVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSoundVideo.Name = "groupSoundVideo";
            this.groupSoundVideo.Size = new System.Drawing.Size(234, 400);
            this.groupSoundVideo.TabIndex = 166;
            // 
            // cardCoding
            // 
            this.cardCoding.Controls.Add(this.groupCoding);
            this.cardCoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCoding.Location = new System.Drawing.Point(519, 34);
            this.cardCoding.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardCoding.Name = "cardCoding";
            this.cardCoding.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardCoding.Size = new System.Drawing.Size(243, 410);
            this.cardCoding.TabIndex = 2;
            // 
            // groupCoding
            // 
            this.groupCoding.AutoScroll = true;
            this.groupCoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCoding.Location = new System.Drawing.Point(5, 5);
            this.groupCoding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCoding.Name = "groupCoding";
            this.groupCoding.Size = new System.Drawing.Size(233, 400);
            this.groupCoding.TabIndex = 165;
            // 
            // cardInternet
            // 
            this.cardInternet.Controls.Add(this.groupInternet);
            this.cardInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInternet.Location = new System.Drawing.Point(266, 34);
            this.cardInternet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardInternet.Name = "cardInternet";
            this.cardInternet.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardInternet.Size = new System.Drawing.Size(243, 410);
            this.cardInternet.TabIndex = 1;
            // 
            // groupInternet
            // 
            this.groupInternet.AutoScroll = true;
            this.groupInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInternet.Location = new System.Drawing.Point(5, 5);
            this.groupInternet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupInternet.Name = "groupInternet";
            this.groupInternet.Size = new System.Drawing.Size(233, 400);
            this.groupInternet.TabIndex = 164;
            // 
            // cardSystemTools
            // 
            this.cardSystemTools.Controls.Add(this.groupSystemTools);
            this.cardSystemTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSystemTools.Location = new System.Drawing.Point(13, 34);
            this.cardSystemTools.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cardSystemTools.Name = "cardSystemTools";
            this.cardSystemTools.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardSystemTools.Size = new System.Drawing.Size(243, 410);
            this.cardSystemTools.TabIndex = 0;
            // 
            // groupSystemTools
            // 
            this.groupSystemTools.AutoScroll = true;
            this.groupSystemTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSystemTools.Location = new System.Drawing.Point(5, 5);
            this.groupSystemTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSystemTools.Name = "groupSystemTools";
            this.groupSystemTools.Size = new System.Drawing.Size(233, 400);
            this.groupSystemTools.TabIndex = 162;
            // 
            // tableApps
            // 
            this.tableApps.ColumnCount = 4;
            this.tableApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableApps.Controls.Add(this.lblSystemTools, 0, 0);
            this.tableApps.Controls.Add(this.cardSystemTools, 0, 1);
            this.tableApps.Controls.Add(this.lblInternet, 1, 0);
            this.tableApps.Controls.Add(this.cardInternet, 1, 1);
            this.tableApps.Controls.Add(this.lblCoding, 2, 0);
            this.tableApps.Controls.Add(this.cardCoding, 2, 1);
            this.tableApps.Controls.Add(this.lblVideoSound, 3, 0);
            this.tableApps.Controls.Add(this.cardSoundVideo, 3, 1);
            this.tableApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableApps.Location = new System.Drawing.Point(3, 47);
            this.tableApps.Margin = new System.Windows.Forms.Padding(0);
            this.tableApps.Name = "tableApps";
            this.tableApps.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.tableApps.RowCount = 2;
            this.tableApps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableApps.Size = new System.Drawing.Size(1268, 505);
            this.tableApps.TabIndex = 164;
            // 
            // lblSystemTools
            // 
            this.lblSystemTools.AutoSize = true;
            this.lblSystemTools.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTools.ForeColor = System.Drawing.Color.Silver;
            this.lblSystemTools.Location = new System.Drawing.Point(14, 8);
            this.lblSystemTools.Margin = new System.Windows.Forms.Padding(6, 3, 5, 6);
            this.lblSystemTools.Name = "lblSystemTools";
            this.lblSystemTools.Size = new System.Drawing.Size(111, 20);
            this.lblSystemTools.TabIndex = 162;
            this.lblSystemTools.Tag = "";
            this.lblSystemTools.Text = "System && Tools";
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.ForeColor = System.Drawing.Color.Silver;
            this.lblInternet.Location = new System.Drawing.Point(267, 8);
            this.lblInternet.Margin = new System.Windows.Forms.Padding(6, 3, 5, 6);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(63, 20);
            this.lblInternet.TabIndex = 167;
            this.lblInternet.Tag = "";
            this.lblInternet.Text = "Internet";
            // 
            // lblCoding
            // 
            this.lblCoding.AutoSize = true;
            this.lblCoding.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoding.ForeColor = System.Drawing.Color.Silver;
            this.lblCoding.Location = new System.Drawing.Point(520, 8);
            this.lblCoding.Margin = new System.Windows.Forms.Padding(6, 3, 5, 6);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Size = new System.Drawing.Size(58, 20);
            this.lblCoding.TabIndex = 168;
            this.lblCoding.Tag = "";
            this.lblCoding.Text = "Coding";
            // 
            // lblVideoSound
            // 
            this.lblVideoSound.AutoSize = true;
            this.lblVideoSound.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoSound.ForeColor = System.Drawing.Color.Silver;
            this.lblVideoSound.Location = new System.Drawing.Point(773, 8);
            this.lblVideoSound.Margin = new System.Windows.Forms.Padding(6, 3, 5, 6);
            this.lblVideoSound.Name = "lblVideoSound";
            this.lblVideoSound.Size = new System.Drawing.Size(112, 20);
            this.lblVideoSound.TabIndex = 169;
            this.lblVideoSound.Tag = "";
            this.lblVideoSound.Text = "Video && Sound";
            // 
            // cardUwp
            // 
            this.cardUwp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardUwp.Controls.Add(this.panelUwp);
            this.cardUwp.Location = new System.Drawing.Point(13, 45);
            this.cardUwp.Margin = new System.Windows.Forms.Padding(0);
            this.cardUwp.Name = "cardUwp";
            this.cardUwp.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cardUwp.Size = new System.Drawing.Size(1018, 618);
            this.cardUwp.TabIndex = 0;
            // 
            // panelUwp
            // 
            this.panelUwp.AutoScroll = true;
            this.panelUwp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUwp.Location = new System.Drawing.Point(5, 5);
            this.panelUwp.Name = "panelUwp";
            this.panelUwp.Size = new System.Drawing.Size(1008, 608);
            this.panelUwp.TabIndex = 54;
            // 
            // advancedTabSection1
            // 
            this.advancedTabSection1.Controls.Add(this.hpetSw);
            this.advancedTabSection1.Controls.Add(this.loginVerboseSw);
            this.advancedTabSection1.Controls.Add(this.uODSw);
            this.advancedTabSection1.Controls.Add(this.regBackupSw);
            this.advancedTabSection1.Controls.Add(this.btnRestartSafe);
            this.advancedTabSection1.Controls.Add(this.btnRestart);
            this.advancedTabSection1.Location = new System.Drawing.Point(22, 6);
            this.advancedTabSection1.Margin = new System.Windows.Forms.Padding(0);
            this.advancedTabSection1.Name = "advancedTabSection1";
            this.advancedTabSection1.Size = new System.Drawing.Size(483, 301);
            this.advancedTabSection1.TabIndex = 0;
            // 
            // hpetSw
            // 
            this.hpetSw.AccessibleName = "Disable HPET";
            this.hpetSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hpetSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hpetSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hpetSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpetSw.ForeColor = System.Drawing.Color.White;
            this.hpetSw.LabelText = "Disable HPET";
            this.hpetSw.Location = new System.Drawing.Point(0, 0);
            this.hpetSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.hpetSw.Name = "hpetSw";
            this.hpetSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.hpetSw.Size = new System.Drawing.Size(483, 42);
            this.hpetSw.TabIndex = 84;
            this.hpetSw.Tag = "themeable";
            this.hpetSw.ToggleChecked = false;
            // 
            // loginVerboseSw
            // 
            this.loginVerboseSw.AccessibleName = "Enable Detailed Login Screen";
            this.loginVerboseSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.loginVerboseSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginVerboseSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loginVerboseSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginVerboseSw.ForeColor = System.Drawing.Color.White;
            this.loginVerboseSw.LabelText = "Enable Detailed Login Screen";
            this.loginVerboseSw.Location = new System.Drawing.Point(0, 46);
            this.loginVerboseSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.loginVerboseSw.Name = "loginVerboseSw";
            this.loginVerboseSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.loginVerboseSw.Size = new System.Drawing.Size(483, 42);
            this.loginVerboseSw.TabIndex = 85;
            this.loginVerboseSw.Tag = "themeable";
            this.loginVerboseSw.ToggleChecked = false;
            // 
            // uODSw
            // 
            this.uODSw.AccessibleName = "Uninstall OneDrive";
            this.uODSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.uODSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uODSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uODSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.ForeColor = System.Drawing.Color.White;
            this.uODSw.LabelText = "Uninstall OneDrive";
            this.uODSw.Location = new System.Drawing.Point(0, 92);
            this.uODSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.uODSw.Name = "uODSw";
            this.uODSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.uODSw.Size = new System.Drawing.Size(483, 42);
            this.uODSw.TabIndex = 89;
            this.uODSw.Tag = "themeable";
            this.uODSw.ToggleChecked = false;
            // 
            // regBackupSw
            // 
            this.regBackupSw.AccessibleName = "Enable Registry Backups";
            this.regBackupSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.regBackupSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regBackupSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.regBackupSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBackupSw.ForeColor = System.Drawing.Color.White;
            this.regBackupSw.LabelText = "Enable Registry Backups";
            this.regBackupSw.Location = new System.Drawing.Point(0, 138);
            this.regBackupSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.regBackupSw.Name = "regBackupSw";
            this.regBackupSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.regBackupSw.Size = new System.Drawing.Size(483, 42);
            this.regBackupSw.TabIndex = 90;
            this.regBackupSw.Tag = "themeable";
            this.regBackupSw.ToggleChecked = false;
            // 
            // btnRestartSafe
            // 
            this.btnRestartSafe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRestartSafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartSafe.Location = new System.Drawing.Point(0, 184);
            this.btnRestartSafe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRestartSafe.Name = "btnRestartSafe";
            this.btnRestartSafe.Size = new System.Drawing.Size(288, 34);
            this.btnRestartSafe.TabIndex = 86;
            this.btnRestartSafe.Text = "Restart in Safe Mode";
            this.btnRestartSafe.UseVisualStyleBackColor = false;
            this.btnRestartSafe.Click += new System.EventHandler(this.btnRestartSafe_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Kind = Optimizer.ButtonKind.Primary;
            this.btnRestart.Location = new System.Drawing.Point(0, 223);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(288, 34);
            this.btnRestart.TabIndex = 87;
            this.btnRestart.Text = "Restart in Normal Mode";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // advancedTabLayout
            // 
            this.advancedTabLayout.Controls.Add(this.advancedTabSection1);
            this.advancedTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedTabLayout.Location = new System.Drawing.Point(0, 0);
            this.advancedTabLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.advancedTabLayout.Name = "advancedTabLayout";
            this.advancedTabLayout.Padding = new System.Windows.Forms.Padding(22, 6, 22, 22);
            this.advancedTabLayout.Size = new System.Drawing.Size(1035, 622);
            this.advancedTabLayout.TabIndex = 0;
            // 
            // win11Section2
            // 
            this.win11Section2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.win11Section2.Controls.Add(this.label20);
            this.win11Section2.Controls.Add(this.snapAssistSw);
            this.win11Section2.Controls.Add(this.classicContextSw);
            this.win11Section2.Controls.Add(this.compactModeSw);
            this.win11Section2.Controls.Add(this.copilotSw);
            this.win11Section2.Location = new System.Drawing.Point(0, 232);
            this.win11Section2.Margin = new System.Windows.Forms.Padding(0);
            this.win11Section2.Name = "win11Section2";
            this.win11Section2.Size = new System.Drawing.Size(475, 216);
            this.win11Section2.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(2, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 21);
            this.label20.TabIndex = 178;
            this.label20.Tag = "";
            this.label20.Text = "Extras";
            // 
            // snapAssistSw
            // 
            this.snapAssistSw.AccessibleName = "Disable Snap Assist";
            this.snapAssistSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.snapAssistSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snapAssistSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snapAssistSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapAssistSw.ForeColor = System.Drawing.Color.White;
            this.snapAssistSw.LabelText = "Disable Snap Assist";
            this.snapAssistSw.Location = new System.Drawing.Point(0, 32);
            this.snapAssistSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.snapAssistSw.Name = "snapAssistSw";
            this.snapAssistSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.snapAssistSw.Size = new System.Drawing.Size(475, 42);
            this.snapAssistSw.TabIndex = 106;
            this.snapAssistSw.Tag = "themeable";
            this.snapAssistSw.ToggleChecked = false;
            // 
            // classicContextSw
            // 
            this.classicContextSw.AccessibleName = "Enable Classic Right-Click Menu";
            this.classicContextSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.classicContextSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classicContextSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicContextSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicContextSw.ForeColor = System.Drawing.Color.White;
            this.classicContextSw.LabelText = "Enable Classic Right-Click Menu";
            this.classicContextSw.Location = new System.Drawing.Point(0, 78);
            this.classicContextSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.classicContextSw.Name = "classicContextSw";
            this.classicContextSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.classicContextSw.Size = new System.Drawing.Size(475, 42);
            this.classicContextSw.TabIndex = 110;
            this.classicContextSw.Tag = "themeable";
            this.classicContextSw.ToggleChecked = false;
            // 
            // compactModeSw
            // 
            this.compactModeSw.AccessibleName = "Enable Compact Mode in Explorer";
            this.compactModeSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.compactModeSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compactModeSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compactModeSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compactModeSw.ForeColor = System.Drawing.Color.White;
            this.compactModeSw.LabelText = "Enable Compact Mode in Explorer";
            this.compactModeSw.Location = new System.Drawing.Point(0, 124);
            this.compactModeSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.compactModeSw.Name = "compactModeSw";
            this.compactModeSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.compactModeSw.Size = new System.Drawing.Size(475, 42);
            this.compactModeSw.TabIndex = 112;
            this.compactModeSw.Tag = "themeable";
            this.compactModeSw.ToggleChecked = false;
            // 
            // copilotSw
            // 
            this.copilotSw.AccessibleName = "Disable CoPilot AI";
            this.copilotSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.copilotSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copilotSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.copilotSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copilotSw.ForeColor = System.Drawing.Color.White;
            this.copilotSw.LabelText = "Disable CoPilot AI";
            this.copilotSw.Location = new System.Drawing.Point(0, 170);
            this.copilotSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.copilotSw.Name = "copilotSw";
            this.copilotSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.copilotSw.Size = new System.Drawing.Size(475, 42);
            this.copilotSw.TabIndex = 179;
            this.copilotSw.Tag = "themeable";
            this.copilotSw.ToggleChecked = false;
            // 
            // win11Section1
            // 
            this.win11Section1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.win11Section1.Controls.Add(this.label19);
            this.win11Section1.Controls.Add(this.leftTaskbarSw);
            this.win11Section1.Controls.Add(this.widgetsSw);
            this.win11Section1.Controls.Add(this.chatSw);
            this.win11Section1.Controls.Add(this.stickersSw);
            this.win11Section1.Location = new System.Drawing.Point(0, 0);
            this.win11Section1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.win11Section1.Name = "win11Section1";
            this.win11Section1.Size = new System.Drawing.Size(475, 216);
            this.win11Section1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(2, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 21);
            this.label19.TabIndex = 177;
            this.label19.Tag = "";
            this.label19.Text = "Taskbar";
            // 
            // leftTaskbarSw
            // 
            this.leftTaskbarSw.AccessibleName = "Align Taskbar to Left";
            this.leftTaskbarSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.leftTaskbarSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTaskbarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftTaskbarSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTaskbarSw.ForeColor = System.Drawing.Color.White;
            this.leftTaskbarSw.LabelText = "Align Taskbar to Left";
            this.leftTaskbarSw.Location = new System.Drawing.Point(0, 32);
            this.leftTaskbarSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.leftTaskbarSw.Name = "leftTaskbarSw";
            this.leftTaskbarSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.leftTaskbarSw.Size = new System.Drawing.Size(475, 42);
            this.leftTaskbarSw.TabIndex = 105;
            this.leftTaskbarSw.Tag = "themeable";
            this.leftTaskbarSw.ToggleChecked = false;
            // 
            // widgetsSw
            // 
            this.widgetsSw.AccessibleName = "Disable Widgets";
            this.widgetsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.widgetsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widgetsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.widgetsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widgetsSw.ForeColor = System.Drawing.Color.White;
            this.widgetsSw.LabelText = "Disable Widgets";
            this.widgetsSw.Location = new System.Drawing.Point(0, 78);
            this.widgetsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.widgetsSw.Name = "widgetsSw";
            this.widgetsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.widgetsSw.Size = new System.Drawing.Size(475, 42);
            this.widgetsSw.TabIndex = 108;
            this.widgetsSw.Tag = "themeable";
            this.widgetsSw.ToggleChecked = false;
            // 
            // chatSw
            // 
            this.chatSw.AccessibleName = "Disable Chat";
            this.chatSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chatSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chatSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatSw.ForeColor = System.Drawing.Color.White;
            this.chatSw.LabelText = "Disable Chat";
            this.chatSw.Location = new System.Drawing.Point(0, 124);
            this.chatSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.chatSw.Name = "chatSw";
            this.chatSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.chatSw.Size = new System.Drawing.Size(475, 42);
            this.chatSw.TabIndex = 107;
            this.chatSw.Tag = "themeable";
            this.chatSw.ToggleChecked = false;
            // 
            // stickersSw
            // 
            this.stickersSw.AccessibleName = "Disable Stickers";
            this.stickersSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.stickersSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stickersSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stickersSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickersSw.ForeColor = System.Drawing.Color.White;
            this.stickersSw.LabelText = "Disable Stickers";
            this.stickersSw.Location = new System.Drawing.Point(0, 170);
            this.stickersSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.stickersSw.Name = "stickersSw";
            this.stickersSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.stickersSw.Size = new System.Drawing.Size(475, 42);
            this.stickersSw.TabIndex = 113;
            this.stickersSw.Tag = "themeable";
            this.stickersSw.ToggleChecked = false;
            // 
            // windows10TabSection5
            // 
            this.windows10TabSection5.Controls.Add(this.label15);
            this.windows10TabSection5.Controls.Add(this.autoUpdatesSw);
            this.windows10TabSection5.Controls.Add(this.storeUpdatesSw);
            this.windows10TabSection5.Controls.Add(this.insiderSw);
            this.windows10TabSection5.Controls.Add(this.driversSw);
            this.windows10TabSection5.Location = new System.Drawing.Point(22, 614);
            this.windows10TabSection5.Margin = new System.Windows.Forms.Padding(0);
            this.windows10TabSection5.Name = "windows10TabSection5";
            this.windows10TabSection5.Size = new System.Drawing.Size(475, 216);
            this.windows10TabSection5.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(2, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 21);
            this.label15.TabIndex = 173;
            this.label15.Tag = "";
            this.label15.Text = "Windows Update";
            // 
            // autoUpdatesSw
            // 
            this.autoUpdatesSw.AccessibleName = "Disable Automatic Updates";
            this.autoUpdatesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoUpdatesSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoUpdatesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoUpdatesSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdatesSw.ForeColor = System.Drawing.Color.White;
            this.autoUpdatesSw.LabelText = "Disable Automatic Updates";
            this.autoUpdatesSw.Location = new System.Drawing.Point(0, 32);
            this.autoUpdatesSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.autoUpdatesSw.Name = "autoUpdatesSw";
            this.autoUpdatesSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.autoUpdatesSw.Size = new System.Drawing.Size(475, 42);
            this.autoUpdatesSw.TabIndex = 93;
            this.autoUpdatesSw.Tag = "themeable";
            this.autoUpdatesSw.ToggleChecked = false;
            // 
            // storeUpdatesSw
            // 
            this.storeUpdatesSw.AccessibleName = "Disable Microsoft Store Updates";
            this.storeUpdatesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.storeUpdatesSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeUpdatesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.storeUpdatesSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeUpdatesSw.ForeColor = System.Drawing.Color.White;
            this.storeUpdatesSw.LabelText = "Disable Microsoft Store Updates";
            this.storeUpdatesSw.Location = new System.Drawing.Point(0, 78);
            this.storeUpdatesSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.storeUpdatesSw.Name = "storeUpdatesSw";
            this.storeUpdatesSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.storeUpdatesSw.Size = new System.Drawing.Size(475, 42);
            this.storeUpdatesSw.TabIndex = 104;
            this.storeUpdatesSw.Tag = "themeable";
            this.storeUpdatesSw.ToggleChecked = false;
            // 
            // insiderSw
            // 
            this.insiderSw.AccessibleName = "Disable Insider Service";
            this.insiderSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.insiderSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insiderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.insiderSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.ForeColor = System.Drawing.Color.White;
            this.insiderSw.LabelText = "Disable Insider Service";
            this.insiderSw.Location = new System.Drawing.Point(0, 124);
            this.insiderSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.insiderSw.Name = "insiderSw";
            this.insiderSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.insiderSw.Size = new System.Drawing.Size(475, 42);
            this.insiderSw.TabIndex = 102;
            this.insiderSw.Tag = "themeable";
            this.insiderSw.ToggleChecked = false;
            // 
            // driversSw
            // 
            this.driversSw.AccessibleName = "Exclude Drivers from Update";
            this.driversSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.driversSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driversSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.driversSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversSw.ForeColor = System.Drawing.Color.White;
            this.driversSw.LabelText = "Exclude Drivers from Update";
            this.driversSw.Location = new System.Drawing.Point(0, 170);
            this.driversSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.driversSw.Name = "driversSw";
            this.driversSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.driversSw.Size = new System.Drawing.Size(475, 42);
            this.driversSw.TabIndex = 95;
            this.driversSw.Tag = "themeable";
            this.driversSw.ToggleChecked = false;
            // 
            // windows10TabSection4
            // 
            this.windows10TabSection4.Controls.Add(this.label18);
            this.windows10TabSection4.Controls.Add(this.inkSw);
            this.windows10TabSection4.Controls.Add(this.spellSw);
            this.windows10TabSection4.Controls.Add(this.ccSw);
            this.windows10TabSection4.Location = new System.Drawing.Point(521, 578);
            this.windows10TabSection4.Margin = new System.Windows.Forms.Padding(0);
            this.windows10TabSection4.Name = "windows10TabSection4";
            this.windows10TabSection4.Size = new System.Drawing.Size(475, 170);
            this.windows10TabSection4.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(2, 3);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 21);
            this.label18.TabIndex = 176;
            this.label18.Tag = "";
            this.label18.Text = "Touch";
            // 
            // inkSw
            // 
            this.inkSw.AccessibleName = "Disable Windows Ink";
            this.inkSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.inkSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inkSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkSw.ForeColor = System.Drawing.Color.White;
            this.inkSw.LabelText = "Disable Windows Ink";
            this.inkSw.Location = new System.Drawing.Point(0, 32);
            this.inkSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.inkSw.Name = "inkSw";
            this.inkSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.inkSw.Size = new System.Drawing.Size(475, 42);
            this.inkSw.TabIndex = 89;
            this.inkSw.Tag = "themeable";
            this.inkSw.ToggleChecked = false;
            // 
            // spellSw
            // 
            this.spellSw.AccessibleName = "Disable Spell Checking";
            this.spellSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.spellSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spellSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.spellSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellSw.ForeColor = System.Drawing.Color.White;
            this.spellSw.LabelText = "Disable Spell Checking";
            this.spellSw.Location = new System.Drawing.Point(0, 78);
            this.spellSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.spellSw.Name = "spellSw";
            this.spellSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.spellSw.Size = new System.Drawing.Size(475, 42);
            this.spellSw.TabIndex = 88;
            this.spellSw.Tag = "themeable";
            this.spellSw.ToggleChecked = false;
            // 
            // ccSw
            // 
            this.ccSw.AccessibleName = "Disable Cloud Clipboard";
            this.ccSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ccSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ccSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccSw.ForeColor = System.Drawing.Color.White;
            this.ccSw.LabelText = "Disable Cloud Clipboard";
            this.ccSw.Location = new System.Drawing.Point(0, 124);
            this.ccSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.ccSw.Name = "ccSw";
            this.ccSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.ccSw.Size = new System.Drawing.Size(475, 42);
            this.ccSw.TabIndex = 98;
            this.ccSw.Tag = "themeable";
            this.ccSw.ToggleChecked = false;
            // 
            // windows10TabSection3
            // 
            this.windows10TabSection3.Controls.Add(this.label17);
            this.windows10TabSection3.Controls.Add(this.gameModeSw);
            this.windows10TabSection3.Controls.Add(this.xboxSw);
            this.windows10TabSection3.Controls.Add(this.gameBarSw);
            this.windows10TabSection3.Location = new System.Drawing.Point(521, 384);
            this.windows10TabSection3.Margin = new System.Windows.Forms.Padding(0);
            this.windows10TabSection3.Name = "windows10TabSection3";
            this.windows10TabSection3.Size = new System.Drawing.Size(475, 170);
            this.windows10TabSection3.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(2, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 21);
            this.label17.TabIndex = 175;
            this.label17.Tag = "";
            this.label17.Text = "Gaming";
            // 
            // gameModeSw
            // 
            this.gameModeSw.AccessibleName = "Enable Gaming Mode";
            this.gameModeSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.gameModeSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameModeSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameModeSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeSw.ForeColor = System.Drawing.Color.White;
            this.gameModeSw.LabelText = "Enable Gaming Mode";
            this.gameModeSw.Location = new System.Drawing.Point(0, 32);
            this.gameModeSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.gameModeSw.Name = "gameModeSw";
            this.gameModeSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.gameModeSw.Size = new System.Drawing.Size(475, 42);
            this.gameModeSw.TabIndex = 105;
            this.gameModeSw.Tag = "themeable";
            this.gameModeSw.ToggleChecked = false;
            // 
            // xboxSw
            // 
            this.xboxSw.AccessibleName = "Disable Xbox Live";
            this.xboxSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.xboxSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xboxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xboxSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxSw.ForeColor = System.Drawing.Color.White;
            this.xboxSw.LabelText = "Disable Xbox Live";
            this.xboxSw.Location = new System.Drawing.Point(0, 78);
            this.xboxSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.xboxSw.Name = "xboxSw";
            this.xboxSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.xboxSw.Size = new System.Drawing.Size(475, 42);
            this.xboxSw.TabIndex = 90;
            this.xboxSw.Tag = "themeable";
            this.xboxSw.ToggleChecked = false;
            // 
            // gameBarSw
            // 
            this.gameBarSw.AccessibleName = "Disable Game Bar";
            this.gameBarSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.gameBarSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameBarSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBarSw.ForeColor = System.Drawing.Color.White;
            this.gameBarSw.LabelText = "Disable Game Bar";
            this.gameBarSw.Location = new System.Drawing.Point(0, 124);
            this.gameBarSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.gameBarSw.Name = "gameBarSw";
            this.gameBarSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.gameBarSw.Size = new System.Drawing.Size(475, 42);
            this.gameBarSw.TabIndex = 100;
            this.gameBarSw.Tag = "themeable";
            this.gameBarSw.ToggleChecked = false;
            // 
            // windows10TabSection2
            // 
            this.windows10TabSection2.Controls.Add(this.label16);
            this.windows10TabSection2.Controls.Add(this.telemetryServicesSw);
            this.windows10TabSection2.Controls.Add(this.cortanaSw);
            this.windows10TabSection2.Controls.Add(this.privacySw);
            this.windows10TabSection2.Controls.Add(this.newsInterestsSw);
            this.windows10TabSection2.Controls.Add(this.adsSw);
            this.windows10TabSection2.Controls.Add(this.edgeTelemetrySw);
            this.windows10TabSection2.Controls.Add(this.edgeAiSw);
            this.windows10TabSection2.Location = new System.Drawing.Point(521, 6);
            this.windows10TabSection2.Margin = new System.Windows.Forms.Padding(0);
            this.windows10TabSection2.Name = "windows10TabSection2";
            this.windows10TabSection2.Size = new System.Drawing.Size(475, 354);
            this.windows10TabSection2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(2, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 21);
            this.label16.TabIndex = 174;
            this.label16.Tag = "";
            this.label16.Text = "Privacy";
            // 
            // telemetryServicesSw
            // 
            this.telemetryServicesSw.AccessibleName = "Disable Telemetry Services";
            this.telemetryServicesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.telemetryServicesSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telemetryServicesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryServicesSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryServicesSw.ForeColor = System.Drawing.Color.White;
            this.telemetryServicesSw.LabelText = "Disable Telemetry Services";
            this.telemetryServicesSw.Location = new System.Drawing.Point(0, 32);
            this.telemetryServicesSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.telemetryServicesSw.Name = "telemetryServicesSw";
            this.telemetryServicesSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.telemetryServicesSw.Size = new System.Drawing.Size(475, 42);
            this.telemetryServicesSw.TabIndex = 94;
            this.telemetryServicesSw.Tag = "themeable";
            this.telemetryServicesSw.ToggleChecked = false;
            // 
            // cortanaSw
            // 
            this.cortanaSw.AccessibleName = "Disable Cortana";
            this.cortanaSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.cortanaSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cortanaSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cortanaSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortanaSw.ForeColor = System.Drawing.Color.White;
            this.cortanaSw.LabelText = "Disable Cortana";
            this.cortanaSw.Location = new System.Drawing.Point(0, 78);
            this.cortanaSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.cortanaSw.Name = "cortanaSw";
            this.cortanaSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.cortanaSw.Size = new System.Drawing.Size(475, 42);
            this.cortanaSw.TabIndex = 97;
            this.cortanaSw.Tag = "themeable";
            this.cortanaSw.ToggleChecked = false;
            // 
            // privacySw
            // 
            this.privacySw.AccessibleName = "Enhance Privacy";
            this.privacySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.privacySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privacySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.privacySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacySw.ForeColor = System.Drawing.Color.White;
            this.privacySw.LabelText = "Enhance Privacy";
            this.privacySw.Location = new System.Drawing.Point(0, 124);
            this.privacySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.privacySw.Name = "privacySw";
            this.privacySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.privacySw.Size = new System.Drawing.Size(475, 42);
            this.privacySw.TabIndex = 96;
            this.privacySw.Tag = "themeable";
            this.privacySw.ToggleChecked = false;
            // 
            // newsInterestsSw
            // 
            this.newsInterestsSw.AccessibleName = "Disable News && Interests";
            this.newsInterestsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.newsInterestsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newsInterestsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.newsInterestsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsInterestsSw.ForeColor = System.Drawing.Color.White;
            this.newsInterestsSw.LabelText = "Disable News && Interests";
            this.newsInterestsSw.Location = new System.Drawing.Point(0, 170);
            this.newsInterestsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.newsInterestsSw.Name = "newsInterestsSw";
            this.newsInterestsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.newsInterestsSw.Size = new System.Drawing.Size(475, 42);
            this.newsInterestsSw.TabIndex = 237;
            this.newsInterestsSw.Tag = "themeable";
            this.newsInterestsSw.ToggleChecked = false;
            // 
            // adsSw
            // 
            this.adsSw.AccessibleName = "Disable Start Menu Ads";
            this.adsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.adsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsSw.ForeColor = System.Drawing.Color.White;
            this.adsSw.LabelText = "Disable Start Menu Ads";
            this.adsSw.Location = new System.Drawing.Point(0, 216);
            this.adsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.adsSw.Name = "adsSw";
            this.adsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.adsSw.Size = new System.Drawing.Size(475, 42);
            this.adsSw.TabIndex = 82;
            this.adsSw.Tag = "themeable";
            this.adsSw.ToggleChecked = false;
            // 
            // edgeTelemetrySw
            // 
            this.edgeTelemetrySw.AccessibleName = "Disable Edge Telemetry";
            this.edgeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.edgeTelemetrySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edgeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeTelemetrySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.edgeTelemetrySw.LabelText = "Disable Edge Telemetry";
            this.edgeTelemetrySw.Location = new System.Drawing.Point(0, 262);
            this.edgeTelemetrySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.edgeTelemetrySw.Name = "edgeTelemetrySw";
            this.edgeTelemetrySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.edgeTelemetrySw.Size = new System.Drawing.Size(475, 42);
            this.edgeTelemetrySw.TabIndex = 177;
            this.edgeTelemetrySw.Tag = "themeable";
            this.edgeTelemetrySw.ToggleChecked = false;
            // 
            // edgeAiSw
            // 
            this.edgeAiSw.AccessibleName = "Disable Edge Discover";
            this.edgeAiSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.edgeAiSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edgeAiSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeAiSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeAiSw.ForeColor = System.Drawing.Color.White;
            this.edgeAiSw.LabelText = "Disable Edge Discover";
            this.edgeAiSw.Location = new System.Drawing.Point(0, 308);
            this.edgeAiSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.edgeAiSw.Name = "edgeAiSw";
            this.edgeAiSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.edgeAiSw.Size = new System.Drawing.Size(475, 42);
            this.edgeAiSw.TabIndex = 179;
            this.edgeAiSw.Tag = "themeable";
            this.edgeAiSw.ToggleChecked = false;
            // 
            // windows10TabSection1
            // 
            this.windows10TabSection1.Controls.Add(this.label14);
            this.windows10TabSection1.Controls.Add(this.oldExplorerSw);
            this.windows10TabSection1.Controls.Add(this.hideWeatherSw);
            this.windows10TabSection1.Controls.Add(this.hideSearchSw);
            this.windows10TabSection1.Controls.Add(this.peopleSw);
            this.windows10TabSection1.Controls.Add(this.longPathsSw);
            this.windows10TabSection1.Controls.Add(this.tpmSw);
            this.windows10TabSection1.Controls.Add(this.sensorSw);
            this.windows10TabSection1.Controls.Add(this.castSw);
            this.windows10TabSection1.Controls.Add(this.oldMixerSw);
            this.windows10TabSection1.Controls.Add(this.vbsSw);
            this.windows10TabSection1.Controls.Add(this.classicPhotoViewerSw);
            this.windows10TabSection1.Controls.Add(this.modernStandbySw);
            this.windows10TabSection1.Location = new System.Drawing.Point(22, 6);
            this.windows10TabSection1.Margin = new System.Windows.Forms.Padding(0);
            this.windows10TabSection1.Name = "windows10TabSection1";
            this.windows10TabSection1.Size = new System.Drawing.Size(475, 584);
            this.windows10TabSection1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(2, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 170;
            this.label14.Tag = "";
            this.label14.Text = "System";
            // 
            // oldExplorerSw
            // 
            this.oldExplorerSw.AccessibleName = "Restore Classic Windows Explorer";
            this.oldExplorerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.oldExplorerSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldExplorerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldExplorerSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldExplorerSw.ForeColor = System.Drawing.Color.White;
            this.oldExplorerSw.LabelText = "Restore Classic Windows Explorer";
            this.oldExplorerSw.Location = new System.Drawing.Point(0, 32);
            this.oldExplorerSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.oldExplorerSw.Name = "oldExplorerSw";
            this.oldExplorerSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.oldExplorerSw.Size = new System.Drawing.Size(475, 42);
            this.oldExplorerSw.TabIndex = 83;
            this.oldExplorerSw.Tag = "themeable";
            this.oldExplorerSw.ToggleChecked = false;
            // 
            // hideWeatherSw
            // 
            this.hideWeatherSw.AccessibleName = "Hide Taskbar Weather";
            this.hideWeatherSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hideWeatherSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hideWeatherSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideWeatherSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideWeatherSw.ForeColor = System.Drawing.Color.White;
            this.hideWeatherSw.LabelText = "Hide Taskbar Weather";
            this.hideWeatherSw.Location = new System.Drawing.Point(0, 78);
            this.hideWeatherSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.hideWeatherSw.Name = "hideWeatherSw";
            this.hideWeatherSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.hideWeatherSw.Size = new System.Drawing.Size(475, 42);
            this.hideWeatherSw.TabIndex = 235;
            this.hideWeatherSw.Tag = "themeable";
            this.hideWeatherSw.ToggleChecked = false;
            // 
            // hideSearchSw
            // 
            this.hideSearchSw.AccessibleName = "Hide Taskbar Search";
            this.hideSearchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hideSearchSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hideSearchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideSearchSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideSearchSw.ForeColor = System.Drawing.Color.White;
            this.hideSearchSw.LabelText = "Hide Taskbar Search";
            this.hideSearchSw.Location = new System.Drawing.Point(0, 124);
            this.hideSearchSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.hideSearchSw.Name = "hideSearchSw";
            this.hideSearchSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.hideSearchSw.Size = new System.Drawing.Size(475, 42);
            this.hideSearchSw.TabIndex = 236;
            this.hideSearchSw.Tag = "themeable";
            this.hideSearchSw.ToggleChecked = false;
            // 
            // peopleSw
            // 
            this.peopleSw.AccessibleName = "Disable My People";
            this.peopleSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.peopleSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.peopleSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.ForeColor = System.Drawing.Color.White;
            this.peopleSw.LabelText = "Disable My People";
            this.peopleSw.Location = new System.Drawing.Point(0, 170);
            this.peopleSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.peopleSw.Name = "peopleSw";
            this.peopleSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.peopleSw.Size = new System.Drawing.Size(475, 42);
            this.peopleSw.TabIndex = 85;
            this.peopleSw.Tag = "themeable";
            this.peopleSw.ToggleChecked = false;
            // 
            // longPathsSw
            // 
            this.longPathsSw.AccessibleName = "Enable Long Paths";
            this.longPathsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.longPathsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longPathsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.longPathsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPathsSw.ForeColor = System.Drawing.Color.White;
            this.longPathsSw.LabelText = "Enable Long Paths";
            this.longPathsSw.Location = new System.Drawing.Point(0, 216);
            this.longPathsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.longPathsSw.Size = new System.Drawing.Size(475, 42);
            this.longPathsSw.TabIndex = 87;
            this.longPathsSw.Tag = "themeable";
            this.longPathsSw.ToggleChecked = false;
            // 
            // tpmSw
            // 
            this.tpmSw.AccessibleName = "Disable TPM 2.0 Check";
            this.tpmSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.tpmSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpmSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpmSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpmSw.ForeColor = System.Drawing.Color.White;
            this.tpmSw.LabelText = "Disable TPM 2.0 Check";
            this.tpmSw.Location = new System.Drawing.Point(0, 262);
            this.tpmSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tpmSw.Name = "tpmSw";
            this.tpmSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.tpmSw.Size = new System.Drawing.Size(475, 42);
            this.tpmSw.TabIndex = 92;
            this.tpmSw.Tag = "themeable";
            this.tpmSw.ToggleChecked = false;
            // 
            // sensorSw
            // 
            this.sensorSw.AccessibleName = "Disable Sensor Services";
            this.sensorSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.sensorSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sensorSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorSw.ForeColor = System.Drawing.Color.White;
            this.sensorSw.LabelText = "Disable Sensor Services";
            this.sensorSw.Location = new System.Drawing.Point(0, 308);
            this.sensorSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.sensorSw.Name = "sensorSw";
            this.sensorSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.sensorSw.Size = new System.Drawing.Size(475, 42);
            this.sensorSw.TabIndex = 99;
            this.sensorSw.Tag = "themeable";
            this.sensorSw.ToggleChecked = false;
            // 
            // castSw
            // 
            this.castSw.AccessibleName = "Remove Cast to Device";
            this.castSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.castSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.castSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.castSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castSw.ForeColor = System.Drawing.Color.White;
            this.castSw.LabelText = "Remove Cast to Device";
            this.castSw.Location = new System.Drawing.Point(0, 354);
            this.castSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.castSw.Name = "castSw";
            this.castSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.castSw.Size = new System.Drawing.Size(475, 42);
            this.castSw.TabIndex = 101;
            this.castSw.Tag = "themeable";
            this.castSw.ToggleChecked = false;
            // 
            // oldMixerSw
            // 
            this.oldMixerSw.AccessibleName = "Enable Classic Volume Mixer";
            this.oldMixerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.oldMixerSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldMixerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldMixerSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMixerSw.ForeColor = System.Drawing.Color.White;
            this.oldMixerSw.LabelText = "Enable Classic Volume Mixer";
            this.oldMixerSw.Location = new System.Drawing.Point(0, 400);
            this.oldMixerSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.oldMixerSw.Name = "oldMixerSw";
            this.oldMixerSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.oldMixerSw.Size = new System.Drawing.Size(475, 42);
            this.oldMixerSw.TabIndex = 103;
            this.oldMixerSw.Tag = "themeable";
            this.oldMixerSw.ToggleChecked = false;
            // 
            // vbsSw
            // 
            this.vbsSw.AccessibleName = "Disable Virtualization Based Security";
            this.vbsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vbsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vbsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vbsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbsSw.ForeColor = System.Drawing.Color.White;
            this.vbsSw.LabelText = "Disable Virtualization Based Security";
            this.vbsSw.Location = new System.Drawing.Point(0, 446);
            this.vbsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.vbsSw.Name = "vbsSw";
            this.vbsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.vbsSw.Size = new System.Drawing.Size(475, 42);
            this.vbsSw.TabIndex = 114;
            this.vbsSw.Tag = "themeable";
            this.vbsSw.ToggleChecked = false;
            this.vbsSw.Visible = false;
            // 
            // classicPhotoViewerSw
            // 
            this.classicPhotoViewerSw.AccessibleName = "Restore Classic Photo Viewer";
            this.classicPhotoViewerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.classicPhotoViewerSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classicPhotoViewerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicPhotoViewerSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicPhotoViewerSw.ForeColor = System.Drawing.Color.White;
            this.classicPhotoViewerSw.LabelText = "Restore Classic Photo Viewer";
            this.classicPhotoViewerSw.Location = new System.Drawing.Point(0, 492);
            this.classicPhotoViewerSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.classicPhotoViewerSw.Name = "classicPhotoViewerSw";
            this.classicPhotoViewerSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.classicPhotoViewerSw.Size = new System.Drawing.Size(475, 42);
            this.classicPhotoViewerSw.TabIndex = 180;
            this.classicPhotoViewerSw.Tag = "themeable";
            this.classicPhotoViewerSw.ToggleChecked = false;
            // 
            // modernStandbySw
            // 
            this.modernStandbySw.AccessibleName = "Disable Modern Standby";
            this.modernStandbySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.modernStandbySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modernStandbySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modernStandbySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernStandbySw.ForeColor = System.Drawing.Color.White;
            this.modernStandbySw.LabelText = "Disable Modern Standby";
            this.modernStandbySw.Location = new System.Drawing.Point(0, 538);
            this.modernStandbySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.modernStandbySw.Name = "modernStandbySw";
            this.modernStandbySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.modernStandbySw.Size = new System.Drawing.Size(475, 42);
            this.modernStandbySw.TabIndex = 238;
            this.modernStandbySw.Tag = "themeable";
            this.modernStandbySw.ToggleChecked = false;
            // 
            // windows10TabLayout
            // 
            this.windows10TabLayout.Controls.Add(this.windows10TabSection1);
            this.windows10TabLayout.Controls.Add(this.windows10TabSection2);
            this.windows10TabLayout.Controls.Add(this.windows10TabSection3);
            this.windows10TabLayout.Controls.Add(this.windows10TabSection4);
            this.windows10TabLayout.Controls.Add(this.windows10TabSection5);
            this.windows10TabLayout.Controls.Add(this.panelWin11Tweaks);
            this.windows10TabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windows10TabLayout.Location = new System.Drawing.Point(0, 0);
            this.windows10TabLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windows10TabLayout.Name = "windows10TabLayout";
            this.windows10TabLayout.Padding = new System.Windows.Forms.Padding(22, 6, 22, 22);
            this.windows10TabLayout.Size = new System.Drawing.Size(1035, 622);
            this.windows10TabLayout.TabIndex = 0;
            // 
            // panelWin11Tweaks
            // 
            this.panelWin11Tweaks.Controls.Add(this.win11Section1);
            this.panelWin11Tweaks.Controls.Add(this.win11Section2);
            this.panelWin11Tweaks.Location = new System.Drawing.Point(521, 772);
            this.panelWin11Tweaks.Margin = new System.Windows.Forms.Padding(0);
            this.panelWin11Tweaks.Name = "panelWin11Tweaks";
            this.panelWin11Tweaks.Size = new System.Drawing.Size(475, 448);
            this.panelWin11Tweaks.TabIndex = 80;
            this.panelWin11Tweaks.Visible = false;
            // 
            // universalTabSection4
            // 
            this.universalTabSection4.Controls.Add(this.drives);
            this.universalTabSection4.Controls.Add(this.systemRestoreSw);
            this.universalTabSection4.Controls.Add(this.superfetchSw);
            this.universalTabSection4.Controls.Add(this.hibernateSw);
            this.universalTabSection4.Controls.Add(this.ntfsStampSw);
            this.universalTabSection4.Controls.Add(this.winSearchSw);
            this.universalTabSection4.Location = new System.Drawing.Point(22, 614);
            this.universalTabSection4.Margin = new System.Windows.Forms.Padding(0);
            this.universalTabSection4.Name = "universalTabSection4";
            this.universalTabSection4.Size = new System.Drawing.Size(475, 262);
            this.universalTabSection4.TabIndex = 0;
            // 
            // drives
            // 
            this.drives.AutoSize = true;
            this.drives.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drives.ForeColor = System.Drawing.Color.Silver;
            this.drives.Location = new System.Drawing.Point(2, 3);
            this.drives.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.drives.Name = "drives";
            this.drives.Size = new System.Drawing.Size(47, 21);
            this.drives.TabIndex = 226;
            this.drives.Tag = "";
            this.drives.Text = "Disks";
            // 
            // systemRestoreSw
            // 
            this.systemRestoreSw.AccessibleName = "Disable System Restore";
            this.systemRestoreSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.systemRestoreSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemRestoreSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.systemRestoreSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.ForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.LabelText = "Disable System Restore";
            this.systemRestoreSw.Location = new System.Drawing.Point(0, 32);
            this.systemRestoreSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.systemRestoreSw.Size = new System.Drawing.Size(475, 42);
            this.systemRestoreSw.TabIndex = 215;
            this.systemRestoreSw.Tag = "themeable";
            this.systemRestoreSw.ToggleChecked = false;
            // 
            // superfetchSw
            // 
            this.superfetchSw.AccessibleName = "Disable Superfetch";
            this.superfetchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.superfetchSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superfetchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.superfetchSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.ForeColor = System.Drawing.Color.White;
            this.superfetchSw.LabelText = "Disable Superfetch";
            this.superfetchSw.Location = new System.Drawing.Point(0, 78);
            this.superfetchSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.superfetchSw.Size = new System.Drawing.Size(475, 42);
            this.superfetchSw.TabIndex = 204;
            this.superfetchSw.Tag = "themeable";
            this.superfetchSw.ToggleChecked = false;
            // 
            // hibernateSw
            // 
            this.hibernateSw.AccessibleName = "Disable Hibernation";
            this.hibernateSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hibernateSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hibernateSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hibernateSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateSw.ForeColor = System.Drawing.Color.White;
            this.hibernateSw.LabelText = "Disable Hibernation";
            this.hibernateSw.Location = new System.Drawing.Point(0, 124);
            this.hibernateSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.hibernateSw.Name = "hibernateSw";
            this.hibernateSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.hibernateSw.Size = new System.Drawing.Size(475, 42);
            this.hibernateSw.TabIndex = 220;
            this.hibernateSw.Tag = "themeable";
            this.hibernateSw.ToggleChecked = false;
            // 
            // ntfsStampSw
            // 
            this.ntfsStampSw.AccessibleName = "Disable NTFS Timestamp";
            this.ntfsStampSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ntfsStampSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntfsStampSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ntfsStampSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfsStampSw.ForeColor = System.Drawing.Color.White;
            this.ntfsStampSw.LabelText = "Disable NTFS Timestamp";
            this.ntfsStampSw.Location = new System.Drawing.Point(0, 170);
            this.ntfsStampSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.ntfsStampSw.Name = "ntfsStampSw";
            this.ntfsStampSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.ntfsStampSw.Size = new System.Drawing.Size(475, 42);
            this.ntfsStampSw.TabIndex = 223;
            this.ntfsStampSw.Tag = "themeable";
            this.ntfsStampSw.ToggleChecked = false;
            // 
            // winSearchSw
            // 
            this.winSearchSw.AccessibleName = "Disable Search";
            this.winSearchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.winSearchSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winSearchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.winSearchSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winSearchSw.ForeColor = System.Drawing.Color.White;
            this.winSearchSw.LabelText = "Disable Search";
            this.winSearchSw.Location = new System.Drawing.Point(0, 216);
            this.winSearchSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.winSearchSw.Name = "winSearchSw";
            this.winSearchSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.winSearchSw.Size = new System.Drawing.Size(475, 42);
            this.winSearchSw.TabIndex = 229;
            this.winSearchSw.Tag = "themeable";
            this.winSearchSw.ToggleChecked = false;
            // 
            // universalTabSection3
            // 
            this.universalTabSection3.Controls.Add(this.label13);
            this.universalTabSection3.Controls.Add(this.telemetryTasksSw);
            this.universalTabSection3.Controls.Add(this.mediaSharingSw);
            this.universalTabSection3.Controls.Add(this.homegroupSw);
            this.universalTabSection3.Controls.Add(this.smb1Sw);
            this.universalTabSection3.Controls.Add(this.smb2Sw);
            this.universalTabSection3.Controls.Add(this.disableOneDriveSw);
            this.universalTabSection3.Location = new System.Drawing.Point(521, 292);
            this.universalTabSection3.Margin = new System.Windows.Forms.Padding(0);
            this.universalTabSection3.Name = "universalTabSection3";
            this.universalTabSection3.Size = new System.Drawing.Size(475, 308);
            this.universalTabSection3.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(2, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 228;
            this.label13.Tag = "";
            this.label13.Text = "Privacy";
            // 
            // telemetryTasksSw
            // 
            this.telemetryTasksSw.AccessibleName = "Disable Telemetry Tasks";
            this.telemetryTasksSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.telemetryTasksSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telemetryTasksSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryTasksSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryTasksSw.ForeColor = System.Drawing.Color.White;
            this.telemetryTasksSw.LabelText = "Disable Telemetry Tasks";
            this.telemetryTasksSw.Location = new System.Drawing.Point(0, 32);
            this.telemetryTasksSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.telemetryTasksSw.Size = new System.Drawing.Size(475, 42);
            this.telemetryTasksSw.TabIndex = 211;
            this.telemetryTasksSw.Tag = "themeable";
            this.telemetryTasksSw.ToggleChecked = false;
            // 
            // mediaSharingSw
            // 
            this.mediaSharingSw.AccessibleName = "Disable Media Player Sharing";
            this.mediaSharingSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.mediaSharingSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaSharingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mediaSharingSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaSharingSw.ForeColor = System.Drawing.Color.White;
            this.mediaSharingSw.LabelText = "Disable Media Player Sharing";
            this.mediaSharingSw.Location = new System.Drawing.Point(0, 78);
            this.mediaSharingSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.mediaSharingSw.Size = new System.Drawing.Size(475, 42);
            this.mediaSharingSw.TabIndex = 206;
            this.mediaSharingSw.Tag = "themeable";
            this.mediaSharingSw.ToggleChecked = false;
            // 
            // homegroupSw
            // 
            this.homegroupSw.AccessibleName = "Disable HomeGroup";
            this.homegroupSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.homegroupSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homegroupSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.homegroupSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homegroupSw.ForeColor = System.Drawing.Color.White;
            this.homegroupSw.LabelText = "Disable HomeGroup";
            this.homegroupSw.Location = new System.Drawing.Point(0, 124);
            this.homegroupSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.homegroupSw.Size = new System.Drawing.Size(475, 42);
            this.homegroupSw.TabIndex = 209;
            this.homegroupSw.Tag = "themeable";
            this.homegroupSw.ToggleChecked = false;
            // 
            // smb1Sw
            // 
            this.smb1Sw.AccessibleName = "Disable SMBv1 Protocol";
            this.smb1Sw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smb1Sw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smb1Sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smb1Sw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smb1Sw.ForeColor = System.Drawing.Color.White;
            this.smb1Sw.LabelText = "Disable SMBv1 Protocol";
            this.smb1Sw.Location = new System.Drawing.Point(0, 170);
            this.smb1Sw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.smb1Sw.Name = "smb1Sw";
            this.smb1Sw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.smb1Sw.Size = new System.Drawing.Size(475, 42);
            this.smb1Sw.TabIndex = 221;
            this.smb1Sw.Tag = "themeable";
            this.smb1Sw.ToggleChecked = false;
            // 
            // smb2Sw
            // 
            this.smb2Sw.AccessibleName = "Disable SMBv2 Protocol";
            this.smb2Sw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smb2Sw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smb2Sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smb2Sw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smb2Sw.ForeColor = System.Drawing.Color.White;
            this.smb2Sw.LabelText = "Disable SMBv2 Protocol";
            this.smb2Sw.Location = new System.Drawing.Point(0, 216);
            this.smb2Sw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.smb2Sw.Name = "smb2Sw";
            this.smb2Sw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.smb2Sw.Size = new System.Drawing.Size(475, 42);
            this.smb2Sw.TabIndex = 222;
            this.smb2Sw.Tag = "themeable";
            this.smb2Sw.ToggleChecked = false;
            // 
            // disableOneDriveSw
            // 
            this.disableOneDriveSw.AccessibleName = "Disable OneDrive";
            this.disableOneDriveSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.disableOneDriveSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disableOneDriveSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disableOneDriveSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.ForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.LabelText = "Disable OneDrive";
            this.disableOneDriveSw.Location = new System.Drawing.Point(0, 262);
            this.disableOneDriveSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.disableOneDriveSw.Size = new System.Drawing.Size(475, 42);
            this.disableOneDriveSw.TabIndex = 232;
            this.disableOneDriveSw.Tag = "themeable";
            this.disableOneDriveSw.ToggleChecked = false;
            // 
            // universalTabSection2
            // 
            this.universalTabSection2.Controls.Add(this.label4a);
            this.universalTabSection2.Controls.Add(this.officeTelemetrySw);
            this.universalTabSection2.Controls.Add(this.ffTelemetrySw);
            this.universalTabSection2.Controls.Add(this.chromeTelemetrySw);
            this.universalTabSection2.Controls.Add(this.nvidiaTelemetrySw);
            this.universalTabSection2.Controls.Add(this.vsSw);
            this.universalTabSection2.Location = new System.Drawing.Point(521, 6);
            this.universalTabSection2.Margin = new System.Windows.Forms.Padding(0);
            this.universalTabSection2.Name = "universalTabSection2";
            this.universalTabSection2.Size = new System.Drawing.Size(475, 262);
            this.universalTabSection2.TabIndex = 0;
            // 
            // label4a
            // 
            this.label4a.AutoSize = true;
            this.label4a.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4a.ForeColor = System.Drawing.Color.Silver;
            this.label4a.Location = new System.Drawing.Point(2, 3);
            this.label4a.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label4a.Name = "label4a";
            this.label4a.Size = new System.Drawing.Size(48, 21);
            this.label4a.TabIndex = 227;
            this.label4a.Tag = "";
            this.label4a.Text = "Apps";
            // 
            // officeTelemetrySw
            // 
            this.officeTelemetrySw.AccessibleName = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.officeTelemetrySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.officeTelemetrySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.LabelText = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.Location = new System.Drawing.Point(0, 32);
            this.officeTelemetrySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.officeTelemetrySw.Size = new System.Drawing.Size(475, 42);
            this.officeTelemetrySw.TabIndex = 214;
            this.officeTelemetrySw.Tag = "themeable";
            this.officeTelemetrySw.ToggleChecked = false;
            // 
            // ffTelemetrySw
            // 
            this.ffTelemetrySw.AccessibleName = "Disable Mozilla Firefox Telemetry";
            this.ffTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ffTelemetrySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ffTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ffTelemetrySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.ffTelemetrySw.LabelText = "Disable Mozilla Firefox Telemetry";
            this.ffTelemetrySw.Location = new System.Drawing.Point(0, 78);
            this.ffTelemetrySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.ffTelemetrySw.Name = "ffTelemetrySw";
            this.ffTelemetrySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.ffTelemetrySw.Size = new System.Drawing.Size(475, 42);
            this.ffTelemetrySw.TabIndex = 218;
            this.ffTelemetrySw.Tag = "themeable";
            this.ffTelemetrySw.ToggleChecked = false;
            // 
            // chromeTelemetrySw
            // 
            this.chromeTelemetrySw.AccessibleName = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chromeTelemetrySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeTelemetrySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.chromeTelemetrySw.LabelText = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.Location = new System.Drawing.Point(0, 124);
            this.chromeTelemetrySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.chromeTelemetrySw.Name = "chromeTelemetrySw";
            this.chromeTelemetrySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.chromeTelemetrySw.Size = new System.Drawing.Size(475, 42);
            this.chromeTelemetrySw.TabIndex = 219;
            this.chromeTelemetrySw.Tag = "themeable";
            this.chromeTelemetrySw.ToggleChecked = false;
            // 
            // nvidiaTelemetrySw
            // 
            this.nvidiaTelemetrySw.AccessibleName = "Disable NVIDIA Telemetry";
            this.nvidiaTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.nvidiaTelemetrySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nvidiaTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nvidiaTelemetrySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvidiaTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.nvidiaTelemetrySw.LabelText = "Disable NVIDIA Telemetry";
            this.nvidiaTelemetrySw.Location = new System.Drawing.Point(0, 170);
            this.nvidiaTelemetrySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.nvidiaTelemetrySw.Name = "nvidiaTelemetrySw";
            this.nvidiaTelemetrySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.nvidiaTelemetrySw.Size = new System.Drawing.Size(475, 42);
            this.nvidiaTelemetrySw.TabIndex = 224;
            this.nvidiaTelemetrySw.Tag = "themeable";
            this.nvidiaTelemetrySw.ToggleChecked = false;
            // 
            // vsSw
            // 
            this.vsSw.AccessibleName = "Disable Visual Studio Telemetry";
            this.vsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsSw.ForeColor = System.Drawing.Color.White;
            this.vsSw.LabelText = "Disable Visual Studio Telemetry";
            this.vsSw.Location = new System.Drawing.Point(0, 216);
            this.vsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.vsSw.Name = "vsSw";
            this.vsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.vsSw.Size = new System.Drawing.Size(475, 42);
            this.vsSw.TabIndex = 217;
            this.vsSw.Tag = "themeable";
            this.vsSw.ToggleChecked = false;
            // 
            // universalTabSection1
            // 
            this.universalTabSection1.Controls.Add(this.label14s);
            this.universalTabSection1.Controls.Add(this.performanceSw);
            this.universalTabSection1.Controls.Add(this.allTrayIconsSw);
            this.universalTabSection1.Controls.Add(this.noMenuDelaySw);
            this.universalTabSection1.Controls.Add(this.networkSw);
            this.universalTabSection1.Controls.Add(this.reportingSw);
            this.universalTabSection1.Controls.Add(this.compatSw);
            this.universalTabSection1.Controls.Add(this.printSw);
            this.universalTabSection1.Controls.Add(this.faxSw);
            this.universalTabSection1.Controls.Add(this.stickySw);
            this.universalTabSection1.Controls.Add(this.smartScreenSw);
            this.universalTabSection1.Controls.Add(this.enableUtcSw);
            this.universalTabSection1.Controls.Add(this.defenderSw);
            this.universalTabSection1.Location = new System.Drawing.Point(22, 6);
            this.universalTabSection1.Margin = new System.Windows.Forms.Padding(0);
            this.universalTabSection1.Name = "universalTabSection1";
            this.universalTabSection1.Size = new System.Drawing.Size(475, 584);
            this.universalTabSection1.TabIndex = 0;
            // 
            // label14s
            // 
            this.label14s.AutoSize = true;
            this.label14s.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14s.ForeColor = System.Drawing.Color.Silver;
            this.label14s.Location = new System.Drawing.Point(2, 3);
            this.label14s.Margin = new System.Windows.Forms.Padding(2, 3, 0, 8);
            this.label14s.Name = "label14s";
            this.label14s.Size = new System.Drawing.Size(63, 21);
            this.label14s.TabIndex = 225;
            this.label14s.Tag = "";
            this.label14s.Text = "System";
            // 
            // performanceSw
            // 
            this.performanceSw.AccessibleName = "Enable Performance Tweaks";
            this.performanceSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.performanceSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.performanceSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.performanceSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceSw.ForeColor = System.Drawing.Color.White;
            this.performanceSw.LabelText = "Enable Performance Tweaks";
            this.performanceSw.Location = new System.Drawing.Point(0, 32);
            this.performanceSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.performanceSw.Size = new System.Drawing.Size(475, 42);
            this.performanceSw.TabIndex = 202;
            this.performanceSw.Tag = "themeable";
            this.performanceSw.ToggleChecked = false;
            // 
            // allTrayIconsSw
            // 
            this.allTrayIconsSw.AccessibleName = "Show all notification icons";
            this.allTrayIconsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.allTrayIconsSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTrayIconsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.allTrayIconsSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTrayIconsSw.ForeColor = System.Drawing.Color.White;
            this.allTrayIconsSw.LabelText = "Show all notification icons";
            this.allTrayIconsSw.Location = new System.Drawing.Point(0, 78);
            this.allTrayIconsSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.allTrayIconsSw.Name = "allTrayIconsSw";
            this.allTrayIconsSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.allTrayIconsSw.Size = new System.Drawing.Size(475, 42);
            this.allTrayIconsSw.TabIndex = 233;
            this.allTrayIconsSw.Tag = "themeable";
            this.allTrayIconsSw.ToggleChecked = false;
            // 
            // noMenuDelaySw
            // 
            this.noMenuDelaySw.AccessibleName = "Remove menus delay";
            this.noMenuDelaySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.noMenuDelaySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noMenuDelaySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.noMenuDelaySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMenuDelaySw.ForeColor = System.Drawing.Color.White;
            this.noMenuDelaySw.LabelText = "Remove menus delay";
            this.noMenuDelaySw.Location = new System.Drawing.Point(0, 124);
            this.noMenuDelaySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.noMenuDelaySw.Name = "noMenuDelaySw";
            this.noMenuDelaySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.noMenuDelaySw.Size = new System.Drawing.Size(475, 42);
            this.noMenuDelaySw.TabIndex = 234;
            this.noMenuDelaySw.Tag = "themeable";
            this.noMenuDelaySw.ToggleChecked = false;
            // 
            // networkSw
            // 
            this.networkSw.AccessibleName = "Disable Network Throttling";
            this.networkSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.networkSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.networkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.networkSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkSw.ForeColor = System.Drawing.Color.White;
            this.networkSw.LabelText = "Disable Network Throttling";
            this.networkSw.Location = new System.Drawing.Point(0, 170);
            this.networkSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.networkSw.Name = "networkSw";
            this.networkSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.networkSw.Size = new System.Drawing.Size(475, 42);
            this.networkSw.TabIndex = 212;
            this.networkSw.Tag = "themeable";
            this.networkSw.ToggleChecked = false;
            // 
            // reportingSw
            // 
            this.reportingSw.AccessibleName = "Disable Error Reporting";
            this.reportingSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.reportingSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportingSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingSw.ForeColor = System.Drawing.Color.White;
            this.reportingSw.LabelText = "Disable Error Reporting";
            this.reportingSw.Location = new System.Drawing.Point(0, 216);
            this.reportingSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.reportingSw.Size = new System.Drawing.Size(475, 42);
            this.reportingSw.TabIndex = 216;
            this.reportingSw.Tag = "themeable";
            this.reportingSw.ToggleChecked = false;
            // 
            // compatSw
            // 
            this.compatSw.AccessibleName = "Disable Compatibility Assistant";
            this.compatSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.compatSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compatSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatSw.ForeColor = System.Drawing.Color.White;
            this.compatSw.LabelText = "Disable Compatibility Assistant";
            this.compatSw.Location = new System.Drawing.Point(0, 262);
            this.compatSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.compatSw.Name = "compatSw";
            this.compatSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.compatSw.Size = new System.Drawing.Size(475, 42);
            this.compatSw.TabIndex = 207;
            this.compatSw.Tag = "themeable";
            this.compatSw.ToggleChecked = false;
            // 
            // printSw
            // 
            this.printSw.AccessibleName = "Disable Print Service";
            this.printSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.printSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSw.ForeColor = System.Drawing.Color.White;
            this.printSw.LabelText = "Disable Print Service";
            this.printSw.Location = new System.Drawing.Point(0, 308);
            this.printSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.printSw.Name = "printSw";
            this.printSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.printSw.Size = new System.Drawing.Size(475, 42);
            this.printSw.TabIndex = 205;
            this.printSw.Tag = "themeable";
            this.printSw.ToggleChecked = false;
            // 
            // faxSw
            // 
            this.faxSw.AccessibleName = "Disable Fax Service";
            this.faxSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.faxSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.faxSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.ForeColor = System.Drawing.Color.White;
            this.faxSw.LabelText = "Disable Fax Service";
            this.faxSw.Location = new System.Drawing.Point(0, 354);
            this.faxSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.faxSw.Name = "faxSw";
            this.faxSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.faxSw.Size = new System.Drawing.Size(475, 42);
            this.faxSw.TabIndex = 203;
            this.faxSw.Tag = "themeable";
            this.faxSw.ToggleChecked = false;
            // 
            // stickySw
            // 
            this.stickySw.AccessibleName = "Disable Sticky Keys";
            this.stickySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.stickySw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stickySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stickySw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickySw.ForeColor = System.Drawing.Color.White;
            this.stickySw.LabelText = "Disable Sticky Keys";
            this.stickySw.Location = new System.Drawing.Point(0, 400);
            this.stickySw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.stickySw.Name = "stickySw";
            this.stickySw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.stickySw.Size = new System.Drawing.Size(475, 42);
            this.stickySw.TabIndex = 208;
            this.stickySw.Tag = "themeable";
            this.stickySw.ToggleChecked = false;
            // 
            // smartScreenSw
            // 
            this.smartScreenSw.AccessibleName = "Disable SmartScreen";
            this.smartScreenSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smartScreenSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smartScreenSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smartScreenSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartScreenSw.ForeColor = System.Drawing.Color.White;
            this.smartScreenSw.LabelText = "Disable SmartScreen";
            this.smartScreenSw.Location = new System.Drawing.Point(0, 446);
            this.smartScreenSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.smartScreenSw.Size = new System.Drawing.Size(475, 42);
            this.smartScreenSw.TabIndex = 213;
            this.smartScreenSw.Tag = "themeable";
            this.smartScreenSw.ToggleChecked = false;
            // 
            // enableUtcSw
            // 
            this.enableUtcSw.AccessibleName = "Enable UTC Time";
            this.enableUtcSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.enableUtcSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enableUtcSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.enableUtcSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableUtcSw.ForeColor = System.Drawing.Color.White;
            this.enableUtcSw.LabelText = "Enable UTC Time";
            this.enableUtcSw.Location = new System.Drawing.Point(0, 492);
            this.enableUtcSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.enableUtcSw.Name = "enableUtcSw";
            this.enableUtcSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.enableUtcSw.Size = new System.Drawing.Size(475, 42);
            this.enableUtcSw.TabIndex = 235;
            this.enableUtcSw.Tag = "themeable";
            this.enableUtcSw.ToggleChecked = false;
            // 
            // defenderSw
            // 
            this.defenderSw.AccessibleName = "Disable Windows Defender";
            this.defenderSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.defenderSw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defenderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.defenderSw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenderSw.ForeColor = System.Drawing.Color.White;
            this.defenderSw.LabelText = "Disable Windows Defender";
            this.defenderSw.Location = new System.Drawing.Point(0, 538);
            this.defenderSw.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.defenderSw.Size = new System.Drawing.Size(475, 42);
            this.defenderSw.TabIndex = 210;
            this.defenderSw.Tag = "themeable";
            this.defenderSw.ToggleChecked = false;
            // 
            // universalTabLayout
            // 
            this.universalTabLayout.Controls.Add(this.universalTabSection1);
            this.universalTabLayout.Controls.Add(this.universalTabSection2);
            this.universalTabLayout.Controls.Add(this.universalTabSection3);
            this.universalTabLayout.Controls.Add(this.universalTabSection4);
            this.universalTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.universalTabLayout.Location = new System.Drawing.Point(0, 0);
            this.universalTabLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.universalTabLayout.Name = "universalTabLayout";
            this.universalTabLayout.Padding = new System.Windows.Forms.Padding(22, 6, 22, 22);
            this.universalTabLayout.Size = new System.Drawing.Size(1035, 622);
            this.universalTabLayout.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.Location = new System.Drawing.Point(240, 58);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lblPageTitle.Size = new System.Drawing.Size(1043, 61);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageTitle.UseMnemonic = false;
            // 
            // sidebarNav
            // 
            this.sidebarNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarNav.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.sidebarNav.Location = new System.Drawing.Point(0, 66);
            this.sidebarNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebarNav.Name = "sidebarNav";
            this.sidebarNav.Size = new System.Drawing.Size(240, 704);
            this.sidebarNav.TabControl = this.tabCollection;
            this.sidebarNav.TabIndex = 3;
            // 
            // tabCollection
            // 
            this.tabCollection.Controls.Add(this.universalTab);
            this.tabCollection.Controls.Add(this.windows10Tab);
            this.tabCollection.Controls.Add(this.advancedTab);
            this.tabCollection.Controls.Add(this.modernAppsTab);
            this.tabCollection.Controls.Add(this.startupTab);
            this.tabCollection.Controls.Add(this.appsTab);
            this.tabCollection.Controls.Add(this.cleanerTab);
            this.tabCollection.Controls.Add(this.pingerTab);
            this.tabCollection.Controls.Add(this.hostsEditorTab);
            this.tabCollection.Controls.Add(this.registryFixerTab);
            this.tabCollection.Controls.Add(this.indiciumTab);
            this.tabCollection.Controls.Add(this.integratorTab);
            this.tabCollection.Controls.Add(this.optionsTab);
            this.tabCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCollection.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCollection.HideHeaders = true;
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(0);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Drawing.Point(0, 0);
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(1282, 704);
            this.tabCollection.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCollection.TabIndex = 0;
            this.tabCollection.SelectedIndexChanged += new System.EventHandler(this.aio_SelectedIndexChanged);
            // 
            // universalTab
            // 
            this.universalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.universalTab.Controls.Add(this.universalTabLayout);
            this.universalTab.Location = new System.Drawing.Point(4, 25);
            this.universalTab.Margin = new System.Windows.Forms.Padding(2);
            this.universalTab.Name = "universalTab";
            this.universalTab.Size = new System.Drawing.Size(1274, 675);
            this.universalTab.TabIndex = 0;
            this.universalTab.Text = "General";
            // 
            // windows10Tab
            // 
            this.windows10Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows10Tab.Controls.Add(this.windows10TabLayout);
            this.windows10Tab.Location = new System.Drawing.Point(4, 25);
            this.windows10Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Name = "windows10Tab";
            this.windows10Tab.Size = new System.Drawing.Size(1274, 675);
            this.windows10Tab.TabIndex = 1;
            this.windows10Tab.Text = "Windows 10";
            // 
            // advancedTab
            // 
            this.advancedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.advancedTab.Controls.Add(this.advancedTabLayout);
            this.advancedTab.Location = new System.Drawing.Point(4, 25);
            this.advancedTab.Margin = new System.Windows.Forms.Padding(2);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Size = new System.Drawing.Size(1274, 675);
            this.advancedTab.TabIndex = 15;
            this.advancedTab.Text = "Advanced";
            // 
            // modernAppsTab
            // 
            this.modernAppsTab.AutoScroll = true;
            this.modernAppsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modernAppsTab.Controls.Add(this.btnRestoreUwp);
            this.modernAppsTab.Controls.Add(this.uninstallModernAppsButton);
            this.modernAppsTab.Controls.Add(this.refreshModernAppsButton);
            this.modernAppsTab.Controls.Add(this.txtModernAppsTitle);
            this.modernAppsTab.Controls.Add(this.chkOnlyRemovable);
            this.modernAppsTab.Controls.Add(this.chkSelectAllModernApps);
            this.modernAppsTab.Controls.Add(this.cardUwp);
            this.modernAppsTab.Location = new System.Drawing.Point(4, 25);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.modernAppsTab.Size = new System.Drawing.Size(1274, 675);
            this.modernAppsTab.TabIndex = 11;
            this.modernAppsTab.Text = "UWP Apps";
            // 
            // btnRestoreUwp
            // 
            this.btnRestoreUwp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreUwp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreUwp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreUwp.Location = new System.Drawing.Point(1044, 629);
            this.btnRestoreUwp.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestoreUwp.Name = "btnRestoreUwp";
            this.btnRestoreUwp.Size = new System.Drawing.Size(218, 34);
            this.btnRestoreUwp.TabIndex = 55;
            this.btnRestoreUwp.Text = "Restore all UWP";
            this.btnRestoreUwp.Click += new System.EventHandler(this.btnRestoreUwp_Click);
            // 
            // uninstallModernAppsButton
            // 
            this.uninstallModernAppsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uninstallModernAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallModernAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallModernAppsButton.Kind = Optimizer.ButtonKind.Primary;
            this.uninstallModernAppsButton.Location = new System.Drawing.Point(1044, 85);
            this.uninstallModernAppsButton.Margin = new System.Windows.Forms.Padding(0);
            this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
            this.uninstallModernAppsButton.Size = new System.Drawing.Size(218, 34);
            this.uninstallModernAppsButton.TabIndex = 50;
            this.uninstallModernAppsButton.Text = "Uninstall";
            this.uninstallModernAppsButton.Click += new System.EventHandler(this.button74_Click);
            // 
            // refreshModernAppsButton
            // 
            this.refreshModernAppsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshModernAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshModernAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshModernAppsButton.Location = new System.Drawing.Point(1044, 45);
            this.refreshModernAppsButton.Margin = new System.Windows.Forms.Padding(0);
            this.refreshModernAppsButton.Name = "refreshModernAppsButton";
            this.refreshModernAppsButton.Size = new System.Drawing.Size(218, 34);
            this.refreshModernAppsButton.TabIndex = 49;
            this.refreshModernAppsButton.Text = "Refresh";
            this.refreshModernAppsButton.Click += new System.EventHandler(this.button75_Click);
            // 
            // txtModernAppsTitle
            // 
            this.txtModernAppsTitle.AutoSize = true;
            this.txtModernAppsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModernAppsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtModernAppsTitle.Location = new System.Drawing.Point(10, 10);
            this.txtModernAppsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtModernAppsTitle.Name = "txtModernAppsTitle";
            this.txtModernAppsTitle.Size = new System.Drawing.Size(291, 28);
            this.txtModernAppsTitle.TabIndex = 47;
            this.txtModernAppsTitle.Tag = "themeable";
            this.txtModernAppsTitle.Text = "Uninstall unwanted UWP Apps";
            // 
            // chkOnlyRemovable
            // 
            this.chkOnlyRemovable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnlyRemovable.AutoSize = true;
            this.chkOnlyRemovable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.chkOnlyRemovable.ForeColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Location = new System.Drawing.Point(1040, 128);
            this.chkOnlyRemovable.Margin = new System.Windows.Forms.Padding(0);
            this.chkOnlyRemovable.Name = "chkOnlyRemovable";
            this.chkOnlyRemovable.Size = new System.Drawing.Size(177, 25);
            this.chkOnlyRemovable.TabIndex = 53;
            this.chkOnlyRemovable.Text = "Only uninstall-ables";
            this.chkOnlyRemovable.UseVisualStyleBackColor = true;
            this.chkOnlyRemovable.CheckedChanged += new System.EventHandler(this.chkOnlyRemovable_CheckedChanged);
            // 
            // chkSelectAllModernApps
            // 
            this.chkSelectAllModernApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectAllModernApps.AutoSize = true;
            this.chkSelectAllModernApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAllModernApps.ForeColor = System.Drawing.Color.White;
            this.chkSelectAllModernApps.Location = new System.Drawing.Point(1036, 157);
            this.chkSelectAllModernApps.Margin = new System.Windows.Forms.Padding(0);
            this.chkSelectAllModernApps.Name = "chkSelectAllModernApps";
            this.chkSelectAllModernApps.Size = new System.Drawing.Size(101, 25);
            this.chkSelectAllModernApps.TabIndex = 52;
            this.chkSelectAllModernApps.Text = "Select all";
            this.chkSelectAllModernApps.UseVisualStyleBackColor = true;
            this.chkSelectAllModernApps.CheckedChanged += new System.EventHandler(this.chkSelectAllModernApps_CheckedChanged);
            // 
            // startupTab
            // 
            this.startupTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startupTab.Controls.Add(this.startupFooter);
            this.startupTab.Controls.Add(this.panelStartup);
            this.startupTab.Controls.Add(this.startupBackupStrip);
            this.startupTab.Controls.Add(this.backupStartupB);
            this.startupTab.Controls.Add(this.restoreStartupB);
            this.startupTab.Controls.Add(this.refreshStartupB);
            this.startupTab.Controls.Add(this.sortDirStartupB);
            this.startupTab.Controls.Add(this.cmbStartupSort);
            this.startupTab.Controls.Add(this.cmbStartupFilter);
            this.startupTab.Controls.Add(this.cmbStartupStatus);
            this.startupTab.Controls.Add(this.txtStartupSearch);
            this.startupTab.Controls.Add(this.startupTitle);
            this.startupTab.Location = new System.Drawing.Point(4, 25);
            this.startupTab.Margin = new System.Windows.Forms.Padding(2);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(1274, 675);
            this.startupTab.TabIndex = 7;
            this.startupTab.Text = "Startup";
            this.startupTab.Layout += new System.Windows.Forms.LayoutEventHandler(this.startupTab_Layout);
            // 
            // startupFooter
            // 
            this.startupFooter.Controls.Add(this.chkStartupSelectAll);
            this.startupFooter.Controls.Add(this.lblStartupSelected);
            this.startupFooter.Controls.Add(this.clearStartupSelB);
            this.startupFooter.Controls.Add(this.enableStartupB);
            this.startupFooter.Controls.Add(this.disableStartupB);
            this.startupFooter.Controls.Add(this.removeStartupItemB);
            this.startupFooter.Location = new System.Drawing.Point(13, 611);
            this.startupFooter.Margin = new System.Windows.Forms.Padding(0);
            this.startupFooter.Name = "startupFooter";
            this.startupFooter.Padding = new System.Windows.Forms.Padding(13, 13, 13, 13);
            this.startupFooter.Size = new System.Drawing.Size(1249, 56);
            this.startupFooter.TabIndex = 10;
            // 
            // chkStartupSelectAll
            // 
            this.chkStartupSelectAll.AutoSize = true;
            this.chkStartupSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chkStartupSelectAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartupSelectAll.ForeColor = System.Drawing.Color.White;
            this.chkStartupSelectAll.Location = new System.Drawing.Point(16, 16);
            this.chkStartupSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkStartupSelectAll.Name = "chkStartupSelectAll";
            this.chkStartupSelectAll.Size = new System.Drawing.Size(87, 24);
            this.chkStartupSelectAll.TabIndex = 0;
            this.chkStartupSelectAll.Text = "Select all";
            this.chkStartupSelectAll.UseVisualStyleBackColor = false;
            this.chkStartupSelectAll.Click += new System.EventHandler(this.chkStartupSelectAll_Click);
            // 
            // lblStartupSelected
            // 
            this.lblStartupSelected.AutoSize = true;
            this.lblStartupSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartupSelected.ForeColor = System.Drawing.Color.Silver;
            this.lblStartupSelected.Location = new System.Drawing.Point(128, 19);
            this.lblStartupSelected.Margin = new System.Windows.Forms.Padding(0);
            this.lblStartupSelected.Name = "lblStartupSelected";
            this.lblStartupSelected.Size = new System.Drawing.Size(0, 19);
            this.lblStartupSelected.TabIndex = 1;
            // 
            // clearStartupSelB
            // 
            this.clearStartupSelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clearStartupSelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearStartupSelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearStartupSelB.Kind = Optimizer.ButtonKind.Subtle;
            this.clearStartupSelB.Location = new System.Drawing.Point(1017, 11);
            this.clearStartupSelB.Margin = new System.Windows.Forms.Padding(0);
            this.clearStartupSelB.Name = "clearStartupSelB";
            this.clearStartupSelB.Size = new System.Drawing.Size(96, 32);
            this.clearStartupSelB.TabIndex = 2;
            this.clearStartupSelB.Text = "Clear";
            this.clearStartupSelB.UseVisualStyleBackColor = false;
            this.clearStartupSelB.Click += new System.EventHandler(this.clearStartupSelB_Click);
            // 
            // enableStartupB
            // 
            this.enableStartupB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.enableStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableStartupB.Location = new System.Drawing.Point(809, 11);
            this.enableStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.enableStartupB.Name = "enableStartupB";
            this.enableStartupB.Size = new System.Drawing.Size(96, 32);
            this.enableStartupB.TabIndex = 4;
            this.enableStartupB.Text = "Enable";
            this.enableStartupB.UseVisualStyleBackColor = false;
            this.enableStartupB.Click += new System.EventHandler(this.enableStartupB_Click);
            // 
            // disableStartupB
            // 
            this.disableStartupB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disableStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disableStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableStartupB.Location = new System.Drawing.Point(913, 11);
            this.disableStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.disableStartupB.Name = "disableStartupB";
            this.disableStartupB.Size = new System.Drawing.Size(96, 32);
            this.disableStartupB.TabIndex = 5;
            this.disableStartupB.Text = "Disable";
            this.disableStartupB.UseVisualStyleBackColor = false;
            this.disableStartupB.Click += new System.EventHandler(this.disableStartupB_Click);
            // 
            // removeStartupItemB
            // 
            this.removeStartupItemB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeStartupItemB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeStartupItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStartupItemB.Kind = Optimizer.ButtonKind.Primary;
            this.removeStartupItemB.Location = new System.Drawing.Point(1121, 11);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(0);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(112, 32);
            this.removeStartupItemB.TabIndex = 3;
            this.removeStartupItemB.Text = "Delete";
            this.removeStartupItemB.UseVisualStyleBackColor = false;
            this.removeStartupItemB.Click += new System.EventHandler(this.button32_Click);
            // 
            // panelStartup
            // 
            this.panelStartup.AutoScroll = true;
            this.panelStartup.EmptyText = "";
            this.panelStartup.Location = new System.Drawing.Point(13, 90);
            this.panelStartup.Margin = new System.Windows.Forms.Padding(0);
            this.panelStartup.Name = "panelStartup";
            this.panelStartup.Size = new System.Drawing.Size(1249, 512);
            this.panelStartup.TabIndex = 9;
            // 
            // startupBackupStrip
            // 
            this.startupBackupStrip.Controls.Add(this.lblBackupTitle);
            this.startupBackupStrip.Controls.Add(this.txtBackupTitle);
            this.startupBackupStrip.Controls.Add(this.doBackup);
            this.startupBackupStrip.Controls.Add(this.cancelBackup);
            this.startupBackupStrip.Location = new System.Drawing.Point(13, 90);
            this.startupBackupStrip.Margin = new System.Windows.Forms.Padding(0);
            this.startupBackupStrip.Name = "startupBackupStrip";
            this.startupBackupStrip.Padding = new System.Windows.Forms.Padding(13, 13, 13, 13);
            this.startupBackupStrip.Size = new System.Drawing.Size(1249, 56);
            this.startupBackupStrip.TabIndex = 8;
            this.startupBackupStrip.Visible = false;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupTitle.ForeColor = System.Drawing.Color.White;
            this.lblBackupTitle.Location = new System.Drawing.Point(16, 18);
            this.lblBackupTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(83, 19);
            this.lblBackupTitle.TabIndex = 0;
            this.lblBackupTitle.Tag = "";
            this.lblBackupTitle.Text = "Backup title:";
            // 
            // txtBackupTitle
            // 
            this.txtBackupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBackupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupTitle.ForeColor = System.Drawing.Color.White;
            this.txtBackupTitle.Location = new System.Drawing.Point(107, 14);
            this.txtBackupTitle.Margin = new System.Windows.Forms.Padding(0);
            this.txtBackupTitle.Name = "txtBackupTitle";
            this.txtBackupTitle.Size = new System.Drawing.Size(288, 25);
            this.txtBackupTitle.TabIndex = 1;
            this.txtBackupTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBackupTitle_KeyDown);
            // 
            // doBackup
            // 
            this.doBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.doBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doBackup.Kind = Optimizer.ButtonKind.Primary;
            this.doBackup.Location = new System.Drawing.Point(405, 11);
            this.doBackup.Margin = new System.Windows.Forms.Padding(0);
            this.doBackup.Name = "doBackup";
            this.doBackup.Size = new System.Drawing.Size(96, 32);
            this.doBackup.TabIndex = 2;
            this.doBackup.Text = "OK";
            this.doBackup.UseVisualStyleBackColor = false;
            this.doBackup.Click += new System.EventHandler(this.button13_Click);
            // 
            // cancelBackup
            // 
            this.cancelBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cancelBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.Location = new System.Drawing.Point(509, 11);
            this.cancelBackup.Margin = new System.Windows.Forms.Padding(0);
            this.cancelBackup.Name = "cancelBackup";
            this.cancelBackup.Size = new System.Drawing.Size(96, 32);
            this.cancelBackup.TabIndex = 3;
            this.cancelBackup.Text = "Cancel";
            this.cancelBackup.UseVisualStyleBackColor = false;
            this.cancelBackup.Click += new System.EventHandler(this.button14_Click);
            // 
            // backupStartupB
            // 
            this.backupStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backupStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupStartupB.Kind = Optimizer.ButtonKind.Primary;
            this.backupStartupB.Location = new System.Drawing.Point(1150, 48);
            this.backupStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.backupStartupB.Name = "backupStartupB";
            this.backupStartupB.Size = new System.Drawing.Size(112, 32);
            this.backupStartupB.TabIndex = 7;
            this.backupStartupB.Text = "Backup";
            this.backupStartupB.Click += new System.EventHandler(this.button11_Click);
            // 
            // restoreStartupB
            // 
            this.restoreStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreStartupB.Location = new System.Drawing.Point(1030, 48);
            this.restoreStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.restoreStartupB.Name = "restoreStartupB";
            this.restoreStartupB.Size = new System.Drawing.Size(112, 32);
            this.restoreStartupB.TabIndex = 6;
            this.restoreStartupB.Text = "Restore";
            this.restoreStartupB.Click += new System.EventHandler(this.button12_Click);
            // 
            // refreshStartupB
            // 
            this.refreshStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshStartupB.Location = new System.Drawing.Point(910, 48);
            this.refreshStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.refreshStartupB.Name = "refreshStartupB";
            this.refreshStartupB.Size = new System.Drawing.Size(112, 32);
            this.refreshStartupB.TabIndex = 5;
            this.refreshStartupB.Text = "Refresh";
            this.refreshStartupB.Click += new System.EventHandler(this.button37_Click);
            // 
            // sortDirStartupB
            // 
            this.sortDirStartupB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortDirStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortDirStartupB.Location = new System.Drawing.Point(621, 50);
            this.sortDirStartupB.Margin = new System.Windows.Forms.Padding(0);
            this.sortDirStartupB.Name = "sortDirStartupB";
            this.sortDirStartupB.Size = new System.Drawing.Size(32, 32);
            this.sortDirStartupB.TabIndex = 4;
            this.sortDirStartupB.Text = "↑";
            this.sortDirStartupB.Click += new System.EventHandler(this.sortDirStartupB_Click);
            // 
            // cmbStartupSort
            // 
            this.cmbStartupSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbStartupSort.BorderColor = System.Drawing.Color.Blue;
            this.cmbStartupSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartupSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartupSort.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartupSort.ForeColor = System.Drawing.Color.White;
            this.cmbStartupSort.FormattingEnabled = true;
            this.cmbStartupSort.Location = new System.Drawing.Point(469, 51);
            this.cmbStartupSort.Margin = new System.Windows.Forms.Padding(0);
            this.cmbStartupSort.Name = "cmbStartupSort";
            this.cmbStartupSort.Size = new System.Drawing.Size(145, 25);
            this.cmbStartupSort.TabIndex = 3;
            this.cmbStartupSort.SelectedIndexChanged += new System.EventHandler(this.cmbStartupSort_SelectedIndexChanged);
            // 
            // cmbStartupFilter
            // 
            this.cmbStartupFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbStartupFilter.BorderColor = System.Drawing.Color.Blue;
            this.cmbStartupFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartupFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartupFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartupFilter.ForeColor = System.Drawing.Color.White;
            this.cmbStartupFilter.FormattingEnabled = true;
            this.cmbStartupFilter.Location = new System.Drawing.Point(261, 51);
            this.cmbStartupFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cmbStartupFilter.Name = "cmbStartupFilter";
            this.cmbStartupFilter.Size = new System.Drawing.Size(201, 25);
            this.cmbStartupFilter.TabIndex = 2;
            this.cmbStartupFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStartupFilter_SelectedIndexChanged);
            // 
            // cmbStartupStatus
            // 
            this.cmbStartupStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbStartupStatus.BorderColor = System.Drawing.Color.Blue;
            this.cmbStartupStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartupStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStartupStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStartupStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStartupStatus.FormattingEnabled = true;
            this.cmbStartupStatus.Location = new System.Drawing.Point(469, 51);
            this.cmbStartupStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cmbStartupStatus.Name = "cmbStartupStatus";
            this.cmbStartupStatus.Size = new System.Drawing.Size(121, 25);
            this.cmbStartupStatus.TabIndex = 3;
            this.cmbStartupStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStartupStatus_SelectedIndexChanged);
            // 
            // txtStartupSearch
            // 
            this.txtStartupSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtStartupSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartupSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartupSearch.ForeColor = System.Drawing.Color.White;
            this.txtStartupSearch.Location = new System.Drawing.Point(13, 51);
            this.txtStartupSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtStartupSearch.Name = "txtStartupSearch";
            this.txtStartupSearch.Size = new System.Drawing.Size(240, 25);
            this.txtStartupSearch.TabIndex = 1;
            this.txtStartupSearch.TextChanged += new System.EventHandler(this.txtStartupSearch_TextChanged);
            this.txtStartupSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartupSearch_KeyDown);
            // 
            // startupTitle
            // 
            this.startupTitle.AutoSize = true;
            this.startupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.startupTitle.Location = new System.Drawing.Point(10, 10);
            this.startupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startupTitle.Name = "startupTitle";
            this.startupTitle.Size = new System.Drawing.Size(254, 28);
            this.startupTitle.TabIndex = 0;
            this.startupTitle.Tag = "themeable";
            this.startupTitle.Text = "Choose your startup items";
            // 
            // appsTab
            // 
            this.appsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.appsTab.Controls.Add(this.txtFeedError);
            this.appsTab.Controls.Add(this.tableApps);
            this.appsTab.Controls.Add(this.panel10);
            this.appsTab.Controls.Add(this.panelCommonApps);
            this.appsTab.Location = new System.Drawing.Point(4, 25);
            this.appsTab.Name = "appsTab";
            this.appsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.appsTab.Size = new System.Drawing.Size(1274, 675);
            this.appsTab.TabIndex = 12;
            this.appsTab.Text = "Apps";
            // 
            // txtFeedError
            // 
            this.txtFeedError.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedError.ForeColor = System.Drawing.Color.Gold;
            this.txtFeedError.Location = new System.Drawing.Point(3, 47);
            this.txtFeedError.Name = "txtFeedError";
            this.txtFeedError.Size = new System.Drawing.Size(1268, 505);
            this.txtFeedError.TabIndex = 171;
            this.txtFeedError.Text = "No internet connection, try refreshing links again";
            this.txtFeedError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFeedError.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1268, 44);
            this.panel10.TabIndex = 163;
            // 
            // appsTitle
            // 
            this.appsTitle.AutoSize = true;
            this.appsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.appsTitle.Location = new System.Drawing.Point(5, 7);
            this.appsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appsTitle.Name = "appsTitle";
            this.appsTitle.Size = new System.Drawing.Size(365, 28);
            this.appsTitle.TabIndex = 53;
            this.appsTitle.Tag = "themeable";
            this.appsTitle.Text = "Quickly download && install useful apps";
            // 
            // btnGetFeed
            // 
            this.btnGetFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGetFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFeed.Location = new System.Drawing.Point(1058, 7);
            this.btnGetFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetFeed.Name = "btnGetFeed";
            this.btnGetFeed.Size = new System.Drawing.Size(201, 32);
            this.btnGetFeed.TabIndex = 161;
            this.btnGetFeed.Text = "Refresh links";
            this.btnGetFeed.UseVisualStyleBackColor = false;
            this.btnGetFeed.Click += new System.EventHandler(this.btnGetFeed_Click);
            // 
            // panelCommonApps
            // 
            this.panelCommonApps.AutoScroll = true;
            this.panelCommonApps.Controls.Add(this.cAutoInstall);
            this.panelCommonApps.Controls.Add(this.progressDownloader);
            this.panelCommonApps.Controls.Add(this.c64);
            this.panelCommonApps.Controls.Add(this.c32);
            this.panelCommonApps.Controls.Add(this.btnDownloadApps);
            this.panelCommonApps.Controls.Add(this.setDownDirLbl);
            this.panelCommonApps.Controls.Add(this.txtDownloadFolder);
            this.panelCommonApps.Controls.Add(this.changeDownDirB);
            this.panelCommonApps.Controls.Add(this.txtDownloadStatus);
            this.panelCommonApps.Controls.Add(this.linkWarnings);
            this.panelCommonApps.Controls.Add(this.bitPref);
            this.panelCommonApps.Controls.Add(this.goToDownloadsB);
            this.panelCommonApps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommonApps.Location = new System.Drawing.Point(3, 552);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(1268, 120);
            this.panelCommonApps.TabIndex = 162;
            // 
            // cAutoInstall
            // 
            this.cAutoInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cAutoInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cAutoInstall.Location = new System.Drawing.Point(852, 47);
            this.cAutoInstall.Name = "cAutoInstall";
            this.cAutoInstall.Size = new System.Drawing.Size(369, 24);
            this.cAutoInstall.TabIndex = 107;
            this.cAutoInstall.Text = "Install after downloading";
            this.cAutoInstall.UseVisualStyleBackColor = false;
            // 
            // progressDownloader
            // 
            this.progressDownloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressDownloader.Location = new System.Drawing.Point(8, 83);
            this.progressDownloader.MarqueeAnimationSpeed = 15;
            this.progressDownloader.Name = "progressDownloader";
            this.progressDownloader.Size = new System.Drawing.Size(302, 10);
            this.progressDownloader.TabIndex = 160;
            // 
            // c64
            // 
            this.c64.AutoSize = true;
            this.c64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.c64.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c64.Location = new System.Drawing.Point(373, 28);
            this.c64.Name = "c64";
            this.c64.Size = new System.Drawing.Size(80, 25);
            this.c64.TabIndex = 75;
            this.c64.TabStop = true;
            this.c64.Text = "64-bit";
            this.c64.UseVisualStyleBackColor = false;
            // 
            // c32
            // 
            this.c32.AutoSize = true;
            this.c32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.c32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c32.Location = new System.Drawing.Point(464, 28);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(80, 25);
            this.c32.TabIndex = 76;
            this.c32.TabStop = true;
            this.c32.Text = "32-bit";
            this.c32.UseVisualStyleBackColor = false;
            // 
            // btnDownloadApps
            // 
            this.btnDownloadApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDownloadApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadApps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadApps.Kind = Optimizer.ButtonKind.Primary;
            this.btnDownloadApps.Location = new System.Drawing.Point(1058, 76);
            this.btnDownloadApps.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadApps.Name = "btnDownloadApps";
            this.btnDownloadApps.Size = new System.Drawing.Size(203, 35);
            this.btnDownloadApps.TabIndex = 50;
            this.btnDownloadApps.Text = "Download";
            this.btnDownloadApps.UseVisualStyleBackColor = false;
            this.btnDownloadApps.Click += new System.EventHandler(this.btnDownloadApps_Click);
            // 
            // setDownDirLbl
            // 
            this.setDownDirLbl.AutoSize = true;
            this.setDownDirLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDownDirLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.setDownDirLbl.Location = new System.Drawing.Point(3, 4);
            this.setDownDirLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setDownDirLbl.Name = "setDownDirLbl";
            this.setDownDirLbl.Size = new System.Drawing.Size(160, 21);
            this.setDownDirLbl.TabIndex = 69;
            this.setDownDirLbl.Tag = "themeable";
            this.setDownDirLbl.Text = "Set download folder";
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDownloadFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownloadFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadFolder.ForeColor = System.Drawing.Color.Silver;
            this.txtDownloadFolder.Location = new System.Drawing.Point(8, 30);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.ReadOnly = true;
            this.txtDownloadFolder.Size = new System.Drawing.Size(302, 23);
            this.txtDownloadFolder.TabIndex = 70;
            // 
            // changeDownDirB
            // 
            this.changeDownDirB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.changeDownDirB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeDownDirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDownDirB.Location = new System.Drawing.Point(313, 30);
            this.changeDownDirB.Margin = new System.Windows.Forms.Padding(2);
            this.changeDownDirB.Name = "changeDownDirB";
            this.changeDownDirB.Size = new System.Drawing.Size(30, 23);
            this.changeDownDirB.TabIndex = 71;
            this.changeDownDirB.Text = "...";
            this.changeDownDirB.UseVisualStyleBackColor = false;
            this.changeDownDirB.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtDownloadStatus
            // 
            this.txtDownloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDownloadStatus.AutoSize = true;
            this.txtDownloadStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadStatus.ForeColor = System.Drawing.Color.LightGray;
            this.txtDownloadStatus.Location = new System.Drawing.Point(4, 58);
            this.txtDownloadStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDownloadStatus.Name = "txtDownloadStatus";
            this.txtDownloadStatus.Size = new System.Drawing.Size(32, 19);
            this.txtDownloadStatus.TabIndex = 72;
            this.txtDownloadStatus.Tag = "";
            this.txtDownloadStatus.Text = "Idle";
            // 
            // linkWarnings
            // 
            this.linkWarnings.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linkWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkWarnings.AutoSize = true;
            this.linkWarnings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWarnings.ForeColor = System.Drawing.Color.Gold;
            this.linkWarnings.LinkColor = System.Drawing.Color.Gold;
            this.linkWarnings.Location = new System.Drawing.Point(4, 98);
            this.linkWarnings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkWarnings.Name = "linkWarnings";
            this.linkWarnings.Size = new System.Drawing.Size(92, 19);
            this.linkWarnings.TabIndex = 78;
            this.linkWarnings.TabStop = true;
            this.linkWarnings.Tag = "";
            this.linkWarnings.Text = "See warnings";
            this.linkWarnings.Visible = false;
            this.linkWarnings.VisitedLinkColor = System.Drawing.Color.Gold;
            this.linkWarnings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bitPref
            // 
            this.bitPref.AutoSize = true;
            this.bitPref.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitPref.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bitPref.Location = new System.Drawing.Point(368, 5);
            this.bitPref.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bitPref.Name = "bitPref";
            this.bitPref.Size = new System.Drawing.Size(143, 21);
            this.bitPref.TabIndex = 74;
            this.bitPref.Tag = "themeable";
            this.bitPref.Text = "Set bit preference";
            // 
            // goToDownloadsB
            // 
            this.goToDownloadsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goToDownloadsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.goToDownloadsB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToDownloadsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDownloadsB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToDownloadsB.Location = new System.Drawing.Point(852, 76);
            this.goToDownloadsB.Margin = new System.Windows.Forms.Padding(2);
            this.goToDownloadsB.Name = "goToDownloadsB";
            this.goToDownloadsB.Size = new System.Drawing.Size(203, 35);
            this.goToDownloadsB.TabIndex = 77;
            this.goToDownloadsB.Text = "Go to Downloads";
            this.goToDownloadsB.UseVisualStyleBackColor = false;
            this.goToDownloadsB.Click += new System.EventHandler(this.button6_Click);
            // 
            // cleanerTab
            // 
            this.cleanerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cleanerTab.Controls.Add(this.panel14);
            this.cleanerTab.Controls.Add(this.panel13);
            this.cleanerTab.Controls.Add(this.panel1);
            this.cleanerTab.Location = new System.Drawing.Point(4, 25);
            this.cleanerTab.Margin = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(10, 6, 13, 6);
            this.cleanerTab.Size = new System.Drawing.Size(1274, 675);
            this.cleanerTab.TabIndex = 5;
            this.cleanerTab.Text = "Cleaner";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.listCleanPreview);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(242, 6);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel14.Size = new System.Drawing.Size(780, 549);
            this.panel14.TabIndex = 51;
            // 
            // listCleanPreview
            // 
            this.listCleanPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listCleanPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCleanPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCleanPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCleanPreview.ForeColor = System.Drawing.Color.Silver;
            this.listCleanPreview.FormattingEnabled = true;
            this.listCleanPreview.HorizontalScrollbar = true;
            this.listCleanPreview.Location = new System.Drawing.Point(5, 5);
            this.listCleanPreview.Name = "listCleanPreview";
            this.listCleanPreview.Size = new System.Drawing.Size(770, 539);
            this.listCleanPreview.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.AutoScroll = true;
            this.panel13.Controls.Add(this.btnWinClean);
            this.panel13.Controls.Add(this.analyzeDriveB);
            this.panel13.Controls.Add(this.checkSelectAll);
            this.panel13.Controls.Add(this.lblPretext);
            this.panel13.Controls.Add(this.cleanDriveB);
            this.panel13.Controls.Add(this.lblFootprint);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(242, 555);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(780, 61);
            this.panel13.TabIndex = 50;
            // 
            // btnWinClean
            // 
            this.btnWinClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnWinClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClean.Location = new System.Drawing.Point(346, 23);
            this.btnWinClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnWinClean.Name = "btnWinClean";
            this.btnWinClean.Size = new System.Drawing.Size(140, 31);
            this.btnWinClean.TabIndex = 90;
            this.btnWinClean.Text = "Cleanmgr ...";
            this.btnWinClean.UseVisualStyleBackColor = false;
            this.btnWinClean.Click += new System.EventHandler(this.btnWinClean_Click);
            // 
            // analyzeDriveB
            // 
            this.analyzeDriveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.analyzeDriveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.analyzeDriveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyzeDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeDriveB.Location = new System.Drawing.Point(490, 23);
            this.analyzeDriveB.Margin = new System.Windows.Forms.Padding(2);
            this.analyzeDriveB.Name = "analyzeDriveB";
            this.analyzeDriveB.Size = new System.Drawing.Size(140, 31);
            this.analyzeDriveB.TabIndex = 89;
            this.analyzeDriveB.Text = "Analyze";
            this.analyzeDriveB.UseVisualStyleBackColor = false;
            this.analyzeDriveB.Click += new System.EventHandler(this.analyzeDriveB_Click);
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSelectAll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkSelectAll.LinkColor = System.Drawing.Color.DodgerBlue;
            this.checkSelectAll.Location = new System.Drawing.Point(527, 1);
            this.checkSelectAll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(247, 20);
            this.checkSelectAll.TabIndex = 88;
            this.checkSelectAll.TabStop = true;
            this.checkSelectAll.Tag = "themeable";
            this.checkSelectAll.Text = "Select all";
            this.checkSelectAll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.checkSelectAll_LinkClicked);
            // 
            // lblPretext
            // 
            this.lblPretext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPretext.AutoSize = true;
            this.lblPretext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretext.ForeColor = System.Drawing.Color.Silver;
            this.lblPretext.Location = new System.Drawing.Point(2, 4);
            this.lblPretext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretext.Name = "lblPretext";
            this.lblPretext.Size = new System.Drawing.Size(199, 21);
            this.lblPretext.TabIndex = 49;
            this.lblPretext.Tag = "";
            this.lblPretext.Text = "Maximum size to be freed:";
            this.lblPretext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cleanDriveB
            // 
            this.cleanDriveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cleanDriveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cleanDriveB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanDriveB.Kind = Optimizer.ButtonKind.Primary;
            this.cleanDriveB.Location = new System.Drawing.Point(634, 23);
            this.cleanDriveB.Margin = new System.Windows.Forms.Padding(2);
            this.cleanDriveB.Name = "cleanDriveB";
            this.cleanDriveB.Size = new System.Drawing.Size(140, 31);
            this.cleanDriveB.TabIndex = 34;
            this.cleanDriveB.Text = "Clean";
            this.cleanDriveB.UseVisualStyleBackColor = false;
            this.cleanDriveB.Click += new System.EventHandler(this.cleanDriveB_Click);
            // 
            // lblFootprint
            // 
            this.lblFootprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFootprint.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootprint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFootprint.Location = new System.Drawing.Point(1, 26);
            this.lblFootprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFootprint.Name = "lblFootprint";
            this.lblFootprint.Size = new System.Drawing.Size(197, 31);
            this.lblFootprint.TabIndex = 48;
            this.lblFootprint.Tag = "themeable";
            this.lblFootprint.Text = "-";
            this.lblFootprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bravePasswords);
            this.panel1.Controls.Add(this.braveSession);
            this.panel1.Controls.Add(this.braveHistory);
            this.panel1.Controls.Add(this.braveCookies);
            this.panel1.Controls.Add(this.braveCache);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.edgeSession);
            this.panel1.Controls.Add(this.edgeHistory);
            this.panel1.Controls.Add(this.edgeCookies);
            this.panel1.Controls.Add(this.edgeCache);
            this.panel1.Controls.Add(this.IECache);
            this.panel1.Controls.Add(this.firefoxHistory);
            this.panel1.Controls.Add(this.firefoxCookies);
            this.panel1.Controls.Add(this.firefoxCache);
            this.panel1.Controls.Add(this.chromePws);
            this.panel1.Controls.Add(this.chromeSession);
            this.panel1.Controls.Add(this.chromeHistory);
            this.panel1.Controls.Add(this.chromeCookies);
            this.panel1.Controls.Add(this.chromeCache);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.checkErrorReports);
            this.panel1.Controls.Add(this.checkTemp);
            this.panel1.Controls.Add(this.checkBin);
            this.panel1.Controls.Add(this.checkMiniDumps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 610);
            this.panel1.TabIndex = 47;
            // 
            // bravePasswords
            // 
            this.bravePasswords.AutoSize = true;
            this.bravePasswords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bravePasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bravePasswords.ForeColor = System.Drawing.Color.White;
            this.bravePasswords.Location = new System.Drawing.Point(9, 676);
            this.bravePasswords.Margin = new System.Windows.Forms.Padding(2);
            this.bravePasswords.Name = "bravePasswords";
            this.bravePasswords.Size = new System.Drawing.Size(100, 24);
            this.bravePasswords.TabIndex = 78;
            this.bravePasswords.Text = "Passwords";
            this.bravePasswords.UseVisualStyleBackColor = false;
            // 
            // braveSession
            // 
            this.braveSession.AutoSize = true;
            this.braveSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.braveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveSession.ForeColor = System.Drawing.Color.White;
            this.braveSession.Location = new System.Drawing.Point(9, 649);
            this.braveSession.Margin = new System.Windows.Forms.Padding(2);
            this.braveSession.Name = "braveSession";
            this.braveSession.Size = new System.Drawing.Size(82, 24);
            this.braveSession.TabIndex = 77;
            this.braveSession.Text = "Session";
            this.braveSession.UseVisualStyleBackColor = false;
            // 
            // braveHistory
            // 
            this.braveHistory.AutoSize = true;
            this.braveHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.braveHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveHistory.ForeColor = System.Drawing.Color.White;
            this.braveHistory.Location = new System.Drawing.Point(9, 622);
            this.braveHistory.Margin = new System.Windows.Forms.Padding(2);
            this.braveHistory.Name = "braveHistory";
            this.braveHistory.Size = new System.Drawing.Size(81, 24);
            this.braveHistory.TabIndex = 76;
            this.braveHistory.Text = "History";
            this.braveHistory.UseVisualStyleBackColor = false;
            // 
            // braveCookies
            // 
            this.braveCookies.AutoSize = true;
            this.braveCookies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.braveCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCookies.ForeColor = System.Drawing.Color.White;
            this.braveCookies.Location = new System.Drawing.Point(9, 595);
            this.braveCookies.Margin = new System.Windows.Forms.Padding(2);
            this.braveCookies.Name = "braveCookies";
            this.braveCookies.Size = new System.Drawing.Size(84, 24);
            this.braveCookies.TabIndex = 75;
            this.braveCookies.Text = "Cookies";
            this.braveCookies.UseVisualStyleBackColor = false;
            // 
            // braveCache
            // 
            this.braveCache.AutoSize = true;
            this.braveCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.braveCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCache.ForeColor = System.Drawing.Color.White;
            this.braveCache.Location = new System.Drawing.Point(9, 568);
            this.braveCache.Margin = new System.Windows.Forms.Padding(2);
            this.braveCache.Name = "braveCache";
            this.braveCache.Size = new System.Drawing.Size(73, 24);
            this.braveCache.TabIndex = 74;
            this.braveCache.Text = "Cache";
            this.braveCache.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(30, 543);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 73;
            this.label9.Tag = "";
            this.label9.Text = "Brave Browser";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 542);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(32, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 71;
            this.label8.Tag = "";
            this.label8.Text = "Windows";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // edgeSession
            // 
            this.edgeSession.AutoSize = true;
            this.edgeSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeSession.ForeColor = System.Drawing.Color.White;
            this.edgeSession.Location = new System.Drawing.Point(9, 516);
            this.edgeSession.Margin = new System.Windows.Forms.Padding(2);
            this.edgeSession.Name = "edgeSession";
            this.edgeSession.Size = new System.Drawing.Size(82, 24);
            this.edgeSession.TabIndex = 69;
            this.edgeSession.Text = "Session";
            this.edgeSession.UseVisualStyleBackColor = false;
            // 
            // edgeHistory
            // 
            this.edgeHistory.AutoSize = true;
            this.edgeHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeHistory.ForeColor = System.Drawing.Color.White;
            this.edgeHistory.Location = new System.Drawing.Point(9, 489);
            this.edgeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.edgeHistory.Name = "edgeHistory";
            this.edgeHistory.Size = new System.Drawing.Size(81, 24);
            this.edgeHistory.TabIndex = 68;
            this.edgeHistory.Text = "History";
            this.edgeHistory.UseVisualStyleBackColor = false;
            // 
            // edgeCookies
            // 
            this.edgeCookies.AutoSize = true;
            this.edgeCookies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCookies.ForeColor = System.Drawing.Color.White;
            this.edgeCookies.Location = new System.Drawing.Point(9, 462);
            this.edgeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCookies.Name = "edgeCookies";
            this.edgeCookies.Size = new System.Drawing.Size(84, 24);
            this.edgeCookies.TabIndex = 67;
            this.edgeCookies.Text = "Cookies";
            this.edgeCookies.UseVisualStyleBackColor = false;
            // 
            // edgeCache
            // 
            this.edgeCache.AutoSize = true;
            this.edgeCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCache.ForeColor = System.Drawing.Color.White;
            this.edgeCache.Location = new System.Drawing.Point(9, 435);
            this.edgeCache.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCache.Name = "edgeCache";
            this.edgeCache.Size = new System.Drawing.Size(73, 24);
            this.edgeCache.TabIndex = 66;
            this.edgeCache.Text = "Cache";
            this.edgeCache.UseVisualStyleBackColor = false;
            // 
            // IECache
            // 
            this.IECache.AutoSize = true;
            this.IECache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IECache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IECache.ForeColor = System.Drawing.Color.White;
            this.IECache.Location = new System.Drawing.Point(10, 725);
            this.IECache.Margin = new System.Windows.Forms.Padding(2);
            this.IECache.Name = "IECache";
            this.IECache.Size = new System.Drawing.Size(73, 24);
            this.IECache.TabIndex = 65;
            this.IECache.Text = "Cache";
            this.IECache.UseVisualStyleBackColor = false;
            // 
            // firefoxHistory
            // 
            this.firefoxHistory.AutoSize = true;
            this.firefoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.firefoxHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxHistory.ForeColor = System.Drawing.Color.White;
            this.firefoxHistory.Location = new System.Drawing.Point(9, 384);
            this.firefoxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxHistory.Name = "firefoxHistory";
            this.firefoxHistory.Size = new System.Drawing.Size(81, 24);
            this.firefoxHistory.TabIndex = 64;
            this.firefoxHistory.Text = "History";
            this.firefoxHistory.UseVisualStyleBackColor = false;
            // 
            // firefoxCookies
            // 
            this.firefoxCookies.AutoSize = true;
            this.firefoxCookies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.firefoxCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCookies.ForeColor = System.Drawing.Color.White;
            this.firefoxCookies.Location = new System.Drawing.Point(9, 357);
            this.firefoxCookies.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCookies.Name = "firefoxCookies";
            this.firefoxCookies.Size = new System.Drawing.Size(84, 24);
            this.firefoxCookies.TabIndex = 63;
            this.firefoxCookies.Text = "Cookies";
            this.firefoxCookies.UseVisualStyleBackColor = false;
            // 
            // firefoxCache
            // 
            this.firefoxCache.AutoSize = true;
            this.firefoxCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.firefoxCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCache.ForeColor = System.Drawing.Color.White;
            this.firefoxCache.Location = new System.Drawing.Point(9, 330);
            this.firefoxCache.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCache.Name = "firefoxCache";
            this.firefoxCache.Size = new System.Drawing.Size(73, 24);
            this.firefoxCache.TabIndex = 62;
            this.firefoxCache.Text = "Cache";
            this.firefoxCache.UseVisualStyleBackColor = false;
            // 
            // chromePws
            // 
            this.chromePws.AutoSize = true;
            this.chromePws.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromePws.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromePws.ForeColor = System.Drawing.Color.White;
            this.chromePws.Location = new System.Drawing.Point(8, 278);
            this.chromePws.Margin = new System.Windows.Forms.Padding(2);
            this.chromePws.Name = "chromePws";
            this.chromePws.Size = new System.Drawing.Size(100, 24);
            this.chromePws.TabIndex = 61;
            this.chromePws.Text = "Passwords";
            this.chromePws.UseVisualStyleBackColor = false;
            // 
            // chromeSession
            // 
            this.chromeSession.AutoSize = true;
            this.chromeSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeSession.ForeColor = System.Drawing.Color.White;
            this.chromeSession.Location = new System.Drawing.Point(8, 251);
            this.chromeSession.Margin = new System.Windows.Forms.Padding(2);
            this.chromeSession.Name = "chromeSession";
            this.chromeSession.Size = new System.Drawing.Size(82, 24);
            this.chromeSession.TabIndex = 60;
            this.chromeSession.Text = "Session";
            this.chromeSession.UseVisualStyleBackColor = false;
            // 
            // chromeHistory
            // 
            this.chromeHistory.AutoSize = true;
            this.chromeHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeHistory.ForeColor = System.Drawing.Color.White;
            this.chromeHistory.Location = new System.Drawing.Point(8, 224);
            this.chromeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.chromeHistory.Name = "chromeHistory";
            this.chromeHistory.Size = new System.Drawing.Size(81, 24);
            this.chromeHistory.TabIndex = 59;
            this.chromeHistory.Text = "History";
            this.chromeHistory.UseVisualStyleBackColor = false;
            // 
            // chromeCookies
            // 
            this.chromeCookies.AutoSize = true;
            this.chromeCookies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCookies.ForeColor = System.Drawing.Color.White;
            this.chromeCookies.Location = new System.Drawing.Point(8, 197);
            this.chromeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCookies.Name = "chromeCookies";
            this.chromeCookies.Size = new System.Drawing.Size(84, 24);
            this.chromeCookies.TabIndex = 58;
            this.chromeCookies.Text = "Cookies";
            this.chromeCookies.UseVisualStyleBackColor = false;
            // 
            // chromeCache
            // 
            this.chromeCache.AutoSize = true;
            this.chromeCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCache.ForeColor = System.Drawing.Color.White;
            this.chromeCache.Location = new System.Drawing.Point(8, 170);
            this.chromeCache.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCache.Name = "chromeCache";
            this.chromeCache.Size = new System.Drawing.Size(73, 24);
            this.chromeCache.TabIndex = 57;
            this.chromeCache.Text = "Cache";
            this.chromeCache.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(31, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 56;
            this.label7.Tag = "";
            this.label7.Text = "Microsoft Edge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(33, 701);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 55;
            this.label6.Tag = "";
            this.label6.Text = "Internet Explorer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(30, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 54;
            this.label5.Tag = "";
            this.label5.Text = "Mozilla Firefox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 47;
            this.label4.Tag = "";
            this.label4.Text = "Google Chrome";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(9, 410);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(9, 700);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 52;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(7, 146);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(9, 306);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // checkErrorReports
            // 
            this.checkErrorReports.AutoSize = true;
            this.checkErrorReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(8, 91);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.Size = new System.Drawing.Size(113, 24);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.Text = "Error reports";
            this.checkErrorReports.UseVisualStyleBackColor = false;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTemp.ForeColor = System.Drawing.Color.White;
            this.checkTemp.Location = new System.Drawing.Point(8, 37);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(132, 24);
            this.checkTemp.TabIndex = 36;
            this.checkTemp.Text = "Temporary files";
            this.checkTemp.UseVisualStyleBackColor = false;
            // 
            // checkBin
            // 
            this.checkBin.AutoSize = true;
            this.checkBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.White;
            this.checkBin.Location = new System.Drawing.Point(8, 118);
            this.checkBin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBin.Name = "checkBin";
            this.checkBin.Size = new System.Drawing.Size(107, 24);
            this.checkBin.TabIndex = 41;
            this.checkBin.Text = "Recycle Bin";
            this.checkBin.UseVisualStyleBackColor = false;
            // 
            // checkMiniDumps
            // 
            this.checkMiniDumps.AutoSize = true;
            this.checkMiniDumps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkMiniDumps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniDumps.ForeColor = System.Drawing.Color.White;
            this.checkMiniDumps.Location = new System.Drawing.Point(8, 64);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(2);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.Size = new System.Drawing.Size(147, 24);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.Text = "BSOD Minidumps";
            this.checkMiniDumps.UseVisualStyleBackColor = false;
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pingerTab.Controls.Add(this.netTools);
            this.pingerTab.Location = new System.Drawing.Point(4, 25);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pingerTab.Size = new System.Drawing.Size(1274, 675);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // netTools
            // 
            this.netTools.Controls.Add(this.tabPage2);
            this.netTools.Controls.Add(this.tabPage1);
            this.netTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netTools.Location = new System.Drawing.Point(3, 3);
            this.netTools.Margin = new System.Windows.Forms.Padding(0);
            this.netTools.Multiline = true;
            this.netTools.Name = "netTools";
            this.netTools.Padding = new System.Drawing.Point(0, 0);
            this.netTools.SelectedIndex = 0;
            this.netTools.Size = new System.Drawing.Size(1029, 616);
            this.netTools.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.netTools.TabIndex = 104;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage2.Controls.Add(this.btnSetDns);
            this.tabPage2.Controls.Add(this.txtDns6B);
            this.tabPage2.Controls.Add(this.txtDns6A);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtDns4B);
            this.tabPage2.Controls.Add(this.txtDns4A);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.chkCustomDns);
            this.tabPage2.Controls.Add(this.chkAllNics);
            this.tabPage2.Controls.Add(this.dnsTitle);
            this.tabPage2.Controls.Add(this.linkDNSv6A);
            this.tabPage2.Controls.Add(this.linkDNSv4A);
            this.tabPage2.Controls.Add(this.linkDNSv6);
            this.tabPage2.Controls.Add(this.linkDNSv4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnOpenNetwork);
            this.tabPage2.Controls.Add(this.flushCacheB);
            this.tabPage2.Controls.Add(this.boxAdapter);
            this.tabPage2.Controls.Add(this.boxDNS);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNS";
            // 
            // btnSetDns
            // 
            this.btnSetDns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetDns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDns.Kind = Optimizer.ButtonKind.Primary;
            this.btnSetDns.Location = new System.Drawing.Point(428, 521);
            this.btnSetDns.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetDns.Name = "btnSetDns";
            this.btnSetDns.Size = new System.Drawing.Size(260, 29);
            this.btnSetDns.TabIndex = 123;
            this.btnSetDns.Text = "Set as default";
            this.btnSetDns.Click += new System.EventHandler(this.btnSetDns_Click);
            // 
            // txtDns6B
            // 
            this.txtDns6B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDns6B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDns6B.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns6B.ForeColor = System.Drawing.Color.White;
            this.txtDns6B.Location = new System.Drawing.Point(359, 268);
            this.txtDns6B.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns6B.Name = "txtDns6B";
            this.txtDns6B.Size = new System.Drawing.Size(326, 29);
            this.txtDns6B.TabIndex = 122;
            this.txtDns6B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDns6B.Visible = false;
            // 
            // txtDns6A
            // 
            this.txtDns6A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDns6A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDns6A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns6A.ForeColor = System.Drawing.Color.White;
            this.txtDns6A.Location = new System.Drawing.Point(29, 268);
            this.txtDns6A.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns6A.Name = "txtDns6A";
            this.txtDns6A.Size = new System.Drawing.Size(326, 29);
            this.txtDns6A.TabIndex = 120;
            this.txtDns6A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDns6A.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(25, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 19);
            this.label12.TabIndex = 121;
            this.label12.Tag = "";
            this.label12.Text = "IPv6";
            this.label12.Visible = false;
            // 
            // txtDns4B
            // 
            this.txtDns4B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDns4B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDns4B.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns4B.ForeColor = System.Drawing.Color.White;
            this.txtDns4B.Location = new System.Drawing.Point(359, 212);
            this.txtDns4B.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns4B.Name = "txtDns4B";
            this.txtDns4B.Size = new System.Drawing.Size(326, 29);
            this.txtDns4B.TabIndex = 119;
            this.txtDns4B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDns4B.Visible = false;
            // 
            // txtDns4A
            // 
            this.txtDns4A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDns4A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDns4A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns4A.ForeColor = System.Drawing.Color.White;
            this.txtDns4A.Location = new System.Drawing.Point(29, 212);
            this.txtDns4A.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns4A.Name = "txtDns4A";
            this.txtDns4A.Size = new System.Drawing.Size(326, 29);
            this.txtDns4A.TabIndex = 117;
            this.txtDns4A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDns4A.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(26, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 118;
            this.label10.Tag = "";
            this.label10.Text = "IPv4";
            this.label10.Visible = false;
            // 
            // chkCustomDns
            // 
            this.chkCustomDns.AutoSize = true;
            this.chkCustomDns.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomDns.ForeColor = System.Drawing.Color.White;
            this.chkCustomDns.Location = new System.Drawing.Point(29, 163);
            this.chkCustomDns.Margin = new System.Windows.Forms.Padding(2);
            this.chkCustomDns.Name = "chkCustomDns";
            this.chkCustomDns.Size = new System.Drawing.Size(103, 24);
            this.chkCustomDns.TabIndex = 116;
            this.chkCustomDns.Text = "Set cutom";
            this.chkCustomDns.UseVisualStyleBackColor = true;
            this.chkCustomDns.CheckedChanged += new System.EventHandler(this.chkCustomDns_CheckedChanged);
            // 
            // chkAllNics
            // 
            this.chkAllNics.AutoSize = true;
            this.chkAllNics.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllNics.ForeColor = System.Drawing.Color.White;
            this.chkAllNics.Location = new System.Drawing.Point(29, 84);
            this.chkAllNics.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllNics.Name = "chkAllNics";
            this.chkAllNics.Size = new System.Drawing.Size(100, 24);
            this.chkAllNics.TabIndex = 115;
            this.chkAllNics.Text = "Set for all";
            this.chkAllNics.UseVisualStyleBackColor = true;
            // 
            // dnsTitle
            // 
            this.dnsTitle.AutoSize = true;
            this.dnsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dnsTitle.Location = new System.Drawing.Point(5, 3);
            this.dnsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dnsTitle.Name = "dnsTitle";
            this.dnsTitle.Size = new System.Drawing.Size(258, 28);
            this.dnsTitle.TabIndex = 114;
            this.dnsTitle.Tag = "themeable";
            this.dnsTitle.Text = "Rapidly change DNS server";
            // 
            // linkDNSv6A
            // 
            this.linkDNSv6A.AutoSize = true;
            this.linkDNSv6A.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv6A.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv6A.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv6A.Location = new System.Drawing.Point(106, 440);
            this.linkDNSv6A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv6A.Name = "linkDNSv6A";
            this.linkDNSv6A.Size = new System.Drawing.Size(15, 20);
            this.linkDNSv6A.TabIndex = 113;
            this.linkDNSv6A.TabStop = true;
            this.linkDNSv6A.Tag = "themeable";
            this.linkDNSv6A.Text = "-";
            // 
            // linkDNSv4A
            // 
            this.linkDNSv4A.AutoSize = true;
            this.linkDNSv4A.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv4A.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv4A.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv4A.Location = new System.Drawing.Point(105, 383);
            this.linkDNSv4A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv4A.Name = "linkDNSv4A";
            this.linkDNSv4A.Size = new System.Drawing.Size(15, 20);
            this.linkDNSv4A.TabIndex = 112;
            this.linkDNSv4A.TabStop = true;
            this.linkDNSv4A.Tag = "themeable";
            this.linkDNSv4A.Text = "-";
            // 
            // linkDNSv6
            // 
            this.linkDNSv6.AutoSize = true;
            this.linkDNSv6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv6.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv6.Location = new System.Drawing.Point(106, 417);
            this.linkDNSv6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv6.Name = "linkDNSv6";
            this.linkDNSv6.Size = new System.Drawing.Size(15, 20);
            this.linkDNSv6.TabIndex = 111;
            this.linkDNSv6.TabStop = true;
            this.linkDNSv6.Tag = "themeable";
            this.linkDNSv6.Text = "-";
            // 
            // linkDNSv4
            // 
            this.linkDNSv4.AutoSize = true;
            this.linkDNSv4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv4.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkDNSv4.Location = new System.Drawing.Point(106, 360);
            this.linkDNSv4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv4.Name = "linkDNSv4";
            this.linkDNSv4.Size = new System.Drawing.Size(15, 20);
            this.linkDNSv4.TabIndex = 110;
            this.linkDNSv4.TabStop = true;
            this.linkDNSv4.Tag = "themeable";
            this.linkDNSv4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(24, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 109;
            this.label3.Tag = "";
            this.label3.Text = "DNS IPv6:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 108;
            this.label1.Tag = "";
            this.label1.Text = "DNS IPv4:";
            // 
            // btnOpenNetwork
            // 
            this.btnOpenNetwork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenNetwork.Location = new System.Drawing.Point(28, 521);
            this.btnOpenNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenNetwork.Name = "btnOpenNetwork";
            this.btnOpenNetwork.Size = new System.Drawing.Size(260, 29);
            this.btnOpenNetwork.TabIndex = 105;
            this.btnOpenNetwork.Text = "Open Network Connections";
            this.btnOpenNetwork.Click += new System.EventHandler(this.btnOpenNetwork_Click);
            // 
            // flushCacheB
            // 
            this.flushCacheB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flushCacheB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flushCacheB.Location = new System.Drawing.Point(28, 488);
            this.flushCacheB.Margin = new System.Windows.Forms.Padding(2);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(260, 29);
            this.flushCacheB.TabIndex = 104;
            this.flushCacheB.Text = "Flush DNS cache";
            this.flushCacheB.Click += new System.EventHandler(this.flushCacheB_Click);
            // 
            // boxAdapter
            // 
            this.boxAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxAdapter.BorderColor = System.Drawing.Color.Blue;
            this.boxAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxAdapter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAdapter.ForeColor = System.Drawing.Color.White;
            this.boxAdapter.FormattingEnabled = true;
            this.boxAdapter.Location = new System.Drawing.Point(28, 50);
            this.boxAdapter.Name = "boxAdapter";
            this.boxAdapter.Size = new System.Drawing.Size(660, 29);
            this.boxAdapter.TabIndex = 107;
            this.boxAdapter.Tag = "themeable";
            // 
            // boxDNS
            // 
            this.boxDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxDNS.BorderColor = System.Drawing.Color.Blue;
            this.boxDNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDNS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDNS.ForeColor = System.Drawing.Color.White;
            this.boxDNS.FormattingEnabled = true;
            this.boxDNS.Location = new System.Drawing.Point(28, 129);
            this.boxDNS.Name = "boxDNS";
            this.boxDNS.Size = new System.Drawing.Size(660, 29);
            this.boxDNS.TabIndex = 106;
            this.boxDNS.Tag = "themeable";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage1.Controls.Add(this.btnExport);
            this.tabPage1.Controls.Add(this.copyB);
            this.tabPage1.Controls.Add(this.copyIPB);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.lblResults);
            this.tabPage1.Controls.Add(this.btnShodan);
            this.tabPage1.Controls.Add(this.btnPing);
            this.tabPage1.Controls.Add(this.txtPingInput);
            this.tabPage1.Controls.Add(this.lblPinger);
            this.tabPage1.Controls.Add(this.pingerTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1260, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pinger";
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(27, 487);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 29);
            this.btnExport.TabIndex = 93;
            this.btnExport.Text = "Export...";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // copyB
            // 
            this.copyB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyB.Location = new System.Drawing.Point(25, 144);
            this.copyB.Margin = new System.Windows.Forms.Padding(2);
            this.copyB.Name = "copyB";
            this.copyB.Size = new System.Drawing.Size(185, 31);
            this.copyB.TabIndex = 92;
            this.copyB.Text = "Copy IP";
            this.copyB.Click += new System.EventHandler(this.copyB_Click);
            // 
            // copyIPB
            // 
            this.copyIPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyIPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyIPB.Location = new System.Drawing.Point(214, 144);
            this.copyIPB.Margin = new System.Windows.Forms.Padding(2);
            this.copyIPB.Name = "copyIPB";
            this.copyIPB.Size = new System.Drawing.Size(185, 31);
            this.copyIPB.TabIndex = 91;
            this.copyIPB.Text = "Copy";
            this.copyIPB.Click += new System.EventHandler(this.copyIPB_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.listPingResults);
            this.panel7.Location = new System.Drawing.Point(27, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(371, 270);
            this.panel7.TabIndex = 90;
            // 
            // listPingResults
            // 
            this.listPingResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listPingResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPingResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPingResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listPingResults.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPingResults.ForeColor = System.Drawing.Color.White;
            this.listPingResults.FormattingEnabled = true;
            this.listPingResults.HorizontalScrollbar = true;
            this.listPingResults.ItemHeight = 21;
            this.listPingResults.Location = new System.Drawing.Point(0, 0);
            this.listPingResults.Margin = new System.Windows.Forms.Padding(2);
            this.listPingResults.Name = "listPingResults";
            this.listPingResults.Size = new System.Drawing.Size(369, 268);
            this.listPingResults.TabIndex = 79;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Silver;
            this.lblResults.Location = new System.Drawing.Point(23, 192);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(54, 19);
            this.lblResults.TabIndex = 89;
            this.lblResults.Tag = "";
            this.lblResults.Text = "Results";
            // 
            // btnShodan
            // 
            this.btnShodan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShodan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShodan.Location = new System.Drawing.Point(25, 109);
            this.btnShodan.Margin = new System.Windows.Forms.Padding(2);
            this.btnShodan.Name = "btnShodan";
            this.btnShodan.Size = new System.Drawing.Size(185, 31);
            this.btnShodan.TabIndex = 88;
            this.btnShodan.Text = "Check on SHODAN.io";
            this.btnShodan.Click += new System.EventHandler(this.btnShodan_Click);
            // 
            // btnPing
            // 
            this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPing.Kind = Optimizer.ButtonKind.Primary;
            this.btnPing.Location = new System.Drawing.Point(214, 109);
            this.btnPing.Margin = new System.Windows.Forms.Padding(2);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(185, 31);
            this.btnPing.TabIndex = 87;
            this.btnPing.Text = "Ping";
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtPingInput
            // 
            this.txtPingInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPingInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPingInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPingInput.ForeColor = System.Drawing.Color.White;
            this.txtPingInput.Location = new System.Drawing.Point(25, 76);
            this.txtPingInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtPingInput.Name = "txtPingInput";
            this.txtPingInput.Size = new System.Drawing.Size(374, 29);
            this.txtPingInput.TabIndex = 85;
            this.txtPingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPingInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPingInput_KeyDown);
            // 
            // lblPinger
            // 
            this.lblPinger.AutoSize = true;
            this.lblPinger.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinger.ForeColor = System.Drawing.Color.Silver;
            this.lblPinger.Location = new System.Drawing.Point(22, 53);
            this.lblPinger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPinger.Name = "lblPinger";
            this.lblPinger.Size = new System.Drawing.Size(122, 19);
            this.lblPinger.TabIndex = 86;
            this.lblPinger.Tag = "";
            this.lblPinger.Text = "IP / Domain name";
            // 
            // pingerTitle
            // 
            this.pingerTitle.AutoSize = true;
            this.pingerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingerTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pingerTitle.Location = new System.Drawing.Point(5, 3);
            this.pingerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pingerTitle.Name = "pingerTitle";
            this.pingerTitle.Size = new System.Drawing.Size(393, 28);
            this.pingerTitle.TabIndex = 84;
            this.pingerTitle.Tag = "themeable";
            this.pingerTitle.Text = "Ping IP addresses and assess your latency";
            // 
            // hostsEditorTab
            // 
            this.hostsEditorTab.AutoScroll = true;
            this.hostsEditorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hostsEditorTab.Controls.Add(this.panel4);
            this.hostsEditorTab.Controls.Add(this.hostsTitle);
            this.hostsEditorTab.Controls.Add(this.linkLocate);
            this.hostsEditorTab.Location = new System.Drawing.Point(4, 25);
            this.hostsEditorTab.Margin = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Name = "hostsEditorTab";
            this.hostsEditorTab.Padding = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Size = new System.Drawing.Size(1274, 675);
            this.hostsEditorTab.TabIndex = 9;
            this.hostsEditorTab.Text = "Hosts";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.chkIncludeWww);
            this.panel4.Controls.Add(this.linkAdvancedEdit);
            this.panel4.Controls.Add(this.linkRestoreDefault);
            this.panel4.Controls.Add(this.lblLock);
            this.panel4.Controls.Add(this.chkReadOnly);
            this.panel4.Controls.Add(this.panelList);
            this.panel4.Controls.Add(this.chkBlock);
            this.panel4.Controls.Add(this.refreshHostsB);
            this.panel4.Controls.Add(this.removeHostB);
            this.panel4.Controls.Add(this.removeAllHostsB);
            this.panel4.Controls.Add(this.addHostB);
            this.panel4.Controls.Add(this.txtIP);
            this.panel4.Controls.Add(this.txtDomain);
            this.panel4.Controls.Add(this.lblDomain);
            this.panel4.Controls.Add(this.lblIP);
            this.panel4.Location = new System.Drawing.Point(6, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 501);
            this.panel4.TabIndex = 53;
            // 
            // chkIncludeWww
            // 
            this.chkIncludeWww.AutoSize = true;
            this.chkIncludeWww.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chkIncludeWww.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeWww.ForeColor = System.Drawing.Color.White;
            this.chkIncludeWww.Location = new System.Drawing.Point(329, 136);
            this.chkIncludeWww.Margin = new System.Windows.Forms.Padding(2);
            this.chkIncludeWww.Name = "chkIncludeWww";
            this.chkIncludeWww.Size = new System.Drawing.Size(141, 25);
            this.chkIncludeWww.TabIndex = 63;
            this.chkIncludeWww.Text = "WWW CNAME";
            this.chkIncludeWww.UseVisualStyleBackColor = false;
            // 
            // linkAdvancedEdit
            // 
            this.linkAdvancedEdit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkAdvancedEdit.AutoSize = true;
            this.linkAdvancedEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdvancedEdit.ForeColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.LinkColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.Location = new System.Drawing.Point(323, 338);
            this.linkAdvancedEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkAdvancedEdit.Name = "linkAdvancedEdit";
            this.linkAdvancedEdit.Size = new System.Drawing.Size(132, 21);
            this.linkAdvancedEdit.TabIndex = 49;
            this.linkAdvancedEdit.TabStop = true;
            this.linkAdvancedEdit.Tag = "";
            this.linkAdvancedEdit.Text = "Advanced editor";
            this.linkAdvancedEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAdvancedEdit.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkRestoreDefault
            // 
            this.linkRestoreDefault.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkRestoreDefault.AutoSize = true;
            this.linkRestoreDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRestoreDefault.ForeColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.Location = new System.Drawing.Point(323, 369);
            this.linkRestoreDefault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRestoreDefault.Name = "linkRestoreDefault";
            this.linkRestoreDefault.Size = new System.Drawing.Size(123, 21);
            this.linkRestoreDefault.TabIndex = 51;
            this.linkRestoreDefault.TabStop = true;
            this.linkRestoreDefault.Tag = "";
            this.linkRestoreDefault.Text = "Restore default";
            this.linkRestoreDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkRestoreDefault.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // lblLock
            // 
            this.lblLock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLock.ForeColor = System.Drawing.Color.Silver;
            this.lblLock.Location = new System.Drawing.Point(325, 234);
            this.lblLock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(315, 55);
            this.lblLock.TabIndex = 62;
            this.lblLock.Tag = "";
            this.lblLock.Text = "Protect your HOSTS file by locking it.";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chkReadOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadOnly.ForeColor = System.Drawing.Color.White;
            this.chkReadOnly.Location = new System.Drawing.Point(329, 207);
            this.chkReadOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(110, 25);
            this.chkReadOnly.TabIndex = 61;
            this.chkReadOnly.Text = "Read-only";
            this.chkReadOnly.UseVisualStyleBackColor = false;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelList.Controls.Add(this.listHostEntries);
            this.panelList.Location = new System.Drawing.Point(5, 3);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(312, 388);
            this.panelList.TabIndex = 60;
            // 
            // listHostEntries
            // 
            this.listHostEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listHostEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHostEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHostEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listHostEntries.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHostEntries.ForeColor = System.Drawing.Color.White;
            this.listHostEntries.FormattingEnabled = true;
            this.listHostEntries.HorizontalScrollbar = true;
            this.listHostEntries.ItemHeight = 21;
            this.listHostEntries.Location = new System.Drawing.Point(0, 0);
            this.listHostEntries.Margin = new System.Windows.Forms.Padding(2);
            this.listHostEntries.Name = "listHostEntries";
            this.listHostEntries.Size = new System.Drawing.Size(310, 386);
            this.listHostEntries.TabIndex = 52;
            // 
            // chkBlock
            // 
            this.chkBlock.AutoSize = true;
            this.chkBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chkBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlock.ForeColor = System.Drawing.Color.White;
            this.chkBlock.Location = new System.Drawing.Point(329, 110);
            this.chkBlock.Margin = new System.Windows.Forms.Padding(2);
            this.chkBlock.Name = "chkBlock";
            this.chkBlock.Size = new System.Drawing.Size(76, 25);
            this.chkBlock.TabIndex = 59;
            this.chkBlock.Text = "Block";
            this.chkBlock.UseVisualStyleBackColor = false;
            this.chkBlock.CheckedChanged += new System.EventHandler(this.chkBlock_CheckedChanged);
            // 
            // refreshHostsB
            // 
            this.refreshHostsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.refreshHostsB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshHostsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshHostsB.Location = new System.Drawing.Point(5, 395);
            this.refreshHostsB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshHostsB.Name = "refreshHostsB";
            this.refreshHostsB.Size = new System.Drawing.Size(152, 31);
            this.refreshHostsB.TabIndex = 55;
            this.refreshHostsB.Text = "Refresh";
            this.refreshHostsB.UseVisualStyleBackColor = false;
            this.refreshHostsB.Click += new System.EventHandler(this.button41_Click);
            // 
            // removeHostB
            // 
            this.removeHostB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeHostB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeHostB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeHostB.Location = new System.Drawing.Point(161, 395);
            this.removeHostB.Margin = new System.Windows.Forms.Padding(2);
            this.removeHostB.Name = "removeHostB";
            this.removeHostB.Size = new System.Drawing.Size(156, 31);
            this.removeHostB.TabIndex = 54;
            this.removeHostB.Text = "Delete";
            this.removeHostB.UseVisualStyleBackColor = false;
            this.removeHostB.Click += new System.EventHandler(this.button42_Click);
            // 
            // removeAllHostsB
            // 
            this.removeAllHostsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.removeAllHostsB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAllHostsB.Enabled = false;
            this.removeAllHostsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllHostsB.Location = new System.Drawing.Point(161, 430);
            this.removeAllHostsB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllHostsB.Name = "removeAllHostsB";
            this.removeAllHostsB.Size = new System.Drawing.Size(156, 31);
            this.removeAllHostsB.TabIndex = 53;
            this.removeAllHostsB.Text = "Delete all";
            this.removeAllHostsB.UseVisualStyleBackColor = false;
            this.removeAllHostsB.Visible = false;
            this.removeAllHostsB.Click += new System.EventHandler(this.button46_Click);
            // 
            // addHostB
            // 
            this.addHostB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addHostB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addHostB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHostB.Kind = Optimizer.ButtonKind.Primary;
            this.addHostB.Location = new System.Drawing.Point(511, 110);
            this.addHostB.Margin = new System.Windows.Forms.Padding(2);
            this.addHostB.Name = "addHostB";
            this.addHostB.Size = new System.Drawing.Size(127, 31);
            this.addHostB.TabIndex = 57;
            this.addHostB.Text = "Add";
            this.addHostB.UseVisualStyleBackColor = false;
            this.addHostB.Click += new System.EventHandler(this.button47_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.Location = new System.Drawing.Point(328, 23);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(310, 29);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.ForeColor = System.Drawing.Color.White;
            this.txtDomain.Location = new System.Drawing.Point(328, 77);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(310, 29);
            this.txtDomain.TabIndex = 1;
            this.txtDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDomain.Location = new System.Drawing.Point(323, 54);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(66, 21);
            this.lblDomain.TabIndex = 55;
            this.lblDomain.Tag = "themeable";
            this.lblDomain.Text = "Domain";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIP.Location = new System.Drawing.Point(323, 0);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(85, 21);
            this.lblIP.TabIndex = 53;
            this.lblIP.Tag = "themeable";
            this.lblIP.Text = "IP address";
            // 
            // hostsTitle
            // 
            this.hostsTitle.AutoSize = true;
            this.hostsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hostsTitle.Location = new System.Drawing.Point(6, 10);
            this.hostsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostsTitle.Name = "hostsTitle";
            this.hostsTitle.Size = new System.Drawing.Size(182, 28);
            this.hostsTitle.TabIndex = 3;
            this.hostsTitle.Tag = "themeable";
            this.hostsTitle.Text = "Edit your hosts file";
            // 
            // linkLocate
            // 
            this.linkLocate.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLocate.AutoSize = true;
            this.linkLocate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLocate.ForeColor = System.Drawing.Color.Silver;
            this.linkLocate.LinkColor = System.Drawing.Color.Silver;
            this.linkLocate.Location = new System.Drawing.Point(8, 38);
            this.linkLocate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLocate.Name = "linkLocate";
            this.linkLocate.Size = new System.Drawing.Size(59, 21);
            this.linkLocate.TabIndex = 47;
            this.linkLocate.TabStop = true;
            this.linkLocate.Tag = "";
            this.linkLocate.Text = "Locate";
            this.linkLocate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLocate.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLocate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // registryFixerTab
            // 
            this.registryFixerTab.AutoScroll = true;
            this.registryFixerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.registryFixerTab.Controls.Add(this.panel2);
            this.registryFixerTab.Controls.Add(this.registryTitle);
            this.registryFixerTab.Location = new System.Drawing.Point(4, 25);
            this.registryFixerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Name = "registryFixerTab";
            this.registryFixerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Size = new System.Drawing.Size(1274, 675);
            this.registryFixerTab.TabIndex = 8;
            this.registryFixerTab.Text = "Registry";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.regFixB);
            this.panel2.Controls.Add(this.regLbl);
            this.panel2.Controls.Add(this.checkRestartExplorer);
            this.panel2.Controls.Add(this.checkRegistryEditor);
            this.panel2.Controls.Add(this.checkEnableAll);
            this.panel2.Controls.Add(this.checkContextMenu);
            this.panel2.Controls.Add(this.checkTaskManager);
            this.panel2.Controls.Add(this.checkCommandPrompt);
            this.panel2.Controls.Add(this.checkFirewall);
            this.panel2.Controls.Add(this.checkRunDialog);
            this.panel2.Controls.Add(this.checkFolderOptions);
            this.panel2.Controls.Add(this.checkControlPanel);
            this.panel2.Location = new System.Drawing.Point(11, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 286);
            this.panel2.TabIndex = 48;
            // 
            // regFixB
            // 
            this.regFixB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.regFixB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regFixB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regFixB.Kind = Optimizer.ButtonKind.Primary;
            this.regFixB.Location = new System.Drawing.Point(29, 252);
            this.regFixB.Margin = new System.Windows.Forms.Padding(2);
            this.regFixB.Name = "regFixB";
            this.regFixB.Size = new System.Drawing.Size(154, 31);
            this.regFixB.TabIndex = 49;
            this.regFixB.Text = "Fix";
            this.regFixB.UseVisualStyleBackColor = false;
            this.regFixB.Click += new System.EventHandler(this.button33_Click);
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLbl.ForeColor = System.Drawing.Color.Silver;
            this.regLbl.Location = new System.Drawing.Point(94, 208);
            this.regLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(236, 21);
            this.regLbl.TabIndex = 51;
            this.regLbl.Tag = "";
            this.regLbl.Text = "(some changes might need this)";
            this.regLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkRestartExplorer
            // 
            this.checkRestartExplorer.AutoSize = true;
            this.checkRestartExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkRestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.checkRestartExplorer.Location = new System.Drawing.Point(29, 181);
            this.checkRestartExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.checkRestartExplorer.Name = "checkRestartExplorer";
            this.checkRestartExplorer.Size = new System.Drawing.Size(313, 25);
            this.checkRestartExplorer.TabIndex = 50;
            this.checkRestartExplorer.Tag = "";
            this.checkRestartExplorer.Text = "Also restart Explorer to apply changes";
            this.checkRestartExplorer.UseVisualStyleBackColor = false;
            // 
            // checkRegistryEditor
            // 
            this.checkRegistryEditor.AutoSize = true;
            this.checkRegistryEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkRegistryEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegistryEditor.ForeColor = System.Drawing.Color.White;
            this.checkRegistryEditor.Location = new System.Drawing.Point(291, 136);
            this.checkRegistryEditor.Margin = new System.Windows.Forms.Padding(2);
            this.checkRegistryEditor.Name = "checkRegistryEditor";
            this.checkRegistryEditor.Size = new System.Drawing.Size(145, 25);
            this.checkRegistryEditor.TabIndex = 38;
            this.checkRegistryEditor.Text = "Registry Editor";
            this.checkRegistryEditor.UseVisualStyleBackColor = false;
            // 
            // checkEnableAll
            // 
            this.checkEnableAll.AutoSize = true;
            this.checkEnableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkEnableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnableAll.ForeColor = System.Drawing.Color.White;
            this.checkEnableAll.Location = new System.Drawing.Point(29, 14);
            this.checkEnableAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkEnableAll.Name = "checkEnableAll";
            this.checkEnableAll.Size = new System.Drawing.Size(104, 25);
            this.checkEnableAll.TabIndex = 35;
            this.checkEnableAll.Tag = "";
            this.checkEnableAll.Text = "Enable all";
            this.checkEnableAll.UseVisualStyleBackColor = false;
            this.checkEnableAll.CheckedChanged += new System.EventHandler(this.checkEnableAll_CheckedChanged);
            // 
            // checkContextMenu
            // 
            this.checkContextMenu.AutoSize = true;
            this.checkContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkContextMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkContextMenu.ForeColor = System.Drawing.Color.White;
            this.checkContextMenu.Location = new System.Drawing.Point(291, 75);
            this.checkContextMenu.Margin = new System.Windows.Forms.Padding(2);
            this.checkContextMenu.Name = "checkContextMenu";
            this.checkContextMenu.Size = new System.Drawing.Size(158, 25);
            this.checkContextMenu.TabIndex = 43;
            this.checkContextMenu.Text = "Right Click menu";
            this.checkContextMenu.UseVisualStyleBackColor = false;
            // 
            // checkTaskManager
            // 
            this.checkTaskManager.AutoSize = true;
            this.checkTaskManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkTaskManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaskManager.ForeColor = System.Drawing.Color.White;
            this.checkTaskManager.Location = new System.Drawing.Point(55, 45);
            this.checkTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.checkTaskManager.Name = "checkTaskManager";
            this.checkTaskManager.Size = new System.Drawing.Size(135, 25);
            this.checkTaskManager.TabIndex = 36;
            this.checkTaskManager.Text = "Task Manager";
            this.checkTaskManager.UseVisualStyleBackColor = false;
            // 
            // checkCommandPrompt
            // 
            this.checkCommandPrompt.AutoSize = true;
            this.checkCommandPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkCommandPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCommandPrompt.ForeColor = System.Drawing.Color.White;
            this.checkCommandPrompt.Location = new System.Drawing.Point(55, 75);
            this.checkCommandPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.checkCommandPrompt.Name = "checkCommandPrompt";
            this.checkCommandPrompt.Size = new System.Drawing.Size(170, 25);
            this.checkCommandPrompt.TabIndex = 42;
            this.checkCommandPrompt.Text = "Command Prompt";
            this.checkCommandPrompt.UseVisualStyleBackColor = false;
            // 
            // checkFirewall
            // 
            this.checkFirewall.AutoSize = true;
            this.checkFirewall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkFirewall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFirewall.ForeColor = System.Drawing.Color.White;
            this.checkFirewall.Location = new System.Drawing.Point(291, 106);
            this.checkFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.checkFirewall.Name = "checkFirewall";
            this.checkFirewall.Size = new System.Drawing.Size(162, 25);
            this.checkFirewall.TabIndex = 37;
            this.checkFirewall.Text = "Windows Firewall";
            this.checkFirewall.UseVisualStyleBackColor = false;
            // 
            // checkRunDialog
            // 
            this.checkRunDialog.AutoSize = true;
            this.checkRunDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkRunDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRunDialog.ForeColor = System.Drawing.Color.White;
            this.checkRunDialog.Location = new System.Drawing.Point(291, 45);
            this.checkRunDialog.Margin = new System.Windows.Forms.Padding(2);
            this.checkRunDialog.Name = "checkRunDialog";
            this.checkRunDialog.Size = new System.Drawing.Size(115, 25);
            this.checkRunDialog.TabIndex = 41;
            this.checkRunDialog.Text = "Run Dialog";
            this.checkRunDialog.UseVisualStyleBackColor = false;
            // 
            // checkFolderOptions
            // 
            this.checkFolderOptions.AutoSize = true;
            this.checkFolderOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkFolderOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFolderOptions.ForeColor = System.Drawing.Color.White;
            this.checkFolderOptions.Location = new System.Drawing.Point(55, 136);
            this.checkFolderOptions.Margin = new System.Windows.Forms.Padding(2);
            this.checkFolderOptions.Name = "checkFolderOptions";
            this.checkFolderOptions.Size = new System.Drawing.Size(145, 25);
            this.checkFolderOptions.TabIndex = 39;
            this.checkFolderOptions.Text = "Folder Options";
            this.checkFolderOptions.UseVisualStyleBackColor = false;
            // 
            // checkControlPanel
            // 
            this.checkControlPanel.AutoSize = true;
            this.checkControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkControlPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkControlPanel.ForeColor = System.Drawing.Color.White;
            this.checkControlPanel.Location = new System.Drawing.Point(55, 106);
            this.checkControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.checkControlPanel.Name = "checkControlPanel";
            this.checkControlPanel.Size = new System.Drawing.Size(134, 25);
            this.checkControlPanel.TabIndex = 40;
            this.checkControlPanel.Text = "Control Panel";
            this.checkControlPanel.UseVisualStyleBackColor = false;
            // 
            // registryTitle
            // 
            this.registryTitle.AutoSize = true;
            this.registryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registryTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registryTitle.Location = new System.Drawing.Point(6, 10);
            this.registryTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registryTitle.Name = "registryTitle";
            this.registryTitle.Size = new System.Drawing.Size(260, 28);
            this.registryTitle.TabIndex = 47;
            this.registryTitle.Tag = "themeable";
            this.registryTitle.Text = "Fix common registry issues";
            // 
            // indiciumTab
            // 
            this.indiciumTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.indiciumTab.Controls.Add(this.panel12);
            this.indiciumTab.Controls.Add(this.panel11);
            this.indiciumTab.Location = new System.Drawing.Point(4, 25);
            this.indiciumTab.Name = "indiciumTab";
            this.indiciumTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.indiciumTab.Size = new System.Drawing.Size(1274, 675);
            this.indiciumTab.TabIndex = 14;
            this.indiciumTab.Text = "Hardware";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.specsTree);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 56);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1029, 563);
            this.panel12.TabIndex = 2;
            // 
            // specsTree
            // 
            this.specsTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.specsTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specsTree.ContextMenuStrip = this.indiciumMenu;
            this.specsTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specsTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.specsTree.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specsTree.ForeColor = System.Drawing.Color.White;
            this.specsTree.Location = new System.Drawing.Point(0, 0);
            this.specsTree.Name = "specsTree";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "cpu";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "Processors";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "ram";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Memory";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "gpu";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Graphics";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "mobo";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Motherboard";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "disk";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Storage";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "inet";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "Network Adapters";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "audio";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "Audio";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "dev";
            treeNode8.SelectedImageIndex = 7;
            treeNode8.Text = "Peripherals";
            this.specsTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.specsTree.Size = new System.Drawing.Size(1027, 561);
            this.specsTree.TabIndex = 0;
            this.specsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.specsTree_NodeMouseClick);
            // 
            // indiciumMenu
            // 
            this.indiciumMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.indiciumMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indiciumMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.indiciumMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHWCopy,
            this.toolHWGoogle,
            this.toolHWDuck});
            this.indiciumMenu.Name = "launcherMenu";
            this.indiciumMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.indiciumMenu.ShowImageMargin = false;
            this.indiciumMenu.Size = new System.Drawing.Size(223, 76);
            // 
            // toolHWCopy
            // 
            this.toolHWCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWCopy.ForeColor = System.Drawing.Color.White;
            this.toolHWCopy.Name = "toolHWCopy";
            this.toolHWCopy.Size = new System.Drawing.Size(222, 24);
            this.toolHWCopy.Text = "Copy";
            this.toolHWCopy.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolHWCopy.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolHWGoogle
            // 
            this.toolHWGoogle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWGoogle.ForeColor = System.Drawing.Color.White;
            this.toolHWGoogle.Name = "toolHWGoogle";
            this.toolHWGoogle.Size = new System.Drawing.Size(222, 24);
            this.toolHWGoogle.Text = "Search with Google...";
            this.toolHWGoogle.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolHWGoogle.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolHWDuck
            // 
            this.toolHWDuck.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWDuck.ForeColor = System.Drawing.Color.White;
            this.toolHWDuck.Name = "toolHWDuck";
            this.toolHWDuck.Size = new System.Drawing.Size(222, 24);
            this.toolHWDuck.Text = "Search with DuckDuckGo...";
            this.toolHWDuck.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolHWDuck.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.btnCopyHW);
            this.panel11.Controls.Add(this.btnSaveHW);
            this.panel11.Controls.Add(this.hwDetailed);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1029, 53);
            this.panel11.TabIndex = 1;
            // 
            // btnCopyHW
            // 
            this.btnCopyHW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyHW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCopyHW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyHW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHW.Location = new System.Drawing.Point(879, 14);
            this.btnCopyHW.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyHW.Name = "btnCopyHW";
            this.btnCopyHW.Size = new System.Drawing.Size(146, 24);
            this.btnCopyHW.TabIndex = 163;
            this.btnCopyHW.Text = "Copy";
            this.btnCopyHW.UseVisualStyleBackColor = false;
            this.btnCopyHW.Click += new System.EventHandler(this.btnCopyHW_Click);
            // 
            // btnSaveHW
            // 
            this.btnSaveHW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSaveHW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveHW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHW.Location = new System.Drawing.Point(727, 14);
            this.btnSaveHW.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveHW.Name = "btnSaveHW";
            this.btnSaveHW.Size = new System.Drawing.Size(146, 24);
            this.btnSaveHW.TabIndex = 162;
            this.btnSaveHW.Text = "Save";
            this.btnSaveHW.UseVisualStyleBackColor = false;
            this.btnSaveHW.Click += new System.EventHandler(this.btnSaveHW_Click);
            // 
            // hwDetailed
            // 
            this.hwDetailed.AccessibleName = "Detailed View";
            this.hwDetailed.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hwDetailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hwDetailed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwDetailed.ForeColor = System.Drawing.Color.White;
            this.hwDetailed.LabelText = "Detailed View";
            this.hwDetailed.Location = new System.Drawing.Point(5, 5);
            this.hwDetailed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hwDetailed.Name = "hwDetailed";
            this.hwDetailed.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.hwDetailed.Size = new System.Drawing.Size(374, 42);
            this.hwDetailed.TabIndex = 89;
            this.hwDetailed.Tag = "themeable";
            this.hwDetailed.ToggleChecked = true;
            this.hwDetailed.ToggleClicked += new System.EventHandler(this.hwDetailed_ToggleClicked);
            // 
            // integratorTab
            // 
            this.integratorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.integratorTab.Controls.Add(this.synapse);
            this.integratorTab.Location = new System.Drawing.Point(4, 25);
            this.integratorTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorTab.Name = "integratorTab";
            this.integratorTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorTab.Size = new System.Drawing.Size(1274, 675);
            this.integratorTab.TabIndex = 10;
            this.integratorTab.Text = "Integrator";
            // 
            // synapse
            // 
            this.synapse.Controls.Add(this.integratorInfoTab);
            this.synapse.Controls.Add(this.tabPage8);
            this.synapse.Controls.Add(this.tabPage9);
            this.synapse.Controls.Add(this.tabPage10);
            this.synapse.Controls.Add(this.tabPage11);
            this.synapse.Controls.Add(this.tabPage4);
            this.synapse.Controls.Add(this.tabPage3);
            this.synapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synapse.Location = new System.Drawing.Point(2, 2);
            this.synapse.Margin = new System.Windows.Forms.Padding(0);
            this.synapse.Multiline = true;
            this.synapse.Name = "synapse";
            this.synapse.Padding = new System.Drawing.Point(0, 0);
            this.synapse.SelectedIndex = 0;
            this.synapse.Size = new System.Drawing.Size(1031, 618);
            this.synapse.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.synapse.TabIndex = 0;
            // 
            // integratorInfoTab
            // 
            this.integratorInfoTab.AutoScroll = true;
            this.integratorInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.integratorInfoTab.Controls.Add(this.integrator7);
            this.integratorInfoTab.Controls.Add(this.integrator6);
            this.integratorInfoTab.Controls.Add(this.integrator5);
            this.integratorInfoTab.Controls.Add(this.integrator4);
            this.integratorInfoTab.Controls.Add(this.integrator3);
            this.integratorInfoTab.Controls.Add(this.integrator2);
            this.integratorInfoTab.Controls.Add(this.integrator1);
            this.integratorInfoTab.Location = new System.Drawing.Point(4, 25);
            this.integratorInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Name = "integratorInfoTab";
            this.integratorInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Size = new System.Drawing.Size(1023, 589);
            this.integratorInfoTab.TabIndex = 0;
            this.integratorInfoTab.Text = "Info";
            // 
            // integrator7
            // 
            this.integrator7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator7.ForeColor = System.Drawing.Color.Silver;
            this.integrator7.Location = new System.Drawing.Point(6, 225);
            this.integrator7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator7.Name = "integrator7";
            this.integrator7.Size = new System.Drawing.Size(763, 309);
            this.integrator7.TabIndex = 10;
            this.integrator7.Tag = "";
            this.integrator7.Text = resources.GetString("integrator7.Text");
            // 
            // integrator6
            // 
            this.integrator6.AutoSize = true;
            this.integrator6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator6.ForeColor = System.Drawing.Color.Silver;
            this.integrator6.Location = new System.Drawing.Point(38, 183);
            this.integrator6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator6.Name = "integrator6";
            this.integrator6.Size = new System.Drawing.Size(103, 21);
            this.integrator6.TabIndex = 9;
            this.integrator6.Tag = "";
            this.integrator6.Text = "• Commands";
            // 
            // integrator5
            // 
            this.integrator5.AutoSize = true;
            this.integrator5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator5.ForeColor = System.Drawing.Color.Silver;
            this.integrator5.Location = new System.Drawing.Point(38, 158);
            this.integrator5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator5.Name = "integrator5";
            this.integrator5.Size = new System.Drawing.Size(133, 21);
            this.integrator5.TabIndex = 8;
            this.integrator5.Tag = "";
            this.integrator5.Text = "• Any type of file";
            // 
            // integrator4
            // 
            this.integrator4.AutoSize = true;
            this.integrator4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator4.ForeColor = System.Drawing.Color.Silver;
            this.integrator4.Location = new System.Drawing.Point(38, 132);
            this.integrator4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator4.Name = "integrator4";
            this.integrator4.Size = new System.Drawing.Size(156, 21);
            this.integrator4.TabIndex = 7;
            this.integrator4.Tag = "";
            this.integrator4.Text = "• Links to webpages";
            // 
            // integrator3
            // 
            this.integrator3.AutoSize = true;
            this.integrator3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator3.ForeColor = System.Drawing.Color.Silver;
            this.integrator3.Location = new System.Drawing.Point(38, 106);
            this.integrator3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator3.Name = "integrator3";
            this.integrator3.Size = new System.Drawing.Size(167, 21);
            this.integrator3.TabIndex = 6;
            this.integrator3.Tag = "";
            this.integrator3.Text = "• Shortcuts to folders";
            // 
            // integrator2
            // 
            this.integrator2.AutoSize = true;
            this.integrator2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator2.ForeColor = System.Drawing.Color.Silver;
            this.integrator2.Location = new System.Drawing.Point(38, 81);
            this.integrator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator2.Name = "integrator2";
            this.integrator2.Size = new System.Drawing.Size(117, 21);
            this.integrator2.TabIndex = 5;
            this.integrator2.Tag = "";
            this.integrator2.Text = "• Any program";
            // 
            // integrator1
            // 
            this.integrator1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator1.ForeColor = System.Drawing.Color.Silver;
            this.integrator1.Location = new System.Drawing.Point(6, 10);
            this.integrator1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator1.Name = "integrator1";
            this.integrator1.Size = new System.Drawing.Size(811, 61);
            this.integrator1.TabIndex = 4;
            this.integrator1.Tag = "";
            this.integrator1.Text = "Integrator is able to add fully-customized items in Desktop right-click menu:";
            // 
            // tabPage8
            // 
            this.tabPage8.AutoScroll = true;
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage8.Controls.Add(this.btnAddItem);
            this.tabPage8.Controls.Add(this.itemnamegroup);
            this.tabPage8.Controls.Add(this.security);
            this.tabPage8.Controls.Add(this.itemposition);
            this.tabPage8.Controls.Add(this.icontoaddgroup);
            this.tabPage8.Controls.Add(this.itemtoaddgroup);
            this.tabPage8.Controls.Add(this.itemtype);
            this.tabPage8.Controls.Add(this.addItemL);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(1263, 643);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Add/Modify";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Kind = Optimizer.ButtonKind.Primary;
            this.btnAddItem.Location = new System.Drawing.Point(436, 473);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(202, 31);
            this.btnAddItem.TabIndex = 85;
            this.btnAddItem.Text = "Add/Modify";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // itemnamegroup
            // 
            this.itemnamegroup.Controls.Add(this.txtItemName);
            this.itemnamegroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamegroup.ForeColor = System.Drawing.Color.Silver;
            this.itemnamegroup.Location = new System.Drawing.Point(11, 403);
            this.itemnamegroup.Margin = new System.Windows.Forms.Padding(2);
            this.itemnamegroup.Name = "itemnamegroup";
            this.itemnamegroup.Padding = new System.Windows.Forms.Padding(2);
            this.itemnamegroup.Size = new System.Drawing.Size(627, 66);
            this.itemnamegroup.TabIndex = 84;
            this.itemnamegroup.TabStop = false;
            this.itemnamegroup.Text = "Item name in menu:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.ForeColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(11, 26);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(476, 29);
            this.txtItemName.TabIndex = 82;
            // 
            // security
            // 
            this.security.Controls.Add(this.checkShift);
            this.security.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security.ForeColor = System.Drawing.Color.Silver;
            this.security.Location = new System.Drawing.Point(11, 338);
            this.security.Margin = new System.Windows.Forms.Padding(2);
            this.security.Name = "security";
            this.security.Padding = new System.Windows.Forms.Padding(2);
            this.security.Size = new System.Drawing.Size(627, 61);
            this.security.TabIndex = 83;
            this.security.TabStop = false;
            this.security.Text = "Security:";
            // 
            // checkShift
            // 
            this.checkShift.AutoSize = true;
            this.checkShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkShift.ForeColor = System.Drawing.Color.White;
            this.checkShift.Location = new System.Drawing.Point(11, 26);
            this.checkShift.Margin = new System.Windows.Forms.Padding(2);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(307, 25);
            this.checkShift.TabIndex = 83;
            this.checkShift.Text = "Show only when SHIFT key is pressed";
            this.checkShift.UseVisualStyleBackColor = false;
            // 
            // itemposition
            // 
            this.itemposition.Controls.Add(this.radioTop);
            this.itemposition.Controls.Add(this.radioMiddle);
            this.itemposition.Controls.Add(this.radioBottom);
            this.itemposition.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemposition.ForeColor = System.Drawing.Color.Silver;
            this.itemposition.Location = new System.Drawing.Point(11, 272);
            this.itemposition.Margin = new System.Windows.Forms.Padding(2);
            this.itemposition.Name = "itemposition";
            this.itemposition.Padding = new System.Windows.Forms.Padding(2);
            this.itemposition.Size = new System.Drawing.Size(627, 62);
            this.itemposition.TabIndex = 82;
            this.itemposition.TabStop = false;
            this.itemposition.Text = "Item position:";
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioTop.ForeColor = System.Drawing.Color.White;
            this.radioTop.Location = new System.Drawing.Point(11, 26);
            this.radioTop.Margin = new System.Windows.Forms.Padding(2);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(63, 25);
            this.radioTop.TabIndex = 83;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = false;
            this.radioTop.CheckedChanged += new System.EventHandler(this.radioTop_CheckedChanged);
            // 
            // radioMiddle
            // 
            this.radioMiddle.AutoSize = true;
            this.radioMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioMiddle.ForeColor = System.Drawing.Color.White;
            this.radioMiddle.Location = new System.Drawing.Point(131, 26);
            this.radioMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.radioMiddle.Name = "radioMiddle";
            this.radioMiddle.Size = new System.Drawing.Size(88, 25);
            this.radioMiddle.TabIndex = 84;
            this.radioMiddle.Text = "Middle";
            this.radioMiddle.UseVisualStyleBackColor = false;
            this.radioMiddle.CheckedChanged += new System.EventHandler(this.radioMiddle_CheckedChanged);
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioBottom.ForeColor = System.Drawing.Color.White;
            this.radioBottom.Location = new System.Drawing.Point(277, 26);
            this.radioBottom.Margin = new System.Windows.Forms.Padding(2);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(92, 25);
            this.radioBottom.TabIndex = 85;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = false;
            this.radioBottom.CheckedChanged += new System.EventHandler(this.radioBottom_CheckedChanged);
            // 
            // icontoaddgroup
            // 
            this.icontoaddgroup.Controls.Add(this.checkDefaultIcon);
            this.icontoaddgroup.Controls.Add(this.btnBrowseIcon);
            this.icontoaddgroup.Controls.Add(this.txtIcon);
            this.icontoaddgroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icontoaddgroup.ForeColor = System.Drawing.Color.Silver;
            this.icontoaddgroup.Location = new System.Drawing.Point(11, 178);
            this.icontoaddgroup.Margin = new System.Windows.Forms.Padding(2);
            this.icontoaddgroup.Name = "icontoaddgroup";
            this.icontoaddgroup.Padding = new System.Windows.Forms.Padding(2);
            this.icontoaddgroup.Size = new System.Drawing.Size(627, 90);
            this.icontoaddgroup.TabIndex = 81;
            this.icontoaddgroup.TabStop = false;
            this.icontoaddgroup.Text = "Icon to add:";
            // 
            // checkDefaultIcon
            // 
            this.checkDefaultIcon.AutoSize = true;
            this.checkDefaultIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkDefaultIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.checkDefaultIcon.ForeColor = System.Drawing.Color.White;
            this.checkDefaultIcon.Location = new System.Drawing.Point(11, 58);
            this.checkDefaultIcon.Margin = new System.Windows.Forms.Padding(2);
            this.checkDefaultIcon.Name = "checkDefaultIcon";
            this.checkDefaultIcon.Size = new System.Drawing.Size(176, 25);
            this.checkDefaultIcon.TabIndex = 82;
            this.checkDefaultIcon.Text = "Use program\'s icon";
            this.checkDefaultIcon.UseVisualStyleBackColor = false;
            this.checkDefaultIcon.CheckedChanged += new System.EventHandler(this.checkDefaultIcon_CheckedChanged);
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBrowseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseIcon.Enabled = false;
            this.btnBrowseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseIcon.Location = new System.Drawing.Point(450, 26);
            this.btnBrowseIcon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(36, 29);
            this.btnBrowseIcon.TabIndex = 82;
            this.btnBrowseIcon.Text = "...";
            this.btnBrowseIcon.UseVisualStyleBackColor = false;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // txtIcon
            // 
            this.txtIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIcon.Enabled = false;
            this.txtIcon.ForeColor = System.Drawing.Color.White;
            this.txtIcon.Location = new System.Drawing.Point(11, 26);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(2);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = true;
            this.txtIcon.Size = new System.Drawing.Size(434, 29);
            this.txtIcon.TabIndex = 81;
            // 
            // itemtoaddgroup
            // 
            this.itemtoaddgroup.Controls.Add(this.btnBrowseItem);
            this.itemtoaddgroup.Controls.Add(this.txtItem);
            this.itemtoaddgroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtoaddgroup.ForeColor = System.Drawing.Color.Silver;
            this.itemtoaddgroup.Location = new System.Drawing.Point(11, 107);
            this.itemtoaddgroup.Margin = new System.Windows.Forms.Padding(2);
            this.itemtoaddgroup.Name = "itemtoaddgroup";
            this.itemtoaddgroup.Padding = new System.Windows.Forms.Padding(2);
            this.itemtoaddgroup.Size = new System.Drawing.Size(627, 67);
            this.itemtoaddgroup.TabIndex = 80;
            this.itemtoaddgroup.TabStop = false;
            this.itemtoaddgroup.Text = "Program to add:";
            // 
            // btnBrowseItem
            // 
            this.btnBrowseItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBrowseItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseItem.Location = new System.Drawing.Point(449, 26);
            this.btnBrowseItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseItem.Name = "btnBrowseItem";
            this.btnBrowseItem.Size = new System.Drawing.Size(36, 29);
            this.btnBrowseItem.TabIndex = 82;
            this.btnBrowseItem.Text = "...";
            this.btnBrowseItem.UseVisualStyleBackColor = false;
            this.btnBrowseItem.Click += new System.EventHandler(this.btnBrowseItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.ForeColor = System.Drawing.Color.White;
            this.txtItem.Location = new System.Drawing.Point(11, 26);
            this.txtItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(434, 29);
            this.txtItem.TabIndex = 81;
            // 
            // itemtype
            // 
            this.itemtype.Controls.Add(this.radioCommand);
            this.itemtype.Controls.Add(this.radioProgram);
            this.itemtype.Controls.Add(this.radioFolder);
            this.itemtype.Controls.Add(this.radioLink);
            this.itemtype.Controls.Add(this.radioFile);
            this.itemtype.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtype.ForeColor = System.Drawing.Color.Silver;
            this.itemtype.Location = new System.Drawing.Point(11, 40);
            this.itemtype.Margin = new System.Windows.Forms.Padding(2);
            this.itemtype.Name = "itemtype";
            this.itemtype.Padding = new System.Windows.Forms.Padding(2);
            this.itemtype.Size = new System.Drawing.Size(627, 63);
            this.itemtype.TabIndex = 79;
            this.itemtype.TabStop = false;
            this.itemtype.Text = "Item Type:";
            // 
            // radioCommand
            // 
            this.radioCommand.AutoSize = true;
            this.radioCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioCommand.ForeColor = System.Drawing.Color.White;
            this.radioCommand.Location = new System.Drawing.Point(481, 26);
            this.radioCommand.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommand.Name = "radioCommand";
            this.radioCommand.Size = new System.Drawing.Size(111, 25);
            this.radioCommand.TabIndex = 84;
            this.radioCommand.Text = "Command";
            this.radioCommand.UseVisualStyleBackColor = false;
            this.radioCommand.CheckedChanged += new System.EventHandler(this.radioCommand_CheckedChanged);
            // 
            // radioProgram
            // 
            this.radioProgram.AutoSize = true;
            this.radioProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioProgram.ForeColor = System.Drawing.Color.White;
            this.radioProgram.Location = new System.Drawing.Point(11, 26);
            this.radioProgram.Margin = new System.Windows.Forms.Padding(2);
            this.radioProgram.Name = "radioProgram";
            this.radioProgram.Size = new System.Drawing.Size(99, 25);
            this.radioProgram.TabIndex = 80;
            this.radioProgram.Text = "Program";
            this.radioProgram.UseVisualStyleBackColor = false;
            this.radioProgram.CheckedChanged += new System.EventHandler(this.radioProgram_CheckedChanged);
            // 
            // radioFolder
            // 
            this.radioFolder.AutoSize = true;
            this.radioFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioFolder.ForeColor = System.Drawing.Color.White;
            this.radioFolder.Location = new System.Drawing.Point(139, 26);
            this.radioFolder.Margin = new System.Windows.Forms.Padding(2);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(83, 25);
            this.radioFolder.TabIndex = 81;
            this.radioFolder.Text = "Folder";
            this.radioFolder.UseVisualStyleBackColor = false;
            this.radioFolder.CheckedChanged += new System.EventHandler(this.radioFolder_CheckedChanged);
            // 
            // radioLink
            // 
            this.radioLink.AutoSize = true;
            this.radioLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioLink.ForeColor = System.Drawing.Color.White;
            this.radioLink.Location = new System.Drawing.Point(254, 26);
            this.radioLink.Margin = new System.Windows.Forms.Padding(2);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(65, 25);
            this.radioLink.TabIndex = 82;
            this.radioLink.Text = "Link";
            this.radioLink.UseVisualStyleBackColor = false;
            this.radioLink.CheckedChanged += new System.EventHandler(this.radioLink_CheckedChanged);
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.radioFile.ForeColor = System.Drawing.Color.White;
            this.radioFile.Location = new System.Drawing.Point(371, 26);
            this.radioFile.Margin = new System.Windows.Forms.Padding(2);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(61, 25);
            this.radioFile.TabIndex = 83;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = false;
            this.radioFile.CheckedChanged += new System.EventHandler(this.radioFile_CheckedChanged);
            // 
            // addItemL
            // 
            this.addItemL.AutoSize = true;
            this.addItemL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addItemL.Location = new System.Drawing.Point(6, 10);
            this.addItemL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addItemL.Name = "addItemL";
            this.addItemL.Size = new System.Drawing.Size(219, 28);
            this.addItemL.TabIndex = 78;
            this.addItemL.Tag = "themeable";
            this.addItemL.Text = "Add or modify an item";
            // 
            // tabPage9
            // 
            this.tabPage9.AutoScroll = true;
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage9.Controls.Add(this.panel5);
            this.tabPage9.Controls.Add(this.refreshIIB);
            this.tabPage9.Controls.Add(this.removeDIB);
            this.tabPage9.Controls.Add(this.removeAllIIB);
            this.tabPage9.Controls.Add(this.removeIntegratorItemsL);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(1263, 643);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Remove";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.listDesktopItems);
            this.panel5.Location = new System.Drawing.Point(11, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 435);
            this.panel5.TabIndex = 82;
            // 
            // listDesktopItems
            // 
            this.listDesktopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listDesktopItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDesktopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDesktopItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listDesktopItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDesktopItems.ForeColor = System.Drawing.Color.White;
            this.listDesktopItems.FormattingEnabled = true;
            this.listDesktopItems.HorizontalScrollbar = true;
            this.listDesktopItems.ItemHeight = 21;
            this.listDesktopItems.Location = new System.Drawing.Point(0, 0);
            this.listDesktopItems.Margin = new System.Windows.Forms.Padding(2);
            this.listDesktopItems.Name = "listDesktopItems";
            this.listDesktopItems.Size = new System.Drawing.Size(291, 433);
            this.listDesktopItems.TabIndex = 78;
            // 
            // refreshIIB
            // 
            this.refreshIIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshIIB.Location = new System.Drawing.Point(308, 80);
            this.refreshIIB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshIIB.Name = "refreshIIB";
            this.refreshIIB.Size = new System.Drawing.Size(185, 31);
            this.refreshIIB.TabIndex = 81;
            this.refreshIIB.Text = "Refresh";
            this.refreshIIB.Click += new System.EventHandler(this.button60_Click);
            // 
            // removeDIB
            // 
            this.removeDIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeDIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDIB.Location = new System.Drawing.Point(308, 45);
            this.removeDIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeDIB.Name = "removeDIB";
            this.removeDIB.Size = new System.Drawing.Size(185, 31);
            this.removeDIB.TabIndex = 80;
            this.removeDIB.Text = "Delete";
            this.removeDIB.Click += new System.EventHandler(this.button61_Click);
            // 
            // removeAllIIB
            // 
            this.removeAllIIB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeAllIIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllIIB.Location = new System.Drawing.Point(308, 115);
            this.removeAllIIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllIIB.Name = "removeAllIIB";
            this.removeAllIIB.Size = new System.Drawing.Size(185, 31);
            this.removeAllIIB.TabIndex = 79;
            this.removeAllIIB.Text = "Delete all";
            this.removeAllIIB.Click += new System.EventHandler(this.button62_Click);
            // 
            // removeIntegratorItemsL
            // 
            this.removeIntegratorItemsL.AutoSize = true;
            this.removeIntegratorItemsL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIntegratorItemsL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.removeIntegratorItemsL.Location = new System.Drawing.Point(6, 10);
            this.removeIntegratorItemsL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeIntegratorItemsL.Name = "removeIntegratorItemsL";
            this.removeIntegratorItemsL.Size = new System.Drawing.Size(300, 28);
            this.removeIntegratorItemsL.TabIndex = 77;
            this.removeIntegratorItemsL.Tag = "themeable";
            this.removeIntegratorItemsL.Text = "Remove existing Desktop items";
            // 
            // tabPage10
            // 
            this.tabPage10.AutoScroll = true;
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage10.Controls.Add(this.WAB);
            this.tabPage10.Controls.Add(this.AddCMDB);
            this.tabPage10.Controls.Add(this.AddOwnerB);
            this.tabPage10.Controls.Add(this.DSB);
            this.tabPage10.Controls.Add(this.SSB);
            this.tabPage10.Controls.Add(this.STB);
            this.tabPage10.Controls.Add(this.PMB);
            this.tabPage10.Controls.Add(this.readyMenusL);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(1263, 643);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "Ready Menus";
            // 
            // WAB
            // 
            this.WAB.AccessibleName = "Add \"Windows Apps\"";
            this.WAB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.WAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.WAB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WAB.ForeColor = System.Drawing.Color.White;
            this.WAB.LabelText = "Add \"Windows Apps\"";
            this.WAB.Location = new System.Drawing.Point(32, 153);
            this.WAB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WAB.Name = "WAB";
            this.WAB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.WAB.Size = new System.Drawing.Size(374, 42);
            this.WAB.TabIndex = 95;
            this.WAB.Tag = "themeable";
            this.WAB.ToggleChecked = false;
            // 
            // AddCMDB
            // 
            this.AddCMDB.AccessibleName = "Add \"Open with CMD\"";
            this.AddCMDB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.AddCMDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddCMDB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCMDB.ForeColor = System.Drawing.Color.White;
            this.AddCMDB.LabelText = "Add \"Open with CMD\"";
            this.AddCMDB.Location = new System.Drawing.Point(32, 358);
            this.AddCMDB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddCMDB.Name = "AddCMDB";
            this.AddCMDB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.AddCMDB.Size = new System.Drawing.Size(374, 42);
            this.AddCMDB.TabIndex = 94;
            this.AddCMDB.Tag = "themeable";
            this.AddCMDB.ToggleChecked = false;
            // 
            // AddOwnerB
            // 
            this.AddOwnerB.AccessibleName = "Add \"Take Ownership\"";
            this.AddOwnerB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.AddOwnerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddOwnerB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOwnerB.ForeColor = System.Drawing.Color.White;
            this.AddOwnerB.LabelText = "Add \"Take Ownership\"";
            this.AddOwnerB.Location = new System.Drawing.Point(32, 311);
            this.AddOwnerB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddOwnerB.Name = "AddOwnerB";
            this.AddOwnerB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.AddOwnerB.Size = new System.Drawing.Size(374, 42);
            this.AddOwnerB.TabIndex = 93;
            this.AddOwnerB.Tag = "themeable";
            this.AddOwnerB.ToggleChecked = false;
            // 
            // DSB
            // 
            this.DSB.AccessibleName = "Add \"Desktop Shortcuts\"";
            this.DSB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.DSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DSB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSB.ForeColor = System.Drawing.Color.White;
            this.DSB.LabelText = "Add \"Desktop Shortcuts\"";
            this.DSB.Location = new System.Drawing.Point(32, 246);
            this.DSB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DSB.Name = "DSB";
            this.DSB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.DSB.Size = new System.Drawing.Size(374, 42);
            this.DSB.TabIndex = 92;
            this.DSB.Tag = "themeable";
            this.DSB.ToggleChecked = false;
            // 
            // SSB
            // 
            this.SSB.AccessibleName = "Add \"System Shortcuts\"";
            this.SSB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.SSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SSB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSB.ForeColor = System.Drawing.Color.White;
            this.SSB.LabelText = "Add \"System Shortcuts\"";
            this.SSB.Location = new System.Drawing.Point(32, 199);
            this.SSB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SSB.Name = "SSB";
            this.SSB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.SSB.Size = new System.Drawing.Size(374, 42);
            this.SSB.TabIndex = 91;
            this.SSB.Tag = "themeable";
            this.SSB.ToggleChecked = false;
            // 
            // STB
            // 
            this.STB.AccessibleName = "Add \"System Tools\"";
            this.STB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.STB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.STB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STB.ForeColor = System.Drawing.Color.White;
            this.STB.LabelText = "Add \"System Tools\"";
            this.STB.Location = new System.Drawing.Point(32, 106);
            this.STB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.STB.Name = "STB";
            this.STB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.STB.Size = new System.Drawing.Size(374, 42);
            this.STB.TabIndex = 90;
            this.STB.Tag = "themeable";
            this.STB.ToggleChecked = false;
            // 
            // PMB
            // 
            this.PMB.AccessibleName = "Add \"Power Menu\"";
            this.PMB.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.PMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PMB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMB.ForeColor = System.Drawing.Color.White;
            this.PMB.LabelText = "Add \"Power Menu\"";
            this.PMB.Location = new System.Drawing.Point(32, 60);
            this.PMB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PMB.Name = "PMB";
            this.PMB.Padding = new System.Windows.Forms.Padding(11, 3, 6, 3);
            this.PMB.Size = new System.Drawing.Size(374, 42);
            this.PMB.TabIndex = 89;
            this.PMB.Tag = "themeable";
            this.PMB.ToggleChecked = false;
            // 
            // readyMenusL
            // 
            this.readyMenusL.AutoSize = true;
            this.readyMenusL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyMenusL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.readyMenusL.Location = new System.Drawing.Point(6, 10);
            this.readyMenusL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readyMenusL.Name = "readyMenusL";
            this.readyMenusL.Size = new System.Drawing.Size(232, 28);
            this.readyMenusL.TabIndex = 76;
            this.readyMenusL.Tag = "themeable";
            this.readyMenusL.Text = "Add ready-made menus";
            // 
            // tabPage11
            // 
            this.tabPage11.AutoScroll = true;
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage11.Controls.Add(this.panel6);
            this.tabPage11.Controls.Add(this.removeCCB);
            this.tabPage11.Controls.Add(this.refreshCCB);
            this.tabPage11.Controls.Add(this.removeCCL);
            this.tabPage11.Controls.Add(this.btnCreateCustomCommand);
            this.tabPage11.Controls.Add(this.button48);
            this.tabPage11.Controls.Add(this.txtRunKeyword);
            this.tabPage11.Controls.Add(this.ccKeywordL);
            this.tabPage11.Controls.Add(this.txtRunFile);
            this.tabPage11.Controls.Add(this.ccFileL);
            this.tabPage11.Controls.Add(this.ccL);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage11.Size = new System.Drawing.Size(1263, 643);
            this.tabPage11.TabIndex = 4;
            this.tabPage11.Text = "Run Dialog";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.listCustomCommands);
            this.panel6.Location = new System.Drawing.Point(11, 210);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 313);
            this.panel6.TabIndex = 84;
            // 
            // listCustomCommands
            // 
            this.listCustomCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listCustomCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCustomCommands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listCustomCommands.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomCommands.ForeColor = System.Drawing.Color.White;
            this.listCustomCommands.FormattingEnabled = true;
            this.listCustomCommands.HorizontalScrollbar = true;
            this.listCustomCommands.ItemHeight = 21;
            this.listCustomCommands.Location = new System.Drawing.Point(0, 0);
            this.listCustomCommands.Margin = new System.Windows.Forms.Padding(2);
            this.listCustomCommands.Name = "listCustomCommands";
            this.listCustomCommands.Size = new System.Drawing.Size(269, 311);
            this.listCustomCommands.TabIndex = 79;
            // 
            // removeCCB
            // 
            this.removeCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCCB.Location = new System.Drawing.Point(286, 210);
            this.removeCCB.Margin = new System.Windows.Forms.Padding(2);
            this.removeCCB.Name = "removeCCB";
            this.removeCCB.Size = new System.Drawing.Size(162, 27);
            this.removeCCB.TabIndex = 82;
            this.removeCCB.Text = "Delete";
            this.removeCCB.Click += new System.EventHandler(this.button26_Click);
            // 
            // refreshCCB
            // 
            this.refreshCCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshCCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCCB.Location = new System.Drawing.Point(286, 241);
            this.refreshCCB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshCCB.Name = "refreshCCB";
            this.refreshCCB.Size = new System.Drawing.Size(162, 27);
            this.refreshCCB.TabIndex = 81;
            this.refreshCCB.Text = "Refresh";
            this.refreshCCB.Click += new System.EventHandler(this.button8_Click);
            // 
            // removeCCL
            // 
            this.removeCCL.AutoSize = true;
            this.removeCCL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCCL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.removeCCL.Location = new System.Drawing.Point(6, 173);
            this.removeCCL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeCCL.Name = "removeCCL";
            this.removeCCL.Size = new System.Drawing.Size(254, 28);
            this.removeCCL.TabIndex = 80;
            this.removeCCL.Tag = "themeable";
            this.removeCCL.Text = "Delete existing commands";
            // 
            // btnCreateCustomCommand
            // 
            this.btnCreateCustomCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCustomCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCustomCommand.Kind = Optimizer.ButtonKind.Primary;
            this.btnCreateCustomCommand.Location = new System.Drawing.Point(299, 130);
            this.btnCreateCustomCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCustomCommand.Name = "btnCreateCustomCommand";
            this.btnCreateCustomCommand.Size = new System.Drawing.Size(149, 29);
            this.btnCreateCustomCommand.TabIndex = 60;
            this.btnCreateCustomCommand.Text = "Create";
            this.btnCreateCustomCommand.Click += new System.EventHandler(this.button50_Click);
            // 
            // button48
            // 
            this.button48.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.Location = new System.Drawing.Point(396, 75);
            this.button48.Margin = new System.Windows.Forms.Padding(2);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(52, 29);
            this.button48.TabIndex = 58;
            this.button48.Text = "...";
            this.button48.Click += new System.EventHandler(this.button48_Click);
            // 
            // txtRunKeyword
            // 
            this.txtRunKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRunKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRunKeyword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunKeyword.ForeColor = System.Drawing.Color.White;
            this.txtRunKeyword.Location = new System.Drawing.Point(11, 130);
            this.txtRunKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRunKeyword.Name = "txtRunKeyword";
            this.txtRunKeyword.Size = new System.Drawing.Size(284, 29);
            this.txtRunKeyword.TabIndex = 9;
            // 
            // ccKeywordL
            // 
            this.ccKeywordL.AutoSize = true;
            this.ccKeywordL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccKeywordL.ForeColor = System.Drawing.Color.Silver;
            this.ccKeywordL.Location = new System.Drawing.Point(7, 105);
            this.ccKeywordL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ccKeywordL.Name = "ccKeywordL";
            this.ccKeywordL.Size = new System.Drawing.Size(79, 21);
            this.ccKeywordL.TabIndex = 8;
            this.ccKeywordL.Text = "Keyword:";
            // 
            // txtRunFile
            // 
            this.txtRunFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRunFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRunFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunFile.ForeColor = System.Drawing.Color.White;
            this.txtRunFile.Location = new System.Drawing.Point(11, 75);
            this.txtRunFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtRunFile.Name = "txtRunFile";
            this.txtRunFile.ReadOnly = true;
            this.txtRunFile.Size = new System.Drawing.Size(381, 29);
            this.txtRunFile.TabIndex = 7;
            // 
            // ccFileL
            // 
            this.ccFileL.AutoSize = true;
            this.ccFileL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccFileL.ForeColor = System.Drawing.Color.Silver;
            this.ccFileL.Location = new System.Drawing.Point(7, 50);
            this.ccFileL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ccFileL.Name = "ccFileL";
            this.ccFileL.Size = new System.Drawing.Size(102, 21);
            this.ccFileL.TabIndex = 6;
            this.ccFileL.Text = "File location:";
            // 
            // ccL
            // 
            this.ccL.AutoSize = true;
            this.ccL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ccL.Location = new System.Drawing.Point(6, 10);
            this.ccL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ccL.Name = "ccL";
            this.ccL.Size = new System.Drawing.Size(298, 28);
            this.ccL.TabIndex = 5;
            this.ccL.Tag = "themeable";
            this.ccL.Text = "Define your custom commands";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage4.Controls.Add(this.panel15);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.txtSysVar);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1263, 643);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "System Variables";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.listSystemVariables);
            this.panel15.Location = new System.Drawing.Point(11, 169);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(624, 313);
            this.panel15.TabIndex = 84;
            // 
            // listSystemVariables
            // 
            this.listSystemVariables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listSystemVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSystemVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSystemVariables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listSystemVariables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSystemVariables.ForeColor = System.Drawing.Color.White;
            this.listSystemVariables.FormattingEnabled = true;
            this.listSystemVariables.HorizontalScrollbar = true;
            this.listSystemVariables.ItemHeight = 21;
            this.listSystemVariables.Location = new System.Drawing.Point(0, 0);
            this.listSystemVariables.Margin = new System.Windows.Forms.Padding(2);
            this.listSystemVariables.Name = "listSystemVariables";
            this.listSystemVariables.Size = new System.Drawing.Size(622, 311);
            this.listSystemVariables.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(307, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 27);
            this.button1.TabIndex = 82;
            this.button1.Text = "Delete";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(473, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 27);
            this.button2.TabIndex = 81;
            this.button2.Text = "Refresh";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(6, 132);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 28);
            this.label21.TabIndex = 80;
            this.label21.Tag = "themeable";
            this.label21.Text = "System Variables";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(473, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 29);
            this.button3.TabIndex = 60;
            this.button3.Text = "Add";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSysVar
            // 
            this.txtSysVar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSysVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSysVar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSysVar.ForeColor = System.Drawing.Color.White;
            this.txtSysVar.Location = new System.Drawing.Point(11, 75);
            this.txtSysVar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSysVar.Name = "txtSysVar";
            this.txtSysVar.Size = new System.Drawing.Size(458, 29);
            this.txtSysVar.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(7, 50);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 21);
            this.label23.TabIndex = 6;
            this.label23.Text = "New system variable path:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(6, 10);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(225, 28);
            this.label24.TabIndex = 5;
            this.label24.Tag = "themeable";
            this.label24.Text = "System Variables editor";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage3.Controls.Add(this.lblFontsNumber);
            this.tabPage3.Controls.Add(this.lblFontsCount);
            this.tabPage3.Controls.Add(this.txtSearchFonts);
            this.tabPage3.Controls.Add(this.btnRestoreFont);
            this.tabPage3.Controls.Add(this.btnSetGlobalFont);
            this.tabPage3.Controls.Add(this.lblCurrentFont);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnRefreshFonts);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.fontSetTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1263, 643);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Fonts";
            // 
            // lblFontsNumber
            // 
            this.lblFontsNumber.AutoSize = true;
            this.lblFontsNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontsNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFontsNumber.Location = new System.Drawing.Point(8, 502);
            this.lblFontsNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFontsNumber.Name = "lblFontsNumber";
            this.lblFontsNumber.Size = new System.Drawing.Size(16, 21);
            this.lblFontsNumber.TabIndex = 93;
            this.lblFontsNumber.Tag = "themeable";
            this.lblFontsNumber.Text = "-";
            // 
            // lblFontsCount
            // 
            this.lblFontsCount.AutoSize = true;
            this.lblFontsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontsCount.ForeColor = System.Drawing.Color.Silver;
            this.lblFontsCount.Location = new System.Drawing.Point(8, 481);
            this.lblFontsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFontsCount.Name = "lblFontsCount";
            this.lblFontsCount.Size = new System.Drawing.Size(122, 21);
            this.lblFontsCount.TabIndex = 92;
            this.lblFontsCount.Tag = "";
            this.lblFontsCount.Text = "Available fonts:";
            // 
            // txtSearchFonts
            // 
            this.txtSearchFonts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSearchFonts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFonts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFonts.ForeColor = System.Drawing.Color.White;
            this.txtSearchFonts.Location = new System.Drawing.Point(11, 127);
            this.txtSearchFonts.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFonts.Name = "txtSearchFonts";
            this.txtSearchFonts.Size = new System.Drawing.Size(271, 29);
            this.txtSearchFonts.TabIndex = 91;
            this.txtSearchFonts.TextChanged += new System.EventHandler(this.txtSearchFonts_TextChanged);
            // 
            // btnRestoreFont
            // 
            this.btnRestoreFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreFont.Location = new System.Drawing.Point(286, 445);
            this.btnRestoreFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreFont.Name = "btnRestoreFont";
            this.btnRestoreFont.Size = new System.Drawing.Size(215, 27);
            this.btnRestoreFont.TabIndex = 90;
            this.btnRestoreFont.Text = "Restore default";
            this.btnRestoreFont.Click += new System.EventHandler(this.btnRestoreFont_Click);
            // 
            // btnSetGlobalFont
            // 
            this.btnSetGlobalFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetGlobalFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetGlobalFont.Kind = Optimizer.ButtonKind.Primary;
            this.btnSetGlobalFont.Location = new System.Drawing.Point(286, 161);
            this.btnSetGlobalFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetGlobalFont.Name = "btnSetGlobalFont";
            this.btnSetGlobalFont.Size = new System.Drawing.Size(215, 27);
            this.btnSetGlobalFont.TabIndex = 89;
            this.btnSetGlobalFont.Text = "Set selected as default";
            this.btnSetGlobalFont.Click += new System.EventHandler(this.btnSetGlobalFont_Click);
            // 
            // lblCurrentFont
            // 
            this.lblCurrentFont.AutoSize = true;
            this.lblCurrentFont.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFont.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCurrentFont.Location = new System.Drawing.Point(8, 75);
            this.lblCurrentFont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentFont.Name = "lblCurrentFont";
            this.lblCurrentFont.Size = new System.Drawing.Size(16, 21);
            this.lblCurrentFont.TabIndex = 88;
            this.lblCurrentFont.Tag = "themeable";
            this.lblCurrentFont.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(8, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 87;
            this.label11.Tag = "";
            this.label11.Text = "Current font:";
            // 
            // btnRefreshFonts
            // 
            this.btnRefreshFonts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFonts.Location = new System.Drawing.Point(286, 128);
            this.btnRefreshFonts.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshFonts.Name = "btnRefreshFonts";
            this.btnRefreshFonts.Size = new System.Drawing.Size(215, 27);
            this.btnRefreshFonts.TabIndex = 86;
            this.btnRefreshFonts.Text = "Refresh";
            this.btnRefreshFonts.Click += new System.EventHandler(this.btnRefreshFonts_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.listFonts);
            this.panel8.Location = new System.Drawing.Point(11, 160);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(271, 313);
            this.panel8.TabIndex = 85;
            // 
            // listFonts
            // 
            this.listFonts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listFonts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listFonts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFonts.ForeColor = System.Drawing.Color.White;
            this.listFonts.FormattingEnabled = true;
            this.listFonts.HorizontalScrollbar = true;
            this.listFonts.ItemHeight = 21;
            this.listFonts.Location = new System.Drawing.Point(0, 0);
            this.listFonts.Margin = new System.Windows.Forms.Padding(2);
            this.listFonts.Name = "listFonts";
            this.listFonts.Size = new System.Drawing.Size(269, 311);
            this.listFonts.TabIndex = 79;
            // 
            // fontSetTitle
            // 
            this.fontSetTitle.AutoSize = true;
            this.fontSetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSetTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fontSetTitle.Location = new System.Drawing.Point(6, 10);
            this.fontSetTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fontSetTitle.Name = "fontSetTitle";
            this.fontSetTitle.Size = new System.Drawing.Size(436, 28);
            this.fontSetTitle.TabIndex = 6;
            this.fontSetTitle.Tag = "themeable";
            this.fontSetTitle.Text = "Set your favorite font as Windows default font";
            // 
            // optionsTab
            // 
            this.optionsTab.AutoScroll = true;
            this.optionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.optionsTab.Controls.Add(this.linkLabel7);
            this.optionsTab.Controls.Add(this.pictureBox7);
            this.optionsTab.Controls.Add(this.linkLabel6);
            this.optionsTab.Controls.Add(this.linkLabel4);
            this.optionsTab.Controls.Add(this.pictureBox6);
            this.optionsTab.Controls.Add(this.pictureBox5);
            this.optionsTab.Controls.Add(this.pictureBox3);
            this.optionsTab.Controls.Add(this.linkLabel3);
            this.optionsTab.Controls.Add(this.pictureBox17);
            this.optionsTab.Controls.Add(this.linkLabel2);
            this.optionsTab.Controls.Add(this.pictureBox14);
            this.optionsTab.Controls.Add(this.pictureBox13);
            this.optionsTab.Controls.Add(this.pictureBox12);
            this.optionsTab.Controls.Add(this.linkLabel1);
            this.optionsTab.Controls.Add(this.pictureBox85);
            this.optionsTab.Controls.Add(this.panel9);
            this.optionsTab.Controls.Add(this.languagesL);
            this.optionsTab.Controls.Add(this.linkLabel5);
            this.optionsTab.Controls.Add(this.l2);
            this.optionsTab.Controls.Add(this.optionsLayout);
            this.optionsTab.Location = new System.Drawing.Point(4, 25);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(2);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.optionsTab.Size = new System.Drawing.Size(1274, 675);
            this.optionsTab.TabIndex = 6;
            this.optionsTab.Text = "Options";
            // 
            // linkLabel7
            // 
            this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel7.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel7.Location = new System.Drawing.Point(1131, 494);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(98, 21);
            this.linkLabel7.TabIndex = 107;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Tag = "themeable";
            this.linkLabel7.Text = "FAQs && help";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1236, 494);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 106;
            this.pictureBox7.TabStop = false;
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel6.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel6.Location = new System.Drawing.Point(38, 642);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(139, 21);
            this.linkLabel6.TabIndex = 102;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Tag = "themeable";
            this.linkLabel6.Text = "Request a feature";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel4.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel4.Location = new System.Drawing.Point(38, 616);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(106, 21);
            this.linkLabel4.TabIndex = 101;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Tag = "themeable";
            this.linkLabel4.Text = "Report a bug";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(13, 642);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 100;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 616);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 99;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1236, 523);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel3.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel3.Location = new System.Drawing.Point(1134, 523);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(97, 21);
            this.linkLabel3.TabIndex = 95;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "themeable";
            this.linkLabel3.Text = "Support me";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(1236, 582);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(24, 24);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 94;
            this.pictureBox17.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(1126, 582);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 21);
            this.linkLabel2.TabIndex = 93;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "themeable";
            this.linkLabel2.Text = "Open Source";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(1236, 642);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(24, 24);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 92;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1236, 552);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(24, 24);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 91;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(1236, 612);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(24, 24);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 90;
            this.pictureBox12.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1103, 611);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 21);
            this.linkLabel1.TabIndex = 89;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "themeable";
            this.linkLabel1.Text = "Discord support";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBox85
            // 
            this.pictureBox85.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox85.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox85.Image")));
            this.pictureBox85.Location = new System.Drawing.Point(1224, 14);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(32, 32);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 74;
            this.pictureBox85.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.boxLang);
            this.panel9.Controls.Add(this.picFlag);
            this.panel9.Location = new System.Drawing.Point(914, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(341, 113);
            this.panel9.TabIndex = 73;
            // 
            // boxLang
            // 
            this.boxLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxLang.BorderColor = System.Drawing.Color.Blue;
            this.boxLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLang.ForeColor = System.Drawing.Color.White;
            this.boxLang.FormattingEnabled = true;
            this.boxLang.Location = new System.Drawing.Point(92, 3);
            this.boxLang.Name = "boxLang";
            this.boxLang.Size = new System.Drawing.Size(212, 29);
            this.boxLang.TabIndex = 95;
            this.boxLang.SelectedIndexChanged += new System.EventHandler(this.boxLang_SelectedIndexChanged);
            // 
            // picFlag
            // 
            this.picFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFlag.Image = global::Optimizer.Properties.Resources.united_kingdom;
            this.picFlag.Location = new System.Drawing.Point(309, 9);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(32, 19);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 75;
            this.picFlag.TabStop = false;
            // 
            // languagesL
            // 
            this.languagesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.languagesL.Location = new System.Drawing.Point(973, 18);
            this.languagesL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.languagesL.Name = "languagesL";
            this.languagesL.Size = new System.Drawing.Size(246, 28);
            this.languagesL.TabIndex = 71;
            this.languagesL.Tag = "themeable";
            this.languagesL.Text = "Choose language";
            this.languagesL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.Location = new System.Drawing.Point(1075, 642);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(156, 21);
            this.linkLabel5.TabIndex = 65;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "themeable";
            this.linkLabel5.Text = "GNU GPL 3.0 license";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // l2
            // 
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.l2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.l2.Location = new System.Drawing.Point(1106, 552);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(125, 21);
            this.l2.TabIndex = 59;
            this.l2.TabStop = true;
            this.l2.Tag = "themeable";
            this.l2.Text = "deadmoon © ∞";
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // tpanel
            // 
            this.tpanel.Controls.Add(this.restartAndApply);
            this.tpanel.Controls.Add(this.picRestartNeeded);
            this.tpanel.Controls.Add(this.picLab);
            this.tpanel.Controls.Add(this.picUpdate);
            this.tpanel.Controls.Add(this.txtNetFw);
            this.tpanel.Controls.Add(this.txtBitness);
            this.tpanel.Controls.Add(this.txtOS);
            this.tpanel.Controls.Add(this.txtVersion);
            this.tpanel.Controls.Add(this.pictureBox1);
            this.tpanel.Controls.Add(this.label2);
            this.tpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpanel.Location = new System.Drawing.Point(0, 0);
            this.tpanel.Margin = new System.Windows.Forms.Padding(2);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(1283, 66);
            this.tpanel.TabIndex = 1;
            // 
            // restartAndApply
            // 
            this.restartAndApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartAndApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartAndApply.ForeColor = System.Drawing.Color.White;
            this.restartAndApply.Location = new System.Drawing.Point(842, 12);
            this.restartAndApply.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restartAndApply.Name = "restartAndApply";
            this.restartAndApply.Size = new System.Drawing.Size(394, 25);
            this.restartAndApply.TabIndex = 74;
            this.restartAndApply.Tag = "themeable";
            this.restartAndApply.Text = "Restart needed";
            this.restartAndApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restartAndApply.Visible = false;
            this.restartAndApply.Click += new System.EventHandler(this.restartAndApply_Click);
            this.restartAndApply.MouseEnter += new System.EventHandler(this.restartAndApply_MouseEnter);
            this.restartAndApply.MouseLeave += new System.EventHandler(this.restartAndApply_MouseLeave);
            this.restartAndApply.MouseHover += new System.EventHandler(this.restartAndApply_MouseHover);
            // 
            // picRestartNeeded
            // 
            this.picRestartNeeded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRestartNeeded.Image = ((System.Drawing.Image)(resources.GetObject("picRestartNeeded.Image")));
            this.picRestartNeeded.Location = new System.Drawing.Point(1241, 11);
            this.picRestartNeeded.Name = "picRestartNeeded";
            this.picRestartNeeded.Size = new System.Drawing.Size(30, 30);
            this.picRestartNeeded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestartNeeded.TabIndex = 73;
            this.picRestartNeeded.TabStop = false;
            this.picRestartNeeded.Visible = false;
            this.picRestartNeeded.Click += new System.EventHandler(this.picRestartNeeded_Click);
            // 
            // picLab
            // 
            this.picLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLab.Image = ((System.Drawing.Image)(resources.GetObject("picLab.Image")));
            this.picLab.Location = new System.Drawing.Point(1241, 11);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(30, 30);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLab.TabIndex = 72;
            this.picLab.TabStop = false;
            this.picLab.Visible = false;
            this.picLab.Click += new System.EventHandler(this.picLab_Click);
            // 
            // picUpdate
            // 
            this.picUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(1241, 11);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(30, 30);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 71;
            this.picUpdate.TabStop = false;
            this.picUpdate.Visible = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // txtNetFw
            // 
            this.txtNetFw.AutoSize = true;
            this.txtNetFw.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetFw.ForeColor = System.Drawing.Color.Silver;
            this.txtNetFw.Location = new System.Drawing.Point(188, 42);
            this.txtNetFw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNetFw.Name = "txtNetFw";
            this.txtNetFw.Size = new System.Drawing.Size(42, 17);
            this.txtNetFw.TabIndex = 70;
            this.txtNetFw.Text = "netfw";
            // 
            // txtBitness
            // 
            this.txtBitness.AutoSize = true;
            this.txtBitness.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitness.ForeColor = System.Drawing.Color.Silver;
            this.txtBitness.Location = new System.Drawing.Point(188, 23);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(51, 17);
            this.txtBitness.TabIndex = 4;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.AutoSize = true;
            this.txtOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.ForeColor = System.Drawing.Color.Silver;
            this.txtOS.Location = new System.Drawing.Point(188, 3);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(22, 17);
            this.txtOS.TabIndex = 3;
            this.txtOS.Text = "os";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.Silver;
            this.txtVersion.Location = new System.Drawing.Point(70, 36);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(85, 17);
            this.txtVersion.TabIndex = 1;
            this.txtVersion.Text = "Version: {VN}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Optimizer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Optimizer";
            // 
            // bpanel
            // 
            this.bpanel.Controls.Add(this.tabCollection);
            this.bpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpanel.Location = new System.Drawing.Point(240, 119);
            this.bpanel.Margin = new System.Windows.Forms.Padding(2);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(1043, 651);
            this.bpanel.TabIndex = 2;
            // 
            // imagesHw
            // 
            this.imagesHw.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesHw.ImageStream")));
            this.imagesHw.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesHw.Images.SetKeyName(0, "cpu.png");
            this.imagesHw.Images.SetKeyName(1, "ram.png");
            this.imagesHw.Images.SetKeyName(2, "gpu.png");
            this.imagesHw.Images.SetKeyName(3, "mobo.png");
            this.imagesHw.Images.SetKeyName(4, "1608923_hdd_o_icon.png");
            this.imagesHw.Images.SetKeyName(5, "inet.png");
            this.imagesHw.Images.SetKeyName(6, "audio.png");
            this.imagesHw.Images.SetKeyName(7, "dev.png");
            this.imagesHw.Images.SetKeyName(8, "os.png");
            // 
            // defineCommandDialog
            // 
            this.defineCommandDialog.Filter = "Executables [*.exe]|*.exe";
            this.defineCommandDialog.Title = "Optimizer";
            this.defineCommandDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineCmd_FileOk);
            // 
            // defineProgramDialog
            // 
            this.defineProgramDialog.Filter = "Executables [*.exe]|*.exe";
            this.defineProgramDialog.Title = "Optimizer";
            this.defineProgramDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineProgramDialog_FileOk);
            // 
            // defineFolderDialog
            // 
            this.defineFolderDialog.Description = "Optimizer";
            // 
            // defineFileDialog
            // 
            this.defineFileDialog.Filter = "All files [*.*]|*.*";
            this.defineFileDialog.Title = "Optimizer";
            this.defineFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineFileDialog_FileOk);
            // 
            // DefineProgramIconDialog
            // 
            this.DefineProgramIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineProgramIconDialog.Title = "Optimizer";
            this.DefineProgramIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineProgramIconDialog_FileOk);
            // 
            // DefineFolderIconDialog
            // 
            this.DefineFolderIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineFolderIconDialog.Title = "Optimizer";
            this.DefineFolderIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineFolderIconDialog_FileOk);
            // 
            // DefineURLIconDialog
            // 
            this.DefineURLIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineURLIconDialog.Title = "Optimizer";
            this.DefineURLIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineURLIconDialog_FileOk);
            // 
            // DefineFileIconDialog
            // 
            this.DefineFileIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineFileIconDialog.Title = "Optimizer";
            this.DefineFileIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineFileIconDialog_FileOk);
            // 
            // DefineCommandIconDialog
            // 
            this.DefineCommandIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            this.DefineCommandIconDialog.Title = "Optimizer";
            this.DefineCommandIconDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.DefineCommandIconDialog_FileOk);
            // 
            // ExportDialog
            // 
            this.ExportDialog.Filter = "Text [*.txt]|*.txt";
            this.ExportDialog.Title = "Optimizer";
            // 
            // launcherMenu
            // 
            this.launcherMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.launcherMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcherMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.launcherMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayStartup,
            this.trayCleaner,
            this.trayPinger,
            this.trayHosts,
            this.trayAD,
            this.trayHW,
            this.trayRegistry,
            this.toolStripSeparator1,
            this.trayOptions,
            this.trayRestartExplorer,
            this.trayUnlocker,
            this.toolStripSeparator2,
            this.trayExit});
            this.launcherMenu.Name = "launcherMenu";
            this.launcherMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.launcherMenu.Size = new System.Drawing.Size(221, 302);
            // 
            // trayStartup
            // 
            this.trayStartup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStartup.ForeColor = System.Drawing.Color.White;
            this.trayStartup.Image = ((System.Drawing.Image)(resources.GetObject("trayStartup.Image")));
            this.trayStartup.Name = "trayStartup";
            this.trayStartup.Size = new System.Drawing.Size(220, 26);
            this.trayStartup.Text = "Startup Manager";
            this.trayStartup.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayStartup.Click += new System.EventHandler(this.startupItem_Click);
            // 
            // trayCleaner
            // 
            this.trayCleaner.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayCleaner.ForeColor = System.Drawing.Color.White;
            this.trayCleaner.Image = ((System.Drawing.Image)(resources.GetObject("trayCleaner.Image")));
            this.trayCleaner.Name = "trayCleaner";
            this.trayCleaner.Size = new System.Drawing.Size(220, 26);
            this.trayCleaner.Text = "PC Cleaner";
            this.trayCleaner.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayCleaner.Click += new System.EventHandler(this.cleanerItem_Click);
            // 
            // trayPinger
            // 
            this.trayPinger.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayPinger.ForeColor = System.Drawing.Color.White;
            this.trayPinger.Image = ((System.Drawing.Image)(resources.GetObject("trayPinger.Image")));
            this.trayPinger.Name = "trayPinger";
            this.trayPinger.Size = new System.Drawing.Size(220, 26);
            this.trayPinger.Text = "Pinger Tool";
            this.trayPinger.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayPinger.Click += new System.EventHandler(this.pingerItem_Click);
            // 
            // trayHosts
            // 
            this.trayHosts.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayHosts.ForeColor = System.Drawing.Color.White;
            this.trayHosts.Image = ((System.Drawing.Image)(resources.GetObject("trayHosts.Image")));
            this.trayHosts.Name = "trayHosts";
            this.trayHosts.Size = new System.Drawing.Size(220, 26);
            this.trayHosts.Text = "HOSTS Editor";
            this.trayHosts.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayHosts.Click += new System.EventHandler(this.hostsItem_Click);
            // 
            // trayAD
            // 
            this.trayAD.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayAD.ForeColor = System.Drawing.Color.White;
            this.trayAD.Image = ((System.Drawing.Image)(resources.GetObject("trayAD.Image")));
            this.trayAD.Name = "trayAD";
            this.trayAD.Size = new System.Drawing.Size(220, 26);
            this.trayAD.Text = "Apps Downloader";
            this.trayAD.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayAD.Click += new System.EventHandler(this.appsItem_Click);
            // 
            // trayHW
            // 
            this.trayHW.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayHW.ForeColor = System.Drawing.Color.White;
            this.trayHW.Image = ((System.Drawing.Image)(resources.GetObject("trayHW.Image")));
            this.trayHW.Name = "trayHW";
            this.trayHW.Size = new System.Drawing.Size(220, 26);
            this.trayHW.Text = "Hardware Information";
            this.trayHW.Click += new System.EventHandler(this.trayHW_Click);
            // 
            // trayRegistry
            // 
            this.trayRegistry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRegistry.ForeColor = System.Drawing.Color.White;
            this.trayRegistry.Image = ((System.Drawing.Image)(resources.GetObject("trayRegistry.Image")));
            this.trayRegistry.Name = "trayRegistry";
            this.trayRegistry.Size = new System.Drawing.Size(220, 26);
            this.trayRegistry.Text = "Registry Repair";
            this.trayRegistry.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayRegistry.Click += new System.EventHandler(this.trayRegistry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            this.toolStripSeparator1.Tag = "";
            // 
            // trayOptions
            // 
            this.trayOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayOptions.ForeColor = System.Drawing.Color.White;
            this.trayOptions.Image = ((System.Drawing.Image)(resources.GetObject("trayOptions.Image")));
            this.trayOptions.Name = "trayOptions";
            this.trayOptions.Size = new System.Drawing.Size(220, 26);
            this.trayOptions.Text = "Options";
            this.trayOptions.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayOptions.Click += new System.EventHandler(this.trayOptions_Click);
            // 
            // trayRestartExplorer
            // 
            this.trayRestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.trayRestartExplorer.Image = ((System.Drawing.Image)(resources.GetObject("trayRestartExplorer.Image")));
            this.trayRestartExplorer.Name = "trayRestartExplorer";
            this.trayRestartExplorer.Size = new System.Drawing.Size(220, 26);
            this.trayRestartExplorer.Text = "Restart Explorer";
            this.trayRestartExplorer.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayRestartExplorer.Click += new System.EventHandler(this.restartExpolorerItem_Click);
            // 
            // trayUnlocker
            // 
            this.trayUnlocker.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.trayUnlocker.ForeColor = System.Drawing.Color.White;
            this.trayUnlocker.Image = ((System.Drawing.Image)(resources.GetObject("trayUnlocker.Image")));
            this.trayUnlocker.Name = "trayUnlocker";
            this.trayUnlocker.Size = new System.Drawing.Size(220, 26);
            this.trayUnlocker.Text = "Find Handles";
            this.trayUnlocker.Click += new System.EventHandler(this.trayUnlocker_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // trayExit
            // 
            this.trayExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayExit.ForeColor = System.Drawing.Color.White;
            this.trayExit.Image = ((System.Drawing.Image)(resources.GetObject("trayExit.Image")));
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(220, 26);
            this.trayExit.Text = "Exit";
            this.trayExit.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // launcherIcon
            // 
            this.launcherIcon.ContextMenuStrip = this.launcherMenu;
            this.launcherIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("launcherIcon.Icon")));
            this.launcherIcon.Text = "Optimizer";
            this.launcherIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.launcherIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1283, 770);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.sidebarNav);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1123, 728);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.optionsLayout.ResumeLayout(false);
            this.optionsLayout.PerformLayout();
            this.cardSoundVideo.ResumeLayout(false);
            this.cardCoding.ResumeLayout(false);
            this.cardInternet.ResumeLayout(false);
            this.cardSystemTools.ResumeLayout(false);
            this.tableApps.ResumeLayout(false);
            this.tableApps.PerformLayout();
            this.cardUwp.ResumeLayout(false);
            this.advancedTabSection1.ResumeLayout(false);
            this.advancedTabLayout.ResumeLayout(false);
            this.win11Section2.ResumeLayout(false);
            this.win11Section2.PerformLayout();
            this.win11Section1.ResumeLayout(false);
            this.win11Section1.PerformLayout();
            this.windows10TabSection5.ResumeLayout(false);
            this.windows10TabSection5.PerformLayout();
            this.windows10TabSection4.ResumeLayout(false);
            this.windows10TabSection4.PerformLayout();
            this.windows10TabSection3.ResumeLayout(false);
            this.windows10TabSection3.PerformLayout();
            this.windows10TabSection2.ResumeLayout(false);
            this.windows10TabSection2.PerformLayout();
            this.windows10TabSection1.ResumeLayout(false);
            this.windows10TabSection1.PerformLayout();
            this.windows10TabLayout.ResumeLayout(false);
            this.panelWin11Tweaks.ResumeLayout(false);
            this.universalTabSection4.ResumeLayout(false);
            this.universalTabSection4.PerformLayout();
            this.universalTabSection3.ResumeLayout(false);
            this.universalTabSection3.PerformLayout();
            this.universalTabSection2.ResumeLayout(false);
            this.universalTabSection2.PerformLayout();
            this.universalTabSection1.ResumeLayout(false);
            this.universalTabSection1.PerformLayout();
            this.universalTabLayout.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.universalTab.ResumeLayout(false);
            this.windows10Tab.ResumeLayout(false);
            this.advancedTab.ResumeLayout(false);
            this.modernAppsTab.ResumeLayout(false);
            this.modernAppsTab.PerformLayout();
            this.startupTab.ResumeLayout(false);
            this.startupTab.PerformLayout();
            this.startupFooter.ResumeLayout(false);
            this.startupFooter.PerformLayout();
            this.startupBackupStrip.ResumeLayout(false);
            this.startupBackupStrip.PerformLayout();
            this.appsTab.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelCommonApps.ResumeLayout(false);
            this.panelCommonApps.PerformLayout();
            this.cleanerTab.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pingerTab.ResumeLayout(false);
            this.netTools.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.hostsEditorTab.ResumeLayout(false);
            this.hostsEditorTab.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.registryFixerTab.ResumeLayout(false);
            this.registryFixerTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.indiciumTab.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.indiciumMenu.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.integratorTab.ResumeLayout(false);
            this.synapse.ResumeLayout(false);
            this.integratorInfoTab.ResumeLayout(false);
            this.integratorInfoTab.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.itemnamegroup.ResumeLayout(false);
            this.itemnamegroup.PerformLayout();
            this.security.ResumeLayout(false);
            this.security.PerformLayout();
            this.itemposition.ResumeLayout(false);
            this.itemposition.PerformLayout();
            this.icontoaddgroup.ResumeLayout(false);
            this.icontoaddgroup.PerformLayout();
            this.itemtoaddgroup.ResumeLayout(false);
            this.itemtoaddgroup.PerformLayout();
            this.itemtype.ResumeLayout(false);
            this.itemtype.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.optionsTab.ResumeLayout(false);
            this.optionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bpanel.ResumeLayout(false);
            this.launcherMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tpanel;
        private System.Windows.Forms.Label txtBitness;
        private System.Windows.Forms.Label txtOS;
        private System.Windows.Forms.Label txtVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bpanel;
        private Optimizer.MoonTabs tabCollection;
        private System.Windows.Forms.TabPage universalTab;
        private System.Windows.Forms.TabPage windows10Tab;
        private System.Windows.Forms.TabPage cleanerTab;
        private System.Windows.Forms.TabPage startupTab;
        private System.Windows.Forms.Label startupTitle;
        private Optimizer.FluentButton removeStartupItemB;
        private System.Windows.Forms.TabPage registryFixerTab;
        private System.Windows.Forms.Label registryTitle;
        private Optimizer.FluentButton regFixB;
        private System.Windows.Forms.Panel panel2;
        private MoonCheck checkRegistryEditor;
        private MoonCheck checkEnableAll;
        private MoonCheck checkContextMenu;
        private MoonCheck checkTaskManager;
        private MoonCheck checkCommandPrompt;
        private MoonCheck checkFirewall;
        private MoonCheck checkRunDialog;
        private MoonCheck checkFolderOptions;
        private MoonCheck checkControlPanel;
        private MoonCheck checkRestartExplorer;
        private System.Windows.Forms.Label regLbl;
        private Optimizer.FluentButton refreshStartupB;
        private System.Windows.Forms.TextBox txtStartupSearch;
        private Optimizer.MoonSelect cmbStartupFilter;
        private Optimizer.MoonSelect cmbStartupStatus;
        private Optimizer.MoonSelect cmbStartupSort;
        private Optimizer.FluentButton sortDirStartupB;
        private Optimizer.CardPanel startupBackupStrip;
        private Optimizer.StartupList panelStartup;
        private Optimizer.CardPanel startupFooter;
        private Optimizer.MoonCheck chkStartupSelectAll;
        private System.Windows.Forms.Label lblStartupSelected;
        private Optimizer.FluentButton clearStartupSelB;
        private Optimizer.FluentButton enableStartupB;
        private Optimizer.FluentButton disableStartupB;
        private System.Windows.Forms.TabPage hostsEditorTab;
        private System.Windows.Forms.Label hostsTitle;
        private System.Windows.Forms.LinkLabel linkLocate;
        private System.Windows.Forms.LinkLabel linkAdvancedEdit;
        private System.Windows.Forms.LinkLabel linkRestoreDefault;
        private MoonList listHostEntries;
        private System.Windows.Forms.Panel panel4;
        private Optimizer.FluentButton removeAllHostsB;
        private Optimizer.FluentButton refreshHostsB;
        private Optimizer.FluentButton removeHostB;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblIP;
        private Optimizer.FluentButton addHostB;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TabPage integratorTab;
        private Optimizer.MoonTabs synapse;
        private System.Windows.Forms.TabPage integratorInfoTab;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Label integrator7;
        private System.Windows.Forms.Label integrator6;
        private System.Windows.Forms.Label integrator5;
        private System.Windows.Forms.Label integrator4;
        private System.Windows.Forms.Label integrator3;
        private System.Windows.Forms.Label integrator2;
        private System.Windows.Forms.Label integrator1;
        private Optimizer.FluentButton button48;
        private System.Windows.Forms.TextBox txtRunKeyword;
        private System.Windows.Forms.Label ccKeywordL;
        private System.Windows.Forms.TextBox txtRunFile;
        private System.Windows.Forms.Label ccFileL;
        private System.Windows.Forms.Label ccL;
        private Optimizer.FluentButton btnCreateCustomCommand;
        internal System.Windows.Forms.OpenFileDialog defineCommandDialog;
        private System.Windows.Forms.Label readyMenusL;
        private MoonList listDesktopItems;
        private System.Windows.Forms.Label removeIntegratorItemsL;
        private Optimizer.FluentButton refreshIIB;
        private Optimizer.FluentButton removeDIB;
        private Optimizer.FluentButton removeAllIIB;
        private System.Windows.Forms.GroupBox itemtype;
        private MoonRadio radioCommand;
        private MoonRadio radioProgram;
        private MoonRadio radioFile;
        private MoonRadio radioFolder;
        private MoonRadio radioLink;
        private System.Windows.Forms.Label addItemL;
        private System.Windows.Forms.GroupBox icontoaddgroup;
        private MoonCheck checkDefaultIcon;
        private Optimizer.FluentButton btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.GroupBox itemtoaddgroup;
        private Optimizer.FluentButton btnBrowseItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.GroupBox security;
        private MoonCheck checkShift;
        private System.Windows.Forms.GroupBox itemposition;
        private MoonRadio radioTop;
        private MoonRadio radioMiddle;
        private MoonRadio radioBottom;
        private System.Windows.Forms.GroupBox itemnamegroup;
        private System.Windows.Forms.TextBox txtItemName;
        private Optimizer.FluentButton btnAddItem;
        internal System.Windows.Forms.OpenFileDialog defineProgramDialog;
        internal System.Windows.Forms.FolderBrowserDialog defineFolderDialog;
        internal System.Windows.Forms.OpenFileDialog defineFileDialog;
        internal System.Windows.Forms.OpenFileDialog DefineProgramIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFolderIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineURLIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFileIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineCommandIconDialog;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.Label lblTheming;
        private MoonList listCustomCommands;
        private System.Windows.Forms.Label removeCCL;
        private Optimizer.FluentButton removeCCB;
        private Optimizer.FluentButton refreshCCB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TabPage modernAppsTab;
        private System.Windows.Forms.Label txtModernAppsTitle;
        private Optimizer.FluentButton uninstallModernAppsButton;
        private Optimizer.FluentButton refreshModernAppsButton;
        private MoonCheck chkSelectAllModernApps;
        private Optimizer.FluentButton btnResetConfig;
        private Optimizer.FluentButton btnUpdate;
        private MoonCheck chkReadOnly;
        private System.Windows.Forms.Label lblLock;
        private MoonCheck chkBlock;
        private System.Windows.Forms.TabPage appsTab;
        private Optimizer.FluentButton btnDownloadApps;
        private System.Windows.Forms.Label appsTitle;
        private System.Windows.Forms.Label setDownDirLbl;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private Optimizer.FluentButton changeDownDirB;
        private System.Windows.Forms.Label txtDownloadStatus;
        private System.Windows.Forms.Label bitPref;
        private MoonRadio c32;
        private Optimizer.FluentButton goToDownloadsB;
        private System.Windows.Forms.LinkLabel linkWarnings;
        private MoonCheck cAutoInstall;
        private MoonCheck chkOnlyRemovable;
        private MoonProgress progressDownloader;
        private Optimizer.FluentButton btnGetFeed;
        private System.Windows.Forms.Panel panelCommonApps;
        private System.Windows.Forms.LinkLabel l2;
        private System.Windows.Forms.Panel groupSystemTools;
        private Optimizer.FluentButton btnViewLog;
        private System.Windows.Forms.Label lblTroubleshoot;
        private System.Windows.Forms.Label lblUpdating;
        private Optimizer.FluentButton btnOpenConf;
        private System.Windows.Forms.TabPage pingerTab;
        internal System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.ContextMenuStrip launcherMenu;
        private System.Windows.Forms.NotifyIcon launcherIcon;
        private System.Windows.Forms.ToolStripMenuItem trayStartup;
        private System.Windows.Forms.ToolStripMenuItem trayCleaner;
        private System.Windows.Forms.ToolStripMenuItem trayPinger;
        private System.Windows.Forms.ToolStripMenuItem trayHosts;
        private System.Windows.Forms.ToolStripMenuItem trayAD;
        private System.Windows.Forms.ToolStripMenuItem trayExit;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.ToolStripMenuItem trayRestartExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MoonRadio c64;
        private System.Windows.Forms.Panel panel10;
        private TextBox txtBackupTitle;
        private Label lblBackupTitle;
        private Label languagesL;
        private PictureBox pictureBox85;
        private Panel panel9;
        private PictureBox picFlag;
        private Label txtNetFw;
        private Panel groupCoding;
        private Panel groupInternet;
        private Panel groupSoundVideo;
        private Label lblVideoSound;
        private Label lblCoding;
        private Label lblSystemTools;
        private Label lblInternet;
        private Optimizer.StackPanel panelWin11Tweaks;
        private ToolStripMenuItem trayRegistry;
        private ToolStripMenuItem trayOptions;
        private Label txtFeedError;
        private ToggleCard tpmSw;
        private ToggleCard xboxSw;
        private ToggleCard inkSw;
        private ToggleCard spellSw;
        private ToggleCard longPathsSw;
        private ToggleCard peopleSw;
        private ToggleCard oldExplorerSw;
        private ToggleCard adsSw;
        private ToggleCard storeUpdatesSw;
        private ToggleCard oldMixerSw;
        private ToggleCard insiderSw;
        private ToggleCard castSw;
        private ToggleCard gameBarSw;
        private ToggleCard sensorSw;
        private ToggleCard ccSw;
        private ToggleCard cortanaSw;
        private ToggleCard privacySw;
        private ToggleCard driversSw;
        private ToggleCard telemetryServicesSw;
        private ToggleCard autoUpdatesSw;
        private ToggleCard classicContextSw;
        private ToggleCard widgetsSw;
        private ToggleCard chatSw;
        private ToggleCard snapAssistSw;
        private ToggleCard leftTaskbarSw;
        private ToggleCard quickAccessToggle;
        private PictureBox picUpdate;
        private TabPage indiciumTab;
        private MoonTree specsTree;
        private Panel panel12;
        private Panel panel11;
        private ImageList imagesHw;
        private ToggleCard hwDetailed;
        private ToolStripMenuItem trayHW;
        private ContextMenuStrip indiciumMenu;
        private ToolStripMenuItem toolHWCopy;
        private ToolStripMenuItem toolHWGoogle;
        private ToolStripMenuItem toolHWDuck;
        private ToolStripSeparator toolStripSeparator2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
        private PictureBox picLab;
        private PictureBox pictureBox17;
        private LinkLabel linkLabel2;
        private MoonSelect boxLang;
        private Panel panel1;
        private MoonCheck edgeSession;
        private MoonCheck edgeHistory;
        private Label lblFootprint;
        private MoonCheck edgeCookies;
        private Label lblPretext;
        private MoonCheck edgeCache;
        private MoonCheck IECache;
        private MoonCheck firefoxHistory;
        private MoonCheck firefoxCookies;
        private MoonCheck firefoxCache;
        private MoonCheck chromePws;
        private MoonCheck chromeSession;
        private MoonCheck chromeHistory;
        private MoonCheck chromeCookies;
        private MoonCheck chromeCache;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private MoonCheck checkErrorReports;
        private MoonCheck checkTemp;
        private MoonCheck checkBin;
        private MoonCheck checkMiniDumps;
        private PictureBox pictureBox2;
        private Label label8;
        private Panel panel13;
        private Optimizer.CardPanel panel14;
        private MoonCheckList listCleanPreview;
        private LinkLabel checkSelectAll;
        private ToggleCard gameModeSw;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel3;
        private ToggleCard compactModeSw;
        private ToggleCard PMB;
        private ToggleCard AddCMDB;
        private ToggleCard AddOwnerB;
        private ToggleCard DSB;
        private ToggleCard SSB;
        private ToggleCard STB;
        private ToggleCard WAB;
        private Label label9;
        private PictureBox pictureBox4;
        private MoonCheck bravePasswords;
        private MoonCheck braveSession;
        private MoonCheck braveHistory;
        private MoonCheck braveCookies;
        private MoonCheck braveCache;
        private ToolStripMenuItem trayUnlocker;
        private Panel panelUwp;
        private ToggleCard stickersSw;
        private PictureBox picRestartNeeded;
        private Label restartAndApply;
        private TabPage tabPage1;
        private Panel panel7;
        private MoonList listPingResults;
        private Label lblResults;
        private TextBox txtPingInput;
        private Label lblPinger;
        private Label pingerTitle;
        private TabPage tabPage2;
        private LinkLabel linkDNSv6A;
        private LinkLabel linkDNSv4A;
        private LinkLabel linkDNSv6;
        private LinkLabel linkDNSv4;
        private Label label3;
        private Label label1;
        private MoonSelect boxAdapter;
        private MoonSelect boxDNS;
        private Controls.ColorPicker colorPicker1;
        private ToggleCard autoStartToggle;
        private Optimizer.MoonTabs netTools;
        private Label dnsTitle;
        private ToggleCard vbsSw;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label19;
        private Label label20;
        private TabPage advancedTab;
        private ToggleCard edgeAiSw;
        private ToggleCard edgeTelemetrySw;
        private ToggleCard loginVerboseSw;
        private ToggleCard hpetSw;
        private Optimizer.FluentButton backupStartupB;
        private Optimizer.FluentButton restoreStartupB;
        private Optimizer.FluentButton doBackup;
        private Optimizer.FluentButton cancelBackup;
        private Optimizer.FluentButton btnCopyHW;
        private Optimizer.FluentButton btnSaveHW;
        private Optimizer.FluentButton cleanDriveB;
        private Optimizer.FluentButton analyzeDriveB;
        private Optimizer.FluentButton btnWinClean;
        private Optimizer.FluentButton btnExport;
        private Optimizer.FluentButton copyB;
        private Optimizer.FluentButton copyIPB;
        private Optimizer.FluentButton btnShodan;
        private Optimizer.FluentButton btnPing;
        private Optimizer.FluentButton btnOpenNetwork;
        private Optimizer.FluentButton flushCacheB;
        private Optimizer.FluentButton btnRestoreUwp;
        private Optimizer.FluentButton btnRestart;
        private Optimizer.FluentButton btnRestartSafe;
        private ToggleCard classicPhotoViewerSw;
        private ToggleCard winSearchSw;
        private Label label13;
        private Label label4a;
        private Label drives;
        private Label label14s;
        private ToggleCard nvidiaTelemetrySw;
        private ToggleCard ntfsStampSw;
        private ToggleCard smb2Sw;
        private ToggleCard smb1Sw;
        private ToggleCard hibernateSw;
        private ToggleCard chromeTelemetrySw;
        private ToggleCard ffTelemetrySw;
        private ToggleCard vsSw;
        private ToggleCard reportingSw;
        private ToggleCard systemRestoreSw;
        private ToggleCard officeTelemetrySw;
        private ToggleCard smartScreenSw;
        private ToggleCard networkSw;
        private ToggleCard telemetryTasksSw;
        private ToggleCard defenderSw;
        private ToggleCard homegroupSw;
        private ToggleCard stickySw;
        private ToggleCard compatSw;
        private ToggleCard mediaSharingSw;
        private ToggleCard printSw;
        private ToggleCard superfetchSw;
        private ToggleCard faxSw;
        private ToggleCard performanceSw;
        private MoonCheck chkIncludeWww;
        private LinkLabel linkLabel4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private LinkLabel linkLabel6;
        private TabPage tabPage3;
        private Label fontSetTitle;
        private Panel panel8;
        private MoonList listFonts;
        private Optimizer.FluentButton btnRefreshFonts;
        private Label lblCurrentFont;
        private Label label11;
        private Optimizer.FluentButton btnRestoreFont;
        private Optimizer.FluentButton btnSetGlobalFont;
        private TextBox txtSearchFonts;
        private Label lblFontsCount;
        private Label lblFontsNumber;
        private MoonCheck chkAllNics;
        private MoonCheck chkCustomDns;
        private TextBox txtDns6B;
        private TextBox txtDns6A;
        private Label label12;
        private TextBox txtDns4B;
        private TextBox txtDns4A;
        private Label label10;
        private Optimizer.FluentButton btnSetDns;
        private Optimizer.FluentButton btnReinforce;
        private ToggleCard copilotSw;
        private ToggleCard autoUpdateToggle;
        private LinkLabel linkLabel7;
        private PictureBox pictureBox7;
        private ToggleCard disableOneDriveSw;
        private ToggleCard noMenuDelaySw;
        private ToggleCard allTrayIconsSw;
        private ToggleCard newsInterestsSw;
        private ToggleCard hideSearchSw;
        private ToggleCard hideWeatherSw;
        private ToggleCard modernStandbySw;
        private ToggleCard uODSw;
        private ToggleCard enableUtcSw;
        private TabPage tabPage4;
        private Panel panel15;
        private MoonList listSystemVariables;
        private Optimizer.FluentButton button1;
        private Optimizer.FluentButton button2;
        private Label label21;
        private Optimizer.FluentButton button3;
        private TextBox txtSysVar;
        private Label label23;
        private Label label24;
        private ToggleCard regBackupSw;
        private Optimizer.SidebarNav sidebarNav;
        private System.Windows.Forms.Label lblPageTitle;
        private Optimizer.ColumnsPanel universalTabLayout;
        private Optimizer.StackPanel universalTabSection1;
        private Optimizer.StackPanel universalTabSection2;
        private Optimizer.StackPanel universalTabSection3;
        private Optimizer.StackPanel universalTabSection4;
        private Optimizer.ColumnsPanel windows10TabLayout;
        private Optimizer.StackPanel windows10TabSection1;
        private Optimizer.StackPanel windows10TabSection2;
        private Optimizer.StackPanel windows10TabSection3;
        private Optimizer.StackPanel windows10TabSection4;
        private Optimizer.StackPanel windows10TabSection5;
        private Optimizer.StackPanel win11Section1;
        private Optimizer.StackPanel win11Section2;
        private Optimizer.ColumnsPanel advancedTabLayout;
        private Optimizer.StackPanel advancedTabSection1;
        private Optimizer.CardPanel cardUwp;
        private System.Windows.Forms.TableLayoutPanel tableApps;
        private Optimizer.CardPanel cardSystemTools;
        private Optimizer.CardPanel cardInternet;
        private Optimizer.CardPanel cardCoding;
        private Optimizer.CardPanel cardSoundVideo;
        private Optimizer.ToggleCard themeModeToggle;
        private Optimizer.StackPanel optionsLayout;
    }
}

