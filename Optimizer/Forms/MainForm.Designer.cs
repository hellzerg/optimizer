using System.Windows.Forms;

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
            this.tabCollection = new Optimizer.MoonTabs();
            this.universalTab = new System.Windows.Forms.TabPage();
            this.winSearchSw = new Optimizer.ToggleCard();
            this.label13 = new System.Windows.Forms.Label();
            this.label4a = new System.Windows.Forms.Label();
            this.drives = new System.Windows.Forms.Label();
            this.label14s = new System.Windows.Forms.Label();
            this.nvidiaTelemetrySw = new Optimizer.ToggleCard();
            this.ntfsStampSw = new Optimizer.ToggleCard();
            this.smb2Sw = new Optimizer.ToggleCard();
            this.smb1Sw = new Optimizer.ToggleCard();
            this.hibernateSw = new Optimizer.ToggleCard();
            this.chromeTelemetrySw = new Optimizer.ToggleCard();
            this.ffTelemetrySw = new Optimizer.ToggleCard();
            this.vsSw = new Optimizer.ToggleCard();
            this.reportingSw = new Optimizer.ToggleCard();
            this.systemRestoreSw = new Optimizer.ToggleCard();
            this.officeTelemetrySw = new Optimizer.ToggleCard();
            this.smartScreenSw = new Optimizer.ToggleCard();
            this.networkSw = new Optimizer.ToggleCard();
            this.telemetryTasksSw = new Optimizer.ToggleCard();
            this.defenderSw = new Optimizer.ToggleCard();
            this.homegroupSw = new Optimizer.ToggleCard();
            this.stickySw = new Optimizer.ToggleCard();
            this.compatSw = new Optimizer.ToggleCard();
            this.mediaSharingSw = new Optimizer.ToggleCard();
            this.printSw = new Optimizer.ToggleCard();
            this.superfetchSw = new Optimizer.ToggleCard();
            this.faxSw = new Optimizer.ToggleCard();
            this.performanceSw = new Optimizer.ToggleCard();
            this.windows10Tab = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelWin11Tweaks = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.stickersSw = new Optimizer.ToggleCard();
            this.compactModeSw = new Optimizer.ToggleCard();
            this.classicRibbonSw = new Optimizer.ToggleCard();
            this.snapAssistSw = new Optimizer.ToggleCard();
            this.widgetsSw = new Optimizer.ToggleCard();
            this.leftTaskbarSw = new Optimizer.ToggleCard();
            this.classicContextSw = new Optimizer.ToggleCard();
            this.chatSw = new Optimizer.ToggleCard();
            this.smallerTaskbarSw = new Optimizer.ToggleCard();
            this.vbsSw = new Optimizer.ToggleCard();
            this.gameModeSw = new Optimizer.ToggleCard();
            this.storeUpdatesSw = new Optimizer.ToggleCard();
            this.oldMixerSw = new Optimizer.ToggleCard();
            this.insiderSw = new Optimizer.ToggleCard();
            this.castSw = new Optimizer.ToggleCard();
            this.gameBarSw = new Optimizer.ToggleCard();
            this.sensorSw = new Optimizer.ToggleCard();
            this.ccSw = new Optimizer.ToggleCard();
            this.cortanaSw = new Optimizer.ToggleCard();
            this.privacySw = new Optimizer.ToggleCard();
            this.driversSw = new Optimizer.ToggleCard();
            this.telemetryServicesSw = new Optimizer.ToggleCard();
            this.autoUpdatesSw = new Optimizer.ToggleCard();
            this.tpmSw = new Optimizer.ToggleCard();
            this.xboxSw = new Optimizer.ToggleCard();
            this.inkSw = new Optimizer.ToggleCard();
            this.spellSw = new Optimizer.ToggleCard();
            this.longPathsSw = new Optimizer.ToggleCard();
            this.uODSw = new Optimizer.ToggleCard();
            this.peopleSw = new Optimizer.ToggleCard();
            this.oldExplorerSw = new Optimizer.ToggleCard();
            this.adsSw = new Optimizer.ToggleCard();
            this.windows8Tab = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.disableOneDriveSw = new Optimizer.ToggleCard();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.btnRestoreUwp = new System.Windows.Forms.Button();
            this.panelUwp = new System.Windows.Forms.Panel();
            this.uninstallModernAppsButton = new System.Windows.Forms.Button();
            this.refreshModernAppsButton = new System.Windows.Forms.Button();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.chkOnlyRemovable = new Optimizer.MoonCheck();
            this.chkSelectAllModernApps = new Optimizer.MoonCheck();
            this.startupTab = new System.Windows.Forms.TabPage();
            this.cancelBackup = new System.Windows.Forms.Button();
            this.doBackup = new System.Windows.Forms.Button();
            this.txtBackupTitle = new System.Windows.Forms.TextBox();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.restoreStartupB = new System.Windows.Forms.Button();
            this.backupStartupB = new System.Windows.Forms.Button();
            this.findInRegB = new System.Windows.Forms.Button();
            this.locateFileB = new System.Windows.Forms.Button();
            this.refreshStartupB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listStartupItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeStartupItemB = new System.Windows.Forms.Button();
            this.startupTitle = new System.Windows.Forms.Label();
            this.appsTab = new System.Windows.Forms.TabPage();
            this.txtFeedError = new System.Windows.Forms.Label();
            this.lblVideoSound = new System.Windows.Forms.Label();
            this.lblCoding = new System.Windows.Forms.Label();
            this.lblSystemTools = new System.Windows.Forms.Label();
            this.groupSoundVideo = new System.Windows.Forms.Panel();
            this.lblInternet = new System.Windows.Forms.Label();
            this.groupCoding = new System.Windows.Forms.Panel();
            this.groupInternet = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.appsTitle = new System.Windows.Forms.Label();
            this.btnGetFeed = new System.Windows.Forms.Button();
            this.panelCommonApps = new System.Windows.Forms.Panel();
            this.cAutoInstall = new Optimizer.MoonCheck();
            this.progressDownloader = new Optimizer.MoonProgress();
            this.c64 = new Optimizer.MoonRadio();
            this.c32 = new Optimizer.MoonRadio();
            this.btnDownloadApps = new System.Windows.Forms.Button();
            this.setDownDirLbl = new System.Windows.Forms.Label();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.changeDownDirB = new System.Windows.Forms.Button();
            this.txtDownloadStatus = new System.Windows.Forms.Label();
            this.linkWarnings = new System.Windows.Forms.LinkLabel();
            this.bitPref = new System.Windows.Forms.Label();
            this.goToDownloadsB = new System.Windows.Forms.Button();
            this.groupSystemTools = new System.Windows.Forms.Panel();
            this.cleanerTab = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.listCleanPreview = new Optimizer.MoonCheckList();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnWinClean = new System.Windows.Forms.Button();
            this.analyzeDriveB = new System.Windows.Forms.Button();
            this.checkSelectAll = new System.Windows.Forms.LinkLabel();
            this.lblPretext = new System.Windows.Forms.Label();
            this.cleanDriveB = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.copyB = new System.Windows.Forms.Button();
            this.copyIPB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listPingResults = new Optimizer.MoonList();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnShodan = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtPingInput = new System.Windows.Forms.TextBox();
            this.lblPinger = new System.Windows.Forms.Label();
            this.pingerTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dnsTitle = new System.Windows.Forms.Label();
            this.linkDNSv6A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv6 = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenNetwork = new System.Windows.Forms.Button();
            this.flushCacheB = new System.Windows.Forms.Button();
            this.boxAdapter = new Optimizer.MoonSelect();
            this.boxDNS = new Optimizer.MoonSelect();
            this.hostsEditorTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkAdvancedEdit = new System.Windows.Forms.LinkLabel();
            this.linkRestoreDefault = new System.Windows.Forms.LinkLabel();
            this.lblLock = new System.Windows.Forms.Label();
            this.chkReadOnly = new Optimizer.MoonCheck();
            this.panelList = new System.Windows.Forms.Panel();
            this.listHostEntries = new Optimizer.MoonList();
            this.chkBlock = new Optimizer.MoonCheck();
            this.refreshHostsB = new System.Windows.Forms.Button();
            this.removeHostB = new System.Windows.Forms.Button();
            this.removeAllHostsB = new System.Windows.Forms.Button();
            this.addHostB = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.hostsTitle = new System.Windows.Forms.Label();
            this.linkLocate = new System.Windows.Forms.LinkLabel();
            this.registryFixerTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regFixB = new System.Windows.Forms.Button();
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
            this.btnCopyHW = new System.Windows.Forms.Button();
            this.btnSaveHW = new System.Windows.Forms.Button();
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
            this.btnAddItem = new System.Windows.Forms.Button();
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
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseItem = new System.Windows.Forms.Button();
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
            this.refreshIIB = new System.Windows.Forms.Button();
            this.removeDIB = new System.Windows.Forms.Button();
            this.removeAllIIB = new System.Windows.Forms.Button();
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
            this.removeCCB = new System.Windows.Forms.Button();
            this.refreshCCB = new System.Windows.Forms.Button();
            this.removeCCL = new System.Windows.Forms.Label();
            this.btnCreateCustomCommand = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.txtRunKeyword = new System.Windows.Forms.TextBox();
            this.ccKeywordL = new System.Windows.Forms.Label();
            this.txtRunFile = new System.Windows.Forms.TextBox();
            this.ccFileL = new System.Windows.Forms.Label();
            this.ccL = new System.Windows.Forms.Label();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.telemetrySvcToggle = new Optimizer.ToggleCard();
            this.autoStartToggle = new Optimizer.ToggleCard();
            this.colorPicker1 = new Optimizer.Controls.ColorPicker();
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
            this.btnOpenConf = new System.Windows.Forms.Button();
            this.lblTroubleshoot = new System.Windows.Forms.Label();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.lblTheming = new System.Windows.Forms.Label();
            this.quickAccessToggle = new Optimizer.ToggleCard();
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
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bpanel.SuspendLayout();
            this.tabCollection.SuspendLayout();
            this.universalTab.SuspendLayout();
            this.windows10Tab.SuspendLayout();
            this.panelWin11Tweaks.SuspendLayout();
            this.windows8Tab.SuspendLayout();
            this.modernAppsTab.SuspendLayout();
            this.startupTab.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.optionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.launcherMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            this.tpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.tpanel.Size = new System.Drawing.Size(984, 64);
            this.tpanel.TabIndex = 1;
            // 
            // restartAndApply
            // 
            this.restartAndApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartAndApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartAndApply.ForeColor = System.Drawing.Color.White;
            this.restartAndApply.Location = new System.Drawing.Point(542, 12);
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
            this.picRestartNeeded.Location = new System.Drawing.Point(941, 11);
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
            this.picLab.Location = new System.Drawing.Point(941, 11);
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
            this.picUpdate.Location = new System.Drawing.Point(941, 11);
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
            this.bpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpanel.Controls.Add(this.tabCollection);
            this.bpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpanel.Location = new System.Drawing.Point(0, 64);
            this.bpanel.Margin = new System.Windows.Forms.Padding(2);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(984, 684);
            this.bpanel.TabIndex = 2;
            // 
            // tabCollection
            // 
            this.tabCollection.Controls.Add(this.universalTab);
            this.tabCollection.Controls.Add(this.windows10Tab);
            this.tabCollection.Controls.Add(this.windows8Tab);
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
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(2);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Drawing.Point(0, 0);
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(982, 682);
            this.tabCollection.TabIndex = 0;
            this.tabCollection.SelectedIndexChanged += new System.EventHandler(this.aio_SelectedIndexChanged);
            // 
            // universalTab
            // 
            this.universalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.universalTab.Controls.Add(this.winSearchSw);
            this.universalTab.Controls.Add(this.label13);
            this.universalTab.Controls.Add(this.label4a);
            this.universalTab.Controls.Add(this.drives);
            this.universalTab.Controls.Add(this.label14s);
            this.universalTab.Controls.Add(this.nvidiaTelemetrySw);
            this.universalTab.Controls.Add(this.ntfsStampSw);
            this.universalTab.Controls.Add(this.smb2Sw);
            this.universalTab.Controls.Add(this.smb1Sw);
            this.universalTab.Controls.Add(this.hibernateSw);
            this.universalTab.Controls.Add(this.chromeTelemetrySw);
            this.universalTab.Controls.Add(this.ffTelemetrySw);
            this.universalTab.Controls.Add(this.vsSw);
            this.universalTab.Controls.Add(this.reportingSw);
            this.universalTab.Controls.Add(this.systemRestoreSw);
            this.universalTab.Controls.Add(this.officeTelemetrySw);
            this.universalTab.Controls.Add(this.smartScreenSw);
            this.universalTab.Controls.Add(this.networkSw);
            this.universalTab.Controls.Add(this.telemetryTasksSw);
            this.universalTab.Controls.Add(this.defenderSw);
            this.universalTab.Controls.Add(this.homegroupSw);
            this.universalTab.Controls.Add(this.stickySw);
            this.universalTab.Controls.Add(this.compatSw);
            this.universalTab.Controls.Add(this.mediaSharingSw);
            this.universalTab.Controls.Add(this.printSw);
            this.universalTab.Controls.Add(this.superfetchSw);
            this.universalTab.Controls.Add(this.faxSw);
            this.universalTab.Controls.Add(this.performanceSw);
            this.universalTab.Location = new System.Drawing.Point(4, 25);
            this.universalTab.Margin = new System.Windows.Forms.Padding(2);
            this.universalTab.Name = "universalTab";
            this.universalTab.Padding = new System.Windows.Forms.Padding(2);
            this.universalTab.Size = new System.Drawing.Size(974, 653);
            this.universalTab.TabIndex = 0;
            this.universalTab.Text = "General";
            // 
            // winSearchSw
            // 
            this.winSearchSw.AccessibleName = "Disable Search";
            this.winSearchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.winSearchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.winSearchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winSearchSw.ForeColor = System.Drawing.Color.White;
            this.winSearchSw.LabelText = "Disable Search";
            this.winSearchSw.Location = new System.Drawing.Point(21, 466);
            this.winSearchSw.Margin = new System.Windows.Forms.Padding(6);
            this.winSearchSw.Name = "winSearchSw";
            this.winSearchSw.Size = new System.Drawing.Size(414, 24);
            this.winSearchSw.TabIndex = 173;
            this.winSearchSw.Tag = "themeable";
            this.winSearchSw.ToggleChecked = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(460, 194);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 172;
            this.label13.Tag = "";
            this.label13.Text = "Privacy";
            // 
            // label4a
            // 
            this.label4a.AutoSize = true;
            this.label4a.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4a.ForeColor = System.Drawing.Color.Silver;
            this.label4a.Location = new System.Drawing.Point(460, 11);
            this.label4a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4a.Name = "label4a";
            this.label4a.Size = new System.Drawing.Size(40, 19);
            this.label4a.TabIndex = 171;
            this.label4a.Tag = "";
            this.label4a.Text = "Apps";
            // 
            // drives
            // 
            this.drives.AutoSize = true;
            this.drives.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drives.ForeColor = System.Drawing.Color.Silver;
            this.drives.Location = new System.Drawing.Point(17, 315);
            this.drives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drives.Name = "drives";
            this.drives.Size = new System.Drawing.Size(42, 19);
            this.drives.TabIndex = 170;
            this.drives.Tag = "";
            this.drives.Text = "Disks";
            // 
            // label14s
            // 
            this.label14s.AutoSize = true;
            this.label14s.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14s.ForeColor = System.Drawing.Color.Silver;
            this.label14s.Location = new System.Drawing.Point(17, 11);
            this.label14s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14s.Name = "label14s";
            this.label14s.Size = new System.Drawing.Size(54, 19);
            this.label14s.TabIndex = 169;
            this.label14s.Tag = "";
            this.label14s.Text = "System";
            // 
            // nvidiaTelemetrySw
            // 
            this.nvidiaTelemetrySw.AccessibleName = "Disable NVIDIA Telemetry";
            this.nvidiaTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.nvidiaTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nvidiaTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvidiaTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.nvidiaTelemetrySw.LabelText = "Disable NVIDIA Telemetry";
            this.nvidiaTelemetrySw.Location = new System.Drawing.Point(464, 130);
            this.nvidiaTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.nvidiaTelemetrySw.Name = "nvidiaTelemetrySw";
            this.nvidiaTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.nvidiaTelemetrySw.TabIndex = 73;
            this.nvidiaTelemetrySw.Tag = "themeable";
            this.nvidiaTelemetrySw.ToggleChecked = false;
            // 
            // ntfsStampSw
            // 
            this.ntfsStampSw.AccessibleName = "Disable NTFS Timestamp";
            this.ntfsStampSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ntfsStampSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ntfsStampSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfsStampSw.ForeColor = System.Drawing.Color.White;
            this.ntfsStampSw.LabelText = "Disable NTFS Timestamp";
            this.ntfsStampSw.Location = new System.Drawing.Point(20, 436);
            this.ntfsStampSw.Margin = new System.Windows.Forms.Padding(6);
            this.ntfsStampSw.Name = "ntfsStampSw";
            this.ntfsStampSw.Size = new System.Drawing.Size(414, 24);
            this.ntfsStampSw.TabIndex = 72;
            this.ntfsStampSw.Tag = "themeable";
            this.ntfsStampSw.ToggleChecked = false;
            // 
            // smb2Sw
            // 
            this.smb2Sw.AccessibleName = "Disable SMBv2 Protocol";
            this.smb2Sw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smb2Sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smb2Sw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smb2Sw.ForeColor = System.Drawing.Color.White;
            this.smb2Sw.LabelText = "Disable SMBv2 Protocol";
            this.smb2Sw.Location = new System.Drawing.Point(464, 344);
            this.smb2Sw.Margin = new System.Windows.Forms.Padding(6);
            this.smb2Sw.Name = "smb2Sw";
            this.smb2Sw.Size = new System.Drawing.Size(414, 24);
            this.smb2Sw.TabIndex = 71;
            this.smb2Sw.Tag = "themeable";
            this.smb2Sw.ToggleChecked = false;
            // 
            // smb1Sw
            // 
            this.smb1Sw.AccessibleName = "Disable SMBv1 Protocol";
            this.smb1Sw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smb1Sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smb1Sw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smb1Sw.ForeColor = System.Drawing.Color.White;
            this.smb1Sw.LabelText = "Disable SMBv1 Protocol";
            this.smb1Sw.Location = new System.Drawing.Point(464, 314);
            this.smb1Sw.Margin = new System.Windows.Forms.Padding(6);
            this.smb1Sw.Name = "smb1Sw";
            this.smb1Sw.Size = new System.Drawing.Size(414, 24);
            this.smb1Sw.TabIndex = 70;
            this.smb1Sw.Tag = "themeable";
            this.smb1Sw.ToggleChecked = false;
            // 
            // hibernateSw
            // 
            this.hibernateSw.AccessibleName = "Disable Hibernation";
            this.hibernateSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hibernateSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hibernateSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateSw.ForeColor = System.Drawing.Color.White;
            this.hibernateSw.LabelText = "Disable Hibernation";
            this.hibernateSw.Location = new System.Drawing.Point(20, 406);
            this.hibernateSw.Margin = new System.Windows.Forms.Padding(6);
            this.hibernateSw.Name = "hibernateSw";
            this.hibernateSw.Size = new System.Drawing.Size(414, 24);
            this.hibernateSw.TabIndex = 69;
            this.hibernateSw.Tag = "themeable";
            this.hibernateSw.ToggleChecked = false;
            // 
            // chromeTelemetrySw
            // 
            this.chromeTelemetrySw.AccessibleName = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chromeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.chromeTelemetrySw.LabelText = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.Location = new System.Drawing.Point(464, 100);
            this.chromeTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.chromeTelemetrySw.Name = "chromeTelemetrySw";
            this.chromeTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.chromeTelemetrySw.TabIndex = 68;
            this.chromeTelemetrySw.Tag = "themeable";
            this.chromeTelemetrySw.ToggleChecked = false;
            // 
            // ffTelemetrySw
            // 
            this.ffTelemetrySw.AccessibleName = "Disable Mozilla Firefox Telemetry";
            this.ffTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ffTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ffTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.ffTelemetrySw.LabelText = "Disable Mozilla Firefox Telemetry";
            this.ffTelemetrySw.Location = new System.Drawing.Point(464, 70);
            this.ffTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.ffTelemetrySw.Name = "ffTelemetrySw";
            this.ffTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.ffTelemetrySw.TabIndex = 67;
            this.ffTelemetrySw.Tag = "themeable";
            this.ffTelemetrySw.ToggleChecked = false;
            // 
            // vsSw
            // 
            this.vsSw.AccessibleName = "Disable Visual Studio Telemetry";
            this.vsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsSw.ForeColor = System.Drawing.Color.White;
            this.vsSw.LabelText = "Disable Visual Studio Telemetry";
            this.vsSw.Location = new System.Drawing.Point(464, 160);
            this.vsSw.Margin = new System.Windows.Forms.Padding(6);
            this.vsSw.Name = "vsSw";
            this.vsSw.Size = new System.Drawing.Size(490, 24);
            this.vsSw.TabIndex = 66;
            this.vsSw.Tag = "themeable";
            this.vsSw.ToggleChecked = false;
            // 
            // reportingSw
            // 
            this.reportingSw.AccessibleName = "Disable Error Reporting";
            this.reportingSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.reportingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportingSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingSw.ForeColor = System.Drawing.Color.White;
            this.reportingSw.LabelText = "Disable Error Reporting";
            this.reportingSw.Location = new System.Drawing.Point(20, 100);
            this.reportingSw.Margin = new System.Windows.Forms.Padding(6);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.Size = new System.Drawing.Size(414, 24);
            this.reportingSw.TabIndex = 65;
            this.reportingSw.Tag = "themeable";
            this.reportingSw.ToggleChecked = false;
            // 
            // systemRestoreSw
            // 
            this.systemRestoreSw.AccessibleName = "Disable System Restore";
            this.systemRestoreSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.systemRestoreSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.systemRestoreSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.ForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.LabelText = "Disable System Restore";
            this.systemRestoreSw.Location = new System.Drawing.Point(20, 346);
            this.systemRestoreSw.Margin = new System.Windows.Forms.Padding(6);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.Size = new System.Drawing.Size(414, 24);
            this.systemRestoreSw.TabIndex = 64;
            this.systemRestoreSw.Tag = "themeable";
            this.systemRestoreSw.ToggleChecked = false;
            // 
            // officeTelemetrySw
            // 
            this.officeTelemetrySw.AccessibleName = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.officeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.officeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.LabelText = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.Location = new System.Drawing.Point(463, 40);
            this.officeTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.officeTelemetrySw.TabIndex = 63;
            this.officeTelemetrySw.Tag = "themeable";
            this.officeTelemetrySw.ToggleChecked = false;
            // 
            // smartScreenSw
            // 
            this.smartScreenSw.AccessibleName = "Disable SmartScreen";
            this.smartScreenSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smartScreenSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smartScreenSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartScreenSw.ForeColor = System.Drawing.Color.White;
            this.smartScreenSw.LabelText = "Disable SmartScreen";
            this.smartScreenSw.Location = new System.Drawing.Point(20, 250);
            this.smartScreenSw.Margin = new System.Windows.Forms.Padding(6);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.Size = new System.Drawing.Size(414, 24);
            this.smartScreenSw.TabIndex = 62;
            this.smartScreenSw.Tag = "themeable";
            this.smartScreenSw.ToggleChecked = false;
            // 
            // networkSw
            // 
            this.networkSw.AccessibleName = "Disable Network Throttling";
            this.networkSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.networkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.networkSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkSw.ForeColor = System.Drawing.Color.White;
            this.networkSw.LabelText = "Disable Network Throttling";
            this.networkSw.Location = new System.Drawing.Point(20, 70);
            this.networkSw.Margin = new System.Windows.Forms.Padding(6);
            this.networkSw.Name = "networkSw";
            this.networkSw.Size = new System.Drawing.Size(414, 24);
            this.networkSw.TabIndex = 61;
            this.networkSw.Tag = "themeable";
            this.networkSw.ToggleChecked = false;
            // 
            // telemetryTasksSw
            // 
            this.telemetryTasksSw.AccessibleName = "Disable Telemetry Tasks";
            this.telemetryTasksSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.telemetryTasksSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryTasksSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryTasksSw.ForeColor = System.Drawing.Color.White;
            this.telemetryTasksSw.LabelText = "Disable Telemetry Tasks";
            this.telemetryTasksSw.Location = new System.Drawing.Point(464, 224);
            this.telemetryTasksSw.Margin = new System.Windows.Forms.Padding(6);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.Size = new System.Drawing.Size(414, 24);
            this.telemetryTasksSw.TabIndex = 60;
            this.telemetryTasksSw.Tag = "themeable";
            this.telemetryTasksSw.ToggleChecked = false;
            // 
            // defenderSw
            // 
            this.defenderSw.AccessibleName = "Disable Windows Defender";
            this.defenderSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.defenderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.defenderSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenderSw.ForeColor = System.Drawing.Color.White;
            this.defenderSw.LabelText = "Disable Windows Defender";
            this.defenderSw.Location = new System.Drawing.Point(20, 280);
            this.defenderSw.Margin = new System.Windows.Forms.Padding(6);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.Size = new System.Drawing.Size(414, 24);
            this.defenderSw.TabIndex = 59;
            this.defenderSw.Tag = "themeable";
            this.defenderSw.ToggleChecked = false;
            // 
            // homegroupSw
            // 
            this.homegroupSw.AccessibleName = "Disable HomeGroup";
            this.homegroupSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.homegroupSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.homegroupSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homegroupSw.ForeColor = System.Drawing.Color.White;
            this.homegroupSw.LabelText = "Disable HomeGroup";
            this.homegroupSw.Location = new System.Drawing.Point(464, 284);
            this.homegroupSw.Margin = new System.Windows.Forms.Padding(6);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.Size = new System.Drawing.Size(414, 24);
            this.homegroupSw.TabIndex = 58;
            this.homegroupSw.Tag = "themeable";
            this.homegroupSw.ToggleChecked = false;
            // 
            // stickySw
            // 
            this.stickySw.AccessibleName = "Disable Sticky Keys";
            this.stickySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.stickySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stickySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickySw.ForeColor = System.Drawing.Color.White;
            this.stickySw.LabelText = "Disable Sticky Keys";
            this.stickySw.Location = new System.Drawing.Point(20, 220);
            this.stickySw.Margin = new System.Windows.Forms.Padding(6);
            this.stickySw.Name = "stickySw";
            this.stickySw.Size = new System.Drawing.Size(414, 24);
            this.stickySw.TabIndex = 57;
            this.stickySw.Tag = "themeable";
            this.stickySw.ToggleChecked = false;
            // 
            // compatSw
            // 
            this.compatSw.AccessibleName = "Disable Compatibility Assistant";
            this.compatSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.compatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compatSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatSw.ForeColor = System.Drawing.Color.White;
            this.compatSw.LabelText = "Disable Compatibility Assistant";
            this.compatSw.Location = new System.Drawing.Point(20, 130);
            this.compatSw.Margin = new System.Windows.Forms.Padding(6);
            this.compatSw.Name = "compatSw";
            this.compatSw.Size = new System.Drawing.Size(414, 24);
            this.compatSw.TabIndex = 56;
            this.compatSw.Tag = "themeable";
            this.compatSw.ToggleChecked = false;
            // 
            // mediaSharingSw
            // 
            this.mediaSharingSw.AccessibleName = "Disable Media Player Sharing";
            this.mediaSharingSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.mediaSharingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mediaSharingSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaSharingSw.ForeColor = System.Drawing.Color.White;
            this.mediaSharingSw.LabelText = "Disable Media Player Sharing";
            this.mediaSharingSw.Location = new System.Drawing.Point(464, 254);
            this.mediaSharingSw.Margin = new System.Windows.Forms.Padding(6);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.Size = new System.Drawing.Size(414, 24);
            this.mediaSharingSw.TabIndex = 55;
            this.mediaSharingSw.Tag = "themeable";
            this.mediaSharingSw.ToggleChecked = false;
            // 
            // printSw
            // 
            this.printSw.AccessibleName = "Disable Print Service";
            this.printSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.printSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSw.ForeColor = System.Drawing.Color.White;
            this.printSw.LabelText = "Disable Print Service";
            this.printSw.Location = new System.Drawing.Point(20, 160);
            this.printSw.Margin = new System.Windows.Forms.Padding(6);
            this.printSw.Name = "printSw";
            this.printSw.Size = new System.Drawing.Size(414, 24);
            this.printSw.TabIndex = 54;
            this.printSw.Tag = "themeable";
            this.printSw.ToggleChecked = false;
            // 
            // superfetchSw
            // 
            this.superfetchSw.AccessibleName = "Disable Superfetch";
            this.superfetchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.superfetchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.superfetchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.ForeColor = System.Drawing.Color.White;
            this.superfetchSw.LabelText = "Disable Superfetch";
            this.superfetchSw.Location = new System.Drawing.Point(20, 376);
            this.superfetchSw.Margin = new System.Windows.Forms.Padding(6);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.Size = new System.Drawing.Size(414, 24);
            this.superfetchSw.TabIndex = 53;
            this.superfetchSw.Tag = "themeable";
            this.superfetchSw.ToggleChecked = false;
            // 
            // faxSw
            // 
            this.faxSw.AccessibleName = "Disable Fax Service";
            this.faxSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.faxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.faxSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.ForeColor = System.Drawing.Color.White;
            this.faxSw.LabelText = "Disable Fax Service";
            this.faxSw.Location = new System.Drawing.Point(20, 190);
            this.faxSw.Margin = new System.Windows.Forms.Padding(6);
            this.faxSw.Name = "faxSw";
            this.faxSw.Size = new System.Drawing.Size(414, 24);
            this.faxSw.TabIndex = 52;
            this.faxSw.Tag = "themeable";
            this.faxSw.ToggleChecked = false;
            // 
            // performanceSw
            // 
            this.performanceSw.AccessibleName = "Enable Performance Tweaks";
            this.performanceSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.performanceSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.performanceSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceSw.ForeColor = System.Drawing.Color.White;
            this.performanceSw.LabelText = "Enable Performance Tweaks";
            this.performanceSw.Location = new System.Drawing.Point(20, 40);
            this.performanceSw.Margin = new System.Windows.Forms.Padding(6);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.Size = new System.Drawing.Size(414, 24);
            this.performanceSw.TabIndex = 51;
            this.performanceSw.Tag = "themeable";
            this.performanceSw.ToggleChecked = false;
            // 
            // windows10Tab
            // 
            this.windows10Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows10Tab.Controls.Add(this.label18);
            this.windows10Tab.Controls.Add(this.label17);
            this.windows10Tab.Controls.Add(this.label16);
            this.windows10Tab.Controls.Add(this.label15);
            this.windows10Tab.Controls.Add(this.label14);
            this.windows10Tab.Controls.Add(this.panelWin11Tweaks);
            this.windows10Tab.Controls.Add(this.vbsSw);
            this.windows10Tab.Controls.Add(this.gameModeSw);
            this.windows10Tab.Controls.Add(this.storeUpdatesSw);
            this.windows10Tab.Controls.Add(this.oldMixerSw);
            this.windows10Tab.Controls.Add(this.insiderSw);
            this.windows10Tab.Controls.Add(this.castSw);
            this.windows10Tab.Controls.Add(this.gameBarSw);
            this.windows10Tab.Controls.Add(this.sensorSw);
            this.windows10Tab.Controls.Add(this.ccSw);
            this.windows10Tab.Controls.Add(this.cortanaSw);
            this.windows10Tab.Controls.Add(this.privacySw);
            this.windows10Tab.Controls.Add(this.driversSw);
            this.windows10Tab.Controls.Add(this.telemetryServicesSw);
            this.windows10Tab.Controls.Add(this.autoUpdatesSw);
            this.windows10Tab.Controls.Add(this.tpmSw);
            this.windows10Tab.Controls.Add(this.xboxSw);
            this.windows10Tab.Controls.Add(this.inkSw);
            this.windows10Tab.Controls.Add(this.spellSw);
            this.windows10Tab.Controls.Add(this.longPathsSw);
            this.windows10Tab.Controls.Add(this.uODSw);
            this.windows10Tab.Controls.Add(this.peopleSw);
            this.windows10Tab.Controls.Add(this.oldExplorerSw);
            this.windows10Tab.Controls.Add(this.adsSw);
            this.windows10Tab.Location = new System.Drawing.Point(4, 25);
            this.windows10Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Name = "windows10Tab";
            this.windows10Tab.Padding = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Size = new System.Drawing.Size(974, 653);
            this.windows10Tab.TabIndex = 1;
            this.windows10Tab.Text = "Windows 10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(460, 296);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 19);
            this.label18.TabIndex = 176;
            this.label18.Tag = "";
            this.label18.Text = "Touch";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(460, 163);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 19);
            this.label17.TabIndex = 175;
            this.label17.Tag = "";
            this.label17.Text = "Gaming";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(460, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 19);
            this.label16.TabIndex = 174;
            this.label16.Tag = "";
            this.label16.Text = "Privacy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(18, 296);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 19);
            this.label15.TabIndex = 173;
            this.label15.Tag = "";
            this.label15.Text = "Windows Update";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(17, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 170;
            this.label14.Tag = "";
            this.label14.Text = "System";
            // 
            // panelWin11Tweaks
            // 
            this.panelWin11Tweaks.Controls.Add(this.label20);
            this.panelWin11Tweaks.Controls.Add(this.label19);
            this.panelWin11Tweaks.Controls.Add(this.stickersSw);
            this.panelWin11Tweaks.Controls.Add(this.compactModeSw);
            this.panelWin11Tweaks.Controls.Add(this.classicRibbonSw);
            this.panelWin11Tweaks.Controls.Add(this.snapAssistSw);
            this.panelWin11Tweaks.Controls.Add(this.widgetsSw);
            this.panelWin11Tweaks.Controls.Add(this.leftTaskbarSw);
            this.panelWin11Tweaks.Controls.Add(this.classicContextSw);
            this.panelWin11Tweaks.Controls.Add(this.chatSw);
            this.panelWin11Tweaks.Controls.Add(this.smallerTaskbarSw);
            this.panelWin11Tweaks.Location = new System.Drawing.Point(0, 450);
            this.panelWin11Tweaks.Name = "panelWin11Tweaks";
            this.panelWin11Tweaks.Size = new System.Drawing.Size(971, 203);
            this.panelWin11Tweaks.TabIndex = 80;
            this.panelWin11Tweaks.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(460, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 19);
            this.label20.TabIndex = 178;
            this.label20.Tag = "";
            this.label20.Text = "Extras";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(16, 5);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 19);
            this.label19.TabIndex = 177;
            this.label19.Tag = "";
            this.label19.Text = "Taskbar";
            // 
            // stickersSw
            // 
            this.stickersSw.AccessibleName = "Disable Stickers";
            this.stickersSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.stickersSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stickersSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickersSw.ForeColor = System.Drawing.Color.White;
            this.stickersSw.LabelText = "Disable Stickers";
            this.stickersSw.Location = new System.Drawing.Point(21, 126);
            this.stickersSw.Margin = new System.Windows.Forms.Padding(6);
            this.stickersSw.Name = "stickersSw";
            this.stickersSw.Size = new System.Drawing.Size(414, 24);
            this.stickersSw.TabIndex = 113;
            this.stickersSw.Tag = "themeable";
            this.stickersSw.ToggleChecked = false;
            // 
            // compactModeSw
            // 
            this.compactModeSw.AccessibleName = "Enable Compact Mode in Explorer";
            this.compactModeSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.compactModeSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compactModeSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compactModeSw.ForeColor = System.Drawing.Color.White;
            this.compactModeSw.LabelText = "Enable Compact Mode in Explorer";
            this.compactModeSw.Location = new System.Drawing.Point(464, 126);
            this.compactModeSw.Margin = new System.Windows.Forms.Padding(6);
            this.compactModeSw.Name = "compactModeSw";
            this.compactModeSw.Size = new System.Drawing.Size(414, 24);
            this.compactModeSw.TabIndex = 112;
            this.compactModeSw.Tag = "themeable";
            this.compactModeSw.ToggleChecked = false;
            // 
            // classicRibbonSw
            // 
            this.classicRibbonSw.AccessibleName = "Enable Classic Ribbon in Explorer";
            this.classicRibbonSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.classicRibbonSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicRibbonSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicRibbonSw.ForeColor = System.Drawing.Color.White;
            this.classicRibbonSw.LabelText = "Enable Classic Ribbon in Explorer";
            this.classicRibbonSw.Location = new System.Drawing.Point(464, 66);
            this.classicRibbonSw.Margin = new System.Windows.Forms.Padding(6);
            this.classicRibbonSw.Name = "classicRibbonSw";
            this.classicRibbonSw.Size = new System.Drawing.Size(414, 24);
            this.classicRibbonSw.TabIndex = 111;
            this.classicRibbonSw.Tag = "themeable";
            this.classicRibbonSw.ToggleChecked = false;
            // 
            // snapAssistSw
            // 
            this.snapAssistSw.AccessibleName = "Disable Snap Assist";
            this.snapAssistSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.snapAssistSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snapAssistSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapAssistSw.ForeColor = System.Drawing.Color.White;
            this.snapAssistSw.LabelText = "Disable Snap Assist";
            this.snapAssistSw.Location = new System.Drawing.Point(464, 36);
            this.snapAssistSw.Margin = new System.Windows.Forms.Padding(6);
            this.snapAssistSw.Name = "snapAssistSw";
            this.snapAssistSw.Size = new System.Drawing.Size(414, 24);
            this.snapAssistSw.TabIndex = 106;
            this.snapAssistSw.Tag = "themeable";
            this.snapAssistSw.ToggleChecked = false;
            // 
            // widgetsSw
            // 
            this.widgetsSw.AccessibleName = "Disable Widgets";
            this.widgetsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.widgetsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.widgetsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widgetsSw.ForeColor = System.Drawing.Color.White;
            this.widgetsSw.LabelText = "Disable Widgets";
            this.widgetsSw.Location = new System.Drawing.Point(21, 66);
            this.widgetsSw.Margin = new System.Windows.Forms.Padding(6);
            this.widgetsSw.Name = "widgetsSw";
            this.widgetsSw.Size = new System.Drawing.Size(414, 24);
            this.widgetsSw.TabIndex = 108;
            this.widgetsSw.Tag = "themeable";
            this.widgetsSw.ToggleChecked = false;
            // 
            // leftTaskbarSw
            // 
            this.leftTaskbarSw.AccessibleName = "Align Taskbar to Left";
            this.leftTaskbarSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.leftTaskbarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftTaskbarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTaskbarSw.ForeColor = System.Drawing.Color.White;
            this.leftTaskbarSw.LabelText = "Align Taskbar to Left";
            this.leftTaskbarSw.Location = new System.Drawing.Point(20, 36);
            this.leftTaskbarSw.Margin = new System.Windows.Forms.Padding(6);
            this.leftTaskbarSw.Name = "leftTaskbarSw";
            this.leftTaskbarSw.Size = new System.Drawing.Size(414, 24);
            this.leftTaskbarSw.TabIndex = 105;
            this.leftTaskbarSw.Tag = "themeable";
            this.leftTaskbarSw.ToggleChecked = false;
            // 
            // classicContextSw
            // 
            this.classicContextSw.AccessibleName = "Enable Classic Right-Click Menu";
            this.classicContextSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.classicContextSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicContextSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicContextSw.ForeColor = System.Drawing.Color.White;
            this.classicContextSw.LabelText = "Enable Classic Right-Click Menu";
            this.classicContextSw.Location = new System.Drawing.Point(464, 96);
            this.classicContextSw.Margin = new System.Windows.Forms.Padding(6);
            this.classicContextSw.Name = "classicContextSw";
            this.classicContextSw.Size = new System.Drawing.Size(414, 24);
            this.classicContextSw.TabIndex = 110;
            this.classicContextSw.Tag = "themeable";
            this.classicContextSw.ToggleChecked = false;
            // 
            // chatSw
            // 
            this.chatSw.AccessibleName = "Disable Chat";
            this.chatSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chatSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatSw.ForeColor = System.Drawing.Color.White;
            this.chatSw.LabelText = "Disable Chat";
            this.chatSw.Location = new System.Drawing.Point(21, 96);
            this.chatSw.Margin = new System.Windows.Forms.Padding(6);
            this.chatSw.Name = "chatSw";
            this.chatSw.Size = new System.Drawing.Size(414, 24);
            this.chatSw.TabIndex = 107;
            this.chatSw.Tag = "themeable";
            this.chatSw.ToggleChecked = false;
            // 
            // smallerTaskbarSw
            // 
            this.smallerTaskbarSw.AccessibleName = "Make Taskbar Smaller";
            this.smallerTaskbarSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smallerTaskbarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smallerTaskbarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallerTaskbarSw.ForeColor = System.Drawing.Color.White;
            this.smallerTaskbarSw.LabelText = "Make Taskbar Smaller";
            this.smallerTaskbarSw.Location = new System.Drawing.Point(21, 156);
            this.smallerTaskbarSw.Margin = new System.Windows.Forms.Padding(6);
            this.smallerTaskbarSw.Name = "smallerTaskbarSw";
            this.smallerTaskbarSw.Size = new System.Drawing.Size(414, 24);
            this.smallerTaskbarSw.TabIndex = 109;
            this.smallerTaskbarSw.Tag = "themeable";
            this.smallerTaskbarSw.ToggleChecked = false;
            // 
            // vbsSw
            // 
            this.vbsSw.AccessibleName = "Disable Virtualization Based Security";
            this.vbsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vbsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vbsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbsSw.ForeColor = System.Drawing.Color.White;
            this.vbsSw.LabelText = "Disable Virtualization Based Security";
            this.vbsSw.Location = new System.Drawing.Point(21, 220);
            this.vbsSw.Margin = new System.Windows.Forms.Padding(6);
            this.vbsSw.Name = "vbsSw";
            this.vbsSw.Size = new System.Drawing.Size(414, 24);
            this.vbsSw.TabIndex = 114;
            this.vbsSw.Tag = "themeable";
            this.vbsSw.ToggleChecked = false;
            this.vbsSw.Visible = false;
            // 
            // gameModeSw
            // 
            this.gameModeSw.AccessibleName = "Enable Gaming Mode";
            this.gameModeSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.gameModeSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameModeSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModeSw.ForeColor = System.Drawing.Color.White;
            this.gameModeSw.LabelText = "Enable Gaming Mode";
            this.gameModeSw.Location = new System.Drawing.Point(464, 190);
            this.gameModeSw.Margin = new System.Windows.Forms.Padding(6);
            this.gameModeSw.Name = "gameModeSw";
            this.gameModeSw.Size = new System.Drawing.Size(414, 24);
            this.gameModeSw.TabIndex = 105;
            this.gameModeSw.Tag = "themeable";
            this.gameModeSw.ToggleChecked = false;
            // 
            // storeUpdatesSw
            // 
            this.storeUpdatesSw.AccessibleName = "Disable Microsoft Store Updates";
            this.storeUpdatesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.storeUpdatesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.storeUpdatesSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeUpdatesSw.ForeColor = System.Drawing.Color.White;
            this.storeUpdatesSw.LabelText = "Disable Microsoft Store Updates";
            this.storeUpdatesSw.Location = new System.Drawing.Point(21, 357);
            this.storeUpdatesSw.Margin = new System.Windows.Forms.Padding(6);
            this.storeUpdatesSw.Name = "storeUpdatesSw";
            this.storeUpdatesSw.Size = new System.Drawing.Size(414, 24);
            this.storeUpdatesSw.TabIndex = 104;
            this.storeUpdatesSw.Tag = "themeable";
            this.storeUpdatesSw.ToggleChecked = false;
            // 
            // oldMixerSw
            // 
            this.oldMixerSw.AccessibleName = "Enable Classic Volume Mixer";
            this.oldMixerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.oldMixerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldMixerSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMixerSw.ForeColor = System.Drawing.Color.White;
            this.oldMixerSw.LabelText = "Enable Classic Volume Mixer";
            this.oldMixerSw.Location = new System.Drawing.Point(21, 220);
            this.oldMixerSw.Margin = new System.Windows.Forms.Padding(6);
            this.oldMixerSw.Name = "oldMixerSw";
            this.oldMixerSw.Size = new System.Drawing.Size(414, 24);
            this.oldMixerSw.TabIndex = 103;
            this.oldMixerSw.Tag = "themeable";
            this.oldMixerSw.ToggleChecked = false;
            // 
            // insiderSw
            // 
            this.insiderSw.AccessibleName = "Disable Insider Service";
            this.insiderSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.insiderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.insiderSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.ForeColor = System.Drawing.Color.White;
            this.insiderSw.LabelText = "Disable Insider Service";
            this.insiderSw.Location = new System.Drawing.Point(21, 387);
            this.insiderSw.Margin = new System.Windows.Forms.Padding(6);
            this.insiderSw.Name = "insiderSw";
            this.insiderSw.Size = new System.Drawing.Size(414, 24);
            this.insiderSw.TabIndex = 102;
            this.insiderSw.Tag = "themeable";
            this.insiderSw.ToggleChecked = false;
            // 
            // castSw
            // 
            this.castSw.AccessibleName = "Remove Cast to Device";
            this.castSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.castSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.castSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castSw.ForeColor = System.Drawing.Color.White;
            this.castSw.LabelText = "Remove Cast to Device";
            this.castSw.Location = new System.Drawing.Point(21, 190);
            this.castSw.Margin = new System.Windows.Forms.Padding(6);
            this.castSw.Name = "castSw";
            this.castSw.Size = new System.Drawing.Size(414, 24);
            this.castSw.TabIndex = 101;
            this.castSw.Tag = "themeable";
            this.castSw.ToggleChecked = false;
            // 
            // gameBarSw
            // 
            this.gameBarSw.AccessibleName = "Disable Game Bar";
            this.gameBarSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.gameBarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameBarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBarSw.ForeColor = System.Drawing.Color.White;
            this.gameBarSw.LabelText = "Disable Game Bar";
            this.gameBarSw.Location = new System.Drawing.Point(464, 250);
            this.gameBarSw.Margin = new System.Windows.Forms.Padding(6);
            this.gameBarSw.Name = "gameBarSw";
            this.gameBarSw.Size = new System.Drawing.Size(414, 24);
            this.gameBarSw.TabIndex = 100;
            this.gameBarSw.Tag = "themeable";
            this.gameBarSw.ToggleChecked = false;
            // 
            // sensorSw
            // 
            this.sensorSw.AccessibleName = "Disable Sensor Services";
            this.sensorSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.sensorSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sensorSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorSw.ForeColor = System.Drawing.Color.White;
            this.sensorSw.LabelText = "Disable Sensor Services";
            this.sensorSw.Location = new System.Drawing.Point(21, 160);
            this.sensorSw.Margin = new System.Windows.Forms.Padding(6);
            this.sensorSw.Name = "sensorSw";
            this.sensorSw.Size = new System.Drawing.Size(414, 24);
            this.sensorSw.TabIndex = 99;
            this.sensorSw.Tag = "themeable";
            this.sensorSw.ToggleChecked = false;
            // 
            // ccSw
            // 
            this.ccSw.AccessibleName = "Disable Cloud Clipboard";
            this.ccSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ccSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ccSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccSw.ForeColor = System.Drawing.Color.White;
            this.ccSw.LabelText = "Disable Cloud Clipboard";
            this.ccSw.Location = new System.Drawing.Point(464, 387);
            this.ccSw.Margin = new System.Windows.Forms.Padding(6);
            this.ccSw.Name = "ccSw";
            this.ccSw.Size = new System.Drawing.Size(414, 24);
            this.ccSw.TabIndex = 98;
            this.ccSw.Tag = "themeable";
            this.ccSw.ToggleChecked = false;
            // 
            // cortanaSw
            // 
            this.cortanaSw.AccessibleName = "Disable Cortana";
            this.cortanaSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.cortanaSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cortanaSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortanaSw.ForeColor = System.Drawing.Color.White;
            this.cortanaSw.LabelText = "Disable Cortana";
            this.cortanaSw.Location = new System.Drawing.Point(464, 70);
            this.cortanaSw.Margin = new System.Windows.Forms.Padding(6);
            this.cortanaSw.Name = "cortanaSw";
            this.cortanaSw.Size = new System.Drawing.Size(414, 24);
            this.cortanaSw.TabIndex = 97;
            this.cortanaSw.Tag = "themeable";
            this.cortanaSw.ToggleChecked = false;
            // 
            // privacySw
            // 
            this.privacySw.AccessibleName = "Enhance Privacy";
            this.privacySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.privacySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.privacySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacySw.ForeColor = System.Drawing.Color.White;
            this.privacySw.LabelText = "Enhance Privacy";
            this.privacySw.Location = new System.Drawing.Point(464, 100);
            this.privacySw.Margin = new System.Windows.Forms.Padding(6);
            this.privacySw.Name = "privacySw";
            this.privacySw.Size = new System.Drawing.Size(414, 24);
            this.privacySw.TabIndex = 96;
            this.privacySw.Tag = "themeable";
            this.privacySw.ToggleChecked = false;
            // 
            // driversSw
            // 
            this.driversSw.AccessibleName = "Exclude Drivers from Update";
            this.driversSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.driversSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.driversSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversSw.ForeColor = System.Drawing.Color.White;
            this.driversSw.LabelText = "Exclude Drivers from Update";
            this.driversSw.Location = new System.Drawing.Point(21, 417);
            this.driversSw.Margin = new System.Windows.Forms.Padding(6);
            this.driversSw.Name = "driversSw";
            this.driversSw.Size = new System.Drawing.Size(414, 24);
            this.driversSw.TabIndex = 95;
            this.driversSw.Tag = "themeable";
            this.driversSw.ToggleChecked = false;
            // 
            // telemetryServicesSw
            // 
            this.telemetryServicesSw.AccessibleName = "Disable Telemetry Services";
            this.telemetryServicesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.telemetryServicesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryServicesSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryServicesSw.ForeColor = System.Drawing.Color.White;
            this.telemetryServicesSw.LabelText = "Disable Telemetry Services";
            this.telemetryServicesSw.Location = new System.Drawing.Point(464, 40);
            this.telemetryServicesSw.Margin = new System.Windows.Forms.Padding(6);
            this.telemetryServicesSw.Name = "telemetryServicesSw";
            this.telemetryServicesSw.Size = new System.Drawing.Size(414, 24);
            this.telemetryServicesSw.TabIndex = 94;
            this.telemetryServicesSw.Tag = "themeable";
            this.telemetryServicesSw.ToggleChecked = false;
            // 
            // autoUpdatesSw
            // 
            this.autoUpdatesSw.AccessibleName = "Disable Automatic Updates";
            this.autoUpdatesSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoUpdatesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoUpdatesSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdatesSw.ForeColor = System.Drawing.Color.White;
            this.autoUpdatesSw.LabelText = "Disable Automatic Updates";
            this.autoUpdatesSw.Location = new System.Drawing.Point(20, 327);
            this.autoUpdatesSw.Margin = new System.Windows.Forms.Padding(6);
            this.autoUpdatesSw.Name = "autoUpdatesSw";
            this.autoUpdatesSw.Size = new System.Drawing.Size(414, 24);
            this.autoUpdatesSw.TabIndex = 93;
            this.autoUpdatesSw.Tag = "themeable";
            this.autoUpdatesSw.ToggleChecked = false;
            // 
            // tpmSw
            // 
            this.tpmSw.AccessibleName = "Disable TPM 2.0 Check";
            this.tpmSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.tpmSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpmSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpmSw.ForeColor = System.Drawing.Color.White;
            this.tpmSw.LabelText = "Disable TPM 2.0 Check";
            this.tpmSw.Location = new System.Drawing.Point(21, 130);
            this.tpmSw.Margin = new System.Windows.Forms.Padding(6);
            this.tpmSw.Name = "tpmSw";
            this.tpmSw.Size = new System.Drawing.Size(414, 24);
            this.tpmSw.TabIndex = 92;
            this.tpmSw.Tag = "themeable";
            this.tpmSw.ToggleChecked = false;
            // 
            // xboxSw
            // 
            this.xboxSw.AccessibleName = "Disable Xbox Live";
            this.xboxSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.xboxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xboxSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxSw.ForeColor = System.Drawing.Color.White;
            this.xboxSw.LabelText = "Disable Xbox Live";
            this.xboxSw.Location = new System.Drawing.Point(464, 220);
            this.xboxSw.Margin = new System.Windows.Forms.Padding(6);
            this.xboxSw.Name = "xboxSw";
            this.xboxSw.Size = new System.Drawing.Size(414, 24);
            this.xboxSw.TabIndex = 90;
            this.xboxSw.Tag = "themeable";
            this.xboxSw.ToggleChecked = false;
            // 
            // inkSw
            // 
            this.inkSw.AccessibleName = "Disable Windows Ink";
            this.inkSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.inkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inkSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkSw.ForeColor = System.Drawing.Color.White;
            this.inkSw.LabelText = "Disable Windows Ink";
            this.inkSw.Location = new System.Drawing.Point(464, 327);
            this.inkSw.Margin = new System.Windows.Forms.Padding(6);
            this.inkSw.Name = "inkSw";
            this.inkSw.Size = new System.Drawing.Size(414, 24);
            this.inkSw.TabIndex = 89;
            this.inkSw.Tag = "themeable";
            this.inkSw.ToggleChecked = false;
            // 
            // spellSw
            // 
            this.spellSw.AccessibleName = "Disable Spell Checking";
            this.spellSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.spellSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.spellSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellSw.ForeColor = System.Drawing.Color.White;
            this.spellSw.LabelText = "Disable Spell Checking";
            this.spellSw.Location = new System.Drawing.Point(464, 357);
            this.spellSw.Margin = new System.Windows.Forms.Padding(6);
            this.spellSw.Name = "spellSw";
            this.spellSw.Size = new System.Drawing.Size(414, 24);
            this.spellSw.TabIndex = 88;
            this.spellSw.Tag = "themeable";
            this.spellSw.ToggleChecked = false;
            // 
            // longPathsSw
            // 
            this.longPathsSw.AccessibleName = "Enable Long Paths";
            this.longPathsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.longPathsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.longPathsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPathsSw.ForeColor = System.Drawing.Color.White;
            this.longPathsSw.LabelText = "Enable Long Paths";
            this.longPathsSw.Location = new System.Drawing.Point(21, 100);
            this.longPathsSw.Margin = new System.Windows.Forms.Padding(6);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.Size = new System.Drawing.Size(414, 24);
            this.longPathsSw.TabIndex = 87;
            this.longPathsSw.Tag = "themeable";
            this.longPathsSw.ToggleChecked = false;
            // 
            // uODSw
            // 
            this.uODSw.AccessibleName = "Uninstall OneDrive";
            this.uODSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.uODSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uODSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.ForeColor = System.Drawing.Color.White;
            this.uODSw.LabelText = "Uninstall OneDrive";
            this.uODSw.Location = new System.Drawing.Point(22, 250);
            this.uODSw.Margin = new System.Windows.Forms.Padding(6);
            this.uODSw.Name = "uODSw";
            this.uODSw.Size = new System.Drawing.Size(414, 24);
            this.uODSw.TabIndex = 86;
            this.uODSw.Tag = "themeable";
            this.uODSw.ToggleChecked = false;
            // 
            // peopleSw
            // 
            this.peopleSw.AccessibleName = "Disable My People";
            this.peopleSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.peopleSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.peopleSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.ForeColor = System.Drawing.Color.White;
            this.peopleSw.LabelText = "Disable My People";
            this.peopleSw.Location = new System.Drawing.Point(21, 70);
            this.peopleSw.Margin = new System.Windows.Forms.Padding(6);
            this.peopleSw.Name = "peopleSw";
            this.peopleSw.Size = new System.Drawing.Size(414, 24);
            this.peopleSw.TabIndex = 85;
            this.peopleSw.Tag = "themeable";
            this.peopleSw.ToggleChecked = false;
            // 
            // oldExplorerSw
            // 
            this.oldExplorerSw.AccessibleName = "Restore Classic Windows Explorer";
            this.oldExplorerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.oldExplorerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldExplorerSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldExplorerSw.ForeColor = System.Drawing.Color.White;
            this.oldExplorerSw.LabelText = "Restore Classic Windows Explorer";
            this.oldExplorerSw.Location = new System.Drawing.Point(20, 40);
            this.oldExplorerSw.Margin = new System.Windows.Forms.Padding(6);
            this.oldExplorerSw.Name = "oldExplorerSw";
            this.oldExplorerSw.Size = new System.Drawing.Size(414, 24);
            this.oldExplorerSw.TabIndex = 83;
            this.oldExplorerSw.Tag = "themeable";
            this.oldExplorerSw.ToggleChecked = false;
            // 
            // adsSw
            // 
            this.adsSw.AccessibleName = "Disable Start Menu Ads";
            this.adsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.adsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsSw.ForeColor = System.Drawing.Color.White;
            this.adsSw.LabelText = "Disable Start Menu Ads";
            this.adsSw.Location = new System.Drawing.Point(464, 130);
            this.adsSw.Margin = new System.Windows.Forms.Padding(6);
            this.adsSw.Name = "adsSw";
            this.adsSw.Size = new System.Drawing.Size(414, 24);
            this.adsSw.TabIndex = 82;
            this.adsSw.Tag = "themeable";
            this.adsSw.ToggleChecked = false;
            // 
            // windows8Tab
            // 
            this.windows8Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows8Tab.Controls.Add(this.label21);
            this.windows8Tab.Controls.Add(this.disableOneDriveSw);
            this.windows8Tab.Location = new System.Drawing.Point(4, 25);
            this.windows8Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows8Tab.Name = "windows8Tab";
            this.windows8Tab.Padding = new System.Windows.Forms.Padding(2);
            this.windows8Tab.Size = new System.Drawing.Size(974, 653);
            this.windows8Tab.TabIndex = 2;
            this.windows8Tab.Text = "Windows 8.1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(17, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 19);
            this.label21.TabIndex = 170;
            this.label21.Tag = "";
            this.label21.Text = "System";
            // 
            // disableOneDriveSw
            // 
            this.disableOneDriveSw.AccessibleName = "Disable OneDrive";
            this.disableOneDriveSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.disableOneDriveSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disableOneDriveSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.ForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.LabelText = "Disable OneDrive";
            this.disableOneDriveSw.Location = new System.Drawing.Point(20, 40);
            this.disableOneDriveSw.Margin = new System.Windows.Forms.Padding(6);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.Size = new System.Drawing.Size(500, 24);
            this.disableOneDriveSw.TabIndex = 84;
            this.disableOneDriveSw.Tag = "themeable";
            this.disableOneDriveSw.ToggleChecked = false;
            // 
            // modernAppsTab
            // 
            this.modernAppsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modernAppsTab.Controls.Add(this.btnRestoreUwp);
            this.modernAppsTab.Controls.Add(this.panelUwp);
            this.modernAppsTab.Controls.Add(this.uninstallModernAppsButton);
            this.modernAppsTab.Controls.Add(this.refreshModernAppsButton);
            this.modernAppsTab.Controls.Add(this.txtModernAppsTitle);
            this.modernAppsTab.Controls.Add(this.chkOnlyRemovable);
            this.modernAppsTab.Controls.Add(this.chkSelectAllModernApps);
            this.modernAppsTab.Location = new System.Drawing.Point(4, 25);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(3);
            this.modernAppsTab.Size = new System.Drawing.Size(974, 653);
            this.modernAppsTab.TabIndex = 11;
            this.modernAppsTab.Text = "UWP Apps";
            // 
            // btnRestoreUwp
            // 
            this.btnRestoreUwp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestoreUwp.FlatAppearance.BorderSize = 0;
            this.btnRestoreUwp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestoreUwp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestoreUwp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreUwp.ForeColor = System.Drawing.Color.White;
            this.btnRestoreUwp.Location = new System.Drawing.Point(11, 544);
            this.btnRestoreUwp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreUwp.Name = "btnRestoreUwp";
            this.btnRestoreUwp.Size = new System.Drawing.Size(299, 31);
            this.btnRestoreUwp.TabIndex = 55;
            this.btnRestoreUwp.Text = "Restore all UWP";
            this.btnRestoreUwp.UseVisualStyleBackColor = false;
            this.btnRestoreUwp.Click += new System.EventHandler(this.btnRestoreUwp_Click);
            // 
            // panelUwp
            // 
            this.panelUwp.AutoScroll = true;
            this.panelUwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUwp.Location = new System.Drawing.Point(11, 41);
            this.panelUwp.Name = "panelUwp";
            this.panelUwp.Size = new System.Drawing.Size(569, 498);
            this.panelUwp.TabIndex = 54;
            // 
            // uninstallModernAppsButton
            // 
            this.uninstallModernAppsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.uninstallModernAppsButton.FlatAppearance.BorderSize = 0;
            this.uninstallModernAppsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.uninstallModernAppsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.uninstallModernAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallModernAppsButton.ForeColor = System.Drawing.Color.White;
            this.uninstallModernAppsButton.Location = new System.Drawing.Point(585, 76);
            this.uninstallModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
            this.uninstallModernAppsButton.Size = new System.Drawing.Size(208, 31);
            this.uninstallModernAppsButton.TabIndex = 50;
            this.uninstallModernAppsButton.Text = "Uninstall";
            this.uninstallModernAppsButton.UseVisualStyleBackColor = false;
            this.uninstallModernAppsButton.Click += new System.EventHandler(this.button74_Click);
            // 
            // refreshModernAppsButton
            // 
            this.refreshModernAppsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshModernAppsButton.FlatAppearance.BorderSize = 0;
            this.refreshModernAppsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshModernAppsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshModernAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshModernAppsButton.ForeColor = System.Drawing.Color.White;
            this.refreshModernAppsButton.Location = new System.Drawing.Point(585, 41);
            this.refreshModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshModernAppsButton.Name = "refreshModernAppsButton";
            this.refreshModernAppsButton.Size = new System.Drawing.Size(208, 31);
            this.refreshModernAppsButton.TabIndex = 49;
            this.refreshModernAppsButton.Text = "Refresh";
            this.refreshModernAppsButton.UseVisualStyleBackColor = false;
            this.refreshModernAppsButton.Click += new System.EventHandler(this.button75_Click);
            // 
            // txtModernAppsTitle
            // 
            this.txtModernAppsTitle.AutoSize = true;
            this.txtModernAppsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModernAppsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtModernAppsTitle.Location = new System.Drawing.Point(6, 10);
            this.txtModernAppsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtModernAppsTitle.Name = "txtModernAppsTitle";
            this.txtModernAppsTitle.Size = new System.Drawing.Size(291, 28);
            this.txtModernAppsTitle.TabIndex = 47;
            this.txtModernAppsTitle.Tag = "themeable";
            this.txtModernAppsTitle.Text = "Uninstall unwanted UWP Apps";
            // 
            // chkOnlyRemovable
            // 
            this.chkOnlyRemovable.AutoSize = true;
            this.chkOnlyRemovable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.chkOnlyRemovable.ForeColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Location = new System.Drawing.Point(585, 111);
            this.chkOnlyRemovable.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnlyRemovable.Name = "chkOnlyRemovable";
            this.chkOnlyRemovable.Size = new System.Drawing.Size(170, 25);
            this.chkOnlyRemovable.TabIndex = 53;
            this.chkOnlyRemovable.Text = "Only uninstall-ables";
            this.chkOnlyRemovable.UseVisualStyleBackColor = true;
            this.chkOnlyRemovable.CheckedChanged += new System.EventHandler(this.chkOnlyRemovable_CheckedChanged);
            // 
            // chkSelectAllModernApps
            // 
            this.chkSelectAllModernApps.AutoSize = true;
            this.chkSelectAllModernApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAllModernApps.ForeColor = System.Drawing.Color.White;
            this.chkSelectAllModernApps.Location = new System.Drawing.Point(585, 140);
            this.chkSelectAllModernApps.Margin = new System.Windows.Forms.Padding(2);
            this.chkSelectAllModernApps.Name = "chkSelectAllModernApps";
            this.chkSelectAllModernApps.Size = new System.Drawing.Size(94, 25);
            this.chkSelectAllModernApps.TabIndex = 52;
            this.chkSelectAllModernApps.Text = "Select all";
            this.chkSelectAllModernApps.UseVisualStyleBackColor = true;
            this.chkSelectAllModernApps.CheckedChanged += new System.EventHandler(this.chkSelectAllModernApps_CheckedChanged);
            // 
            // startupTab
            // 
            this.startupTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startupTab.Controls.Add(this.cancelBackup);
            this.startupTab.Controls.Add(this.doBackup);
            this.startupTab.Controls.Add(this.txtBackupTitle);
            this.startupTab.Controls.Add(this.lblBackupTitle);
            this.startupTab.Controls.Add(this.restoreStartupB);
            this.startupTab.Controls.Add(this.backupStartupB);
            this.startupTab.Controls.Add(this.findInRegB);
            this.startupTab.Controls.Add(this.locateFileB);
            this.startupTab.Controls.Add(this.refreshStartupB);
            this.startupTab.Controls.Add(this.panel3);
            this.startupTab.Controls.Add(this.removeStartupItemB);
            this.startupTab.Controls.Add(this.startupTitle);
            this.startupTab.Location = new System.Drawing.Point(4, 25);
            this.startupTab.Margin = new System.Windows.Forms.Padding(2);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(974, 653);
            this.startupTab.TabIndex = 7;
            this.startupTab.Text = "Startup";
            // 
            // cancelBackup
            // 
            this.cancelBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.BorderSize = 0;
            this.cancelBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.ForeColor = System.Drawing.Color.White;
            this.cancelBackup.Location = new System.Drawing.Point(126, 551);
            this.cancelBackup.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBackup.Name = "cancelBackup";
            this.cancelBackup.Size = new System.Drawing.Size(110, 30);
            this.cancelBackup.TabIndex = 61;
            this.cancelBackup.Text = "Cancel";
            this.cancelBackup.UseVisualStyleBackColor = false;
            this.cancelBackup.Visible = false;
            this.cancelBackup.Click += new System.EventHandler(this.button14_Click);
            // 
            // doBackup
            // 
            this.doBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.doBackup.FlatAppearance.BorderSize = 0;
            this.doBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doBackup.ForeColor = System.Drawing.Color.White;
            this.doBackup.Location = new System.Drawing.Point(12, 551);
            this.doBackup.Margin = new System.Windows.Forms.Padding(2);
            this.doBackup.Name = "doBackup";
            this.doBackup.Size = new System.Drawing.Size(110, 30);
            this.doBackup.TabIndex = 60;
            this.doBackup.Text = "OK";
            this.doBackup.UseVisualStyleBackColor = false;
            this.doBackup.Visible = false;
            this.doBackup.Click += new System.EventHandler(this.button13_Click);
            // 
            // txtBackupTitle
            // 
            this.txtBackupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBackupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupTitle.ForeColor = System.Drawing.Color.White;
            this.txtBackupTitle.Location = new System.Drawing.Point(12, 522);
            this.txtBackupTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackupTitle.Name = "txtBackupTitle";
            this.txtBackupTitle.Size = new System.Drawing.Size(323, 25);
            this.txtBackupTitle.TabIndex = 58;
            this.txtBackupTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBackupTitle.Visible = false;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblBackupTitle.Location = new System.Drawing.Point(8, 501);
            this.lblBackupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(86, 19);
            this.lblBackupTitle.TabIndex = 59;
            this.lblBackupTitle.Tag = "";
            this.lblBackupTitle.Text = "Backup title:";
            this.lblBackupTitle.Visible = false;
            // 
            // restoreStartupB
            // 
            this.restoreStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.restoreStartupB.FlatAppearance.BorderSize = 0;
            this.restoreStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreStartupB.ForeColor = System.Drawing.Color.White;
            this.restoreStartupB.Location = new System.Drawing.Point(206, 502);
            this.restoreStartupB.Margin = new System.Windows.Forms.Padding(2);
            this.restoreStartupB.Name = "restoreStartupB";
            this.restoreStartupB.Size = new System.Drawing.Size(190, 31);
            this.restoreStartupB.TabIndex = 42;
            this.restoreStartupB.Text = "Restore";
            this.restoreStartupB.UseVisualStyleBackColor = false;
            this.restoreStartupB.Click += new System.EventHandler(this.button12_Click);
            // 
            // backupStartupB
            // 
            this.backupStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.backupStartupB.FlatAppearance.BorderSize = 0;
            this.backupStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupStartupB.ForeColor = System.Drawing.Color.White;
            this.backupStartupB.Location = new System.Drawing.Point(12, 502);
            this.backupStartupB.Margin = new System.Windows.Forms.Padding(2);
            this.backupStartupB.Name = "backupStartupB";
            this.backupStartupB.Size = new System.Drawing.Size(190, 31);
            this.backupStartupB.TabIndex = 41;
            this.backupStartupB.Text = "Backup";
            this.backupStartupB.UseVisualStyleBackColor = false;
            this.backupStartupB.Click += new System.EventHandler(this.button11_Click);
            // 
            // findInRegB
            // 
            this.findInRegB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findInRegB.BackColor = System.Drawing.Color.DodgerBlue;
            this.findInRegB.FlatAppearance.BorderSize = 0;
            this.findInRegB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findInRegB.ForeColor = System.Drawing.Color.White;
            this.findInRegB.Location = new System.Drawing.Point(575, 538);
            this.findInRegB.Margin = new System.Windows.Forms.Padding(2);
            this.findInRegB.Name = "findInRegB";
            this.findInRegB.Size = new System.Drawing.Size(190, 31);
            this.findInRegB.TabIndex = 40;
            this.findInRegB.Text = "Find in Registry";
            this.findInRegB.UseVisualStyleBackColor = false;
            this.findInRegB.Click += new System.EventHandler(this.button64_Click);
            // 
            // locateFileB
            // 
            this.locateFileB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.locateFileB.BackColor = System.Drawing.Color.DodgerBlue;
            this.locateFileB.FlatAppearance.BorderSize = 0;
            this.locateFileB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locateFileB.ForeColor = System.Drawing.Color.White;
            this.locateFileB.Location = new System.Drawing.Point(769, 503);
            this.locateFileB.Margin = new System.Windows.Forms.Padding(2);
            this.locateFileB.Name = "locateFileB";
            this.locateFileB.Size = new System.Drawing.Size(190, 31);
            this.locateFileB.TabIndex = 39;
            this.locateFileB.Text = "Locate file";
            this.locateFileB.UseVisualStyleBackColor = false;
            this.locateFileB.Click += new System.EventHandler(this.button31_Click);
            // 
            // refreshStartupB
            // 
            this.refreshStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshStartupB.FlatAppearance.BorderSize = 0;
            this.refreshStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshStartupB.ForeColor = System.Drawing.Color.White;
            this.refreshStartupB.Location = new System.Drawing.Point(769, 538);
            this.refreshStartupB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshStartupB.Name = "refreshStartupB";
            this.refreshStartupB.Size = new System.Drawing.Size(190, 31);
            this.refreshStartupB.TabIndex = 38;
            this.refreshStartupB.Text = "Refresh";
            this.refreshStartupB.UseVisualStyleBackColor = false;
            this.refreshStartupB.Click += new System.EventHandler(this.button37_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listStartupItems);
            this.panel3.Location = new System.Drawing.Point(11, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 459);
            this.panel3.TabIndex = 37;
            // 
            // listStartupItems
            // 
            this.listStartupItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listStartupItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listStartupItems.CheckBoxes = true;
            this.listStartupItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listStartupItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStartupItems.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStartupItems.ForeColor = System.Drawing.Color.MediumOrchid;
            this.listStartupItems.FullRowSelect = true;
            this.listStartupItems.HideSelection = false;
            this.listStartupItems.Location = new System.Drawing.Point(0, 0);
            this.listStartupItems.Margin = new System.Windows.Forms.Padding(2);
            this.listStartupItems.MultiSelect = false;
            this.listStartupItems.Name = "listStartupItems";
            this.listStartupItems.ShowGroups = false;
            this.listStartupItems.Size = new System.Drawing.Size(946, 457);
            this.listStartupItems.TabIndex = 0;
            this.listStartupItems.UseCompatibleStateImageBehavior = false;
            this.listStartupItems.View = System.Windows.Forms.View.Details;
            this.listStartupItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listStartupItems_ColumnClick);
            this.listStartupItems.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listStartupItems_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 507;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 134;
            // 
            // removeStartupItemB
            // 
            this.removeStartupItemB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeStartupItemB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeStartupItemB.FlatAppearance.BorderSize = 0;
            this.removeStartupItemB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStartupItemB.ForeColor = System.Drawing.Color.White;
            this.removeStartupItemB.Location = new System.Drawing.Point(575, 503);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(2);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(190, 31);
            this.removeStartupItemB.TabIndex = 36;
            this.removeStartupItemB.Text = "Delete";
            this.removeStartupItemB.UseVisualStyleBackColor = false;
            this.removeStartupItemB.Click += new System.EventHandler(this.button32_Click);
            // 
            // startupTitle
            // 
            this.startupTitle.AutoSize = true;
            this.startupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.startupTitle.Location = new System.Drawing.Point(6, 10);
            this.startupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startupTitle.Name = "startupTitle";
            this.startupTitle.Size = new System.Drawing.Size(254, 28);
            this.startupTitle.TabIndex = 3;
            this.startupTitle.Tag = "themeable";
            this.startupTitle.Text = "Choose your startup items";
            // 
            // appsTab
            // 
            this.appsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.appsTab.Controls.Add(this.txtFeedError);
            this.appsTab.Controls.Add(this.lblVideoSound);
            this.appsTab.Controls.Add(this.lblCoding);
            this.appsTab.Controls.Add(this.lblSystemTools);
            this.appsTab.Controls.Add(this.groupSoundVideo);
            this.appsTab.Controls.Add(this.lblInternet);
            this.appsTab.Controls.Add(this.groupCoding);
            this.appsTab.Controls.Add(this.groupInternet);
            this.appsTab.Controls.Add(this.panel10);
            this.appsTab.Controls.Add(this.panelCommonApps);
            this.appsTab.Controls.Add(this.groupSystemTools);
            this.appsTab.Location = new System.Drawing.Point(4, 25);
            this.appsTab.Name = "appsTab";
            this.appsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appsTab.Size = new System.Drawing.Size(974, 653);
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
            this.txtFeedError.Size = new System.Drawing.Size(968, 483);
            this.txtFeedError.TabIndex = 171;
            this.txtFeedError.Text = "No internet connection, try refreshing links again";
            this.txtFeedError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFeedError.Visible = false;
            // 
            // lblVideoSound
            // 
            this.lblVideoSound.AutoSize = true;
            this.lblVideoSound.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoSound.ForeColor = System.Drawing.Color.Silver;
            this.lblVideoSound.Location = new System.Drawing.Point(746, 46);
            this.lblVideoSound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideoSound.Name = "lblVideoSound";
            this.lblVideoSound.Size = new System.Drawing.Size(88, 15);
            this.lblVideoSound.TabIndex = 169;
            this.lblVideoSound.Tag = "";
            this.lblVideoSound.Text = "Video && Sound";
            // 
            // lblCoding
            // 
            this.lblCoding.AutoSize = true;
            this.lblCoding.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoding.ForeColor = System.Drawing.Color.Silver;
            this.lblCoding.Location = new System.Drawing.Point(514, 46);
            this.lblCoding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Size = new System.Drawing.Size(45, 15);
            this.lblCoding.TabIndex = 168;
            this.lblCoding.Tag = "";
            this.lblCoding.Text = "Coding";
            // 
            // lblSystemTools
            // 
            this.lblSystemTools.AutoSize = true;
            this.lblSystemTools.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTools.ForeColor = System.Drawing.Color.Silver;
            this.lblSystemTools.Location = new System.Drawing.Point(11, 46);
            this.lblSystemTools.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemTools.Name = "lblSystemTools";
            this.lblSystemTools.Size = new System.Drawing.Size(89, 15);
            this.lblSystemTools.TabIndex = 162;
            this.lblSystemTools.Tag = "";
            this.lblSystemTools.Text = "System && Tools";
            // 
            // groupSoundVideo
            // 
            this.groupSoundVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSoundVideo.AutoScroll = true;
            this.groupSoundVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupSoundVideo.Location = new System.Drawing.Point(749, 64);
            this.groupSoundVideo.Name = "groupSoundVideo";
            this.groupSoundVideo.Size = new System.Drawing.Size(227, 465);
            this.groupSoundVideo.TabIndex = 166;
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.ForeColor = System.Drawing.Color.Silver;
            this.lblInternet.Location = new System.Drawing.Point(262, 46);
            this.lblInternet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(49, 15);
            this.lblInternet.TabIndex = 167;
            this.lblInternet.Tag = "";
            this.lblInternet.Text = "Internet";
            // 
            // groupCoding
            // 
            this.groupCoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupCoding.AutoScroll = true;
            this.groupCoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupCoding.Location = new System.Drawing.Point(517, 64);
            this.groupCoding.Name = "groupCoding";
            this.groupCoding.Size = new System.Drawing.Size(226, 465);
            this.groupCoding.TabIndex = 165;
            // 
            // groupInternet
            // 
            this.groupInternet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInternet.AutoScroll = true;
            this.groupInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupInternet.Location = new System.Drawing.Point(265, 64);
            this.groupInternet.Name = "groupInternet";
            this.groupInternet.Size = new System.Drawing.Size(246, 465);
            this.groupInternet.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(968, 44);
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
            this.btnGetFeed.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetFeed.FlatAppearance.BorderSize = 0;
            this.btnGetFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFeed.ForeColor = System.Drawing.Color.White;
            this.btnGetFeed.Location = new System.Drawing.Point(763, 7);
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
            this.panelCommonApps.Location = new System.Drawing.Point(3, 530);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(968, 120);
            this.panelCommonApps.TabIndex = 162;
            // 
            // cAutoInstall
            // 
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cAutoInstall.Location = new System.Drawing.Point(558, 53);
            this.cAutoInstall.Name = "cAutoInstall";
            this.cAutoInstall.Size = new System.Drawing.Size(369, 24);
            this.cAutoInstall.TabIndex = 107;
            this.cAutoInstall.Text = "Install after downloading";
            this.cAutoInstall.UseVisualStyleBackColor = true;
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
            this.c64.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c64.Location = new System.Drawing.Point(373, 28);
            this.c64.Name = "c64";
            this.c64.Size = new System.Drawing.Size(72, 25);
            this.c64.TabIndex = 75;
            this.c64.TabStop = true;
            this.c64.Text = "64-bit";
            this.c64.UseVisualStyleBackColor = true;
            // 
            // c32
            // 
            this.c32.AutoSize = true;
            this.c32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c32.Location = new System.Drawing.Point(448, 28);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(72, 25);
            this.c32.TabIndex = 76;
            this.c32.TabStop = true;
            this.c32.Text = "32-bit";
            this.c32.UseVisualStyleBackColor = true;
            // 
            // btnDownloadApps
            // 
            this.btnDownloadApps.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadApps.FlatAppearance.BorderSize = 0;
            this.btnDownloadApps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadApps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadApps.ForeColor = System.Drawing.Color.White;
            this.btnDownloadApps.Location = new System.Drawing.Point(765, 82);
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
            this.txtDownloadFolder.Size = new System.Drawing.Size(302, 23);
            this.txtDownloadFolder.TabIndex = 70;
            this.txtDownloadFolder.TextChanged += new System.EventHandler(this.txtDownloadFolder_TextChanged);
            // 
            // changeDownDirB
            // 
            this.changeDownDirB.BackColor = System.Drawing.Color.DodgerBlue;
            this.changeDownDirB.FlatAppearance.BorderSize = 0;
            this.changeDownDirB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.changeDownDirB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.changeDownDirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDownDirB.ForeColor = System.Drawing.Color.White;
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
            this.goToDownloadsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.goToDownloadsB.FlatAppearance.BorderSize = 0;
            this.goToDownloadsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDownloadsB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToDownloadsB.ForeColor = System.Drawing.Color.White;
            this.goToDownloadsB.Location = new System.Drawing.Point(558, 82);
            this.goToDownloadsB.Margin = new System.Windows.Forms.Padding(2);
            this.goToDownloadsB.Name = "goToDownloadsB";
            this.goToDownloadsB.Size = new System.Drawing.Size(203, 35);
            this.goToDownloadsB.TabIndex = 77;
            this.goToDownloadsB.Text = "Go to Downloads";
            this.goToDownloadsB.UseVisualStyleBackColor = false;
            this.goToDownloadsB.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupSystemTools
            // 
            this.groupSystemTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupSystemTools.AutoScroll = true;
            this.groupSystemTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupSystemTools.Location = new System.Drawing.Point(13, 64);
            this.groupSystemTools.Name = "groupSystemTools";
            this.groupSystemTools.Size = new System.Drawing.Size(246, 524);
            this.groupSystemTools.TabIndex = 162;
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
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Size = new System.Drawing.Size(974, 653);
            this.cleanerTab.TabIndex = 5;
            this.cleanerTab.Text = "Cleaner";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.listCleanPreview);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(221, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(751, 588);
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
            this.listCleanPreview.Location = new System.Drawing.Point(0, 0);
            this.listCleanPreview.Name = "listCleanPreview";
            this.listCleanPreview.Size = new System.Drawing.Size(749, 586);
            this.listCleanPreview.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btnWinClean);
            this.panel13.Controls.Add(this.analyzeDriveB);
            this.panel13.Controls.Add(this.checkSelectAll);
            this.panel13.Controls.Add(this.lblPretext);
            this.panel13.Controls.Add(this.cleanDriveB);
            this.panel13.Controls.Add(this.lblFootprint);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(221, 590);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(751, 61);
            this.panel13.TabIndex = 50;
            // 
            // btnWinClean
            // 
            this.btnWinClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClean.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnWinClean.FlatAppearance.BorderSize = 0;
            this.btnWinClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWinClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWinClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClean.ForeColor = System.Drawing.Color.White;
            this.btnWinClean.Location = new System.Drawing.Point(317, 23);
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
            this.analyzeDriveB.BackColor = System.Drawing.Color.DodgerBlue;
            this.analyzeDriveB.FlatAppearance.BorderSize = 0;
            this.analyzeDriveB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.analyzeDriveB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.analyzeDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeDriveB.ForeColor = System.Drawing.Color.White;
            this.analyzeDriveB.Location = new System.Drawing.Point(461, 23);
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
            this.checkSelectAll.Location = new System.Drawing.Point(498, 1);
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
            this.cleanDriveB.BackColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.BorderSize = 0;
            this.cleanDriveB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanDriveB.ForeColor = System.Drawing.Color.White;
            this.cleanDriveB.Location = new System.Drawing.Point(605, 23);
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
            this.lblFootprint.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 649);
            this.panel1.TabIndex = 47;
            // 
            // bravePasswords
            // 
            this.bravePasswords.AutoSize = true;
            this.bravePasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bravePasswords.ForeColor = System.Drawing.Color.White;
            this.bravePasswords.Location = new System.Drawing.Point(9, 676);
            this.bravePasswords.Margin = new System.Windows.Forms.Padding(2);
            this.bravePasswords.Name = "bravePasswords";
            this.bravePasswords.Size = new System.Drawing.Size(93, 23);
            this.bravePasswords.TabIndex = 78;
            this.bravePasswords.Text = "Passwords";
            this.bravePasswords.UseVisualStyleBackColor = true;
            // 
            // braveSession
            // 
            this.braveSession.AutoSize = true;
            this.braveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveSession.ForeColor = System.Drawing.Color.White;
            this.braveSession.Location = new System.Drawing.Point(9, 649);
            this.braveSession.Margin = new System.Windows.Forms.Padding(2);
            this.braveSession.Name = "braveSession";
            this.braveSession.Size = new System.Drawing.Size(75, 23);
            this.braveSession.TabIndex = 77;
            this.braveSession.Text = "Session";
            this.braveSession.UseVisualStyleBackColor = true;
            // 
            // braveHistory
            // 
            this.braveHistory.AutoSize = true;
            this.braveHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveHistory.ForeColor = System.Drawing.Color.White;
            this.braveHistory.Location = new System.Drawing.Point(9, 622);
            this.braveHistory.Margin = new System.Windows.Forms.Padding(2);
            this.braveHistory.Name = "braveHistory";
            this.braveHistory.Size = new System.Drawing.Size(74, 23);
            this.braveHistory.TabIndex = 76;
            this.braveHistory.Text = "History";
            this.braveHistory.UseVisualStyleBackColor = true;
            // 
            // braveCookies
            // 
            this.braveCookies.AutoSize = true;
            this.braveCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCookies.ForeColor = System.Drawing.Color.White;
            this.braveCookies.Location = new System.Drawing.Point(9, 595);
            this.braveCookies.Margin = new System.Windows.Forms.Padding(2);
            this.braveCookies.Name = "braveCookies";
            this.braveCookies.Size = new System.Drawing.Size(77, 23);
            this.braveCookies.TabIndex = 75;
            this.braveCookies.Text = "Cookies";
            this.braveCookies.UseVisualStyleBackColor = true;
            // 
            // braveCache
            // 
            this.braveCache.AutoSize = true;
            this.braveCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCache.ForeColor = System.Drawing.Color.White;
            this.braveCache.Location = new System.Drawing.Point(9, 568);
            this.braveCache.Margin = new System.Windows.Forms.Padding(2);
            this.braveCache.Name = "braveCache";
            this.braveCache.Size = new System.Drawing.Size(66, 23);
            this.braveCache.TabIndex = 74;
            this.braveCache.Text = "Cache";
            this.braveCache.UseVisualStyleBackColor = true;
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
            this.edgeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeSession.ForeColor = System.Drawing.Color.White;
            this.edgeSession.Location = new System.Drawing.Point(9, 516);
            this.edgeSession.Margin = new System.Windows.Forms.Padding(2);
            this.edgeSession.Name = "edgeSession";
            this.edgeSession.Size = new System.Drawing.Size(75, 23);
            this.edgeSession.TabIndex = 69;
            this.edgeSession.Text = "Session";
            this.edgeSession.UseVisualStyleBackColor = true;
            // 
            // edgeHistory
            // 
            this.edgeHistory.AutoSize = true;
            this.edgeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeHistory.ForeColor = System.Drawing.Color.White;
            this.edgeHistory.Location = new System.Drawing.Point(9, 489);
            this.edgeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.edgeHistory.Name = "edgeHistory";
            this.edgeHistory.Size = new System.Drawing.Size(74, 23);
            this.edgeHistory.TabIndex = 68;
            this.edgeHistory.Text = "History";
            this.edgeHistory.UseVisualStyleBackColor = true;
            // 
            // edgeCookies
            // 
            this.edgeCookies.AutoSize = true;
            this.edgeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCookies.ForeColor = System.Drawing.Color.White;
            this.edgeCookies.Location = new System.Drawing.Point(9, 462);
            this.edgeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCookies.Name = "edgeCookies";
            this.edgeCookies.Size = new System.Drawing.Size(77, 23);
            this.edgeCookies.TabIndex = 67;
            this.edgeCookies.Text = "Cookies";
            this.edgeCookies.UseVisualStyleBackColor = true;
            // 
            // edgeCache
            // 
            this.edgeCache.AutoSize = true;
            this.edgeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCache.ForeColor = System.Drawing.Color.White;
            this.edgeCache.Location = new System.Drawing.Point(9, 435);
            this.edgeCache.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCache.Name = "edgeCache";
            this.edgeCache.Size = new System.Drawing.Size(66, 23);
            this.edgeCache.TabIndex = 66;
            this.edgeCache.Text = "Cache";
            this.edgeCache.UseVisualStyleBackColor = true;
            // 
            // IECache
            // 
            this.IECache.AutoSize = true;
            this.IECache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IECache.ForeColor = System.Drawing.Color.White;
            this.IECache.Location = new System.Drawing.Point(10, 725);
            this.IECache.Margin = new System.Windows.Forms.Padding(2);
            this.IECache.Name = "IECache";
            this.IECache.Size = new System.Drawing.Size(66, 23);
            this.IECache.TabIndex = 65;
            this.IECache.Text = "Cache";
            this.IECache.UseVisualStyleBackColor = true;
            // 
            // firefoxHistory
            // 
            this.firefoxHistory.AutoSize = true;
            this.firefoxHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxHistory.ForeColor = System.Drawing.Color.White;
            this.firefoxHistory.Location = new System.Drawing.Point(9, 384);
            this.firefoxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxHistory.Name = "firefoxHistory";
            this.firefoxHistory.Size = new System.Drawing.Size(74, 23);
            this.firefoxHistory.TabIndex = 64;
            this.firefoxHistory.Text = "History";
            this.firefoxHistory.UseVisualStyleBackColor = true;
            // 
            // firefoxCookies
            // 
            this.firefoxCookies.AutoSize = true;
            this.firefoxCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCookies.ForeColor = System.Drawing.Color.White;
            this.firefoxCookies.Location = new System.Drawing.Point(9, 357);
            this.firefoxCookies.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCookies.Name = "firefoxCookies";
            this.firefoxCookies.Size = new System.Drawing.Size(77, 23);
            this.firefoxCookies.TabIndex = 63;
            this.firefoxCookies.Text = "Cookies";
            this.firefoxCookies.UseVisualStyleBackColor = true;
            // 
            // firefoxCache
            // 
            this.firefoxCache.AutoSize = true;
            this.firefoxCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCache.ForeColor = System.Drawing.Color.White;
            this.firefoxCache.Location = new System.Drawing.Point(9, 330);
            this.firefoxCache.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCache.Name = "firefoxCache";
            this.firefoxCache.Size = new System.Drawing.Size(66, 23);
            this.firefoxCache.TabIndex = 62;
            this.firefoxCache.Text = "Cache";
            this.firefoxCache.UseVisualStyleBackColor = true;
            // 
            // chromePws
            // 
            this.chromePws.AutoSize = true;
            this.chromePws.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromePws.ForeColor = System.Drawing.Color.White;
            this.chromePws.Location = new System.Drawing.Point(8, 278);
            this.chromePws.Margin = new System.Windows.Forms.Padding(2);
            this.chromePws.Name = "chromePws";
            this.chromePws.Size = new System.Drawing.Size(93, 23);
            this.chromePws.TabIndex = 61;
            this.chromePws.Text = "Passwords";
            this.chromePws.UseVisualStyleBackColor = true;
            // 
            // chromeSession
            // 
            this.chromeSession.AutoSize = true;
            this.chromeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeSession.ForeColor = System.Drawing.Color.White;
            this.chromeSession.Location = new System.Drawing.Point(8, 251);
            this.chromeSession.Margin = new System.Windows.Forms.Padding(2);
            this.chromeSession.Name = "chromeSession";
            this.chromeSession.Size = new System.Drawing.Size(75, 23);
            this.chromeSession.TabIndex = 60;
            this.chromeSession.Text = "Session";
            this.chromeSession.UseVisualStyleBackColor = true;
            // 
            // chromeHistory
            // 
            this.chromeHistory.AutoSize = true;
            this.chromeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeHistory.ForeColor = System.Drawing.Color.White;
            this.chromeHistory.Location = new System.Drawing.Point(8, 224);
            this.chromeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.chromeHistory.Name = "chromeHistory";
            this.chromeHistory.Size = new System.Drawing.Size(74, 23);
            this.chromeHistory.TabIndex = 59;
            this.chromeHistory.Text = "History";
            this.chromeHistory.UseVisualStyleBackColor = true;
            // 
            // chromeCookies
            // 
            this.chromeCookies.AutoSize = true;
            this.chromeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCookies.ForeColor = System.Drawing.Color.White;
            this.chromeCookies.Location = new System.Drawing.Point(8, 197);
            this.chromeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCookies.Name = "chromeCookies";
            this.chromeCookies.Size = new System.Drawing.Size(77, 23);
            this.chromeCookies.TabIndex = 58;
            this.chromeCookies.Text = "Cookies";
            this.chromeCookies.UseVisualStyleBackColor = true;
            // 
            // chromeCache
            // 
            this.chromeCache.AutoSize = true;
            this.chromeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCache.ForeColor = System.Drawing.Color.White;
            this.chromeCache.Location = new System.Drawing.Point(8, 170);
            this.chromeCache.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCache.Name = "chromeCache";
            this.chromeCache.Size = new System.Drawing.Size(66, 23);
            this.chromeCache.TabIndex = 57;
            this.chromeCache.Text = "Cache";
            this.chromeCache.UseVisualStyleBackColor = true;
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
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(8, 91);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.Size = new System.Drawing.Size(106, 23);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.Text = "Error reports";
            this.checkErrorReports.UseVisualStyleBackColor = true;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTemp.ForeColor = System.Drawing.Color.White;
            this.checkTemp.Location = new System.Drawing.Point(8, 37);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(125, 23);
            this.checkTemp.TabIndex = 36;
            this.checkTemp.Text = "Temporary files";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkBin
            // 
            this.checkBin.AutoSize = true;
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.White;
            this.checkBin.Location = new System.Drawing.Point(8, 118);
            this.checkBin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBin.Name = "checkBin";
            this.checkBin.Size = new System.Drawing.Size(100, 23);
            this.checkBin.TabIndex = 41;
            this.checkBin.Text = "Recycle Bin";
            this.checkBin.UseVisualStyleBackColor = true;
            // 
            // checkMiniDumps
            // 
            this.checkMiniDumps.AutoSize = true;
            this.checkMiniDumps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniDumps.ForeColor = System.Drawing.Color.White;
            this.checkMiniDumps.Location = new System.Drawing.Point(8, 64);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(2);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.Size = new System.Drawing.Size(140, 23);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.Text = "BSOD Minidumps";
            this.checkMiniDumps.UseVisualStyleBackColor = true;
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pingerTab.Controls.Add(this.netTools);
            this.pingerTab.Location = new System.Drawing.Point(4, 25);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(3);
            this.pingerTab.Size = new System.Drawing.Size(974, 653);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // netTools
            // 
            this.netTools.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.netTools.Controls.Add(this.tabPage1);
            this.netTools.Controls.Add(this.tabPage2);
            this.netTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netTools.Location = new System.Drawing.Point(3, 3);
            this.netTools.Margin = new System.Windows.Forms.Padding(0);
            this.netTools.Multiline = true;
            this.netTools.Name = "netTools";
            this.netTools.Padding = new System.Drawing.Point(0, 0);
            this.netTools.SelectedIndex = 0;
            this.netTools.Size = new System.Drawing.Size(968, 647);
            this.netTools.TabIndex = 104;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pinger";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(27, 487);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 29);
            this.btnExport.TabIndex = 93;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // copyB
            // 
            this.copyB.BackColor = System.Drawing.Color.DodgerBlue;
            this.copyB.FlatAppearance.BorderSize = 0;
            this.copyB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.copyB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.copyB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyB.ForeColor = System.Drawing.Color.White;
            this.copyB.Location = new System.Drawing.Point(25, 144);
            this.copyB.Margin = new System.Windows.Forms.Padding(2);
            this.copyB.Name = "copyB";
            this.copyB.Size = new System.Drawing.Size(185, 31);
            this.copyB.TabIndex = 92;
            this.copyB.Text = "Copy IP";
            this.copyB.UseVisualStyleBackColor = false;
            this.copyB.Click += new System.EventHandler(this.copyB_Click);
            // 
            // copyIPB
            // 
            this.copyIPB.BackColor = System.Drawing.Color.DodgerBlue;
            this.copyIPB.FlatAppearance.BorderSize = 0;
            this.copyIPB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.copyIPB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.copyIPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyIPB.ForeColor = System.Drawing.Color.White;
            this.copyIPB.Location = new System.Drawing.Point(214, 144);
            this.copyIPB.Margin = new System.Windows.Forms.Padding(2);
            this.copyIPB.Name = "copyIPB";
            this.copyIPB.Size = new System.Drawing.Size(185, 31);
            this.copyIPB.TabIndex = 91;
            this.copyIPB.Text = "Copy";
            this.copyIPB.UseVisualStyleBackColor = false;
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
            this.btnShodan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShodan.FlatAppearance.BorderSize = 0;
            this.btnShodan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShodan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShodan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShodan.ForeColor = System.Drawing.Color.White;
            this.btnShodan.Location = new System.Drawing.Point(25, 109);
            this.btnShodan.Margin = new System.Windows.Forms.Padding(2);
            this.btnShodan.Name = "btnShodan";
            this.btnShodan.Size = new System.Drawing.Size(185, 31);
            this.btnShodan.TabIndex = 88;
            this.btnShodan.Text = "Check on SHODAN.io";
            this.btnShodan.UseVisualStyleBackColor = false;
            this.btnShodan.Click += new System.EventHandler(this.btnShodan_Click);
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPing.FlatAppearance.BorderSize = 0;
            this.btnPing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPing.ForeColor = System.Drawing.Color.White;
            this.btnPing.Location = new System.Drawing.Point(214, 109);
            this.btnPing.Margin = new System.Windows.Forms.Padding(2);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(185, 31);
            this.btnPing.TabIndex = 87;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = false;
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNS";
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
            this.linkDNSv6A.Location = new System.Drawing.Point(109, 218);
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
            this.linkDNSv4A.Location = new System.Drawing.Point(108, 161);
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
            this.linkDNSv6.Location = new System.Drawing.Point(109, 195);
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
            this.linkDNSv4.Location = new System.Drawing.Point(109, 138);
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
            this.label3.Location = new System.Drawing.Point(27, 196);
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
            this.label1.Location = new System.Drawing.Point(27, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 108;
            this.label1.Tag = "";
            this.label1.Text = "DNS IPv4:";
            // 
            // btnOpenNetwork
            // 
            this.btnOpenNetwork.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenNetwork.FlatAppearance.BorderSize = 0;
            this.btnOpenNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenNetwork.ForeColor = System.Drawing.Color.White;
            this.btnOpenNetwork.Location = new System.Drawing.Point(31, 299);
            this.btnOpenNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenNetwork.Name = "btnOpenNetwork";
            this.btnOpenNetwork.Size = new System.Drawing.Size(260, 29);
            this.btnOpenNetwork.TabIndex = 105;
            this.btnOpenNetwork.Text = "Open Network Connections";
            this.btnOpenNetwork.UseVisualStyleBackColor = false;
            this.btnOpenNetwork.Click += new System.EventHandler(this.btnOpenNetwork_Click);
            // 
            // flushCacheB
            // 
            this.flushCacheB.BackColor = System.Drawing.Color.DodgerBlue;
            this.flushCacheB.FlatAppearance.BorderSize = 0;
            this.flushCacheB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flushCacheB.ForeColor = System.Drawing.Color.White;
            this.flushCacheB.Location = new System.Drawing.Point(31, 266);
            this.flushCacheB.Margin = new System.Windows.Forms.Padding(2);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(260, 29);
            this.flushCacheB.TabIndex = 104;
            this.flushCacheB.Text = "Flush DNS cache";
            this.flushCacheB.UseVisualStyleBackColor = false;
            this.flushCacheB.Click += new System.EventHandler(this.flushCacheB_Click);
            // 
            // boxAdapter
            // 
            this.boxAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxAdapter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.boxAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxAdapter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAdapter.ForeColor = System.Drawing.Color.White;
            this.boxAdapter.FormattingEnabled = true;
            this.boxAdapter.Location = new System.Drawing.Point(28, 50);
            this.boxAdapter.Name = "boxAdapter";
            this.boxAdapter.Size = new System.Drawing.Size(414, 29);
            this.boxAdapter.TabIndex = 107;
            // 
            // boxDNS
            // 
            this.boxDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxDNS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.boxDNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxDNS.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDNS.ForeColor = System.Drawing.Color.White;
            this.boxDNS.FormattingEnabled = true;
            this.boxDNS.Items.AddRange(new object[] {
            "Automatic",
            "Cloudflare DNS",
            "Open DNS",
            "Quad9 DNS",
            "Google DNS",
            "Alternate DNS",
            "Adguard DNS",
            "CleanBrowsing",
            "CleanBrowsing (adult filter)"});
            this.boxDNS.Location = new System.Drawing.Point(28, 85);
            this.boxDNS.Name = "boxDNS";
            this.boxDNS.Size = new System.Drawing.Size(414, 29);
            this.boxDNS.TabIndex = 106;
            // 
            // hostsEditorTab
            // 
            this.hostsEditorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hostsEditorTab.Controls.Add(this.panel4);
            this.hostsEditorTab.Controls.Add(this.hostsTitle);
            this.hostsEditorTab.Controls.Add(this.linkLocate);
            this.hostsEditorTab.Location = new System.Drawing.Point(4, 25);
            this.hostsEditorTab.Margin = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Name = "hostsEditorTab";
            this.hostsEditorTab.Padding = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Size = new System.Drawing.Size(974, 653);
            this.hostsEditorTab.TabIndex = 9;
            this.hostsEditorTab.Text = "Hosts";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel4.Size = new System.Drawing.Size(1057, 643);
            this.panel4.TabIndex = 53;
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
            this.lblLock.Location = new System.Drawing.Point(325, 182);
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
            this.chkReadOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadOnly.ForeColor = System.Drawing.Color.White;
            this.chkReadOnly.Location = new System.Drawing.Point(329, 155);
            this.chkReadOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(103, 25);
            this.chkReadOnly.TabIndex = 61;
            this.chkReadOnly.Text = "Read-only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
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
            this.chkBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlock.ForeColor = System.Drawing.Color.White;
            this.chkBlock.Location = new System.Drawing.Point(329, 110);
            this.chkBlock.Margin = new System.Windows.Forms.Padding(2);
            this.chkBlock.Name = "chkBlock";
            this.chkBlock.Size = new System.Drawing.Size(69, 25);
            this.chkBlock.TabIndex = 59;
            this.chkBlock.Text = "Block";
            this.chkBlock.UseVisualStyleBackColor = true;
            this.chkBlock.CheckedChanged += new System.EventHandler(this.chkBlock_CheckedChanged);
            // 
            // refreshHostsB
            // 
            this.refreshHostsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshHostsB.FlatAppearance.BorderSize = 0;
            this.refreshHostsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshHostsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshHostsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshHostsB.ForeColor = System.Drawing.Color.White;
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
            this.removeHostB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeHostB.FlatAppearance.BorderSize = 0;
            this.removeHostB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeHostB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeHostB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeHostB.ForeColor = System.Drawing.Color.White;
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
            this.removeAllHostsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeAllHostsB.Enabled = false;
            this.removeAllHostsB.FlatAppearance.BorderSize = 0;
            this.removeAllHostsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllHostsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllHostsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllHostsB.ForeColor = System.Drawing.Color.White;
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
            this.addHostB.BackColor = System.Drawing.Color.DodgerBlue;
            this.addHostB.FlatAppearance.BorderSize = 0;
            this.addHostB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.addHostB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.addHostB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHostB.ForeColor = System.Drawing.Color.White;
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
            this.registryFixerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.registryFixerTab.Controls.Add(this.panel2);
            this.registryFixerTab.Controls.Add(this.registryTitle);
            this.registryFixerTab.Location = new System.Drawing.Point(4, 25);
            this.registryFixerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Name = "registryFixerTab";
            this.registryFixerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Size = new System.Drawing.Size(974, 653);
            this.registryFixerTab.TabIndex = 8;
            this.registryFixerTab.Text = "Registry";
            // 
            // panel2
            // 
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
            this.regFixB.BackColor = System.Drawing.Color.DodgerBlue;
            this.regFixB.FlatAppearance.BorderSize = 0;
            this.regFixB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.regFixB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.regFixB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regFixB.ForeColor = System.Drawing.Color.White;
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
            this.checkRestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.checkRestartExplorer.Location = new System.Drawing.Point(29, 181);
            this.checkRestartExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.checkRestartExplorer.Name = "checkRestartExplorer";
            this.checkRestartExplorer.Size = new System.Drawing.Size(306, 25);
            this.checkRestartExplorer.TabIndex = 50;
            this.checkRestartExplorer.Tag = "";
            this.checkRestartExplorer.Text = "Also restart Explorer to apply changes";
            this.checkRestartExplorer.UseVisualStyleBackColor = true;
            // 
            // checkRegistryEditor
            // 
            this.checkRegistryEditor.AutoSize = true;
            this.checkRegistryEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegistryEditor.ForeColor = System.Drawing.Color.White;
            this.checkRegistryEditor.Location = new System.Drawing.Point(291, 136);
            this.checkRegistryEditor.Margin = new System.Windows.Forms.Padding(2);
            this.checkRegistryEditor.Name = "checkRegistryEditor";
            this.checkRegistryEditor.Size = new System.Drawing.Size(138, 25);
            this.checkRegistryEditor.TabIndex = 38;
            this.checkRegistryEditor.Text = "Registry Editor";
            this.checkRegistryEditor.UseVisualStyleBackColor = true;
            // 
            // checkEnableAll
            // 
            this.checkEnableAll.AutoSize = true;
            this.checkEnableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnableAll.ForeColor = System.Drawing.Color.White;
            this.checkEnableAll.Location = new System.Drawing.Point(29, 14);
            this.checkEnableAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkEnableAll.Name = "checkEnableAll";
            this.checkEnableAll.Size = new System.Drawing.Size(97, 25);
            this.checkEnableAll.TabIndex = 35;
            this.checkEnableAll.Tag = "";
            this.checkEnableAll.Text = "Enable all";
            this.checkEnableAll.UseVisualStyleBackColor = true;
            this.checkEnableAll.CheckedChanged += new System.EventHandler(this.checkEnableAll_CheckedChanged);
            // 
            // checkContextMenu
            // 
            this.checkContextMenu.AutoSize = true;
            this.checkContextMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkContextMenu.ForeColor = System.Drawing.Color.White;
            this.checkContextMenu.Location = new System.Drawing.Point(291, 75);
            this.checkContextMenu.Margin = new System.Windows.Forms.Padding(2);
            this.checkContextMenu.Name = "checkContextMenu";
            this.checkContextMenu.Size = new System.Drawing.Size(151, 25);
            this.checkContextMenu.TabIndex = 43;
            this.checkContextMenu.Text = "Right Click menu";
            this.checkContextMenu.UseVisualStyleBackColor = true;
            // 
            // checkTaskManager
            // 
            this.checkTaskManager.AutoSize = true;
            this.checkTaskManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaskManager.ForeColor = System.Drawing.Color.White;
            this.checkTaskManager.Location = new System.Drawing.Point(55, 45);
            this.checkTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.checkTaskManager.Name = "checkTaskManager";
            this.checkTaskManager.Size = new System.Drawing.Size(128, 25);
            this.checkTaskManager.TabIndex = 36;
            this.checkTaskManager.Text = "Task Manager";
            this.checkTaskManager.UseVisualStyleBackColor = true;
            // 
            // checkCommandPrompt
            // 
            this.checkCommandPrompt.AutoSize = true;
            this.checkCommandPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCommandPrompt.ForeColor = System.Drawing.Color.White;
            this.checkCommandPrompt.Location = new System.Drawing.Point(55, 75);
            this.checkCommandPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.checkCommandPrompt.Name = "checkCommandPrompt";
            this.checkCommandPrompt.Size = new System.Drawing.Size(163, 25);
            this.checkCommandPrompt.TabIndex = 42;
            this.checkCommandPrompt.Text = "Command Prompt";
            this.checkCommandPrompt.UseVisualStyleBackColor = true;
            // 
            // checkFirewall
            // 
            this.checkFirewall.AutoSize = true;
            this.checkFirewall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFirewall.ForeColor = System.Drawing.Color.White;
            this.checkFirewall.Location = new System.Drawing.Point(291, 106);
            this.checkFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.checkFirewall.Name = "checkFirewall";
            this.checkFirewall.Size = new System.Drawing.Size(155, 25);
            this.checkFirewall.TabIndex = 37;
            this.checkFirewall.Text = "Windows Firewall";
            this.checkFirewall.UseVisualStyleBackColor = true;
            // 
            // checkRunDialog
            // 
            this.checkRunDialog.AutoSize = true;
            this.checkRunDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRunDialog.ForeColor = System.Drawing.Color.White;
            this.checkRunDialog.Location = new System.Drawing.Point(291, 45);
            this.checkRunDialog.Margin = new System.Windows.Forms.Padding(2);
            this.checkRunDialog.Name = "checkRunDialog";
            this.checkRunDialog.Size = new System.Drawing.Size(108, 25);
            this.checkRunDialog.TabIndex = 41;
            this.checkRunDialog.Text = "Run Dialog";
            this.checkRunDialog.UseVisualStyleBackColor = true;
            // 
            // checkFolderOptions
            // 
            this.checkFolderOptions.AutoSize = true;
            this.checkFolderOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFolderOptions.ForeColor = System.Drawing.Color.White;
            this.checkFolderOptions.Location = new System.Drawing.Point(55, 136);
            this.checkFolderOptions.Margin = new System.Windows.Forms.Padding(2);
            this.checkFolderOptions.Name = "checkFolderOptions";
            this.checkFolderOptions.Size = new System.Drawing.Size(138, 25);
            this.checkFolderOptions.TabIndex = 39;
            this.checkFolderOptions.Text = "Folder Options";
            this.checkFolderOptions.UseVisualStyleBackColor = true;
            // 
            // checkControlPanel
            // 
            this.checkControlPanel.AutoSize = true;
            this.checkControlPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkControlPanel.ForeColor = System.Drawing.Color.White;
            this.checkControlPanel.Location = new System.Drawing.Point(55, 106);
            this.checkControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.checkControlPanel.Name = "checkControlPanel";
            this.checkControlPanel.Size = new System.Drawing.Size(127, 25);
            this.checkControlPanel.TabIndex = 40;
            this.checkControlPanel.Text = "Control Panel";
            this.checkControlPanel.UseVisualStyleBackColor = true;
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
            this.indiciumTab.Padding = new System.Windows.Forms.Padding(3);
            this.indiciumTab.Size = new System.Drawing.Size(974, 653);
            this.indiciumTab.TabIndex = 14;
            this.indiciumTab.Text = "Hardware";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.specsTree);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 38);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(968, 612);
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
            this.specsTree.Size = new System.Drawing.Size(966, 610);
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
            this.panel11.Size = new System.Drawing.Size(968, 35);
            this.panel11.TabIndex = 1;
            // 
            // btnCopyHW
            // 
            this.btnCopyHW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyHW.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopyHW.FlatAppearance.BorderSize = 0;
            this.btnCopyHW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopyHW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopyHW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHW.ForeColor = System.Drawing.Color.White;
            this.btnCopyHW.Location = new System.Drawing.Point(817, 4);
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
            this.btnSaveHW.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveHW.FlatAppearance.BorderSize = 0;
            this.btnSaveHW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveHW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveHW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHW.ForeColor = System.Drawing.Color.White;
            this.btnSaveHW.Location = new System.Drawing.Point(667, 4);
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
            this.hwDetailed.Location = new System.Drawing.Point(5, 4);
            this.hwDetailed.Margin = new System.Windows.Forms.Padding(6);
            this.hwDetailed.Name = "hwDetailed";
            this.hwDetailed.Size = new System.Drawing.Size(374, 24);
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
            this.integratorTab.Size = new System.Drawing.Size(974, 653);
            this.integratorTab.TabIndex = 10;
            this.integratorTab.Text = "Integrator";
            // 
            // synapse
            // 
            this.synapse.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.synapse.Controls.Add(this.integratorInfoTab);
            this.synapse.Controls.Add(this.tabPage8);
            this.synapse.Controls.Add(this.tabPage9);
            this.synapse.Controls.Add(this.tabPage10);
            this.synapse.Controls.Add(this.tabPage11);
            this.synapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synapse.Location = new System.Drawing.Point(2, 2);
            this.synapse.Margin = new System.Windows.Forms.Padding(2);
            this.synapse.Multiline = true;
            this.synapse.Name = "synapse";
            this.synapse.Padding = new System.Drawing.Point(0, 0);
            this.synapse.SelectedIndex = 0;
            this.synapse.Size = new System.Drawing.Size(970, 649);
            this.synapse.TabIndex = 0;
            // 
            // integratorInfoTab
            // 
            this.integratorInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.integratorInfoTab.Controls.Add(this.integrator7);
            this.integratorInfoTab.Controls.Add(this.integrator6);
            this.integratorInfoTab.Controls.Add(this.integrator5);
            this.integratorInfoTab.Controls.Add(this.integrator4);
            this.integratorInfoTab.Controls.Add(this.integrator3);
            this.integratorInfoTab.Controls.Add(this.integrator2);
            this.integratorInfoTab.Controls.Add(this.integrator1);
            this.integratorInfoTab.Location = new System.Drawing.Point(4, 4);
            this.integratorInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Name = "integratorInfoTab";
            this.integratorInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Size = new System.Drawing.Size(962, 620);
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
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage8.Controls.Add(this.btnAddItem);
            this.tabPage8.Controls.Add(this.itemnamegroup);
            this.tabPage8.Controls.Add(this.security);
            this.tabPage8.Controls.Add(this.itemposition);
            this.tabPage8.Controls.Add(this.icontoaddgroup);
            this.tabPage8.Controls.Add(this.itemtoaddgroup);
            this.tabPage8.Controls.Add(this.itemtype);
            this.tabPage8.Controls.Add(this.addItemL);
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(962, 620);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Add/Modify";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(436, 473);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(202, 31);
            this.btnAddItem.TabIndex = 85;
            this.btnAddItem.Text = "Add/Modify";
            this.btnAddItem.UseVisualStyleBackColor = false;
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
            this.checkShift.ForeColor = System.Drawing.Color.White;
            this.checkShift.Location = new System.Drawing.Point(11, 26);
            this.checkShift.Margin = new System.Windows.Forms.Padding(2);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(300, 25);
            this.checkShift.TabIndex = 83;
            this.checkShift.Text = "Show only when SHIFT key is pressed";
            this.checkShift.UseVisualStyleBackColor = true;
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
            this.radioTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioTop.ForeColor = System.Drawing.Color.White;
            this.radioTop.Location = new System.Drawing.Point(11, 26);
            this.radioTop.Margin = new System.Windows.Forms.Padding(2);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(55, 25);
            this.radioTop.TabIndex = 83;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = true;
            this.radioTop.CheckedChanged += new System.EventHandler(this.radioTop_CheckedChanged);
            // 
            // radioMiddle
            // 
            this.radioMiddle.AutoSize = true;
            this.radioMiddle.ForeColor = System.Drawing.Color.White;
            this.radioMiddle.Location = new System.Drawing.Point(131, 26);
            this.radioMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.radioMiddle.Name = "radioMiddle";
            this.radioMiddle.Size = new System.Drawing.Size(80, 25);
            this.radioMiddle.TabIndex = 84;
            this.radioMiddle.Text = "Middle";
            this.radioMiddle.UseVisualStyleBackColor = true;
            this.radioMiddle.CheckedChanged += new System.EventHandler(this.radioMiddle_CheckedChanged);
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.ForeColor = System.Drawing.Color.White;
            this.radioBottom.Location = new System.Drawing.Point(277, 26);
            this.radioBottom.Margin = new System.Windows.Forms.Padding(2);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(84, 25);
            this.radioBottom.TabIndex = 85;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = true;
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
            this.checkDefaultIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.checkDefaultIcon.ForeColor = System.Drawing.Color.White;
            this.checkDefaultIcon.Location = new System.Drawing.Point(11, 58);
            this.checkDefaultIcon.Margin = new System.Windows.Forms.Padding(2);
            this.checkDefaultIcon.Name = "checkDefaultIcon";
            this.checkDefaultIcon.Size = new System.Drawing.Size(169, 25);
            this.checkDefaultIcon.TabIndex = 82;
            this.checkDefaultIcon.Text = "Use program\'s icon";
            this.checkDefaultIcon.UseVisualStyleBackColor = true;
            this.checkDefaultIcon.CheckedChanged += new System.EventHandler(this.checkDefaultIcon_CheckedChanged);
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseIcon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseIcon.Enabled = false;
            this.btnBrowseIcon.FlatAppearance.BorderSize = 0;
            this.btnBrowseIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseIcon.ForeColor = System.Drawing.Color.White;
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
            this.btnBrowseItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseItem.FlatAppearance.BorderSize = 0;
            this.btnBrowseItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseItem.ForeColor = System.Drawing.Color.White;
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
            this.radioCommand.ForeColor = System.Drawing.Color.White;
            this.radioCommand.Location = new System.Drawing.Point(481, 26);
            this.radioCommand.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommand.Name = "radioCommand";
            this.radioCommand.Size = new System.Drawing.Size(103, 25);
            this.radioCommand.TabIndex = 84;
            this.radioCommand.Text = "Command";
            this.radioCommand.UseVisualStyleBackColor = true;
            this.radioCommand.CheckedChanged += new System.EventHandler(this.radioCommand_CheckedChanged);
            // 
            // radioProgram
            // 
            this.radioProgram.AutoSize = true;
            this.radioProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioProgram.ForeColor = System.Drawing.Color.White;
            this.radioProgram.Location = new System.Drawing.Point(11, 26);
            this.radioProgram.Margin = new System.Windows.Forms.Padding(2);
            this.radioProgram.Name = "radioProgram";
            this.radioProgram.Size = new System.Drawing.Size(91, 25);
            this.radioProgram.TabIndex = 80;
            this.radioProgram.Text = "Program";
            this.radioProgram.UseVisualStyleBackColor = true;
            this.radioProgram.CheckedChanged += new System.EventHandler(this.radioProgram_CheckedChanged);
            // 
            // radioFolder
            // 
            this.radioFolder.AutoSize = true;
            this.radioFolder.ForeColor = System.Drawing.Color.White;
            this.radioFolder.Location = new System.Drawing.Point(139, 26);
            this.radioFolder.Margin = new System.Windows.Forms.Padding(2);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(75, 25);
            this.radioFolder.TabIndex = 81;
            this.radioFolder.Text = "Folder";
            this.radioFolder.UseVisualStyleBackColor = true;
            this.radioFolder.CheckedChanged += new System.EventHandler(this.radioFolder_CheckedChanged);
            // 
            // radioLink
            // 
            this.radioLink.AutoSize = true;
            this.radioLink.ForeColor = System.Drawing.Color.White;
            this.radioLink.Location = new System.Drawing.Point(254, 26);
            this.radioLink.Margin = new System.Windows.Forms.Padding(2);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(57, 25);
            this.radioLink.TabIndex = 82;
            this.radioLink.Text = "Link";
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.CheckedChanged += new System.EventHandler(this.radioLink_CheckedChanged);
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.ForeColor = System.Drawing.Color.White;
            this.radioFile.Location = new System.Drawing.Point(371, 26);
            this.radioFile.Margin = new System.Windows.Forms.Padding(2);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(53, 25);
            this.radioFile.TabIndex = 83;
            this.radioFile.Text = "File";
            this.radioFile.UseVisualStyleBackColor = true;
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
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage9.Controls.Add(this.panel5);
            this.tabPage9.Controls.Add(this.refreshIIB);
            this.tabPage9.Controls.Add(this.removeDIB);
            this.tabPage9.Controls.Add(this.removeAllIIB);
            this.tabPage9.Controls.Add(this.removeIntegratorItemsL);
            this.tabPage9.Location = new System.Drawing.Point(4, 4);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(962, 620);
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
            this.refreshIIB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshIIB.FlatAppearance.BorderSize = 0;
            this.refreshIIB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshIIB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshIIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshIIB.ForeColor = System.Drawing.Color.White;
            this.refreshIIB.Location = new System.Drawing.Point(308, 80);
            this.refreshIIB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshIIB.Name = "refreshIIB";
            this.refreshIIB.Size = new System.Drawing.Size(185, 31);
            this.refreshIIB.TabIndex = 81;
            this.refreshIIB.Text = "Refresh";
            this.refreshIIB.UseVisualStyleBackColor = false;
            this.refreshIIB.Click += new System.EventHandler(this.button60_Click);
            // 
            // removeDIB
            // 
            this.removeDIB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeDIB.FlatAppearance.BorderSize = 0;
            this.removeDIB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeDIB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeDIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDIB.ForeColor = System.Drawing.Color.White;
            this.removeDIB.Location = new System.Drawing.Point(308, 45);
            this.removeDIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeDIB.Name = "removeDIB";
            this.removeDIB.Size = new System.Drawing.Size(185, 31);
            this.removeDIB.TabIndex = 80;
            this.removeDIB.Text = "Delete";
            this.removeDIB.UseVisualStyleBackColor = false;
            this.removeDIB.Click += new System.EventHandler(this.button61_Click);
            // 
            // removeAllIIB
            // 
            this.removeAllIIB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeAllIIB.FlatAppearance.BorderSize = 0;
            this.removeAllIIB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllIIB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllIIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllIIB.ForeColor = System.Drawing.Color.White;
            this.removeAllIIB.Location = new System.Drawing.Point(308, 115);
            this.removeAllIIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllIIB.Name = "removeAllIIB";
            this.removeAllIIB.Size = new System.Drawing.Size(185, 31);
            this.removeAllIIB.TabIndex = 79;
            this.removeAllIIB.Text = "Delete all";
            this.removeAllIIB.UseVisualStyleBackColor = false;
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
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage10.Controls.Add(this.WAB);
            this.tabPage10.Controls.Add(this.AddCMDB);
            this.tabPage10.Controls.Add(this.AddOwnerB);
            this.tabPage10.Controls.Add(this.DSB);
            this.tabPage10.Controls.Add(this.SSB);
            this.tabPage10.Controls.Add(this.STB);
            this.tabPage10.Controls.Add(this.PMB);
            this.tabPage10.Controls.Add(this.readyMenusL);
            this.tabPage10.Location = new System.Drawing.Point(4, 4);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(962, 620);
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
            this.WAB.Location = new System.Drawing.Point(32, 120);
            this.WAB.Margin = new System.Windows.Forms.Padding(6);
            this.WAB.Name = "WAB";
            this.WAB.Size = new System.Drawing.Size(374, 24);
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
            this.AddCMDB.Location = new System.Drawing.Point(32, 275);
            this.AddCMDB.Margin = new System.Windows.Forms.Padding(6);
            this.AddCMDB.Name = "AddCMDB";
            this.AddCMDB.Size = new System.Drawing.Size(374, 24);
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
            this.AddOwnerB.Location = new System.Drawing.Point(32, 245);
            this.AddOwnerB.Margin = new System.Windows.Forms.Padding(6);
            this.AddOwnerB.Name = "AddOwnerB";
            this.AddOwnerB.Size = new System.Drawing.Size(374, 24);
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
            this.DSB.Location = new System.Drawing.Point(32, 180);
            this.DSB.Margin = new System.Windows.Forms.Padding(6);
            this.DSB.Name = "DSB";
            this.DSB.Size = new System.Drawing.Size(374, 24);
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
            this.SSB.Location = new System.Drawing.Point(32, 150);
            this.SSB.Margin = new System.Windows.Forms.Padding(6);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(374, 24);
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
            this.STB.Location = new System.Drawing.Point(32, 90);
            this.STB.Margin = new System.Windows.Forms.Padding(6);
            this.STB.Name = "STB";
            this.STB.Size = new System.Drawing.Size(374, 24);
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
            this.PMB.Margin = new System.Windows.Forms.Padding(6);
            this.PMB.Name = "PMB";
            this.PMB.Size = new System.Drawing.Size(374, 24);
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
            this.tabPage11.Location = new System.Drawing.Point(4, 4);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage11.Size = new System.Drawing.Size(962, 620);
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
            this.removeCCB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeCCB.FlatAppearance.BorderSize = 0;
            this.removeCCB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeCCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeCCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCCB.ForeColor = System.Drawing.Color.White;
            this.removeCCB.Location = new System.Drawing.Point(286, 210);
            this.removeCCB.Margin = new System.Windows.Forms.Padding(2);
            this.removeCCB.Name = "removeCCB";
            this.removeCCB.Size = new System.Drawing.Size(162, 27);
            this.removeCCB.TabIndex = 82;
            this.removeCCB.Text = "Delete";
            this.removeCCB.UseVisualStyleBackColor = false;
            this.removeCCB.Click += new System.EventHandler(this.button26_Click);
            // 
            // refreshCCB
            // 
            this.refreshCCB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshCCB.FlatAppearance.BorderSize = 0;
            this.refreshCCB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshCCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshCCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshCCB.ForeColor = System.Drawing.Color.White;
            this.refreshCCB.Location = new System.Drawing.Point(286, 241);
            this.refreshCCB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshCCB.Name = "refreshCCB";
            this.refreshCCB.Size = new System.Drawing.Size(162, 27);
            this.refreshCCB.TabIndex = 81;
            this.refreshCCB.Text = "Refresh";
            this.refreshCCB.UseVisualStyleBackColor = false;
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
            this.btnCreateCustomCommand.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateCustomCommand.FlatAppearance.BorderSize = 0;
            this.btnCreateCustomCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateCustomCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateCustomCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCustomCommand.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomCommand.Location = new System.Drawing.Point(299, 130);
            this.btnCreateCustomCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCustomCommand.Name = "btnCreateCustomCommand";
            this.btnCreateCustomCommand.Size = new System.Drawing.Size(149, 29);
            this.btnCreateCustomCommand.TabIndex = 60;
            this.btnCreateCustomCommand.Text = "Create";
            this.btnCreateCustomCommand.UseVisualStyleBackColor = false;
            this.btnCreateCustomCommand.Click += new System.EventHandler(this.button50_Click);
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.DodgerBlue;
            this.button48.FlatAppearance.BorderSize = 0;
            this.button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.ForeColor = System.Drawing.Color.White;
            this.button48.Location = new System.Drawing.Point(396, 75);
            this.button48.Margin = new System.Windows.Forms.Padding(2);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(52, 29);
            this.button48.TabIndex = 58;
            this.button48.Text = "...";
            this.button48.UseVisualStyleBackColor = false;
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
            // optionsTab
            // 
            this.optionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.optionsTab.Controls.Add(this.telemetrySvcToggle);
            this.optionsTab.Controls.Add(this.autoStartToggle);
            this.optionsTab.Controls.Add(this.colorPicker1);
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
            this.optionsTab.Controls.Add(this.btnOpenConf);
            this.optionsTab.Controls.Add(this.lblTroubleshoot);
            this.optionsTab.Controls.Add(this.lblUpdating);
            this.optionsTab.Controls.Add(this.btnViewLog);
            this.optionsTab.Controls.Add(this.l2);
            this.optionsTab.Controls.Add(this.btnUpdate);
            this.optionsTab.Controls.Add(this.btnResetConfig);
            this.optionsTab.Controls.Add(this.lblTheming);
            this.optionsTab.Controls.Add(this.quickAccessToggle);
            this.optionsTab.Location = new System.Drawing.Point(4, 25);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(2);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(2);
            this.optionsTab.Size = new System.Drawing.Size(974, 653);
            this.optionsTab.TabIndex = 6;
            this.optionsTab.Text = "Options";
            // 
            // telemetrySvcToggle
            // 
            this.telemetrySvcToggle.AccessibleName = "Disable Telemetry Service";
            this.telemetrySvcToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.telemetrySvcToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetrySvcToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetrySvcToggle.ForeColor = System.Drawing.Color.White;
            this.telemetrySvcToggle.LabelText = "Disable Telemetry Service";
            this.telemetrySvcToggle.Location = new System.Drawing.Point(21, 80);
            this.telemetrySvcToggle.Margin = new System.Windows.Forms.Padding(6);
            this.telemetrySvcToggle.Name = "telemetrySvcToggle";
            this.telemetrySvcToggle.Size = new System.Drawing.Size(374, 24);
            this.telemetrySvcToggle.TabIndex = 99;
            this.telemetrySvcToggle.Tag = "themeable";
            this.telemetrySvcToggle.ToggleChecked = false;
            this.telemetrySvcToggle.ToggleClicked += new System.EventHandler(this.telemetrySvcToggle_ToggleClicked);
            // 
            // autoStartToggle
            // 
            this.autoStartToggle.AccessibleName = "Start with Windows";
            this.autoStartToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoStartToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoStartToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoStartToggle.ForeColor = System.Drawing.Color.White;
            this.autoStartToggle.LabelText = "Start with Windows";
            this.autoStartToggle.Location = new System.Drawing.Point(21, 49);
            this.autoStartToggle.Margin = new System.Windows.Forms.Padding(6);
            this.autoStartToggle.Name = "autoStartToggle";
            this.autoStartToggle.Size = new System.Drawing.Size(374, 24);
            this.autoStartToggle.TabIndex = 98;
            this.autoStartToggle.Tag = "themeable";
            this.autoStartToggle.ToggleChecked = false;
            this.autoStartToggle.ToggleClicked += new System.EventHandler(this.autoStartToggle_ToggleClicked);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorPicker1.Location = new System.Drawing.Point(22, 151);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(139, 98);
            this.colorPicker1.TabIndex = 97;
            this.colorPicker1.Text = "colorPicker1";
            this.colorPicker1.ColorChanged += new System.EventHandler(this.colorPicker1_ColorChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(932, 461);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel3.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel3.Location = new System.Drawing.Point(807, 460);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(121, 28);
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
            this.pictureBox17.Location = new System.Drawing.Point(932, 537);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(32, 32);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 94;
            this.pictureBox17.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(798, 536);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(130, 28);
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
            this.pictureBox14.Location = new System.Drawing.Point(932, 613);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(32, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 92;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(932, 499);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(32, 32);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 91;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(932, 575);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 90;
            this.pictureBox12.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(771, 575);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 28);
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
            this.pictureBox85.Location = new System.Drawing.Point(1067, 7);
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
            this.panel9.Location = new System.Drawing.Point(623, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(341, 113);
            this.panel9.TabIndex = 73;
            // 
            // boxLang
            // 
            this.boxLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.boxLang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.boxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLang.ForeColor = System.Drawing.Color.White;
            this.boxLang.FormattingEnabled = true;
            this.boxLang.Items.AddRange(new object[] {
            "English",
            "русский",
            "Ελληνικά",
            "Deutsch",
            "Italiano",
            "Čeština",
            "Türkçe",
            "Español",
            "Português",
            "Français",
            "Polski",
            "简体中文",
            "繁體中文",
            "한국어",
            "العربية",
            "کوردی",
            "Magyar",
            "Română",
            "Nederlands",
            "українська",
            "日本語"});
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
            this.languagesL.Location = new System.Drawing.Point(718, 6);
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
            this.linkLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.Location = new System.Drawing.Point(730, 613);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(198, 28);
            this.linkLabel5.TabIndex = 65;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "themeable";
            this.linkLabel5.Text = "GNU GPL 3.0 license";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // btnOpenConf
            // 
            this.btnOpenConf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.FlatAppearance.BorderSize = 0;
            this.btnOpenConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenConf.ForeColor = System.Drawing.Color.White;
            this.btnOpenConf.Location = new System.Drawing.Point(34, 452);
            this.btnOpenConf.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenConf.Name = "btnOpenConf";
            this.btnOpenConf.Size = new System.Drawing.Size(261, 31);
            this.btnOpenConf.TabIndex = 63;
            this.btnOpenConf.Text = "Show config folder";
            this.btnOpenConf.UseVisualStyleBackColor = false;
            this.btnOpenConf.Click += new System.EventHandler(this.btnOpenConf_Click);
            // 
            // lblTroubleshoot
            // 
            this.lblTroubleshoot.AutoSize = true;
            this.lblTroubleshoot.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleshoot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTroubleshoot.Location = new System.Drawing.Point(17, 379);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(150, 25);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "themeable";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // lblUpdating
            // 
            this.lblUpdating.AutoSize = true;
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUpdating.Location = new System.Drawing.Point(17, 283);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(142, 25);
            this.lblUpdating.TabIndex = 61;
            this.lblUpdating.Tag = "themeable";
            this.lblUpdating.Text = "Check && update";
            // 
            // btnViewLog
            // 
            this.btnViewLog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.FlatAppearance.BorderSize = 0;
            this.btnViewLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.ForeColor = System.Drawing.Color.White;
            this.btnViewLog.Location = new System.Drawing.Point(34, 417);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(261, 31);
            this.btnViewLog.TabIndex = 60;
            this.btnViewLog.Text = "View errors";
            this.btnViewLog.UseVisualStyleBackColor = false;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // l2
            // 
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.l2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.l2.Location = new System.Drawing.Point(771, 498);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(157, 28);
            this.l2.TabIndex = 59;
            this.l2.TabStop = true;
            this.l2.Tag = "themeable";
            this.l2.Text = "deadmoon © ∞";
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(34, 317);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(261, 31);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Check for update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnResetConfig.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnResetConfig.FlatAppearance.BorderSize = 0;
            this.btnResetConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetConfig.ForeColor = System.Drawing.Color.White;
            this.btnResetConfig.Location = new System.Drawing.Point(34, 487);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(261, 31);
            this.btnResetConfig.TabIndex = 56;
            this.btnResetConfig.Text = "Repair";
            this.btnResetConfig.UseVisualStyleBackColor = false;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // lblTheming
            // 
            this.lblTheming.AutoSize = true;
            this.lblTheming.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheming.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTheming.Location = new System.Drawing.Point(17, 123);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(174, 25);
            this.lblTheming.TabIndex = 55;
            this.lblTheming.Tag = "themeable";
            this.lblTheming.Text = "Choose your theme";
            // 
            // quickAccessToggle
            // 
            this.quickAccessToggle.AccessibleName = "Show Quick Access Menu";
            this.quickAccessToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.quickAccessToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.quickAccessToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessToggle.ForeColor = System.Drawing.Color.White;
            this.quickAccessToggle.LabelText = "Show Quick Access Menu";
            this.quickAccessToggle.Location = new System.Drawing.Point(21, 18);
            this.quickAccessToggle.Margin = new System.Windows.Forms.Padding(6);
            this.quickAccessToggle.Name = "quickAccessToggle";
            this.quickAccessToggle.Size = new System.Drawing.Size(374, 24);
            this.quickAccessToggle.TabIndex = 88;
            this.quickAccessToggle.Tag = "themeable";
            this.quickAccessToggle.ToggleChecked = false;
            this.quickAccessToggle.ToggleClicked += new System.EventHandler(this.quickAccessToggle_ToggleClicked);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(984, 748);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(967, 539);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bpanel.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.universalTab.ResumeLayout(false);
            this.universalTab.PerformLayout();
            this.windows10Tab.ResumeLayout(false);
            this.windows10Tab.PerformLayout();
            this.panelWin11Tweaks.ResumeLayout(false);
            this.panelWin11Tweaks.PerformLayout();
            this.windows8Tab.ResumeLayout(false);
            this.windows8Tab.PerformLayout();
            this.modernAppsTab.ResumeLayout(false);
            this.modernAppsTab.PerformLayout();
            this.startupTab.ResumeLayout(false);
            this.startupTab.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.appsTab.ResumeLayout(false);
            this.appsTab.PerformLayout();
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
            this.optionsTab.ResumeLayout(false);
            this.optionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
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
        private System.Windows.Forms.TabPage windows8Tab;
        private System.Windows.Forms.TabPage cleanerTab;
        private System.Windows.Forms.TabPage startupTab;
        private System.Windows.Forms.Label startupTitle;
        private System.Windows.Forms.Button removeStartupItemB;
        private System.Windows.Forms.TabPage registryFixerTab;
        private System.Windows.Forms.Label registryTitle;
        private System.Windows.Forms.Button regFixB;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.ListView listStartupItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button refreshStartupB;
        private System.Windows.Forms.Button locateFileB;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage hostsEditorTab;
        private System.Windows.Forms.Label hostsTitle;
        private System.Windows.Forms.LinkLabel linkLocate;
        private System.Windows.Forms.LinkLabel linkAdvancedEdit;
        private System.Windows.Forms.LinkLabel linkRestoreDefault;
        private MoonList listHostEntries;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeAllHostsB;
        private System.Windows.Forms.Button refreshHostsB;
        private System.Windows.Forms.Button removeHostB;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button addHostB;
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
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.TextBox txtRunKeyword;
        private System.Windows.Forms.Label ccKeywordL;
        private System.Windows.Forms.TextBox txtRunFile;
        private System.Windows.Forms.Label ccFileL;
        private System.Windows.Forms.Label ccL;
        private System.Windows.Forms.Button btnCreateCustomCommand;
        internal System.Windows.Forms.OpenFileDialog defineCommandDialog;
        private System.Windows.Forms.Label readyMenusL;
        private MoonList listDesktopItems;
        private System.Windows.Forms.Label removeIntegratorItemsL;
        private System.Windows.Forms.Button refreshIIB;
        private System.Windows.Forms.Button removeDIB;
        private System.Windows.Forms.Button removeAllIIB;
        private System.Windows.Forms.GroupBox itemtype;
        private MoonRadio radioCommand;
        private MoonRadio radioProgram;
        private MoonRadio radioFile;
        private MoonRadio radioFolder;
        private MoonRadio radioLink;
        private System.Windows.Forms.Label addItemL;
        private System.Windows.Forms.GroupBox icontoaddgroup;
        private MoonCheck checkDefaultIcon;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.GroupBox itemtoaddgroup;
        private System.Windows.Forms.Button btnBrowseItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.GroupBox security;
        private MoonCheck checkShift;
        private System.Windows.Forms.GroupBox itemposition;
        private MoonRadio radioTop;
        private MoonRadio radioMiddle;
        private MoonRadio radioBottom;
        private System.Windows.Forms.GroupBox itemnamegroup;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.OpenFileDialog defineProgramDialog;
        internal System.Windows.Forms.FolderBrowserDialog defineFolderDialog;
        internal System.Windows.Forms.OpenFileDialog defineFileDialog;
        internal System.Windows.Forms.OpenFileDialog DefineProgramIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFolderIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineURLIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineFileIconDialog;
        internal System.Windows.Forms.OpenFileDialog DefineCommandIconDialog;
        private System.Windows.Forms.Button findInRegB;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.Label lblTheming;
        private MoonList listCustomCommands;
        private System.Windows.Forms.Label removeCCL;
        private System.Windows.Forms.Button removeCCB;
        private System.Windows.Forms.Button refreshCCB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TabPage modernAppsTab;
        private System.Windows.Forms.Label txtModernAppsTitle;
        private System.Windows.Forms.Button uninstallModernAppsButton;
        private System.Windows.Forms.Button refreshModernAppsButton;
        private MoonCheck chkSelectAllModernApps;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnUpdate;
        private MoonCheck chkReadOnly;
        private System.Windows.Forms.Label lblLock;
        private MoonCheck chkBlock;
        private System.Windows.Forms.TabPage appsTab;
        private System.Windows.Forms.Button btnDownloadApps;
        private System.Windows.Forms.Label appsTitle;
        private System.Windows.Forms.Label setDownDirLbl;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Button changeDownDirB;
        private System.Windows.Forms.Label txtDownloadStatus;
        private System.Windows.Forms.Label bitPref;
        private MoonRadio c32;
        private System.Windows.Forms.Button goToDownloadsB;
        private System.Windows.Forms.LinkLabel linkWarnings;
        private MoonCheck cAutoInstall;
        private MoonCheck chkOnlyRemovable;
        private MoonProgress progressDownloader;
        private System.Windows.Forms.Button btnGetFeed;
        private System.Windows.Forms.Panel panelCommonApps;
        private System.Windows.Forms.LinkLabel l2;
        private System.Windows.Forms.Panel groupSystemTools;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Label lblTroubleshoot;
        private System.Windows.Forms.Label lblUpdating;
        private System.Windows.Forms.Button btnOpenConf;
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
        private Button backupStartupB;
        private Button restoreStartupB;
        private TextBox txtBackupTitle;
        private Label lblBackupTitle;
        private Button doBackup;
        private Button cancelBackup;
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
        private Panel panelWin11Tweaks;
        private ToolStripMenuItem trayRegistry;
        private ToolStripMenuItem trayOptions;
        private Label txtFeedError;
        private ToggleCard performanceSw;
        private ToggleCard faxSw;
        private ToggleCard homegroupSw;
        private ToggleCard stickySw;
        private ToggleCard compatSw;
        private ToggleCard mediaSharingSw;
        private ToggleCard printSw;
        private ToggleCard superfetchSw;
        private ToggleCard reportingSw;
        private ToggleCard systemRestoreSw;
        private ToggleCard officeTelemetrySw;
        private ToggleCard smartScreenSw;
        private ToggleCard networkSw;
        private ToggleCard telemetryTasksSw;
        private ToggleCard defenderSw;
        private ToggleCard tpmSw;
        private ToggleCard xboxSw;
        private ToggleCard inkSw;
        private ToggleCard spellSw;
        private ToggleCard longPathsSw;
        private ToggleCard uODSw;
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
        private ToggleCard classicRibbonSw;
        private ToggleCard classicContextSw;
        private ToggleCard smallerTaskbarSw;
        private ToggleCard widgetsSw;
        private ToggleCard chatSw;
        private ToggleCard snapAssistSw;
        private ToggleCard leftTaskbarSw;
        private ToggleCard disableOneDriveSw;
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
        private ToggleCard vsSw;
        private ToggleCard chromeTelemetrySw;
        private ToggleCard ffTelemetrySw;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
        private PictureBox picLab;
        private PictureBox pictureBox17;
        private LinkLabel linkLabel2;
        private Button btnCopyHW;
        private Button btnSaveHW;
        private MoonSelect boxLang;
        private Panel panel1;
        private MoonCheck edgeSession;
        private MoonCheck edgeHistory;
        private Button cleanDriveB;
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
        private Panel panel14;
        private MoonCheckList listCleanPreview;
        private LinkLabel checkSelectAll;
        private Button analyzeDriveB;
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
        private ToggleCard hibernateSw;
        private ToggleCard smb2Sw;
        private ToggleCard smb1Sw;
        private ToggleCard ntfsStampSw;
        private Button btnWinClean;
        private TabPage tabPage1;
        private Button btnExport;
        private Button copyB;
        private Button copyIPB;
        private Panel panel7;
        private MoonList listPingResults;
        private Label lblResults;
        private Button btnShodan;
        private Button btnPing;
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
        private Button btnOpenNetwork;
        private Button flushCacheB;
        private MoonSelect boxAdapter;
        private MoonSelect boxDNS;
        private Controls.ColorPicker colorPicker1;
        private ToggleCard autoStartToggle;
        private ToggleCard nvidiaTelemetrySw;
        private Optimizer.MoonTabs netTools;
        private Label dnsTitle;
        private ToggleCard vbsSw;
        private Label label14s;
        private Label label4a;
        private Label drives;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label19;
        private Label label20;
        private Label label21;
        private ToggleCard winSearchSw;
        private Button btnRestoreUwp;
        private ToggleCard telemetrySvcToggle;
    }
}

