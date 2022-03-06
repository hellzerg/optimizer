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
            this.featuresSw = new Optimizer.ToggleCard();
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
            this.actionSw = new Optimizer.ToggleCard();
            this.xboxSw = new Optimizer.ToggleCard();
            this.inkSw = new Optimizer.ToggleCard();
            this.spellSw = new Optimizer.ToggleCard();
            this.longPathsSw = new Optimizer.ToggleCard();
            this.uODSw = new Optimizer.ToggleCard();
            this.peopleSw = new Optimizer.ToggleCard();
            this.oldExplorerSw = new Optimizer.ToggleCard();
            this.adsSw = new Optimizer.ToggleCard();
            this.panelWin11Tweaks = new System.Windows.Forms.Panel();
            this.classicRibbonSw = new Optimizer.ToggleCard();
            this.snapAssistSw = new Optimizer.ToggleCard();
            this.widgetsSw = new Optimizer.ToggleCard();
            this.leftTaskbarSw = new Optimizer.ToggleCard();
            this.classicContextSw = new Optimizer.ToggleCard();
            this.chatSw = new Optimizer.ToggleCard();
            this.smallerTaskbarSw = new Optimizer.ToggleCard();
            this.windows8Tab = new System.Windows.Forms.TabPage();
            this.disableOneDriveSw = new Optimizer.ToggleCard();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.chkOnlyRemovable = new Optimizer.MoonCheck();
            this.chkSelectAllModernApps = new Optimizer.MoonCheck();
            this.txtUWP = new System.Windows.Forms.Label();
            this.uninstallModernAppsButton = new System.Windows.Forms.Button();
            this.refreshModernAppsButton = new System.Windows.Forms.Button();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.panelModernAppsList = new System.Windows.Forms.Panel();
            this.listModernApps = new Optimizer.MoonCheckList();
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
            this.c64 = new Optimizer.MoonnRadio();
            this.c32 = new Optimizer.MoonnRadio();
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
            this.cleanerTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblPretext = new System.Windows.Forms.Label();
            this.lblFootprint = new System.Windows.Forms.Label();
            this.checkErrorReports = new Optimizer.MoonCheck();
            this.cleanDriveB = new System.Windows.Forms.Button();
            this.checkSelectAll = new Optimizer.MoonCheck();
            this.checkTemp = new Optimizer.MoonCheck();
            this.checkBin = new Optimizer.MoonCheck();
            this.checkMiniDumps = new Optimizer.MoonCheck();
            this.pingerTab = new System.Windows.Forms.TabPage();
            this.btnOpenNetwork = new System.Windows.Forms.Button();
            this.txtIPv6A = new System.Windows.Forms.LinkLabel();
            this.txtIPv6 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPv4A = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPv4 = new System.Windows.Forms.LinkLabel();
            this.lblDNS = new System.Windows.Forms.Label();
            this.flushCacheB = new System.Windows.Forms.Button();
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
            this.hostsEditorTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAdblockSub = new System.Windows.Forms.Label();
            this.linkAdvancedEdit = new System.Windows.Forms.LinkLabel();
            this.lblAdblock = new System.Windows.Forms.Label();
            this.linkRestoreDefault = new System.Windows.Forms.LinkLabel();
            this.adblockUlti = new System.Windows.Forms.Button();
            this.adblockP = new System.Windows.Forms.Button();
            this.adblockS = new System.Windows.Forms.Button();
            this.adblockBasic = new System.Windows.Forms.Button();
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
            this.btnSaveHW = new System.Windows.Forms.LinkLabel();
            this.btnCopyHW = new System.Windows.Forms.LinkLabel();
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
            this.radioTop = new Optimizer.MoonnRadio();
            this.radioMiddle = new Optimizer.MoonnRadio();
            this.radioBottom = new Optimizer.MoonnRadio();
            this.icontoaddgroup = new System.Windows.Forms.GroupBox();
            this.checkDefaultIcon = new Optimizer.MoonCheck();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.itemtype = new System.Windows.Forms.GroupBox();
            this.radioCommand = new Optimizer.MoonnRadio();
            this.radioProgram = new Optimizer.MoonnRadio();
            this.radioFolder = new Optimizer.MoonnRadio();
            this.radioLink = new Optimizer.MoonnRadio();
            this.radioFile = new Optimizer.MoonnRadio();
            this.addItemL = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listDesktopItems = new Optimizer.MoonList();
            this.refreshIIB = new System.Windows.Forms.Button();
            this.removeDIB = new System.Windows.Forms.Button();
            this.removeAllIIB = new System.Windows.Forms.Button();
            this.removeIntegratorItemsL = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.DeleteCMDB = new System.Windows.Forms.Button();
            this.AddCMDB = new System.Windows.Forms.Button();
            this.RemoveOwnerB = new System.Windows.Forms.Button();
            this.AddOwnerB = new System.Windows.Forms.Button();
            this.readyMenusL = new System.Windows.Forms.Label();
            this.PMB = new System.Windows.Forms.Button();
            this.DSB = new System.Windows.Forms.Button();
            this.STB = new System.Windows.Forms.Button();
            this.SSB = new System.Windows.Forms.Button();
            this.WAB = new System.Windows.Forms.Button();
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
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.quickAccessToggle = new Optimizer.ToggleCard();
            this.helpTipsToggle = new Optimizer.ToggleCard();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioCzech = new Optimizer.MoonnRadio();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.radioChinese = new Optimizer.MoonnRadio();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.radioItalian = new Optimizer.MoonnRadio();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.radioFrench = new Optimizer.MoonnRadio();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.radioPortuguese = new Optimizer.MoonnRadio();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.radioSpanish = new Optimizer.MoonnRadio();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioGerman = new Optimizer.MoonnRadio();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.radioTurkish = new Optimizer.MoonnRadio();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.radioHellenic = new Optimizer.MoonnRadio();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.radioEnglish = new Optimizer.MoonnRadio();
            this.radioRussian = new Optimizer.MoonnRadio();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rAmber = new System.Windows.Forms.RadioButton();
            this.rAmethyst = new System.Windows.Forms.RadioButton();
            this.rAzurite = new System.Windows.Forms.RadioButton();
            this.rRuby = new System.Windows.Forms.RadioButton();
            this.rJade = new System.Windows.Forms.RadioButton();
            this.rSilver = new System.Windows.Forms.RadioButton();
            this.languagesL = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.btnOpenConf = new System.Windows.Forms.Button();
            this.lblTroubleshoot = new System.Windows.Forms.Label();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.lblTheming = new System.Windows.Forms.Label();
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
            this.trayDownSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.trayUpSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.seperatorNetMon = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.helpBox = new Optimizer.MoonTip();
            this.tpanel.SuspendLayout();
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
            this.panelModernAppsList.SuspendLayout();
            this.startupTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.appsTab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCommonApps.SuspendLayout();
            this.cleanerTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pingerTab.SuspendLayout();
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
            this.optionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            this.panel8.SuspendLayout();
            this.launcherMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            this.tpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.tpanel.Size = new System.Drawing.Size(1009, 64);
            this.tpanel.TabIndex = 1;
            // 
            // picLab
            // 
            this.picLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLab.Image = ((System.Drawing.Image)(resources.GetObject("picLab.Image")));
            this.picLab.Location = new System.Drawing.Point(963, 15);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(30, 30);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLab.TabIndex = 72;
            this.picLab.TabStop = false;
            this.picLab.Visible = false;
            // 
            // picUpdate
            // 
            this.picUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(963, 15);
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
            this.txtNetFw.ForeColor = System.Drawing.Color.Silver;
            this.txtNetFw.Location = new System.Drawing.Point(188, 42);
            this.txtNetFw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNetFw.Name = "txtNetFw";
            this.txtNetFw.Size = new System.Drawing.Size(37, 15);
            this.txtNetFw.TabIndex = 70;
            this.txtNetFw.Text = "netfw";
            // 
            // txtBitness
            // 
            this.txtBitness.AutoSize = true;
            this.txtBitness.ForeColor = System.Drawing.Color.Silver;
            this.txtBitness.Location = new System.Drawing.Point(188, 24);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(44, 15);
            this.txtBitness.TabIndex = 4;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.AutoSize = true;
            this.txtOS.ForeColor = System.Drawing.Color.Silver;
            this.txtOS.Location = new System.Drawing.Point(188, 6);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(19, 15);
            this.txtOS.TabIndex = 3;
            this.txtOS.Text = "os";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.ForeColor = System.Drawing.Color.Silver;
            this.txtVersion.Location = new System.Drawing.Point(69, 37);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(77, 15);
            this.txtVersion.TabIndex = 1;
            this.txtVersion.Text = "Version: {VN}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bpanel.Size = new System.Drawing.Size(1009, 641);
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
            this.tabCollection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(2);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Drawing.Point(0, 0);
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(1007, 639);
            this.tabCollection.TabIndex = 0;
            this.tabCollection.SelectedIndexChanged += new System.EventHandler(this.aio_SelectedIndexChanged);
            // 
            // universalTab
            // 
            this.universalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.universalTab.Size = new System.Drawing.Size(999, 610);
            this.universalTab.TabIndex = 0;
            this.universalTab.Text = "Universal";
            // 
            // chromeTelemetrySw
            // 
            this.chromeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.chromeTelemetrySw.LabelText = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.Location = new System.Drawing.Point(457, 324);
            this.chromeTelemetrySw.Name = "chromeTelemetrySw";
            this.chromeTelemetrySw.Size = new System.Drawing.Size(414, 24);
            this.chromeTelemetrySw.TabIndex = 68;
            this.chromeTelemetrySw.Tag = "themeable";
            this.chromeTelemetrySw.ToggleChecked = false;
            // 
            // ffTelemetrySw
            // 
            this.ffTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ffTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.ffTelemetrySw.LabelText = "Disable Mozilla Firefox Telemetry";
            this.ffTelemetrySw.Location = new System.Drawing.Point(457, 287);
            this.ffTelemetrySw.Name = "ffTelemetrySw";
            this.ffTelemetrySw.Size = new System.Drawing.Size(414, 24);
            this.ffTelemetrySw.TabIndex = 67;
            this.ffTelemetrySw.Tag = "themeable";
            this.ffTelemetrySw.ToggleChecked = false;
            // 
            // vsSw
            // 
            this.vsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsSw.ForeColor = System.Drawing.Color.White;
            this.vsSw.LabelText = "Disable Visual Studio Telemetry";
            this.vsSw.Location = new System.Drawing.Point(21, 325);
            this.vsSw.Name = "vsSw";
            this.vsSw.Size = new System.Drawing.Size(414, 24);
            this.vsSw.TabIndex = 66;
            this.vsSw.Tag = "themeable";
            this.vsSw.ToggleChecked = false;
            // 
            // reportingSw
            // 
            this.reportingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.reportingSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingSw.ForeColor = System.Drawing.Color.White;
            this.reportingSw.LabelText = "Disable Error Reporting";
            this.reportingSw.Location = new System.Drawing.Point(21, 198);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.Size = new System.Drawing.Size(414, 24);
            this.reportingSw.TabIndex = 65;
            this.reportingSw.Tag = "themeable";
            this.reportingSw.ToggleChecked = false;
            // 
            // systemRestoreSw
            // 
            this.systemRestoreSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.systemRestoreSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.ForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.LabelText = "Disable System Restore";
            this.systemRestoreSw.Location = new System.Drawing.Point(21, 162);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.Size = new System.Drawing.Size(414, 24);
            this.systemRestoreSw.TabIndex = 64;
            this.systemRestoreSw.Tag = "themeable";
            this.systemRestoreSw.ToggleChecked = false;
            // 
            // officeTelemetrySw
            // 
            this.officeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.officeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.LabelText = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.Location = new System.Drawing.Point(21, 287);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.Size = new System.Drawing.Size(414, 24);
            this.officeTelemetrySw.TabIndex = 63;
            this.officeTelemetrySw.Tag = "themeable";
            this.officeTelemetrySw.ToggleChecked = false;
            // 
            // smartScreenSw
            // 
            this.smartScreenSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smartScreenSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartScreenSw.ForeColor = System.Drawing.Color.White;
            this.smartScreenSw.LabelText = "Disable SmartScreen";
            this.smartScreenSw.Location = new System.Drawing.Point(21, 126);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.Size = new System.Drawing.Size(414, 24);
            this.smartScreenSw.TabIndex = 62;
            this.smartScreenSw.Tag = "themeable";
            this.smartScreenSw.ToggleChecked = false;
            // 
            // networkSw
            // 
            this.networkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.networkSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkSw.ForeColor = System.Drawing.Color.White;
            this.networkSw.LabelText = "Disable Network Throttling";
            this.networkSw.Location = new System.Drawing.Point(21, 54);
            this.networkSw.Name = "networkSw";
            this.networkSw.Size = new System.Drawing.Size(414, 24);
            this.networkSw.TabIndex = 61;
            this.networkSw.Tag = "themeable";
            this.networkSw.ToggleChecked = false;
            // 
            // telemetryTasksSw
            // 
            this.telemetryTasksSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryTasksSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryTasksSw.ForeColor = System.Drawing.Color.White;
            this.telemetryTasksSw.LabelText = "Disable Telemetry Tasks";
            this.telemetryTasksSw.Location = new System.Drawing.Point(21, 234);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.Size = new System.Drawing.Size(414, 24);
            this.telemetryTasksSw.TabIndex = 60;
            this.telemetryTasksSw.Tag = "themeable";
            this.telemetryTasksSw.ToggleChecked = false;
            // 
            // defenderSw
            // 
            this.defenderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.defenderSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenderSw.ForeColor = System.Drawing.Color.White;
            this.defenderSw.LabelText = "Disable Windows Defender";
            this.defenderSw.Location = new System.Drawing.Point(21, 90);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.Size = new System.Drawing.Size(414, 24);
            this.defenderSw.TabIndex = 59;
            this.defenderSw.Tag = "themeable";
            this.defenderSw.ToggleChecked = false;
            // 
            // homegroupSw
            // 
            this.homegroupSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.homegroupSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homegroupSw.ForeColor = System.Drawing.Color.White;
            this.homegroupSw.LabelText = "Disable HomeGroup";
            this.homegroupSw.Location = new System.Drawing.Point(457, 162);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.Size = new System.Drawing.Size(414, 24);
            this.homegroupSw.TabIndex = 58;
            this.homegroupSw.Tag = "themeable";
            this.homegroupSw.ToggleChecked = false;
            // 
            // stickySw
            // 
            this.stickySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.stickySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickySw.ForeColor = System.Drawing.Color.White;
            this.stickySw.LabelText = "Disable Sticky Keys";
            this.stickySw.Location = new System.Drawing.Point(457, 126);
            this.stickySw.Name = "stickySw";
            this.stickySw.Size = new System.Drawing.Size(414, 24);
            this.stickySw.TabIndex = 57;
            this.stickySw.Tag = "themeable";
            this.stickySw.ToggleChecked = false;
            // 
            // compatSw
            // 
            this.compatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compatSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatSw.ForeColor = System.Drawing.Color.White;
            this.compatSw.LabelText = "Disable Compatibility Assistant";
            this.compatSw.Location = new System.Drawing.Point(457, 234);
            this.compatSw.Name = "compatSw";
            this.compatSw.Size = new System.Drawing.Size(414, 24);
            this.compatSw.TabIndex = 56;
            this.compatSw.Tag = "themeable";
            this.compatSw.ToggleChecked = false;
            // 
            // mediaSharingSw
            // 
            this.mediaSharingSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mediaSharingSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaSharingSw.ForeColor = System.Drawing.Color.White;
            this.mediaSharingSw.LabelText = "Disable Media Player Sharing";
            this.mediaSharingSw.Location = new System.Drawing.Point(457, 90);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.Size = new System.Drawing.Size(414, 24);
            this.mediaSharingSw.TabIndex = 55;
            this.mediaSharingSw.Tag = "themeable";
            this.mediaSharingSw.ToggleChecked = false;
            // 
            // printSw
            // 
            this.printSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSw.ForeColor = System.Drawing.Color.White;
            this.printSw.LabelText = "Disable Print Service";
            this.printSw.Location = new System.Drawing.Point(457, 18);
            this.printSw.Name = "printSw";
            this.printSw.Size = new System.Drawing.Size(414, 24);
            this.printSw.TabIndex = 54;
            this.printSw.Tag = "themeable";
            this.printSw.ToggleChecked = false;
            // 
            // superfetchSw
            // 
            this.superfetchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.superfetchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.ForeColor = System.Drawing.Color.White;
            this.superfetchSw.LabelText = "Disable Superfetch";
            this.superfetchSw.Location = new System.Drawing.Point(457, 198);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.Size = new System.Drawing.Size(414, 24);
            this.superfetchSw.TabIndex = 53;
            this.superfetchSw.Tag = "themeable";
            this.superfetchSw.ToggleChecked = false;
            // 
            // faxSw
            // 
            this.faxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.faxSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.ForeColor = System.Drawing.Color.White;
            this.faxSw.LabelText = "Disable Fax Service";
            this.faxSw.Location = new System.Drawing.Point(457, 54);
            this.faxSw.Name = "faxSw";
            this.faxSw.Size = new System.Drawing.Size(414, 24);
            this.faxSw.TabIndex = 52;
            this.faxSw.Tag = "themeable";
            this.faxSw.ToggleChecked = false;
            // 
            // performanceSw
            // 
            this.performanceSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.performanceSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceSw.ForeColor = System.Drawing.Color.White;
            this.performanceSw.LabelText = "Enable Performance Tweaks";
            this.performanceSw.Location = new System.Drawing.Point(21, 18);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.Size = new System.Drawing.Size(414, 24);
            this.performanceSw.TabIndex = 51;
            this.performanceSw.Tag = "themeable";
            this.performanceSw.ToggleChecked = false;
            // 
            // windows10Tab
            // 
            this.windows10Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows10Tab.Controls.Add(this.featuresSw);
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
            this.windows10Tab.Controls.Add(this.actionSw);
            this.windows10Tab.Controls.Add(this.xboxSw);
            this.windows10Tab.Controls.Add(this.inkSw);
            this.windows10Tab.Controls.Add(this.spellSw);
            this.windows10Tab.Controls.Add(this.longPathsSw);
            this.windows10Tab.Controls.Add(this.uODSw);
            this.windows10Tab.Controls.Add(this.peopleSw);
            this.windows10Tab.Controls.Add(this.oldExplorerSw);
            this.windows10Tab.Controls.Add(this.adsSw);
            this.windows10Tab.Controls.Add(this.panelWin11Tweaks);
            this.windows10Tab.Location = new System.Drawing.Point(4, 25);
            this.windows10Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Name = "windows10Tab";
            this.windows10Tab.Padding = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Size = new System.Drawing.Size(999, 610);
            this.windows10Tab.TabIndex = 1;
            this.windows10Tab.Text = "Windows 10";
            // 
            // featuresSw
            // 
            this.featuresSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.featuresSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresSw.ForeColor = System.Drawing.Color.White;
            this.featuresSw.LabelText = "Disable Feature Updates";
            this.featuresSw.Location = new System.Drawing.Point(21, 342);
            this.featuresSw.Name = "featuresSw";
            this.featuresSw.Size = new System.Drawing.Size(414, 24);
            this.featuresSw.TabIndex = 104;
            this.featuresSw.Tag = "themeable";
            this.featuresSw.ToggleChecked = false;
            // 
            // oldMixerSw
            // 
            this.oldMixerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldMixerSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMixerSw.ForeColor = System.Drawing.Color.White;
            this.oldMixerSw.LabelText = "Enable Classic Volume Mixer";
            this.oldMixerSw.Location = new System.Drawing.Point(21, 378);
            this.oldMixerSw.Name = "oldMixerSw";
            this.oldMixerSw.Size = new System.Drawing.Size(414, 24);
            this.oldMixerSw.TabIndex = 103;
            this.oldMixerSw.Tag = "themeable";
            this.oldMixerSw.ToggleChecked = false;
            // 
            // insiderSw
            // 
            this.insiderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.insiderSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.ForeColor = System.Drawing.Color.White;
            this.insiderSw.LabelText = "Disable Insider Service";
            this.insiderSw.Location = new System.Drawing.Point(444, 342);
            this.insiderSw.Name = "insiderSw";
            this.insiderSw.Size = new System.Drawing.Size(414, 24);
            this.insiderSw.TabIndex = 102;
            this.insiderSw.Tag = "themeable";
            this.insiderSw.ToggleChecked = false;
            // 
            // castSw
            // 
            this.castSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.castSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castSw.ForeColor = System.Drawing.Color.White;
            this.castSw.LabelText = "Remove Cast to Device";
            this.castSw.Location = new System.Drawing.Point(444, 270);
            this.castSw.Name = "castSw";
            this.castSw.Size = new System.Drawing.Size(414, 24);
            this.castSw.TabIndex = 101;
            this.castSw.Tag = "themeable";
            this.castSw.ToggleChecked = false;
            // 
            // gameBarSw
            // 
            this.gameBarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.gameBarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBarSw.ForeColor = System.Drawing.Color.White;
            this.gameBarSw.LabelText = "Disable Game Bar";
            this.gameBarSw.Location = new System.Drawing.Point(444, 306);
            this.gameBarSw.Name = "gameBarSw";
            this.gameBarSw.Size = new System.Drawing.Size(414, 24);
            this.gameBarSw.TabIndex = 100;
            this.gameBarSw.Tag = "themeable";
            this.gameBarSw.ToggleChecked = false;
            // 
            // sensorSw
            // 
            this.sensorSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sensorSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorSw.ForeColor = System.Drawing.Color.White;
            this.sensorSw.LabelText = "Disable Sensor Services";
            this.sensorSw.Location = new System.Drawing.Point(444, 234);
            this.sensorSw.Name = "sensorSw";
            this.sensorSw.Size = new System.Drawing.Size(414, 24);
            this.sensorSw.TabIndex = 99;
            this.sensorSw.Tag = "themeable";
            this.sensorSw.ToggleChecked = false;
            // 
            // ccSw
            // 
            this.ccSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ccSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccSw.ForeColor = System.Drawing.Color.White;
            this.ccSw.LabelText = "Disable Cloud Clipboard";
            this.ccSw.Location = new System.Drawing.Point(444, 162);
            this.ccSw.Name = "ccSw";
            this.ccSw.Size = new System.Drawing.Size(414, 24);
            this.ccSw.TabIndex = 98;
            this.ccSw.Tag = "themeable";
            this.ccSw.ToggleChecked = false;
            // 
            // cortanaSw
            // 
            this.cortanaSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cortanaSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortanaSw.ForeColor = System.Drawing.Color.White;
            this.cortanaSw.LabelText = "Disable Cortana";
            this.cortanaSw.Location = new System.Drawing.Point(444, 198);
            this.cortanaSw.Name = "cortanaSw";
            this.cortanaSw.Size = new System.Drawing.Size(414, 24);
            this.cortanaSw.TabIndex = 97;
            this.cortanaSw.Tag = "themeable";
            this.cortanaSw.ToggleChecked = false;
            // 
            // privacySw
            // 
            this.privacySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.privacySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacySw.ForeColor = System.Drawing.Color.White;
            this.privacySw.LabelText = "Enhance Privacy";
            this.privacySw.Location = new System.Drawing.Point(444, 126);
            this.privacySw.Name = "privacySw";
            this.privacySw.Size = new System.Drawing.Size(414, 24);
            this.privacySw.TabIndex = 96;
            this.privacySw.Tag = "themeable";
            this.privacySw.ToggleChecked = false;
            // 
            // driversSw
            // 
            this.driversSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.driversSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversSw.ForeColor = System.Drawing.Color.White;
            this.driversSw.LabelText = "Exclude Drivers from Update";
            this.driversSw.Location = new System.Drawing.Point(444, 54);
            this.driversSw.Name = "driversSw";
            this.driversSw.Size = new System.Drawing.Size(414, 24);
            this.driversSw.TabIndex = 95;
            this.driversSw.Tag = "themeable";
            this.driversSw.ToggleChecked = false;
            // 
            // telemetryServicesSw
            // 
            this.telemetryServicesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.telemetryServicesSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryServicesSw.ForeColor = System.Drawing.Color.White;
            this.telemetryServicesSw.LabelText = "Disable Telemetry Services";
            this.telemetryServicesSw.Location = new System.Drawing.Point(444, 90);
            this.telemetryServicesSw.Name = "telemetryServicesSw";
            this.telemetryServicesSw.Size = new System.Drawing.Size(414, 24);
            this.telemetryServicesSw.TabIndex = 94;
            this.telemetryServicesSw.Tag = "themeable";
            this.telemetryServicesSw.ToggleChecked = false;
            // 
            // autoUpdatesSw
            // 
            this.autoUpdatesSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoUpdatesSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdatesSw.ForeColor = System.Drawing.Color.White;
            this.autoUpdatesSw.LabelText = "Disable Automatic Updates";
            this.autoUpdatesSw.Location = new System.Drawing.Point(444, 18);
            this.autoUpdatesSw.Name = "autoUpdatesSw";
            this.autoUpdatesSw.Size = new System.Drawing.Size(414, 24);
            this.autoUpdatesSw.TabIndex = 93;
            this.autoUpdatesSw.Tag = "themeable";
            this.autoUpdatesSw.ToggleChecked = false;
            // 
            // tpmSw
            // 
            this.tpmSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpmSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpmSw.ForeColor = System.Drawing.Color.White;
            this.tpmSw.LabelText = "Disable TPM 2.0 Check";
            this.tpmSw.Location = new System.Drawing.Point(21, 306);
            this.tpmSw.Name = "tpmSw";
            this.tpmSw.Size = new System.Drawing.Size(414, 24);
            this.tpmSw.TabIndex = 92;
            this.tpmSw.Tag = "themeable";
            this.tpmSw.ToggleChecked = false;
            // 
            // actionSw
            // 
            this.actionSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.actionSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionSw.ForeColor = System.Drawing.Color.White;
            this.actionSw.LabelText = "Disable Notification Center";
            this.actionSw.Location = new System.Drawing.Point(444, 378);
            this.actionSw.Name = "actionSw";
            this.actionSw.Size = new System.Drawing.Size(414, 24);
            this.actionSw.TabIndex = 91;
            this.actionSw.Tag = "themeable";
            this.actionSw.ToggleChecked = false;
            // 
            // xboxSw
            // 
            this.xboxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xboxSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxSw.ForeColor = System.Drawing.Color.White;
            this.xboxSw.LabelText = "Disable Xbox Live";
            this.xboxSw.Location = new System.Drawing.Point(21, 270);
            this.xboxSw.Name = "xboxSw";
            this.xboxSw.Size = new System.Drawing.Size(414, 24);
            this.xboxSw.TabIndex = 90;
            this.xboxSw.Tag = "themeable";
            this.xboxSw.ToggleChecked = false;
            // 
            // inkSw
            // 
            this.inkSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inkSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkSw.ForeColor = System.Drawing.Color.White;
            this.inkSw.LabelText = "Disable Windows Ink";
            this.inkSw.Location = new System.Drawing.Point(21, 198);
            this.inkSw.Name = "inkSw";
            this.inkSw.Size = new System.Drawing.Size(414, 24);
            this.inkSw.TabIndex = 89;
            this.inkSw.Tag = "themeable";
            this.inkSw.ToggleChecked = false;
            // 
            // spellSw
            // 
            this.spellSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.spellSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellSw.ForeColor = System.Drawing.Color.White;
            this.spellSw.LabelText = "Disable Spell Checking";
            this.spellSw.Location = new System.Drawing.Point(21, 234);
            this.spellSw.Name = "spellSw";
            this.spellSw.Size = new System.Drawing.Size(414, 24);
            this.spellSw.TabIndex = 88;
            this.spellSw.Tag = "themeable";
            this.spellSw.ToggleChecked = false;
            // 
            // longPathsSw
            // 
            this.longPathsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.longPathsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPathsSw.ForeColor = System.Drawing.Color.White;
            this.longPathsSw.LabelText = "Enable Long Paths";
            this.longPathsSw.Location = new System.Drawing.Point(21, 162);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.Size = new System.Drawing.Size(414, 24);
            this.longPathsSw.TabIndex = 87;
            this.longPathsSw.Tag = "themeable";
            this.longPathsSw.ToggleChecked = false;
            // 
            // uODSw
            // 
            this.uODSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uODSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.ForeColor = System.Drawing.Color.White;
            this.uODSw.LabelText = "Uninstall OneDrive";
            this.uODSw.Location = new System.Drawing.Point(21, 90);
            this.uODSw.Name = "uODSw";
            this.uODSw.Size = new System.Drawing.Size(414, 24);
            this.uODSw.TabIndex = 86;
            this.uODSw.Tag = "themeable";
            this.uODSw.ToggleChecked = false;
            // 
            // peopleSw
            // 
            this.peopleSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.peopleSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.ForeColor = System.Drawing.Color.White;
            this.peopleSw.LabelText = "Disable My People";
            this.peopleSw.Location = new System.Drawing.Point(21, 126);
            this.peopleSw.Name = "peopleSw";
            this.peopleSw.Size = new System.Drawing.Size(414, 24);
            this.peopleSw.TabIndex = 85;
            this.peopleSw.Tag = "themeable";
            this.peopleSw.ToggleChecked = false;
            // 
            // oldExplorerSw
            // 
            this.oldExplorerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.oldExplorerSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldExplorerSw.ForeColor = System.Drawing.Color.White;
            this.oldExplorerSw.LabelText = "Restore Classic Windows Explorer";
            this.oldExplorerSw.Location = new System.Drawing.Point(21, 18);
            this.oldExplorerSw.Name = "oldExplorerSw";
            this.oldExplorerSw.Size = new System.Drawing.Size(414, 24);
            this.oldExplorerSw.TabIndex = 83;
            this.oldExplorerSw.Tag = "themeable";
            this.oldExplorerSw.ToggleChecked = false;
            // 
            // adsSw
            // 
            this.adsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.adsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsSw.ForeColor = System.Drawing.Color.White;
            this.adsSw.LabelText = "Disable Start Menu Ads";
            this.adsSw.Location = new System.Drawing.Point(21, 54);
            this.adsSw.Name = "adsSw";
            this.adsSw.Size = new System.Drawing.Size(414, 24);
            this.adsSw.TabIndex = 82;
            this.adsSw.Tag = "themeable";
            this.adsSw.ToggleChecked = false;
            // 
            // panelWin11Tweaks
            // 
            this.panelWin11Tweaks.Controls.Add(this.classicRibbonSw);
            this.panelWin11Tweaks.Controls.Add(this.snapAssistSw);
            this.panelWin11Tweaks.Controls.Add(this.widgetsSw);
            this.panelWin11Tweaks.Controls.Add(this.leftTaskbarSw);
            this.panelWin11Tweaks.Controls.Add(this.classicContextSw);
            this.panelWin11Tweaks.Controls.Add(this.chatSw);
            this.panelWin11Tweaks.Controls.Add(this.smallerTaskbarSw);
            this.panelWin11Tweaks.Location = new System.Drawing.Point(7, 408);
            this.panelWin11Tweaks.Name = "panelWin11Tweaks";
            this.panelWin11Tweaks.Size = new System.Drawing.Size(985, 196);
            this.panelWin11Tweaks.TabIndex = 80;
            this.panelWin11Tweaks.Visible = false;
            // 
            // classicRibbonSw
            // 
            this.classicRibbonSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicRibbonSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicRibbonSw.ForeColor = System.Drawing.Color.White;
            this.classicRibbonSw.LabelText = "Enable Classic Ribbon in Explorer";
            this.classicRibbonSw.Location = new System.Drawing.Point(437, 51);
            this.classicRibbonSw.Name = "classicRibbonSw";
            this.classicRibbonSw.Size = new System.Drawing.Size(414, 24);
            this.classicRibbonSw.TabIndex = 111;
            this.classicRibbonSw.Tag = "themeable";
            this.classicRibbonSw.ToggleChecked = false;
            // 
            // snapAssistSw
            // 
            this.snapAssistSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snapAssistSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapAssistSw.ForeColor = System.Drawing.Color.White;
            this.snapAssistSw.LabelText = "Disable Snap Assist";
            this.snapAssistSw.Location = new System.Drawing.Point(14, 51);
            this.snapAssistSw.Name = "snapAssistSw";
            this.snapAssistSw.Size = new System.Drawing.Size(414, 24);
            this.snapAssistSw.TabIndex = 106;
            this.snapAssistSw.Tag = "themeable";
            this.snapAssistSw.ToggleChecked = false;
            // 
            // widgetsSw
            // 
            this.widgetsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.widgetsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widgetsSw.ForeColor = System.Drawing.Color.White;
            this.widgetsSw.LabelText = "Disable Widgets";
            this.widgetsSw.Location = new System.Drawing.Point(14, 87);
            this.widgetsSw.Name = "widgetsSw";
            this.widgetsSw.Size = new System.Drawing.Size(414, 24);
            this.widgetsSw.TabIndex = 108;
            this.widgetsSw.Tag = "themeable";
            this.widgetsSw.ToggleChecked = false;
            // 
            // leftTaskbarSw
            // 
            this.leftTaskbarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.leftTaskbarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTaskbarSw.ForeColor = System.Drawing.Color.White;
            this.leftTaskbarSw.LabelText = "Align Taskbar to Left";
            this.leftTaskbarSw.Location = new System.Drawing.Point(14, 15);
            this.leftTaskbarSw.Name = "leftTaskbarSw";
            this.leftTaskbarSw.Size = new System.Drawing.Size(414, 24);
            this.leftTaskbarSw.TabIndex = 105;
            this.leftTaskbarSw.Tag = "themeable";
            this.leftTaskbarSw.ToggleChecked = false;
            // 
            // classicContextSw
            // 
            this.classicContextSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicContextSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicContextSw.ForeColor = System.Drawing.Color.White;
            this.classicContextSw.LabelText = "Enable Classic Right-Click Menu";
            this.classicContextSw.Location = new System.Drawing.Point(437, 87);
            this.classicContextSw.Name = "classicContextSw";
            this.classicContextSw.Size = new System.Drawing.Size(414, 24);
            this.classicContextSw.TabIndex = 110;
            this.classicContextSw.Tag = "themeable";
            this.classicContextSw.ToggleChecked = false;
            // 
            // chatSw
            // 
            this.chatSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chatSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatSw.ForeColor = System.Drawing.Color.White;
            this.chatSw.LabelText = "Disable Chat";
            this.chatSw.Location = new System.Drawing.Point(14, 123);
            this.chatSw.Name = "chatSw";
            this.chatSw.Size = new System.Drawing.Size(414, 24);
            this.chatSw.TabIndex = 107;
            this.chatSw.Tag = "themeable";
            this.chatSw.ToggleChecked = false;
            // 
            // smallerTaskbarSw
            // 
            this.smallerTaskbarSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smallerTaskbarSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallerTaskbarSw.ForeColor = System.Drawing.Color.White;
            this.smallerTaskbarSw.LabelText = "Make Taskbar Smaller";
            this.smallerTaskbarSw.Location = new System.Drawing.Point(437, 15);
            this.smallerTaskbarSw.Name = "smallerTaskbarSw";
            this.smallerTaskbarSw.Size = new System.Drawing.Size(414, 24);
            this.smallerTaskbarSw.TabIndex = 109;
            this.smallerTaskbarSw.Tag = "themeable";
            this.smallerTaskbarSw.ToggleChecked = false;
            // 
            // windows8Tab
            // 
            this.windows8Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows8Tab.Controls.Add(this.disableOneDriveSw);
            this.windows8Tab.Location = new System.Drawing.Point(4, 25);
            this.windows8Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows8Tab.Name = "windows8Tab";
            this.windows8Tab.Padding = new System.Windows.Forms.Padding(2);
            this.windows8Tab.Size = new System.Drawing.Size(999, 610);
            this.windows8Tab.TabIndex = 2;
            this.windows8Tab.Text = "Windows 8.1";
            // 
            // disableOneDriveSw
            // 
            this.disableOneDriveSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disableOneDriveSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.ForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.LabelText = "Disable OneDrive";
            this.disableOneDriveSw.Location = new System.Drawing.Point(21, 18);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.Size = new System.Drawing.Size(500, 24);
            this.disableOneDriveSw.TabIndex = 84;
            this.disableOneDriveSw.Tag = "themeable";
            this.disableOneDriveSw.ToggleChecked = false;
            // 
            // modernAppsTab
            // 
            this.modernAppsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modernAppsTab.Controls.Add(this.chkOnlyRemovable);
            this.modernAppsTab.Controls.Add(this.chkSelectAllModernApps);
            this.modernAppsTab.Controls.Add(this.txtUWP);
            this.modernAppsTab.Controls.Add(this.uninstallModernAppsButton);
            this.modernAppsTab.Controls.Add(this.refreshModernAppsButton);
            this.modernAppsTab.Controls.Add(this.txtModernAppsTitle);
            this.modernAppsTab.Controls.Add(this.panelModernAppsList);
            this.modernAppsTab.Location = new System.Drawing.Point(4, 25);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(3);
            this.modernAppsTab.Size = new System.Drawing.Size(999, 610);
            this.modernAppsTab.TabIndex = 11;
            this.modernAppsTab.Text = "UWP Apps";
            // 
            // chkOnlyRemovable
            // 
            this.chkOnlyRemovable.AutoSize = true;
            this.chkOnlyRemovable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.chkOnlyRemovable.ForeColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Location = new System.Drawing.Point(503, 140);
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
            this.chkSelectAllModernApps.Location = new System.Drawing.Point(503, 111);
            this.chkSelectAllModernApps.Margin = new System.Windows.Forms.Padding(2);
            this.chkSelectAllModernApps.Name = "chkSelectAllModernApps";
            this.chkSelectAllModernApps.Size = new System.Drawing.Size(94, 25);
            this.chkSelectAllModernApps.TabIndex = 52;
            this.chkSelectAllModernApps.Text = "Select all";
            this.chkSelectAllModernApps.UseVisualStyleBackColor = true;
            this.chkSelectAllModernApps.CheckedChanged += new System.EventHandler(this.chkSelectAllModernApps_CheckedChanged);
            // 
            // txtUWP
            // 
            this.txtUWP.AutoSize = true;
            this.txtUWP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUWP.ForeColor = System.Drawing.Color.Silver;
            this.txtUWP.Location = new System.Drawing.Point(499, 195);
            this.txtUWP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUWP.Name = "txtUWP";
            this.txtUWP.Size = new System.Drawing.Size(160, 231);
            this.txtUWP.TabIndex = 51;
            this.txtUWP.Tag = "";
            this.txtUWP.Text = "IMPORTANT:\r\n\r\nIf you uninstall Store\r\nyou won\'t be able\r\nto install new apps!\r\n\r\n" +
    "Also, some apps\r\ncan\'t be uninstalled.\r\n\r\nLike Microsoft Edge,\r\nSettings, etc.";
            // 
            // uninstallModernAppsButton
            // 
            this.uninstallModernAppsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.uninstallModernAppsButton.FlatAppearance.BorderSize = 0;
            this.uninstallModernAppsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.uninstallModernAppsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.uninstallModernAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallModernAppsButton.ForeColor = System.Drawing.Color.White;
            this.uninstallModernAppsButton.Location = new System.Drawing.Point(503, 76);
            this.uninstallModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
            this.uninstallModernAppsButton.Size = new System.Drawing.Size(169, 31);
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
            this.refreshModernAppsButton.Location = new System.Drawing.Point(503, 41);
            this.refreshModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshModernAppsButton.Name = "refreshModernAppsButton";
            this.refreshModernAppsButton.Size = new System.Drawing.Size(169, 31);
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
            // panelModernAppsList
            // 
            this.panelModernAppsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelModernAppsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelModernAppsList.Controls.Add(this.listModernApps);
            this.panelModernAppsList.Location = new System.Drawing.Point(11, 41);
            this.panelModernAppsList.Name = "panelModernAppsList";
            this.panelModernAppsList.Size = new System.Drawing.Size(487, 449);
            this.panelModernAppsList.TabIndex = 0;
            // 
            // listModernApps
            // 
            this.listModernApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listModernApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listModernApps.CheckOnClick = true;
            this.listModernApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listModernApps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listModernApps.ForeColor = System.Drawing.Color.White;
            this.listModernApps.FormattingEnabled = true;
            this.listModernApps.HorizontalScrollbar = true;
            this.listModernApps.Location = new System.Drawing.Point(0, 0);
            this.listModernApps.Name = "listModernApps";
            this.listModernApps.Size = new System.Drawing.Size(485, 447);
            this.listModernApps.Sorted = true;
            this.listModernApps.TabIndex = 0;
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
            this.startupTab.Size = new System.Drawing.Size(999, 610);
            this.startupTab.TabIndex = 7;
            this.startupTab.Text = "Startup";
            // 
            // cancelBackup
            // 
            this.cancelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.BorderSize = 0;
            this.cancelBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.ForeColor = System.Drawing.Color.White;
            this.cancelBackup.Location = new System.Drawing.Point(106, 551);
            this.cancelBackup.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBackup.Name = "cancelBackup";
            this.cancelBackup.Size = new System.Drawing.Size(90, 25);
            this.cancelBackup.TabIndex = 61;
            this.cancelBackup.Text = "Cancel";
            this.cancelBackup.UseVisualStyleBackColor = false;
            this.cancelBackup.Visible = false;
            this.cancelBackup.Click += new System.EventHandler(this.button14_Click);
            // 
            // doBackup
            // 
            this.doBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.doBackup.FlatAppearance.BorderSize = 0;
            this.doBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doBackup.ForeColor = System.Drawing.Color.White;
            this.doBackup.Location = new System.Drawing.Point(12, 551);
            this.doBackup.Margin = new System.Windows.Forms.Padding(2);
            this.doBackup.Name = "doBackup";
            this.doBackup.Size = new System.Drawing.Size(90, 25);
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
            this.restoreStartupB.Location = new System.Drawing.Point(176, 502);
            this.restoreStartupB.Margin = new System.Windows.Forms.Padding(2);
            this.restoreStartupB.Name = "restoreStartupB";
            this.restoreStartupB.Size = new System.Drawing.Size(160, 31);
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
            this.backupStartupB.Size = new System.Drawing.Size(160, 31);
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
            this.findInRegB.Location = new System.Drawing.Point(656, 538);
            this.findInRegB.Margin = new System.Windows.Forms.Padding(2);
            this.findInRegB.Name = "findInRegB";
            this.findInRegB.Size = new System.Drawing.Size(160, 31);
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
            this.locateFileB.Location = new System.Drawing.Point(820, 503);
            this.locateFileB.Margin = new System.Windows.Forms.Padding(2);
            this.locateFileB.Name = "locateFileB";
            this.locateFileB.Size = new System.Drawing.Size(160, 31);
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
            this.refreshStartupB.Location = new System.Drawing.Point(820, 538);
            this.refreshStartupB.Margin = new System.Windows.Forms.Padding(2);
            this.refreshStartupB.Name = "refreshStartupB";
            this.refreshStartupB.Size = new System.Drawing.Size(160, 31);
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
            this.panel3.Size = new System.Drawing.Size(969, 459);
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
            this.listStartupItems.Size = new System.Drawing.Size(967, 457);
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
            this.removeStartupItemB.Location = new System.Drawing.Point(656, 503);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(2);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(160, 31);
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
            this.appsTab.Size = new System.Drawing.Size(999, 610);
            this.appsTab.TabIndex = 12;
            this.appsTab.Text = "Common Apps";
            // 
            // txtFeedError
            // 
            this.txtFeedError.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedError.ForeColor = System.Drawing.Color.Gold;
            this.txtFeedError.Location = new System.Drawing.Point(3, 47);
            this.txtFeedError.Name = "txtFeedError";
            this.txtFeedError.Size = new System.Drawing.Size(993, 440);
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
            this.groupSoundVideo.Size = new System.Drawing.Size(227, 421);
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
            this.groupCoding.Size = new System.Drawing.Size(226, 421);
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
            this.groupInternet.Size = new System.Drawing.Size(246, 421);
            this.groupInternet.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(993, 44);
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
            this.btnGetFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFeed.ForeColor = System.Drawing.Color.White;
            this.btnGetFeed.Location = new System.Drawing.Point(845, 7);
            this.btnGetFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetFeed.Name = "btnGetFeed";
            this.btnGetFeed.Size = new System.Drawing.Size(144, 32);
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
            this.panelCommonApps.Location = new System.Drawing.Point(3, 487);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(993, 120);
            this.panelCommonApps.TabIndex = 162;
            // 
            // cAutoInstall
            // 
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cAutoInstall.Location = new System.Drawing.Point(620, 55);
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
            this.btnDownloadApps.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadApps.ForeColor = System.Drawing.Color.White;
            this.btnDownloadApps.Location = new System.Drawing.Point(808, 82);
            this.btnDownloadApps.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadApps.Name = "btnDownloadApps";
            this.btnDownloadApps.Size = new System.Drawing.Size(183, 35);
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
            this.goToDownloadsB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToDownloadsB.ForeColor = System.Drawing.Color.White;
            this.goToDownloadsB.Location = new System.Drawing.Point(621, 82);
            this.goToDownloadsB.Margin = new System.Windows.Forms.Padding(2);
            this.goToDownloadsB.Name = "goToDownloadsB";
            this.goToDownloadsB.Size = new System.Drawing.Size(183, 35);
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
            this.groupSystemTools.Size = new System.Drawing.Size(246, 421);
            this.groupSystemTools.TabIndex = 162;
            // 
            // cleanerTab
            // 
            this.cleanerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cleanerTab.Controls.Add(this.cleanerTitle);
            this.cleanerTab.Controls.Add(this.panel1);
            this.cleanerTab.Location = new System.Drawing.Point(4, 25);
            this.cleanerTab.Margin = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Size = new System.Drawing.Size(999, 610);
            this.cleanerTab.TabIndex = 5;
            this.cleanerTab.Text = "Cleaner";
            // 
            // cleanerTitle
            // 
            this.cleanerTitle.AutoSize = true;
            this.cleanerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cleanerTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cleanerTitle.Location = new System.Drawing.Point(6, 10);
            this.cleanerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cleanerTitle.Name = "cleanerTitle";
            this.cleanerTitle.Size = new System.Drawing.Size(260, 28);
            this.cleanerTitle.TabIndex = 46;
            this.cleanerTitle.Tag = "themeable";
            this.cleanerTitle.Text = "Clean up your system drive";
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.lblPretext);
            this.panel1.Controls.Add(this.lblFootprint);
            this.panel1.Controls.Add(this.checkErrorReports);
            this.panel1.Controls.Add(this.cleanDriveB);
            this.panel1.Controls.Add(this.checkSelectAll);
            this.panel1.Controls.Add(this.checkTemp);
            this.panel1.Controls.Add(this.checkBin);
            this.panel1.Controls.Add(this.checkMiniDumps);
            this.panel1.Location = new System.Drawing.Point(11, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 514);
            this.panel1.TabIndex = 45;
            // 
            // edgeSession
            // 
            this.edgeSession.AutoSize = true;
            this.edgeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeSession.ForeColor = System.Drawing.Color.White;
            this.edgeSession.Location = new System.Drawing.Point(523, 321);
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
            this.edgeHistory.Location = new System.Drawing.Point(523, 294);
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
            this.edgeCookies.Location = new System.Drawing.Point(523, 267);
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
            this.edgeCache.Location = new System.Drawing.Point(523, 240);
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
            this.IECache.Location = new System.Drawing.Point(334, 240);
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
            this.firefoxHistory.Location = new System.Drawing.Point(523, 98);
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
            this.firefoxCookies.Location = new System.Drawing.Point(523, 71);
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
            this.firefoxCache.Location = new System.Drawing.Point(523, 44);
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
            this.chromePws.Location = new System.Drawing.Point(334, 152);
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
            this.chromeSession.Location = new System.Drawing.Point(334, 125);
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
            this.chromeHistory.Location = new System.Drawing.Point(334, 98);
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
            this.chromeCookies.Location = new System.Drawing.Point(334, 71);
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
            this.chromeCache.Location = new System.Drawing.Point(334, 44);
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
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(550, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 56;
            this.label7.Tag = "";
            this.label7.Text = "Microsoft Edge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(361, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 55;
            this.label6.Tag = "";
            this.label6.Text = "Internet Explorer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(550, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 54;
            this.label5.Tag = "";
            this.label5.Text = "Mozilla Firefox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(362, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 47;
            this.label4.Tag = "";
            this.label4.Text = "Google Chrome";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(523, 211);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 24);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(334, 211);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 24);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 52;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(334, 15);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(523, 17);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // lblPretext
            // 
            this.lblPretext.AutoSize = true;
            this.lblPretext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretext.ForeColor = System.Drawing.Color.Silver;
            this.lblPretext.Location = new System.Drawing.Point(51, 416);
            this.lblPretext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretext.Name = "lblPretext";
            this.lblPretext.Size = new System.Drawing.Size(199, 21);
            this.lblPretext.TabIndex = 49;
            this.lblPretext.Tag = "";
            this.lblPretext.Text = "Maximum size to be freed:";
            this.lblPretext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFootprint
            // 
            this.lblFootprint.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootprint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFootprint.Location = new System.Drawing.Point(52, 437);
            this.lblFootprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFootprint.Name = "lblFootprint";
            this.lblFootprint.Size = new System.Drawing.Size(119, 31);
            this.lblFootprint.TabIndex = 48;
            this.lblFootprint.Tag = "themeable";
            this.lblFootprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkErrorReports
            // 
            this.checkErrorReports.AutoSize = true;
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(55, 103);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.Size = new System.Drawing.Size(123, 25);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.Text = "Error reports";
            this.checkErrorReports.UseVisualStyleBackColor = true;
            // 
            // cleanDriveB
            // 
            this.cleanDriveB.BackColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.BorderSize = 0;
            this.cleanDriveB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanDriveB.ForeColor = System.Drawing.Color.White;
            this.cleanDriveB.Location = new System.Drawing.Point(29, 371);
            this.cleanDriveB.Margin = new System.Windows.Forms.Padding(2);
            this.cleanDriveB.Name = "cleanDriveB";
            this.cleanDriveB.Size = new System.Drawing.Size(120, 31);
            this.cleanDriveB.TabIndex = 34;
            this.cleanDriveB.Text = "Clean";
            this.cleanDriveB.UseVisualStyleBackColor = false;
            this.cleanDriveB.Click += new System.EventHandler(this.button20_Click);
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSelectAll.ForeColor = System.Drawing.Color.Silver;
            this.checkSelectAll.Location = new System.Drawing.Point(29, 14);
            this.checkSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(94, 25);
            this.checkSelectAll.TabIndex = 35;
            this.checkSelectAll.Tag = "";
            this.checkSelectAll.Text = "Select all";
            this.checkSelectAll.UseVisualStyleBackColor = true;
            this.checkSelectAll.CheckedChanged += new System.EventHandler(this.checkSelectAll_CheckedChanged);
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTemp.ForeColor = System.Drawing.Color.White;
            this.checkTemp.Location = new System.Drawing.Point(55, 45);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(142, 25);
            this.checkTemp.TabIndex = 36;
            this.checkTemp.Text = "Temporary files";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkBin
            // 
            this.checkBin.AutoSize = true;
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.Silver;
            this.checkBin.Location = new System.Drawing.Point(29, 156);
            this.checkBin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBin.Name = "checkBin";
            this.checkBin.Size = new System.Drawing.Size(162, 25);
            this.checkBin.TabIndex = 41;
            this.checkBin.Text = "Empty Recycle Bin";
            this.checkBin.UseVisualStyleBackColor = true;
            // 
            // checkMiniDumps
            // 
            this.checkMiniDumps.AutoSize = true;
            this.checkMiniDumps.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniDumps.ForeColor = System.Drawing.Color.White;
            this.checkMiniDumps.Location = new System.Drawing.Point(55, 74);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(2);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.Size = new System.Drawing.Size(157, 25);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.Text = "BSOD Minidumps";
            this.checkMiniDumps.UseVisualStyleBackColor = true;
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pingerTab.Controls.Add(this.btnOpenNetwork);
            this.pingerTab.Controls.Add(this.txtIPv6A);
            this.pingerTab.Controls.Add(this.txtIPv6);
            this.pingerTab.Controls.Add(this.label3);
            this.pingerTab.Controls.Add(this.txtIPv4A);
            this.pingerTab.Controls.Add(this.label1);
            this.pingerTab.Controls.Add(this.txtIPv4);
            this.pingerTab.Controls.Add(this.lblDNS);
            this.pingerTab.Controls.Add(this.flushCacheB);
            this.pingerTab.Controls.Add(this.btnExport);
            this.pingerTab.Controls.Add(this.copyB);
            this.pingerTab.Controls.Add(this.copyIPB);
            this.pingerTab.Controls.Add(this.panel7);
            this.pingerTab.Controls.Add(this.lblResults);
            this.pingerTab.Controls.Add(this.btnShodan);
            this.pingerTab.Controls.Add(this.btnPing);
            this.pingerTab.Controls.Add(this.txtPingInput);
            this.pingerTab.Controls.Add(this.lblPinger);
            this.pingerTab.Controls.Add(this.pingerTitle);
            this.pingerTab.Location = new System.Drawing.Point(4, 25);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(3);
            this.pingerTab.Size = new System.Drawing.Size(999, 610);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // btnOpenNetwork
            // 
            this.btnOpenNetwork.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenNetwork.FlatAppearance.BorderSize = 0;
            this.btnOpenNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenNetwork.ForeColor = System.Drawing.Color.White;
            this.btnOpenNetwork.Location = new System.Drawing.Point(579, 381);
            this.btnOpenNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenNetwork.Name = "btnOpenNetwork";
            this.btnOpenNetwork.Size = new System.Drawing.Size(200, 29);
            this.btnOpenNetwork.TabIndex = 92;
            this.btnOpenNetwork.Text = "Open Network Connections";
            this.btnOpenNetwork.UseVisualStyleBackColor = false;
            this.btnOpenNetwork.Click += new System.EventHandler(this.btnOpenNetwork_Click);
            // 
            // txtIPv6A
            // 
            this.txtIPv6A.AutoSize = true;
            this.txtIPv6A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6A.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv6A.LinkColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv6A.Location = new System.Drawing.Point(618, 335);
            this.txtIPv6A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIPv6A.Name = "txtIPv6A";
            this.txtIPv6A.Size = new System.Drawing.Size(164, 21);
            this.txtIPv6A.TabIndex = 91;
            this.txtIPv6A.TabStop = true;
            this.txtIPv6A.Tag = "themeable";
            this.txtIPv6A.Text = "2606:4700:4700::1001";
            this.txtIPv6A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtIPv6A_LinkClicked);
            // 
            // txtIPv6
            // 
            this.txtIPv6.AutoSize = true;
            this.txtIPv6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv6.LinkColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv6.Location = new System.Drawing.Point(618, 311);
            this.txtIPv6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIPv6.Name = "txtIPv6";
            this.txtIPv6.Size = new System.Drawing.Size(158, 21);
            this.txtIPv6.TabIndex = 90;
            this.txtIPv6.TabStop = true;
            this.txtIPv6.Tag = "themeable";
            this.txtIPv6.Text = "2606:4700:4700::1111";
            this.txtIPv6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtIPv6_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(575, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 89;
            this.label3.Tag = "";
            this.label3.Text = "IPv6:";
            // 
            // txtIPv4A
            // 
            this.txtIPv4A.AutoSize = true;
            this.txtIPv4A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv4A.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv4A.LinkColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv4A.Location = new System.Drawing.Point(618, 271);
            this.txtIPv4A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIPv4A.Name = "txtIPv4A";
            this.txtIPv4A.Size = new System.Drawing.Size(52, 21);
            this.txtIPv4A.TabIndex = 88;
            this.txtIPv4A.TabStop = true;
            this.txtIPv4A.Tag = "themeable";
            this.txtIPv4A.Text = "1.0.0.1";
            this.txtIPv4A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtIPv4A_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(575, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 87;
            this.label1.Tag = "";
            this.label1.Text = "IPv4:";
            // 
            // txtIPv4
            // 
            this.txtIPv4.AutoSize = true;
            this.txtIPv4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv4.LinkColor = System.Drawing.Color.DodgerBlue;
            this.txtIPv4.Location = new System.Drawing.Point(618, 247);
            this.txtIPv4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.Size = new System.Drawing.Size(46, 21);
            this.txtIPv4.TabIndex = 86;
            this.txtIPv4.TabStop = true;
            this.txtIPv4.Tag = "themeable";
            this.txtIPv4.Text = "1.1.1.1";
            this.txtIPv4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtIPv4_LinkClicked);
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNS.ForeColor = System.Drawing.Color.Silver;
            this.lblDNS.Location = new System.Drawing.Point(575, 196);
            this.lblDNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(204, 38);
            this.lblDNS.TabIndex = 85;
            this.lblDNS.Tag = "";
            this.lblDNS.Text = "Recommended Cloudflare DNS\r\n(click to copy)";
            // 
            // flushCacheB
            // 
            this.flushCacheB.BackColor = System.Drawing.Color.DodgerBlue;
            this.flushCacheB.FlatAppearance.BorderSize = 0;
            this.flushCacheB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flushCacheB.ForeColor = System.Drawing.Color.White;
            this.flushCacheB.Location = new System.Drawing.Point(579, 414);
            this.flushCacheB.Margin = new System.Windows.Forms.Padding(2);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(200, 29);
            this.flushCacheB.TabIndex = 84;
            this.flushCacheB.Text = "Flush DNS cache";
            this.flushCacheB.UseVisualStyleBackColor = false;
            this.flushCacheB.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(26, 512);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 29);
            this.btnExport.TabIndex = 83;
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
            this.copyB.Location = new System.Drawing.Point(265, 116);
            this.copyB.Margin = new System.Windows.Forms.Padding(2);
            this.copyB.Name = "copyB";
            this.copyB.Size = new System.Drawing.Size(146, 31);
            this.copyB.TabIndex = 82;
            this.copyB.Text = "Copy IP";
            this.copyB.UseVisualStyleBackColor = false;
            this.copyB.Click += new System.EventHandler(this.button9_Click);
            // 
            // copyIPB
            // 
            this.copyIPB.BackColor = System.Drawing.Color.DodgerBlue;
            this.copyIPB.FlatAppearance.BorderSize = 0;
            this.copyIPB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.copyIPB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.copyIPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyIPB.ForeColor = System.Drawing.Color.White;
            this.copyIPB.Location = new System.Drawing.Point(415, 116);
            this.copyIPB.Margin = new System.Windows.Forms.Padding(2);
            this.copyIPB.Name = "copyIPB";
            this.copyIPB.Size = new System.Drawing.Size(146, 31);
            this.copyIPB.TabIndex = 81;
            this.copyIPB.Text = "Copy";
            this.copyIPB.UseVisualStyleBackColor = false;
            this.copyIPB.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.listPingResults);
            this.panel7.Location = new System.Drawing.Point(26, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(544, 307);
            this.panel7.TabIndex = 80;
            // 
            // listPingResults
            // 
            this.listPingResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listPingResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPingResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPingResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listPingResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPingResults.ForeColor = System.Drawing.Color.White;
            this.listPingResults.FormattingEnabled = true;
            this.listPingResults.HorizontalScrollbar = true;
            this.listPingResults.ItemHeight = 21;
            this.listPingResults.Location = new System.Drawing.Point(0, 0);
            this.listPingResults.Margin = new System.Windows.Forms.Padding(2);
            this.listPingResults.Name = "listPingResults";
            this.listPingResults.Size = new System.Drawing.Size(542, 305);
            this.listPingResults.TabIndex = 79;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Silver;
            this.lblResults.Location = new System.Drawing.Point(21, 176);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(62, 21);
            this.lblResults.TabIndex = 60;
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
            this.btnShodan.Location = new System.Drawing.Point(101, 116);
            this.btnShodan.Margin = new System.Windows.Forms.Padding(2);
            this.btnShodan.Name = "btnShodan";
            this.btnShodan.Size = new System.Drawing.Size(160, 31);
            this.btnShodan.TabIndex = 59;
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
            this.btnPing.Location = new System.Drawing.Point(26, 116);
            this.btnPing.Margin = new System.Windows.Forms.Padding(2);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(71, 31);
            this.btnPing.TabIndex = 58;
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
            this.txtPingInput.Location = new System.Drawing.Point(26, 83);
            this.txtPingInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtPingInput.Name = "txtPingInput";
            this.txtPingInput.Size = new System.Drawing.Size(535, 29);
            this.txtPingInput.TabIndex = 56;
            this.txtPingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPingInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPingInput_KeyDown);
            // 
            // lblPinger
            // 
            this.lblPinger.AutoSize = true;
            this.lblPinger.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinger.ForeColor = System.Drawing.Color.Silver;
            this.lblPinger.Location = new System.Drawing.Point(23, 60);
            this.lblPinger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPinger.Name = "lblPinger";
            this.lblPinger.Size = new System.Drawing.Size(139, 21);
            this.lblPinger.TabIndex = 57;
            this.lblPinger.Tag = "";
            this.lblPinger.Text = "IP / Domain name";
            // 
            // pingerTitle
            // 
            this.pingerTitle.AutoSize = true;
            this.pingerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingerTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pingerTitle.Location = new System.Drawing.Point(6, 10);
            this.pingerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pingerTitle.Name = "pingerTitle";
            this.pingerTitle.Size = new System.Drawing.Size(393, 28);
            this.pingerTitle.TabIndex = 47;
            this.pingerTitle.Tag = "themeable";
            this.pingerTitle.Text = "Ping IP addresses and assess your latency";
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
            this.hostsEditorTab.Size = new System.Drawing.Size(999, 610);
            this.hostsEditorTab.TabIndex = 9;
            this.hostsEditorTab.Text = "Hosts";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lblAdblockSub);
            this.panel4.Controls.Add(this.linkAdvancedEdit);
            this.panel4.Controls.Add(this.lblAdblock);
            this.panel4.Controls.Add(this.linkRestoreDefault);
            this.panel4.Controls.Add(this.adblockUlti);
            this.panel4.Controls.Add(this.adblockP);
            this.panel4.Controls.Add(this.adblockS);
            this.panel4.Controls.Add(this.adblockBasic);
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
            this.panel4.Size = new System.Drawing.Size(987, 537);
            this.panel4.TabIndex = 53;
            // 
            // lblAdblockSub
            // 
            this.lblAdblockSub.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdblockSub.ForeColor = System.Drawing.Color.Silver;
            this.lblAdblockSub.Location = new System.Drawing.Point(325, 279);
            this.lblAdblockSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdblockSub.Name = "lblAdblockSub";
            this.lblAdblockSub.Size = new System.Drawing.Size(313, 25);
            this.lblAdblockSub.TabIndex = 68;
            this.lblAdblockSub.Tag = "";
            this.lblAdblockSub.Text = "(will delete your current config)";
            // 
            // linkAdvancedEdit
            // 
            this.linkAdvancedEdit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkAdvancedEdit.AutoSize = true;
            this.linkAdvancedEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdvancedEdit.ForeColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.LinkColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.Location = new System.Drawing.Point(1, 428);
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
            // lblAdblock
            // 
            this.lblAdblock.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdblock.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAdblock.Location = new System.Drawing.Point(322, 254);
            this.lblAdblock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdblock.Name = "lblAdblock";
            this.lblAdblock.Size = new System.Drawing.Size(281, 25);
            this.lblAdblock.TabIndex = 67;
            this.lblAdblock.Tag = "themeable";
            this.lblAdblock.Text = "Pre-made adblocks";
            // 
            // linkRestoreDefault
            // 
            this.linkRestoreDefault.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkRestoreDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRestoreDefault.ForeColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.Location = new System.Drawing.Point(0, 515);
            this.linkRestoreDefault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRestoreDefault.Name = "linkRestoreDefault";
            this.linkRestoreDefault.Size = new System.Drawing.Size(494, 21);
            this.linkRestoreDefault.TabIndex = 51;
            this.linkRestoreDefault.TabStop = true;
            this.linkRestoreDefault.Tag = "";
            this.linkRestoreDefault.Text = "Restore default";
            this.linkRestoreDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkRestoreDefault.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // adblockUlti
            // 
            this.adblockUlti.BackColor = System.Drawing.Color.DodgerBlue;
            this.adblockUlti.FlatAppearance.BorderSize = 0;
            this.adblockUlti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockUlti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockUlti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adblockUlti.ForeColor = System.Drawing.Color.White;
            this.adblockUlti.Location = new System.Drawing.Point(485, 351);
            this.adblockUlti.Margin = new System.Windows.Forms.Padding(2);
            this.adblockUlti.Name = "adblockUlti";
            this.adblockUlti.Size = new System.Drawing.Size(153, 31);
            this.adblockUlti.TabIndex = 66;
            this.adblockUlti.Text = "AdBlock Ultimate\r\n";
            this.adblockUlti.UseVisualStyleBackColor = false;
            this.adblockUlti.Click += new System.EventHandler(this.button4_Click);
            // 
            // adblockP
            // 
            this.adblockP.BackColor = System.Drawing.Color.DodgerBlue;
            this.adblockP.FlatAppearance.BorderSize = 0;
            this.adblockP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adblockP.ForeColor = System.Drawing.Color.White;
            this.adblockP.Location = new System.Drawing.Point(485, 316);
            this.adblockP.Margin = new System.Windows.Forms.Padding(2);
            this.adblockP.Name = "adblockP";
            this.adblockP.Size = new System.Drawing.Size(153, 31);
            this.adblockP.TabIndex = 65;
            this.adblockP.Text = "AdBlock + Porn";
            this.adblockP.UseVisualStyleBackColor = false;
            this.adblockP.Click += new System.EventHandler(this.button3_Click);
            // 
            // adblockS
            // 
            this.adblockS.BackColor = System.Drawing.Color.DodgerBlue;
            this.adblockS.FlatAppearance.BorderSize = 0;
            this.adblockS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adblockS.ForeColor = System.Drawing.Color.White;
            this.adblockS.Location = new System.Drawing.Point(327, 351);
            this.adblockS.Margin = new System.Windows.Forms.Padding(2);
            this.adblockS.Name = "adblockS";
            this.adblockS.Size = new System.Drawing.Size(153, 31);
            this.adblockS.TabIndex = 64;
            this.adblockS.Text = "AdBlock + Social";
            this.adblockS.UseVisualStyleBackColor = false;
            this.adblockS.Click += new System.EventHandler(this.button2_Click);
            // 
            // adblockBasic
            // 
            this.adblockBasic.BackColor = System.Drawing.Color.DodgerBlue;
            this.adblockBasic.FlatAppearance.BorderSize = 0;
            this.adblockBasic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockBasic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.adblockBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adblockBasic.ForeColor = System.Drawing.Color.White;
            this.adblockBasic.Location = new System.Drawing.Point(327, 316);
            this.adblockBasic.Margin = new System.Windows.Forms.Padding(2);
            this.adblockBasic.Name = "adblockBasic";
            this.adblockBasic.Size = new System.Drawing.Size(153, 31);
            this.adblockBasic.TabIndex = 63;
            this.adblockBasic.Text = "AdBlock Basic";
            this.adblockBasic.UseVisualStyleBackColor = false;
            this.adblockBasic.Click += new System.EventHandler(this.button1_Click);
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
            this.addHostB.Location = new System.Drawing.Point(551, 110);
            this.addHostB.Margin = new System.Windows.Forms.Padding(2);
            this.addHostB.Name = "addHostB";
            this.addHostB.Size = new System.Drawing.Size(87, 31);
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
            this.registryFixerTab.Size = new System.Drawing.Size(999, 610);
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
            this.regFixB.Size = new System.Drawing.Size(108, 31);
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
            this.indiciumTab.Size = new System.Drawing.Size(999, 610);
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
            this.panel12.Size = new System.Drawing.Size(993, 569);
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
            this.specsTree.Size = new System.Drawing.Size(991, 567);
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
            this.panel11.Controls.Add(this.btnSaveHW);
            this.panel11.Controls.Add(this.btnCopyHW);
            this.panel11.Controls.Add(this.hwDetailed);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(993, 35);
            this.panel11.TabIndex = 1;
            // 
            // btnSaveHW
            // 
            this.btnSaveHW.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveHW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHW.ForeColor = System.Drawing.Color.Silver;
            this.btnSaveHW.LinkColor = System.Drawing.Color.Silver;
            this.btnSaveHW.Location = new System.Drawing.Point(808, 4);
            this.btnSaveHW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSaveHW.Name = "btnSaveHW";
            this.btnSaveHW.Size = new System.Drawing.Size(180, 24);
            this.btnSaveHW.TabIndex = 93;
            this.btnSaveHW.TabStop = true;
            this.btnSaveHW.Tag = "themeable";
            this.btnSaveHW.Text = "Save";
            this.btnSaveHW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveHW.VisitedLinkColor = System.Drawing.Color.Silver;
            this.btnSaveHW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnSaveHW_LinkClicked);
            // 
            // btnCopyHW
            // 
            this.btnCopyHW.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopyHW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyHW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHW.ForeColor = System.Drawing.Color.Silver;
            this.btnCopyHW.LinkColor = System.Drawing.Color.Silver;
            this.btnCopyHW.Location = new System.Drawing.Point(624, 4);
            this.btnCopyHW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCopyHW.Name = "btnCopyHW";
            this.btnCopyHW.Size = new System.Drawing.Size(180, 24);
            this.btnCopyHW.TabIndex = 92;
            this.btnCopyHW.TabStop = true;
            this.btnCopyHW.Tag = "themeable";
            this.btnCopyHW.Text = "Copy";
            this.btnCopyHW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopyHW.VisitedLinkColor = System.Drawing.Color.Silver;
            this.btnCopyHW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCopyHW_LinkClicked);
            // 
            // hwDetailed
            // 
            this.hwDetailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hwDetailed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwDetailed.ForeColor = System.Drawing.Color.White;
            this.hwDetailed.LabelText = "Detailed View";
            this.hwDetailed.Location = new System.Drawing.Point(5, 4);
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
            this.integratorTab.Size = new System.Drawing.Size(999, 610);
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
            this.synapse.Size = new System.Drawing.Size(995, 606);
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
            this.integratorInfoTab.Size = new System.Drawing.Size(987, 577);
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
            this.tabPage8.Size = new System.Drawing.Size(987, 577);
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
            this.btnAddItem.Location = new System.Drawing.Point(465, 473);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(173, 31);
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
            this.tabPage9.Size = new System.Drawing.Size(987, 577);
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
            this.refreshIIB.Size = new System.Drawing.Size(137, 31);
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
            this.removeDIB.Size = new System.Drawing.Size(137, 31);
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
            this.removeAllIIB.Size = new System.Drawing.Size(137, 31);
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
            this.tabPage10.Controls.Add(this.DeleteCMDB);
            this.tabPage10.Controls.Add(this.AddCMDB);
            this.tabPage10.Controls.Add(this.RemoveOwnerB);
            this.tabPage10.Controls.Add(this.AddOwnerB);
            this.tabPage10.Controls.Add(this.readyMenusL);
            this.tabPage10.Controls.Add(this.PMB);
            this.tabPage10.Controls.Add(this.DSB);
            this.tabPage10.Controls.Add(this.STB);
            this.tabPage10.Controls.Add(this.SSB);
            this.tabPage10.Controls.Add(this.WAB);
            this.tabPage10.Location = new System.Drawing.Point(4, 4);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(987, 577);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "Ready Menus";
            // 
            // DeleteCMDB
            // 
            this.DeleteCMDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteCMDB.FlatAppearance.BorderSize = 0;
            this.DeleteCMDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteCMDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteCMDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCMDB.ForeColor = System.Drawing.Color.White;
            this.DeleteCMDB.Location = new System.Drawing.Point(11, 365);
            this.DeleteCMDB.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCMDB.Name = "DeleteCMDB";
            this.DeleteCMDB.Size = new System.Drawing.Size(334, 31);
            this.DeleteCMDB.TabIndex = 80;
            this.DeleteCMDB.Text = "Delete \"Open with CMD\"";
            this.DeleteCMDB.UseVisualStyleBackColor = false;
            this.DeleteCMDB.Click += new System.EventHandler(this.DeleteCMDB_Click);
            // 
            // AddCMDB
            // 
            this.AddCMDB.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddCMDB.FlatAppearance.BorderSize = 0;
            this.AddCMDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.AddCMDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.AddCMDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCMDB.ForeColor = System.Drawing.Color.White;
            this.AddCMDB.Location = new System.Drawing.Point(11, 329);
            this.AddCMDB.Margin = new System.Windows.Forms.Padding(2);
            this.AddCMDB.Name = "AddCMDB";
            this.AddCMDB.Size = new System.Drawing.Size(334, 31);
            this.AddCMDB.TabIndex = 79;
            this.AddCMDB.Text = "Add \"Open with CMD\"";
            this.AddCMDB.UseVisualStyleBackColor = false;
            this.AddCMDB.Click += new System.EventHandler(this.AddCMDB_Click);
            // 
            // RemoveOwnerB
            // 
            this.RemoveOwnerB.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveOwnerB.FlatAppearance.BorderSize = 0;
            this.RemoveOwnerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.RemoveOwnerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.RemoveOwnerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveOwnerB.ForeColor = System.Drawing.Color.White;
            this.RemoveOwnerB.Location = new System.Drawing.Point(11, 276);
            this.RemoveOwnerB.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveOwnerB.Name = "RemoveOwnerB";
            this.RemoveOwnerB.Size = new System.Drawing.Size(334, 31);
            this.RemoveOwnerB.TabIndex = 78;
            this.RemoveOwnerB.Text = "Delete \"Take Ownership\"";
            this.RemoveOwnerB.UseVisualStyleBackColor = false;
            this.RemoveOwnerB.Click += new System.EventHandler(this.button65_Click);
            // 
            // AddOwnerB
            // 
            this.AddOwnerB.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddOwnerB.FlatAppearance.BorderSize = 0;
            this.AddOwnerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.AddOwnerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.AddOwnerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOwnerB.ForeColor = System.Drawing.Color.White;
            this.AddOwnerB.Location = new System.Drawing.Point(11, 240);
            this.AddOwnerB.Margin = new System.Windows.Forms.Padding(2);
            this.AddOwnerB.Name = "AddOwnerB";
            this.AddOwnerB.Size = new System.Drawing.Size(334, 31);
            this.AddOwnerB.TabIndex = 77;
            this.AddOwnerB.Text = "Add \"Take Ownership\"";
            this.AddOwnerB.UseVisualStyleBackColor = false;
            this.AddOwnerB.Click += new System.EventHandler(this.button66_Click);
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
            // PMB
            // 
            this.PMB.BackColor = System.Drawing.Color.DodgerBlue;
            this.PMB.FlatAppearance.BorderSize = 0;
            this.PMB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.PMB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.PMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PMB.ForeColor = System.Drawing.Color.White;
            this.PMB.Location = new System.Drawing.Point(11, 48);
            this.PMB.Margin = new System.Windows.Forms.Padding(2);
            this.PMB.Name = "PMB";
            this.PMB.Size = new System.Drawing.Size(334, 31);
            this.PMB.TabIndex = 74;
            this.PMB.Text = "Add \"Power Menu\"";
            this.PMB.UseVisualStyleBackColor = false;
            this.PMB.Click += new System.EventHandler(this.button59_Click);
            // 
            // DSB
            // 
            this.DSB.BackColor = System.Drawing.Color.DodgerBlue;
            this.DSB.FlatAppearance.BorderSize = 0;
            this.DSB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.DSB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.DSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSB.ForeColor = System.Drawing.Color.White;
            this.DSB.Location = new System.Drawing.Point(11, 192);
            this.DSB.Margin = new System.Windows.Forms.Padding(2);
            this.DSB.Name = "DSB";
            this.DSB.Size = new System.Drawing.Size(334, 31);
            this.DSB.TabIndex = 72;
            this.DSB.Text = "Add \"Desktop Shortcuts\"";
            this.DSB.UseVisualStyleBackColor = false;
            this.DSB.Click += new System.EventHandler(this.button57_Click);
            // 
            // STB
            // 
            this.STB.BackColor = System.Drawing.Color.DodgerBlue;
            this.STB.FlatAppearance.BorderSize = 0;
            this.STB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.STB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.STB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STB.ForeColor = System.Drawing.Color.White;
            this.STB.Location = new System.Drawing.Point(11, 84);
            this.STB.Margin = new System.Windows.Forms.Padding(2);
            this.STB.Name = "STB";
            this.STB.Size = new System.Drawing.Size(334, 31);
            this.STB.TabIndex = 70;
            this.STB.Text = "Add \"System Tools\"";
            this.STB.UseVisualStyleBackColor = false;
            this.STB.Click += new System.EventHandler(this.button53_Click);
            // 
            // SSB
            // 
            this.SSB.BackColor = System.Drawing.Color.DodgerBlue;
            this.SSB.FlatAppearance.BorderSize = 0;
            this.SSB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SSB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.SSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSB.ForeColor = System.Drawing.Color.White;
            this.SSB.Location = new System.Drawing.Point(11, 156);
            this.SSB.Margin = new System.Windows.Forms.Padding(2);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(334, 31);
            this.SSB.TabIndex = 68;
            this.SSB.Text = "Add \"System Shortcuts\"";
            this.SSB.UseVisualStyleBackColor = false;
            this.SSB.Click += new System.EventHandler(this.button51_Click);
            // 
            // WAB
            // 
            this.WAB.BackColor = System.Drawing.Color.DodgerBlue;
            this.WAB.FlatAppearance.BorderSize = 0;
            this.WAB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.WAB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.WAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WAB.ForeColor = System.Drawing.Color.White;
            this.WAB.Location = new System.Drawing.Point(11, 120);
            this.WAB.Margin = new System.Windows.Forms.Padding(2);
            this.WAB.Name = "WAB";
            this.WAB.Size = new System.Drawing.Size(334, 31);
            this.WAB.TabIndex = 65;
            this.WAB.Text = "Add \"Windows Apps\"";
            this.WAB.UseVisualStyleBackColor = false;
            this.WAB.Click += new System.EventHandler(this.button54_Click);
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
            this.tabPage11.Size = new System.Drawing.Size(987, 577);
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
            this.removeCCB.Size = new System.Drawing.Size(120, 27);
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
            this.refreshCCB.Size = new System.Drawing.Size(120, 27);
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
            this.btnCreateCustomCommand.Size = new System.Drawing.Size(107, 29);
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
            this.button48.Location = new System.Drawing.Point(354, 75);
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
            this.txtRunFile.Size = new System.Drawing.Size(339, 29);
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
            this.optionsTab.Controls.Add(this.pictureBox14);
            this.optionsTab.Controls.Add(this.pictureBox13);
            this.optionsTab.Controls.Add(this.pictureBox12);
            this.optionsTab.Controls.Add(this.linkLabel1);
            this.optionsTab.Controls.Add(this.quickAccessToggle);
            this.optionsTab.Controls.Add(this.helpTipsToggle);
            this.optionsTab.Controls.Add(this.pictureBox85);
            this.optionsTab.Controls.Add(this.panel9);
            this.optionsTab.Controls.Add(this.panel8);
            this.optionsTab.Controls.Add(this.languagesL);
            this.optionsTab.Controls.Add(this.linkLabel5);
            this.optionsTab.Controls.Add(this.btnOpenConf);
            this.optionsTab.Controls.Add(this.lblTroubleshoot);
            this.optionsTab.Controls.Add(this.lblUpdating);
            this.optionsTab.Controls.Add(this.btnViewLog);
            this.optionsTab.Controls.Add(this.l2);
            this.optionsTab.Controls.Add(this.btnChangelog);
            this.optionsTab.Controls.Add(this.btnUpdate);
            this.optionsTab.Controls.Add(this.btnResetConfig);
            this.optionsTab.Controls.Add(this.lblTheming);
            this.optionsTab.Location = new System.Drawing.Point(4, 25);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(2);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(2);
            this.optionsTab.Size = new System.Drawing.Size(999, 610);
            this.optionsTab.TabIndex = 6;
            this.optionsTab.Text = "Options";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(957, 568);
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
            this.pictureBox13.Location = new System.Drawing.Point(957, 484);
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
            this.pictureBox12.Location = new System.Drawing.Point(957, 526);
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
            this.linkLabel1.Location = new System.Drawing.Point(795, 525);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 28);
            this.linkLabel1.TabIndex = 89;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "themeable";
            this.linkLabel1.Text = "Discord support";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // quickAccessToggle
            // 
            this.quickAccessToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.quickAccessToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessToggle.ForeColor = System.Drawing.Color.White;
            this.quickAccessToggle.LabelText = "Show Quick Access Menu";
            this.quickAccessToggle.Location = new System.Drawing.Point(21, 18);
            this.quickAccessToggle.Name = "quickAccessToggle";
            this.quickAccessToggle.Size = new System.Drawing.Size(374, 24);
            this.quickAccessToggle.TabIndex = 88;
            this.quickAccessToggle.Tag = "themeable";
            this.quickAccessToggle.ToggleChecked = false;
            this.quickAccessToggle.ToggleClicked += new System.EventHandler(this.quickAccessToggle_ToggleClicked);
            // 
            // helpTipsToggle
            // 
            this.helpTipsToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.helpTipsToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTipsToggle.ForeColor = System.Drawing.Color.White;
            this.helpTipsToggle.LabelText = "Show Help Messages";
            this.helpTipsToggle.Location = new System.Drawing.Point(21, 54);
            this.helpTipsToggle.Name = "helpTipsToggle";
            this.helpTipsToggle.Size = new System.Drawing.Size(374, 24);
            this.helpTipsToggle.TabIndex = 87;
            this.helpTipsToggle.Tag = "themeable";
            this.helpTipsToggle.ToggleChecked = false;
            this.helpTipsToggle.ToggleClicked += new System.EventHandler(this.helpTipsToggle_ToggleClicked);
            // 
            // pictureBox85
            // 
            this.pictureBox85.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox85.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox85.Image")));
            this.pictureBox85.Location = new System.Drawing.Point(958, 10);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(32, 32);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 74;
            this.pictureBox85.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.radioCzech);
            this.panel9.Controls.Add(this.pictureBox15);
            this.panel9.Controls.Add(this.radioChinese);
            this.panel9.Controls.Add(this.pictureBox7);
            this.panel9.Controls.Add(this.radioItalian);
            this.panel9.Controls.Add(this.pictureBox6);
            this.panel9.Controls.Add(this.radioFrench);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Controls.Add(this.radioPortuguese);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Controls.Add(this.radioSpanish);
            this.panel9.Controls.Add(this.pictureBox3);
            this.panel9.Controls.Add(this.radioGerman);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Controls.Add(this.pictureBox89);
            this.panel9.Controls.Add(this.radioTurkish);
            this.panel9.Controls.Add(this.pictureBox88);
            this.panel9.Controls.Add(this.radioHellenic);
            this.panel9.Controls.Add(this.pictureBox87);
            this.panel9.Controls.Add(this.radioEnglish);
            this.panel9.Controls.Add(this.radioRussian);
            this.panel9.Controls.Add(this.pictureBox86);
            this.panel9.Location = new System.Drawing.Point(711, 46);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 390);
            this.panel9.TabIndex = 73;
            // 
            // radioCzech
            // 
            this.radioCzech.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioCzech.AutoSize = true;
            this.radioCzech.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioCzech.ForeColor = System.Drawing.Color.White;
            this.radioCzech.Location = new System.Drawing.Point(157, 297);
            this.radioCzech.Margin = new System.Windows.Forms.Padding(2);
            this.radioCzech.Name = "radioCzech";
            this.radioCzech.Size = new System.Drawing.Size(81, 25);
            this.radioCzech.TabIndex = 104;
            this.radioCzech.Tag = "";
            this.radioCzech.Text = "Ceština";
            this.radioCzech.UseVisualStyleBackColor = true;
            this.radioCzech.Click += new System.EventHandler(this.radioCzech_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox15.Image = global::Optimizer.Properties.Resources.czech;
            this.pictureBox15.Location = new System.Drawing.Point(116, 298);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(36, 22);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 103;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // radioChinese
            // 
            this.radioChinese.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioChinese.AutoSize = true;
            this.radioChinese.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioChinese.ForeColor = System.Drawing.Color.White;
            this.radioChinese.Location = new System.Drawing.Point(157, 268);
            this.radioChinese.Margin = new System.Windows.Forms.Padding(2);
            this.radioChinese.Name = "radioChinese";
            this.radioChinese.Size = new System.Drawing.Size(96, 25);
            this.radioChinese.TabIndex = 102;
            this.radioChinese.Tag = "";
            this.radioChinese.Text = "简体中文";
            this.radioChinese.UseVisualStyleBackColor = true;
            this.radioChinese.Click += new System.EventHandler(this.radioChinese_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.Image = global::Optimizer.Properties.Resources.china;
            this.pictureBox7.Location = new System.Drawing.Point(116, 269);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 22);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 101;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // radioItalian
            // 
            this.radioItalian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioItalian.AutoSize = true;
            this.radioItalian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioItalian.ForeColor = System.Drawing.Color.White;
            this.radioItalian.Location = new System.Drawing.Point(157, 239);
            this.radioItalian.Margin = new System.Windows.Forms.Padding(2);
            this.radioItalian.Name = "radioItalian";
            this.radioItalian.Size = new System.Drawing.Size(82, 25);
            this.radioItalian.TabIndex = 90;
            this.radioItalian.Tag = "";
            this.radioItalian.Text = "Italiano";
            this.radioItalian.UseVisualStyleBackColor = true;
            this.radioItalian.Click += new System.EventHandler(this.radioItalian_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.Image = global::Optimizer.Properties.Resources.italy;
            this.pictureBox6.Location = new System.Drawing.Point(116, 240);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 89;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // radioFrench
            // 
            this.radioFrench.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioFrench.AutoSize = true;
            this.radioFrench.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioFrench.ForeColor = System.Drawing.Color.White;
            this.radioFrench.Location = new System.Drawing.Point(157, 210);
            this.radioFrench.Margin = new System.Windows.Forms.Padding(2);
            this.radioFrench.Name = "radioFrench";
            this.radioFrench.Size = new System.Drawing.Size(86, 25);
            this.radioFrench.TabIndex = 88;
            this.radioFrench.Tag = "";
            this.radioFrench.Text = "Français";
            this.radioFrench.UseVisualStyleBackColor = true;
            this.radioFrench.Click += new System.EventHandler(this.radioFrench_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Image = global::Optimizer.Properties.Resources.france;
            this.pictureBox5.Location = new System.Drawing.Point(116, 211);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // radioPortuguese
            // 
            this.radioPortuguese.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioPortuguese.AutoSize = true;
            this.radioPortuguese.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioPortuguese.ForeColor = System.Drawing.Color.White;
            this.radioPortuguese.Location = new System.Drawing.Point(157, 181);
            this.radioPortuguese.Margin = new System.Windows.Forms.Padding(2);
            this.radioPortuguese.Name = "radioPortuguese";
            this.radioPortuguese.Size = new System.Drawing.Size(102, 25);
            this.radioPortuguese.TabIndex = 86;
            this.radioPortuguese.Tag = "";
            this.radioPortuguese.Text = "Português";
            this.radioPortuguese.UseVisualStyleBackColor = true;
            this.radioPortuguese.Click += new System.EventHandler(this.radioPortuguese_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::Optimizer.Properties.Resources.brazil;
            this.pictureBox4.Location = new System.Drawing.Point(116, 182);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // radioSpanish
            // 
            this.radioSpanish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioSpanish.AutoSize = true;
            this.radioSpanish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioSpanish.ForeColor = System.Drawing.Color.White;
            this.radioSpanish.Location = new System.Drawing.Point(157, 153);
            this.radioSpanish.Margin = new System.Windows.Forms.Padding(2);
            this.radioSpanish.Name = "radioSpanish";
            this.radioSpanish.Size = new System.Drawing.Size(84, 25);
            this.radioSpanish.TabIndex = 84;
            this.radioSpanish.Tag = "";
            this.radioSpanish.Text = "Español";
            this.radioSpanish.UseVisualStyleBackColor = true;
            this.radioSpanish.Click += new System.EventHandler(this.radioSpanish_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::Optimizer.Properties.Resources.spain;
            this.pictureBox3.Location = new System.Drawing.Point(116, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // radioGerman
            // 
            this.radioGerman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioGerman.AutoSize = true;
            this.radioGerman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioGerman.ForeColor = System.Drawing.Color.White;
            this.radioGerman.Location = new System.Drawing.Point(157, 95);
            this.radioGerman.Margin = new System.Windows.Forms.Padding(2);
            this.radioGerman.Name = "radioGerman";
            this.radioGerman.Size = new System.Drawing.Size(87, 25);
            this.radioGerman.TabIndex = 82;
            this.radioGerman.Tag = "";
            this.radioGerman.Text = "Deutsch";
            this.radioGerman.UseVisualStyleBackColor = true;
            this.radioGerman.Click += new System.EventHandler(this.radioGerman_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Optimizer.Properties.Resources.germany;
            this.pictureBox2.Location = new System.Drawing.Point(116, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox89
            // 
            this.pictureBox89.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox89.Image = global::Optimizer.Properties.Resources.turkey;
            this.pictureBox89.Location = new System.Drawing.Point(116, 125);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(36, 22);
            this.pictureBox89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox89.TabIndex = 79;
            this.pictureBox89.TabStop = false;
            this.pictureBox89.Click += new System.EventHandler(this.pictureBox89_Click);
            // 
            // radioTurkish
            // 
            this.radioTurkish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioTurkish.AutoSize = true;
            this.radioTurkish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioTurkish.ForeColor = System.Drawing.Color.White;
            this.radioTurkish.Location = new System.Drawing.Point(157, 124);
            this.radioTurkish.Margin = new System.Windows.Forms.Padding(2);
            this.radioTurkish.Name = "radioTurkish";
            this.radioTurkish.Size = new System.Drawing.Size(76, 25);
            this.radioTurkish.TabIndex = 80;
            this.radioTurkish.Tag = "";
            this.radioTurkish.Text = "Türkçe";
            this.radioTurkish.UseVisualStyleBackColor = true;
            this.radioTurkish.Click += new System.EventHandler(this.radioTurkish_Click);
            // 
            // pictureBox88
            // 
            this.pictureBox88.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox88.Image = global::Optimizer.Properties.Resources.greece;
            this.pictureBox88.Location = new System.Drawing.Point(116, 67);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(36, 22);
            this.pictureBox88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox88.TabIndex = 77;
            this.pictureBox88.TabStop = false;
            this.pictureBox88.Click += new System.EventHandler(this.pictureBox88_Click);
            // 
            // radioHellenic
            // 
            this.radioHellenic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioHellenic.AutoSize = true;
            this.radioHellenic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioHellenic.ForeColor = System.Drawing.Color.White;
            this.radioHellenic.Location = new System.Drawing.Point(157, 66);
            this.radioHellenic.Margin = new System.Windows.Forms.Padding(2);
            this.radioHellenic.Name = "radioHellenic";
            this.radioHellenic.Size = new System.Drawing.Size(94, 25);
            this.radioHellenic.TabIndex = 78;
            this.radioHellenic.Tag = "";
            this.radioHellenic.Text = "Ελληνικά";
            this.radioHellenic.UseVisualStyleBackColor = true;
            this.radioHellenic.Click += new System.EventHandler(this.radioHellenic_Click);
            // 
            // pictureBox87
            // 
            this.pictureBox87.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox87.Image = global::Optimizer.Properties.Resources.russia;
            this.pictureBox87.Location = new System.Drawing.Point(116, 38);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(36, 22);
            this.pictureBox87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox87.TabIndex = 76;
            this.pictureBox87.TabStop = false;
            this.pictureBox87.Click += new System.EventHandler(this.pictureBox87_Click);
            // 
            // radioEnglish
            // 
            this.radioEnglish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnglish.ForeColor = System.Drawing.Color.White;
            this.radioEnglish.Location = new System.Drawing.Point(157, 8);
            this.radioEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(79, 25);
            this.radioEnglish.TabIndex = 75;
            this.radioEnglish.Tag = "";
            this.radioEnglish.Text = "English";
            this.radioEnglish.UseVisualStyleBackColor = true;
            this.radioEnglish.Click += new System.EventHandler(this.radioEnglish_Click);
            // 
            // radioRussian
            // 
            this.radioRussian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioRussian.AutoSize = true;
            this.radioRussian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioRussian.ForeColor = System.Drawing.Color.White;
            this.radioRussian.Location = new System.Drawing.Point(157, 37);
            this.radioRussian.Margin = new System.Windows.Forms.Padding(2);
            this.radioRussian.Name = "radioRussian";
            this.radioRussian.Size = new System.Drawing.Size(90, 25);
            this.radioRussian.TabIndex = 74;
            this.radioRussian.Tag = "";
            this.radioRussian.Text = "русский";
            this.radioRussian.UseVisualStyleBackColor = true;
            this.radioRussian.Click += new System.EventHandler(this.radioRussian_Click);
            // 
            // pictureBox86
            // 
            this.pictureBox86.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox86.Image = global::Optimizer.Properties.Resources.united_kingdom;
            this.pictureBox86.Location = new System.Drawing.Point(116, 9);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(36, 22);
            this.pictureBox86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox86.TabIndex = 75;
            this.pictureBox86.TabStop = false;
            this.pictureBox86.Click += new System.EventHandler(this.pictureBox86_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rAmber);
            this.panel8.Controls.Add(this.rAmethyst);
            this.panel8.Controls.Add(this.rAzurite);
            this.panel8.Controls.Add(this.rRuby);
            this.panel8.Controls.Add(this.rJade);
            this.panel8.Controls.Add(this.rSilver);
            this.panel8.Location = new System.Drawing.Point(21, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(326, 118);
            this.panel8.TabIndex = 72;
            // 
            // rAmber
            // 
            this.rAmber.AutoSize = true;
            this.rAmber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAmber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.rAmber.Location = new System.Drawing.Point(163, 11);
            this.rAmber.Margin = new System.Windows.Forms.Padding(2);
            this.rAmber.Name = "rAmber";
            this.rAmber.Size = new System.Drawing.Size(78, 25);
            this.rAmber.TabIndex = 52;
            this.rAmber.Text = "Amber";
            this.rAmber.UseVisualStyleBackColor = true;
            this.rAmber.CheckedChanged += new System.EventHandler(this.radioCaramel_CheckedChanged);
            // 
            // rAmethyst
            // 
            this.rAmethyst.AutoSize = true;
            this.rAmethyst.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAmethyst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.rAmethyst.Location = new System.Drawing.Point(15, 11);
            this.rAmethyst.Margin = new System.Windows.Forms.Padding(2);
            this.rAmethyst.Name = "rAmethyst";
            this.rAmethyst.Size = new System.Drawing.Size(98, 25);
            this.rAmethyst.TabIndex = 48;
            this.rAmethyst.Text = "Amethyst";
            this.rAmethyst.UseVisualStyleBackColor = true;
            this.rAmethyst.CheckedChanged += new System.EventHandler(this.radioZerg_CheckedChanged);
            // 
            // rAzurite
            // 
            this.rAzurite.AutoSize = true;
            this.rAzurite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.rAzurite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.rAzurite.Location = new System.Drawing.Point(15, 69);
            this.rAzurite.Margin = new System.Windows.Forms.Padding(2);
            this.rAzurite.Name = "rAzurite";
            this.rAzurite.Size = new System.Drawing.Size(80, 25);
            this.rAzurite.TabIndex = 49;
            this.rAzurite.Text = "Azurite";
            this.rAzurite.UseVisualStyleBackColor = true;
            this.rAzurite.CheckedChanged += new System.EventHandler(this.radioOcean_CheckedChanged);
            // 
            // rRuby
            // 
            this.rRuby.AutoSize = true;
            this.rRuby.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rRuby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.rRuby.Location = new System.Drawing.Point(15, 40);
            this.rRuby.Margin = new System.Windows.Forms.Padding(2);
            this.rRuby.Name = "rRuby";
            this.rRuby.Size = new System.Drawing.Size(65, 25);
            this.rRuby.TabIndex = 50;
            this.rRuby.Text = "Ruby";
            this.rRuby.UseVisualStyleBackColor = true;
            this.rRuby.CheckedChanged += new System.EventHandler(this.radioMagma_CheckedChanged);
            // 
            // rJade
            // 
            this.rJade.AutoSize = true;
            this.rJade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.rJade.Location = new System.Drawing.Point(163, 40);
            this.rJade.Margin = new System.Windows.Forms.Padding(2);
            this.rJade.Name = "rJade";
            this.rJade.Size = new System.Drawing.Size(61, 25);
            this.rJade.TabIndex = 51;
            this.rJade.Text = "Jade";
            this.rJade.UseVisualStyleBackColor = true;
            this.rJade.CheckedChanged += new System.EventHandler(this.radioLime_CheckedChanged);
            // 
            // rSilver
            // 
            this.rSilver.AutoSize = true;
            this.rSilver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rSilver.ForeColor = System.Drawing.Color.Gray;
            this.rSilver.Location = new System.Drawing.Point(163, 69);
            this.rSilver.Margin = new System.Windows.Forms.Padding(2);
            this.rSilver.Name = "rSilver";
            this.rSilver.Size = new System.Drawing.Size(68, 25);
            this.rSilver.TabIndex = 53;
            this.rSilver.Text = "Silver";
            this.rSilver.UseVisualStyleBackColor = true;
            this.rSilver.CheckedChanged += new System.EventHandler(this.radioMinimal_CheckedChanged);
            // 
            // languagesL
            // 
            this.languagesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.languagesL.Location = new System.Drawing.Point(711, 9);
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
            this.linkLabel5.Location = new System.Drawing.Point(754, 568);
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
            this.btnOpenConf.Location = new System.Drawing.Point(34, 471);
            this.btnOpenConf.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenConf.Name = "btnOpenConf";
            this.btnOpenConf.Size = new System.Drawing.Size(197, 31);
            this.btnOpenConf.TabIndex = 63;
            this.btnOpenConf.Text = "Show config folder";
            this.btnOpenConf.UseVisualStyleBackColor = false;
            this.btnOpenConf.Click += new System.EventHandler(this.btnOpenConf_Click);
            // 
            // lblTroubleshoot
            // 
            this.lblTroubleshoot.AutoSize = true;
            this.lblTroubleshoot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleshoot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTroubleshoot.Location = new System.Drawing.Point(17, 398);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(131, 21);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "themeable";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // lblUpdating
            // 
            this.lblUpdating.AutoSize = true;
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUpdating.Location = new System.Drawing.Point(17, 256);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(125, 21);
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
            this.btnViewLog.Location = new System.Drawing.Point(34, 436);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(197, 31);
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
            this.l2.Location = new System.Drawing.Point(795, 483);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(157, 28);
            this.l2.TabIndex = 59;
            this.l2.TabStop = true;
            this.l2.Tag = "themeable";
            this.l2.Text = "deadmoon © ∞";
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // btnChangelog
            // 
            this.btnChangelog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangelog.FlatAppearance.BorderSize = 0;
            this.btnChangelog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangelog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangelog.ForeColor = System.Drawing.Color.White;
            this.btnChangelog.Location = new System.Drawing.Point(34, 325);
            this.btnChangelog.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(197, 31);
            this.btnChangelog.TabIndex = 58;
            this.btnChangelog.Text = "View changes";
            this.btnChangelog.UseVisualStyleBackColor = false;
            this.btnChangelog.Click += new System.EventHandler(this.btnChangelog_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(34, 290);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 31);
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
            this.btnResetConfig.Location = new System.Drawing.Point(34, 506);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(197, 31);
            this.btnResetConfig.TabIndex = 56;
            this.btnResetConfig.Text = "Reset configuration";
            this.btnResetConfig.UseVisualStyleBackColor = false;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // lblTheming
            // 
            this.lblTheming.AutoSize = true;
            this.lblTheming.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheming.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTheming.Location = new System.Drawing.Point(17, 96);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(153, 21);
            this.lblTheming.TabIndex = 55;
            this.lblTheming.Tag = "themeable";
            this.lblTheming.Text = "Choose your theme";
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
            this.trayDownSpeed,
            this.trayUpSpeed,
            this.seperatorNetMon,
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
            this.toolStripSeparator2,
            this.trayExit});
            this.launcherMenu.Name = "launcherMenu";
            this.launcherMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.launcherMenu.Size = new System.Drawing.Size(221, 334);
            // 
            // trayDownSpeed
            // 
            this.trayDownSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayDownSpeed.ForeColor = System.Drawing.Color.White;
            this.trayDownSpeed.Image = ((System.Drawing.Image)(resources.GetObject("trayDownSpeed.Image")));
            this.trayDownSpeed.Name = "trayDownSpeed";
            this.trayDownSpeed.Size = new System.Drawing.Size(220, 26);
            this.trayDownSpeed.Text = "-";
            this.trayDownSpeed.Visible = false;
            // 
            // trayUpSpeed
            // 
            this.trayUpSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayUpSpeed.ForeColor = System.Drawing.Color.White;
            this.trayUpSpeed.Image = ((System.Drawing.Image)(resources.GetObject("trayUpSpeed.Image")));
            this.trayUpSpeed.Name = "trayUpSpeed";
            this.trayUpSpeed.Size = new System.Drawing.Size(220, 26);
            this.trayUpSpeed.Text = "-";
            this.trayUpSpeed.Visible = false;
            // 
            // seperatorNetMon
            // 
            this.seperatorNetMon.Name = "seperatorNetMon";
            this.seperatorNetMon.Size = new System.Drawing.Size(217, 6);
            this.seperatorNetMon.Visible = false;
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
            // helpBox
            // 
            this.helpBox.AutoPopDelay = 90000;
            this.helpBox.InitialDelay = 0;
            this.helpBox.OwnerDraw = true;
            this.helpBox.ReshowDelay = 0;
            this.helpBox.ShowAlways = true;
            this.helpBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpBox.UseAnimation = false;
            this.helpBox.UseFading = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1009, 705);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1025, 744);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bpanel.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.universalTab.ResumeLayout(false);
            this.windows10Tab.ResumeLayout(false);
            this.panelWin11Tweaks.ResumeLayout(false);
            this.windows8Tab.ResumeLayout(false);
            this.modernAppsTab.ResumeLayout(false);
            this.modernAppsTab.PerformLayout();
            this.panelModernAppsList.ResumeLayout(false);
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
            this.cleanerTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pingerTab.ResumeLayout(false);
            this.pingerTab.PerformLayout();
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
            this.optionsTab.ResumeLayout(false);
            this.optionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private MoonTabs tabCollection;
        private System.Windows.Forms.TabPage universalTab;
        private System.Windows.Forms.TabPage windows10Tab;
        private System.Windows.Forms.TabPage windows8Tab;
        private System.Windows.Forms.TabPage cleanerTab;
        private MoonCheck checkTemp;
        private MoonCheck checkSelectAll;
        private System.Windows.Forms.Button cleanDriveB;
        private MoonCheck checkBin;
        private MoonCheck checkMiniDumps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage startupTab;
        private System.Windows.Forms.Label startupTitle;
        private System.Windows.Forms.Button removeStartupItemB;
        private System.Windows.Forms.Label cleanerTitle;
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
        private MoonCheck checkErrorReports;
        private System.Windows.Forms.TabPage integratorTab;
        private MoonTabs synapse;
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
        private System.Windows.Forms.Button PMB;
        private System.Windows.Forms.Button DSB;
        private System.Windows.Forms.Button STB;
        private System.Windows.Forms.Button SSB;
        private System.Windows.Forms.Button WAB;
        private System.Windows.Forms.Label readyMenusL;
        private MoonList listDesktopItems;
        private System.Windows.Forms.Label removeIntegratorItemsL;
        private System.Windows.Forms.Button refreshIIB;
        private System.Windows.Forms.Button removeDIB;
        private System.Windows.Forms.Button removeAllIIB;
        private System.Windows.Forms.GroupBox itemtype;
        private MoonnRadio radioCommand;
        private MoonnRadio radioProgram;
        private MoonnRadio radioFile;
        private MoonnRadio radioFolder;
        private MoonnRadio radioLink;
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
        private MoonnRadio radioTop;
        private MoonnRadio radioMiddle;
        private MoonnRadio radioBottom;
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
        private System.Windows.Forms.Button RemoveOwnerB;
        private System.Windows.Forms.Button AddOwnerB;
        private System.Windows.Forms.TabPage optionsTab;
        private System.Windows.Forms.RadioButton rSilver;
        private System.Windows.Forms.RadioButton rAmber;
        private System.Windows.Forms.RadioButton rJade;
        private System.Windows.Forms.RadioButton rRuby;
        private System.Windows.Forms.RadioButton rAzurite;
        private System.Windows.Forms.RadioButton rAmethyst;
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
        private System.Windows.Forms.Panel panelModernAppsList;
        private MoonCheckList listModernApps;
        private System.Windows.Forms.Button uninstallModernAppsButton;
        private System.Windows.Forms.Button refreshModernAppsButton;
        private System.Windows.Forms.Label txtUWP;
        private MoonCheck chkSelectAllModernApps;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnChangelog;
        private MoonCheck chkReadOnly;
        private System.Windows.Forms.Label lblLock;
        private MoonCheck chkBlock;
        private System.Windows.Forms.Button adblockBasic;
        private System.Windows.Forms.Label lblAdblockSub;
        private System.Windows.Forms.Label lblAdblock;
        private System.Windows.Forms.Button adblockUlti;
        private System.Windows.Forms.Button adblockP;
        private System.Windows.Forms.Button adblockS;
        private System.Windows.Forms.TabPage appsTab;
        private System.Windows.Forms.Button btnDownloadApps;
        private System.Windows.Forms.Label appsTitle;
        private System.Windows.Forms.Label setDownDirLbl;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Button changeDownDirB;
        private System.Windows.Forms.Label txtDownloadStatus;
        private System.Windows.Forms.Label bitPref;
        private MoonnRadio c32;
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
        private System.Windows.Forms.Label pingerTitle;
        private System.Windows.Forms.TextBox txtPingInput;
        private System.Windows.Forms.Label lblPinger;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lblFootprint;
        private System.Windows.Forms.Label lblPretext;
        private System.Windows.Forms.Button btnShodan;
        private System.Windows.Forms.Label lblResults;
        private MoonList listPingResults;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button copyIPB;
        private System.Windows.Forms.Button copyB;
        private System.Windows.Forms.Button btnExport;
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
        private System.Windows.Forms.Button flushCacheB;
        private MoonnRadio c64;
        private System.Windows.Forms.Panel panel10;
        private Button backupStartupB;
        private Button restoreStartupB;
        private TextBox txtBackupTitle;
        private Label lblBackupTitle;
        private Button doBackup;
        private Button cancelBackup;
        private Label languagesL;
        private Panel panel8;
        private PictureBox pictureBox85;
        private Panel panel9;
        private PictureBox pictureBox87;
        private PictureBox pictureBox86;
        private MoonTip helpBox;
        private PictureBox pictureBox88;
        private MoonnRadio radioHellenic;
        private MoonnRadio radioEnglish;
        private MoonnRadio radioRussian;
        private PictureBox pictureBox89;
        private MoonnRadio radioTurkish;
        private Label txtNetFw;
        private Panel groupCoding;
        private Panel groupInternet;
        private Panel groupSoundVideo;
        private Label lblVideoSound;
        private Label lblCoding;
        private Label lblSystemTools;
        private Label lblInternet;
        private MoonnRadio radioGerman;
        private PictureBox pictureBox2;
        private MoonnRadio radioSpanish;
        private PictureBox pictureBox3;
        private MoonnRadio radioPortuguese;
        private PictureBox pictureBox4;
        private Label lblDNS;
        private LinkLabel txtIPv4;
        private LinkLabel txtIPv6A;
        private LinkLabel txtIPv6;
        private Label label3;
        private LinkLabel txtIPv4A;
        private Label label1;
        private Button btnOpenNetwork;
        private MoonnRadio radioFrench;
        private PictureBox pictureBox5;
        private Panel panelWin11Tweaks;
        private ToolStripMenuItem trayRegistry;
        private ToolStripMenuItem trayOptions;
        private Label txtFeedError;
        private MoonnRadio radioItalian;
        private PictureBox pictureBox6;
        private Button DeleteCMDB;
        private Button AddCMDB;
        private MoonnRadio radioChinese;
        private PictureBox pictureBox7;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private MoonCheck chromePws;
        private MoonCheck chromeSession;
        private MoonCheck chromeHistory;
        private MoonCheck chromeCookies;
        private MoonCheck chromeCache;
        private MoonCheck firefoxHistory;
        private MoonCheck firefoxCookies;
        private MoonCheck firefoxCache;
        private MoonCheck edgeSession;
        private MoonCheck edgeHistory;
        private MoonCheck edgeCookies;
        private MoonCheck edgeCache;
        private MoonCheck IECache;
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
        private ToggleCard actionSw;
        private ToggleCard xboxSw;
        private ToggleCard inkSw;
        private ToggleCard spellSw;
        private ToggleCard longPathsSw;
        private ToggleCard uODSw;
        private ToggleCard peopleSw;
        private ToggleCard oldExplorerSw;
        private ToggleCard adsSw;
        private ToggleCard featuresSw;
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
        private ToggleCard helpTipsToggle;
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
        private ToolStripMenuItem trayDownSpeed;
        private ToolStripSeparator seperatorNetMon;
        private ToolStripMenuItem trayUpSpeed;
        private LinkLabel btnSaveHW;
        private LinkLabel btnCopyHW;
        private ToggleCard vsSw;
        private ToggleCard chromeTelemetrySw;
        private ToggleCard ffTelemetrySw;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
        private PictureBox picLab;
        private MoonnRadio radioCzech;
        private PictureBox pictureBox15;
    }
}

