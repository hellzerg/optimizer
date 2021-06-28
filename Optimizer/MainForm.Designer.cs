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
            this.tpanel = new System.Windows.Forms.Panel();
            this.txtNetFw = new System.Windows.Forms.Label();
            this.linkUpdate = new System.Windows.Forms.LinkLabel();
            this.lblLab = new System.Windows.Forms.Label();
            this.txtBitness = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpanel = new System.Windows.Forms.Panel();
            this.tabCollection = new System.Windows.Forms.TabControl();
            this.universalTab = new System.Windows.Forms.TabPage();
            this.restartButton = new System.Windows.Forms.Button();
            this.windowsXTab = new System.Windows.Forms.TabPage();
            this.restartButton10 = new System.Windows.Forms.Button();
            this.windowsVIIITab = new System.Windows.Forms.TabPage();
            this.restartButton8 = new System.Windows.Forms.Button();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.txtUWP = new System.Windows.Forms.Label();
            this.uninstallModernAppsButton = new System.Windows.Forms.Button();
            this.refreshModernAppsButton = new System.Windows.Forms.Button();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.panelModernAppsList = new System.Windows.Forms.Panel();
            this.listModernApps = new System.Windows.Forms.CheckedListBox();
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
            this.lblPretext = new System.Windows.Forms.Label();
            this.lblFootprint = new System.Windows.Forms.Label();
            this.cleanDriveB = new System.Windows.Forms.Button();
            this.pingerTab = new System.Windows.Forms.TabPage();
            this.flushCacheB = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.copyB = new System.Windows.Forms.Button();
            this.copyIPB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listPingResults = new System.Windows.Forms.ListBox();
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
            this.panelList = new System.Windows.Forms.Panel();
            this.listHostEntries = new System.Windows.Forms.ListBox();
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
            this.registryTitle = new System.Windows.Forms.Label();
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.itemnamegroup = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.security = new System.Windows.Forms.GroupBox();
            this.itemposition = new System.Windows.Forms.GroupBox();
            this.icontoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new System.Windows.Forms.GroupBox();
            this.btnBrowseItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.itemtype = new System.Windows.Forms.GroupBox();
            this.addItemL = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listDesktopItems = new System.Windows.Forms.ListBox();
            this.refreshIIB = new System.Windows.Forms.Button();
            this.removeDIB = new System.Windows.Forms.Button();
            this.removeAllIIB = new System.Windows.Forms.Button();
            this.removeIntegratorItemsL = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
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
            this.listCustomCommands = new System.Windows.Forms.ListBox();
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
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioCaramel = new System.Windows.Forms.RadioButton();
            this.radioZerg = new System.Windows.Forms.RadioButton();
            this.radioOcean = new System.Windows.Forms.RadioButton();
            this.radioMagma = new System.Windows.Forms.RadioButton();
            this.radioLime = new System.Windows.Forms.RadioButton();
            this.radioMinimal = new System.Windows.Forms.RadioButton();
            this.languagesL = new System.Windows.Forms.Label();
            this.lblUpdateDisabled = new System.Windows.Forms.Label();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.picFOSS = new System.Windows.Forms.PictureBox();
            this.picFSF = new System.Windows.Forms.PictureBox();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayRestartExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.helpBox = new System.Windows.Forms.ToolTip(this.components);
            this.txtFeedError = new System.Windows.Forms.Label();
            this.stickySw = new Optimizer.ToggleSwitch();
            this.smartScreenSw = new Optimizer.ToggleSwitch();
            this.faxSw = new Optimizer.ToggleSwitch();
            this.compatSw = new Optimizer.ToggleSwitch();
            this.officeTelemetrySw = new Optimizer.ToggleSwitch();
            this.telemetryTasksSw = new Optimizer.ToggleSwitch();
            this.superfetchSw = new Optimizer.ToggleSwitch();
            this.homegroupSw = new Optimizer.ToggleSwitch();
            this.reportingSw = new Optimizer.ToggleSwitch();
            this.mediaSharingSw = new Optimizer.ToggleSwitch();
            this.printSw = new Optimizer.ToggleSwitch();
            this.systemRestoreSw = new Optimizer.ToggleSwitch();
            this.performanceSw = new Optimizer.ToggleSwitch();
            this.defenderSw = new Optimizer.ToggleSwitch();
            this.networkSw = new Optimizer.ToggleSwitch();
            this.actionSw = new Optimizer.ToggleSwitch();
            this.castSw = new Optimizer.ToggleSwitch();
            this.longPathsSw = new Optimizer.ToggleSwitch();
            this.ccSw = new Optimizer.ToggleSwitch();
            this.featuresSw = new Optimizer.ToggleSwitch();
            this.insiderSw = new Optimizer.ToggleSwitch();
            this.darkSw = new Optimizer.ToggleSwitch();
            this.spellSw = new Optimizer.ToggleSwitch();
            this.inkSw = new Optimizer.ToggleSwitch();
            this.driversSw = new Optimizer.ToggleSwitch();
            this.sensorSw = new Optimizer.ToggleSwitch();
            this.privacySw = new Optimizer.ToggleSwitch();
            this.telemetryServicesSw = new Optimizer.ToggleSwitch();
            this.autoUpdatesSw = new Optimizer.ToggleSwitch();
            this.peopleSw = new Optimizer.ToggleSwitch();
            this.adsSw = new Optimizer.ToggleSwitch();
            this.colorBarSw = new Optimizer.ToggleSwitch();
            this.oldExplorerSw = new Optimizer.ToggleSwitch();
            this.xboxSw = new Optimizer.ToggleSwitch();
            this.cortanaSw = new Optimizer.ToggleSwitch();
            this.gameBarSw = new Optimizer.ToggleSwitch();
            this.uODSw = new Optimizer.ToggleSwitch();
            this.oldMixerSw = new Optimizer.ToggleSwitch();
            this.disableOneDriveSw = new Optimizer.ToggleSwitch();
            this.chkOnlyRemovable = new Optimizer.ColoredCheckBox();
            this.chkSelectAllModernApps = new Optimizer.ColoredCheckBox();
            this.cAutoInstall = new Optimizer.ColoredCheckBox();
            this.progressDownloader = new Optimizer.ColoredProgress();
            this.c64 = new Optimizer.ColoredRadioButton();
            this.c32 = new Optimizer.ColoredRadioButton();
            this.checkErrorReports = new Optimizer.ColoredCheckBox();
            this.checkSelectAll = new Optimizer.ColoredCheckBox();
            this.checkMediaCache = new Optimizer.ColoredCheckBox();
            this.checkTemp = new Optimizer.ColoredCheckBox();
            this.checkLogs = new Optimizer.ColoredCheckBox();
            this.checkBin = new Optimizer.ColoredCheckBox();
            this.checkMiniDumps = new Optimizer.ColoredCheckBox();
            this.chkReadOnly = new Optimizer.ColoredCheckBox();
            this.chkBlock = new Optimizer.ColoredCheckBox();
            this.checkRestartExplorer = new Optimizer.ColoredCheckBox();
            this.checkRegistryEditor = new Optimizer.ColoredCheckBox();
            this.checkEnableAll = new Optimizer.ColoredCheckBox();
            this.checkContextMenu = new Optimizer.ColoredCheckBox();
            this.checkTaskManager = new Optimizer.ColoredCheckBox();
            this.checkCommandPrompt = new Optimizer.ColoredCheckBox();
            this.checkFirewall = new Optimizer.ColoredCheckBox();
            this.checkRunDialog = new Optimizer.ColoredCheckBox();
            this.checkFolderOptions = new Optimizer.ColoredCheckBox();
            this.checkControlPanel = new Optimizer.ColoredCheckBox();
            this.checkShift = new Optimizer.ColoredCheckBox();
            this.radioTop = new Optimizer.ColoredRadioButton();
            this.radioMiddle = new Optimizer.ColoredRadioButton();
            this.radioBottom = new Optimizer.ColoredRadioButton();
            this.checkDefaultIcon = new Optimizer.ColoredCheckBox();
            this.radioCommand = new Optimizer.ColoredRadioButton();
            this.radioProgram = new Optimizer.ColoredRadioButton();
            this.radioFolder = new Optimizer.ColoredRadioButton();
            this.radioLink = new Optimizer.ColoredRadioButton();
            this.radioFile = new Optimizer.ColoredRadioButton();
            this.radioTurkish = new Optimizer.ColoredRadioButton();
            this.radioHellenic = new Optimizer.ColoredRadioButton();
            this.radioEnglish = new Optimizer.ColoredRadioButton();
            this.radioRussian = new Optimizer.ColoredRadioButton();
            this.helpTipsToggle = new Optimizer.ToggleSwitch();
            this.quickAccessToggle = new Optimizer.ToggleSwitch();
            this.tpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bpanel.SuspendLayout();
            this.tabCollection.SuspendLayout();
            this.universalTab.SuspendLayout();
            this.windowsXTab.SuspendLayout();
            this.windowsVIIITab.SuspendLayout();
            this.modernAppsTab.SuspendLayout();
            this.panelModernAppsList.SuspendLayout();
            this.startupTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.appsTab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCommonApps.SuspendLayout();
            this.cleanerTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pingerTab.SuspendLayout();
            this.panel7.SuspendLayout();
            this.hostsEditorTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelList.SuspendLayout();
            this.registryFixerTab.SuspendLayout();
            this.panel2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFOSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFSF)).BeginInit();
            this.launcherMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpanel
            // 
            this.tpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpanel.Controls.Add(this.txtNetFw);
            this.tpanel.Controls.Add(this.linkUpdate);
            this.tpanel.Controls.Add(this.lblLab);
            this.tpanel.Controls.Add(this.txtBitness);
            this.tpanel.Controls.Add(this.txtOS);
            this.tpanel.Controls.Add(this.txtVersion);
            this.tpanel.Controls.Add(this.pictureBox1);
            this.tpanel.Controls.Add(this.label2);
            this.tpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpanel.Location = new System.Drawing.Point(0, 0);
            this.tpanel.Margin = new System.Windows.Forms.Padding(2);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(939, 64);
            this.tpanel.TabIndex = 1;
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
            // linkUpdate
            // 
            this.linkUpdate.ActiveLinkColor = System.Drawing.Color.Goldenrod;
            this.linkUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkUpdate.ForeColor = System.Drawing.Color.Gold;
            this.linkUpdate.LinkColor = System.Drawing.Color.Gold;
            this.linkUpdate.Location = new System.Drawing.Point(607, 6);
            this.linkUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkUpdate.Name = "linkUpdate";
            this.linkUpdate.Size = new System.Drawing.Size(320, 50);
            this.linkUpdate.TabIndex = 69;
            this.linkUpdate.TabStop = true;
            this.linkUpdate.Tag = "";
            this.linkUpdate.Text = "Update available";
            this.linkUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkUpdate.Visible = false;
            this.linkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUpdate_LinkClicked);
            // 
            // lblLab
            // 
            this.lblLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLab.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab.ForeColor = System.Drawing.Color.Gold;
            this.lblLab.Location = new System.Drawing.Point(531, 6);
            this.lblLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(402, 50);
            this.lblLab.TabIndex = 68;
            this.lblLab.Text = "EXPERIMENTAL BUILD\r\n(delete after testing)";
            this.lblLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLab.Visible = false;
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
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
            this.bpanel.Size = new System.Drawing.Size(939, 641);
            this.bpanel.TabIndex = 2;
            // 
            // tabCollection
            // 
            this.tabCollection.Controls.Add(this.universalTab);
            this.tabCollection.Controls.Add(this.windowsXTab);
            this.tabCollection.Controls.Add(this.windowsVIIITab);
            this.tabCollection.Controls.Add(this.modernAppsTab);
            this.tabCollection.Controls.Add(this.startupTab);
            this.tabCollection.Controls.Add(this.appsTab);
            this.tabCollection.Controls.Add(this.cleanerTab);
            this.tabCollection.Controls.Add(this.pingerTab);
            this.tabCollection.Controls.Add(this.hostsEditorTab);
            this.tabCollection.Controls.Add(this.registryFixerTab);
            this.tabCollection.Controls.Add(this.integratorTab);
            this.tabCollection.Controls.Add(this.optionsTab);
            this.tabCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(2);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(937, 639);
            this.tabCollection.TabIndex = 0;
            this.tabCollection.SelectedIndexChanged += new System.EventHandler(this.aio_SelectedIndexChanged);
            // 
            // universalTab
            // 
            this.universalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.universalTab.Controls.Add(this.stickySw);
            this.universalTab.Controls.Add(this.smartScreenSw);
            this.universalTab.Controls.Add(this.faxSw);
            this.universalTab.Controls.Add(this.compatSw);
            this.universalTab.Controls.Add(this.officeTelemetrySw);
            this.universalTab.Controls.Add(this.telemetryTasksSw);
            this.universalTab.Controls.Add(this.superfetchSw);
            this.universalTab.Controls.Add(this.homegroupSw);
            this.universalTab.Controls.Add(this.reportingSw);
            this.universalTab.Controls.Add(this.mediaSharingSw);
            this.universalTab.Controls.Add(this.printSw);
            this.universalTab.Controls.Add(this.systemRestoreSw);
            this.universalTab.Controls.Add(this.performanceSw);
            this.universalTab.Controls.Add(this.defenderSw);
            this.universalTab.Controls.Add(this.networkSw);
            this.universalTab.Controls.Add(this.restartButton);
            this.universalTab.Location = new System.Drawing.Point(4, 24);
            this.universalTab.Margin = new System.Windows.Forms.Padding(2);
            this.universalTab.Name = "universalTab";
            this.universalTab.Padding = new System.Windows.Forms.Padding(2);
            this.universalTab.Size = new System.Drawing.Size(929, 611);
            this.universalTab.TabIndex = 0;
            this.universalTab.Text = "Universal";
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(14, 310);
            this.restartButton.Margin = new System.Windows.Forms.Padding(2);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(115, 31);
            this.restartButton.TabIndex = 30;
            this.restartButton.Text = "Apply && Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.button39_Click);
            // 
            // windowsXTab
            // 
            this.windowsXTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windowsXTab.Controls.Add(this.restartButton10);
            this.windowsXTab.Controls.Add(this.actionSw);
            this.windowsXTab.Controls.Add(this.castSw);
            this.windowsXTab.Controls.Add(this.longPathsSw);
            this.windowsXTab.Controls.Add(this.ccSw);
            this.windowsXTab.Controls.Add(this.featuresSw);
            this.windowsXTab.Controls.Add(this.insiderSw);
            this.windowsXTab.Controls.Add(this.darkSw);
            this.windowsXTab.Controls.Add(this.spellSw);
            this.windowsXTab.Controls.Add(this.inkSw);
            this.windowsXTab.Controls.Add(this.driversSw);
            this.windowsXTab.Controls.Add(this.sensorSw);
            this.windowsXTab.Controls.Add(this.privacySw);
            this.windowsXTab.Controls.Add(this.telemetryServicesSw);
            this.windowsXTab.Controls.Add(this.autoUpdatesSw);
            this.windowsXTab.Controls.Add(this.peopleSw);
            this.windowsXTab.Controls.Add(this.adsSw);
            this.windowsXTab.Controls.Add(this.colorBarSw);
            this.windowsXTab.Controls.Add(this.oldExplorerSw);
            this.windowsXTab.Controls.Add(this.xboxSw);
            this.windowsXTab.Controls.Add(this.cortanaSw);
            this.windowsXTab.Controls.Add(this.gameBarSw);
            this.windowsXTab.Controls.Add(this.uODSw);
            this.windowsXTab.Controls.Add(this.oldMixerSw);
            this.windowsXTab.Location = new System.Drawing.Point(4, 24);
            this.windowsXTab.Margin = new System.Windows.Forms.Padding(2);
            this.windowsXTab.Name = "windowsXTab";
            this.windowsXTab.Padding = new System.Windows.Forms.Padding(2);
            this.windowsXTab.Size = new System.Drawing.Size(929, 611);
            this.windowsXTab.TabIndex = 1;
            this.windowsXTab.Text = "Windows 10";
            // 
            // restartButton10
            // 
            this.restartButton10.AutoSize = true;
            this.restartButton10.BackColor = System.Drawing.Color.DodgerBlue;
            this.restartButton10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.restartButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton10.ForeColor = System.Drawing.Color.White;
            this.restartButton10.Location = new System.Drawing.Point(14, 457);
            this.restartButton10.Margin = new System.Windows.Forms.Padding(2);
            this.restartButton10.Name = "restartButton10";
            this.restartButton10.Size = new System.Drawing.Size(115, 31);
            this.restartButton10.TabIndex = 31;
            this.restartButton10.Text = "Apply && Restart";
            this.restartButton10.UseVisualStyleBackColor = false;
            this.restartButton10.Click += new System.EventHandler(this.button43_Click);
            // 
            // windowsVIIITab
            // 
            this.windowsVIIITab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windowsVIIITab.Controls.Add(this.disableOneDriveSw);
            this.windowsVIIITab.Controls.Add(this.restartButton8);
            this.windowsVIIITab.Location = new System.Drawing.Point(4, 24);
            this.windowsVIIITab.Margin = new System.Windows.Forms.Padding(2);
            this.windowsVIIITab.Name = "windowsVIIITab";
            this.windowsVIIITab.Padding = new System.Windows.Forms.Padding(2);
            this.windowsVIIITab.Size = new System.Drawing.Size(929, 611);
            this.windowsVIIITab.TabIndex = 2;
            this.windowsVIIITab.Text = "Windows 8.1";
            // 
            // restartButton8
            // 
            this.restartButton8.AutoSize = true;
            this.restartButton8.BackColor = System.Drawing.Color.DodgerBlue;
            this.restartButton8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.restartButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restartButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton8.ForeColor = System.Drawing.Color.White;
            this.restartButton8.Location = new System.Drawing.Point(14, 65);
            this.restartButton8.Margin = new System.Windows.Forms.Padding(2);
            this.restartButton8.Name = "restartButton8";
            this.restartButton8.Size = new System.Drawing.Size(115, 31);
            this.restartButton8.TabIndex = 32;
            this.restartButton8.Text = "Apply && Restart";
            this.restartButton8.UseVisualStyleBackColor = false;
            this.restartButton8.Click += new System.EventHandler(this.button44_Click);
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
            this.modernAppsTab.Location = new System.Drawing.Point(4, 24);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(3);
            this.modernAppsTab.Size = new System.Drawing.Size(929, 611);
            this.modernAppsTab.TabIndex = 11;
            this.modernAppsTab.Text = "UWP Apps";
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
            this.uninstallModernAppsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.refreshModernAppsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.startupTab.Location = new System.Drawing.Point(4, 24);
            this.startupTab.Margin = new System.Windows.Forms.Padding(2);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(929, 611);
            this.startupTab.TabIndex = 7;
            this.startupTab.Text = "Startup";
            // 
            // cancelBackup
            // 
            this.cancelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.ForeColor = System.Drawing.Color.White;
            this.cancelBackup.Location = new System.Drawing.Point(432, 522);
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
            this.doBackup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.doBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doBackup.ForeColor = System.Drawing.Color.White;
            this.doBackup.Location = new System.Drawing.Point(338, 522);
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
            this.txtBackupTitle.Location = new System.Drawing.Point(11, 522);
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
            this.lblBackupTitle.Location = new System.Drawing.Point(7, 501);
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
            this.restoreStartupB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.restoreStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreStartupB.ForeColor = System.Drawing.Color.White;
            this.restoreStartupB.Location = new System.Drawing.Point(175, 502);
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
            this.backupStartupB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.backupStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupStartupB.ForeColor = System.Drawing.Color.White;
            this.backupStartupB.Location = new System.Drawing.Point(11, 502);
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
            this.findInRegB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.findInRegB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findInRegB.ForeColor = System.Drawing.Color.White;
            this.findInRegB.Location = new System.Drawing.Point(521, 537);
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
            this.locateFileB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.locateFileB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locateFileB.ForeColor = System.Drawing.Color.White;
            this.locateFileB.Location = new System.Drawing.Point(521, 502);
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
            this.refreshStartupB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.refreshStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshStartupB.ForeColor = System.Drawing.Color.White;
            this.refreshStartupB.Location = new System.Drawing.Point(685, 537);
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
            this.panel3.Size = new System.Drawing.Size(834, 459);
            this.panel3.TabIndex = 37;
            // 
            // listStartupItems
            // 
            this.listStartupItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listStartupItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listStartupItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listStartupItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStartupItems.ForeColor = System.Drawing.Color.White;
            this.listStartupItems.FullRowSelect = true;
            this.listStartupItems.HideSelection = false;
            this.listStartupItems.Location = new System.Drawing.Point(0, 0);
            this.listStartupItems.Margin = new System.Windows.Forms.Padding(2);
            this.listStartupItems.MultiSelect = false;
            this.listStartupItems.Name = "listStartupItems";
            this.listStartupItems.ShowGroups = false;
            this.listStartupItems.Size = new System.Drawing.Size(832, 457);
            this.listStartupItems.TabIndex = 0;
            this.listStartupItems.UseCompatibleStateImageBehavior = false;
            this.listStartupItems.View = System.Windows.Forms.View.Details;
            this.listStartupItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listStartupItems_ColumnClick);
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
            this.removeStartupItemB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeStartupItemB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStartupItemB.ForeColor = System.Drawing.Color.White;
            this.removeStartupItemB.Location = new System.Drawing.Point(685, 502);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(2);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(160, 31);
            this.removeStartupItemB.TabIndex = 36;
            this.removeStartupItemB.Text = "Remove";
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
            this.appsTab.Location = new System.Drawing.Point(4, 24);
            this.appsTab.Name = "appsTab";
            this.appsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appsTab.Size = new System.Drawing.Size(929, 611);
            this.appsTab.TabIndex = 12;
            this.appsTab.Text = "Common Apps";
            // 
            // lblVideoSound
            // 
            this.lblVideoSound.AutoSize = true;
            this.lblVideoSound.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoSound.ForeColor = System.Drawing.Color.Silver;
            this.lblVideoSound.Location = new System.Drawing.Point(703, 46);
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
            this.lblCoding.Location = new System.Drawing.Point(499, 46);
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
            this.groupSoundVideo.Location = new System.Drawing.Point(706, 64);
            this.groupSoundVideo.Name = "groupSoundVideo";
            this.groupSoundVideo.Size = new System.Drawing.Size(211, 421);
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
            this.groupCoding.Location = new System.Drawing.Point(502, 64);
            this.groupCoding.Name = "groupCoding";
            this.groupCoding.Size = new System.Drawing.Size(198, 421);
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
            this.groupInternet.Size = new System.Drawing.Size(231, 421);
            this.groupInternet.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(923, 44);
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
            this.btnGetFeed.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGetFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFeed.ForeColor = System.Drawing.Color.White;
            this.btnGetFeed.Location = new System.Drawing.Point(777, 6);
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
            this.panelCommonApps.Location = new System.Drawing.Point(3, 488);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(923, 120);
            this.panelCommonApps.TabIndex = 162;
            // 
            // btnDownloadApps
            // 
            this.btnDownloadApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadApps.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadApps.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadApps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadApps.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadApps.ForeColor = System.Drawing.Color.White;
            this.btnDownloadApps.Location = new System.Drawing.Point(778, 84);
            this.btnDownloadApps.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadApps.Name = "btnDownloadApps";
            this.btnDownloadApps.Size = new System.Drawing.Size(143, 35);
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
            this.setDownDirLbl.Location = new System.Drawing.Point(6, 4);
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
            this.txtDownloadFolder.Location = new System.Drawing.Point(11, 30);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(302, 23);
            this.txtDownloadFolder.TabIndex = 70;
            this.txtDownloadFolder.TextChanged += new System.EventHandler(this.txtDownloadFolder_TextChanged);
            // 
            // changeDownDirB
            // 
            this.changeDownDirB.BackColor = System.Drawing.Color.DodgerBlue;
            this.changeDownDirB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.changeDownDirB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.changeDownDirB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.changeDownDirB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDownDirB.ForeColor = System.Drawing.Color.White;
            this.changeDownDirB.Location = new System.Drawing.Point(316, 30);
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
            this.txtDownloadStatus.Location = new System.Drawing.Point(7, 58);
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
            this.linkWarnings.Location = new System.Drawing.Point(7, 98);
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
            this.bitPref.Location = new System.Drawing.Point(368, 6);
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
            this.goToDownloadsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.goToDownloadsB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.goToDownloadsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDownloadsB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToDownloadsB.ForeColor = System.Drawing.Color.White;
            this.goToDownloadsB.Location = new System.Drawing.Point(631, 84);
            this.goToDownloadsB.Margin = new System.Windows.Forms.Padding(2);
            this.goToDownloadsB.Name = "goToDownloadsB";
            this.goToDownloadsB.Size = new System.Drawing.Size(143, 35);
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
            this.cleanerTab.Location = new System.Drawing.Point(4, 24);
            this.cleanerTab.Margin = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Size = new System.Drawing.Size(929, 611);
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
            this.panel1.Controls.Add(this.lblPretext);
            this.panel1.Controls.Add(this.lblFootprint);
            this.panel1.Controls.Add(this.checkErrorReports);
            this.panel1.Controls.Add(this.cleanDriveB);
            this.panel1.Controls.Add(this.checkSelectAll);
            this.panel1.Controls.Add(this.checkMediaCache);
            this.panel1.Controls.Add(this.checkTemp);
            this.panel1.Controls.Add(this.checkLogs);
            this.panel1.Controls.Add(this.checkBin);
            this.panel1.Controls.Add(this.checkMiniDumps);
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 333);
            this.panel1.TabIndex = 45;
            // 
            // lblPretext
            // 
            this.lblPretext.AutoSize = true;
            this.lblPretext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretext.ForeColor = System.Drawing.Color.Silver;
            this.lblPretext.Location = new System.Drawing.Point(29, 229);
            this.lblPretext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretext.Name = "lblPretext";
            this.lblPretext.Size = new System.Drawing.Size(123, 21);
            this.lblPretext.TabIndex = 49;
            this.lblPretext.Tag = "";
            this.lblPretext.Text = "Size to be freed:";
            this.lblPretext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFootprint
            // 
            this.lblFootprint.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootprint.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFootprint.Location = new System.Drawing.Point(30, 250);
            this.lblFootprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFootprint.Name = "lblFootprint";
            this.lblFootprint.Size = new System.Drawing.Size(119, 31);
            this.lblFootprint.TabIndex = 48;
            this.lblFootprint.Tag = "themeable";
            this.lblFootprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cleanDriveB
            // 
            this.cleanDriveB.BackColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cleanDriveB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cleanDriveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanDriveB.ForeColor = System.Drawing.Color.White;
            this.cleanDriveB.Location = new System.Drawing.Point(29, 196);
            this.cleanDriveB.Margin = new System.Windows.Forms.Padding(2);
            this.cleanDriveB.Name = "cleanDriveB";
            this.cleanDriveB.Size = new System.Drawing.Size(120, 31);
            this.cleanDriveB.TabIndex = 34;
            this.cleanDriveB.Text = "Clean";
            this.cleanDriveB.UseVisualStyleBackColor = false;
            this.cleanDriveB.Click += new System.EventHandler(this.button20_Click);
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
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
            this.pingerTab.Location = new System.Drawing.Point(4, 24);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(3);
            this.pingerTab.Size = new System.Drawing.Size(929, 611);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // flushCacheB
            // 
            this.flushCacheB.BackColor = System.Drawing.Color.DodgerBlue;
            this.flushCacheB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.flushCacheB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.flushCacheB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flushCacheB.ForeColor = System.Drawing.Color.White;
            this.flushCacheB.Location = new System.Drawing.Point(26, 512);
            this.flushCacheB.Margin = new System.Windows.Forms.Padding(2);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(177, 29);
            this.flushCacheB.TabIndex = 84;
            this.flushCacheB.Text = "Flush DNS cache";
            this.flushCacheB.UseVisualStyleBackColor = false;
            this.flushCacheB.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(463, 512);
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
            this.copyB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.copyIPB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.listPingResults.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnShodan.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.btnPing.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.hostsEditorTab.Location = new System.Drawing.Point(4, 24);
            this.hostsEditorTab.Margin = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Name = "hostsEditorTab";
            this.hostsEditorTab.Padding = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Size = new System.Drawing.Size(929, 611);
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
            this.panel4.Size = new System.Drawing.Size(848, 535);
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
            this.linkRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRestoreDefault.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRestoreDefault.ForeColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.Location = new System.Drawing.Point(354, 514);
            this.linkRestoreDefault.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRestoreDefault.Name = "linkRestoreDefault";
            this.linkRestoreDefault.Size = new System.Drawing.Size(494, 21);
            this.linkRestoreDefault.TabIndex = 51;
            this.linkRestoreDefault.TabStop = true;
            this.linkRestoreDefault.Tag = "";
            this.linkRestoreDefault.Text = "Restore default";
            this.linkRestoreDefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkRestoreDefault.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkRestoreDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // adblockUlti
            // 
            this.adblockUlti.BackColor = System.Drawing.Color.DodgerBlue;
            this.adblockUlti.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.adblockP.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.adblockS.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.adblockBasic.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            // panelList
            // 
            this.panelList.Controls.Add(this.listHostEntries);
            this.panelList.Location = new System.Drawing.Point(5, 3);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(312, 388);
            this.panelList.TabIndex = 60;
            // 
            // listHostEntries
            // 
            this.listHostEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listHostEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listHostEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHostEntries.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHostEntries.ForeColor = System.Drawing.Color.White;
            this.listHostEntries.FormattingEnabled = true;
            this.listHostEntries.HorizontalScrollbar = true;
            this.listHostEntries.ItemHeight = 21;
            this.listHostEntries.Location = new System.Drawing.Point(0, 0);
            this.listHostEntries.Margin = new System.Windows.Forms.Padding(2);
            this.listHostEntries.Name = "listHostEntries";
            this.listHostEntries.Size = new System.Drawing.Size(312, 388);
            this.listHostEntries.TabIndex = 52;
            // 
            // refreshHostsB
            // 
            this.refreshHostsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshHostsB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.removeHostB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeHostB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeHostB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeHostB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeHostB.ForeColor = System.Drawing.Color.White;
            this.removeHostB.Location = new System.Drawing.Point(161, 395);
            this.removeHostB.Margin = new System.Windows.Forms.Padding(2);
            this.removeHostB.Name = "removeHostB";
            this.removeHostB.Size = new System.Drawing.Size(156, 31);
            this.removeHostB.TabIndex = 54;
            this.removeHostB.Text = "Remove";
            this.removeHostB.UseVisualStyleBackColor = false;
            this.removeHostB.Click += new System.EventHandler(this.button42_Click);
            // 
            // removeAllHostsB
            // 
            this.removeAllHostsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeAllHostsB.Enabled = false;
            this.removeAllHostsB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeAllHostsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllHostsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllHostsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllHostsB.ForeColor = System.Drawing.Color.White;
            this.removeAllHostsB.Location = new System.Drawing.Point(161, 430);
            this.removeAllHostsB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllHostsB.Name = "removeAllHostsB";
            this.removeAllHostsB.Size = new System.Drawing.Size(156, 31);
            this.removeAllHostsB.TabIndex = 53;
            this.removeAllHostsB.Text = "Remove all";
            this.removeAllHostsB.UseVisualStyleBackColor = false;
            this.removeAllHostsB.Visible = false;
            this.removeAllHostsB.Click += new System.EventHandler(this.button46_Click);
            // 
            // addHostB
            // 
            this.addHostB.BackColor = System.Drawing.Color.DodgerBlue;
            this.addHostB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.registryFixerTab.Location = new System.Drawing.Point(4, 24);
            this.registryFixerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Name = "registryFixerTab";
            this.registryFixerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Size = new System.Drawing.Size(929, 611);
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
            this.regFixB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.regLbl.Location = new System.Drawing.Point(94, 202);
            this.regLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(236, 21);
            this.regLbl.TabIndex = 51;
            this.regLbl.Tag = "";
            this.regLbl.Text = "(some changes might need this)";
            this.regLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // integratorTab
            // 
            this.integratorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.integratorTab.Controls.Add(this.synapse);
            this.integratorTab.Location = new System.Drawing.Point(4, 24);
            this.integratorTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorTab.Name = "integratorTab";
            this.integratorTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorTab.Size = new System.Drawing.Size(929, 611);
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
            this.synapse.SelectedIndex = 0;
            this.synapse.Size = new System.Drawing.Size(925, 609);
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
            this.integratorInfoTab.Size = new System.Drawing.Size(917, 581);
            this.integratorInfoTab.TabIndex = 0;
            this.integratorInfoTab.Text = "Info";
            // 
            // integrator7
            // 
            this.integrator7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator7.ForeColor = System.Drawing.Color.Silver;
            this.integrator7.Location = new System.Drawing.Point(6, 225);
            this.integrator7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator7.Name = "integrator7";
            this.integrator7.Size = new System.Drawing.Size(763, 233);
            this.integrator7.TabIndex = 10;
            this.integrator7.Tag = "";
            this.integrator7.Text = resources.GetString("integrator7.Text");
            // 
            // integrator6
            // 
            this.integrator6.AutoSize = true;
            this.integrator6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator6.ForeColor = System.Drawing.Color.Silver;
            this.integrator6.Location = new System.Drawing.Point(38, 183);
            this.integrator6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator6.Name = "integrator6";
            this.integrator6.Size = new System.Drawing.Size(122, 25);
            this.integrator6.TabIndex = 9;
            this.integrator6.Tag = "";
            this.integrator6.Text = "• Commands";
            // 
            // integrator5
            // 
            this.integrator5.AutoSize = true;
            this.integrator5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator5.ForeColor = System.Drawing.Color.Silver;
            this.integrator5.Location = new System.Drawing.Point(38, 158);
            this.integrator5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator5.Name = "integrator5";
            this.integrator5.Size = new System.Drawing.Size(157, 25);
            this.integrator5.TabIndex = 8;
            this.integrator5.Tag = "";
            this.integrator5.Text = "• Any type of file";
            // 
            // integrator4
            // 
            this.integrator4.AutoSize = true;
            this.integrator4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator4.ForeColor = System.Drawing.Color.Silver;
            this.integrator4.Location = new System.Drawing.Point(38, 132);
            this.integrator4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator4.Name = "integrator4";
            this.integrator4.Size = new System.Drawing.Size(181, 25);
            this.integrator4.TabIndex = 7;
            this.integrator4.Tag = "";
            this.integrator4.Text = "• Links to webpages";
            // 
            // integrator3
            // 
            this.integrator3.AutoSize = true;
            this.integrator3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator3.ForeColor = System.Drawing.Color.Silver;
            this.integrator3.Location = new System.Drawing.Point(38, 106);
            this.integrator3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator3.Name = "integrator3";
            this.integrator3.Size = new System.Drawing.Size(194, 25);
            this.integrator3.TabIndex = 6;
            this.integrator3.Tag = "";
            this.integrator3.Text = "• Shortcuts to folders";
            // 
            // integrator2
            // 
            this.integrator2.AutoSize = true;
            this.integrator2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator2.ForeColor = System.Drawing.Color.Silver;
            this.integrator2.Location = new System.Drawing.Point(38, 81);
            this.integrator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator2.Name = "integrator2";
            this.integrator2.Size = new System.Drawing.Size(138, 25);
            this.integrator2.TabIndex = 5;
            this.integrator2.Tag = "";
            this.integrator2.Text = "• Any program";
            // 
            // integrator1
            // 
            this.integrator1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator1.ForeColor = System.Drawing.Color.Silver;
            this.integrator1.Location = new System.Drawing.Point(6, 10);
            this.integrator1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator1.Name = "integrator1";
            this.integrator1.Size = new System.Drawing.Size(419, 61);
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
            this.tabPage8.Size = new System.Drawing.Size(917, 581);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Add/Modify";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowseIcon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseIcon.Enabled = false;
            this.btnBrowseIcon.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.btnBrowseItem.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.tabPage9.Size = new System.Drawing.Size(917, 581);
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
            this.listDesktopItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.refreshIIB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.removeDIB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeDIB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeDIB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeDIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeDIB.ForeColor = System.Drawing.Color.White;
            this.removeDIB.Location = new System.Drawing.Point(308, 45);
            this.removeDIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeDIB.Name = "removeDIB";
            this.removeDIB.Size = new System.Drawing.Size(137, 31);
            this.removeDIB.TabIndex = 80;
            this.removeDIB.Text = "Remove";
            this.removeDIB.UseVisualStyleBackColor = false;
            this.removeDIB.Click += new System.EventHandler(this.button61_Click);
            // 
            // removeAllIIB
            // 
            this.removeAllIIB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeAllIIB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeAllIIB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllIIB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeAllIIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllIIB.ForeColor = System.Drawing.Color.White;
            this.removeAllIIB.Location = new System.Drawing.Point(308, 115);
            this.removeAllIIB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllIIB.Name = "removeAllIIB";
            this.removeAllIIB.Size = new System.Drawing.Size(137, 31);
            this.removeAllIIB.TabIndex = 79;
            this.removeAllIIB.Text = "Remove all";
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
            this.tabPage10.Size = new System.Drawing.Size(917, 581);
            this.tabPage10.TabIndex = 3;
            this.tabPage10.Text = "Ready Menus";
            // 
            // RemoveOwnerB
            // 
            this.RemoveOwnerB.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveOwnerB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.RemoveOwnerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.RemoveOwnerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.RemoveOwnerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveOwnerB.ForeColor = System.Drawing.Color.White;
            this.RemoveOwnerB.Location = new System.Drawing.Point(11, 276);
            this.RemoveOwnerB.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveOwnerB.Name = "RemoveOwnerB";
            this.RemoveOwnerB.Size = new System.Drawing.Size(334, 31);
            this.RemoveOwnerB.TabIndex = 78;
            this.RemoveOwnerB.Text = "Remove \"Take Ownership\"";
            this.RemoveOwnerB.UseVisualStyleBackColor = false;
            this.RemoveOwnerB.Click += new System.EventHandler(this.button65_Click);
            // 
            // AddOwnerB
            // 
            this.AddOwnerB.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddOwnerB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.PMB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.DSB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.STB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.SSB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.WAB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.tabPage11.Size = new System.Drawing.Size(917, 581);
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
            this.panel6.Size = new System.Drawing.Size(271, 263);
            this.panel6.TabIndex = 84;
            // 
            // listCustomCommands
            // 
            this.listCustomCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listCustomCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCustomCommands.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomCommands.ForeColor = System.Drawing.Color.White;
            this.listCustomCommands.FormattingEnabled = true;
            this.listCustomCommands.HorizontalScrollbar = true;
            this.listCustomCommands.ItemHeight = 21;
            this.listCustomCommands.Location = new System.Drawing.Point(0, 0);
            this.listCustomCommands.Margin = new System.Windows.Forms.Padding(2);
            this.listCustomCommands.Name = "listCustomCommands";
            this.listCustomCommands.Size = new System.Drawing.Size(269, 261);
            this.listCustomCommands.TabIndex = 79;
            // 
            // removeCCB
            // 
            this.removeCCB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeCCB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.removeCCB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeCCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeCCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCCB.ForeColor = System.Drawing.Color.White;
            this.removeCCB.Location = new System.Drawing.Point(286, 210);
            this.removeCCB.Margin = new System.Windows.Forms.Padding(2);
            this.removeCCB.Name = "removeCCB";
            this.removeCCB.Size = new System.Drawing.Size(120, 27);
            this.removeCCB.TabIndex = 82;
            this.removeCCB.Text = "Remove";
            this.removeCCB.UseVisualStyleBackColor = false;
            this.removeCCB.Click += new System.EventHandler(this.button26_Click);
            // 
            // refreshCCB
            // 
            this.refreshCCB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshCCB.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.removeCCL.Size = new System.Drawing.Size(268, 28);
            this.removeCCL.TabIndex = 80;
            this.removeCCL.Tag = "themeable";
            this.removeCCL.Text = "Remove existing commands";
            // 
            // btnCreateCustomCommand
            // 
            this.btnCreateCustomCommand.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateCustomCommand.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.button48.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
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
            this.optionsTab.Controls.Add(this.pictureBox85);
            this.optionsTab.Controls.Add(this.panel9);
            this.optionsTab.Controls.Add(this.panel8);
            this.optionsTab.Controls.Add(this.languagesL);
            this.optionsTab.Controls.Add(this.lblUpdateDisabled);
            this.optionsTab.Controls.Add(this.linkLabel6);
            this.optionsTab.Controls.Add(this.picFOSS);
            this.optionsTab.Controls.Add(this.picFSF);
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
            this.optionsTab.Controls.Add(this.helpTipsToggle);
            this.optionsTab.Controls.Add(this.quickAccessToggle);
            this.optionsTab.Location = new System.Drawing.Point(4, 24);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(2);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(2);
            this.optionsTab.Size = new System.Drawing.Size(929, 611);
            this.optionsTab.TabIndex = 6;
            this.optionsTab.Text = "Options";
            // 
            // pictureBox85
            // 
            this.pictureBox85.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox85.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox85.Image")));
            this.pictureBox85.Location = new System.Drawing.Point(884, 11);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(33, 32);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 74;
            this.pictureBox85.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.pictureBox89);
            this.panel9.Controls.Add(this.radioTurkish);
            this.panel9.Controls.Add(this.pictureBox88);
            this.panel9.Controls.Add(this.radioHellenic);
            this.panel9.Controls.Add(this.pictureBox87);
            this.panel9.Controls.Add(this.radioEnglish);
            this.panel9.Controls.Add(this.radioRussian);
            this.panel9.Controls.Add(this.pictureBox86);
            this.panel9.Location = new System.Drawing.Point(637, 46);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(285, 205);
            this.panel9.TabIndex = 73;
            // 
            // pictureBox89
            // 
            this.pictureBox89.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox89.Image")));
            this.pictureBox89.Location = new System.Drawing.Point(110, 96);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(36, 22);
            this.pictureBox89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox89.TabIndex = 79;
            this.pictureBox89.TabStop = false;
            this.pictureBox89.Click += new System.EventHandler(this.pictureBox89_Click);
            // 
            // pictureBox88
            // 
            this.pictureBox88.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox88.Image")));
            this.pictureBox88.Location = new System.Drawing.Point(110, 67);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(36, 22);
            this.pictureBox88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox88.TabIndex = 77;
            this.pictureBox88.TabStop = false;
            this.pictureBox88.Click += new System.EventHandler(this.pictureBox88_Click);
            // 
            // pictureBox87
            // 
            this.pictureBox87.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox87.Image")));
            this.pictureBox87.Location = new System.Drawing.Point(110, 38);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(36, 22);
            this.pictureBox87.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox87.TabIndex = 76;
            this.pictureBox87.TabStop = false;
            this.pictureBox87.Click += new System.EventHandler(this.pictureBox87_Click);
            // 
            // pictureBox86
            // 
            this.pictureBox86.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox86.Image")));
            this.pictureBox86.Location = new System.Drawing.Point(110, 9);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(36, 22);
            this.pictureBox86.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox86.TabIndex = 75;
            this.pictureBox86.TabStop = false;
            this.pictureBox86.Click += new System.EventHandler(this.pictureBox86_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.radioCaramel);
            this.panel8.Controls.Add(this.radioZerg);
            this.panel8.Controls.Add(this.radioOcean);
            this.panel8.Controls.Add(this.radioMagma);
            this.panel8.Controls.Add(this.radioLime);
            this.panel8.Controls.Add(this.radioMinimal);
            this.panel8.Location = new System.Drawing.Point(16, 130);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(326, 118);
            this.panel8.TabIndex = 72;
            // 
            // radioCaramel
            // 
            this.radioCaramel.AutoSize = true;
            this.radioCaramel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCaramel.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioCaramel.Location = new System.Drawing.Point(163, 11);
            this.radioCaramel.Margin = new System.Windows.Forms.Padding(2);
            this.radioCaramel.Name = "radioCaramel";
            this.radioCaramel.Size = new System.Drawing.Size(87, 25);
            this.radioCaramel.TabIndex = 52;
            this.radioCaramel.Text = "Caramel";
            this.radioCaramel.UseVisualStyleBackColor = true;
            this.radioCaramel.CheckedChanged += new System.EventHandler(this.radioCaramel_CheckedChanged);
            // 
            // radioZerg
            // 
            this.radioZerg.AutoSize = true;
            this.radioZerg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioZerg.ForeColor = System.Drawing.Color.MediumOrchid;
            this.radioZerg.Location = new System.Drawing.Point(15, 69);
            this.radioZerg.Margin = new System.Windows.Forms.Padding(2);
            this.radioZerg.Name = "radioZerg";
            this.radioZerg.Size = new System.Drawing.Size(62, 25);
            this.radioZerg.TabIndex = 48;
            this.radioZerg.Text = "Zerg";
            this.radioZerg.UseVisualStyleBackColor = true;
            this.radioZerg.CheckedChanged += new System.EventHandler(this.radioZerg_CheckedChanged);
            // 
            // radioOcean
            // 
            this.radioOcean.AutoSize = true;
            this.radioOcean.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioOcean.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioOcean.Location = new System.Drawing.Point(15, 11);
            this.radioOcean.Margin = new System.Windows.Forms.Padding(2);
            this.radioOcean.Name = "radioOcean";
            this.radioOcean.Size = new System.Drawing.Size(74, 25);
            this.radioOcean.TabIndex = 49;
            this.radioOcean.Text = "Ocean";
            this.radioOcean.UseVisualStyleBackColor = true;
            this.radioOcean.CheckedChanged += new System.EventHandler(this.radioOcean_CheckedChanged);
            // 
            // radioMagma
            // 
            this.radioMagma.AutoSize = true;
            this.radioMagma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMagma.ForeColor = System.Drawing.Color.Tomato;
            this.radioMagma.Location = new System.Drawing.Point(15, 40);
            this.radioMagma.Margin = new System.Windows.Forms.Padding(2);
            this.radioMagma.Name = "radioMagma";
            this.radioMagma.Size = new System.Drawing.Size(83, 25);
            this.radioMagma.TabIndex = 50;
            this.radioMagma.Text = "Magma";
            this.radioMagma.UseVisualStyleBackColor = true;
            this.radioMagma.CheckedChanged += new System.EventHandler(this.radioMagma_CheckedChanged);
            // 
            // radioLime
            // 
            this.radioLime.AutoSize = true;
            this.radioLime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLime.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioLime.Location = new System.Drawing.Point(163, 40);
            this.radioLime.Margin = new System.Windows.Forms.Padding(2);
            this.radioLime.Name = "radioLime";
            this.radioLime.Size = new System.Drawing.Size(63, 25);
            this.radioLime.TabIndex = 51;
            this.radioLime.Text = "Lime";
            this.radioLime.UseVisualStyleBackColor = true;
            this.radioLime.CheckedChanged += new System.EventHandler(this.radioLime_CheckedChanged);
            // 
            // radioMinimal
            // 
            this.radioMinimal.AutoSize = true;
            this.radioMinimal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMinimal.ForeColor = System.Drawing.Color.Gray;
            this.radioMinimal.Location = new System.Drawing.Point(163, 69);
            this.radioMinimal.Margin = new System.Windows.Forms.Padding(2);
            this.radioMinimal.Name = "radioMinimal";
            this.radioMinimal.Size = new System.Drawing.Size(86, 25);
            this.radioMinimal.TabIndex = 53;
            this.radioMinimal.Text = "Minimal";
            this.radioMinimal.UseVisualStyleBackColor = true;
            this.radioMinimal.CheckedChanged += new System.EventHandler(this.radioMinimal_CheckedChanged);
            // 
            // languagesL
            // 
            this.languagesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesL.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.languagesL.Location = new System.Drawing.Point(637, 9);
            this.languagesL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.languagesL.Name = "languagesL";
            this.languagesL.Size = new System.Drawing.Size(246, 28);
            this.languagesL.TabIndex = 71;
            this.languagesL.Tag = "themeable";
            this.languagesL.Text = "Choose language";
            this.languagesL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUpdateDisabled
            // 
            this.lblUpdateDisabled.AutoSize = true;
            this.lblUpdateDisabled.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDisabled.ForeColor = System.Drawing.Color.Gold;
            this.lblUpdateDisabled.Location = new System.Drawing.Point(28, 358);
            this.lblUpdateDisabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateDisabled.Name = "lblUpdateDisabled";
            this.lblUpdateDisabled.Size = new System.Drawing.Size(239, 21);
            this.lblUpdateDisabled.TabIndex = 69;
            this.lblUpdateDisabled.Text = "Disabled in experimental builds";
            this.lblUpdateDisabled.Visible = false;
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel6.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel6.Location = new System.Drawing.Point(792, 428);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(130, 28);
            this.linkLabel6.TabIndex = 68;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Tag = "themeable";
            this.linkLabel6.Text = "Open Source";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // picFOSS
            // 
            this.picFOSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picFOSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFOSS.BackgroundImage")));
            this.picFOSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFOSS.Location = new System.Drawing.Point(788, 311);
            this.picFOSS.Name = "picFOSS";
            this.picFOSS.Size = new System.Drawing.Size(128, 114);
            this.picFOSS.TabIndex = 67;
            this.picFOSS.TabStop = false;
            // 
            // picFSF
            // 
            this.picFSF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picFSF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFSF.BackgroundImage")));
            this.picFSF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFSF.Location = new System.Drawing.Point(777, 459);
            this.picFSF.Name = "picFSF";
            this.picFSF.Size = new System.Drawing.Size(145, 114);
            this.picFSF.TabIndex = 66;
            this.picFSF.TabStop = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel5.Location = new System.Drawing.Point(726, 576);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(203, 28);
            this.linkLabel5.TabIndex = 65;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "themeable";
            this.linkLabel5.Text = "GNU GPL 3.0 License";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // btnOpenConf
            // 
            this.btnOpenConf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenConf.ForeColor = System.Drawing.Color.White;
            this.btnOpenConf.Location = new System.Drawing.Point(31, 471);
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
            this.lblTroubleshoot.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleshoot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTroubleshoot.Location = new System.Drawing.Point(11, 390);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(161, 28);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "themeable";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // lblUpdating
            // 
            this.lblUpdating.AutoSize = true;
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUpdating.Location = new System.Drawing.Point(11, 243);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(157, 28);
            this.lblUpdating.TabIndex = 61;
            this.lblUpdating.Tag = "themeable";
            this.lblUpdating.Text = "Check && update";
            // 
            // btnViewLog
            // 
            this.btnViewLog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.ForeColor = System.Drawing.Color.White;
            this.btnViewLog.Location = new System.Drawing.Point(31, 436);
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
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.l2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.l2.Location = new System.Drawing.Point(6, 576);
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
            this.btnChangelog.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnChangelog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangelog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangelog.ForeColor = System.Drawing.Color.White;
            this.btnChangelog.Location = new System.Drawing.Point(31, 325);
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
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(31, 290);
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
            this.btnResetConfig.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnResetConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetConfig.ForeColor = System.Drawing.Color.White;
            this.btnResetConfig.Location = new System.Drawing.Point(31, 506);
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
            this.lblTheming.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheming.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTheming.Location = new System.Drawing.Point(11, 99);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(192, 28);
            this.lblTheming.TabIndex = 55;
            this.lblTheming.Tag = "themeable";
            this.lblTheming.Text = "Choose your theme";
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
            this.launcherMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.launcherMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launcherMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.launcherMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayStartup,
            this.trayCleaner,
            this.trayPinger,
            this.trayHosts,
            this.trayAD,
            this.toolStripSeparator1,
            this.trayRestartExplorer,
            this.trayExit});
            this.launcherMenu.Name = "launcherMenu";
            this.launcherMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.launcherMenu.Size = new System.Drawing.Size(215, 192);
            // 
            // trayStartup
            // 
            this.trayStartup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStartup.ForeColor = System.Drawing.Color.White;
            this.trayStartup.Image = ((System.Drawing.Image)(resources.GetObject("trayStartup.Image")));
            this.trayStartup.Name = "trayStartup";
            this.trayStartup.Size = new System.Drawing.Size(214, 26);
            this.trayStartup.Text = "Startup Manager";
            this.trayStartup.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayStartup.Click += new System.EventHandler(this.startupItem_Click);
            // 
            // trayCleaner
            // 
            this.trayCleaner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayCleaner.ForeColor = System.Drawing.Color.White;
            this.trayCleaner.Image = ((System.Drawing.Image)(resources.GetObject("trayCleaner.Image")));
            this.trayCleaner.Name = "trayCleaner";
            this.trayCleaner.Size = new System.Drawing.Size(214, 26);
            this.trayCleaner.Text = "PC Cleaner";
            this.trayCleaner.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayCleaner.Click += new System.EventHandler(this.cleanerItem_Click);
            // 
            // trayPinger
            // 
            this.trayPinger.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayPinger.ForeColor = System.Drawing.Color.White;
            this.trayPinger.Image = ((System.Drawing.Image)(resources.GetObject("trayPinger.Image")));
            this.trayPinger.Name = "trayPinger";
            this.trayPinger.Size = new System.Drawing.Size(214, 26);
            this.trayPinger.Text = "Pinger Tool";
            this.trayPinger.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayPinger.Click += new System.EventHandler(this.pingerItem_Click);
            // 
            // trayHosts
            // 
            this.trayHosts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayHosts.ForeColor = System.Drawing.Color.White;
            this.trayHosts.Image = ((System.Drawing.Image)(resources.GetObject("trayHosts.Image")));
            this.trayHosts.Name = "trayHosts";
            this.trayHosts.Size = new System.Drawing.Size(214, 26);
            this.trayHosts.Text = "HOSTS Editor";
            this.trayHosts.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayHosts.Click += new System.EventHandler(this.hostsItem_Click);
            // 
            // trayAD
            // 
            this.trayAD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayAD.ForeColor = System.Drawing.Color.White;
            this.trayAD.Image = ((System.Drawing.Image)(resources.GetObject("trayAD.Image")));
            this.trayAD.Name = "trayAD";
            this.trayAD.Size = new System.Drawing.Size(214, 26);
            this.trayAD.Text = "Apps Downloader";
            this.trayAD.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayAD.Click += new System.EventHandler(this.appsItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            this.toolStripSeparator1.Tag = "";
            // 
            // trayRestartExplorer
            // 
            this.trayRestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.trayRestartExplorer.Image = ((System.Drawing.Image)(resources.GetObject("trayRestartExplorer.Image")));
            this.trayRestartExplorer.Name = "trayRestartExplorer";
            this.trayRestartExplorer.Size = new System.Drawing.Size(214, 26);
            this.trayRestartExplorer.Text = "Restart Explorer";
            this.trayRestartExplorer.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.trayRestartExplorer.Click += new System.EventHandler(this.restartExpolorerItem_Click);
            // 
            // trayExit
            // 
            this.trayExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayExit.ForeColor = System.Drawing.Color.White;
            this.trayExit.Image = ((System.Drawing.Image)(resources.GetObject("trayExit.Image")));
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(214, 26);
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
            this.helpBox.IsBalloon = true;
            this.helpBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpBox.UseAnimation = false;
            this.helpBox.UseFading = false;
            // 
            // txtFeedError
            // 
            this.txtFeedError.BackColor = System.Drawing.Color.Transparent;
            this.txtFeedError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFeedError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedError.ForeColor = System.Drawing.Color.Gold;
            this.txtFeedError.Location = new System.Drawing.Point(3, 47);
            this.txtFeedError.Name = "txtFeedError";
            this.txtFeedError.Size = new System.Drawing.Size(923, 441);
            this.txtFeedError.TabIndex = 170;
            this.txtFeedError.Text = "No internet connection, try refreshing links again";
            this.txtFeedError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFeedError.Visible = false;
            // 
            // stickySw
            // 
            this.stickySw.Location = new System.Drawing.Point(337, 121);
            this.stickySw.Margin = new System.Windows.Forms.Padding(2);
            this.stickySw.Name = "stickySw";
            this.stickySw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickySw.OffForeColor = System.Drawing.Color.White;
            this.stickySw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickySw.OnForeColor = System.Drawing.Color.White;
            this.stickySw.OnText = "Disable Sticky Keys";
            this.stickySw.Size = new System.Drawing.Size(319, 31);
            this.stickySw.TabIndex = 50;
            this.stickySw.Tag = "themeable";
            // 
            // smartScreenSw
            // 
            this.smartScreenSw.Location = new System.Drawing.Point(14, 121);
            this.smartScreenSw.Margin = new System.Windows.Forms.Padding(2);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartScreenSw.OffForeColor = System.Drawing.Color.White;
            this.smartScreenSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartScreenSw.OnForeColor = System.Drawing.Color.White;
            this.smartScreenSw.OnText = "Disable SmartScreen";
            this.smartScreenSw.Size = new System.Drawing.Size(319, 31);
            this.smartScreenSw.TabIndex = 49;
            this.smartScreenSw.Tag = "themeable";
            // 
            // faxSw
            // 
            this.faxSw.Location = new System.Drawing.Point(337, 51);
            this.faxSw.Margin = new System.Windows.Forms.Padding(2);
            this.faxSw.Name = "faxSw";
            this.faxSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.OffForeColor = System.Drawing.Color.White;
            this.faxSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.OnForeColor = System.Drawing.Color.White;
            this.faxSw.OnText = "Disable Fax Service";
            this.faxSw.Size = new System.Drawing.Size(319, 31);
            this.faxSw.TabIndex = 48;
            this.faxSw.Tag = "themeable";
            // 
            // compatSw
            // 
            this.compatSw.Location = new System.Drawing.Point(337, 226);
            this.compatSw.Margin = new System.Windows.Forms.Padding(2);
            this.compatSw.Name = "compatSw";
            this.compatSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatSw.OffForeColor = System.Drawing.Color.White;
            this.compatSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compatSw.OnForeColor = System.Drawing.Color.White;
            this.compatSw.OnText = "Disable Compatibility Assistant";
            this.compatSw.Size = new System.Drawing.Size(319, 31);
            this.compatSw.TabIndex = 47;
            this.compatSw.Tag = "themeable";
            // 
            // officeTelemetrySw
            // 
            this.officeTelemetrySw.Location = new System.Drawing.Point(14, 261);
            this.officeTelemetrySw.Margin = new System.Windows.Forms.Padding(2);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.OffForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.OnForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.OnText = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.Size = new System.Drawing.Size(319, 31);
            this.officeTelemetrySw.TabIndex = 46;
            this.officeTelemetrySw.Tag = "themeable";
            // 
            // telemetryTasksSw
            // 
            this.telemetryTasksSw.Location = new System.Drawing.Point(14, 226);
            this.telemetryTasksSw.Margin = new System.Windows.Forms.Padding(2);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryTasksSw.OffForeColor = System.Drawing.Color.White;
            this.telemetryTasksSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryTasksSw.OnForeColor = System.Drawing.Color.White;
            this.telemetryTasksSw.OnText = "Disable Telemetry Tasks";
            this.telemetryTasksSw.Size = new System.Drawing.Size(319, 31);
            this.telemetryTasksSw.TabIndex = 45;
            this.telemetryTasksSw.Tag = "themeable";
            // 
            // superfetchSw
            // 
            this.superfetchSw.Location = new System.Drawing.Point(337, 191);
            this.superfetchSw.Margin = new System.Windows.Forms.Padding(2);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.OffForeColor = System.Drawing.Color.White;
            this.superfetchSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.OnForeColor = System.Drawing.Color.White;
            this.superfetchSw.OnText = "Disable Superfetch";
            this.superfetchSw.Size = new System.Drawing.Size(319, 31);
            this.superfetchSw.TabIndex = 44;
            this.superfetchSw.Tag = "themeable";
            // 
            // homegroupSw
            // 
            this.homegroupSw.Location = new System.Drawing.Point(337, 156);
            this.homegroupSw.Margin = new System.Windows.Forms.Padding(2);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homegroupSw.OffForeColor = System.Drawing.Color.White;
            this.homegroupSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homegroupSw.OnForeColor = System.Drawing.Color.White;
            this.homegroupSw.OnText = "Disable HomeGroup";
            this.homegroupSw.Size = new System.Drawing.Size(319, 31);
            this.homegroupSw.TabIndex = 43;
            this.homegroupSw.Tag = "themeable";
            // 
            // reportingSw
            // 
            this.reportingSw.Location = new System.Drawing.Point(14, 191);
            this.reportingSw.Margin = new System.Windows.Forms.Padding(2);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingSw.OffForeColor = System.Drawing.Color.White;
            this.reportingSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingSw.OnForeColor = System.Drawing.Color.White;
            this.reportingSw.OnText = "Disable Error Reporting";
            this.reportingSw.Size = new System.Drawing.Size(319, 31);
            this.reportingSw.TabIndex = 42;
            this.reportingSw.Tag = "themeable";
            // 
            // mediaSharingSw
            // 
            this.mediaSharingSw.Location = new System.Drawing.Point(337, 86);
            this.mediaSharingSw.Margin = new System.Windows.Forms.Padding(2);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaSharingSw.OffForeColor = System.Drawing.Color.White;
            this.mediaSharingSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaSharingSw.OnForeColor = System.Drawing.Color.White;
            this.mediaSharingSw.OnText = "Disable Media Player Sharing";
            this.mediaSharingSw.Size = new System.Drawing.Size(319, 31);
            this.mediaSharingSw.TabIndex = 40;
            this.mediaSharingSw.Tag = "themeable";
            // 
            // printSw
            // 
            this.printSw.Location = new System.Drawing.Point(337, 16);
            this.printSw.Margin = new System.Windows.Forms.Padding(2);
            this.printSw.Name = "printSw";
            this.printSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSw.OffForeColor = System.Drawing.Color.White;
            this.printSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSw.OnForeColor = System.Drawing.Color.White;
            this.printSw.OnText = "Disable Print Service";
            this.printSw.Size = new System.Drawing.Size(319, 31);
            this.printSw.TabIndex = 39;
            this.printSw.Tag = "themeable";
            // 
            // systemRestoreSw
            // 
            this.systemRestoreSw.Location = new System.Drawing.Point(14, 156);
            this.systemRestoreSw.Margin = new System.Windows.Forms.Padding(2);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.OffForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.OnForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.OnText = "Disable System Restore";
            this.systemRestoreSw.Size = new System.Drawing.Size(319, 31);
            this.systemRestoreSw.TabIndex = 38;
            this.systemRestoreSw.Tag = "themeable";
            // 
            // performanceSw
            // 
            this.performanceSw.Location = new System.Drawing.Point(14, 16);
            this.performanceSw.Margin = new System.Windows.Forms.Padding(2);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceSw.OffForeColor = System.Drawing.Color.White;
            this.performanceSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceSw.OnForeColor = System.Drawing.Color.White;
            this.performanceSw.OnText = "Enable Performance Tweaks";
            this.performanceSw.Size = new System.Drawing.Size(319, 31);
            this.performanceSw.TabIndex = 37;
            this.performanceSw.Tag = "themeable";
            // 
            // defenderSw
            // 
            this.defenderSw.Location = new System.Drawing.Point(14, 86);
            this.defenderSw.Margin = new System.Windows.Forms.Padding(2);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenderSw.OffForeColor = System.Drawing.Color.White;
            this.defenderSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenderSw.OnForeColor = System.Drawing.Color.White;
            this.defenderSw.OnText = "Disable Windows Defender";
            this.defenderSw.Size = new System.Drawing.Size(319, 31);
            this.defenderSw.TabIndex = 36;
            this.defenderSw.Tag = "themeable";
            // 
            // networkSw
            // 
            this.networkSw.Location = new System.Drawing.Point(14, 51);
            this.networkSw.Margin = new System.Windows.Forms.Padding(2);
            this.networkSw.Name = "networkSw";
            this.networkSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkSw.OffForeColor = System.Drawing.Color.White;
            this.networkSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkSw.OnForeColor = System.Drawing.Color.White;
            this.networkSw.OnText = "Disable Network Throttling";
            this.networkSw.Size = new System.Drawing.Size(319, 31);
            this.networkSw.TabIndex = 35;
            this.networkSw.Tag = "themeable";
            // 
            // actionSw
            // 
            this.actionSw.Location = new System.Drawing.Point(14, 410);
            this.actionSw.Margin = new System.Windows.Forms.Padding(2);
            this.actionSw.Name = "actionSw";
            this.actionSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionSw.OffForeColor = System.Drawing.Color.White;
            this.actionSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionSw.OnForeColor = System.Drawing.Color.White;
            this.actionSw.OnText = "Disable Notification Center";
            this.actionSw.Size = new System.Drawing.Size(319, 31);
            this.actionSw.TabIndex = 71;
            this.actionSw.Tag = "themeable";
            // 
            // castSw
            // 
            this.castSw.Location = new System.Drawing.Point(337, 267);
            this.castSw.Margin = new System.Windows.Forms.Padding(2);
            this.castSw.Name = "castSw";
            this.castSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castSw.OffForeColor = System.Drawing.Color.White;
            this.castSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castSw.OnForeColor = System.Drawing.Color.White;
            this.castSw.OnText = "Remove Cast To Device";
            this.castSw.Size = new System.Drawing.Size(319, 31);
            this.castSw.TabIndex = 61;
            this.castSw.Tag = "themeable";
            // 
            // longPathsSw
            // 
            this.longPathsSw.Location = new System.Drawing.Point(14, 267);
            this.longPathsSw.Margin = new System.Windows.Forms.Padding(2);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPathsSw.OffForeColor = System.Drawing.Color.White;
            this.longPathsSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPathsSw.OnForeColor = System.Drawing.Color.White;
            this.longPathsSw.OnText = "Enable Long Paths";
            this.longPathsSw.Size = new System.Drawing.Size(319, 31);
            this.longPathsSw.TabIndex = 60;
            this.longPathsSw.Tag = "themeable";
            // 
            // ccSw
            // 
            this.ccSw.Location = new System.Drawing.Point(337, 161);
            this.ccSw.Margin = new System.Windows.Forms.Padding(2);
            this.ccSw.Name = "ccSw";
            this.ccSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccSw.OffForeColor = System.Drawing.Color.White;
            this.ccSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccSw.OnForeColor = System.Drawing.Color.White;
            this.ccSw.OnText = "Disable Cloud Clipboard";
            this.ccSw.Size = new System.Drawing.Size(319, 31);
            this.ccSw.TabIndex = 59;
            this.ccSw.Tag = "themeable";
            // 
            // featuresSw
            // 
            this.featuresSw.Location = new System.Drawing.Point(337, 375);
            this.featuresSw.Margin = new System.Windows.Forms.Padding(2);
            this.featuresSw.Name = "featuresSw";
            this.featuresSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresSw.OffForeColor = System.Drawing.Color.White;
            this.featuresSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresSw.OnForeColor = System.Drawing.Color.White;
            this.featuresSw.OnText = "Disable Feature Updates";
            this.featuresSw.Size = new System.Drawing.Size(319, 31);
            this.featuresSw.TabIndex = 58;
            this.featuresSw.Tag = "themeable";
            // 
            // insiderSw
            // 
            this.insiderSw.Location = new System.Drawing.Point(337, 339);
            this.insiderSw.Margin = new System.Windows.Forms.Padding(2);
            this.insiderSw.Name = "insiderSw";
            this.insiderSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.OffForeColor = System.Drawing.Color.White;
            this.insiderSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.OnForeColor = System.Drawing.Color.White;
            this.insiderSw.OnText = "Disable Insider Service";
            this.insiderSw.Size = new System.Drawing.Size(319, 31);
            this.insiderSw.TabIndex = 57;
            this.insiderSw.Tag = "themeable";
            // 
            // darkSw
            // 
            this.darkSw.Location = new System.Drawing.Point(14, 160);
            this.darkSw.Margin = new System.Windows.Forms.Padding(2);
            this.darkSw.Name = "darkSw";
            this.darkSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSw.OffForeColor = System.Drawing.Color.White;
            this.darkSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSw.OnForeColor = System.Drawing.Color.White;
            this.darkSw.OnText = "Enable Dark Theme";
            this.darkSw.Size = new System.Drawing.Size(319, 31);
            this.darkSw.TabIndex = 56;
            this.darkSw.Tag = "themeable";
            // 
            // spellSw
            // 
            this.spellSw.Location = new System.Drawing.Point(14, 339);
            this.spellSw.Margin = new System.Windows.Forms.Padding(2);
            this.spellSw.Name = "spellSw";
            this.spellSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellSw.OffForeColor = System.Drawing.Color.White;
            this.spellSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellSw.OnForeColor = System.Drawing.Color.White;
            this.spellSw.OnText = "Disable Spell Checking";
            this.spellSw.Size = new System.Drawing.Size(319, 31);
            this.spellSw.TabIndex = 55;
            this.spellSw.Tag = "themeable";
            // 
            // inkSw
            // 
            this.inkSw.Location = new System.Drawing.Point(14, 303);
            this.inkSw.Margin = new System.Windows.Forms.Padding(2);
            this.inkSw.Name = "inkSw";
            this.inkSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkSw.OffForeColor = System.Drawing.Color.White;
            this.inkSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkSw.OnForeColor = System.Drawing.Color.White;
            this.inkSw.OnText = "Disable Windows Ink";
            this.inkSw.Size = new System.Drawing.Size(319, 31);
            this.inkSw.TabIndex = 54;
            this.inkSw.Tag = "themeable";
            // 
            // driversSw
            // 
            this.driversSw.Location = new System.Drawing.Point(337, 52);
            this.driversSw.Margin = new System.Windows.Forms.Padding(2);
            this.driversSw.Name = "driversSw";
            this.driversSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversSw.OffForeColor = System.Drawing.Color.White;
            this.driversSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversSw.OnForeColor = System.Drawing.Color.White;
            this.driversSw.OnText = "Exclude Drivers from Updates";
            this.driversSw.Size = new System.Drawing.Size(319, 31);
            this.driversSw.TabIndex = 53;
            this.driversSw.Tag = "themeable";
            // 
            // sensorSw
            // 
            this.sensorSw.Location = new System.Drawing.Point(337, 232);
            this.sensorSw.Margin = new System.Windows.Forms.Padding(2);
            this.sensorSw.Name = "sensorSw";
            this.sensorSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorSw.OffForeColor = System.Drawing.Color.White;
            this.sensorSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorSw.OnForeColor = System.Drawing.Color.White;
            this.sensorSw.OnText = "Disable Sensor Services";
            this.sensorSw.Size = new System.Drawing.Size(319, 31);
            this.sensorSw.TabIndex = 51;
            this.sensorSw.Tag = "themeable";
            // 
            // privacySw
            // 
            this.privacySw.Location = new System.Drawing.Point(337, 124);
            this.privacySw.Margin = new System.Windows.Forms.Padding(2);
            this.privacySw.Name = "privacySw";
            this.privacySw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacySw.OffForeColor = System.Drawing.Color.White;
            this.privacySw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacySw.OnForeColor = System.Drawing.Color.White;
            this.privacySw.OnText = "Enhance Privacy";
            this.privacySw.Size = new System.Drawing.Size(319, 31);
            this.privacySw.TabIndex = 50;
            this.privacySw.Tag = "themeable";
            // 
            // telemetryServicesSw
            // 
            this.telemetryServicesSw.Location = new System.Drawing.Point(337, 88);
            this.telemetryServicesSw.Margin = new System.Windows.Forms.Padding(2);
            this.telemetryServicesSw.Name = "telemetryServicesSw";
            this.telemetryServicesSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryServicesSw.OffForeColor = System.Drawing.Color.White;
            this.telemetryServicesSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemetryServicesSw.OnForeColor = System.Drawing.Color.White;
            this.telemetryServicesSw.OnText = "Disable Telemetry Services";
            this.telemetryServicesSw.Size = new System.Drawing.Size(319, 31);
            this.telemetryServicesSw.TabIndex = 48;
            this.telemetryServicesSw.Tag = "themeable";
            // 
            // autoUpdatesSw
            // 
            this.autoUpdatesSw.Location = new System.Drawing.Point(337, 16);
            this.autoUpdatesSw.Margin = new System.Windows.Forms.Padding(2);
            this.autoUpdatesSw.Name = "autoUpdatesSw";
            this.autoUpdatesSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdatesSw.OffForeColor = System.Drawing.Color.White;
            this.autoUpdatesSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdatesSw.OnForeColor = System.Drawing.Color.White;
            this.autoUpdatesSw.OnText = "Disable Automatic Updates";
            this.autoUpdatesSw.Size = new System.Drawing.Size(319, 31);
            this.autoUpdatesSw.TabIndex = 47;
            this.autoUpdatesSw.Tag = "themeable";
            // 
            // peopleSw
            // 
            this.peopleSw.Location = new System.Drawing.Point(14, 232);
            this.peopleSw.Margin = new System.Windows.Forms.Padding(2);
            this.peopleSw.Name = "peopleSw";
            this.peopleSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.OffForeColor = System.Drawing.Color.White;
            this.peopleSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.OnForeColor = System.Drawing.Color.White;
            this.peopleSw.OnText = "Disable My People";
            this.peopleSw.Size = new System.Drawing.Size(319, 31);
            this.peopleSw.TabIndex = 46;
            this.peopleSw.Tag = "themeable";
            // 
            // adsSw
            // 
            this.adsSw.Location = new System.Drawing.Point(14, 124);
            this.adsSw.Margin = new System.Windows.Forms.Padding(2);
            this.adsSw.Name = "adsSw";
            this.adsSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsSw.OffForeColor = System.Drawing.Color.White;
            this.adsSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsSw.OnForeColor = System.Drawing.Color.White;
            this.adsSw.OnText = "Disable Start Menu Ads";
            this.adsSw.Size = new System.Drawing.Size(319, 31);
            this.adsSw.TabIndex = 45;
            this.adsSw.Tag = "themeable";
            // 
            // colorBarSw
            // 
            this.colorBarSw.Location = new System.Drawing.Point(14, 52);
            this.colorBarSw.Margin = new System.Windows.Forms.Padding(2);
            this.colorBarSw.Name = "colorBarSw";
            this.colorBarSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBarSw.OffForeColor = System.Drawing.Color.White;
            this.colorBarSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBarSw.OnForeColor = System.Drawing.Color.White;
            this.colorBarSw.OnText = "Enable Taskbar Color";
            this.colorBarSw.Size = new System.Drawing.Size(319, 31);
            this.colorBarSw.TabIndex = 44;
            this.colorBarSw.Tag = "themeable";
            // 
            // oldExplorerSw
            // 
            this.oldExplorerSw.Location = new System.Drawing.Point(14, 88);
            this.oldExplorerSw.Margin = new System.Windows.Forms.Padding(2);
            this.oldExplorerSw.Name = "oldExplorerSw";
            this.oldExplorerSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldExplorerSw.OffForeColor = System.Drawing.Color.White;
            this.oldExplorerSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldExplorerSw.OnForeColor = System.Drawing.Color.White;
            this.oldExplorerSw.OnText = "Disable Quick Access History";
            this.oldExplorerSw.Size = new System.Drawing.Size(319, 31);
            this.oldExplorerSw.TabIndex = 43;
            this.oldExplorerSw.Tag = "themeable";
            // 
            // xboxSw
            // 
            this.xboxSw.Location = new System.Drawing.Point(14, 375);
            this.xboxSw.Margin = new System.Windows.Forms.Padding(2);
            this.xboxSw.Name = "xboxSw";
            this.xboxSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxSw.OffForeColor = System.Drawing.Color.White;
            this.xboxSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxSw.OnForeColor = System.Drawing.Color.White;
            this.xboxSw.OnText = "Disable Xbox Live";
            this.xboxSw.Size = new System.Drawing.Size(319, 31);
            this.xboxSw.TabIndex = 42;
            this.xboxSw.Tag = "themeable";
            // 
            // cortanaSw
            // 
            this.cortanaSw.Location = new System.Drawing.Point(337, 196);
            this.cortanaSw.Margin = new System.Windows.Forms.Padding(2);
            this.cortanaSw.Name = "cortanaSw";
            this.cortanaSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortanaSw.OffForeColor = System.Drawing.Color.White;
            this.cortanaSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortanaSw.OnForeColor = System.Drawing.Color.White;
            this.cortanaSw.OnText = "Disable Cortana";
            this.cortanaSw.Size = new System.Drawing.Size(319, 31);
            this.cortanaSw.TabIndex = 41;
            this.cortanaSw.Tag = "themeable";
            // 
            // gameBarSw
            // 
            this.gameBarSw.Location = new System.Drawing.Point(337, 303);
            this.gameBarSw.Margin = new System.Windows.Forms.Padding(2);
            this.gameBarSw.Name = "gameBarSw";
            this.gameBarSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBarSw.OffForeColor = System.Drawing.Color.White;
            this.gameBarSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBarSw.OnForeColor = System.Drawing.Color.White;
            this.gameBarSw.OnText = "Disable Game Bar";
            this.gameBarSw.Size = new System.Drawing.Size(319, 31);
            this.gameBarSw.TabIndex = 40;
            this.gameBarSw.Tag = "themeable";
            // 
            // uODSw
            // 
            this.uODSw.Location = new System.Drawing.Point(14, 196);
            this.uODSw.Margin = new System.Windows.Forms.Padding(2);
            this.uODSw.Name = "uODSw";
            this.uODSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.OffForeColor = System.Drawing.Color.White;
            this.uODSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.OnForeColor = System.Drawing.Color.White;
            this.uODSw.OnText = "Uninstall OneDrive";
            this.uODSw.Size = new System.Drawing.Size(319, 31);
            this.uODSw.TabIndex = 39;
            this.uODSw.Tag = "themeable";
            // 
            // oldMixerSw
            // 
            this.oldMixerSw.Location = new System.Drawing.Point(14, 16);
            this.oldMixerSw.Margin = new System.Windows.Forms.Padding(2);
            this.oldMixerSw.Name = "oldMixerSw";
            this.oldMixerSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMixerSw.OffForeColor = System.Drawing.Color.White;
            this.oldMixerSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldMixerSw.OnForeColor = System.Drawing.Color.White;
            this.oldMixerSw.OnText = "Enable Classic Volume Mixer";
            this.oldMixerSw.Size = new System.Drawing.Size(319, 31);
            this.oldMixerSw.TabIndex = 38;
            this.oldMixerSw.Tag = "themeable";
            // 
            // disableOneDriveSw
            // 
            this.disableOneDriveSw.Location = new System.Drawing.Point(14, 16);
            this.disableOneDriveSw.Margin = new System.Windows.Forms.Padding(2);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.OffForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.OnForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.OnText = "Disable OneDrive";
            this.disableOneDriveSw.Size = new System.Drawing.Size(319, 31);
            this.disableOneDriveSw.TabIndex = 46;
            this.disableOneDriveSw.Tag = "themeable";
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
            // cAutoInstall
            // 
            this.cAutoInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cAutoInstall.Location = new System.Drawing.Point(630, 56);
            this.cAutoInstall.Name = "cAutoInstall";
            this.cAutoInstall.Size = new System.Drawing.Size(290, 24);
            this.cAutoInstall.TabIndex = 107;
            this.cAutoInstall.Text = "Install after downloading";
            this.cAutoInstall.UseVisualStyleBackColor = true;
            // 
            // progressDownloader
            // 
            this.progressDownloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressDownloader.Location = new System.Drawing.Point(11, 83);
            this.progressDownloader.MarqueeAnimationSpeed = 15;
            this.progressDownloader.Name = "progressDownloader";
            this.progressDownloader.Size = new System.Drawing.Size(302, 10);
            this.progressDownloader.TabIndex = 160;
            // 
            // c64
            // 
            this.c64.AutoSize = true;
            this.c64.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c64.Location = new System.Drawing.Point(373, 29);
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
            this.c32.Location = new System.Drawing.Point(448, 29);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(72, 25);
            this.c32.TabIndex = 76;
            this.c32.TabStop = true;
            this.c32.Text = "32-bit";
            this.c32.UseVisualStyleBackColor = true;
            // 
            // checkErrorReports
            // 
            this.checkErrorReports.AutoSize = true;
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(275, 104);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.Size = new System.Drawing.Size(123, 25);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.Text = "Error reports";
            this.checkErrorReports.UseVisualStyleBackColor = true;
            // 
            // checkSelectAll
            // 
            this.checkSelectAll.AutoSize = true;
            this.checkSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSelectAll.ForeColor = System.Drawing.Color.White;
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
            // checkMediaCache
            // 
            this.checkMediaCache.AutoSize = true;
            this.checkMediaCache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMediaCache.ForeColor = System.Drawing.Color.White;
            this.checkMediaCache.Location = new System.Drawing.Point(275, 75);
            this.checkMediaCache.Margin = new System.Windows.Forms.Padding(2);
            this.checkMediaCache.Name = "checkMediaCache";
            this.checkMediaCache.Size = new System.Drawing.Size(176, 25);
            this.checkMediaCache.TabIndex = 43;
            this.checkMediaCache.Text = "Media Players cache";
            this.checkMediaCache.UseVisualStyleBackColor = true;
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
            // checkLogs
            // 
            this.checkLogs.AutoSize = true;
            this.checkLogs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLogs.ForeColor = System.Drawing.Color.White;
            this.checkLogs.Location = new System.Drawing.Point(55, 75);
            this.checkLogs.Margin = new System.Windows.Forms.Padding(2);
            this.checkLogs.Name = "checkLogs";
            this.checkLogs.Size = new System.Drawing.Size(131, 25);
            this.checkLogs.TabIndex = 42;
            this.checkLogs.Text = "Windows logs";
            this.checkLogs.UseVisualStyleBackColor = true;
            // 
            // checkBin
            // 
            this.checkBin.AutoSize = true;
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.White;
            this.checkBin.Location = new System.Drawing.Point(275, 45);
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
            this.checkMiniDumps.Location = new System.Drawing.Point(55, 104);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(2);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.Size = new System.Drawing.Size(157, 25);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.Text = "BSOD Minidumps";
            this.checkMiniDumps.UseVisualStyleBackColor = true;
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
            // checkRestartExplorer
            // 
            this.checkRestartExplorer.AutoSize = true;
            this.checkRestartExplorer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.checkRestartExplorer.Location = new System.Drawing.Point(29, 175);
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
            this.checkRegistryEditor.Location = new System.Drawing.Point(256, 136);
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
            this.checkContextMenu.Location = new System.Drawing.Point(256, 75);
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
            this.checkFirewall.Location = new System.Drawing.Point(256, 106);
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
            this.checkRunDialog.Location = new System.Drawing.Point(256, 45);
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
            // radioTurkish
            // 
            this.radioTurkish.AutoSize = true;
            this.radioTurkish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioTurkish.ForeColor = System.Drawing.Color.White;
            this.radioTurkish.Location = new System.Drawing.Point(151, 95);
            this.radioTurkish.Margin = new System.Windows.Forms.Padding(2);
            this.radioTurkish.Name = "radioTurkish";
            this.radioTurkish.Size = new System.Drawing.Size(76, 25);
            this.radioTurkish.TabIndex = 80;
            this.radioTurkish.Tag = "";
            this.radioTurkish.Text = "Türkçe";
            this.radioTurkish.UseVisualStyleBackColor = true;
            this.radioTurkish.Click += new System.EventHandler(this.radioTurkish_Click);
            // 
            // radioHellenic
            // 
            this.radioHellenic.AutoSize = true;
            this.radioHellenic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioHellenic.ForeColor = System.Drawing.Color.White;
            this.radioHellenic.Location = new System.Drawing.Point(151, 66);
            this.radioHellenic.Margin = new System.Windows.Forms.Padding(2);
            this.radioHellenic.Name = "radioHellenic";
            this.radioHellenic.Size = new System.Drawing.Size(94, 25);
            this.radioHellenic.TabIndex = 78;
            this.radioHellenic.Tag = "";
            this.radioHellenic.Text = "Ελληνικά";
            this.radioHellenic.UseVisualStyleBackColor = true;
            this.radioHellenic.Click += new System.EventHandler(this.radioHellenic_Click);
            // 
            // radioEnglish
            // 
            this.radioEnglish.AutoSize = true;
            this.radioEnglish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEnglish.ForeColor = System.Drawing.Color.White;
            this.radioEnglish.Location = new System.Drawing.Point(151, 8);
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
            this.radioRussian.AutoSize = true;
            this.radioRussian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.radioRussian.ForeColor = System.Drawing.Color.White;
            this.radioRussian.Location = new System.Drawing.Point(151, 37);
            this.radioRussian.Margin = new System.Windows.Forms.Padding(2);
            this.radioRussian.Name = "radioRussian";
            this.radioRussian.Size = new System.Drawing.Size(90, 25);
            this.radioRussian.TabIndex = 74;
            this.radioRussian.Tag = "";
            this.radioRussian.Text = "русский";
            this.radioRussian.UseVisualStyleBackColor = true;
            this.radioRussian.Click += new System.EventHandler(this.radioRussian_Click);
            // 
            // helpTipsToggle
            // 
            this.helpTipsToggle.Location = new System.Drawing.Point(14, 51);
            this.helpTipsToggle.Margin = new System.Windows.Forms.Padding(2);
            this.helpTipsToggle.Name = "helpTipsToggle";
            this.helpTipsToggle.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTipsToggle.OffForeColor = System.Drawing.Color.White;
            this.helpTipsToggle.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTipsToggle.OnForeColor = System.Drawing.Color.White;
            this.helpTipsToggle.OnText = "Show Help Messages";
            this.helpTipsToggle.Size = new System.Drawing.Size(319, 31);
            this.helpTipsToggle.TabIndex = 70;
            this.helpTipsToggle.Tag = "themeable";
            this.helpTipsToggle.CheckedChanged += new Optimizer.ToggleSwitch.CheckedChangedDelegate(this.helpTipsToggle_CheckedChanged);
            // 
            // quickAccessToggle
            // 
            this.quickAccessToggle.Location = new System.Drawing.Point(14, 16);
            this.quickAccessToggle.Margin = new System.Windows.Forms.Padding(2);
            this.quickAccessToggle.Name = "quickAccessToggle";
            this.quickAccessToggle.OffFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessToggle.OffForeColor = System.Drawing.Color.White;
            this.quickAccessToggle.OnFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAccessToggle.OnForeColor = System.Drawing.Color.White;
            this.quickAccessToggle.OnText = "Show Quick Access Menu";
            this.quickAccessToggle.Size = new System.Drawing.Size(319, 31);
            this.quickAccessToggle.TabIndex = 64;
            this.quickAccessToggle.Tag = "themeable";
            this.quickAccessToggle.CheckedChanged += new Optimizer.ToggleSwitch.CheckedChangedDelegate(this.quickAccessToggle_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(939, 705);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.tpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(955, 744);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpanel.ResumeLayout(false);
            this.tpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bpanel.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.universalTab.ResumeLayout(false);
            this.universalTab.PerformLayout();
            this.windowsXTab.ResumeLayout(false);
            this.windowsXTab.PerformLayout();
            this.windowsVIIITab.ResumeLayout(false);
            this.windowsVIIITab.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFOSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFSF)).EndInit();
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
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TabPage windowsXTab;
        private System.Windows.Forms.Button restartButton10;
        private System.Windows.Forms.TabPage windowsVIIITab;
        private System.Windows.Forms.Button restartButton8;
        private System.Windows.Forms.TabPage cleanerTab;
        private ColoredCheckBox checkTemp;
        private ColoredCheckBox checkSelectAll;
        private System.Windows.Forms.Button cleanDriveB;
        private ColoredCheckBox checkMediaCache;
        private ColoredCheckBox checkLogs;
        private ColoredCheckBox checkBin;
        private ColoredCheckBox checkMiniDumps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage startupTab;
        private System.Windows.Forms.Label startupTitle;
        private System.Windows.Forms.Button removeStartupItemB;
        private System.Windows.Forms.Label cleanerTitle;
        private System.Windows.Forms.TabPage registryFixerTab;
        private System.Windows.Forms.Label registryTitle;
        private System.Windows.Forms.Button regFixB;
        private System.Windows.Forms.Panel panel2;
        private ColoredCheckBox checkRegistryEditor;
        private ColoredCheckBox checkEnableAll;
        private ColoredCheckBox checkContextMenu;
        private ColoredCheckBox checkTaskManager;
        private ColoredCheckBox checkCommandPrompt;
        private ColoredCheckBox checkFirewall;
        private ColoredCheckBox checkRunDialog;
        private ColoredCheckBox checkFolderOptions;
        private ColoredCheckBox checkControlPanel;
        private ColoredCheckBox checkRestartExplorer;
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
        private System.Windows.Forms.ListBox listHostEntries;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeAllHostsB;
        private System.Windows.Forms.Button refreshHostsB;
        private System.Windows.Forms.Button removeHostB;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button addHostB;
        private System.Windows.Forms.TextBox txtIP;
        private ColoredCheckBox checkErrorReports;
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
        private System.Windows.Forms.Button PMB;
        private System.Windows.Forms.Button DSB;
        private System.Windows.Forms.Button STB;
        private System.Windows.Forms.Button SSB;
        private System.Windows.Forms.Button WAB;
        private System.Windows.Forms.Label readyMenusL;
        private System.Windows.Forms.ListBox listDesktopItems;
        private System.Windows.Forms.Label removeIntegratorItemsL;
        private System.Windows.Forms.Button refreshIIB;
        private System.Windows.Forms.Button removeDIB;
        private System.Windows.Forms.Button removeAllIIB;
        private System.Windows.Forms.GroupBox itemtype;
        private ColoredRadioButton radioCommand;
        private ColoredRadioButton radioProgram;
        private ColoredRadioButton radioFile;
        private ColoredRadioButton radioFolder;
        private ColoredRadioButton radioLink;
        private System.Windows.Forms.Label addItemL;
        private System.Windows.Forms.GroupBox icontoaddgroup;
        private ColoredCheckBox checkDefaultIcon;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.GroupBox itemtoaddgroup;
        private System.Windows.Forms.Button btnBrowseItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.GroupBox security;
        private ColoredCheckBox checkShift;
        private System.Windows.Forms.GroupBox itemposition;
        private ColoredRadioButton radioTop;
        private ColoredRadioButton radioMiddle;
        private ColoredRadioButton radioBottom;
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
        private System.Windows.Forms.RadioButton radioMinimal;
        private System.Windows.Forms.RadioButton radioCaramel;
        private System.Windows.Forms.RadioButton radioLime;
        private System.Windows.Forms.RadioButton radioMagma;
        private System.Windows.Forms.RadioButton radioOcean;
        private System.Windows.Forms.RadioButton radioZerg;
        private System.Windows.Forms.Label lblTheming;
        private System.Windows.Forms.ListBox listCustomCommands;
        private System.Windows.Forms.Label removeCCL;
        private System.Windows.Forms.Button removeCCB;
        private System.Windows.Forms.Button refreshCCB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TabPage modernAppsTab;
        private System.Windows.Forms.Label txtModernAppsTitle;
        private System.Windows.Forms.Panel panelModernAppsList;
        private System.Windows.Forms.CheckedListBox listModernApps;
        private System.Windows.Forms.Button uninstallModernAppsButton;
        private System.Windows.Forms.Button refreshModernAppsButton;
        private System.Windows.Forms.Label txtUWP;
        private ColoredCheckBox chkSelectAllModernApps;
        private ToggleSwitch performanceSw;
        private ToggleSwitch defenderSw;
        private ToggleSwitch networkSw;
        private ToggleSwitch mediaSharingSw;
        private ToggleSwitch printSw;
        private ToggleSwitch systemRestoreSw;
        private ToggleSwitch officeTelemetrySw;
        private ToggleSwitch telemetryTasksSw;
        private ToggleSwitch superfetchSw;
        private ToggleSwitch homegroupSw;
        private ToggleSwitch reportingSw;
        private ToggleSwitch oldMixerSw;
        private ToggleSwitch gameBarSw;
        private ToggleSwitch uODSw;
        private ToggleSwitch sensorSw;
        private ToggleSwitch privacySw;
        private ToggleSwitch telemetryServicesSw;
        private ToggleSwitch autoUpdatesSw;
        private ToggleSwitch peopleSw;
        private ToggleSwitch adsSw;
        private ToggleSwitch colorBarSw;
        private ToggleSwitch oldExplorerSw;
        private ToggleSwitch xboxSw;
        private ToggleSwitch cortanaSw;
        private ToggleSwitch darkSw;
        private ToggleSwitch spellSw;
        private ToggleSwitch inkSw;
        private ToggleSwitch driversSw;
        private System.Windows.Forms.Button btnResetConfig;
        private ToggleSwitch disableOneDriveSw;
        private ToggleSwitch compatSw;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnChangelog;
        private ToggleSwitch faxSw;
        private ToggleSwitch insiderSw;
        private ToggleSwitch featuresSw;
        private ToggleSwitch smartScreenSw;
        private ColoredCheckBox chkReadOnly;
        private System.Windows.Forms.Label lblLock;
        private ToggleSwitch ccSw;
        private ToggleSwitch stickySw;
        private ToggleSwitch longPathsSw;
        private ColoredCheckBox chkBlock;
        private ToggleSwitch castSw;
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
        private ColoredRadioButton c32;
        private System.Windows.Forms.Button goToDownloadsB;
        private System.Windows.Forms.LinkLabel linkWarnings;
        private ColoredCheckBox cAutoInstall;
        private ColoredCheckBox chkOnlyRemovable;
        private ColoredProgress progressDownloader;
        private System.Windows.Forms.Button btnGetFeed;
        private System.Windows.Forms.Panel panelCommonApps;
        private ToggleSwitch actionSw;
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
        private System.Windows.Forms.ListBox listPingResults;
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
        private ToggleSwitch quickAccessToggle;
        private System.Windows.Forms.PictureBox picFSF;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.PictureBox picFOSS;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.LinkLabel linkUpdate;
        private System.Windows.Forms.Label lblUpdateDisabled;
        private System.Windows.Forms.ToolStripMenuItem trayRestartExplorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button flushCacheB;
        private ColoredRadioButton c64;
        private System.Windows.Forms.Panel panel10;
        private ToggleSwitch helpTipsToggle;
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
        private ToolTip helpBox;
        private PictureBox pictureBox88;
        private ColoredRadioButton radioHellenic;
        private ColoredRadioButton radioEnglish;
        private ColoredRadioButton radioRussian;
        private PictureBox pictureBox89;
        private ColoredRadioButton radioTurkish;
        private Label txtNetFw;
        private Panel groupCoding;
        private Panel groupInternet;
        private Panel groupSoundVideo;
        private Label lblVideoSound;
        private Label lblCoding;
        private Label lblSystemTools;
        private Label lblInternet;
        private Label txtFeedError;
    }
}

