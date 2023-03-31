﻿using System.Windows.Forms;

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
            this.tabCollection = new System.Windows.Forms.TabControl();
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
            this.snapAssistSw = new Optimizer.ToggleCard();
            this.widgetsSw = new Optimizer.ToggleCard();
            this.leftTaskbarSw = new Optimizer.ToggleCard();
            this.classicContextSw = new Optimizer.ToggleCard();
            this.chatSw = new Optimizer.ToggleCard();
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
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.btnRestoreUwp = new Optimizer.Controls.MoonButton();
            this.panelUwp = new System.Windows.Forms.Panel();
            this.uninstallModernAppsButton = new Optimizer.Controls.MoonButton();
            this.refreshModernAppsButton = new Optimizer.Controls.MoonButton();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.chkOnlyRemovable = new Optimizer.MoonCheck();
            this.chkSelectAllModernApps = new Optimizer.MoonCheck();
            this.startupTab = new System.Windows.Forms.TabPage();
            this.cancelBackup = new Optimizer.Controls.MoonButton();
            this.doBackup = new Optimizer.Controls.MoonButton();
            this.txtBackupTitle = new System.Windows.Forms.TextBox();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.restoreStartupB = new Optimizer.Controls.MoonButton();
            this.backupStartupB = new Optimizer.Controls.MoonButton();
            this.findInRegB = new Optimizer.Controls.MoonButton();
            this.locateFileB = new Optimizer.Controls.MoonButton();
            this.refreshStartupB = new Optimizer.Controls.MoonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listStartupItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeStartupItemB = new Optimizer.Controls.MoonButton();
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
            this.btnGetFeed = new Optimizer.Controls.MoonButton();
            this.panelCommonApps = new System.Windows.Forms.Panel();
            this.cAutoInstall = new Optimizer.MoonCheck();
            this.progressDownloader = new Optimizer.MoonProgress();
            this.c64 = new Optimizer.MoonRadio();
            this.c32 = new Optimizer.MoonRadio();
            this.btnDownloadApps = new Optimizer.Controls.MoonButton();
            this.setDownDirLbl = new System.Windows.Forms.Label();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.changeDownDirB = new Optimizer.Controls.MoonButton();
            this.txtDownloadStatus = new System.Windows.Forms.Label();
            this.linkWarnings = new System.Windows.Forms.LinkLabel();
            this.bitPref = new System.Windows.Forms.Label();
            this.goToDownloadsB = new Optimizer.Controls.MoonButton();
            this.groupSystemTools = new System.Windows.Forms.Panel();
            this.cleanerTab = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.listCleanPreview = new Optimizer.MoonCheckList();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnWinClean = new Optimizer.Controls.MoonButton();
            this.analyzeDriveB = new Optimizer.Controls.MoonButton();
            this.checkSelectAll = new System.Windows.Forms.LinkLabel();
            this.lblPretext = new System.Windows.Forms.Label();
            this.cleanDriveB = new Optimizer.Controls.MoonButton();
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
            this.netTools = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExport = new Optimizer.Controls.MoonButton();
            this.copyB = new Optimizer.Controls.MoonButton();
            this.copyIPB = new Optimizer.Controls.MoonButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listPingResults = new Optimizer.MoonList();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnShodan = new Optimizer.Controls.MoonButton();
            this.btnPing = new Optimizer.Controls.MoonButton();
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
            this.btnOpenNetwork = new Optimizer.Controls.MoonButton();
            this.flushCacheB = new Optimizer.Controls.MoonButton();
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
            this.refreshHostsB = new Optimizer.Controls.MoonButton();
            this.removeHostB = new Optimizer.Controls.MoonButton();
            this.removeAllHostsB = new Optimizer.Controls.MoonButton();
            this.addHostB = new Optimizer.Controls.MoonButton();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.hostsTitle = new System.Windows.Forms.Label();
            this.linkLocate = new System.Windows.Forms.LinkLabel();
            this.registryFixerTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regFixB = new Optimizer.Controls.MoonButton();
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
            this.btnCopyHW = new Optimizer.Controls.MoonButton();
            this.btnSaveHW = new Optimizer.Controls.MoonButton();
            this.hwDetailed = new Optimizer.ToggleCard();
            this.integratorTab = new System.Windows.Forms.TabPage();
            this.synapse = new System.Windows.Forms.TabControl();
            this.integratorInfoTab = new System.Windows.Forms.TabPage();
            this.integrator7 = new System.Windows.Forms.Label();
            this.integrator6 = new System.Windows.Forms.Label();
            this.integrator5 = new System.Windows.Forms.Label();
            this.integrator4 = new System.Windows.Forms.Label();
            this.integrator3 = new System.Windows.Forms.Label();
            this.integrator2 = new System.Windows.Forms.Label();
            this.integrator1 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btnAddItem = new Optimizer.Controls.MoonButton();
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
            this.btnBrowseIcon = new Optimizer.Controls.MoonButton();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseItem = new Optimizer.Controls.MoonButton();
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
            this.refreshIIB = new Optimizer.Controls.MoonButton();
            this.removeDIB = new Optimizer.Controls.MoonButton();
            this.removeAllIIB = new Optimizer.Controls.MoonButton();
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
            this.removeCCB = new Optimizer.Controls.MoonButton();
            this.refreshCCB = new Optimizer.Controls.MoonButton();
            this.removeCCL = new System.Windows.Forms.Label();
            this.btnCreateCustomCommand = new Optimizer.Controls.MoonButton();
            this.button48 = new Optimizer.Controls.MoonButton();
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
            this.btnOpenConf = new Optimizer.Controls.MoonButton();
            this.lblTroubleshoot = new System.Windows.Forms.Label();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.btnViewLog = new Optimizer.Controls.MoonButton();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new Optimizer.Controls.MoonButton();
            this.btnResetConfig = new Optimizer.Controls.MoonButton();
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
            this.tpanel.Margin = new System.Windows.Forms.Padding(4);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(1968, 126);
            this.tpanel.TabIndex = 1;
            // 
            // restartAndApply
            // 
            this.restartAndApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartAndApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartAndApply.ForeColor = System.Drawing.Color.White;
            this.restartAndApply.Location = new System.Drawing.Point(1086, 24);
            this.restartAndApply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restartAndApply.Name = "restartAndApply";
            this.restartAndApply.Size = new System.Drawing.Size(788, 50);
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
            this.picRestartNeeded.Location = new System.Drawing.Point(1884, 22);
            this.picRestartNeeded.Margin = new System.Windows.Forms.Padding(6);
            this.picRestartNeeded.Name = "picRestartNeeded";
            this.picRestartNeeded.Size = new System.Drawing.Size(60, 60);
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
            this.picLab.Location = new System.Drawing.Point(1884, 22);
            this.picLab.Margin = new System.Windows.Forms.Padding(6);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(60, 60);
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
            this.picUpdate.Location = new System.Drawing.Point(1884, 22);
            this.picUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(60, 60);
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
            this.txtNetFw.Location = new System.Drawing.Point(376, 84);
            this.txtNetFw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNetFw.Name = "txtNetFw";
            this.txtNetFw.Size = new System.Drawing.Size(83, 36);
            this.txtNetFw.TabIndex = 70;
            this.txtNetFw.Text = "netfw";
            // 
            // txtBitness
            // 
            this.txtBitness.AutoSize = true;
            this.txtBitness.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitness.ForeColor = System.Drawing.Color.Silver;
            this.txtBitness.Location = new System.Drawing.Point(376, 46);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(98, 36);
            this.txtBitness.TabIndex = 4;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.AutoSize = true;
            this.txtOS.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.ForeColor = System.Drawing.Color.Silver;
            this.txtOS.Location = new System.Drawing.Point(376, 6);
            this.txtOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(42, 36);
            this.txtOS.TabIndex = 3;
            this.txtOS.Text = "os";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.Silver;
            this.txtVersion.Location = new System.Drawing.Point(140, 72);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(171, 36);
            this.txtVersion.TabIndex = 1;
            this.txtVersion.Text = "Version: {VN}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Optimizer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
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
            this.label2.Location = new System.Drawing.Point(134, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Optimizer";
            // 
            // bpanel
            // 
            this.bpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpanel.Controls.Add(this.tabCollection);
            this.bpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpanel.Location = new System.Drawing.Point(0, 126);
            this.bpanel.Margin = new System.Windows.Forms.Padding(4);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(1968, 1370);
            this.bpanel.TabIndex = 2;
            // 
            // tabCollection
            // 
            this.tabCollection.Controls.Add(this.universalTab);
            this.tabCollection.Controls.Add(this.windows10Tab);
            this.tabCollection.Controls.Add(this.windows8Tab);
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
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(4);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Drawing.Point(0, 0);
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(1966, 1368);
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
            this.universalTab.Location = new System.Drawing.Point(8, 55);
            this.universalTab.Margin = new System.Windows.Forms.Padding(4);
            this.universalTab.Name = "universalTab";
            this.universalTab.Padding = new System.Windows.Forms.Padding(4);
            this.universalTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.winSearchSw.Location = new System.Drawing.Point(42, 932);
            this.winSearchSw.Margin = new System.Windows.Forms.Padding(12);
            this.winSearchSw.Name = "winSearchSw";
            this.winSearchSw.Size = new System.Drawing.Size(828, 48);
            this.winSearchSw.TabIndex = 173;
            this.winSearchSw.Tag = "themeable";
            this.winSearchSw.ToggleChecked = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(920, 388);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 37);
            this.label13.TabIndex = 172;
            this.label13.Tag = "";
            this.label13.Text = "Privacy";
            // 
            // label4a
            // 
            this.label4a.AutoSize = true;
            this.label4a.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4a.ForeColor = System.Drawing.Color.Silver;
            this.label4a.Location = new System.Drawing.Point(920, 22);
            this.label4a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4a.Name = "label4a";
            this.label4a.Size = new System.Drawing.Size(79, 37);
            this.label4a.TabIndex = 171;
            this.label4a.Tag = "";
            this.label4a.Text = "Apps";
            // 
            // drives
            // 
            this.drives.AutoSize = true;
            this.drives.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drives.ForeColor = System.Drawing.Color.Silver;
            this.drives.Location = new System.Drawing.Point(34, 630);
            this.drives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drives.Name = "drives";
            this.drives.Size = new System.Drawing.Size(81, 37);
            this.drives.TabIndex = 170;
            this.drives.Tag = "";
            this.drives.Text = "Disks";
            // 
            // label14s
            // 
            this.label14s.AutoSize = true;
            this.label14s.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14s.ForeColor = System.Drawing.Color.Silver;
            this.label14s.Location = new System.Drawing.Point(34, 22);
            this.label14s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14s.Name = "label14s";
            this.label14s.Size = new System.Drawing.Size(105, 37);
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
            this.nvidiaTelemetrySw.Location = new System.Drawing.Point(928, 260);
            this.nvidiaTelemetrySw.Margin = new System.Windows.Forms.Padding(12);
            this.nvidiaTelemetrySw.Name = "nvidiaTelemetrySw";
            this.nvidiaTelemetrySw.Size = new System.Drawing.Size(980, 48);
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
            this.ntfsStampSw.Location = new System.Drawing.Point(40, 872);
            this.ntfsStampSw.Margin = new System.Windows.Forms.Padding(12);
            this.ntfsStampSw.Name = "ntfsStampSw";
            this.ntfsStampSw.Size = new System.Drawing.Size(828, 48);
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
            this.smb2Sw.Location = new System.Drawing.Point(928, 688);
            this.smb2Sw.Margin = new System.Windows.Forms.Padding(12);
            this.smb2Sw.Name = "smb2Sw";
            this.smb2Sw.Size = new System.Drawing.Size(828, 48);
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
            this.smb1Sw.Location = new System.Drawing.Point(928, 628);
            this.smb1Sw.Margin = new System.Windows.Forms.Padding(12);
            this.smb1Sw.Name = "smb1Sw";
            this.smb1Sw.Size = new System.Drawing.Size(828, 48);
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
            this.hibernateSw.Location = new System.Drawing.Point(40, 812);
            this.hibernateSw.Margin = new System.Windows.Forms.Padding(12);
            this.hibernateSw.Name = "hibernateSw";
            this.hibernateSw.Size = new System.Drawing.Size(828, 48);
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
            this.chromeTelemetrySw.Location = new System.Drawing.Point(928, 200);
            this.chromeTelemetrySw.Margin = new System.Windows.Forms.Padding(12);
            this.chromeTelemetrySw.Name = "chromeTelemetrySw";
            this.chromeTelemetrySw.Size = new System.Drawing.Size(980, 48);
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
            this.ffTelemetrySw.Location = new System.Drawing.Point(928, 140);
            this.ffTelemetrySw.Margin = new System.Windows.Forms.Padding(12);
            this.ffTelemetrySw.Name = "ffTelemetrySw";
            this.ffTelemetrySw.Size = new System.Drawing.Size(980, 48);
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
            this.vsSw.Location = new System.Drawing.Point(928, 320);
            this.vsSw.Margin = new System.Windows.Forms.Padding(12);
            this.vsSw.Name = "vsSw";
            this.vsSw.Size = new System.Drawing.Size(980, 48);
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
            this.reportingSw.Location = new System.Drawing.Point(40, 200);
            this.reportingSw.Margin = new System.Windows.Forms.Padding(12);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.Size = new System.Drawing.Size(828, 48);
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
            this.systemRestoreSw.Location = new System.Drawing.Point(40, 692);
            this.systemRestoreSw.Margin = new System.Windows.Forms.Padding(12);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.Size = new System.Drawing.Size(828, 48);
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
            this.officeTelemetrySw.Location = new System.Drawing.Point(926, 80);
            this.officeTelemetrySw.Margin = new System.Windows.Forms.Padding(12);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.Size = new System.Drawing.Size(980, 48);
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
            this.smartScreenSw.Location = new System.Drawing.Point(40, 500);
            this.smartScreenSw.Margin = new System.Windows.Forms.Padding(12);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.Size = new System.Drawing.Size(828, 48);
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
            this.networkSw.Location = new System.Drawing.Point(40, 140);
            this.networkSw.Margin = new System.Windows.Forms.Padding(12);
            this.networkSw.Name = "networkSw";
            this.networkSw.Size = new System.Drawing.Size(828, 48);
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
            this.telemetryTasksSw.Location = new System.Drawing.Point(928, 448);
            this.telemetryTasksSw.Margin = new System.Windows.Forms.Padding(12);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.Size = new System.Drawing.Size(828, 48);
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
            this.defenderSw.Location = new System.Drawing.Point(40, 560);
            this.defenderSw.Margin = new System.Windows.Forms.Padding(12);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.Size = new System.Drawing.Size(828, 48);
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
            this.homegroupSw.Location = new System.Drawing.Point(928, 568);
            this.homegroupSw.Margin = new System.Windows.Forms.Padding(12);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.Size = new System.Drawing.Size(828, 48);
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
            this.stickySw.Location = new System.Drawing.Point(40, 440);
            this.stickySw.Margin = new System.Windows.Forms.Padding(12);
            this.stickySw.Name = "stickySw";
            this.stickySw.Size = new System.Drawing.Size(828, 48);
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
            this.compatSw.Location = new System.Drawing.Point(40, 260);
            this.compatSw.Margin = new System.Windows.Forms.Padding(12);
            this.compatSw.Name = "compatSw";
            this.compatSw.Size = new System.Drawing.Size(828, 48);
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
            this.mediaSharingSw.Location = new System.Drawing.Point(928, 508);
            this.mediaSharingSw.Margin = new System.Windows.Forms.Padding(12);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.Size = new System.Drawing.Size(828, 48);
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
            this.printSw.Location = new System.Drawing.Point(40, 320);
            this.printSw.Margin = new System.Windows.Forms.Padding(12);
            this.printSw.Name = "printSw";
            this.printSw.Size = new System.Drawing.Size(828, 48);
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
            this.superfetchSw.Location = new System.Drawing.Point(40, 752);
            this.superfetchSw.Margin = new System.Windows.Forms.Padding(12);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.Size = new System.Drawing.Size(828, 48);
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
            this.faxSw.Location = new System.Drawing.Point(40, 380);
            this.faxSw.Margin = new System.Windows.Forms.Padding(12);
            this.faxSw.Name = "faxSw";
            this.faxSw.Size = new System.Drawing.Size(828, 48);
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
            this.performanceSw.Location = new System.Drawing.Point(40, 80);
            this.performanceSw.Margin = new System.Windows.Forms.Padding(12);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.Size = new System.Drawing.Size(828, 48);
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
            this.windows10Tab.Location = new System.Drawing.Point(8, 55);
            this.windows10Tab.Margin = new System.Windows.Forms.Padding(4);
            this.windows10Tab.Name = "windows10Tab";
            this.windows10Tab.Padding = new System.Windows.Forms.Padding(4);
            this.windows10Tab.Size = new System.Drawing.Size(1950, 1305);
            this.windows10Tab.TabIndex = 1;
            this.windows10Tab.Text = "Windows 10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(920, 592);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 37);
            this.label18.TabIndex = 176;
            this.label18.Tag = "";
            this.label18.Text = "Touch";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(920, 326);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 37);
            this.label17.TabIndex = 175;
            this.label17.Tag = "";
            this.label17.Text = "Gaming";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(920, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 37);
            this.label16.TabIndex = 174;
            this.label16.Tag = "";
            this.label16.Text = "Privacy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(36, 592);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 37);
            this.label15.TabIndex = 173;
            this.label15.Tag = "";
            this.label15.Text = "Windows Update";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(34, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 37);
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
            this.panelWin11Tweaks.Controls.Add(this.snapAssistSw);
            this.panelWin11Tweaks.Controls.Add(this.widgetsSw);
            this.panelWin11Tweaks.Controls.Add(this.leftTaskbarSw);
            this.panelWin11Tweaks.Controls.Add(this.classicContextSw);
            this.panelWin11Tweaks.Controls.Add(this.chatSw);
            this.panelWin11Tweaks.Location = new System.Drawing.Point(0, 900);
            this.panelWin11Tweaks.Margin = new System.Windows.Forms.Padding(6);
            this.panelWin11Tweaks.Name = "panelWin11Tweaks";
            this.panelWin11Tweaks.Size = new System.Drawing.Size(1942, 406);
            this.panelWin11Tweaks.TabIndex = 80;
            this.panelWin11Tweaks.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Silver;
            this.label20.Location = new System.Drawing.Point(920, 10);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 37);
            this.label20.TabIndex = 178;
            this.label20.Tag = "";
            this.label20.Text = "Extras";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(32, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 37);
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
            this.stickersSw.Location = new System.Drawing.Point(42, 252);
            this.stickersSw.Margin = new System.Windows.Forms.Padding(12);
            this.stickersSw.Name = "stickersSw";
            this.stickersSw.Size = new System.Drawing.Size(828, 48);
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
            this.compactModeSw.Location = new System.Drawing.Point(928, 252);
            this.compactModeSw.Margin = new System.Windows.Forms.Padding(12);
            this.compactModeSw.Name = "compactModeSw";
            this.compactModeSw.Size = new System.Drawing.Size(828, 48);
            this.compactModeSw.TabIndex = 112;
            this.compactModeSw.Tag = "themeable";
            this.compactModeSw.ToggleChecked = false;
            // 
            // snapAssistSw
            // 
            this.snapAssistSw.AccessibleName = "Disable Snap Assist";
            this.snapAssistSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.snapAssistSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snapAssistSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapAssistSw.ForeColor = System.Drawing.Color.White;
            this.snapAssistSw.LabelText = "Disable Snap Assist";
            this.snapAssistSw.Location = new System.Drawing.Point(928, 72);
            this.snapAssistSw.Margin = new System.Windows.Forms.Padding(12);
            this.snapAssistSw.Name = "snapAssistSw";
            this.snapAssistSw.Size = new System.Drawing.Size(828, 48);
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
            this.widgetsSw.Location = new System.Drawing.Point(42, 132);
            this.widgetsSw.Margin = new System.Windows.Forms.Padding(12);
            this.widgetsSw.Name = "widgetsSw";
            this.widgetsSw.Size = new System.Drawing.Size(828, 48);
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
            this.leftTaskbarSw.Location = new System.Drawing.Point(40, 72);
            this.leftTaskbarSw.Margin = new System.Windows.Forms.Padding(12);
            this.leftTaskbarSw.Name = "leftTaskbarSw";
            this.leftTaskbarSw.Size = new System.Drawing.Size(828, 48);
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
            this.classicContextSw.Location = new System.Drawing.Point(928, 192);
            this.classicContextSw.Margin = new System.Windows.Forms.Padding(12);
            this.classicContextSw.Name = "classicContextSw";
            this.classicContextSw.Size = new System.Drawing.Size(828, 48);
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
            this.chatSw.Location = new System.Drawing.Point(42, 192);
            this.chatSw.Margin = new System.Windows.Forms.Padding(12);
            this.chatSw.Name = "chatSw";
            this.chatSw.Size = new System.Drawing.Size(828, 48);
            this.chatSw.TabIndex = 107;
            this.chatSw.Tag = "themeable";
            this.chatSw.ToggleChecked = false;
            // 
            // vbsSw
            // 
            this.vbsSw.AccessibleName = "Disable Virtualization Based Security";
            this.vbsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vbsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vbsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbsSw.ForeColor = System.Drawing.Color.White;
            this.vbsSw.LabelText = "Disable Virtualization Based Security";
            this.vbsSw.Location = new System.Drawing.Point(42, 440);
            this.vbsSw.Margin = new System.Windows.Forms.Padding(12);
            this.vbsSw.Name = "vbsSw";
            this.vbsSw.Size = new System.Drawing.Size(828, 48);
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
            this.gameModeSw.Location = new System.Drawing.Point(928, 380);
            this.gameModeSw.Margin = new System.Windows.Forms.Padding(12);
            this.gameModeSw.Name = "gameModeSw";
            this.gameModeSw.Size = new System.Drawing.Size(828, 48);
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
            this.storeUpdatesSw.Location = new System.Drawing.Point(42, 714);
            this.storeUpdatesSw.Margin = new System.Windows.Forms.Padding(12);
            this.storeUpdatesSw.Name = "storeUpdatesSw";
            this.storeUpdatesSw.Size = new System.Drawing.Size(828, 48);
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
            this.oldMixerSw.Location = new System.Drawing.Point(42, 440);
            this.oldMixerSw.Margin = new System.Windows.Forms.Padding(12);
            this.oldMixerSw.Name = "oldMixerSw";
            this.oldMixerSw.Size = new System.Drawing.Size(828, 48);
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
            this.insiderSw.Location = new System.Drawing.Point(42, 774);
            this.insiderSw.Margin = new System.Windows.Forms.Padding(12);
            this.insiderSw.Name = "insiderSw";
            this.insiderSw.Size = new System.Drawing.Size(828, 48);
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
            this.castSw.Location = new System.Drawing.Point(42, 380);
            this.castSw.Margin = new System.Windows.Forms.Padding(12);
            this.castSw.Name = "castSw";
            this.castSw.Size = new System.Drawing.Size(828, 48);
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
            this.gameBarSw.Location = new System.Drawing.Point(928, 500);
            this.gameBarSw.Margin = new System.Windows.Forms.Padding(12);
            this.gameBarSw.Name = "gameBarSw";
            this.gameBarSw.Size = new System.Drawing.Size(828, 48);
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
            this.sensorSw.Location = new System.Drawing.Point(42, 320);
            this.sensorSw.Margin = new System.Windows.Forms.Padding(12);
            this.sensorSw.Name = "sensorSw";
            this.sensorSw.Size = new System.Drawing.Size(828, 48);
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
            this.ccSw.Location = new System.Drawing.Point(928, 774);
            this.ccSw.Margin = new System.Windows.Forms.Padding(12);
            this.ccSw.Name = "ccSw";
            this.ccSw.Size = new System.Drawing.Size(828, 48);
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
            this.cortanaSw.Location = new System.Drawing.Point(928, 140);
            this.cortanaSw.Margin = new System.Windows.Forms.Padding(12);
            this.cortanaSw.Name = "cortanaSw";
            this.cortanaSw.Size = new System.Drawing.Size(828, 48);
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
            this.privacySw.Location = new System.Drawing.Point(928, 200);
            this.privacySw.Margin = new System.Windows.Forms.Padding(12);
            this.privacySw.Name = "privacySw";
            this.privacySw.Size = new System.Drawing.Size(828, 48);
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
            this.driversSw.Location = new System.Drawing.Point(42, 834);
            this.driversSw.Margin = new System.Windows.Forms.Padding(12);
            this.driversSw.Name = "driversSw";
            this.driversSw.Size = new System.Drawing.Size(828, 48);
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
            this.telemetryServicesSw.Location = new System.Drawing.Point(928, 80);
            this.telemetryServicesSw.Margin = new System.Windows.Forms.Padding(12);
            this.telemetryServicesSw.Name = "telemetryServicesSw";
            this.telemetryServicesSw.Size = new System.Drawing.Size(828, 48);
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
            this.autoUpdatesSw.Location = new System.Drawing.Point(40, 654);
            this.autoUpdatesSw.Margin = new System.Windows.Forms.Padding(12);
            this.autoUpdatesSw.Name = "autoUpdatesSw";
            this.autoUpdatesSw.Size = new System.Drawing.Size(828, 48);
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
            this.tpmSw.Location = new System.Drawing.Point(42, 260);
            this.tpmSw.Margin = new System.Windows.Forms.Padding(12);
            this.tpmSw.Name = "tpmSw";
            this.tpmSw.Size = new System.Drawing.Size(828, 48);
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
            this.xboxSw.Location = new System.Drawing.Point(928, 440);
            this.xboxSw.Margin = new System.Windows.Forms.Padding(12);
            this.xboxSw.Name = "xboxSw";
            this.xboxSw.Size = new System.Drawing.Size(828, 48);
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
            this.inkSw.Location = new System.Drawing.Point(928, 654);
            this.inkSw.Margin = new System.Windows.Forms.Padding(12);
            this.inkSw.Name = "inkSw";
            this.inkSw.Size = new System.Drawing.Size(828, 48);
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
            this.spellSw.Location = new System.Drawing.Point(928, 714);
            this.spellSw.Margin = new System.Windows.Forms.Padding(12);
            this.spellSw.Name = "spellSw";
            this.spellSw.Size = new System.Drawing.Size(828, 48);
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
            this.longPathsSw.Location = new System.Drawing.Point(42, 200);
            this.longPathsSw.Margin = new System.Windows.Forms.Padding(12);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.Size = new System.Drawing.Size(828, 48);
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
            this.uODSw.Location = new System.Drawing.Point(44, 500);
            this.uODSw.Margin = new System.Windows.Forms.Padding(12);
            this.uODSw.Name = "uODSw";
            this.uODSw.Size = new System.Drawing.Size(828, 48);
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
            this.peopleSw.Location = new System.Drawing.Point(42, 140);
            this.peopleSw.Margin = new System.Windows.Forms.Padding(12);
            this.peopleSw.Name = "peopleSw";
            this.peopleSw.Size = new System.Drawing.Size(828, 48);
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
            this.oldExplorerSw.Location = new System.Drawing.Point(40, 80);
            this.oldExplorerSw.Margin = new System.Windows.Forms.Padding(12);
            this.oldExplorerSw.Name = "oldExplorerSw";
            this.oldExplorerSw.Size = new System.Drawing.Size(828, 48);
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
            this.adsSw.Location = new System.Drawing.Point(928, 260);
            this.adsSw.Margin = new System.Windows.Forms.Padding(12);
            this.adsSw.Name = "adsSw";
            this.adsSw.Size = new System.Drawing.Size(828, 48);
            this.adsSw.TabIndex = 82;
            this.adsSw.Tag = "themeable";
            this.adsSw.ToggleChecked = false;
            // 
            // windows8Tab
            // 
            this.windows8Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows8Tab.Controls.Add(this.label21);
            this.windows8Tab.Controls.Add(this.disableOneDriveSw);
            this.windows8Tab.Location = new System.Drawing.Point(8, 55);
            this.windows8Tab.Margin = new System.Windows.Forms.Padding(4);
            this.windows8Tab.Name = "windows8Tab";
            this.windows8Tab.Padding = new System.Windows.Forms.Padding(4);
            this.windows8Tab.Size = new System.Drawing.Size(1950, 1305);
            this.windows8Tab.TabIndex = 2;
            this.windows8Tab.Text = "Windows 8.1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(34, 22);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 37);
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
            this.disableOneDriveSw.Location = new System.Drawing.Point(40, 80);
            this.disableOneDriveSw.Margin = new System.Windows.Forms.Padding(12);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.Size = new System.Drawing.Size(1000, 48);
            this.disableOneDriveSw.TabIndex = 84;
            this.disableOneDriveSw.Tag = "themeable";
            this.disableOneDriveSw.ToggleChecked = false;
            // 
            // advancedTab
            // 
            this.advancedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.advancedTab.Location = new System.Drawing.Point(8, 55);
            this.advancedTab.Margin = new System.Windows.Forms.Padding(4);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(4);
            this.advancedTab.Size = new System.Drawing.Size(1950, 1305);
            this.advancedTab.TabIndex = 15;
            this.advancedTab.Text = "Advanced";
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
            this.modernAppsTab.Location = new System.Drawing.Point(8, 55);
            this.modernAppsTab.Margin = new System.Windows.Forms.Padding(6);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(6);
            this.modernAppsTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.btnRestoreUwp.Location = new System.Drawing.Point(22, 1088);
            this.btnRestoreUwp.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestoreUwp.Name = "btnRestoreUwp";
            this.btnRestoreUwp.Size = new System.Drawing.Size(598, 62);
            this.btnRestoreUwp.TabIndex = 55;
            this.btnRestoreUwp.Text = "Restore all UWP";
            this.btnRestoreUwp.UseVisualStyleBackColor = false;
            this.btnRestoreUwp.Click += new System.EventHandler(this.btnRestoreUwp_Click);
            // 
            // panelUwp
            // 
            this.panelUwp.AutoScroll = true;
            this.panelUwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUwp.Location = new System.Drawing.Point(22, 82);
            this.panelUwp.Margin = new System.Windows.Forms.Padding(6);
            this.panelUwp.Name = "panelUwp";
            this.panelUwp.Size = new System.Drawing.Size(1136, 994);
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
            this.uninstallModernAppsButton.Location = new System.Drawing.Point(1170, 152);
            this.uninstallModernAppsButton.Margin = new System.Windows.Forms.Padding(4);
            this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
            this.uninstallModernAppsButton.Size = new System.Drawing.Size(416, 62);
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
            this.refreshModernAppsButton.Location = new System.Drawing.Point(1170, 82);
            this.refreshModernAppsButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshModernAppsButton.Name = "refreshModernAppsButton";
            this.refreshModernAppsButton.Size = new System.Drawing.Size(416, 62);
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
            this.txtModernAppsTitle.Location = new System.Drawing.Point(12, 20);
            this.txtModernAppsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtModernAppsTitle.Name = "txtModernAppsTitle";
            this.txtModernAppsTitle.Size = new System.Drawing.Size(573, 54);
            this.txtModernAppsTitle.TabIndex = 47;
            this.txtModernAppsTitle.Tag = "themeable";
            this.txtModernAppsTitle.Text = "Uninstall unwanted UWP Apps";
            // 
            // chkOnlyRemovable
            // 
            this.chkOnlyRemovable.AutoSize = true;
            this.chkOnlyRemovable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.chkOnlyRemovable.ForeColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Location = new System.Drawing.Point(1170, 222);
            this.chkOnlyRemovable.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnlyRemovable.Name = "chkOnlyRemovable";
            this.chkOnlyRemovable.Size = new System.Drawing.Size(340, 49);
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
            this.chkSelectAllModernApps.Location = new System.Drawing.Point(1170, 280);
            this.chkSelectAllModernApps.Margin = new System.Windows.Forms.Padding(4);
            this.chkSelectAllModernApps.Name = "chkSelectAllModernApps";
            this.chkSelectAllModernApps.Size = new System.Drawing.Size(180, 49);
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
            this.startupTab.Location = new System.Drawing.Point(8, 55);
            this.startupTab.Margin = new System.Windows.Forms.Padding(4);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.cancelBackup.Location = new System.Drawing.Point(252, 1102);
            this.cancelBackup.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBackup.Name = "cancelBackup";
            this.cancelBackup.Size = new System.Drawing.Size(220, 60);
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
            this.doBackup.Location = new System.Drawing.Point(24, 1102);
            this.doBackup.Margin = new System.Windows.Forms.Padding(4);
            this.doBackup.Name = "doBackup";
            this.doBackup.Size = new System.Drawing.Size(220, 60);
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
            this.txtBackupTitle.Location = new System.Drawing.Point(24, 1044);
            this.txtBackupTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupTitle.Name = "txtBackupTitle";
            this.txtBackupTitle.Size = new System.Drawing.Size(644, 43);
            this.txtBackupTitle.TabIndex = 58;
            this.txtBackupTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBackupTitle.Visible = false;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblBackupTitle.Location = new System.Drawing.Point(16, 1002);
            this.lblBackupTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(168, 37);
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
            this.restoreStartupB.Location = new System.Drawing.Point(412, 1004);
            this.restoreStartupB.Margin = new System.Windows.Forms.Padding(4);
            this.restoreStartupB.Name = "restoreStartupB";
            this.restoreStartupB.Size = new System.Drawing.Size(380, 62);
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
            this.backupStartupB.Location = new System.Drawing.Point(24, 1004);
            this.backupStartupB.Margin = new System.Windows.Forms.Padding(4);
            this.backupStartupB.Name = "backupStartupB";
            this.backupStartupB.Size = new System.Drawing.Size(380, 62);
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
            this.findInRegB.Location = new System.Drawing.Point(1150, 1076);
            this.findInRegB.Margin = new System.Windows.Forms.Padding(4);
            this.findInRegB.Name = "findInRegB";
            this.findInRegB.Size = new System.Drawing.Size(380, 62);
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
            this.locateFileB.Location = new System.Drawing.Point(1538, 1006);
            this.locateFileB.Margin = new System.Windows.Forms.Padding(4);
            this.locateFileB.Name = "locateFileB";
            this.locateFileB.Size = new System.Drawing.Size(380, 62);
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
            this.refreshStartupB.Location = new System.Drawing.Point(1538, 1076);
            this.refreshStartupB.Margin = new System.Windows.Forms.Padding(4);
            this.refreshStartupB.Name = "refreshStartupB";
            this.refreshStartupB.Size = new System.Drawing.Size(380, 62);
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
            this.panel3.Location = new System.Drawing.Point(22, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1894, 916);
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
            this.listStartupItems.Margin = new System.Windows.Forms.Padding(4);
            this.listStartupItems.MultiSelect = false;
            this.listStartupItems.Name = "listStartupItems";
            this.listStartupItems.ShowGroups = false;
            this.listStartupItems.Size = new System.Drawing.Size(1892, 914);
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
            this.removeStartupItemB.Location = new System.Drawing.Point(1150, 1006);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(4);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(380, 62);
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
            this.startupTitle.Location = new System.Drawing.Point(12, 20);
            this.startupTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startupTitle.Name = "startupTitle";
            this.startupTitle.Size = new System.Drawing.Size(498, 54);
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
            this.appsTab.Location = new System.Drawing.Point(8, 55);
            this.appsTab.Margin = new System.Windows.Forms.Padding(6);
            this.appsTab.Name = "appsTab";
            this.appsTab.Padding = new System.Windows.Forms.Padding(6);
            this.appsTab.Size = new System.Drawing.Size(1950, 1305);
            this.appsTab.TabIndex = 12;
            this.appsTab.Text = "Apps";
            // 
            // txtFeedError
            // 
            this.txtFeedError.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedError.ForeColor = System.Drawing.Color.Gold;
            this.txtFeedError.Location = new System.Drawing.Point(6, 94);
            this.txtFeedError.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtFeedError.Name = "txtFeedError";
            this.txtFeedError.Size = new System.Drawing.Size(1938, 965);
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
            this.lblVideoSound.Location = new System.Drawing.Point(1492, 92);
            this.lblVideoSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideoSound.Name = "lblVideoSound";
            this.lblVideoSound.Size = new System.Drawing.Size(176, 32);
            this.lblVideoSound.TabIndex = 169;
            this.lblVideoSound.Tag = "";
            this.lblVideoSound.Text = "Video && Sound";
            // 
            // lblCoding
            // 
            this.lblCoding.AutoSize = true;
            this.lblCoding.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoding.ForeColor = System.Drawing.Color.Silver;
            this.lblCoding.Location = new System.Drawing.Point(1028, 92);
            this.lblCoding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Size = new System.Drawing.Size(91, 32);
            this.lblCoding.TabIndex = 168;
            this.lblCoding.Tag = "";
            this.lblCoding.Text = "Coding";
            // 
            // lblSystemTools
            // 
            this.lblSystemTools.AutoSize = true;
            this.lblSystemTools.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTools.ForeColor = System.Drawing.Color.Silver;
            this.lblSystemTools.Location = new System.Drawing.Point(22, 92);
            this.lblSystemTools.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemTools.Name = "lblSystemTools";
            this.lblSystemTools.Size = new System.Drawing.Size(177, 32);
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
            this.groupSoundVideo.Location = new System.Drawing.Point(1498, 128);
            this.groupSoundVideo.Margin = new System.Windows.Forms.Padding(6);
            this.groupSoundVideo.Name = "groupSoundVideo";
            this.groupSoundVideo.Size = new System.Drawing.Size(452, 928);
            this.groupSoundVideo.TabIndex = 166;
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternet.ForeColor = System.Drawing.Color.Silver;
            this.lblInternet.Location = new System.Drawing.Point(524, 92);
            this.lblInternet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(102, 32);
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
            this.groupCoding.Location = new System.Drawing.Point(1034, 128);
            this.groupCoding.Margin = new System.Windows.Forms.Padding(6);
            this.groupCoding.Name = "groupCoding";
            this.groupCoding.Size = new System.Drawing.Size(450, 928);
            this.groupCoding.TabIndex = 165;
            // 
            // groupInternet
            // 
            this.groupInternet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupInternet.AutoScroll = true;
            this.groupInternet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupInternet.Location = new System.Drawing.Point(530, 128);
            this.groupInternet.Margin = new System.Windows.Forms.Padding(6);
            this.groupInternet.Name = "groupInternet";
            this.groupInternet.Size = new System.Drawing.Size(490, 928);
            this.groupInternet.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(6, 6);
            this.panel10.Margin = new System.Windows.Forms.Padding(6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1938, 88);
            this.panel10.TabIndex = 163;
            // 
            // appsTitle
            // 
            this.appsTitle.AutoSize = true;
            this.appsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.appsTitle.Location = new System.Drawing.Point(10, 14);
            this.appsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appsTitle.Name = "appsTitle";
            this.appsTitle.Size = new System.Drawing.Size(719, 54);
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
            this.btnGetFeed.Location = new System.Drawing.Point(1526, 14);
            this.btnGetFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFeed.Name = "btnGetFeed";
            this.btnGetFeed.Size = new System.Drawing.Size(402, 64);
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
            this.panelCommonApps.Location = new System.Drawing.Point(6, 1059);
            this.panelCommonApps.Margin = new System.Windows.Forms.Padding(6);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(1938, 240);
            this.panelCommonApps.TabIndex = 162;
            // 
            // cAutoInstall
            // 
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cAutoInstall.Location = new System.Drawing.Point(1116, 106);
            this.cAutoInstall.Margin = new System.Windows.Forms.Padding(6);
            this.cAutoInstall.Name = "cAutoInstall";
            this.cAutoInstall.Size = new System.Drawing.Size(738, 48);
            this.cAutoInstall.TabIndex = 107;
            this.cAutoInstall.Text = "Install after downloading";
            this.cAutoInstall.UseVisualStyleBackColor = true;
            // 
            // progressDownloader
            // 
            this.progressDownloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressDownloader.Location = new System.Drawing.Point(16, 166);
            this.progressDownloader.Margin = new System.Windows.Forms.Padding(6);
            this.progressDownloader.MarqueeAnimationSpeed = 15;
            this.progressDownloader.Name = "progressDownloader";
            this.progressDownloader.Size = new System.Drawing.Size(604, 20);
            this.progressDownloader.TabIndex = 160;
            // 
            // c64
            // 
            this.c64.AutoSize = true;
            this.c64.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c64.Location = new System.Drawing.Point(746, 56);
            this.c64.Margin = new System.Windows.Forms.Padding(6);
            this.c64.Name = "c64";
            this.c64.Size = new System.Drawing.Size(139, 49);
            this.c64.TabIndex = 75;
            this.c64.TabStop = true;
            this.c64.Text = "64-bit";
            this.c64.UseVisualStyleBackColor = true;
            // 
            // c32
            // 
            this.c32.AutoSize = true;
            this.c32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c32.Location = new System.Drawing.Point(896, 56);
            this.c32.Margin = new System.Windows.Forms.Padding(6);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(139, 49);
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
            this.btnDownloadApps.Location = new System.Drawing.Point(1530, 164);
            this.btnDownloadApps.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadApps.Name = "btnDownloadApps";
            this.btnDownloadApps.Size = new System.Drawing.Size(406, 70);
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
            this.setDownDirLbl.Location = new System.Drawing.Point(6, 8);
            this.setDownDirLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setDownDirLbl.Name = "setDownDirLbl";
            this.setDownDirLbl.Size = new System.Drawing.Size(314, 45);
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
            this.txtDownloadFolder.Location = new System.Drawing.Point(16, 60);
            this.txtDownloadFolder.Margin = new System.Windows.Forms.Padding(6);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(602, 39);
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
            this.changeDownDirB.Location = new System.Drawing.Point(626, 60);
            this.changeDownDirB.Margin = new System.Windows.Forms.Padding(4);
            this.changeDownDirB.Name = "changeDownDirB";
            this.changeDownDirB.Size = new System.Drawing.Size(60, 46);
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
            this.txtDownloadStatus.Location = new System.Drawing.Point(8, 116);
            this.txtDownloadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDownloadStatus.Name = "txtDownloadStatus";
            this.txtDownloadStatus.Size = new System.Drawing.Size(62, 37);
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
            this.linkWarnings.Location = new System.Drawing.Point(8, 196);
            this.linkWarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkWarnings.Name = "linkWarnings";
            this.linkWarnings.Size = new System.Drawing.Size(178, 37);
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
            this.bitPref.Location = new System.Drawing.Point(736, 10);
            this.bitPref.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bitPref.Name = "bitPref";
            this.bitPref.Size = new System.Drawing.Size(279, 45);
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
            this.goToDownloadsB.Location = new System.Drawing.Point(1116, 164);
            this.goToDownloadsB.Margin = new System.Windows.Forms.Padding(4);
            this.goToDownloadsB.Name = "goToDownloadsB";
            this.goToDownloadsB.Size = new System.Drawing.Size(406, 70);
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
            this.groupSystemTools.Location = new System.Drawing.Point(26, 128);
            this.groupSystemTools.Margin = new System.Windows.Forms.Padding(6);
            this.groupSystemTools.Name = "groupSystemTools";
            this.groupSystemTools.Size = new System.Drawing.Size(490, 1046);
            this.groupSystemTools.TabIndex = 162;
            // 
            // cleanerTab
            // 
            this.cleanerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cleanerTab.Controls.Add(this.panel14);
            this.cleanerTab.Controls.Add(this.panel13);
            this.cleanerTab.Controls.Add(this.panel1);
            this.cleanerTab.Location = new System.Drawing.Point(8, 55);
            this.cleanerTab.Margin = new System.Windows.Forms.Padding(4);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(4);
            this.cleanerTab.Size = new System.Drawing.Size(1950, 1305);
            this.cleanerTab.TabIndex = 5;
            this.cleanerTab.Text = "Cleaner";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.listCleanPreview);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(440, 4);
            this.panel14.Margin = new System.Windows.Forms.Padding(6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1506, 1177);
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
            this.listCleanPreview.Margin = new System.Windows.Forms.Padding(6);
            this.listCleanPreview.Name = "listCleanPreview";
            this.listCleanPreview.Size = new System.Drawing.Size(1504, 1175);
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
            this.panel13.Location = new System.Drawing.Point(440, 1181);
            this.panel13.Margin = new System.Windows.Forms.Padding(6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1506, 120);
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
            this.btnWinClean.Location = new System.Drawing.Point(640, 46);
            this.btnWinClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnWinClean.Name = "btnWinClean";
            this.btnWinClean.Size = new System.Drawing.Size(280, 62);
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
            this.analyzeDriveB.Location = new System.Drawing.Point(928, 46);
            this.analyzeDriveB.Margin = new System.Windows.Forms.Padding(4);
            this.analyzeDriveB.Name = "analyzeDriveB";
            this.analyzeDriveB.Size = new System.Drawing.Size(280, 62);
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
            this.checkSelectAll.Location = new System.Drawing.Point(1002, 2);
            this.checkSelectAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkSelectAll.Name = "checkSelectAll";
            this.checkSelectAll.Size = new System.Drawing.Size(494, 40);
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
            this.lblPretext.Location = new System.Drawing.Point(4, 8);
            this.lblPretext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPretext.Name = "lblPretext";
            this.lblPretext.Size = new System.Drawing.Size(398, 45);
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
            this.cleanDriveB.Location = new System.Drawing.Point(1216, 46);
            this.cleanDriveB.Margin = new System.Windows.Forms.Padding(4);
            this.cleanDriveB.Name = "cleanDriveB";
            this.cleanDriveB.Size = new System.Drawing.Size(280, 62);
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
            this.lblFootprint.Location = new System.Drawing.Point(2, 52);
            this.lblFootprint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFootprint.Name = "lblFootprint";
            this.lblFootprint.Size = new System.Drawing.Size(394, 62);
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
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 1297);
            this.panel1.TabIndex = 47;
            // 
            // bravePasswords
            // 
            this.bravePasswords.AutoSize = true;
            this.bravePasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bravePasswords.ForeColor = System.Drawing.Color.White;
            this.bravePasswords.Location = new System.Drawing.Point(18, 1352);
            this.bravePasswords.Margin = new System.Windows.Forms.Padding(4);
            this.bravePasswords.Name = "bravePasswords";
            this.bravePasswords.Size = new System.Drawing.Size(176, 41);
            this.bravePasswords.TabIndex = 78;
            this.bravePasswords.Text = "Passwords";
            this.bravePasswords.UseVisualStyleBackColor = true;
            // 
            // braveSession
            // 
            this.braveSession.AutoSize = true;
            this.braveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveSession.ForeColor = System.Drawing.Color.White;
            this.braveSession.Location = new System.Drawing.Point(18, 1298);
            this.braveSession.Margin = new System.Windows.Forms.Padding(4);
            this.braveSession.Name = "braveSession";
            this.braveSession.Size = new System.Drawing.Size(141, 41);
            this.braveSession.TabIndex = 77;
            this.braveSession.Text = "Session";
            this.braveSession.UseVisualStyleBackColor = true;
            // 
            // braveHistory
            // 
            this.braveHistory.AutoSize = true;
            this.braveHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveHistory.ForeColor = System.Drawing.Color.White;
            this.braveHistory.Location = new System.Drawing.Point(18, 1244);
            this.braveHistory.Margin = new System.Windows.Forms.Padding(4);
            this.braveHistory.Name = "braveHistory";
            this.braveHistory.Size = new System.Drawing.Size(139, 41);
            this.braveHistory.TabIndex = 76;
            this.braveHistory.Text = "History";
            this.braveHistory.UseVisualStyleBackColor = true;
            // 
            // braveCookies
            // 
            this.braveCookies.AutoSize = true;
            this.braveCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCookies.ForeColor = System.Drawing.Color.White;
            this.braveCookies.Location = new System.Drawing.Point(18, 1190);
            this.braveCookies.Margin = new System.Windows.Forms.Padding(4);
            this.braveCookies.Name = "braveCookies";
            this.braveCookies.Size = new System.Drawing.Size(145, 41);
            this.braveCookies.TabIndex = 75;
            this.braveCookies.Text = "Cookies";
            this.braveCookies.UseVisualStyleBackColor = true;
            // 
            // braveCache
            // 
            this.braveCache.AutoSize = true;
            this.braveCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCache.ForeColor = System.Drawing.Color.White;
            this.braveCache.Location = new System.Drawing.Point(18, 1136);
            this.braveCache.Margin = new System.Windows.Forms.Padding(4);
            this.braveCache.Name = "braveCache";
            this.braveCache.Size = new System.Drawing.Size(123, 41);
            this.braveCache.TabIndex = 74;
            this.braveCache.Text = "Cache";
            this.braveCache.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(60, 1086);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 41);
            this.label9.TabIndex = 73;
            this.label9.Tag = "";
            this.label9.Text = "Brave Browser";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 1084);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(64, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 41);
            this.label8.TabIndex = 71;
            this.label8.Tag = "";
            this.label8.Text = "Windows";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // edgeSession
            // 
            this.edgeSession.AutoSize = true;
            this.edgeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeSession.ForeColor = System.Drawing.Color.White;
            this.edgeSession.Location = new System.Drawing.Point(18, 1032);
            this.edgeSession.Margin = new System.Windows.Forms.Padding(4);
            this.edgeSession.Name = "edgeSession";
            this.edgeSession.Size = new System.Drawing.Size(141, 41);
            this.edgeSession.TabIndex = 69;
            this.edgeSession.Text = "Session";
            this.edgeSession.UseVisualStyleBackColor = true;
            // 
            // edgeHistory
            // 
            this.edgeHistory.AutoSize = true;
            this.edgeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeHistory.ForeColor = System.Drawing.Color.White;
            this.edgeHistory.Location = new System.Drawing.Point(18, 978);
            this.edgeHistory.Margin = new System.Windows.Forms.Padding(4);
            this.edgeHistory.Name = "edgeHistory";
            this.edgeHistory.Size = new System.Drawing.Size(139, 41);
            this.edgeHistory.TabIndex = 68;
            this.edgeHistory.Text = "History";
            this.edgeHistory.UseVisualStyleBackColor = true;
            // 
            // edgeCookies
            // 
            this.edgeCookies.AutoSize = true;
            this.edgeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCookies.ForeColor = System.Drawing.Color.White;
            this.edgeCookies.Location = new System.Drawing.Point(18, 924);
            this.edgeCookies.Margin = new System.Windows.Forms.Padding(4);
            this.edgeCookies.Name = "edgeCookies";
            this.edgeCookies.Size = new System.Drawing.Size(145, 41);
            this.edgeCookies.TabIndex = 67;
            this.edgeCookies.Text = "Cookies";
            this.edgeCookies.UseVisualStyleBackColor = true;
            // 
            // edgeCache
            // 
            this.edgeCache.AutoSize = true;
            this.edgeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCache.ForeColor = System.Drawing.Color.White;
            this.edgeCache.Location = new System.Drawing.Point(18, 870);
            this.edgeCache.Margin = new System.Windows.Forms.Padding(4);
            this.edgeCache.Name = "edgeCache";
            this.edgeCache.Size = new System.Drawing.Size(123, 41);
            this.edgeCache.TabIndex = 66;
            this.edgeCache.Text = "Cache";
            this.edgeCache.UseVisualStyleBackColor = true;
            // 
            // IECache
            // 
            this.IECache.AutoSize = true;
            this.IECache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IECache.ForeColor = System.Drawing.Color.White;
            this.IECache.Location = new System.Drawing.Point(20, 1450);
            this.IECache.Margin = new System.Windows.Forms.Padding(4);
            this.IECache.Name = "IECache";
            this.IECache.Size = new System.Drawing.Size(123, 41);
            this.IECache.TabIndex = 65;
            this.IECache.Text = "Cache";
            this.IECache.UseVisualStyleBackColor = true;
            // 
            // firefoxHistory
            // 
            this.firefoxHistory.AutoSize = true;
            this.firefoxHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxHistory.ForeColor = System.Drawing.Color.White;
            this.firefoxHistory.Location = new System.Drawing.Point(18, 768);
            this.firefoxHistory.Margin = new System.Windows.Forms.Padding(4);
            this.firefoxHistory.Name = "firefoxHistory";
            this.firefoxHistory.Size = new System.Drawing.Size(139, 41);
            this.firefoxHistory.TabIndex = 64;
            this.firefoxHistory.Text = "History";
            this.firefoxHistory.UseVisualStyleBackColor = true;
            // 
            // firefoxCookies
            // 
            this.firefoxCookies.AutoSize = true;
            this.firefoxCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCookies.ForeColor = System.Drawing.Color.White;
            this.firefoxCookies.Location = new System.Drawing.Point(18, 714);
            this.firefoxCookies.Margin = new System.Windows.Forms.Padding(4);
            this.firefoxCookies.Name = "firefoxCookies";
            this.firefoxCookies.Size = new System.Drawing.Size(145, 41);
            this.firefoxCookies.TabIndex = 63;
            this.firefoxCookies.Text = "Cookies";
            this.firefoxCookies.UseVisualStyleBackColor = true;
            // 
            // firefoxCache
            // 
            this.firefoxCache.AutoSize = true;
            this.firefoxCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCache.ForeColor = System.Drawing.Color.White;
            this.firefoxCache.Location = new System.Drawing.Point(18, 660);
            this.firefoxCache.Margin = new System.Windows.Forms.Padding(4);
            this.firefoxCache.Name = "firefoxCache";
            this.firefoxCache.Size = new System.Drawing.Size(123, 41);
            this.firefoxCache.TabIndex = 62;
            this.firefoxCache.Text = "Cache";
            this.firefoxCache.UseVisualStyleBackColor = true;
            // 
            // chromePws
            // 
            this.chromePws.AutoSize = true;
            this.chromePws.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromePws.ForeColor = System.Drawing.Color.White;
            this.chromePws.Location = new System.Drawing.Point(16, 556);
            this.chromePws.Margin = new System.Windows.Forms.Padding(4);
            this.chromePws.Name = "chromePws";
            this.chromePws.Size = new System.Drawing.Size(176, 41);
            this.chromePws.TabIndex = 61;
            this.chromePws.Text = "Passwords";
            this.chromePws.UseVisualStyleBackColor = true;
            // 
            // chromeSession
            // 
            this.chromeSession.AutoSize = true;
            this.chromeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeSession.ForeColor = System.Drawing.Color.White;
            this.chromeSession.Location = new System.Drawing.Point(16, 502);
            this.chromeSession.Margin = new System.Windows.Forms.Padding(4);
            this.chromeSession.Name = "chromeSession";
            this.chromeSession.Size = new System.Drawing.Size(141, 41);
            this.chromeSession.TabIndex = 60;
            this.chromeSession.Text = "Session";
            this.chromeSession.UseVisualStyleBackColor = true;
            // 
            // chromeHistory
            // 
            this.chromeHistory.AutoSize = true;
            this.chromeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeHistory.ForeColor = System.Drawing.Color.White;
            this.chromeHistory.Location = new System.Drawing.Point(16, 448);
            this.chromeHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chromeHistory.Name = "chromeHistory";
            this.chromeHistory.Size = new System.Drawing.Size(139, 41);
            this.chromeHistory.TabIndex = 59;
            this.chromeHistory.Text = "History";
            this.chromeHistory.UseVisualStyleBackColor = true;
            // 
            // chromeCookies
            // 
            this.chromeCookies.AutoSize = true;
            this.chromeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCookies.ForeColor = System.Drawing.Color.White;
            this.chromeCookies.Location = new System.Drawing.Point(16, 394);
            this.chromeCookies.Margin = new System.Windows.Forms.Padding(4);
            this.chromeCookies.Name = "chromeCookies";
            this.chromeCookies.Size = new System.Drawing.Size(145, 41);
            this.chromeCookies.TabIndex = 58;
            this.chromeCookies.Text = "Cookies";
            this.chromeCookies.UseVisualStyleBackColor = true;
            // 
            // chromeCache
            // 
            this.chromeCache.AutoSize = true;
            this.chromeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCache.ForeColor = System.Drawing.Color.White;
            this.chromeCache.Location = new System.Drawing.Point(16, 340);
            this.chromeCache.Margin = new System.Windows.Forms.Padding(4);
            this.chromeCache.Name = "chromeCache";
            this.chromeCache.Size = new System.Drawing.Size(123, 41);
            this.chromeCache.TabIndex = 57;
            this.chromeCache.Text = "Cache";
            this.chromeCache.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(62, 820);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 41);
            this.label7.TabIndex = 56;
            this.label7.Tag = "";
            this.label7.Text = "Microsoft Edge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(66, 1402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 41);
            this.label6.TabIndex = 55;
            this.label6.Tag = "";
            this.label6.Text = "Internet Explorer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(60, 612);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 41);
            this.label5.TabIndex = 54;
            this.label5.Tag = "";
            this.label5.Text = "Mozilla Firefox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(62, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 41);
            this.label4.TabIndex = 47;
            this.label4.Tag = "";
            this.label4.Text = "Google Chrome";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(18, 820);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(40, 40);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(18, 1400);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 52;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(14, 292);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(18, 612);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // checkErrorReports
            // 
            this.checkErrorReports.AutoSize = true;
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(16, 182);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(4);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.Size = new System.Drawing.Size(205, 41);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.Text = "Error reports";
            this.checkErrorReports.UseVisualStyleBackColor = true;
            // 
            // checkTemp
            // 
            this.checkTemp.AutoSize = true;
            this.checkTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTemp.ForeColor = System.Drawing.Color.White;
            this.checkTemp.Location = new System.Drawing.Point(16, 74);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(4);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.Size = new System.Drawing.Size(236, 41);
            this.checkTemp.TabIndex = 36;
            this.checkTemp.Text = "Temporary files";
            this.checkTemp.UseVisualStyleBackColor = true;
            // 
            // checkBin
            // 
            this.checkBin.AutoSize = true;
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.White;
            this.checkBin.Location = new System.Drawing.Point(16, 236);
            this.checkBin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBin.Name = "checkBin";
            this.checkBin.Size = new System.Drawing.Size(186, 41);
            this.checkBin.TabIndex = 41;
            this.checkBin.Text = "Recycle Bin";
            this.checkBin.UseVisualStyleBackColor = true;
            // 
            // checkMiniDumps
            // 
            this.checkMiniDumps.AutoSize = true;
            this.checkMiniDumps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniDumps.ForeColor = System.Drawing.Color.White;
            this.checkMiniDumps.Location = new System.Drawing.Point(16, 128);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(4);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.Size = new System.Drawing.Size(265, 41);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.Text = "BSOD Minidumps";
            this.checkMiniDumps.UseVisualStyleBackColor = true;
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pingerTab.Controls.Add(this.netTools);
            this.pingerTab.Location = new System.Drawing.Point(8, 55);
            this.pingerTab.Margin = new System.Windows.Forms.Padding(6);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(6);
            this.pingerTab.Size = new System.Drawing.Size(1950, 1305);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // netTools
            // 
            this.netTools.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.netTools.Controls.Add(this.tabPage1);
            this.netTools.Controls.Add(this.tabPage2);
            this.netTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netTools.Location = new System.Drawing.Point(6, 6);
            this.netTools.Margin = new System.Windows.Forms.Padding(0);
            this.netTools.Multiline = true;
            this.netTools.Name = "netTools";
            this.netTools.Padding = new System.Drawing.Point(0, 0);
            this.netTools.SelectedIndex = 0;
            this.netTools.Size = new System.Drawing.Size(1938, 1293);
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
            this.tabPage1.Location = new System.Drawing.Point(8, 8);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1922, 1230);
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
            this.btnExport.Location = new System.Drawing.Point(54, 974);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(272, 58);
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
            this.copyB.Location = new System.Drawing.Point(50, 288);
            this.copyB.Margin = new System.Windows.Forms.Padding(4);
            this.copyB.Name = "copyB";
            this.copyB.Size = new System.Drawing.Size(370, 62);
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
            this.copyIPB.Location = new System.Drawing.Point(428, 288);
            this.copyIPB.Margin = new System.Windows.Forms.Padding(4);
            this.copyIPB.Name = "copyIPB";
            this.copyIPB.Size = new System.Drawing.Size(370, 62);
            this.copyIPB.TabIndex = 91;
            this.copyIPB.Text = "Copy";
            this.copyIPB.UseVisualStyleBackColor = false;
            this.copyIPB.Click += new System.EventHandler(this.copyIPB_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.listPingResults);
            this.panel7.Location = new System.Drawing.Point(54, 424);
            this.panel7.Margin = new System.Windows.Forms.Padding(6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(740, 538);
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
            this.listPingResults.Margin = new System.Windows.Forms.Padding(4);
            this.listPingResults.Name = "listPingResults";
            this.listPingResults.Size = new System.Drawing.Size(738, 536);
            this.listPingResults.TabIndex = 79;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Silver;
            this.lblResults.Location = new System.Drawing.Point(46, 384);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(104, 37);
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
            this.btnShodan.Location = new System.Drawing.Point(50, 218);
            this.btnShodan.Margin = new System.Windows.Forms.Padding(4);
            this.btnShodan.Name = "btnShodan";
            this.btnShodan.Size = new System.Drawing.Size(370, 62);
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
            this.btnPing.Location = new System.Drawing.Point(428, 218);
            this.btnPing.Margin = new System.Windows.Forms.Padding(4);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(370, 62);
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
            this.txtPingInput.Location = new System.Drawing.Point(50, 152);
            this.txtPingInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPingInput.Name = "txtPingInput";
            this.txtPingInput.Size = new System.Drawing.Size(746, 50);
            this.txtPingInput.TabIndex = 85;
            this.txtPingInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPingInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPingInput_KeyDown);
            // 
            // lblPinger
            // 
            this.lblPinger.AutoSize = true;
            this.lblPinger.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinger.ForeColor = System.Drawing.Color.Silver;
            this.lblPinger.Location = new System.Drawing.Point(44, 106);
            this.lblPinger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPinger.Name = "lblPinger";
            this.lblPinger.Size = new System.Drawing.Size(237, 37);
            this.lblPinger.TabIndex = 86;
            this.lblPinger.Tag = "";
            this.lblPinger.Text = "IP / Domain name";
            // 
            // pingerTitle
            // 
            this.pingerTitle.AutoSize = true;
            this.pingerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingerTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pingerTitle.Location = new System.Drawing.Point(10, 6);
            this.pingerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pingerTitle.Name = "pingerTitle";
            this.pingerTitle.Size = new System.Drawing.Size(769, 54);
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
            this.tabPage2.Location = new System.Drawing.Point(8, 8);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1922, 1230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNS";
            // 
            // dnsTitle
            // 
            this.dnsTitle.AutoSize = true;
            this.dnsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dnsTitle.Location = new System.Drawing.Point(10, 6);
            this.dnsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dnsTitle.Name = "dnsTitle";
            this.dnsTitle.Size = new System.Drawing.Size(514, 54);
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
            this.linkDNSv6A.Location = new System.Drawing.Point(218, 436);
            this.linkDNSv6A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDNSv6A.Name = "linkDNSv6A";
            this.linkDNSv6A.Size = new System.Drawing.Size(30, 41);
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
            this.linkDNSv4A.Location = new System.Drawing.Point(216, 322);
            this.linkDNSv4A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDNSv4A.Name = "linkDNSv4A";
            this.linkDNSv4A.Size = new System.Drawing.Size(30, 41);
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
            this.linkDNSv6.Location = new System.Drawing.Point(218, 390);
            this.linkDNSv6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDNSv6.Name = "linkDNSv6";
            this.linkDNSv6.Size = new System.Drawing.Size(30, 41);
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
            this.linkDNSv4.Location = new System.Drawing.Point(218, 276);
            this.linkDNSv4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDNSv4.Name = "linkDNSv4";
            this.linkDNSv4.Size = new System.Drawing.Size(30, 41);
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
            this.label3.Location = new System.Drawing.Point(54, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 41);
            this.label3.TabIndex = 109;
            this.label3.Tag = "";
            this.label3.Text = "DNS IPv6:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(54, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
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
            this.btnOpenNetwork.Location = new System.Drawing.Point(62, 598);
            this.btnOpenNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenNetwork.Name = "btnOpenNetwork";
            this.btnOpenNetwork.Size = new System.Drawing.Size(520, 58);
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
            this.flushCacheB.Location = new System.Drawing.Point(62, 532);
            this.flushCacheB.Margin = new System.Windows.Forms.Padding(4);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(520, 58);
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
            this.boxAdapter.Location = new System.Drawing.Point(56, 100);
            this.boxAdapter.Margin = new System.Windows.Forms.Padding(6);
            this.boxAdapter.Name = "boxAdapter";
            this.boxAdapter.Size = new System.Drawing.Size(824, 53);
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
            this.boxDNS.Location = new System.Drawing.Point(56, 170);
            this.boxDNS.Margin = new System.Windows.Forms.Padding(6);
            this.boxDNS.Name = "boxDNS";
            this.boxDNS.Size = new System.Drawing.Size(824, 53);
            this.boxDNS.TabIndex = 106;
            // 
            // hostsEditorTab
            // 
            this.hostsEditorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hostsEditorTab.Controls.Add(this.panel4);
            this.hostsEditorTab.Controls.Add(this.hostsTitle);
            this.hostsEditorTab.Controls.Add(this.linkLocate);
            this.hostsEditorTab.Location = new System.Drawing.Point(8, 55);
            this.hostsEditorTab.Margin = new System.Windows.Forms.Padding(4);
            this.hostsEditorTab.Name = "hostsEditorTab";
            this.hostsEditorTab.Padding = new System.Windows.Forms.Padding(4);
            this.hostsEditorTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.panel4.Location = new System.Drawing.Point(12, 140);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2114, 1286);
            this.panel4.TabIndex = 53;
            // 
            // linkAdvancedEdit
            // 
            this.linkAdvancedEdit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkAdvancedEdit.AutoSize = true;
            this.linkAdvancedEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdvancedEdit.ForeColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.LinkColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.Location = new System.Drawing.Point(646, 676);
            this.linkAdvancedEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAdvancedEdit.Name = "linkAdvancedEdit";
            this.linkAdvancedEdit.Size = new System.Drawing.Size(258, 45);
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
            this.linkRestoreDefault.Location = new System.Drawing.Point(646, 738);
            this.linkRestoreDefault.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRestoreDefault.Name = "linkRestoreDefault";
            this.linkRestoreDefault.Size = new System.Drawing.Size(242, 45);
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
            this.lblLock.Location = new System.Drawing.Point(650, 364);
            this.lblLock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(630, 110);
            this.lblLock.TabIndex = 62;
            this.lblLock.Tag = "";
            this.lblLock.Text = "Protect your HOSTS file by locking it.";
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.AutoSize = true;
            this.chkReadOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadOnly.ForeColor = System.Drawing.Color.White;
            this.chkReadOnly.Location = new System.Drawing.Point(658, 310);
            this.chkReadOnly.Margin = new System.Windows.Forms.Padding(4);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(199, 49);
            this.chkReadOnly.TabIndex = 61;
            this.chkReadOnly.Text = "Read-only";
            this.chkReadOnly.UseVisualStyleBackColor = true;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelList.Controls.Add(this.listHostEntries);
            this.panelList.Location = new System.Drawing.Point(10, 6);
            this.panelList.Margin = new System.Windows.Forms.Padding(6);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(622, 774);
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
            this.listHostEntries.Margin = new System.Windows.Forms.Padding(4);
            this.listHostEntries.Name = "listHostEntries";
            this.listHostEntries.Size = new System.Drawing.Size(620, 772);
            this.listHostEntries.TabIndex = 52;
            // 
            // chkBlock
            // 
            this.chkBlock.AutoSize = true;
            this.chkBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlock.ForeColor = System.Drawing.Color.White;
            this.chkBlock.Location = new System.Drawing.Point(658, 220);
            this.chkBlock.Margin = new System.Windows.Forms.Padding(4);
            this.chkBlock.Name = "chkBlock";
            this.chkBlock.Size = new System.Drawing.Size(130, 49);
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
            this.refreshHostsB.Location = new System.Drawing.Point(10, 790);
            this.refreshHostsB.Margin = new System.Windows.Forms.Padding(4);
            this.refreshHostsB.Name = "refreshHostsB";
            this.refreshHostsB.Size = new System.Drawing.Size(304, 62);
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
            this.removeHostB.Location = new System.Drawing.Point(322, 790);
            this.removeHostB.Margin = new System.Windows.Forms.Padding(4);
            this.removeHostB.Name = "removeHostB";
            this.removeHostB.Size = new System.Drawing.Size(312, 62);
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
            this.removeAllHostsB.Location = new System.Drawing.Point(322, 860);
            this.removeAllHostsB.Margin = new System.Windows.Forms.Padding(4);
            this.removeAllHostsB.Name = "removeAllHostsB";
            this.removeAllHostsB.Size = new System.Drawing.Size(312, 62);
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
            this.addHostB.Location = new System.Drawing.Point(1022, 220);
            this.addHostB.Margin = new System.Windows.Forms.Padding(4);
            this.addHostB.Name = "addHostB";
            this.addHostB.Size = new System.Drawing.Size(254, 62);
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
            this.txtIP.Location = new System.Drawing.Point(656, 46);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(618, 50);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.ForeColor = System.Drawing.Color.White;
            this.txtDomain.Location = new System.Drawing.Point(656, 154);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(618, 50);
            this.txtDomain.TabIndex = 1;
            this.txtDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDomain.Location = new System.Drawing.Point(646, 108);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(134, 45);
            this.lblDomain.TabIndex = 55;
            this.lblDomain.Tag = "themeable";
            this.lblDomain.Text = "Domain";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIP.Location = new System.Drawing.Point(646, 0);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(169, 45);
            this.lblIP.TabIndex = 53;
            this.lblIP.Tag = "themeable";
            this.lblIP.Text = "IP address";
            // 
            // hostsTitle
            // 
            this.hostsTitle.AutoSize = true;
            this.hostsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostsTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.hostsTitle.Location = new System.Drawing.Point(12, 20);
            this.hostsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostsTitle.Name = "hostsTitle";
            this.hostsTitle.Size = new System.Drawing.Size(357, 54);
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
            this.linkLocate.Location = new System.Drawing.Point(16, 76);
            this.linkLocate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLocate.Name = "linkLocate";
            this.linkLocate.Size = new System.Drawing.Size(116, 45);
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
            this.registryFixerTab.Location = new System.Drawing.Point(8, 55);
            this.registryFixerTab.Margin = new System.Windows.Forms.Padding(4);
            this.registryFixerTab.Name = "registryFixerTab";
            this.registryFixerTab.Padding = new System.Windows.Forms.Padding(4);
            this.registryFixerTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.panel2.Location = new System.Drawing.Point(22, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1510, 572);
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
            this.regFixB.Location = new System.Drawing.Point(58, 504);
            this.regFixB.Margin = new System.Windows.Forms.Padding(4);
            this.regFixB.Name = "regFixB";
            this.regFixB.Size = new System.Drawing.Size(308, 62);
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
            this.regLbl.Location = new System.Drawing.Point(188, 416);
            this.regLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(473, 45);
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
            this.checkRestartExplorer.Location = new System.Drawing.Point(58, 362);
            this.checkRestartExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.checkRestartExplorer.Name = "checkRestartExplorer";
            this.checkRestartExplorer.Size = new System.Drawing.Size(606, 49);
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
            this.checkRegistryEditor.Location = new System.Drawing.Point(582, 272);
            this.checkRegistryEditor.Margin = new System.Windows.Forms.Padding(4);
            this.checkRegistryEditor.Name = "checkRegistryEditor";
            this.checkRegistryEditor.Size = new System.Drawing.Size(266, 49);
            this.checkRegistryEditor.TabIndex = 38;
            this.checkRegistryEditor.Text = "Registry Editor";
            this.checkRegistryEditor.UseVisualStyleBackColor = true;
            // 
            // checkEnableAll
            // 
            this.checkEnableAll.AutoSize = true;
            this.checkEnableAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnableAll.ForeColor = System.Drawing.Color.White;
            this.checkEnableAll.Location = new System.Drawing.Point(58, 28);
            this.checkEnableAll.Margin = new System.Windows.Forms.Padding(4);
            this.checkEnableAll.Name = "checkEnableAll";
            this.checkEnableAll.Size = new System.Drawing.Size(191, 49);
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
            this.checkContextMenu.Location = new System.Drawing.Point(582, 150);
            this.checkContextMenu.Margin = new System.Windows.Forms.Padding(4);
            this.checkContextMenu.Name = "checkContextMenu";
            this.checkContextMenu.Size = new System.Drawing.Size(299, 49);
            this.checkContextMenu.TabIndex = 43;
            this.checkContextMenu.Text = "Right Click menu";
            this.checkContextMenu.UseVisualStyleBackColor = true;
            // 
            // checkTaskManager
            // 
            this.checkTaskManager.AutoSize = true;
            this.checkTaskManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaskManager.ForeColor = System.Drawing.Color.White;
            this.checkTaskManager.Location = new System.Drawing.Point(110, 90);
            this.checkTaskManager.Margin = new System.Windows.Forms.Padding(4);
            this.checkTaskManager.Name = "checkTaskManager";
            this.checkTaskManager.Size = new System.Drawing.Size(255, 49);
            this.checkTaskManager.TabIndex = 36;
            this.checkTaskManager.Text = "Task Manager";
            this.checkTaskManager.UseVisualStyleBackColor = true;
            // 
            // checkCommandPrompt
            // 
            this.checkCommandPrompt.AutoSize = true;
            this.checkCommandPrompt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCommandPrompt.ForeColor = System.Drawing.Color.White;
            this.checkCommandPrompt.Location = new System.Drawing.Point(110, 150);
            this.checkCommandPrompt.Margin = new System.Windows.Forms.Padding(4);
            this.checkCommandPrompt.Name = "checkCommandPrompt";
            this.checkCommandPrompt.Size = new System.Drawing.Size(320, 49);
            this.checkCommandPrompt.TabIndex = 42;
            this.checkCommandPrompt.Text = "Command Prompt";
            this.checkCommandPrompt.UseVisualStyleBackColor = true;
            // 
            // checkFirewall
            // 
            this.checkFirewall.AutoSize = true;
            this.checkFirewall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFirewall.ForeColor = System.Drawing.Color.White;
            this.checkFirewall.Location = new System.Drawing.Point(582, 212);
            this.checkFirewall.Margin = new System.Windows.Forms.Padding(4);
            this.checkFirewall.Name = "checkFirewall";
            this.checkFirewall.Size = new System.Drawing.Size(305, 49);
            this.checkFirewall.TabIndex = 37;
            this.checkFirewall.Text = "Windows Firewall";
            this.checkFirewall.UseVisualStyleBackColor = true;
            // 
            // checkRunDialog
            // 
            this.checkRunDialog.AutoSize = true;
            this.checkRunDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRunDialog.ForeColor = System.Drawing.Color.White;
            this.checkRunDialog.Location = new System.Drawing.Point(582, 90);
            this.checkRunDialog.Margin = new System.Windows.Forms.Padding(4);
            this.checkRunDialog.Name = "checkRunDialog";
            this.checkRunDialog.Size = new System.Drawing.Size(213, 49);
            this.checkRunDialog.TabIndex = 41;
            this.checkRunDialog.Text = "Run Dialog";
            this.checkRunDialog.UseVisualStyleBackColor = true;
            // 
            // checkFolderOptions
            // 
            this.checkFolderOptions.AutoSize = true;
            this.checkFolderOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFolderOptions.ForeColor = System.Drawing.Color.White;
            this.checkFolderOptions.Location = new System.Drawing.Point(110, 272);
            this.checkFolderOptions.Margin = new System.Windows.Forms.Padding(4);
            this.checkFolderOptions.Name = "checkFolderOptions";
            this.checkFolderOptions.Size = new System.Drawing.Size(267, 49);
            this.checkFolderOptions.TabIndex = 39;
            this.checkFolderOptions.Text = "Folder Options";
            this.checkFolderOptions.UseVisualStyleBackColor = true;
            // 
            // checkControlPanel
            // 
            this.checkControlPanel.AutoSize = true;
            this.checkControlPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkControlPanel.ForeColor = System.Drawing.Color.White;
            this.checkControlPanel.Location = new System.Drawing.Point(110, 212);
            this.checkControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkControlPanel.Name = "checkControlPanel";
            this.checkControlPanel.Size = new System.Drawing.Size(249, 49);
            this.checkControlPanel.TabIndex = 40;
            this.checkControlPanel.Text = "Control Panel";
            this.checkControlPanel.UseVisualStyleBackColor = true;
            // 
            // registryTitle
            // 
            this.registryTitle.AutoSize = true;
            this.registryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registryTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registryTitle.Location = new System.Drawing.Point(12, 20);
            this.registryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registryTitle.Name = "registryTitle";
            this.registryTitle.Size = new System.Drawing.Size(509, 54);
            this.registryTitle.TabIndex = 47;
            this.registryTitle.Tag = "themeable";
            this.registryTitle.Text = "Fix common registry issues";
            // 
            // indiciumTab
            // 
            this.indiciumTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.indiciumTab.Controls.Add(this.panel12);
            this.indiciumTab.Controls.Add(this.panel11);
            this.indiciumTab.Location = new System.Drawing.Point(8, 55);
            this.indiciumTab.Margin = new System.Windows.Forms.Padding(6);
            this.indiciumTab.Name = "indiciumTab";
            this.indiciumTab.Padding = new System.Windows.Forms.Padding(6);
            this.indiciumTab.Size = new System.Drawing.Size(1950, 1305);
            this.indiciumTab.TabIndex = 14;
            this.indiciumTab.Text = "Hardware";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.specsTree);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(6, 74);
            this.panel12.Margin = new System.Windows.Forms.Padding(6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1938, 1225);
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
            this.specsTree.Margin = new System.Windows.Forms.Padding(6);
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
            this.specsTree.Size = new System.Drawing.Size(1936, 1223);
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
            this.indiciumMenu.Size = new System.Drawing.Size(400, 136);
            // 
            // toolHWCopy
            // 
            this.toolHWCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWCopy.ForeColor = System.Drawing.Color.White;
            this.toolHWCopy.Name = "toolHWCopy";
            this.toolHWCopy.Size = new System.Drawing.Size(399, 44);
            this.toolHWCopy.Text = "Copy";
            this.toolHWCopy.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolHWCopy.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolHWGoogle
            // 
            this.toolHWGoogle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWGoogle.ForeColor = System.Drawing.Color.White;
            this.toolHWGoogle.Name = "toolHWGoogle";
            this.toolHWGoogle.Size = new System.Drawing.Size(399, 44);
            this.toolHWGoogle.Text = "Search with Google...";
            this.toolHWGoogle.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolHWGoogle.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolHWDuck
            // 
            this.toolHWDuck.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHWDuck.ForeColor = System.Drawing.Color.White;
            this.toolHWDuck.Name = "toolHWDuck";
            this.toolHWDuck.Size = new System.Drawing.Size(399, 44);
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
            this.panel11.Location = new System.Drawing.Point(6, 6);
            this.panel11.Margin = new System.Windows.Forms.Padding(6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1938, 68);
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
            this.btnCopyHW.Location = new System.Drawing.Point(1638, 8);
            this.btnCopyHW.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyHW.Name = "btnCopyHW";
            this.btnCopyHW.Size = new System.Drawing.Size(292, 48);
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
            this.btnSaveHW.Location = new System.Drawing.Point(1338, 8);
            this.btnSaveHW.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveHW.Name = "btnSaveHW";
            this.btnSaveHW.Size = new System.Drawing.Size(292, 48);
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
            this.hwDetailed.Location = new System.Drawing.Point(10, 8);
            this.hwDetailed.Margin = new System.Windows.Forms.Padding(12);
            this.hwDetailed.Name = "hwDetailed";
            this.hwDetailed.Size = new System.Drawing.Size(748, 48);
            this.hwDetailed.TabIndex = 89;
            this.hwDetailed.Tag = "themeable";
            this.hwDetailed.ToggleChecked = true;
            this.hwDetailed.ToggleClicked += new System.EventHandler(this.hwDetailed_ToggleClicked);
            // 
            // integratorTab
            // 
            this.integratorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.integratorTab.Controls.Add(this.synapse);
            this.integratorTab.Location = new System.Drawing.Point(8, 55);
            this.integratorTab.Margin = new System.Windows.Forms.Padding(4);
            this.integratorTab.Name = "integratorTab";
            this.integratorTab.Padding = new System.Windows.Forms.Padding(4);
            this.integratorTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.synapse.Location = new System.Drawing.Point(4, 4);
            this.synapse.Margin = new System.Windows.Forms.Padding(4);
            this.synapse.Multiline = true;
            this.synapse.Name = "synapse";
            this.synapse.Padding = new System.Drawing.Point(0, 0);
            this.synapse.SelectedIndex = 0;
            this.synapse.Size = new System.Drawing.Size(1942, 1297);
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
            this.integratorInfoTab.Location = new System.Drawing.Point(8, 8);
            this.integratorInfoTab.Margin = new System.Windows.Forms.Padding(4);
            this.integratorInfoTab.Name = "integratorInfoTab";
            this.integratorInfoTab.Padding = new System.Windows.Forms.Padding(4);
            this.integratorInfoTab.Size = new System.Drawing.Size(1926, 1234);
            this.integratorInfoTab.TabIndex = 0;
            this.integratorInfoTab.Text = "Info";
            // 
            // integrator7
            // 
            this.integrator7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator7.ForeColor = System.Drawing.Color.Silver;
            this.integrator7.Location = new System.Drawing.Point(12, 450);
            this.integrator7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator7.Name = "integrator7";
            this.integrator7.Size = new System.Drawing.Size(1526, 618);
            this.integrator7.TabIndex = 10;
            this.integrator7.Tag = "";
            this.integrator7.Text = resources.GetString("integrator7.Text");
            // 
            // integrator6
            // 
            this.integrator6.AutoSize = true;
            this.integrator6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator6.ForeColor = System.Drawing.Color.Silver;
            this.integrator6.Location = new System.Drawing.Point(76, 366);
            this.integrator6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator6.Name = "integrator6";
            this.integrator6.Size = new System.Drawing.Size(206, 45);
            this.integrator6.TabIndex = 9;
            this.integrator6.Tag = "";
            this.integrator6.Text = "• Commands";
            // 
            // integrator5
            // 
            this.integrator5.AutoSize = true;
            this.integrator5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator5.ForeColor = System.Drawing.Color.Silver;
            this.integrator5.Location = new System.Drawing.Point(76, 316);
            this.integrator5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator5.Name = "integrator5";
            this.integrator5.Size = new System.Drawing.Size(262, 45);
            this.integrator5.TabIndex = 8;
            this.integrator5.Tag = "";
            this.integrator5.Text = "• Any type of file";
            // 
            // integrator4
            // 
            this.integrator4.AutoSize = true;
            this.integrator4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator4.ForeColor = System.Drawing.Color.Silver;
            this.integrator4.Location = new System.Drawing.Point(76, 264);
            this.integrator4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator4.Name = "integrator4";
            this.integrator4.Size = new System.Drawing.Size(311, 45);
            this.integrator4.TabIndex = 7;
            this.integrator4.Tag = "";
            this.integrator4.Text = "• Links to webpages";
            // 
            // integrator3
            // 
            this.integrator3.AutoSize = true;
            this.integrator3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator3.ForeColor = System.Drawing.Color.Silver;
            this.integrator3.Location = new System.Drawing.Point(76, 212);
            this.integrator3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator3.Name = "integrator3";
            this.integrator3.Size = new System.Drawing.Size(331, 45);
            this.integrator3.TabIndex = 6;
            this.integrator3.Tag = "";
            this.integrator3.Text = "• Shortcuts to folders";
            // 
            // integrator2
            // 
            this.integrator2.AutoSize = true;
            this.integrator2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator2.ForeColor = System.Drawing.Color.Silver;
            this.integrator2.Location = new System.Drawing.Point(76, 162);
            this.integrator2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator2.Name = "integrator2";
            this.integrator2.Size = new System.Drawing.Size(233, 45);
            this.integrator2.TabIndex = 5;
            this.integrator2.Tag = "";
            this.integrator2.Text = "• Any program";
            // 
            // integrator1
            // 
            this.integrator1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator1.ForeColor = System.Drawing.Color.Silver;
            this.integrator1.Location = new System.Drawing.Point(12, 20);
            this.integrator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.integrator1.Name = "integrator1";
            this.integrator1.Size = new System.Drawing.Size(1622, 122);
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
            this.tabPage8.Location = new System.Drawing.Point(8, 8);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(1926, 1234);
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
            this.btnAddItem.Location = new System.Drawing.Point(872, 946);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(404, 62);
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
            this.itemnamegroup.Location = new System.Drawing.Point(22, 806);
            this.itemnamegroup.Margin = new System.Windows.Forms.Padding(4);
            this.itemnamegroup.Name = "itemnamegroup";
            this.itemnamegroup.Padding = new System.Windows.Forms.Padding(4);
            this.itemnamegroup.Size = new System.Drawing.Size(1254, 132);
            this.itemnamegroup.TabIndex = 84;
            this.itemnamegroup.TabStop = false;
            this.itemnamegroup.Text = "Item name in menu:";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.ForeColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(22, 52);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(950, 50);
            this.txtItemName.TabIndex = 82;
            // 
            // security
            // 
            this.security.Controls.Add(this.checkShift);
            this.security.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security.ForeColor = System.Drawing.Color.Silver;
            this.security.Location = new System.Drawing.Point(22, 676);
            this.security.Margin = new System.Windows.Forms.Padding(4);
            this.security.Name = "security";
            this.security.Padding = new System.Windows.Forms.Padding(4);
            this.security.Size = new System.Drawing.Size(1254, 122);
            this.security.TabIndex = 83;
            this.security.TabStop = false;
            this.security.Text = "Security:";
            // 
            // checkShift
            // 
            this.checkShift.AutoSize = true;
            this.checkShift.ForeColor = System.Drawing.Color.White;
            this.checkShift.Location = new System.Drawing.Point(22, 52);
            this.checkShift.Margin = new System.Windows.Forms.Padding(4);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(593, 49);
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
            this.itemposition.Location = new System.Drawing.Point(22, 544);
            this.itemposition.Margin = new System.Windows.Forms.Padding(4);
            this.itemposition.Name = "itemposition";
            this.itemposition.Padding = new System.Windows.Forms.Padding(4);
            this.itemposition.Size = new System.Drawing.Size(1254, 124);
            this.itemposition.TabIndex = 82;
            this.itemposition.TabStop = false;
            this.itemposition.Text = "Item position:";
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioTop.ForeColor = System.Drawing.Color.White;
            this.radioTop.Location = new System.Drawing.Point(22, 52);
            this.radioTop.Margin = new System.Windows.Forms.Padding(4);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(104, 49);
            this.radioTop.TabIndex = 83;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = true;
            this.radioTop.CheckedChanged += new System.EventHandler(this.radioTop_CheckedChanged);
            // 
            // radioMiddle
            // 
            this.radioMiddle.AutoSize = true;
            this.radioMiddle.ForeColor = System.Drawing.Color.White;
            this.radioMiddle.Location = new System.Drawing.Point(262, 52);
            this.radioMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.radioMiddle.Name = "radioMiddle";
            this.radioMiddle.Size = new System.Drawing.Size(152, 49);
            this.radioMiddle.TabIndex = 84;
            this.radioMiddle.Text = "Middle";
            this.radioMiddle.UseVisualStyleBackColor = true;
            this.radioMiddle.CheckedChanged += new System.EventHandler(this.radioMiddle_CheckedChanged);
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.ForeColor = System.Drawing.Color.White;
            this.radioBottom.Location = new System.Drawing.Point(554, 52);
            this.radioBottom.Margin = new System.Windows.Forms.Padding(4);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(160, 49);
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
            this.icontoaddgroup.Location = new System.Drawing.Point(22, 356);
            this.icontoaddgroup.Margin = new System.Windows.Forms.Padding(4);
            this.icontoaddgroup.Name = "icontoaddgroup";
            this.icontoaddgroup.Padding = new System.Windows.Forms.Padding(4);
            this.icontoaddgroup.Size = new System.Drawing.Size(1254, 180);
            this.icontoaddgroup.TabIndex = 81;
            this.icontoaddgroup.TabStop = false;
            this.icontoaddgroup.Text = "Icon to add:";
            // 
            // checkDefaultIcon
            // 
            this.checkDefaultIcon.AutoSize = true;
            this.checkDefaultIcon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.checkDefaultIcon.ForeColor = System.Drawing.Color.White;
            this.checkDefaultIcon.Location = new System.Drawing.Point(22, 116);
            this.checkDefaultIcon.Margin = new System.Windows.Forms.Padding(4);
            this.checkDefaultIcon.Name = "checkDefaultIcon";
            this.checkDefaultIcon.Size = new System.Drawing.Size(332, 49);
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
            this.btnBrowseIcon.Location = new System.Drawing.Point(900, 52);
            this.btnBrowseIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(72, 58);
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
            this.txtIcon.Location = new System.Drawing.Point(22, 52);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(4);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.ReadOnly = true;
            this.txtIcon.Size = new System.Drawing.Size(866, 50);
            this.txtIcon.TabIndex = 81;
            // 
            // itemtoaddgroup
            // 
            this.itemtoaddgroup.Controls.Add(this.btnBrowseItem);
            this.itemtoaddgroup.Controls.Add(this.txtItem);
            this.itemtoaddgroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtoaddgroup.ForeColor = System.Drawing.Color.Silver;
            this.itemtoaddgroup.Location = new System.Drawing.Point(22, 214);
            this.itemtoaddgroup.Margin = new System.Windows.Forms.Padding(4);
            this.itemtoaddgroup.Name = "itemtoaddgroup";
            this.itemtoaddgroup.Padding = new System.Windows.Forms.Padding(4);
            this.itemtoaddgroup.Size = new System.Drawing.Size(1254, 134);
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
            this.btnBrowseItem.Location = new System.Drawing.Point(898, 52);
            this.btnBrowseItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseItem.Name = "btnBrowseItem";
            this.btnBrowseItem.Size = new System.Drawing.Size(72, 58);
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
            this.txtItem.Location = new System.Drawing.Point(22, 52);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(866, 50);
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
            this.itemtype.Location = new System.Drawing.Point(22, 80);
            this.itemtype.Margin = new System.Windows.Forms.Padding(4);
            this.itemtype.Name = "itemtype";
            this.itemtype.Padding = new System.Windows.Forms.Padding(4);
            this.itemtype.Size = new System.Drawing.Size(1254, 126);
            this.itemtype.TabIndex = 79;
            this.itemtype.TabStop = false;
            this.itemtype.Text = "Item Type:";
            // 
            // radioCommand
            // 
            this.radioCommand.AutoSize = true;
            this.radioCommand.ForeColor = System.Drawing.Color.White;
            this.radioCommand.Location = new System.Drawing.Point(962, 52);
            this.radioCommand.Margin = new System.Windows.Forms.Padding(4);
            this.radioCommand.Name = "radioCommand";
            this.radioCommand.Size = new System.Drawing.Size(201, 49);
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
            this.radioProgram.Location = new System.Drawing.Point(22, 52);
            this.radioProgram.Margin = new System.Windows.Forms.Padding(4);
            this.radioProgram.Name = "radioProgram";
            this.radioProgram.Size = new System.Drawing.Size(177, 49);
            this.radioProgram.TabIndex = 80;
            this.radioProgram.Text = "Program";
            this.radioProgram.UseVisualStyleBackColor = true;
            this.radioProgram.CheckedChanged += new System.EventHandler(this.radioProgram_CheckedChanged);
            // 
            // radioFolder
            // 
            this.radioFolder.AutoSize = true;
            this.radioFolder.ForeColor = System.Drawing.Color.White;
            this.radioFolder.Location = new System.Drawing.Point(278, 52);
            this.radioFolder.Margin = new System.Windows.Forms.Padding(4);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(142, 49);
            this.radioFolder.TabIndex = 81;
            this.radioFolder.Text = "Folder";
            this.radioFolder.UseVisualStyleBackColor = true;
            this.radioFolder.CheckedChanged += new System.EventHandler(this.radioFolder_CheckedChanged);
            // 
            // radioLink
            // 
            this.radioLink.AutoSize = true;
            this.radioLink.ForeColor = System.Drawing.Color.White;
            this.radioLink.Location = new System.Drawing.Point(508, 52);
            this.radioLink.Margin = new System.Windows.Forms.Padding(4);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(111, 49);
            this.radioLink.TabIndex = 82;
            this.radioLink.Text = "Link";
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.CheckedChanged += new System.EventHandler(this.radioLink_CheckedChanged);
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.ForeColor = System.Drawing.Color.White;
            this.radioFile.Location = new System.Drawing.Point(742, 52);
            this.radioFile.Margin = new System.Windows.Forms.Padding(4);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(100, 49);
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
            this.addItemL.Location = new System.Drawing.Point(12, 20);
            this.addItemL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addItemL.Name = "addItemL";
            this.addItemL.Size = new System.Drawing.Size(433, 54);
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
            this.tabPage9.Location = new System.Drawing.Point(8, 8);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(1926, 1234);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Remove";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.listDesktopItems);
            this.panel5.Location = new System.Drawing.Point(22, 88);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 868);
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
            this.listDesktopItems.Margin = new System.Windows.Forms.Padding(4);
            this.listDesktopItems.Name = "listDesktopItems";
            this.listDesktopItems.Size = new System.Drawing.Size(582, 866);
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
            this.refreshIIB.Location = new System.Drawing.Point(616, 160);
            this.refreshIIB.Margin = new System.Windows.Forms.Padding(4);
            this.refreshIIB.Name = "refreshIIB";
            this.refreshIIB.Size = new System.Drawing.Size(370, 62);
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
            this.removeDIB.Location = new System.Drawing.Point(616, 90);
            this.removeDIB.Margin = new System.Windows.Forms.Padding(4);
            this.removeDIB.Name = "removeDIB";
            this.removeDIB.Size = new System.Drawing.Size(370, 62);
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
            this.removeAllIIB.Location = new System.Drawing.Point(616, 230);
            this.removeAllIIB.Margin = new System.Windows.Forms.Padding(4);
            this.removeAllIIB.Name = "removeAllIIB";
            this.removeAllIIB.Size = new System.Drawing.Size(370, 62);
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
            this.removeIntegratorItemsL.Location = new System.Drawing.Point(12, 20);
            this.removeIntegratorItemsL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removeIntegratorItemsL.Name = "removeIntegratorItemsL";
            this.removeIntegratorItemsL.Size = new System.Drawing.Size(587, 54);
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
            this.tabPage10.Location = new System.Drawing.Point(8, 8);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage10.Size = new System.Drawing.Size(1926, 1234);
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
            this.WAB.Location = new System.Drawing.Point(64, 240);
            this.WAB.Margin = new System.Windows.Forms.Padding(12);
            this.WAB.Name = "WAB";
            this.WAB.Size = new System.Drawing.Size(748, 48);
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
            this.AddCMDB.Location = new System.Drawing.Point(64, 550);
            this.AddCMDB.Margin = new System.Windows.Forms.Padding(12);
            this.AddCMDB.Name = "AddCMDB";
            this.AddCMDB.Size = new System.Drawing.Size(748, 48);
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
            this.AddOwnerB.Location = new System.Drawing.Point(64, 490);
            this.AddOwnerB.Margin = new System.Windows.Forms.Padding(12);
            this.AddOwnerB.Name = "AddOwnerB";
            this.AddOwnerB.Size = new System.Drawing.Size(748, 48);
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
            this.DSB.Location = new System.Drawing.Point(64, 360);
            this.DSB.Margin = new System.Windows.Forms.Padding(12);
            this.DSB.Name = "DSB";
            this.DSB.Size = new System.Drawing.Size(748, 48);
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
            this.SSB.Location = new System.Drawing.Point(64, 300);
            this.SSB.Margin = new System.Windows.Forms.Padding(12);
            this.SSB.Name = "SSB";
            this.SSB.Size = new System.Drawing.Size(748, 48);
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
            this.STB.Location = new System.Drawing.Point(64, 180);
            this.STB.Margin = new System.Windows.Forms.Padding(12);
            this.STB.Name = "STB";
            this.STB.Size = new System.Drawing.Size(748, 48);
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
            this.PMB.Location = new System.Drawing.Point(64, 120);
            this.PMB.Margin = new System.Windows.Forms.Padding(12);
            this.PMB.Name = "PMB";
            this.PMB.Size = new System.Drawing.Size(748, 48);
            this.PMB.TabIndex = 89;
            this.PMB.Tag = "themeable";
            this.PMB.ToggleChecked = false;
            // 
            // readyMenusL
            // 
            this.readyMenusL.AutoSize = true;
            this.readyMenusL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyMenusL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.readyMenusL.Location = new System.Drawing.Point(12, 20);
            this.readyMenusL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyMenusL.Name = "readyMenusL";
            this.readyMenusL.Size = new System.Drawing.Size(457, 54);
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
            this.tabPage11.Location = new System.Drawing.Point(8, 8);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage11.Size = new System.Drawing.Size(1926, 1234);
            this.tabPage11.TabIndex = 4;
            this.tabPage11.Text = "Run Dialog";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.listCustomCommands);
            this.panel6.Location = new System.Drawing.Point(22, 420);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(540, 624);
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
            this.listCustomCommands.Margin = new System.Windows.Forms.Padding(4);
            this.listCustomCommands.Name = "listCustomCommands";
            this.listCustomCommands.Size = new System.Drawing.Size(538, 622);
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
            this.removeCCB.Location = new System.Drawing.Point(572, 420);
            this.removeCCB.Margin = new System.Windows.Forms.Padding(4);
            this.removeCCB.Name = "removeCCB";
            this.removeCCB.Size = new System.Drawing.Size(324, 54);
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
            this.refreshCCB.Location = new System.Drawing.Point(572, 482);
            this.refreshCCB.Margin = new System.Windows.Forms.Padding(4);
            this.refreshCCB.Name = "refreshCCB";
            this.refreshCCB.Size = new System.Drawing.Size(324, 54);
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
            this.removeCCL.Location = new System.Drawing.Point(12, 346);
            this.removeCCL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removeCCL.Name = "removeCCL";
            this.removeCCL.Size = new System.Drawing.Size(498, 54);
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
            this.btnCreateCustomCommand.Location = new System.Drawing.Point(598, 260);
            this.btnCreateCustomCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCustomCommand.Name = "btnCreateCustomCommand";
            this.btnCreateCustomCommand.Size = new System.Drawing.Size(298, 58);
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
            this.button48.Location = new System.Drawing.Point(792, 150);
            this.button48.Margin = new System.Windows.Forms.Padding(4);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(104, 58);
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
            this.txtRunKeyword.Location = new System.Drawing.Point(22, 260);
            this.txtRunKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRunKeyword.Name = "txtRunKeyword";
            this.txtRunKeyword.Size = new System.Drawing.Size(566, 50);
            this.txtRunKeyword.TabIndex = 9;
            // 
            // ccKeywordL
            // 
            this.ccKeywordL.AutoSize = true;
            this.ccKeywordL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccKeywordL.ForeColor = System.Drawing.Color.Silver;
            this.ccKeywordL.Location = new System.Drawing.Point(14, 210);
            this.ccKeywordL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ccKeywordL.Name = "ccKeywordL";
            this.ccKeywordL.Size = new System.Drawing.Size(155, 45);
            this.ccKeywordL.TabIndex = 8;
            this.ccKeywordL.Text = "Keyword:";
            // 
            // txtRunFile
            // 
            this.txtRunFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRunFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRunFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunFile.ForeColor = System.Drawing.Color.White;
            this.txtRunFile.Location = new System.Drawing.Point(22, 150);
            this.txtRunFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtRunFile.Name = "txtRunFile";
            this.txtRunFile.ReadOnly = true;
            this.txtRunFile.Size = new System.Drawing.Size(760, 50);
            this.txtRunFile.TabIndex = 7;
            // 
            // ccFileL
            // 
            this.ccFileL.AutoSize = true;
            this.ccFileL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccFileL.ForeColor = System.Drawing.Color.Silver;
            this.ccFileL.Location = new System.Drawing.Point(14, 100);
            this.ccFileL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ccFileL.Name = "ccFileL";
            this.ccFileL.Size = new System.Drawing.Size(203, 45);
            this.ccFileL.TabIndex = 6;
            this.ccFileL.Text = "File location:";
            // 
            // ccL
            // 
            this.ccL.AutoSize = true;
            this.ccL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ccL.Location = new System.Drawing.Point(12, 20);
            this.ccL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ccL.Name = "ccL";
            this.ccL.Size = new System.Drawing.Size(586, 54);
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
            this.optionsTab.Location = new System.Drawing.Point(8, 55);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(4);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(4);
            this.optionsTab.Size = new System.Drawing.Size(1950, 1305);
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
            this.telemetrySvcToggle.Location = new System.Drawing.Point(42, 160);
            this.telemetrySvcToggle.Margin = new System.Windows.Forms.Padding(12);
            this.telemetrySvcToggle.Name = "telemetrySvcToggle";
            this.telemetrySvcToggle.Size = new System.Drawing.Size(748, 48);
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
            this.autoStartToggle.Location = new System.Drawing.Point(42, 98);
            this.autoStartToggle.Margin = new System.Windows.Forms.Padding(12);
            this.autoStartToggle.Name = "autoStartToggle";
            this.autoStartToggle.Size = new System.Drawing.Size(748, 48);
            this.autoStartToggle.TabIndex = 98;
            this.autoStartToggle.Tag = "themeable";
            this.autoStartToggle.ToggleChecked = false;
            this.autoStartToggle.ToggleClicked += new System.EventHandler(this.autoStartToggle_ToggleClicked);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorPicker1.Location = new System.Drawing.Point(44, 302);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(6);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(278, 196);
            this.colorPicker1.TabIndex = 97;
            this.colorPicker1.Text = "colorPicker1";
            this.colorPicker1.ColorChanged += new System.EventHandler(this.colorPicker1_ColorChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1864, 922);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
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
            this.linkLabel3.Location = new System.Drawing.Point(1614, 920);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(237, 54);
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
            this.pictureBox17.Location = new System.Drawing.Point(1864, 1074);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(64, 64);
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
            this.linkLabel2.Location = new System.Drawing.Point(1596, 1072);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(256, 54);
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
            this.pictureBox14.Location = new System.Drawing.Point(1864, 1226);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(64, 64);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 92;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1864, 998);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(64, 64);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 91;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(1864, 1150);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(64, 64);
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
            this.linkLabel1.Location = new System.Drawing.Point(1542, 1150);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(314, 54);
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
            this.pictureBox85.Location = new System.Drawing.Point(2134, 14);
            this.pictureBox85.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(64, 64);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 74;
            this.pictureBox85.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.boxLang);
            this.panel9.Controls.Add(this.picFlag);
            this.panel9.Location = new System.Drawing.Point(1246, 74);
            this.panel9.Margin = new System.Windows.Forms.Padding(6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(682, 226);
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
            this.boxLang.Location = new System.Drawing.Point(184, 6);
            this.boxLang.Margin = new System.Windows.Forms.Padding(6);
            this.boxLang.Name = "boxLang";
            this.boxLang.Size = new System.Drawing.Size(420, 53);
            this.boxLang.TabIndex = 95;
            this.boxLang.SelectedIndexChanged += new System.EventHandler(this.boxLang_SelectedIndexChanged);
            // 
            // picFlag
            // 
            this.picFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFlag.Image = global::Optimizer.Properties.Resources.united_kingdom;
            this.picFlag.Location = new System.Drawing.Point(618, 18);
            this.picFlag.Margin = new System.Windows.Forms.Padding(6);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(64, 38);
            this.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlag.TabIndex = 75;
            this.picFlag.TabStop = false;
            // 
            // languagesL
            // 
            this.languagesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.languagesL.Location = new System.Drawing.Point(1436, 12);
            this.languagesL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languagesL.Name = "languagesL";
            this.languagesL.Size = new System.Drawing.Size(492, 56);
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
            this.linkLabel5.Location = new System.Drawing.Point(1460, 1226);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(389, 54);
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
            this.btnOpenConf.Location = new System.Drawing.Point(68, 904);
            this.btnOpenConf.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenConf.Name = "btnOpenConf";
            this.btnOpenConf.Size = new System.Drawing.Size(522, 62);
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
            this.lblTroubleshoot.Location = new System.Drawing.Point(34, 758);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(279, 47);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "themeable";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // lblUpdating
            // 
            this.lblUpdating.AutoSize = true;
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUpdating.Location = new System.Drawing.Point(34, 566);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(272, 47);
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
            this.btnViewLog.Location = new System.Drawing.Point(68, 834);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(522, 62);
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
            this.l2.Location = new System.Drawing.Point(1542, 996);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(309, 54);
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
            this.btnUpdate.Location = new System.Drawing.Point(68, 634);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(522, 62);
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
            this.btnResetConfig.Location = new System.Drawing.Point(68, 974);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(522, 62);
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
            this.lblTheming.Location = new System.Drawing.Point(34, 246);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(332, 47);
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
            this.quickAccessToggle.Location = new System.Drawing.Point(42, 36);
            this.quickAccessToggle.Margin = new System.Windows.Forms.Padding(12);
            this.quickAccessToggle.Name = "quickAccessToggle";
            this.quickAccessToggle.Size = new System.Drawing.Size(748, 48);
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
            this.launcherMenu.Size = new System.Drawing.Size(371, 544);
            // 
            // trayStartup
            // 
            this.trayStartup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStartup.ForeColor = System.Drawing.Color.White;
            this.trayStartup.Image = ((System.Drawing.Image)(resources.GetObject("trayStartup.Image")));
            this.trayStartup.Name = "trayStartup";
            this.trayStartup.Size = new System.Drawing.Size(370, 44);
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
            this.trayCleaner.Size = new System.Drawing.Size(370, 44);
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
            this.trayPinger.Size = new System.Drawing.Size(370, 44);
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
            this.trayHosts.Size = new System.Drawing.Size(370, 44);
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
            this.trayAD.Size = new System.Drawing.Size(370, 44);
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
            this.trayHW.Size = new System.Drawing.Size(370, 44);
            this.trayHW.Text = "Hardware Information";
            this.trayHW.Click += new System.EventHandler(this.trayHW_Click);
            // 
            // trayRegistry
            // 
            this.trayRegistry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRegistry.ForeColor = System.Drawing.Color.White;
            this.trayRegistry.Image = ((System.Drawing.Image)(resources.GetObject("trayRegistry.Image")));
            this.trayRegistry.Name = "trayRegistry";
            this.trayRegistry.Size = new System.Drawing.Size(370, 44);
            this.trayRegistry.Text = "Registry Repair";
            this.trayRegistry.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayRegistry.Click += new System.EventHandler(this.trayRegistry_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(367, 6);
            this.toolStripSeparator1.Tag = "";
            // 
            // trayOptions
            // 
            this.trayOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayOptions.ForeColor = System.Drawing.Color.White;
            this.trayOptions.Image = ((System.Drawing.Image)(resources.GetObject("trayOptions.Image")));
            this.trayOptions.Name = "trayOptions";
            this.trayOptions.Size = new System.Drawing.Size(370, 44);
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
            this.trayRestartExplorer.Size = new System.Drawing.Size(370, 44);
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
            this.trayUnlocker.Size = new System.Drawing.Size(370, 44);
            this.trayUnlocker.Text = "Find Handles";
            this.trayUnlocker.Click += new System.EventHandler(this.trayUnlocker_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(367, 6);
            // 
            // trayExit
            // 
            this.trayExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayExit.ForeColor = System.Drawing.Color.White;
            this.trayExit.Image = ((System.Drawing.Image)(resources.GetObject("trayExit.Image")));
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(370, 44);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1968, 1496);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(1908, 1007);
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
        private System.Windows.Forms.TabControl tabCollection;
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
        private System.Windows.Forms.TabControl synapse;
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
        private ToggleCard classicContextSw;
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
        private System.Windows.Forms.TabControl netTools;
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
        private TabPage advancedTab;
    }
}

