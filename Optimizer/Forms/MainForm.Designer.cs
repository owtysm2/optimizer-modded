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
            this.bpanel = new System.Windows.Forms.Panel();
            this.indiciumMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolHWCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHWGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHWDuck = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.Label();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picLab = new System.Windows.Forms.PictureBox();
            this.picRestartNeeded = new System.Windows.Forms.PictureBox();
            this.restartAndApply = new System.Windows.Forms.Label();
            this.pictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tabCollection = new Optimizer.MoonTabs();
            this.universalTab = new System.Windows.Forms.TabPage();
            this.enableUtcSw = new Optimizer.ToggleCard();
            this.noMenuDelaySw = new Optimizer.ToggleCard();
            this.allTrayIconsSw = new Optimizer.ToggleCard();
            this.disableOneDriveSw = new Optimizer.ToggleCard();
            this.label13 = new System.Windows.Forms.Label();
            this.label4a = new System.Windows.Forms.Label();
            this.label14s = new System.Windows.Forms.Label();
            this.nvidiaTelemetrySw = new Optimizer.ToggleCard();
            this.smb2Sw = new Optimizer.ToggleCard();
            this.smb1Sw = new Optimizer.ToggleCard();
            this.chromeTelemetrySw = new Optimizer.ToggleCard();
            this.ffTelemetrySw = new Optimizer.ToggleCard();
            this.vsSw = new Optimizer.ToggleCard();
            this.reportingSw = new Optimizer.ToggleCard();
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
            this.faxSw = new Optimizer.ToggleCard();
            this.performanceSw = new Optimizer.ToggleCard();
            this.panel16 = new System.Windows.Forms.Panel();
            this.drives = new System.Windows.Forms.Label();
            this.superfetchSw = new Optimizer.ToggleCard();
            this.systemRestoreSw = new Optimizer.ToggleCard();
            this.hibernateSw = new Optimizer.ToggleCard();
            this.winSearchSw = new Optimizer.ToggleCard();
            this.ntfsStampSw = new Optimizer.ToggleCard();
            this.windows10Tab = new System.Windows.Forms.TabPage();
            this.modernStandbySw = new Optimizer.ToggleCard();
            this.newsInterestsSw = new Optimizer.ToggleCard();
            this.hideSearchSw = new Optimizer.ToggleCard();
            this.hideWeatherSw = new Optimizer.ToggleCard();
            this.classicPhotoViewerSw = new Optimizer.ToggleCard();
            this.edgeAiSw = new Optimizer.ToggleCard();
            this.edgeTelemetrySw = new Optimizer.ToggleCard();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vbsSw = new Optimizer.ToggleCard();
            this.gameModeSw = new Optimizer.ToggleCard();
            this.storeUpdatesSw = new Optimizer.ToggleCard();
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
            this.peopleSw = new Optimizer.ToggleCard();
            this.oldExplorerSw = new Optimizer.ToggleCard();
            this.adsSw = new Optimizer.ToggleCard();
            this.panelWin11Tweaks = new System.Windows.Forms.Panel();
            this.copilotSw = new Optimizer.ToggleCard();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.stickersSw = new Optimizer.ToggleCard();
            this.compactModeSw = new Optimizer.ToggleCard();
            this.snapAssistSw = new Optimizer.ToggleCard();
            this.widgetsSw = new Optimizer.ToggleCard();
            this.leftTaskbarSw = new Optimizer.ToggleCard();
            this.classicContextSw = new Optimizer.ToggleCard();
            this.chatSw = new Optimizer.ToggleCard();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.regBackupSw = new Optimizer.ToggleCard();
            this.uODSw = new Optimizer.ToggleCard();
            this.loginVerboseSw = new Optimizer.ToggleCard();
            this.hpetSw = new Optimizer.ToggleCard();
            this.btnRestartDisableDefender = new CuoreUI.Controls.cuiButton();
            this.btnRestart = new CuoreUI.Controls.cuiButton();
            this.btnRestartSafe = new CuoreUI.Controls.cuiButton();
            this.modernAppsTab = new System.Windows.Forms.TabPage();
            this.btnRestoreUwp = new CuoreUI.Controls.cuiButton();
            this.uninstallModernAppsButton = new CuoreUI.Controls.cuiButton();
            this.refreshModernAppsButton = new CuoreUI.Controls.cuiButton();
            this.txtModernAppsTitle = new System.Windows.Forms.Label();
            this.chkOnlyRemovable = new CuoreUI.Controls.cuiCheckbox();
            this.chkSelectAllModernApps = new CuoreUI.Controls.cuiCheckbox();
            this.panelUwp = new System.Windows.Forms.Panel();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.startupTab = new System.Windows.Forms.TabPage();
            this.cancelBackup = new System.Windows.Forms.Button();
            this.doBackup = new System.Windows.Forms.Button();
            this.txtBackupTitle = new System.Windows.Forms.TextBox();
            this.lblBackupTitle = new System.Windows.Forms.Label();
            this.restoreStartupB = new System.Windows.Forms.Button();
            this.backupStartupB = new System.Windows.Forms.Button();
            this.findInRegB = new System.Windows.Forms.Button();
            this.locateFileB = new System.Windows.Forms.Button();
            this.removeStartupItemB = new System.Windows.Forms.Button();
            this.refreshStartupB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listStartupItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            this.cAutoInstall = new CuoreUI.Controls.cuiCheckbox();
            this.progressDownloader = new CuoreUI.Controls.cuiProgressBarHorizontal();
            this.btnDownloadApps = new System.Windows.Forms.Button();
            this.setDownDirLbl = new System.Windows.Forms.Label();
            this.txtDownloadFolderTextBox = new CuoreUI.Controls.cuiTextBox();
            this.txtDownloadFolderButton = new CuoreUI.Controls.cuiButton();
            this.txtDownloadStatus = new System.Windows.Forms.Label();
            this.linkWarnings = new System.Windows.Forms.LinkLabel();
            this.bitPref = new System.Windows.Forms.Label();
            this.goToDownloadsB = new System.Windows.Forms.Button();
            this.groupSystemTools = new System.Windows.Forms.Panel();
            this.cleanerTab = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnWinClean = new System.Windows.Forms.Button();
            this.analyzeDriveB = new System.Windows.Forms.Button();
            this.checkSelectAll = new System.Windows.Forms.LinkLabel();
            this.lblPretext = new System.Windows.Forms.Label();
            this.cleanDriveB = new System.Windows.Forms.Button();
            this.lblFootprint = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.listCleanPreview = new Optimizer.MoonCheckList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bravePasswords = new CuoreUI.Controls.cuiCheckbox();
            this.braveSession = new CuoreUI.Controls.cuiCheckbox();
            this.braveHistory = new CuoreUI.Controls.cuiCheckbox();
            this.braveCookies = new CuoreUI.Controls.cuiCheckbox();
            this.braveCache = new CuoreUI.Controls.cuiCheckbox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edgeSession = new CuoreUI.Controls.cuiCheckbox();
            this.edgeHistory = new CuoreUI.Controls.cuiCheckbox();
            this.edgeCookies = new CuoreUI.Controls.cuiCheckbox();
            this.edgeCache = new CuoreUI.Controls.cuiCheckbox();
            this.IECache = new CuoreUI.Controls.cuiCheckbox();
            this.firefoxHistory = new CuoreUI.Controls.cuiCheckbox();
            this.firefoxCookies = new CuoreUI.Controls.cuiCheckbox();
            this.firefoxCache = new CuoreUI.Controls.cuiCheckbox();
            this.chromePws = new CuoreUI.Controls.cuiCheckbox();
            this.chromeSession = new CuoreUI.Controls.cuiCheckbox();
            this.chromeHistory = new CuoreUI.Controls.cuiCheckbox();
            this.chromeCookies = new CuoreUI.Controls.cuiCheckbox();
            this.chromeCache = new CuoreUI.Controls.cuiCheckbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.checkErrorReports = new CuoreUI.Controls.cuiCheckbox();
            this.checkTemp = new CuoreUI.Controls.cuiCheckbox();
            this.checkBin = new CuoreUI.Controls.cuiCheckbox();
            this.checkMiniDumps = new CuoreUI.Controls.cuiCheckbox();
            this.pingerTab = new System.Windows.Forms.TabPage();
            this.netTools = new Optimizer.MoonTabs();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetDns = new System.Windows.Forms.Button();
            this.txtDns6B = new System.Windows.Forms.TextBox();
            this.txtDns6A = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDns4B = new System.Windows.Forms.TextBox();
            this.txtDns4A = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCustomDns = new CuoreUI.Controls.cuiCheckbox();
            this.chkAllNics = new CuoreUI.Controls.cuiCheckbox();
            this.dnsTitle = new System.Windows.Forms.Label();
            this.linkDNSv6A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4A = new System.Windows.Forms.LinkLabel();
            this.linkDNSv6 = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenNetwork = new System.Windows.Forms.Button();
            this.flushCacheB = new System.Windows.Forms.Button();
            this.boxAdapter = new CuoreUI.Controls.cuiComboBox();
            this.boxDNS = new CuoreUI.Controls.cuiComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.copyB = new System.Windows.Forms.Button();
            this.copyIPB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listPingResults = new CuoreUI.Controls.cuiListbox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnShodan = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtPingInput = new System.Windows.Forms.TextBox();
            this.lblPinger = new System.Windows.Forms.Label();
            this.pingerTitle = new System.Windows.Forms.Label();
            this.hostsEditorTab = new System.Windows.Forms.TabPage();
            this.hostsLocateBtn = new CuoreUI.Controls.cuiButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkAdvancedEdit = new System.Windows.Forms.LinkLabel();
            this.linkRestoreDefault = new System.Windows.Forms.LinkLabel();
            this.lblLock = new System.Windows.Forms.Label();
            this.panelList = new System.Windows.Forms.Panel();
            this.listHostEntries = new CuoreUI.Controls.cuiListbox();
            this.refreshHostsB = new System.Windows.Forms.Button();
            this.removeHostB = new System.Windows.Forms.Button();
            this.removeAllHostsB = new System.Windows.Forms.Button();
            this.addHostB = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.chkIncludeWww = new CuoreUI.Controls.cuiCheckbox();
            this.chkReadOnly = new CuoreUI.Controls.cuiCheckbox();
            this.chkBlock = new CuoreUI.Controls.cuiCheckbox();
            this.hostsTitle = new System.Windows.Forms.Label();
            this.registryFixerTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regLbl = new System.Windows.Forms.Label();
            this.regFixB = new CuoreUI.Controls.cuiButton();
            this.checkRestartExplorer = new CuoreUI.Controls.cuiCheckbox();
            this.checkRegistryEditor = new CuoreUI.Controls.cuiCheckbox();
            this.checkEnableAll = new CuoreUI.Controls.cuiCheckbox();
            this.checkContextMenu = new CuoreUI.Controls.cuiCheckbox();
            this.checkTaskManager = new CuoreUI.Controls.cuiCheckbox();
            this.checkCommandPrompt = new CuoreUI.Controls.cuiCheckbox();
            this.checkFirewall = new CuoreUI.Controls.cuiCheckbox();
            this.checkRunDialog = new CuoreUI.Controls.cuiCheckbox();
            this.checkFolderOptions = new CuoreUI.Controls.cuiCheckbox();
            this.checkControlPanel = new CuoreUI.Controls.cuiCheckbox();
            this.registryTitle = new System.Windows.Forms.Label();
            this.indiciumTab = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.specsTree = new Optimizer.MoonTree();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCopyHW = new CuoreUI.Controls.cuiButton();
            this.btnSaveHW = new CuoreUI.Controls.cuiButton();
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
            this.btnAddItem = new CuoreUI.Controls.cuiButton();
            this.itemnamegroup = new CuoreUI.Controls.cuiGroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.security = new CuoreUI.Controls.cuiGroupBox();
            this.checkShift = new CuoreUI.Controls.cuiCheckbox();
            this.itemposition = new CuoreUI.Controls.cuiGroupBox();
            this.radioTop = new Optimizer.MoonRadio();
            this.radioMiddle = new Optimizer.MoonRadio();
            this.radioBottom = new Optimizer.MoonRadio();
            this.icontoaddgroup = new CuoreUI.Controls.cuiGroupBox();
            this.checkDefaultIcon = new CuoreUI.Controls.cuiCheckbox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.itemtoaddgroup = new CuoreUI.Controls.cuiGroupBox();
            this.btnBrowseItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.itemtype = new CuoreUI.Controls.cuiGroupBox();
            this.radioCommand = new Optimizer.MoonRadio();
            this.radioProgram = new Optimizer.MoonRadio();
            this.radioFolder = new Optimizer.MoonRadio();
            this.radioLink = new Optimizer.MoonRadio();
            this.radioFile = new Optimizer.MoonRadio();
            this.addItemL = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listDesktopItems = new CuoreUI.Controls.cuiListbox();
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
            this.listCustomCommands = new CuoreUI.Controls.cuiListbox();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.listSystemVariables = new CuoreUI.Controls.cuiListbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSysVar = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFontsNumber = new System.Windows.Forms.Label();
            this.lblFontsCount = new System.Windows.Forms.Label();
            this.txtSearchFonts = new System.Windows.Forms.TextBox();
            this.btnRestoreFont = new System.Windows.Forms.Button();
            this.btnSetGlobalFont = new System.Windows.Forms.Button();
            this.lblCurrentFont = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRefreshFonts = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listFonts = new CuoreUI.Controls.cuiListbox();
            this.fontSetTitle = new System.Windows.Forms.Label();
            this.optionsTab = new System.Windows.Forms.TabPage();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnDismScan = new CuoreUI.Controls.cuiButton();
            this.btnSfcScannow = new CuoreUI.Controls.cuiButton();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.picFlag = new CuoreUI.Controls.cuiPictureBox();
            this.boxLang = new CuoreUI.Controls.cuiComboBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lblTroubleshoot = new System.Windows.Forms.Label();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.LinkLabel();
            this.lblTheming = new System.Windows.Forms.Label();
            this.autoUpdateToggle = new Optimizer.ToggleCard();
            this.autoStartToggle = new Optimizer.ToggleCard();
            this.quickAccessToggle = new Optimizer.ToggleCard();
            this.languagesL = new System.Windows.Forms.Label();
            this.btnReinforce = new CuoreUI.Controls.cuiButton();
            this.btnOpenConf = new CuoreUI.Controls.cuiButton();
            this.btnViewLog = new CuoreUI.Controls.cuiButton();
            this.btnUpdate = new CuoreUI.Controls.cuiButton();
            this.btnResetConfig = new CuoreUI.Controls.cuiButton();
            this.colorPicker1 = new CuoreUI.Controls.cuiColorPickerWheel();
            this.bpanel.SuspendLayout();
            this.indiciumMenu.SuspendLayout();
            this.launcherMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).BeginInit();
            this.panel17.SuspendLayout();
            this.tabCollection.SuspendLayout();
            this.universalTab.SuspendLayout();
            this.panel16.SuspendLayout();
            this.windows10Tab.SuspendLayout();
            this.panelWin11Tweaks.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.modernAppsTab.SuspendLayout();
            this.startupTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.appsTab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelCommonApps.SuspendLayout();
            this.cleanerTab.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpanel
            // 
            this.bpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bpanel.Controls.Add(this.tabCollection);
            this.bpanel.Location = new System.Drawing.Point(0, 69);
            this.bpanel.Margin = new System.Windows.Forms.Padding(2);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(1299, 801);
            this.bpanel.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Optimizer";
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtVersion.Location = new System.Drawing.Point(67, 37);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(33, 15);
            this.txtVersion.TabIndex = 1;
            this.txtVersion.Text = "{VN}";
            // 
            // picUpdate
            // 
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(154, 16);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(20, 20);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 71;
            this.picUpdate.TabStop = false;
            this.picUpdate.Visible = false;
            this.picUpdate.Click += new System.EventHandler(this.picUpdate_Click);
            // 
            // picLab
            // 
            this.picLab.Image = ((System.Drawing.Image)(resources.GetObject("picLab.Image")));
            this.picLab.Location = new System.Drawing.Point(154, 16);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(20, 20);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLab.TabIndex = 72;
            this.picLab.TabStop = false;
            this.picLab.Visible = false;
            // 
            // picRestartNeeded
            // 
            this.picRestartNeeded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRestartNeeded.Image = ((System.Drawing.Image)(resources.GetObject("picRestartNeeded.Image")));
            this.picRestartNeeded.Location = new System.Drawing.Point(1254, 22);
            this.picRestartNeeded.Name = "picRestartNeeded";
            this.picRestartNeeded.Size = new System.Drawing.Size(24, 24);
            this.picRestartNeeded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestartNeeded.TabIndex = 73;
            this.picRestartNeeded.TabStop = false;
            this.picRestartNeeded.Visible = false;
            this.picRestartNeeded.Click += new System.EventHandler(this.picRestartNeeded_Click);
            // 
            // restartAndApply
            // 
            this.restartAndApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartAndApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.restartAndApply.ForeColor = System.Drawing.Color.Gray;
            this.restartAndApply.Location = new System.Drawing.Point(1000, 23);
            this.restartAndApply.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restartAndApply.Name = "restartAndApply";
            this.restartAndApply.Size = new System.Drawing.Size(254, 21);
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
            // pictureBox1
            // 
            this.pictureBox1.Content = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Content")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ImageTint = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.OutlineThickness = 1F;
            this.pictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.pictureBox1.Rotation = 0;
            this.pictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 75;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.pictureBox1);
            this.panel17.Location = new System.Drawing.Point(19, 17);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(38, 38);
            this.panel17.TabIndex = 76;
            // 
            // tabCollection
            // 
            this.tabCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabCollection.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCollection.ItemSize = new System.Drawing.Size(100, 36);
            this.tabCollection.Location = new System.Drawing.Point(0, 0);
            this.tabCollection.Margin = new System.Windows.Forms.Padding(0);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Drawing.Point(0, 0);
            this.tabCollection.SelectedIndex = 0;
            this.tabCollection.Size = new System.Drawing.Size(1297, 732);
            this.tabCollection.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCollection.TabIndex = 0;
            this.tabCollection.SelectedIndexChanged += new System.EventHandler(this.aio_SelectedIndexChanged);
            // 
            // universalTab
            // 
            this.universalTab.AutoScroll = true;
            this.universalTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.universalTab.Controls.Add(this.enableUtcSw);
            this.universalTab.Controls.Add(this.noMenuDelaySw);
            this.universalTab.Controls.Add(this.allTrayIconsSw);
            this.universalTab.Controls.Add(this.disableOneDriveSw);
            this.universalTab.Controls.Add(this.label13);
            this.universalTab.Controls.Add(this.label4a);
            this.universalTab.Controls.Add(this.label14s);
            this.universalTab.Controls.Add(this.nvidiaTelemetrySw);
            this.universalTab.Controls.Add(this.smb2Sw);
            this.universalTab.Controls.Add(this.smb1Sw);
            this.universalTab.Controls.Add(this.chromeTelemetrySw);
            this.universalTab.Controls.Add(this.ffTelemetrySw);
            this.universalTab.Controls.Add(this.vsSw);
            this.universalTab.Controls.Add(this.reportingSw);
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
            this.universalTab.Controls.Add(this.faxSw);
            this.universalTab.Controls.Add(this.performanceSw);
            this.universalTab.Controls.Add(this.panel16);
            this.universalTab.Location = new System.Drawing.Point(4, 40);
            this.universalTab.Margin = new System.Windows.Forms.Padding(2);
            this.universalTab.Name = "universalTab";
            this.universalTab.Padding = new System.Windows.Forms.Padding(2);
            this.universalTab.Size = new System.Drawing.Size(1289, 688);
            this.universalTab.TabIndex = 0;
            this.universalTab.Text = "General";
            // 
            // enableUtcSw
            // 
            this.enableUtcSw.AccessibleName = "Enable UTC Time";
            this.enableUtcSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.enableUtcSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.enableUtcSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableUtcSw.ForeColor = System.Drawing.Color.White;
            this.enableUtcSw.LabelText = "Enable UTC Time";
            this.enableUtcSw.Location = new System.Drawing.Point(21, 340);
            this.enableUtcSw.Margin = new System.Windows.Forms.Padding(6);
            this.enableUtcSw.Name = "enableUtcSw";
            this.enableUtcSw.Size = new System.Drawing.Size(414, 24);
            this.enableUtcSw.TabIndex = 235;
            this.enableUtcSw.Tag = "themeable";
            this.enableUtcSw.ToggleChecked = false;
            // 
            // noMenuDelaySw
            // 
            this.noMenuDelaySw.AccessibleName = "Remove menus delay";
            this.noMenuDelaySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.noMenuDelaySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.noMenuDelaySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMenuDelaySw.ForeColor = System.Drawing.Color.White;
            this.noMenuDelaySw.LabelText = "Remove menus delay";
            this.noMenuDelaySw.Location = new System.Drawing.Point(21, 100);
            this.noMenuDelaySw.Margin = new System.Windows.Forms.Padding(6);
            this.noMenuDelaySw.Name = "noMenuDelaySw";
            this.noMenuDelaySw.Size = new System.Drawing.Size(414, 24);
            this.noMenuDelaySw.TabIndex = 234;
            this.noMenuDelaySw.Tag = "themeable";
            this.noMenuDelaySw.ToggleChecked = false;
            // 
            // allTrayIconsSw
            // 
            this.allTrayIconsSw.AccessibleName = "Show all notification icons";
            this.allTrayIconsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.allTrayIconsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.allTrayIconsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTrayIconsSw.ForeColor = System.Drawing.Color.White;
            this.allTrayIconsSw.LabelText = "Show all notification icons";
            this.allTrayIconsSw.Location = new System.Drawing.Point(21, 70);
            this.allTrayIconsSw.Margin = new System.Windows.Forms.Padding(6);
            this.allTrayIconsSw.Name = "allTrayIconsSw";
            this.allTrayIconsSw.Size = new System.Drawing.Size(414, 24);
            this.allTrayIconsSw.TabIndex = 233;
            this.allTrayIconsSw.Tag = "themeable";
            this.allTrayIconsSw.ToggleChecked = false;
            // 
            // disableOneDriveSw
            // 
            this.disableOneDriveSw.AccessibleName = "Disable OneDrive";
            this.disableOneDriveSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.disableOneDriveSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.disableOneDriveSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableOneDriveSw.ForeColor = System.Drawing.Color.White;
            this.disableOneDriveSw.LabelText = "Disable OneDrive";
            this.disableOneDriveSw.Location = new System.Drawing.Point(461, 372);
            this.disableOneDriveSw.Margin = new System.Windows.Forms.Padding(6);
            this.disableOneDriveSw.Name = "disableOneDriveSw";
            this.disableOneDriveSw.Size = new System.Drawing.Size(490, 24);
            this.disableOneDriveSw.TabIndex = 232;
            this.disableOneDriveSw.Tag = "themeable";
            this.disableOneDriveSw.ToggleChecked = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(461, 192);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 228;
            this.label13.Tag = "";
            this.label13.Text = "Privacy";
            // 
            // label4a
            // 
            this.label4a.AutoSize = true;
            this.label4a.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4a.ForeColor = System.Drawing.Color.Gray;
            this.label4a.Location = new System.Drawing.Point(461, 11);
            this.label4a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4a.Name = "label4a";
            this.label4a.Size = new System.Drawing.Size(43, 20);
            this.label4a.TabIndex = 227;
            this.label4a.Tag = "";
            this.label4a.Text = "Apps";
            // 
            // label14s
            // 
            this.label14s.AutoSize = true;
            this.label14s.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14s.ForeColor = System.Drawing.Color.Gray;
            this.label14s.Location = new System.Drawing.Point(21, 11);
            this.label14s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14s.Name = "label14s";
            this.label14s.Size = new System.Drawing.Size(56, 20);
            this.label14s.TabIndex = 225;
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
            this.nvidiaTelemetrySw.Location = new System.Drawing.Point(461, 130);
            this.nvidiaTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.nvidiaTelemetrySw.Name = "nvidiaTelemetrySw";
            this.nvidiaTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.nvidiaTelemetrySw.TabIndex = 224;
            this.nvidiaTelemetrySw.Tag = "themeable";
            this.nvidiaTelemetrySw.ToggleChecked = false;
            // 
            // smb2Sw
            // 
            this.smb2Sw.AccessibleName = "Disable SMBv2 Protocol";
            this.smb2Sw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.smb2Sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.smb2Sw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smb2Sw.ForeColor = System.Drawing.Color.White;
            this.smb2Sw.LabelText = "Disable SMBv2 Protocol";
            this.smb2Sw.Location = new System.Drawing.Point(461, 342);
            this.smb2Sw.Margin = new System.Windows.Forms.Padding(6);
            this.smb2Sw.Name = "smb2Sw";
            this.smb2Sw.Size = new System.Drawing.Size(490, 24);
            this.smb2Sw.TabIndex = 222;
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
            this.smb1Sw.Location = new System.Drawing.Point(461, 312);
            this.smb1Sw.Margin = new System.Windows.Forms.Padding(6);
            this.smb1Sw.Name = "smb1Sw";
            this.smb1Sw.Size = new System.Drawing.Size(490, 24);
            this.smb1Sw.TabIndex = 221;
            this.smb1Sw.Tag = "themeable";
            this.smb1Sw.ToggleChecked = false;
            // 
            // chromeTelemetrySw
            // 
            this.chromeTelemetrySw.AccessibleName = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chromeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.chromeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.chromeTelemetrySw.LabelText = "Disable Google Chrome Telemetry";
            this.chromeTelemetrySw.Location = new System.Drawing.Point(461, 100);
            this.chromeTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.chromeTelemetrySw.Name = "chromeTelemetrySw";
            this.chromeTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.chromeTelemetrySw.TabIndex = 219;
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
            this.ffTelemetrySw.Location = new System.Drawing.Point(461, 70);
            this.ffTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.ffTelemetrySw.Name = "ffTelemetrySw";
            this.ffTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.ffTelemetrySw.TabIndex = 218;
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
            this.vsSw.Location = new System.Drawing.Point(461, 160);
            this.vsSw.Margin = new System.Windows.Forms.Padding(6);
            this.vsSw.Name = "vsSw";
            this.vsSw.Size = new System.Drawing.Size(490, 24);
            this.vsSw.TabIndex = 217;
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
            this.reportingSw.Location = new System.Drawing.Point(21, 160);
            this.reportingSw.Margin = new System.Windows.Forms.Padding(6);
            this.reportingSw.Name = "reportingSw";
            this.reportingSw.Size = new System.Drawing.Size(414, 24);
            this.reportingSw.TabIndex = 216;
            this.reportingSw.Tag = "themeable";
            this.reportingSw.ToggleChecked = false;
            // 
            // officeTelemetrySw
            // 
            this.officeTelemetrySw.AccessibleName = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.officeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.officeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.officeTelemetrySw.LabelText = "Disable Office 2016 Telemetry";
            this.officeTelemetrySw.Location = new System.Drawing.Point(461, 40);
            this.officeTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.officeTelemetrySw.Name = "officeTelemetrySw";
            this.officeTelemetrySw.Size = new System.Drawing.Size(490, 24);
            this.officeTelemetrySw.TabIndex = 214;
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
            this.smartScreenSw.Location = new System.Drawing.Point(21, 310);
            this.smartScreenSw.Margin = new System.Windows.Forms.Padding(6);
            this.smartScreenSw.Name = "smartScreenSw";
            this.smartScreenSw.Size = new System.Drawing.Size(414, 24);
            this.smartScreenSw.TabIndex = 213;
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
            this.networkSw.Location = new System.Drawing.Point(21, 130);
            this.networkSw.Margin = new System.Windows.Forms.Padding(6);
            this.networkSw.Name = "networkSw";
            this.networkSw.Size = new System.Drawing.Size(414, 24);
            this.networkSw.TabIndex = 212;
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
            this.telemetryTasksSw.Location = new System.Drawing.Point(461, 222);
            this.telemetryTasksSw.Margin = new System.Windows.Forms.Padding(6);
            this.telemetryTasksSw.Name = "telemetryTasksSw";
            this.telemetryTasksSw.Size = new System.Drawing.Size(490, 24);
            this.telemetryTasksSw.TabIndex = 211;
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
            this.defenderSw.Location = new System.Drawing.Point(21, 370);
            this.defenderSw.Margin = new System.Windows.Forms.Padding(6);
            this.defenderSw.Name = "defenderSw";
            this.defenderSw.Size = new System.Drawing.Size(414, 24);
            this.defenderSw.TabIndex = 210;
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
            this.homegroupSw.Location = new System.Drawing.Point(461, 282);
            this.homegroupSw.Margin = new System.Windows.Forms.Padding(6);
            this.homegroupSw.Name = "homegroupSw";
            this.homegroupSw.Size = new System.Drawing.Size(490, 24);
            this.homegroupSw.TabIndex = 209;
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
            this.stickySw.Location = new System.Drawing.Point(21, 280);
            this.stickySw.Margin = new System.Windows.Forms.Padding(6);
            this.stickySw.Name = "stickySw";
            this.stickySw.Size = new System.Drawing.Size(414, 24);
            this.stickySw.TabIndex = 208;
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
            this.compatSw.Location = new System.Drawing.Point(21, 190);
            this.compatSw.Margin = new System.Windows.Forms.Padding(6);
            this.compatSw.Name = "compatSw";
            this.compatSw.Size = new System.Drawing.Size(414, 24);
            this.compatSw.TabIndex = 207;
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
            this.mediaSharingSw.Location = new System.Drawing.Point(461, 252);
            this.mediaSharingSw.Margin = new System.Windows.Forms.Padding(6);
            this.mediaSharingSw.Name = "mediaSharingSw";
            this.mediaSharingSw.Size = new System.Drawing.Size(490, 24);
            this.mediaSharingSw.TabIndex = 206;
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
            this.printSw.Location = new System.Drawing.Point(21, 220);
            this.printSw.Margin = new System.Windows.Forms.Padding(6);
            this.printSw.Name = "printSw";
            this.printSw.Size = new System.Drawing.Size(414, 24);
            this.printSw.TabIndex = 205;
            this.printSw.Tag = "themeable";
            this.printSw.ToggleChecked = false;
            // 
            // faxSw
            // 
            this.faxSw.AccessibleName = "Disable Fax Service";
            this.faxSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.faxSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.faxSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxSw.ForeColor = System.Drawing.Color.White;
            this.faxSw.LabelText = "Disable Fax Service";
            this.faxSw.Location = new System.Drawing.Point(21, 250);
            this.faxSw.Margin = new System.Windows.Forms.Padding(6);
            this.faxSw.Name = "faxSw";
            this.faxSw.Size = new System.Drawing.Size(414, 24);
            this.faxSw.TabIndex = 203;
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
            this.performanceSw.Location = new System.Drawing.Point(21, 40);
            this.performanceSw.Margin = new System.Windows.Forms.Padding(6);
            this.performanceSw.Name = "performanceSw";
            this.performanceSw.Size = new System.Drawing.Size(414, 24);
            this.performanceSw.TabIndex = 202;
            this.performanceSw.Tag = "themeable";
            this.performanceSw.ToggleChecked = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.drives);
            this.panel16.Controls.Add(this.superfetchSw);
            this.panel16.Controls.Add(this.systemRestoreSw);
            this.panel16.Controls.Add(this.hibernateSw);
            this.panel16.Controls.Add(this.winSearchSw);
            this.panel16.Controls.Add(this.ntfsStampSw);
            this.panel16.Location = new System.Drawing.Point(23, 403);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(410, 175);
            this.panel16.TabIndex = 236;
            // 
            // drives
            // 
            this.drives.AutoSize = true;
            this.drives.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drives.ForeColor = System.Drawing.Color.Gray;
            this.drives.Location = new System.Drawing.Point(-2, -2);
            this.drives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drives.Name = "drives";
            this.drives.Size = new System.Drawing.Size(43, 20);
            this.drives.TabIndex = 226;
            this.drives.Tag = "";
            this.drives.Text = "Disks";
            // 
            // superfetchSw
            // 
            this.superfetchSw.AccessibleName = "Disable Superfetch";
            this.superfetchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.superfetchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.superfetchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superfetchSw.ForeColor = System.Drawing.Color.White;
            this.superfetchSw.LabelText = "Disable Superfetch";
            this.superfetchSw.Location = new System.Drawing.Point(-2, 59);
            this.superfetchSw.Margin = new System.Windows.Forms.Padding(6);
            this.superfetchSw.Name = "superfetchSw";
            this.superfetchSw.Size = new System.Drawing.Size(414, 24);
            this.superfetchSw.TabIndex = 204;
            this.superfetchSw.Tag = "themeable";
            this.superfetchSw.ToggleChecked = false;
            // 
            // systemRestoreSw
            // 
            this.systemRestoreSw.AccessibleName = "Disable System Restore";
            this.systemRestoreSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.systemRestoreSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.systemRestoreSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemRestoreSw.ForeColor = System.Drawing.Color.White;
            this.systemRestoreSw.LabelText = "Disable System Restore";
            this.systemRestoreSw.Location = new System.Drawing.Point(-2, 29);
            this.systemRestoreSw.Margin = new System.Windows.Forms.Padding(6);
            this.systemRestoreSw.Name = "systemRestoreSw";
            this.systemRestoreSw.Size = new System.Drawing.Size(414, 24);
            this.systemRestoreSw.TabIndex = 215;
            this.systemRestoreSw.Tag = "themeable";
            this.systemRestoreSw.ToggleChecked = false;
            // 
            // hibernateSw
            // 
            this.hibernateSw.AccessibleName = "Disable Hibernation";
            this.hibernateSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hibernateSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hibernateSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hibernateSw.ForeColor = System.Drawing.Color.White;
            this.hibernateSw.LabelText = "Disable Hibernation";
            this.hibernateSw.Location = new System.Drawing.Point(-2, 89);
            this.hibernateSw.Margin = new System.Windows.Forms.Padding(6);
            this.hibernateSw.Name = "hibernateSw";
            this.hibernateSw.Size = new System.Drawing.Size(414, 24);
            this.hibernateSw.TabIndex = 220;
            this.hibernateSw.Tag = "themeable";
            this.hibernateSw.ToggleChecked = false;
            // 
            // winSearchSw
            // 
            this.winSearchSw.AccessibleName = "Disable Search";
            this.winSearchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.winSearchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.winSearchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winSearchSw.ForeColor = System.Drawing.Color.White;
            this.winSearchSw.LabelText = "Disable Search";
            this.winSearchSw.Location = new System.Drawing.Point(-2, 149);
            this.winSearchSw.Margin = new System.Windows.Forms.Padding(6);
            this.winSearchSw.Name = "winSearchSw";
            this.winSearchSw.Size = new System.Drawing.Size(414, 24);
            this.winSearchSw.TabIndex = 229;
            this.winSearchSw.Tag = "themeable";
            this.winSearchSw.ToggleChecked = false;
            // 
            // ntfsStampSw
            // 
            this.ntfsStampSw.AccessibleName = "Disable NTFS Timestamp";
            this.ntfsStampSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.ntfsStampSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ntfsStampSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfsStampSw.ForeColor = System.Drawing.Color.White;
            this.ntfsStampSw.LabelText = "Disable NTFS Timestamp";
            this.ntfsStampSw.Location = new System.Drawing.Point(-2, 119);
            this.ntfsStampSw.Margin = new System.Windows.Forms.Padding(6);
            this.ntfsStampSw.Name = "ntfsStampSw";
            this.ntfsStampSw.Size = new System.Drawing.Size(414, 24);
            this.ntfsStampSw.TabIndex = 223;
            this.ntfsStampSw.Tag = "themeable";
            this.ntfsStampSw.ToggleChecked = false;
            // 
            // windows10Tab
            // 
            this.windows10Tab.AutoScroll = true;
            this.windows10Tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.windows10Tab.Controls.Add(this.modernStandbySw);
            this.windows10Tab.Controls.Add(this.newsInterestsSw);
            this.windows10Tab.Controls.Add(this.hideSearchSw);
            this.windows10Tab.Controls.Add(this.hideWeatherSw);
            this.windows10Tab.Controls.Add(this.classicPhotoViewerSw);
            this.windows10Tab.Controls.Add(this.edgeAiSw);
            this.windows10Tab.Controls.Add(this.edgeTelemetrySw);
            this.windows10Tab.Controls.Add(this.label18);
            this.windows10Tab.Controls.Add(this.label17);
            this.windows10Tab.Controls.Add(this.label16);
            this.windows10Tab.Controls.Add(this.label15);
            this.windows10Tab.Controls.Add(this.label14);
            this.windows10Tab.Controls.Add(this.vbsSw);
            this.windows10Tab.Controls.Add(this.gameModeSw);
            this.windows10Tab.Controls.Add(this.storeUpdatesSw);
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
            this.windows10Tab.Controls.Add(this.peopleSw);
            this.windows10Tab.Controls.Add(this.oldExplorerSw);
            this.windows10Tab.Controls.Add(this.adsSw);
            this.windows10Tab.Controls.Add(this.panelWin11Tweaks);
            this.windows10Tab.Location = new System.Drawing.Point(4, 40);
            this.windows10Tab.Margin = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Name = "windows10Tab";
            this.windows10Tab.Padding = new System.Windows.Forms.Padding(2);
            this.windows10Tab.Size = new System.Drawing.Size(1289, 688);
            this.windows10Tab.TabIndex = 1;
            this.windows10Tab.Text = "Windows 10";
            // 
            // modernStandbySw
            // 
            this.modernStandbySw.AccessibleName = "Disable Modern Standby";
            this.modernStandbySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.modernStandbySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modernStandbySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernStandbySw.ForeColor = System.Drawing.Color.White;
            this.modernStandbySw.LabelText = "Disable Modern Standby";
            this.modernStandbySw.Location = new System.Drawing.Point(21, 340);
            this.modernStandbySw.Margin = new System.Windows.Forms.Padding(6);
            this.modernStandbySw.Name = "modernStandbySw";
            this.modernStandbySw.Size = new System.Drawing.Size(414, 24);
            this.modernStandbySw.TabIndex = 238;
            this.modernStandbySw.Tag = "themeable";
            this.modernStandbySw.ToggleChecked = false;
            // 
            // newsInterestsSw
            // 
            this.newsInterestsSw.AccessibleName = "Disable News && Interests";
            this.newsInterestsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.newsInterestsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.newsInterestsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsInterestsSw.ForeColor = System.Drawing.Color.White;
            this.newsInterestsSw.LabelText = "Disable News && Interests";
            this.newsInterestsSw.Location = new System.Drawing.Point(461, 130);
            this.newsInterestsSw.Margin = new System.Windows.Forms.Padding(6);
            this.newsInterestsSw.Name = "newsInterestsSw";
            this.newsInterestsSw.Size = new System.Drawing.Size(414, 24);
            this.newsInterestsSw.TabIndex = 237;
            this.newsInterestsSw.Tag = "themeable";
            this.newsInterestsSw.ToggleChecked = false;
            // 
            // hideSearchSw
            // 
            this.hideSearchSw.AccessibleName = "Hide Taskbar Search";
            this.hideSearchSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hideSearchSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideSearchSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideSearchSw.ForeColor = System.Drawing.Color.White;
            this.hideSearchSw.LabelText = "Hide Taskbar Search";
            this.hideSearchSw.Location = new System.Drawing.Point(21, 100);
            this.hideSearchSw.Margin = new System.Windows.Forms.Padding(6);
            this.hideSearchSw.Name = "hideSearchSw";
            this.hideSearchSw.Size = new System.Drawing.Size(414, 24);
            this.hideSearchSw.TabIndex = 236;
            this.hideSearchSw.Tag = "themeable";
            this.hideSearchSw.ToggleChecked = false;
            // 
            // hideWeatherSw
            // 
            this.hideWeatherSw.AccessibleName = "Hide Taskbar Weather";
            this.hideWeatherSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hideWeatherSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideWeatherSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideWeatherSw.ForeColor = System.Drawing.Color.White;
            this.hideWeatherSw.LabelText = "Hide Taskbar Weather";
            this.hideWeatherSw.Location = new System.Drawing.Point(21, 70);
            this.hideWeatherSw.Margin = new System.Windows.Forms.Padding(6);
            this.hideWeatherSw.Name = "hideWeatherSw";
            this.hideWeatherSw.Size = new System.Drawing.Size(414, 24);
            this.hideWeatherSw.TabIndex = 235;
            this.hideWeatherSw.Tag = "themeable";
            this.hideWeatherSw.ToggleChecked = false;
            // 
            // classicPhotoViewerSw
            // 
            this.classicPhotoViewerSw.AccessibleName = "Restore Classic Photo Viewer";
            this.classicPhotoViewerSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.classicPhotoViewerSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.classicPhotoViewerSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicPhotoViewerSw.ForeColor = System.Drawing.Color.White;
            this.classicPhotoViewerSw.LabelText = "Restore Classic Photo Viewer";
            this.classicPhotoViewerSw.Location = new System.Drawing.Point(21, 310);
            this.classicPhotoViewerSw.Margin = new System.Windows.Forms.Padding(6);
            this.classicPhotoViewerSw.Name = "classicPhotoViewerSw";
            this.classicPhotoViewerSw.Size = new System.Drawing.Size(414, 24);
            this.classicPhotoViewerSw.TabIndex = 180;
            this.classicPhotoViewerSw.Tag = "themeable";
            this.classicPhotoViewerSw.ToggleChecked = false;
            // 
            // edgeAiSw
            // 
            this.edgeAiSw.AccessibleName = "Disable Edge Discover";
            this.edgeAiSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.edgeAiSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeAiSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeAiSw.ForeColor = System.Drawing.Color.White;
            this.edgeAiSw.LabelText = "Disable Edge Discover";
            this.edgeAiSw.Location = new System.Drawing.Point(461, 220);
            this.edgeAiSw.Margin = new System.Windows.Forms.Padding(6);
            this.edgeAiSw.Name = "edgeAiSw";
            this.edgeAiSw.Size = new System.Drawing.Size(414, 24);
            this.edgeAiSw.TabIndex = 179;
            this.edgeAiSw.Tag = "themeable";
            this.edgeAiSw.ToggleChecked = false;
            // 
            // edgeTelemetrySw
            // 
            this.edgeTelemetrySw.AccessibleName = "Disable Edge Telemetry";
            this.edgeTelemetrySw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.edgeTelemetrySw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.edgeTelemetrySw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeTelemetrySw.ForeColor = System.Drawing.Color.White;
            this.edgeTelemetrySw.LabelText = "Disable Edge Telemetry";
            this.edgeTelemetrySw.Location = new System.Drawing.Point(461, 190);
            this.edgeTelemetrySw.Margin = new System.Windows.Forms.Padding(6);
            this.edgeTelemetrySw.Name = "edgeTelemetrySw";
            this.edgeTelemetrySw.Size = new System.Drawing.Size(414, 24);
            this.edgeTelemetrySw.TabIndex = 177;
            this.edgeTelemetrySw.Tag = "themeable";
            this.edgeTelemetrySw.ToggleChecked = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(461, 376);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 176;
            this.label18.Tag = "";
            this.label18.Text = "Touch";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(461, 252);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 175;
            this.label17.Tag = "";
            this.label17.Text = "Gaming";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(461, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 174;
            this.label16.Tag = "";
            this.label16.Text = "Privacy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(21, 373);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 173;
            this.label15.Tag = "";
            this.label15.Text = "Windows Update";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(21, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 170;
            this.label14.Tag = "";
            this.label14.Text = "System";
            // 
            // vbsSw
            // 
            this.vbsSw.AccessibleName = "Disable Virtualization Based Security";
            this.vbsSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.vbsSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vbsSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbsSw.ForeColor = System.Drawing.Color.White;
            this.vbsSw.LabelText = "Disable Virtualization Based Security";
            this.vbsSw.Location = new System.Drawing.Point(21, 280);
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
            this.gameModeSw.Location = new System.Drawing.Point(461, 282);
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
            this.storeUpdatesSw.Location = new System.Drawing.Point(21, 434);
            this.storeUpdatesSw.Margin = new System.Windows.Forms.Padding(6);
            this.storeUpdatesSw.Name = "storeUpdatesSw";
            this.storeUpdatesSw.Size = new System.Drawing.Size(414, 24);
            this.storeUpdatesSw.TabIndex = 104;
            this.storeUpdatesSw.Tag = "themeable";
            this.storeUpdatesSw.ToggleChecked = false;
            // 
            // insiderSw
            // 
            this.insiderSw.AccessibleName = "Disable Insider Service";
            this.insiderSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.insiderSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.insiderSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insiderSw.ForeColor = System.Drawing.Color.White;
            this.insiderSw.LabelText = "Disable Insider Service";
            this.insiderSw.Location = new System.Drawing.Point(21, 464);
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
            this.castSw.Location = new System.Drawing.Point(21, 250);
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
            this.gameBarSw.Location = new System.Drawing.Point(461, 342);
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
            this.sensorSw.Location = new System.Drawing.Point(21, 220);
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
            this.ccSw.Location = new System.Drawing.Point(461, 467);
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
            this.cortanaSw.Location = new System.Drawing.Point(461, 70);
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
            this.privacySw.Location = new System.Drawing.Point(461, 100);
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
            this.driversSw.Location = new System.Drawing.Point(21, 494);
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
            this.telemetryServicesSw.Location = new System.Drawing.Point(461, 40);
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
            this.autoUpdatesSw.Location = new System.Drawing.Point(21, 404);
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
            this.tpmSw.Location = new System.Drawing.Point(21, 190);
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
            this.xboxSw.Location = new System.Drawing.Point(461, 312);
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
            this.inkSw.Location = new System.Drawing.Point(461, 407);
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
            this.spellSw.Location = new System.Drawing.Point(461, 437);
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
            this.longPathsSw.Location = new System.Drawing.Point(21, 160);
            this.longPathsSw.Margin = new System.Windows.Forms.Padding(6);
            this.longPathsSw.Name = "longPathsSw";
            this.longPathsSw.Size = new System.Drawing.Size(414, 24);
            this.longPathsSw.TabIndex = 87;
            this.longPathsSw.Tag = "themeable";
            this.longPathsSw.ToggleChecked = false;
            // 
            // peopleSw
            // 
            this.peopleSw.AccessibleName = "Disable My People";
            this.peopleSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.peopleSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.peopleSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleSw.ForeColor = System.Drawing.Color.White;
            this.peopleSw.LabelText = "Disable My People";
            this.peopleSw.Location = new System.Drawing.Point(21, 130);
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
            this.oldExplorerSw.Location = new System.Drawing.Point(21, 40);
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
            this.adsSw.Location = new System.Drawing.Point(461, 160);
            this.adsSw.Margin = new System.Windows.Forms.Padding(6);
            this.adsSw.Name = "adsSw";
            this.adsSw.Size = new System.Drawing.Size(414, 24);
            this.adsSw.TabIndex = 82;
            this.adsSw.Tag = "themeable";
            this.adsSw.ToggleChecked = false;
            // 
            // panelWin11Tweaks
            // 
            this.panelWin11Tweaks.AutoScroll = true;
            this.panelWin11Tweaks.Controls.Add(this.copilotSw);
            this.panelWin11Tweaks.Controls.Add(this.label20);
            this.panelWin11Tweaks.Controls.Add(this.label19);
            this.panelWin11Tweaks.Controls.Add(this.stickersSw);
            this.panelWin11Tweaks.Controls.Add(this.compactModeSw);
            this.panelWin11Tweaks.Controls.Add(this.snapAssistSw);
            this.panelWin11Tweaks.Controls.Add(this.widgetsSw);
            this.panelWin11Tweaks.Controls.Add(this.leftTaskbarSw);
            this.panelWin11Tweaks.Controls.Add(this.classicContextSw);
            this.panelWin11Tweaks.Controls.Add(this.chatSw);
            this.panelWin11Tweaks.Location = new System.Drawing.Point(0, 494);
            this.panelWin11Tweaks.Name = "panelWin11Tweaks";
            this.panelWin11Tweaks.Size = new System.Drawing.Size(971, 179);
            this.panelWin11Tweaks.TabIndex = 80;
            this.panelWin11Tweaks.Visible = false;
            // 
            // copilotSw
            // 
            this.copilotSw.AccessibleName = "Disable CoPilot AI";
            this.copilotSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.copilotSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.copilotSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copilotSw.ForeColor = System.Drawing.Color.White;
            this.copilotSw.LabelText = "Disable CoPilot AI";
            this.copilotSw.Location = new System.Drawing.Point(461, 126);
            this.copilotSw.Margin = new System.Windows.Forms.Padding(6);
            this.copilotSw.Name = "copilotSw";
            this.copilotSw.Size = new System.Drawing.Size(414, 24);
            this.copilotSw.TabIndex = 179;
            this.copilotSw.Tag = "themeable";
            this.copilotSw.ToggleChecked = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label20.ForeColor = System.Drawing.Color.Gray;
            this.label20.Location = new System.Drawing.Point(460, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 20);
            this.label20.TabIndex = 178;
            this.label20.Tag = "";
            this.label20.Text = "Extras";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(21, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
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
            this.stickersSw.Location = new System.Drawing.Point(21, 152);
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
            this.compactModeSw.Location = new System.Drawing.Point(461, 96);
            this.compactModeSw.Margin = new System.Windows.Forms.Padding(6);
            this.compactModeSw.Name = "compactModeSw";
            this.compactModeSw.Size = new System.Drawing.Size(414, 24);
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
            this.snapAssistSw.Location = new System.Drawing.Point(462, 36);
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
            this.widgetsSw.Location = new System.Drawing.Point(21, 92);
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
            this.leftTaskbarSw.Location = new System.Drawing.Point(21, 62);
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
            this.classicContextSw.Location = new System.Drawing.Point(461, 66);
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
            this.chatSw.Location = new System.Drawing.Point(21, 122);
            this.chatSw.Margin = new System.Windows.Forms.Padding(6);
            this.chatSw.Name = "chatSw";
            this.chatSw.Size = new System.Drawing.Size(414, 24);
            this.chatSw.TabIndex = 107;
            this.chatSw.Tag = "themeable";
            this.chatSw.ToggleChecked = false;
            // 
            // advancedTab
            // 
            this.advancedTab.AutoScroll = true;
            this.advancedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.advancedTab.Controls.Add(this.regBackupSw);
            this.advancedTab.Controls.Add(this.uODSw);
            this.advancedTab.Controls.Add(this.loginVerboseSw);
            this.advancedTab.Controls.Add(this.hpetSw);
            this.advancedTab.Controls.Add(this.btnRestartDisableDefender);
            this.advancedTab.Controls.Add(this.btnRestart);
            this.advancedTab.Controls.Add(this.btnRestartSafe);
            this.advancedTab.Location = new System.Drawing.Point(4, 40);
            this.advancedTab.Margin = new System.Windows.Forms.Padding(2);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(2);
            this.advancedTab.Size = new System.Drawing.Size(1289, 688);
            this.advancedTab.TabIndex = 15;
            this.advancedTab.Text = "Advanced";
            // 
            // regBackupSw
            // 
            this.regBackupSw.AccessibleName = "Enable Registry Backups";
            this.regBackupSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.regBackupSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.regBackupSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBackupSw.ForeColor = System.Drawing.Color.White;
            this.regBackupSw.LabelText = "Enable Registry Backups";
            this.regBackupSw.Location = new System.Drawing.Point(21, 107);
            this.regBackupSw.Margin = new System.Windows.Forms.Padding(6);
            this.regBackupSw.Name = "regBackupSw";
            this.regBackupSw.Size = new System.Drawing.Size(414, 24);
            this.regBackupSw.TabIndex = 90;
            this.regBackupSw.Tag = "themeable";
            this.regBackupSw.ToggleChecked = false;
            // 
            // uODSw
            // 
            this.uODSw.AccessibleName = "Uninstall OneDrive";
            this.uODSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.uODSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.uODSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uODSw.ForeColor = System.Drawing.Color.White;
            this.uODSw.LabelText = "Uninstall OneDrive";
            this.uODSw.Location = new System.Drawing.Point(21, 77);
            this.uODSw.Margin = new System.Windows.Forms.Padding(6);
            this.uODSw.Name = "uODSw";
            this.uODSw.Size = new System.Drawing.Size(414, 24);
            this.uODSw.TabIndex = 89;
            this.uODSw.Tag = "themeable";
            this.uODSw.ToggleChecked = false;
            // 
            // loginVerboseSw
            // 
            this.loginVerboseSw.AccessibleName = "Enable Detailed Login Screen";
            this.loginVerboseSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.loginVerboseSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loginVerboseSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginVerboseSw.ForeColor = System.Drawing.Color.White;
            this.loginVerboseSw.LabelText = "Enable Detailed Login Screen";
            this.loginVerboseSw.Location = new System.Drawing.Point(21, 47);
            this.loginVerboseSw.Margin = new System.Windows.Forms.Padding(6);
            this.loginVerboseSw.Name = "loginVerboseSw";
            this.loginVerboseSw.Size = new System.Drawing.Size(414, 24);
            this.loginVerboseSw.TabIndex = 85;
            this.loginVerboseSw.Tag = "themeable";
            this.loginVerboseSw.ToggleChecked = false;
            // 
            // hpetSw
            // 
            this.hpetSw.AccessibleName = "Disable HPET";
            this.hpetSw.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.hpetSw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hpetSw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpetSw.ForeColor = System.Drawing.Color.White;
            this.hpetSw.LabelText = "Disable HPET";
            this.hpetSw.Location = new System.Drawing.Point(21, 17);
            this.hpetSw.Margin = new System.Windows.Forms.Padding(6);
            this.hpetSw.Name = "hpetSw";
            this.hpetSw.Size = new System.Drawing.Size(414, 24);
            this.hpetSw.TabIndex = 84;
            this.hpetSw.Tag = "themeable";
            this.hpetSw.ToggleChecked = false;
            // 
            // btnRestartDisableDefender
            // 
            this.btnRestartDisableDefender.CheckButton = false;
            this.btnRestartDisableDefender.Checked = false;
            this.btnRestartDisableDefender.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestartDisableDefender.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestartDisableDefender.CheckedImageTint = System.Drawing.Color.White;
            this.btnRestartDisableDefender.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestartDisableDefender.Content = "Restart && Disable Defender";
            this.btnRestartDisableDefender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartDisableDefender.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestartDisableDefender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRestartDisableDefender.ForeColor = System.Drawing.Color.White;
            this.btnRestartDisableDefender.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartDisableDefender.HoverForeColor = System.Drawing.Color.Black;
            this.btnRestartDisableDefender.HoverImageTint = System.Drawing.Color.White;
            this.btnRestartDisableDefender.HoverOutline = System.Drawing.Color.Empty;
            this.btnRestartDisableDefender.Image = null;
            this.btnRestartDisableDefender.ImageAutoCenter = true;
            this.btnRestartDisableDefender.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRestartDisableDefender.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRestartDisableDefender.Location = new System.Drawing.Point(21, 237);
            this.btnRestartDisableDefender.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestartDisableDefender.Name = "btnRestartDisableDefender";
            this.btnRestartDisableDefender.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartDisableDefender.NormalForeColor = System.Drawing.Color.White;
            this.btnRestartDisableDefender.NormalImageTint = System.Drawing.Color.White;
            this.btnRestartDisableDefender.NormalOutline = System.Drawing.Color.Empty;
            this.btnRestartDisableDefender.OutlineThickness = 1F;
            this.btnRestartDisableDefender.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartDisableDefender.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestartDisableDefender.PressedImageTint = System.Drawing.Color.White;
            this.btnRestartDisableDefender.PressedOutline = System.Drawing.Color.Empty;
            this.btnRestartDisableDefender.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRestartDisableDefender.Size = new System.Drawing.Size(320, 45);
            this.btnRestartDisableDefender.TabIndex = 88;
            this.btnRestartDisableDefender.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRestartDisableDefender.TextOffset = new System.Drawing.Point(0, 0);
            this.btnRestartDisableDefender.Click += new System.EventHandler(this.btnRestartDisableDefender_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.CheckButton = false;
            this.btnRestart.Checked = false;
            this.btnRestart.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestart.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestart.CheckedImageTint = System.Drawing.Color.White;
            this.btnRestart.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestart.Content = "Restart in Normal Mode";
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestart.HoverForeColor = System.Drawing.Color.Black;
            this.btnRestart.HoverImageTint = System.Drawing.Color.White;
            this.btnRestart.HoverOutline = System.Drawing.Color.Empty;
            this.btnRestart.Image = null;
            this.btnRestart.ImageAutoCenter = true;
            this.btnRestart.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRestart.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRestart.Location = new System.Drawing.Point(21, 188);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestart.NormalForeColor = System.Drawing.Color.White;
            this.btnRestart.NormalImageTint = System.Drawing.Color.White;
            this.btnRestart.NormalOutline = System.Drawing.Color.Empty;
            this.btnRestart.OutlineThickness = 1F;
            this.btnRestart.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestart.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestart.PressedImageTint = System.Drawing.Color.White;
            this.btnRestart.PressedOutline = System.Drawing.Color.Empty;
            this.btnRestart.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRestart.Size = new System.Drawing.Size(320, 45);
            this.btnRestart.TabIndex = 87;
            this.btnRestart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRestart.TextOffset = new System.Drawing.Point(0, 0);
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRestartSafe
            // 
            this.btnRestartSafe.CheckButton = false;
            this.btnRestartSafe.Checked = false;
            this.btnRestartSafe.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestartSafe.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestartSafe.CheckedImageTint = System.Drawing.Color.White;
            this.btnRestartSafe.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestartSafe.Content = "Restart in Safe Mode";
            this.btnRestartSafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestartSafe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestartSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRestartSafe.ForeColor = System.Drawing.Color.White;
            this.btnRestartSafe.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartSafe.HoverForeColor = System.Drawing.Color.Black;
            this.btnRestartSafe.HoverImageTint = System.Drawing.Color.White;
            this.btnRestartSafe.HoverOutline = System.Drawing.Color.Empty;
            this.btnRestartSafe.Image = null;
            this.btnRestartSafe.ImageAutoCenter = true;
            this.btnRestartSafe.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRestartSafe.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRestartSafe.Location = new System.Drawing.Point(21, 139);
            this.btnRestartSafe.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestartSafe.Name = "btnRestartSafe";
            this.btnRestartSafe.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartSafe.NormalForeColor = System.Drawing.Color.White;
            this.btnRestartSafe.NormalImageTint = System.Drawing.Color.White;
            this.btnRestartSafe.NormalOutline = System.Drawing.Color.Empty;
            this.btnRestartSafe.OutlineThickness = 1F;
            this.btnRestartSafe.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestartSafe.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestartSafe.PressedImageTint = System.Drawing.Color.White;
            this.btnRestartSafe.PressedOutline = System.Drawing.Color.Empty;
            this.btnRestartSafe.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRestartSafe.Size = new System.Drawing.Size(320, 45);
            this.btnRestartSafe.TabIndex = 86;
            this.btnRestartSafe.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRestartSafe.TextOffset = new System.Drawing.Point(0, 0);
            this.btnRestartSafe.Click += new System.EventHandler(this.btnRestartSafe_Click);
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
            this.modernAppsTab.Controls.Add(this.panelUwp);
            this.modernAppsTab.Controls.Add(this.cuiPanel1);
            this.modernAppsTab.Location = new System.Drawing.Point(4, 40);
            this.modernAppsTab.Name = "modernAppsTab";
            this.modernAppsTab.Padding = new System.Windows.Forms.Padding(3);
            this.modernAppsTab.Size = new System.Drawing.Size(1289, 688);
            this.modernAppsTab.TabIndex = 11;
            this.modernAppsTab.Text = "UWP Apps";
            // 
            // btnRestoreUwp
            // 
            this.btnRestoreUwp.CheckButton = false;
            this.btnRestoreUwp.Checked = false;
            this.btnRestoreUwp.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestoreUwp.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestoreUwp.CheckedImageTint = System.Drawing.Color.White;
            this.btnRestoreUwp.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRestoreUwp.Content = "Restore All UWP";
            this.btnRestoreUwp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreUwp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestoreUwp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRestoreUwp.ForeColor = System.Drawing.Color.White;
            this.btnRestoreUwp.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestoreUwp.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestoreUwp.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestoreUwp.HoverOutline = System.Drawing.Color.Empty;
            this.btnRestoreUwp.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreUwp.Image")));
            this.btnRestoreUwp.ImageAutoCenter = true;
            this.btnRestoreUwp.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnRestoreUwp.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnRestoreUwp.Location = new System.Drawing.Point(585, 197);
            this.btnRestoreUwp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreUwp.Name = "btnRestoreUwp";
            this.btnRestoreUwp.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestoreUwp.NormalForeColor = System.Drawing.Color.White;
            this.btnRestoreUwp.NormalImageTint = System.Drawing.Color.White;
            this.btnRestoreUwp.NormalOutline = System.Drawing.Color.Empty;
            this.btnRestoreUwp.OutlineThickness = 1F;
            this.btnRestoreUwp.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnRestoreUwp.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestoreUwp.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestoreUwp.PressedOutline = System.Drawing.Color.Empty;
            this.btnRestoreUwp.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRestoreUwp.Size = new System.Drawing.Size(265, 45);
            this.btnRestoreUwp.TabIndex = 55;
            this.btnRestoreUwp.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRestoreUwp.TextOffset = new System.Drawing.Point(1, 0);
            this.btnRestoreUwp.Click += new System.EventHandler(this.btnRestoreUwp_Click);
            // 
            // uninstallModernAppsButton
            // 
            this.uninstallModernAppsButton.CheckButton = false;
            this.uninstallModernAppsButton.Checked = false;
            this.uninstallModernAppsButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.uninstallModernAppsButton.CheckedForeColor = System.Drawing.Color.White;
            this.uninstallModernAppsButton.CheckedImageTint = System.Drawing.Color.White;
            this.uninstallModernAppsButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.uninstallModernAppsButton.Content = "Uninstall";
            this.uninstallModernAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uninstallModernAppsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.uninstallModernAppsButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallModernAppsButton.ForeColor = System.Drawing.Color.White;
            this.uninstallModernAppsButton.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.uninstallModernAppsButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uninstallModernAppsButton.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uninstallModernAppsButton.HoverOutline = System.Drawing.Color.Empty;
            this.uninstallModernAppsButton.Image = ((System.Drawing.Image)(resources.GetObject("uninstallModernAppsButton.Image")));
            this.uninstallModernAppsButton.ImageAutoCenter = true;
            this.uninstallModernAppsButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.uninstallModernAppsButton.ImageOffset = new System.Drawing.Point(-1, 0);
            this.uninstallModernAppsButton.Location = new System.Drawing.Point(585, 90);
            this.uninstallModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.uninstallModernAppsButton.Name = "uninstallModernAppsButton";
            this.uninstallModernAppsButton.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.uninstallModernAppsButton.NormalForeColor = System.Drawing.Color.White;
            this.uninstallModernAppsButton.NormalImageTint = System.Drawing.Color.White;
            this.uninstallModernAppsButton.NormalOutline = System.Drawing.Color.Empty;
            this.uninstallModernAppsButton.OutlineThickness = 1F;
            this.uninstallModernAppsButton.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.uninstallModernAppsButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uninstallModernAppsButton.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uninstallModernAppsButton.PressedOutline = System.Drawing.Color.Empty;
            this.uninstallModernAppsButton.Rounding = new System.Windows.Forms.Padding(8);
            this.uninstallModernAppsButton.Size = new System.Drawing.Size(265, 45);
            this.uninstallModernAppsButton.TabIndex = 50;
            this.uninstallModernAppsButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.uninstallModernAppsButton.TextOffset = new System.Drawing.Point(1, 0);
            this.uninstallModernAppsButton.Click += new System.EventHandler(this.button74_Click);
            // 
            // refreshModernAppsButton
            // 
            this.refreshModernAppsButton.CheckButton = false;
            this.refreshModernAppsButton.Checked = false;
            this.refreshModernAppsButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.refreshModernAppsButton.CheckedForeColor = System.Drawing.Color.White;
            this.refreshModernAppsButton.CheckedImageTint = System.Drawing.Color.White;
            this.refreshModernAppsButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.refreshModernAppsButton.Content = "Refresh";
            this.refreshModernAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshModernAppsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshModernAppsButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshModernAppsButton.ForeColor = System.Drawing.Color.White;
            this.refreshModernAppsButton.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.refreshModernAppsButton.HoverForeColor = System.Drawing.Color.White;
            this.refreshModernAppsButton.HoverImageTint = System.Drawing.Color.White;
            this.refreshModernAppsButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.refreshModernAppsButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshModernAppsButton.Image")));
            this.refreshModernAppsButton.ImageAutoCenter = true;
            this.refreshModernAppsButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.refreshModernAppsButton.ImageOffset = new System.Drawing.Point(-1, 0);
            this.refreshModernAppsButton.Location = new System.Drawing.Point(585, 41);
            this.refreshModernAppsButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshModernAppsButton.Name = "refreshModernAppsButton";
            this.refreshModernAppsButton.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.refreshModernAppsButton.NormalForeColor = System.Drawing.Color.White;
            this.refreshModernAppsButton.NormalImageTint = System.Drawing.Color.White;
            this.refreshModernAppsButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.refreshModernAppsButton.OutlineThickness = 1F;
            this.refreshModernAppsButton.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.refreshModernAppsButton.PressedForeColor = System.Drawing.Color.Gray;
            this.refreshModernAppsButton.PressedImageTint = System.Drawing.Color.Gray;
            this.refreshModernAppsButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.refreshModernAppsButton.Rounding = new System.Windows.Forms.Padding(8);
            this.refreshModernAppsButton.Size = new System.Drawing.Size(265, 45);
            this.refreshModernAppsButton.TabIndex = 49;
            this.refreshModernAppsButton.Tag = "dontTheme";
            this.refreshModernAppsButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.refreshModernAppsButton.TextOffset = new System.Drawing.Point(1, 0);
            this.refreshModernAppsButton.Click += new System.EventHandler(this.button75_Click);
            // 
            // txtModernAppsTitle
            // 
            this.txtModernAppsTitle.AutoSize = true;
            this.txtModernAppsTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModernAppsTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtModernAppsTitle.Location = new System.Drawing.Point(6, 10);
            this.txtModernAppsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtModernAppsTitle.Name = "txtModernAppsTitle";
            this.txtModernAppsTitle.Size = new System.Drawing.Size(290, 24);
            this.txtModernAppsTitle.TabIndex = 47;
            this.txtModernAppsTitle.Tag = "dontTheme";
            this.txtModernAppsTitle.Text = "Uninstall unwanted UWP Apps";
            // 
            // chkOnlyRemovable
            // 
            this.chkOnlyRemovable.Checked = false;
            this.chkOnlyRemovable.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkOnlyRemovable.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkOnlyRemovable.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Content = "Only uninstall-ables";
            this.chkOnlyRemovable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnlyRemovable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnlyRemovable.ForeColor = System.Drawing.Color.White;
            this.chkOnlyRemovable.Location = new System.Drawing.Point(585, 139);
            this.chkOnlyRemovable.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnlyRemovable.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkOnlyRemovable.Name = "chkOnlyRemovable";
            this.chkOnlyRemovable.OutlineStyle = true;
            this.chkOnlyRemovable.OutlineThickness = 1F;
            this.chkOnlyRemovable.Rounding = 4;
            this.chkOnlyRemovable.ShowSymbols = true;
            this.chkOnlyRemovable.Size = new System.Drawing.Size(265, 25);
            this.chkOnlyRemovable.TabIndex = 53;
            this.chkOnlyRemovable.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkOnlyRemovable.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkOnlyRemovable.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.chkOnlyRemovable.CheckedChanged += new System.EventHandler(this.chkOnlyRemovable_CheckedChanged);
            // 
            // chkSelectAllModernApps
            // 
            this.chkSelectAllModernApps.Checked = false;
            this.chkSelectAllModernApps.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkSelectAllModernApps.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkSelectAllModernApps.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkSelectAllModernApps.Content = "Select all";
            this.chkSelectAllModernApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSelectAllModernApps.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAllModernApps.ForeColor = System.Drawing.Color.White;
            this.chkSelectAllModernApps.Location = new System.Drawing.Point(585, 168);
            this.chkSelectAllModernApps.Margin = new System.Windows.Forms.Padding(2);
            this.chkSelectAllModernApps.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkSelectAllModernApps.Name = "chkSelectAllModernApps";
            this.chkSelectAllModernApps.OutlineStyle = true;
            this.chkSelectAllModernApps.OutlineThickness = 1F;
            this.chkSelectAllModernApps.Rounding = 4;
            this.chkSelectAllModernApps.ShowSymbols = true;
            this.chkSelectAllModernApps.Size = new System.Drawing.Size(265, 25);
            this.chkSelectAllModernApps.TabIndex = 52;
            this.chkSelectAllModernApps.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkSelectAllModernApps.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkSelectAllModernApps.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.chkSelectAllModernApps.CheckedChanged += new System.EventHandler(this.chkSelectAllModernApps_CheckedChanged);
            // 
            // panelUwp
            // 
            this.panelUwp.AutoScroll = true;
            this.panelUwp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelUwp.Location = new System.Drawing.Point(15, 45);
            this.panelUwp.Name = "panelUwp";
            this.panelUwp.Size = new System.Drawing.Size(561, 490);
            this.panelUwp.TabIndex = 54;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Location = new System.Drawing.Point(11, 41);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(569, 498);
            this.cuiPanel1.TabIndex = 56;
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
            this.startupTab.Controls.Add(this.removeStartupItemB);
            this.startupTab.Controls.Add(this.refreshStartupB);
            this.startupTab.Controls.Add(this.panel3);
            this.startupTab.Controls.Add(this.startupTitle);
            this.startupTab.Location = new System.Drawing.Point(4, 40);
            this.startupTab.Margin = new System.Windows.Forms.Padding(2);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(1289, 688);
            this.startupTab.TabIndex = 7;
            this.startupTab.Text = "Startup";
            // 
            // cancelBackup
            // 
            this.cancelBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelBackup.FlatAppearance.BorderSize = 0;
            this.cancelBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.cancelBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBackup.ForeColor = System.Drawing.Color.White;
            this.cancelBackup.Location = new System.Drawing.Point(123, 654);
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
            this.doBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.doBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.doBackup.FlatAppearance.BorderSize = 0;
            this.doBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.doBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doBackup.ForeColor = System.Drawing.Color.White;
            this.doBackup.Location = new System.Drawing.Point(9, 654);
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
            this.txtBackupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBackupTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBackupTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupTitle.ForeColor = System.Drawing.Color.White;
            this.txtBackupTitle.Location = new System.Drawing.Point(9, 625);
            this.txtBackupTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackupTitle.Name = "txtBackupTitle";
            this.txtBackupTitle.Size = new System.Drawing.Size(323, 25);
            this.txtBackupTitle.TabIndex = 58;
            this.txtBackupTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBackupTitle.Visible = false;
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblBackupTitle.Location = new System.Drawing.Point(5, 604);
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
            this.restoreStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restoreStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.restoreStartupB.FlatAppearance.BorderSize = 0;
            this.restoreStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.restoreStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreStartupB.ForeColor = System.Drawing.Color.White;
            this.restoreStartupB.Location = new System.Drawing.Point(203, 564);
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
            this.backupStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backupStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.backupStartupB.FlatAppearance.BorderSize = 0;
            this.backupStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.backupStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupStartupB.ForeColor = System.Drawing.Color.White;
            this.backupStartupB.Location = new System.Drawing.Point(9, 564);
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
            this.findInRegB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findInRegB.BackColor = System.Drawing.Color.DodgerBlue;
            this.findInRegB.FlatAppearance.BorderSize = 0;
            this.findInRegB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.findInRegB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findInRegB.ForeColor = System.Drawing.Color.White;
            this.findInRegB.Location = new System.Drawing.Point(899, 653);
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
            this.locateFileB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.locateFileB.BackColor = System.Drawing.Color.DodgerBlue;
            this.locateFileB.FlatAppearance.BorderSize = 0;
            this.locateFileB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.locateFileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locateFileB.ForeColor = System.Drawing.Color.White;
            this.locateFileB.Location = new System.Drawing.Point(899, 618);
            this.locateFileB.Margin = new System.Windows.Forms.Padding(2);
            this.locateFileB.Name = "locateFileB";
            this.locateFileB.Size = new System.Drawing.Size(190, 31);
            this.locateFileB.TabIndex = 39;
            this.locateFileB.Text = "Locate file";
            this.locateFileB.UseVisualStyleBackColor = false;
            this.locateFileB.Click += new System.EventHandler(this.button31_Click);
            // 
            // removeStartupItemB
            // 
            this.removeStartupItemB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeStartupItemB.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeStartupItemB.FlatAppearance.BorderSize = 0;
            this.removeStartupItemB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.removeStartupItemB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStartupItemB.ForeColor = System.Drawing.Color.White;
            this.removeStartupItemB.Location = new System.Drawing.Point(1094, 618);
            this.removeStartupItemB.Margin = new System.Windows.Forms.Padding(2);
            this.removeStartupItemB.Name = "removeStartupItemB";
            this.removeStartupItemB.Size = new System.Drawing.Size(190, 31);
            this.removeStartupItemB.TabIndex = 36;
            this.removeStartupItemB.Text = "Delete";
            this.removeStartupItemB.UseVisualStyleBackColor = false;
            this.removeStartupItemB.Click += new System.EventHandler(this.button32_Click);
            // 
            // refreshStartupB
            // 
            this.refreshStartupB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshStartupB.BackColor = System.Drawing.Color.DodgerBlue;
            this.refreshStartupB.FlatAppearance.BorderSize = 0;
            this.refreshStartupB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.refreshStartupB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshStartupB.ForeColor = System.Drawing.Color.White;
            this.refreshStartupB.Location = new System.Drawing.Point(1094, 653);
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
            this.panel3.Size = new System.Drawing.Size(1273, 520);
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
            this.listStartupItems.Size = new System.Drawing.Size(1271, 518);
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
            // startupTitle
            // 
            this.startupTitle.AutoSize = true;
            this.startupTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.startupTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.startupTitle.Location = new System.Drawing.Point(6, 10);
            this.startupTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startupTitle.Name = "startupTitle";
            this.startupTitle.Size = new System.Drawing.Size(252, 24);
            this.startupTitle.TabIndex = 3;
            this.startupTitle.Tag = "dontTheme";
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
            this.appsTab.Location = new System.Drawing.Point(4, 40);
            this.appsTab.Name = "appsTab";
            this.appsTab.Padding = new System.Windows.Forms.Padding(3);
            this.appsTab.Size = new System.Drawing.Size(1289, 688);
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
            this.txtFeedError.Size = new System.Drawing.Size(1283, 518);
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
            this.groupSoundVideo.Size = new System.Drawing.Size(227, 414);
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
            this.groupCoding.Size = new System.Drawing.Size(226, 414);
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
            this.groupInternet.Size = new System.Drawing.Size(246, 414);
            this.groupInternet.TabIndex = 164;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.appsTitle);
            this.panel10.Controls.Add(this.btnGetFeed);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1283, 44);
            this.panel10.TabIndex = 163;
            // 
            // appsTitle
            // 
            this.appsTitle.AutoSize = true;
            this.appsTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.appsTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.appsTitle.Location = new System.Drawing.Point(3, 7);
            this.appsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appsTitle.Name = "appsTitle";
            this.appsTitle.Size = new System.Drawing.Size(366, 24);
            this.appsTitle.TabIndex = 53;
            this.appsTitle.Tag = "dontTheme";
            this.appsTitle.Text = "Quickly download && install useful apps";
            // 
            // btnGetFeed
            // 
            this.btnGetFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetFeed.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetFeed.FlatAppearance.BorderSize = 0;
            this.btnGetFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGetFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFeed.ForeColor = System.Drawing.Color.White;
            this.btnGetFeed.Location = new System.Drawing.Point(1073, 7);
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
            this.panelCommonApps.Controls.Add(this.cuiComboBox1);
            this.panelCommonApps.Controls.Add(this.cAutoInstall);
            this.panelCommonApps.Controls.Add(this.progressDownloader);
            this.panelCommonApps.Controls.Add(this.btnDownloadApps);
            this.panelCommonApps.Controls.Add(this.setDownDirLbl);
            this.panelCommonApps.Controls.Add(this.txtDownloadFolderTextBox);
            this.panelCommonApps.Controls.Add(this.txtDownloadFolderButton);
            this.panelCommonApps.Controls.Add(this.txtDownloadStatus);
            this.panelCommonApps.Controls.Add(this.linkWarnings);
            this.panelCommonApps.Controls.Add(this.bitPref);
            this.panelCommonApps.Controls.Add(this.goToDownloadsB);
            this.panelCommonApps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommonApps.Location = new System.Drawing.Point(3, 565);
            this.panelCommonApps.Name = "panelCommonApps";
            this.panelCommonApps.Size = new System.Drawing.Size(1283, 120);
            this.panelCommonApps.TabIndex = 162;
            // 
            // cuiComboBox1
            // 
            this.cuiComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cuiComboBox1.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cuiComboBox1.DropDownForeColor = System.Drawing.Color.Silver;
            this.cuiComboBox1.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cuiComboBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.cuiComboBox1.Items = new string[] {
        "64-bit",
        "32-bit"};
            this.cuiComboBox1.Location = new System.Drawing.Point(372, 30);
            this.cuiComboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cuiComboBox1.MaxDropDownHeight = 240;
            this.cuiComboBox1.Name = "cuiComboBox1";
            this.cuiComboBox1.NoSelectionText = "None";
            this.cuiComboBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiComboBox1.OutlineThickness = 1F;
            this.cuiComboBox1.Rounding = 8;
            this.cuiComboBox1.SelectedIndex = 0;
            this.cuiComboBox1.SelectedItem = "64-bit";
            this.cuiComboBox1.Size = new System.Drawing.Size(169, 45);
            this.cuiComboBox1.SortAlphabetically = true;
            this.cuiComboBox1.TabIndex = 161;
            // 
            // cAutoInstall
            // 
            this.cAutoInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cAutoInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cAutoInstall.Checked = false;
            this.cAutoInstall.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cAutoInstall.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cAutoInstall.CheckedSymbolColor = System.Drawing.Color.White;
            this.cAutoInstall.Content = "Install after downloading";
            this.cAutoInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cAutoInstall.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAutoInstall.Location = new System.Drawing.Point(867, 47);
            this.cAutoInstall.MinimumSize = new System.Drawing.Size(16, 16);
            this.cAutoInstall.Name = "cAutoInstall";
            this.cAutoInstall.OutlineStyle = true;
            this.cAutoInstall.OutlineThickness = 1F;
            this.cAutoInstall.Rounding = 4;
            this.cAutoInstall.ShowSymbols = true;
            this.cAutoInstall.Size = new System.Drawing.Size(369, 24);
            this.cAutoInstall.TabIndex = 107;
            this.cAutoInstall.UncheckedForeground = System.Drawing.Color.Empty;
            this.cAutoInstall.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.cAutoInstall.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // progressDownloader
            // 
            this.progressDownloader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressDownloader.Background = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressDownloader.Flipped = false;
            this.progressDownloader.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.progressDownloader.Location = new System.Drawing.Point(8, 83);
            this.progressDownloader.MaxValue = 100;
            this.progressDownloader.Name = "progressDownloader";
            this.progressDownloader.Rounding = 5;
            this.progressDownloader.Size = new System.Drawing.Size(302, 10);
            this.progressDownloader.TabIndex = 160;
            this.progressDownloader.Value = 0;
            // 
            // btnDownloadApps
            // 
            this.btnDownloadApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadApps.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadApps.FlatAppearance.BorderSize = 0;
            this.btnDownloadApps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownloadApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadApps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadApps.ForeColor = System.Drawing.Color.White;
            this.btnDownloadApps.Location = new System.Drawing.Point(1073, 76);
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
            this.setDownDirLbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDownDirLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.setDownDirLbl.Location = new System.Drawing.Point(5, 6);
            this.setDownDirLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setDownDirLbl.Name = "setDownDirLbl";
            this.setDownDirLbl.Size = new System.Drawing.Size(152, 19);
            this.setDownDirLbl.TabIndex = 69;
            this.setDownDirLbl.Tag = "dontTheme";
            this.setDownDirLbl.Text = "Set download folder";
            // 
            // txtDownloadFolderTextBox
            // 
            this.txtDownloadFolderTextBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtDownloadFolderTextBox.Content = "";
            this.txtDownloadFolderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDownloadFolderTextBox.Enabled = false;
            this.txtDownloadFolderTextBox.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtDownloadFolderTextBox.FocusImageTint = System.Drawing.Color.White;
            this.txtDownloadFolderTextBox.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtDownloadFolderTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadFolderTextBox.ForeColor = System.Drawing.Color.Silver;
            this.txtDownloadFolderTextBox.Image = null;
            this.txtDownloadFolderTextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtDownloadFolderTextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtDownloadFolderTextBox.Location = new System.Drawing.Point(8, 30);
            this.txtDownloadFolderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtDownloadFolderTextBox.Multiline = false;
            this.txtDownloadFolderTextBox.Name = "txtDownloadFolderTextBox";
            this.txtDownloadFolderTextBox.NormalImageTint = System.Drawing.Color.White;
            this.txtDownloadFolderTextBox.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtDownloadFolderTextBox.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.txtDownloadFolderTextBox.PasswordChar = false;
            this.txtDownloadFolderTextBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDownloadFolderTextBox.PlaceholderText = "None";
            this.txtDownloadFolderTextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.txtDownloadFolderTextBox.Size = new System.Drawing.Size(302, 45);
            this.txtDownloadFolderTextBox.TabIndex = 70;
            this.txtDownloadFolderTextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.txtDownloadFolderTextBox.UnderlinedStyle = true;
            // 
            // txtDownloadFolderButton
            // 
            this.txtDownloadFolderButton.CheckButton = false;
            this.txtDownloadFolderButton.Checked = false;
            this.txtDownloadFolderButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtDownloadFolderButton.CheckedForeColor = System.Drawing.Color.White;
            this.txtDownloadFolderButton.CheckedImageTint = System.Drawing.Color.White;
            this.txtDownloadFolderButton.CheckedOutline = System.Drawing.Color.Empty;
            this.txtDownloadFolderButton.Content = "";
            this.txtDownloadFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDownloadFolderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtDownloadFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDownloadFolderButton.ForeColor = System.Drawing.Color.White;
            this.txtDownloadFolderButton.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.txtDownloadFolderButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDownloadFolderButton.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDownloadFolderButton.HoverOutline = System.Drawing.Color.Empty;
            this.txtDownloadFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("txtDownloadFolderButton.Image")));
            this.txtDownloadFolderButton.ImageAutoCenter = true;
            this.txtDownloadFolderButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtDownloadFolderButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtDownloadFolderButton.Location = new System.Drawing.Point(313, 30);
            this.txtDownloadFolderButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownloadFolderButton.Name = "txtDownloadFolderButton";
            this.txtDownloadFolderButton.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.txtDownloadFolderButton.NormalForeColor = System.Drawing.Color.White;
            this.txtDownloadFolderButton.NormalImageTint = System.Drawing.Color.White;
            this.txtDownloadFolderButton.NormalOutline = System.Drawing.Color.Empty;
            this.txtDownloadFolderButton.OutlineThickness = 1F;
            this.txtDownloadFolderButton.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.txtDownloadFolderButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDownloadFolderButton.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDownloadFolderButton.PressedOutline = System.Drawing.Color.Empty;
            this.txtDownloadFolderButton.Rounding = new System.Windows.Forms.Padding(8);
            this.txtDownloadFolderButton.Size = new System.Drawing.Size(45, 45);
            this.txtDownloadFolderButton.TabIndex = 71;
            this.txtDownloadFolderButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtDownloadFolderButton.TextOffset = new System.Drawing.Point(0, 0);
            this.txtDownloadFolderButton.Click += new System.EventHandler(this.button5_Click);
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
            this.bitPref.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitPref.ForeColor = System.Drawing.Color.Gainsboro;
            this.bitPref.Location = new System.Drawing.Point(368, 6);
            this.bitPref.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bitPref.Name = "bitPref";
            this.bitPref.Size = new System.Drawing.Size(131, 19);
            this.bitPref.TabIndex = 74;
            this.bitPref.Tag = "dontTheme";
            this.bitPref.Text = "Set bit preference";
            // 
            // goToDownloadsB
            // 
            this.goToDownloadsB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goToDownloadsB.BackColor = System.Drawing.Color.DodgerBlue;
            this.goToDownloadsB.FlatAppearance.BorderSize = 0;
            this.goToDownloadsB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.goToDownloadsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToDownloadsB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToDownloadsB.ForeColor = System.Drawing.Color.White;
            this.goToDownloadsB.Location = new System.Drawing.Point(867, 76);
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
            this.groupSystemTools.Size = new System.Drawing.Size(246, 414);
            this.groupSystemTools.TabIndex = 162;
            // 
            // cleanerTab
            // 
            this.cleanerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cleanerTab.Controls.Add(this.panel13);
            this.cleanerTab.Controls.Add(this.panel14);
            this.cleanerTab.Controls.Add(this.panel1);
            this.cleanerTab.Location = new System.Drawing.Point(4, 40);
            this.cleanerTab.Margin = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Name = "cleanerTab";
            this.cleanerTab.Padding = new System.Windows.Forms.Padding(2);
            this.cleanerTab.Size = new System.Drawing.Size(1289, 688);
            this.cleanerTab.TabIndex = 5;
            this.cleanerTab.Text = "Cleaner";
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel13.Controls.Add(this.btnWinClean);
            this.panel13.Controls.Add(this.analyzeDriveB);
            this.panel13.Controls.Add(this.checkSelectAll);
            this.panel13.Controls.Add(this.lblPretext);
            this.panel13.Controls.Add(this.cleanDriveB);
            this.panel13.Controls.Add(this.lblFootprint);
            this.panel13.Location = new System.Drawing.Point(221, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1068, 61);
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
            this.btnWinClean.Location = new System.Drawing.Point(636, 25);
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
            this.analyzeDriveB.Location = new System.Drawing.Point(780, 25);
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
            this.checkSelectAll.Location = new System.Drawing.Point(817, 3);
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
            this.lblPretext.Location = new System.Drawing.Point(2, 6);
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
            this.cleanDriveB.Location = new System.Drawing.Point(924, 25);
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
            this.lblFootprint.Location = new System.Drawing.Point(1, 28);
            this.lblFootprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFootprint.Name = "lblFootprint";
            this.lblFootprint.Size = new System.Drawing.Size(197, 31);
            this.lblFootprint.TabIndex = 48;
            this.lblFootprint.Tag = "themeable";
            this.lblFootprint.Text = "-";
            this.lblFootprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.AutoScroll = true;
            this.panel14.Controls.Add(this.listCleanPreview);
            this.panel14.Location = new System.Drawing.Point(221, 61);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1066, 625);
            this.panel14.TabIndex = 51;
            // 
            // listCleanPreview
            // 
            this.listCleanPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCleanPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listCleanPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCleanPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCleanPreview.ForeColor = System.Drawing.Color.Silver;
            this.listCleanPreview.FormattingEnabled = true;
            this.listCleanPreview.HorizontalScrollbar = true;
            this.listCleanPreview.Location = new System.Drawing.Point(0, 60);
            this.listCleanPreview.Name = "listCleanPreview";
            this.listCleanPreview.Size = new System.Drawing.Size(1064, 500);
            this.listCleanPreview.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 684);
            this.panel1.TabIndex = 47;
            // 
            // bravePasswords
            // 
            this.bravePasswords.Checked = false;
            this.bravePasswords.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.bravePasswords.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.bravePasswords.CheckedSymbolColor = System.Drawing.Color.White;
            this.bravePasswords.Content = "Passwords";
            this.bravePasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bravePasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bravePasswords.ForeColor = System.Drawing.Color.White;
            this.bravePasswords.Location = new System.Drawing.Point(9, 674);
            this.bravePasswords.Margin = new System.Windows.Forms.Padding(2);
            this.bravePasswords.MinimumSize = new System.Drawing.Size(16, 16);
            this.bravePasswords.Name = "bravePasswords";
            this.bravePasswords.OutlineStyle = true;
            this.bravePasswords.OutlineThickness = 1F;
            this.bravePasswords.Rounding = 4;
            this.bravePasswords.ShowSymbols = true;
            this.bravePasswords.Size = new System.Drawing.Size(142, 23);
            this.bravePasswords.TabIndex = 78;
            this.bravePasswords.UncheckedForeground = System.Drawing.Color.Empty;
            this.bravePasswords.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.bravePasswords.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // braveSession
            // 
            this.braveSession.Checked = false;
            this.braveSession.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveSession.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveSession.CheckedSymbolColor = System.Drawing.Color.White;
            this.braveSession.Content = "Session";
            this.braveSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveSession.ForeColor = System.Drawing.Color.White;
            this.braveSession.Location = new System.Drawing.Point(9, 647);
            this.braveSession.Margin = new System.Windows.Forms.Padding(2);
            this.braveSession.MinimumSize = new System.Drawing.Size(16, 16);
            this.braveSession.Name = "braveSession";
            this.braveSession.OutlineStyle = true;
            this.braveSession.OutlineThickness = 1F;
            this.braveSession.Rounding = 4;
            this.braveSession.ShowSymbols = true;
            this.braveSession.Size = new System.Drawing.Size(124, 23);
            this.braveSession.TabIndex = 77;
            this.braveSession.UncheckedForeground = System.Drawing.Color.Empty;
            this.braveSession.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.braveSession.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // braveHistory
            // 
            this.braveHistory.Checked = false;
            this.braveHistory.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveHistory.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveHistory.CheckedSymbolColor = System.Drawing.Color.White;
            this.braveHistory.Content = "History";
            this.braveHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveHistory.ForeColor = System.Drawing.Color.White;
            this.braveHistory.Location = new System.Drawing.Point(9, 620);
            this.braveHistory.Margin = new System.Windows.Forms.Padding(2);
            this.braveHistory.MinimumSize = new System.Drawing.Size(16, 16);
            this.braveHistory.Name = "braveHistory";
            this.braveHistory.OutlineStyle = true;
            this.braveHistory.OutlineThickness = 1F;
            this.braveHistory.Rounding = 4;
            this.braveHistory.ShowSymbols = true;
            this.braveHistory.Size = new System.Drawing.Size(123, 23);
            this.braveHistory.TabIndex = 76;
            this.braveHistory.UncheckedForeground = System.Drawing.Color.Empty;
            this.braveHistory.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.braveHistory.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // braveCookies
            // 
            this.braveCookies.Checked = false;
            this.braveCookies.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveCookies.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveCookies.CheckedSymbolColor = System.Drawing.Color.White;
            this.braveCookies.Content = "Cookies";
            this.braveCookies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCookies.ForeColor = System.Drawing.Color.White;
            this.braveCookies.Location = new System.Drawing.Point(9, 593);
            this.braveCookies.Margin = new System.Windows.Forms.Padding(2);
            this.braveCookies.MinimumSize = new System.Drawing.Size(16, 16);
            this.braveCookies.Name = "braveCookies";
            this.braveCookies.OutlineStyle = true;
            this.braveCookies.OutlineThickness = 1F;
            this.braveCookies.Rounding = 4;
            this.braveCookies.ShowSymbols = true;
            this.braveCookies.Size = new System.Drawing.Size(126, 23);
            this.braveCookies.TabIndex = 75;
            this.braveCookies.UncheckedForeground = System.Drawing.Color.Empty;
            this.braveCookies.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.braveCookies.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // braveCache
            // 
            this.braveCache.Checked = false;
            this.braveCache.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveCache.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.braveCache.CheckedSymbolColor = System.Drawing.Color.White;
            this.braveCache.Content = "Cache";
            this.braveCache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveCache.ForeColor = System.Drawing.Color.White;
            this.braveCache.Location = new System.Drawing.Point(9, 566);
            this.braveCache.Margin = new System.Windows.Forms.Padding(2);
            this.braveCache.MinimumSize = new System.Drawing.Size(16, 16);
            this.braveCache.Name = "braveCache";
            this.braveCache.OutlineStyle = true;
            this.braveCache.OutlineThickness = 1F;
            this.braveCache.Rounding = 4;
            this.braveCache.ShowSymbols = true;
            this.braveCache.Size = new System.Drawing.Size(115, 23);
            this.braveCache.TabIndex = 74;
            this.braveCache.UncheckedForeground = System.Drawing.Color.Empty;
            this.braveCache.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.braveCache.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(30, 541);
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
            this.label8.Location = new System.Drawing.Point(30, 8);
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
            this.pictureBox2.Location = new System.Drawing.Point(7, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // edgeSession
            // 
            this.edgeSession.Checked = false;
            this.edgeSession.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeSession.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeSession.CheckedSymbolColor = System.Drawing.Color.White;
            this.edgeSession.Content = "Session";
            this.edgeSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edgeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeSession.ForeColor = System.Drawing.Color.White;
            this.edgeSession.Location = new System.Drawing.Point(9, 514);
            this.edgeSession.Margin = new System.Windows.Forms.Padding(2);
            this.edgeSession.MinimumSize = new System.Drawing.Size(16, 16);
            this.edgeSession.Name = "edgeSession";
            this.edgeSession.OutlineStyle = true;
            this.edgeSession.OutlineThickness = 1F;
            this.edgeSession.Rounding = 4;
            this.edgeSession.ShowSymbols = true;
            this.edgeSession.Size = new System.Drawing.Size(124, 23);
            this.edgeSession.TabIndex = 69;
            this.edgeSession.UncheckedForeground = System.Drawing.Color.Empty;
            this.edgeSession.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.edgeSession.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // edgeHistory
            // 
            this.edgeHistory.Checked = false;
            this.edgeHistory.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeHistory.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeHistory.CheckedSymbolColor = System.Drawing.Color.White;
            this.edgeHistory.Content = "History";
            this.edgeHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edgeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeHistory.ForeColor = System.Drawing.Color.White;
            this.edgeHistory.Location = new System.Drawing.Point(9, 487);
            this.edgeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.edgeHistory.MinimumSize = new System.Drawing.Size(16, 16);
            this.edgeHistory.Name = "edgeHistory";
            this.edgeHistory.OutlineStyle = true;
            this.edgeHistory.OutlineThickness = 1F;
            this.edgeHistory.Rounding = 4;
            this.edgeHistory.ShowSymbols = true;
            this.edgeHistory.Size = new System.Drawing.Size(123, 23);
            this.edgeHistory.TabIndex = 68;
            this.edgeHistory.UncheckedForeground = System.Drawing.Color.Empty;
            this.edgeHistory.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.edgeHistory.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // edgeCookies
            // 
            this.edgeCookies.Checked = false;
            this.edgeCookies.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeCookies.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeCookies.CheckedSymbolColor = System.Drawing.Color.White;
            this.edgeCookies.Content = "Cookies";
            this.edgeCookies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edgeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCookies.ForeColor = System.Drawing.Color.White;
            this.edgeCookies.Location = new System.Drawing.Point(9, 460);
            this.edgeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCookies.MinimumSize = new System.Drawing.Size(16, 16);
            this.edgeCookies.Name = "edgeCookies";
            this.edgeCookies.OutlineStyle = true;
            this.edgeCookies.OutlineThickness = 1F;
            this.edgeCookies.Rounding = 4;
            this.edgeCookies.ShowSymbols = true;
            this.edgeCookies.Size = new System.Drawing.Size(126, 23);
            this.edgeCookies.TabIndex = 67;
            this.edgeCookies.UncheckedForeground = System.Drawing.Color.Empty;
            this.edgeCookies.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.edgeCookies.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // edgeCache
            // 
            this.edgeCache.Checked = false;
            this.edgeCache.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeCache.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.edgeCache.CheckedSymbolColor = System.Drawing.Color.White;
            this.edgeCache.Content = "Cache";
            this.edgeCache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edgeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeCache.ForeColor = System.Drawing.Color.White;
            this.edgeCache.Location = new System.Drawing.Point(9, 433);
            this.edgeCache.Margin = new System.Windows.Forms.Padding(2);
            this.edgeCache.MinimumSize = new System.Drawing.Size(16, 16);
            this.edgeCache.Name = "edgeCache";
            this.edgeCache.OutlineStyle = true;
            this.edgeCache.OutlineThickness = 1F;
            this.edgeCache.Rounding = 4;
            this.edgeCache.ShowSymbols = true;
            this.edgeCache.Size = new System.Drawing.Size(115, 23);
            this.edgeCache.TabIndex = 66;
            this.edgeCache.UncheckedForeground = System.Drawing.Color.Empty;
            this.edgeCache.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.edgeCache.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // IECache
            // 
            this.IECache.Checked = false;
            this.IECache.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.IECache.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.IECache.CheckedSymbolColor = System.Drawing.Color.White;
            this.IECache.Content = "Cache";
            this.IECache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IECache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IECache.ForeColor = System.Drawing.Color.White;
            this.IECache.Location = new System.Drawing.Point(10, 729);
            this.IECache.Margin = new System.Windows.Forms.Padding(2);
            this.IECache.MinimumSize = new System.Drawing.Size(16, 16);
            this.IECache.Name = "IECache";
            this.IECache.OutlineStyle = true;
            this.IECache.OutlineThickness = 1F;
            this.IECache.Rounding = 4;
            this.IECache.ShowSymbols = true;
            this.IECache.Size = new System.Drawing.Size(115, 23);
            this.IECache.TabIndex = 65;
            this.IECache.UncheckedForeground = System.Drawing.Color.Empty;
            this.IECache.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.IECache.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // firefoxHistory
            // 
            this.firefoxHistory.Checked = false;
            this.firefoxHistory.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxHistory.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxHistory.CheckedSymbolColor = System.Drawing.Color.White;
            this.firefoxHistory.Content = "History";
            this.firefoxHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firefoxHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxHistory.ForeColor = System.Drawing.Color.White;
            this.firefoxHistory.Location = new System.Drawing.Point(9, 380);
            this.firefoxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxHistory.MinimumSize = new System.Drawing.Size(16, 16);
            this.firefoxHistory.Name = "firefoxHistory";
            this.firefoxHistory.OutlineStyle = true;
            this.firefoxHistory.OutlineThickness = 1F;
            this.firefoxHistory.Rounding = 4;
            this.firefoxHistory.ShowSymbols = true;
            this.firefoxHistory.Size = new System.Drawing.Size(123, 23);
            this.firefoxHistory.TabIndex = 64;
            this.firefoxHistory.UncheckedForeground = System.Drawing.Color.Empty;
            this.firefoxHistory.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.firefoxHistory.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // firefoxCookies
            // 
            this.firefoxCookies.Checked = false;
            this.firefoxCookies.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxCookies.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxCookies.CheckedSymbolColor = System.Drawing.Color.White;
            this.firefoxCookies.Content = "Cookies";
            this.firefoxCookies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firefoxCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCookies.ForeColor = System.Drawing.Color.White;
            this.firefoxCookies.Location = new System.Drawing.Point(9, 353);
            this.firefoxCookies.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCookies.MinimumSize = new System.Drawing.Size(16, 16);
            this.firefoxCookies.Name = "firefoxCookies";
            this.firefoxCookies.OutlineStyle = true;
            this.firefoxCookies.OutlineThickness = 1F;
            this.firefoxCookies.Rounding = 4;
            this.firefoxCookies.ShowSymbols = true;
            this.firefoxCookies.Size = new System.Drawing.Size(126, 23);
            this.firefoxCookies.TabIndex = 63;
            this.firefoxCookies.UncheckedForeground = System.Drawing.Color.Empty;
            this.firefoxCookies.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.firefoxCookies.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // firefoxCache
            // 
            this.firefoxCache.Checked = false;
            this.firefoxCache.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxCache.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.firefoxCache.CheckedSymbolColor = System.Drawing.Color.White;
            this.firefoxCache.Content = "Cache";
            this.firefoxCache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firefoxCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firefoxCache.ForeColor = System.Drawing.Color.White;
            this.firefoxCache.Location = new System.Drawing.Point(9, 326);
            this.firefoxCache.Margin = new System.Windows.Forms.Padding(2);
            this.firefoxCache.MinimumSize = new System.Drawing.Size(16, 16);
            this.firefoxCache.Name = "firefoxCache";
            this.firefoxCache.OutlineStyle = true;
            this.firefoxCache.OutlineThickness = 1F;
            this.firefoxCache.Rounding = 4;
            this.firefoxCache.ShowSymbols = true;
            this.firefoxCache.Size = new System.Drawing.Size(115, 23);
            this.firefoxCache.TabIndex = 62;
            this.firefoxCache.UncheckedForeground = System.Drawing.Color.Empty;
            this.firefoxCache.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.firefoxCache.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chromePws
            // 
            this.chromePws.Checked = false;
            this.chromePws.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromePws.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromePws.CheckedSymbolColor = System.Drawing.Color.White;
            this.chromePws.Content = "Passwords";
            this.chromePws.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromePws.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromePws.ForeColor = System.Drawing.Color.White;
            this.chromePws.Location = new System.Drawing.Point(8, 274);
            this.chromePws.Margin = new System.Windows.Forms.Padding(2);
            this.chromePws.MinimumSize = new System.Drawing.Size(16, 16);
            this.chromePws.Name = "chromePws";
            this.chromePws.OutlineStyle = true;
            this.chromePws.OutlineThickness = 1F;
            this.chromePws.Rounding = 4;
            this.chromePws.ShowSymbols = true;
            this.chromePws.Size = new System.Drawing.Size(142, 23);
            this.chromePws.TabIndex = 61;
            this.chromePws.UncheckedForeground = System.Drawing.Color.Empty;
            this.chromePws.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chromePws.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chromeSession
            // 
            this.chromeSession.Checked = false;
            this.chromeSession.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeSession.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeSession.CheckedSymbolColor = System.Drawing.Color.White;
            this.chromeSession.Content = "Session";
            this.chromeSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromeSession.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeSession.ForeColor = System.Drawing.Color.White;
            this.chromeSession.Location = new System.Drawing.Point(8, 247);
            this.chromeSession.Margin = new System.Windows.Forms.Padding(2);
            this.chromeSession.MinimumSize = new System.Drawing.Size(16, 16);
            this.chromeSession.Name = "chromeSession";
            this.chromeSession.OutlineStyle = true;
            this.chromeSession.OutlineThickness = 1F;
            this.chromeSession.Rounding = 4;
            this.chromeSession.ShowSymbols = true;
            this.chromeSession.Size = new System.Drawing.Size(124, 23);
            this.chromeSession.TabIndex = 60;
            this.chromeSession.UncheckedForeground = System.Drawing.Color.Empty;
            this.chromeSession.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chromeSession.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chromeHistory
            // 
            this.chromeHistory.Checked = false;
            this.chromeHistory.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeHistory.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeHistory.CheckedSymbolColor = System.Drawing.Color.White;
            this.chromeHistory.Content = "History";
            this.chromeHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromeHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeHistory.ForeColor = System.Drawing.Color.White;
            this.chromeHistory.Location = new System.Drawing.Point(8, 220);
            this.chromeHistory.Margin = new System.Windows.Forms.Padding(2);
            this.chromeHistory.MinimumSize = new System.Drawing.Size(16, 16);
            this.chromeHistory.Name = "chromeHistory";
            this.chromeHistory.OutlineStyle = true;
            this.chromeHistory.OutlineThickness = 1F;
            this.chromeHistory.Rounding = 4;
            this.chromeHistory.ShowSymbols = true;
            this.chromeHistory.Size = new System.Drawing.Size(123, 23);
            this.chromeHistory.TabIndex = 59;
            this.chromeHistory.UncheckedForeground = System.Drawing.Color.Empty;
            this.chromeHistory.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chromeHistory.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chromeCookies
            // 
            this.chromeCookies.Checked = false;
            this.chromeCookies.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeCookies.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeCookies.CheckedSymbolColor = System.Drawing.Color.White;
            this.chromeCookies.Content = "Cookies";
            this.chromeCookies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromeCookies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCookies.ForeColor = System.Drawing.Color.White;
            this.chromeCookies.Location = new System.Drawing.Point(8, 193);
            this.chromeCookies.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCookies.MinimumSize = new System.Drawing.Size(16, 16);
            this.chromeCookies.Name = "chromeCookies";
            this.chromeCookies.OutlineStyle = true;
            this.chromeCookies.OutlineThickness = 1F;
            this.chromeCookies.Rounding = 4;
            this.chromeCookies.ShowSymbols = true;
            this.chromeCookies.Size = new System.Drawing.Size(126, 23);
            this.chromeCookies.TabIndex = 58;
            this.chromeCookies.UncheckedForeground = System.Drawing.Color.Empty;
            this.chromeCookies.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chromeCookies.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chromeCache
            // 
            this.chromeCache.Checked = false;
            this.chromeCache.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeCache.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chromeCache.CheckedSymbolColor = System.Drawing.Color.White;
            this.chromeCache.Content = "Cache";
            this.chromeCache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chromeCache.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCache.ForeColor = System.Drawing.Color.White;
            this.chromeCache.Location = new System.Drawing.Point(8, 166);
            this.chromeCache.Margin = new System.Windows.Forms.Padding(2);
            this.chromeCache.MinimumSize = new System.Drawing.Size(16, 16);
            this.chromeCache.Name = "chromeCache";
            this.chromeCache.OutlineStyle = true;
            this.chromeCache.OutlineThickness = 1F;
            this.chromeCache.Rounding = 4;
            this.chromeCache.ShowSymbols = true;
            this.chromeCache.Size = new System.Drawing.Size(115, 23);
            this.chromeCache.TabIndex = 57;
            this.chromeCache.UncheckedForeground = System.Drawing.Color.Empty;
            this.chromeCache.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chromeCache.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(30, 408);
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
            this.label6.Location = new System.Drawing.Point(30, 704);
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
            this.label5.Location = new System.Drawing.Point(30, 302);
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
            this.label4.Location = new System.Drawing.Point(30, 142);
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
            this.pictureBox11.Location = new System.Drawing.Point(7, 408);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 53;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(7, 704);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 52;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(7, 142);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 51;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(7, 302);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 50;
            this.pictureBox8.TabStop = false;
            // 
            // checkErrorReports
            // 
            this.checkErrorReports.Checked = false;
            this.checkErrorReports.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkErrorReports.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkErrorReports.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkErrorReports.Content = "Error reports";
            this.checkErrorReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkErrorReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkErrorReports.ForeColor = System.Drawing.Color.White;
            this.checkErrorReports.Location = new System.Drawing.Point(8, 87);
            this.checkErrorReports.Margin = new System.Windows.Forms.Padding(2);
            this.checkErrorReports.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkErrorReports.Name = "checkErrorReports";
            this.checkErrorReports.OutlineStyle = true;
            this.checkErrorReports.OutlineThickness = 1F;
            this.checkErrorReports.Rounding = 4;
            this.checkErrorReports.ShowSymbols = true;
            this.checkErrorReports.Size = new System.Drawing.Size(155, 23);
            this.checkErrorReports.TabIndex = 44;
            this.checkErrorReports.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkErrorReports.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkErrorReports.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkTemp
            // 
            this.checkTemp.Checked = false;
            this.checkTemp.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkTemp.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkTemp.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkTemp.Content = "Temporary files";
            this.checkTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTemp.ForeColor = System.Drawing.Color.White;
            this.checkTemp.Location = new System.Drawing.Point(8, 33);
            this.checkTemp.Margin = new System.Windows.Forms.Padding(2);
            this.checkTemp.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkTemp.Name = "checkTemp";
            this.checkTemp.OutlineStyle = true;
            this.checkTemp.OutlineThickness = 1F;
            this.checkTemp.Rounding = 4;
            this.checkTemp.ShowSymbols = true;
            this.checkTemp.Size = new System.Drawing.Size(174, 23);
            this.checkTemp.TabIndex = 36;
            this.checkTemp.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkTemp.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkTemp.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkBin
            // 
            this.checkBin.Checked = false;
            this.checkBin.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkBin.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkBin.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkBin.Content = "Recycle Bin";
            this.checkBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBin.ForeColor = System.Drawing.Color.White;
            this.checkBin.Location = new System.Drawing.Point(8, 114);
            this.checkBin.Margin = new System.Windows.Forms.Padding(2);
            this.checkBin.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkBin.Name = "checkBin";
            this.checkBin.OutlineStyle = true;
            this.checkBin.OutlineThickness = 1F;
            this.checkBin.Rounding = 4;
            this.checkBin.ShowSymbols = true;
            this.checkBin.Size = new System.Drawing.Size(149, 23);
            this.checkBin.TabIndex = 41;
            this.checkBin.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkBin.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkBin.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkMiniDumps
            // 
            this.checkMiniDumps.Checked = false;
            this.checkMiniDumps.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkMiniDumps.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkMiniDumps.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkMiniDumps.Content = "BSOD Minidumps";
            this.checkMiniDumps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMiniDumps.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMiniDumps.ForeColor = System.Drawing.Color.White;
            this.checkMiniDumps.Location = new System.Drawing.Point(8, 60);
            this.checkMiniDumps.Margin = new System.Windows.Forms.Padding(2);
            this.checkMiniDumps.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkMiniDumps.Name = "checkMiniDumps";
            this.checkMiniDumps.OutlineStyle = true;
            this.checkMiniDumps.OutlineThickness = 1F;
            this.checkMiniDumps.Rounding = 4;
            this.checkMiniDumps.ShowSymbols = true;
            this.checkMiniDumps.Size = new System.Drawing.Size(189, 23);
            this.checkMiniDumps.TabIndex = 39;
            this.checkMiniDumps.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkMiniDumps.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkMiniDumps.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // pingerTab
            // 
            this.pingerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pingerTab.Controls.Add(this.netTools);
            this.pingerTab.Location = new System.Drawing.Point(4, 40);
            this.pingerTab.Name = "pingerTab";
            this.pingerTab.Padding = new System.Windows.Forms.Padding(3);
            this.pingerTab.Size = new System.Drawing.Size(1289, 688);
            this.pingerTab.TabIndex = 13;
            this.pingerTab.Text = "Pinger";
            // 
            // netTools
            // 
            this.netTools.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.netTools.Controls.Add(this.tabPage2);
            this.netTools.Controls.Add(this.tabPage1);
            this.netTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netTools.ItemSize = new System.Drawing.Size(96, 36);
            this.netTools.Location = new System.Drawing.Point(3, 3);
            this.netTools.Margin = new System.Windows.Forms.Padding(0);
            this.netTools.Name = "netTools";
            this.netTools.Padding = new System.Drawing.Point(0, 0);
            this.netTools.SelectedIndex = 0;
            this.netTools.Size = new System.Drawing.Size(1283, 682);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNS";
            // 
            // btnSetDns
            // 
            this.btnSetDns.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSetDns.FlatAppearance.BorderSize = 0;
            this.btnSetDns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSetDns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSetDns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDns.ForeColor = System.Drawing.Color.White;
            this.btnSetDns.Location = new System.Drawing.Point(428, 521);
            this.btnSetDns.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetDns.Name = "btnSetDns";
            this.btnSetDns.Size = new System.Drawing.Size(260, 29);
            this.btnSetDns.TabIndex = 123;
            this.btnSetDns.Text = "Set as default";
            this.btnSetDns.UseVisualStyleBackColor = false;
            this.btnSetDns.Click += new System.EventHandler(this.btnSetDns_Click);
            // 
            // txtDns6B
            // 
            this.txtDns6B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtDns6B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDns6B.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns6B.ForeColor = System.Drawing.Color.White;
            this.txtDns6B.Location = new System.Drawing.Point(358, 300);
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
            this.txtDns6A.Location = new System.Drawing.Point(28, 300);
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
            this.label12.Location = new System.Drawing.Point(24, 277);
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
            this.txtDns4B.Location = new System.Drawing.Point(358, 244);
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
            this.txtDns4A.Location = new System.Drawing.Point(28, 244);
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
            this.label10.Location = new System.Drawing.Point(25, 221);
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
            this.chkCustomDns.Checked = false;
            this.chkCustomDns.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkCustomDns.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkCustomDns.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkCustomDns.Content = "Set custom";
            this.chkCustomDns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCustomDns.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomDns.ForeColor = System.Drawing.Color.White;
            this.chkCustomDns.Location = new System.Drawing.Point(28, 195);
            this.chkCustomDns.Margin = new System.Windows.Forms.Padding(2);
            this.chkCustomDns.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkCustomDns.Name = "chkCustomDns";
            this.chkCustomDns.OutlineStyle = true;
            this.chkCustomDns.OutlineThickness = 1F;
            this.chkCustomDns.Rounding = 4;
            this.chkCustomDns.ShowSymbols = true;
            this.chkCustomDns.Size = new System.Drawing.Size(326, 24);
            this.chkCustomDns.TabIndex = 116;
            this.chkCustomDns.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkCustomDns.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkCustomDns.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.chkCustomDns.CheckedChanged += new System.EventHandler(this.chkCustomDns_CheckedChanged);
            // 
            // chkAllNics
            // 
            this.chkAllNics.Checked = false;
            this.chkAllNics.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkAllNics.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkAllNics.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkAllNics.Content = "Set for all";
            this.chkAllNics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAllNics.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllNics.ForeColor = System.Drawing.Color.White;
            this.chkAllNics.Location = new System.Drawing.Point(28, 100);
            this.chkAllNics.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllNics.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkAllNics.Name = "chkAllNics";
            this.chkAllNics.OutlineStyle = true;
            this.chkAllNics.OutlineThickness = 1F;
            this.chkAllNics.Rounding = 4;
            this.chkAllNics.ShowSymbols = true;
            this.chkAllNics.Size = new System.Drawing.Size(323, 24);
            this.chkAllNics.TabIndex = 115;
            this.chkAllNics.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkAllNics.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkAllNics.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // dnsTitle
            // 
            this.dnsTitle.AutoSize = true;
            this.dnsTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.dnsTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dnsTitle.Location = new System.Drawing.Point(-1, 3);
            this.dnsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dnsTitle.Name = "dnsTitle";
            this.dnsTitle.Size = new System.Drawing.Size(260, 24);
            this.dnsTitle.TabIndex = 114;
            this.dnsTitle.Tag = "dontTheme";
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
            this.btnOpenNetwork.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpenNetwork.FlatAppearance.BorderSize = 0;
            this.btnOpenNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOpenNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenNetwork.ForeColor = System.Drawing.Color.White;
            this.btnOpenNetwork.Location = new System.Drawing.Point(28, 521);
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
            this.flushCacheB.Location = new System.Drawing.Point(28, 488);
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
            this.boxAdapter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.boxAdapter.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.boxAdapter.DropDownForeColor = System.Drawing.Color.Silver;
            this.boxAdapter.ExpandArrowColor = System.Drawing.Color.Gray;
            this.boxAdapter.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxAdapter.Items = new string[0];
            this.boxAdapter.Location = new System.Drawing.Point(28, 50);
            this.boxAdapter.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.boxAdapter.MaxDropDownHeight = 200;
            this.boxAdapter.Name = "boxAdapter";
            this.boxAdapter.NoSelectionText = "None";
            this.boxAdapter.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boxAdapter.OutlineThickness = 1F;
            this.boxAdapter.Rounding = 8;
            this.boxAdapter.SelectedIndex = -1;
            this.boxAdapter.SelectedItem = "";
            this.boxAdapter.Size = new System.Drawing.Size(660, 45);
            this.boxAdapter.SortAlphabetically = true;
            this.boxAdapter.TabIndex = 124;
            // 
            // boxDNS
            // 
            this.boxDNS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.boxDNS.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.boxDNS.DropDownForeColor = System.Drawing.Color.Silver;
            this.boxDNS.ExpandArrowColor = System.Drawing.Color.Gray;
            this.boxDNS.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxDNS.Items = new string[0];
            this.boxDNS.Location = new System.Drawing.Point(28, 145);
            this.boxDNS.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.boxDNS.MaxDropDownHeight = 200;
            this.boxDNS.Name = "boxDNS";
            this.boxDNS.NoSelectionText = "None";
            this.boxDNS.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boxDNS.OutlineThickness = 1F;
            this.boxDNS.Rounding = 8;
            this.boxDNS.SelectedIndex = -1;
            this.boxDNS.SelectedItem = "";
            this.boxDNS.Size = new System.Drawing.Size(660, 45);
            this.boxDNS.SortAlphabetically = true;
            this.boxDNS.TabIndex = 125;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 638);
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
            this.listPingResults.BackgroundColor = System.Drawing.Color.White;
            this.listPingResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPingResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPingResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listPingResults.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPingResults.ForeColor = System.Drawing.Color.White;
            this.listPingResults.ForegroundColor = System.Drawing.Color.DimGray;
            this.listPingResults.FormattingEnabled = true;
            this.listPingResults.HorizontalScrollbar = true;
            this.listPingResults.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listPingResults.ItemHeight = 21;
            this.listPingResults.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listPingResults.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.listPingResults.ItemRounding = 8;
            this.listPingResults.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listPingResults.Location = new System.Drawing.Point(0, 0);
            this.listPingResults.Margin = new System.Windows.Forms.Padding(2);
            this.listPingResults.Name = "listPingResults";
            this.listPingResults.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listPingResults.Rounding = new System.Windows.Forms.Padding(8);
            this.listPingResults.SelectedForegroundColor = System.Drawing.Color.White;
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
            // hostsEditorTab
            // 
            this.hostsEditorTab.AutoScroll = true;
            this.hostsEditorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hostsEditorTab.Controls.Add(this.hostsLocateBtn);
            this.hostsEditorTab.Controls.Add(this.panel4);
            this.hostsEditorTab.Controls.Add(this.hostsTitle);
            this.hostsEditorTab.Location = new System.Drawing.Point(4, 40);
            this.hostsEditorTab.Margin = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Name = "hostsEditorTab";
            this.hostsEditorTab.Padding = new System.Windows.Forms.Padding(2);
            this.hostsEditorTab.Size = new System.Drawing.Size(1289, 688);
            this.hostsEditorTab.TabIndex = 9;
            this.hostsEditorTab.Text = "Hosts";
            // 
            // hostsLocateBtn
            // 
            this.hostsLocateBtn.CheckButton = false;
            this.hostsLocateBtn.Checked = false;
            this.hostsLocateBtn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.hostsLocateBtn.CheckedForeColor = System.Drawing.Color.White;
            this.hostsLocateBtn.CheckedImageTint = System.Drawing.Color.White;
            this.hostsLocateBtn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.hostsLocateBtn.Content = "Locate";
            this.hostsLocateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hostsLocateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hostsLocateBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.hostsLocateBtn.ForeColor = System.Drawing.Color.White;
            this.hostsLocateBtn.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.hostsLocateBtn.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hostsLocateBtn.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hostsLocateBtn.HoverOutline = System.Drawing.Color.Empty;
            this.hostsLocateBtn.Image = ((System.Drawing.Image)(resources.GetObject("hostsLocateBtn.Image")));
            this.hostsLocateBtn.ImageAutoCenter = true;
            this.hostsLocateBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.hostsLocateBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.hostsLocateBtn.Location = new System.Drawing.Point(11, 40);
            this.hostsLocateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hostsLocateBtn.Name = "hostsLocateBtn";
            this.hostsLocateBtn.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.hostsLocateBtn.NormalForeColor = System.Drawing.Color.White;
            this.hostsLocateBtn.NormalImageTint = System.Drawing.Color.White;
            this.hostsLocateBtn.NormalOutline = System.Drawing.Color.Empty;
            this.hostsLocateBtn.OutlineThickness = 1F;
            this.hostsLocateBtn.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.hostsLocateBtn.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hostsLocateBtn.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hostsLocateBtn.PressedOutline = System.Drawing.Color.Empty;
            this.hostsLocateBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.hostsLocateBtn.Size = new System.Drawing.Size(141, 45);
            this.hostsLocateBtn.TabIndex = 64;
            this.hostsLocateBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.hostsLocateBtn.TextOffset = new System.Drawing.Point(1, 0);
            this.hostsLocateBtn.Click += new System.EventHandler(this.hostsLocateBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.linkAdvancedEdit);
            this.panel4.Controls.Add(this.linkRestoreDefault);
            this.panel4.Controls.Add(this.lblLock);
            this.panel4.Controls.Add(this.panelList);
            this.panel4.Controls.Add(this.refreshHostsB);
            this.panel4.Controls.Add(this.removeHostB);
            this.panel4.Controls.Add(this.removeAllHostsB);
            this.panel4.Controls.Add(this.addHostB);
            this.panel4.Controls.Add(this.txtIP);
            this.panel4.Controls.Add(this.txtDomain);
            this.panel4.Controls.Add(this.lblDomain);
            this.panel4.Controls.Add(this.lblIP);
            this.panel4.Controls.Add(this.chkIncludeWww);
            this.panel4.Controls.Add(this.chkReadOnly);
            this.panel4.Controls.Add(this.chkBlock);
            this.panel4.Location = new System.Drawing.Point(6, 87);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1017, 539);
            this.panel4.TabIndex = 53;
            // 
            // linkAdvancedEdit
            // 
            this.linkAdvancedEdit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkAdvancedEdit.AutoSize = true;
            this.linkAdvancedEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdvancedEdit.ForeColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.LinkColor = System.Drawing.Color.Silver;
            this.linkAdvancedEdit.Location = new System.Drawing.Point(417, 338);
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
            this.linkRestoreDefault.Location = new System.Drawing.Point(417, 369);
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
            this.lblLock.Location = new System.Drawing.Point(419, 234);
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
            this.panelList.Size = new System.Drawing.Size(407, 388);
            this.panelList.TabIndex = 60;
            // 
            // listHostEntries
            // 
            this.listHostEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listHostEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listHostEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHostEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHostEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listHostEntries.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHostEntries.ForeColor = System.Drawing.Color.White;
            this.listHostEntries.ForegroundColor = System.Drawing.Color.DimGray;
            this.listHostEntries.FormattingEnabled = true;
            this.listHostEntries.HorizontalScrollbar = true;
            this.listHostEntries.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listHostEntries.ItemHeight = 36;
            this.listHostEntries.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listHostEntries.ItemHoverForegroundColor = System.Drawing.Color.Gray;
            this.listHostEntries.ItemRounding = 8;
            this.listHostEntries.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listHostEntries.Location = new System.Drawing.Point(0, 0);
            this.listHostEntries.Margin = new System.Windows.Forms.Padding(2);
            this.listHostEntries.Name = "listHostEntries";
            this.listHostEntries.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listHostEntries.Rounding = new System.Windows.Forms.Padding(8);
            this.listHostEntries.SelectedForegroundColor = System.Drawing.Color.White;
            this.listHostEntries.Size = new System.Drawing.Size(407, 388);
            this.listHostEntries.TabIndex = 52;
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
            this.refreshHostsB.Size = new System.Drawing.Size(201, 31);
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
            this.removeHostB.Location = new System.Drawing.Point(211, 395);
            this.removeHostB.Margin = new System.Windows.Forms.Padding(2);
            this.removeHostB.Name = "removeHostB";
            this.removeHostB.Size = new System.Drawing.Size(201, 31);
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
            this.removeAllHostsB.Location = new System.Drawing.Point(211, 430);
            this.removeAllHostsB.Margin = new System.Windows.Forms.Padding(2);
            this.removeAllHostsB.Name = "removeAllHostsB";
            this.removeAllHostsB.Size = new System.Drawing.Size(201, 31);
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
            this.addHostB.Location = new System.Drawing.Point(605, 110);
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
            this.txtIP.Location = new System.Drawing.Point(422, 23);
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
            this.txtDomain.Location = new System.Drawing.Point(422, 77);
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
            this.lblDomain.Location = new System.Drawing.Point(417, 54);
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
            this.lblIP.Location = new System.Drawing.Point(417, 0);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(85, 21);
            this.lblIP.TabIndex = 53;
            this.lblIP.Tag = "themeable";
            this.lblIP.Text = "IP address";
            // 
            // chkIncludeWww
            // 
            this.chkIncludeWww.Checked = false;
            this.chkIncludeWww.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkIncludeWww.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkIncludeWww.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkIncludeWww.Content = "WWW CNAME";
            this.chkIncludeWww.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIncludeWww.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeWww.ForeColor = System.Drawing.Color.White;
            this.chkIncludeWww.Location = new System.Drawing.Point(423, 136);
            this.chkIncludeWww.Margin = new System.Windows.Forms.Padding(2);
            this.chkIncludeWww.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkIncludeWww.Name = "chkIncludeWww";
            this.chkIncludeWww.OutlineStyle = true;
            this.chkIncludeWww.OutlineThickness = 1F;
            this.chkIncludeWww.Rounding = 4;
            this.chkIncludeWww.ShowSymbols = true;
            this.chkIncludeWww.Size = new System.Drawing.Size(201, 25);
            this.chkIncludeWww.TabIndex = 63;
            this.chkIncludeWww.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkIncludeWww.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkIncludeWww.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.Checked = false;
            this.chkReadOnly.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkReadOnly.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkReadOnly.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkReadOnly.Content = "Read-only";
            this.chkReadOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReadOnly.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadOnly.ForeColor = System.Drawing.Color.White;
            this.chkReadOnly.Location = new System.Drawing.Point(423, 207);
            this.chkReadOnly.Margin = new System.Windows.Forms.Padding(2);
            this.chkReadOnly.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.OutlineStyle = true;
            this.chkReadOnly.OutlineThickness = 1F;
            this.chkReadOnly.Rounding = 4;
            this.chkReadOnly.ShowSymbols = true;
            this.chkReadOnly.Size = new System.Drawing.Size(170, 25);
            this.chkReadOnly.TabIndex = 61;
            this.chkReadOnly.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkReadOnly.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkReadOnly.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // chkBlock
            // 
            this.chkBlock.Checked = false;
            this.chkBlock.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkBlock.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.chkBlock.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkBlock.Content = "Block";
            this.chkBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBlock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlock.ForeColor = System.Drawing.Color.White;
            this.chkBlock.Location = new System.Drawing.Point(423, 110);
            this.chkBlock.Margin = new System.Windows.Forms.Padding(2);
            this.chkBlock.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkBlock.Name = "chkBlock";
            this.chkBlock.OutlineStyle = true;
            this.chkBlock.OutlineThickness = 1F;
            this.chkBlock.Rounding = 4;
            this.chkBlock.ShowSymbols = true;
            this.chkBlock.Size = new System.Drawing.Size(136, 25);
            this.chkBlock.TabIndex = 59;
            this.chkBlock.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkBlock.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkBlock.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.chkBlock.CheckedChanged += new System.EventHandler(this.chkBlock_CheckedChanged);
            // 
            // hostsTitle
            // 
            this.hostsTitle.AutoSize = true;
            this.hostsTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.hostsTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.hostsTitle.Location = new System.Drawing.Point(6, 10);
            this.hostsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostsTitle.Name = "hostsTitle";
            this.hostsTitle.Size = new System.Drawing.Size(179, 24);
            this.hostsTitle.TabIndex = 3;
            this.hostsTitle.Tag = "dontTheme";
            this.hostsTitle.Text = "Edit your hosts file";
            // 
            // registryFixerTab
            // 
            this.registryFixerTab.AutoScroll = true;
            this.registryFixerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.registryFixerTab.Controls.Add(this.panel2);
            this.registryFixerTab.Controls.Add(this.registryTitle);
            this.registryFixerTab.Location = new System.Drawing.Point(4, 40);
            this.registryFixerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Name = "registryFixerTab";
            this.registryFixerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registryFixerTab.Size = new System.Drawing.Size(1289, 688);
            this.registryFixerTab.TabIndex = 8;
            this.registryFixerTab.Text = "Registry";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.regLbl);
            this.panel2.Controls.Add(this.regFixB);
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
            this.panel2.Size = new System.Drawing.Size(755, 288);
            this.panel2.TabIndex = 48;
            // 
            // regLbl
            // 
            this.regLbl.AutoSize = true;
            this.regLbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLbl.ForeColor = System.Drawing.Color.Gray;
            this.regLbl.Location = new System.Drawing.Point(55, 203);
            this.regLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(186, 15);
            this.regLbl.TabIndex = 51;
            this.regLbl.Tag = "";
            this.regLbl.Text = "(some changes might need this)";
            this.regLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regFixB
            // 
            this.regFixB.CheckButton = false;
            this.regFixB.Checked = false;
            this.regFixB.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.regFixB.CheckedForeColor = System.Drawing.Color.White;
            this.regFixB.CheckedImageTint = System.Drawing.Color.White;
            this.regFixB.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.regFixB.Content = "Fix";
            this.regFixB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regFixB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.regFixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.regFixB.ForeColor = System.Drawing.Color.White;
            this.regFixB.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.regFixB.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regFixB.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regFixB.HoverOutline = System.Drawing.Color.Empty;
            this.regFixB.Image = ((System.Drawing.Image)(resources.GetObject("regFixB.Image")));
            this.regFixB.ImageAutoCenter = true;
            this.regFixB.ImageExpand = new System.Drawing.Point(0, 0);
            this.regFixB.ImageOffset = new System.Drawing.Point(-1, 0);
            this.regFixB.Location = new System.Drawing.Point(29, 239);
            this.regFixB.Margin = new System.Windows.Forms.Padding(2);
            this.regFixB.Name = "regFixB";
            this.regFixB.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.regFixB.NormalForeColor = System.Drawing.Color.White;
            this.regFixB.NormalImageTint = System.Drawing.Color.White;
            this.regFixB.NormalOutline = System.Drawing.Color.Empty;
            this.regFixB.OutlineThickness = 1F;
            this.regFixB.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.regFixB.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regFixB.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.regFixB.PressedOutline = System.Drawing.Color.Empty;
            this.regFixB.Rounding = new System.Windows.Forms.Padding(8);
            this.regFixB.Size = new System.Drawing.Size(154, 45);
            this.regFixB.TabIndex = 49;
            this.regFixB.TextAlignment = System.Drawing.StringAlignment.Center;
            this.regFixB.TextOffset = new System.Drawing.Point(1, 0);
            this.regFixB.Click += new System.EventHandler(this.button33_Click);
            // 
            // checkRestartExplorer
            // 
            this.checkRestartExplorer.Checked = false;
            this.checkRestartExplorer.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRestartExplorer.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRestartExplorer.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkRestartExplorer.Content = "Also restart Explorer to apply changes";
            this.checkRestartExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRestartExplorer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestartExplorer.ForeColor = System.Drawing.Color.White;
            this.checkRestartExplorer.Location = new System.Drawing.Point(29, 181);
            this.checkRestartExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.checkRestartExplorer.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkRestartExplorer.Name = "checkRestartExplorer";
            this.checkRestartExplorer.OutlineStyle = true;
            this.checkRestartExplorer.OutlineThickness = 1F;
            this.checkRestartExplorer.Rounding = 4;
            this.checkRestartExplorer.ShowSymbols = true;
            this.checkRestartExplorer.Size = new System.Drawing.Size(494, 25);
            this.checkRestartExplorer.TabIndex = 50;
            this.checkRestartExplorer.Tag = "";
            this.checkRestartExplorer.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkRestartExplorer.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkRestartExplorer.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkRegistryEditor
            // 
            this.checkRegistryEditor.Checked = false;
            this.checkRegistryEditor.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRegistryEditor.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRegistryEditor.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkRegistryEditor.Content = "Registry Editor";
            this.checkRegistryEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRegistryEditor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegistryEditor.ForeColor = System.Drawing.Color.White;
            this.checkRegistryEditor.Location = new System.Drawing.Point(291, 136);
            this.checkRegistryEditor.Margin = new System.Windows.Forms.Padding(2);
            this.checkRegistryEditor.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkRegistryEditor.Name = "checkRegistryEditor";
            this.checkRegistryEditor.OutlineStyle = true;
            this.checkRegistryEditor.OutlineThickness = 1F;
            this.checkRegistryEditor.Rounding = 4;
            this.checkRegistryEditor.ShowSymbols = true;
            this.checkRegistryEditor.Size = new System.Drawing.Size(232, 25);
            this.checkRegistryEditor.TabIndex = 38;
            this.checkRegistryEditor.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkRegistryEditor.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkRegistryEditor.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkEnableAll
            // 
            this.checkEnableAll.Checked = false;
            this.checkEnableAll.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkEnableAll.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkEnableAll.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkEnableAll.Content = "Enable all";
            this.checkEnableAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEnableAll.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnableAll.ForeColor = System.Drawing.Color.White;
            this.checkEnableAll.Location = new System.Drawing.Point(29, 14);
            this.checkEnableAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkEnableAll.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkEnableAll.Name = "checkEnableAll";
            this.checkEnableAll.OutlineStyle = true;
            this.checkEnableAll.OutlineThickness = 1F;
            this.checkEnableAll.Rounding = 4;
            this.checkEnableAll.ShowSymbols = true;
            this.checkEnableAll.Size = new System.Drawing.Size(97, 25);
            this.checkEnableAll.TabIndex = 35;
            this.checkEnableAll.Tag = "";
            this.checkEnableAll.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkEnableAll.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkEnableAll.UncheckedSymbolColor = System.Drawing.Color.Empty;
            this.checkEnableAll.CheckedChanged += new System.EventHandler(this.checkEnableAll_CheckedChanged);
            // 
            // checkContextMenu
            // 
            this.checkContextMenu.Checked = false;
            this.checkContextMenu.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkContextMenu.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkContextMenu.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkContextMenu.Content = "Right Click menu";
            this.checkContextMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkContextMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkContextMenu.ForeColor = System.Drawing.Color.White;
            this.checkContextMenu.Location = new System.Drawing.Point(291, 75);
            this.checkContextMenu.Margin = new System.Windows.Forms.Padding(2);
            this.checkContextMenu.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkContextMenu.Name = "checkContextMenu";
            this.checkContextMenu.OutlineStyle = true;
            this.checkContextMenu.OutlineThickness = 1F;
            this.checkContextMenu.Rounding = 4;
            this.checkContextMenu.ShowSymbols = true;
            this.checkContextMenu.Size = new System.Drawing.Size(232, 25);
            this.checkContextMenu.TabIndex = 43;
            this.checkContextMenu.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkContextMenu.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkContextMenu.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkTaskManager
            // 
            this.checkTaskManager.Checked = false;
            this.checkTaskManager.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkTaskManager.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkTaskManager.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkTaskManager.Content = "Task Manager";
            this.checkTaskManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTaskManager.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTaskManager.ForeColor = System.Drawing.Color.White;
            this.checkTaskManager.Location = new System.Drawing.Point(55, 45);
            this.checkTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.checkTaskManager.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkTaskManager.Name = "checkTaskManager";
            this.checkTaskManager.OutlineStyle = true;
            this.checkTaskManager.OutlineThickness = 1F;
            this.checkTaskManager.Rounding = 4;
            this.checkTaskManager.ShowSymbols = true;
            this.checkTaskManager.Size = new System.Drawing.Size(232, 25);
            this.checkTaskManager.TabIndex = 36;
            this.checkTaskManager.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkTaskManager.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkTaskManager.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkCommandPrompt
            // 
            this.checkCommandPrompt.Checked = false;
            this.checkCommandPrompt.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkCommandPrompt.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkCommandPrompt.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkCommandPrompt.Content = "Command Prompt";
            this.checkCommandPrompt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCommandPrompt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCommandPrompt.ForeColor = System.Drawing.Color.White;
            this.checkCommandPrompt.Location = new System.Drawing.Point(55, 75);
            this.checkCommandPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.checkCommandPrompt.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkCommandPrompt.Name = "checkCommandPrompt";
            this.checkCommandPrompt.OutlineStyle = true;
            this.checkCommandPrompt.OutlineThickness = 1F;
            this.checkCommandPrompt.Rounding = 4;
            this.checkCommandPrompt.ShowSymbols = true;
            this.checkCommandPrompt.Size = new System.Drawing.Size(232, 25);
            this.checkCommandPrompt.TabIndex = 42;
            this.checkCommandPrompt.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkCommandPrompt.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkCommandPrompt.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkFirewall
            // 
            this.checkFirewall.Checked = false;
            this.checkFirewall.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkFirewall.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkFirewall.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkFirewall.Content = "Windows Firewall";
            this.checkFirewall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFirewall.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFirewall.ForeColor = System.Drawing.Color.White;
            this.checkFirewall.Location = new System.Drawing.Point(291, 106);
            this.checkFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.checkFirewall.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkFirewall.Name = "checkFirewall";
            this.checkFirewall.OutlineStyle = true;
            this.checkFirewall.OutlineThickness = 1F;
            this.checkFirewall.Rounding = 4;
            this.checkFirewall.ShowSymbols = true;
            this.checkFirewall.Size = new System.Drawing.Size(232, 25);
            this.checkFirewall.TabIndex = 37;
            this.checkFirewall.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkFirewall.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkFirewall.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkRunDialog
            // 
            this.checkRunDialog.Checked = false;
            this.checkRunDialog.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRunDialog.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkRunDialog.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkRunDialog.Content = "Run Dialog";
            this.checkRunDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRunDialog.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRunDialog.ForeColor = System.Drawing.Color.White;
            this.checkRunDialog.Location = new System.Drawing.Point(291, 45);
            this.checkRunDialog.Margin = new System.Windows.Forms.Padding(2);
            this.checkRunDialog.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkRunDialog.Name = "checkRunDialog";
            this.checkRunDialog.OutlineStyle = true;
            this.checkRunDialog.OutlineThickness = 1F;
            this.checkRunDialog.Rounding = 4;
            this.checkRunDialog.ShowSymbols = true;
            this.checkRunDialog.Size = new System.Drawing.Size(232, 25);
            this.checkRunDialog.TabIndex = 41;
            this.checkRunDialog.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkRunDialog.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkRunDialog.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkFolderOptions
            // 
            this.checkFolderOptions.Checked = false;
            this.checkFolderOptions.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkFolderOptions.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkFolderOptions.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkFolderOptions.Content = "Folder Options";
            this.checkFolderOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFolderOptions.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFolderOptions.ForeColor = System.Drawing.Color.White;
            this.checkFolderOptions.Location = new System.Drawing.Point(55, 136);
            this.checkFolderOptions.Margin = new System.Windows.Forms.Padding(2);
            this.checkFolderOptions.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkFolderOptions.Name = "checkFolderOptions";
            this.checkFolderOptions.OutlineStyle = true;
            this.checkFolderOptions.OutlineThickness = 1F;
            this.checkFolderOptions.Rounding = 4;
            this.checkFolderOptions.ShowSymbols = true;
            this.checkFolderOptions.Size = new System.Drawing.Size(232, 25);
            this.checkFolderOptions.TabIndex = 39;
            this.checkFolderOptions.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkFolderOptions.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkFolderOptions.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // checkControlPanel
            // 
            this.checkControlPanel.Checked = false;
            this.checkControlPanel.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkControlPanel.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkControlPanel.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkControlPanel.Content = "Control Panel";
            this.checkControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkControlPanel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkControlPanel.ForeColor = System.Drawing.Color.White;
            this.checkControlPanel.Location = new System.Drawing.Point(55, 106);
            this.checkControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.checkControlPanel.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkControlPanel.Name = "checkControlPanel";
            this.checkControlPanel.OutlineStyle = true;
            this.checkControlPanel.OutlineThickness = 1F;
            this.checkControlPanel.Rounding = 4;
            this.checkControlPanel.ShowSymbols = true;
            this.checkControlPanel.Size = new System.Drawing.Size(232, 25);
            this.checkControlPanel.TabIndex = 40;
            this.checkControlPanel.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkControlPanel.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkControlPanel.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // registryTitle
            // 
            this.registryTitle.AutoSize = true;
            this.registryTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.registryTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.registryTitle.Location = new System.Drawing.Point(6, 10);
            this.registryTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registryTitle.Name = "registryTitle";
            this.registryTitle.Size = new System.Drawing.Size(257, 24);
            this.registryTitle.TabIndex = 47;
            this.registryTitle.Tag = "dontTheme";
            this.registryTitle.Text = "Fix common registry issues";
            // 
            // indiciumTab
            // 
            this.indiciumTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.indiciumTab.Controls.Add(this.panel12);
            this.indiciumTab.Controls.Add(this.panel11);
            this.indiciumTab.Location = new System.Drawing.Point(4, 40);
            this.indiciumTab.Name = "indiciumTab";
            this.indiciumTab.Padding = new System.Windows.Forms.Padding(3);
            this.indiciumTab.Size = new System.Drawing.Size(1289, 688);
            this.indiciumTab.TabIndex = 14;
            this.indiciumTab.Text = "Hardware";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.specsTree);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 49);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1283, 636);
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
            this.specsTree.Size = new System.Drawing.Size(1281, 634);
            this.specsTree.TabIndex = 0;
            this.specsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.specsTree_NodeMouseClick);
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
            this.panel11.Size = new System.Drawing.Size(1283, 46);
            this.panel11.TabIndex = 1;
            // 
            // btnCopyHW
            // 
            this.btnCopyHW.CheckButton = false;
            this.btnCopyHW.Checked = false;
            this.btnCopyHW.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCopyHW.CheckedForeColor = System.Drawing.Color.White;
            this.btnCopyHW.CheckedImageTint = System.Drawing.Color.White;
            this.btnCopyHW.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnCopyHW.Content = "Copy";
            this.btnCopyHW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyHW.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCopyHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHW.ForeColor = System.Drawing.Color.White;
            this.btnCopyHW.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnCopyHW.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopyHW.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopyHW.HoverOutline = System.Drawing.Color.Empty;
            this.btnCopyHW.Image = null;
            this.btnCopyHW.ImageAutoCenter = true;
            this.btnCopyHW.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnCopyHW.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCopyHW.Location = new System.Drawing.Point(110, 4);
            this.btnCopyHW.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyHW.Name = "btnCopyHW";
            this.btnCopyHW.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnCopyHW.NormalForeColor = System.Drawing.Color.White;
            this.btnCopyHW.NormalImageTint = System.Drawing.Color.White;
            this.btnCopyHW.NormalOutline = System.Drawing.Color.Empty;
            this.btnCopyHW.OutlineThickness = 1F;
            this.btnCopyHW.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnCopyHW.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopyHW.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCopyHW.PressedOutline = System.Drawing.Color.Empty;
            this.btnCopyHW.Rounding = new System.Windows.Forms.Padding(8);
            this.btnCopyHW.Size = new System.Drawing.Size(102, 36);
            this.btnCopyHW.TabIndex = 163;
            this.btnCopyHW.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCopyHW.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCopyHW.Click += new System.EventHandler(this.btnCopyHW_Click);
            // 
            // btnSaveHW
            // 
            this.btnSaveHW.CheckButton = false;
            this.btnSaveHW.Checked = false;
            this.btnSaveHW.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveHW.CheckedForeColor = System.Drawing.Color.White;
            this.btnSaveHW.CheckedImageTint = System.Drawing.Color.White;
            this.btnSaveHW.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSaveHW.Content = "Save";
            this.btnSaveHW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveHW.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveHW.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHW.ForeColor = System.Drawing.Color.White;
            this.btnSaveHW.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnSaveHW.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveHW.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveHW.HoverOutline = System.Drawing.Color.Empty;
            this.btnSaveHW.Image = null;
            this.btnSaveHW.ImageAutoCenter = true;
            this.btnSaveHW.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSaveHW.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSaveHW.Location = new System.Drawing.Point(4, 4);
            this.btnSaveHW.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveHW.Name = "btnSaveHW";
            this.btnSaveHW.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnSaveHW.NormalForeColor = System.Drawing.Color.White;
            this.btnSaveHW.NormalImageTint = System.Drawing.Color.White;
            this.btnSaveHW.NormalOutline = System.Drawing.Color.Empty;
            this.btnSaveHW.OutlineThickness = 1F;
            this.btnSaveHW.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSaveHW.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveHW.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveHW.PressedOutline = System.Drawing.Color.Empty;
            this.btnSaveHW.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSaveHW.Size = new System.Drawing.Size(102, 36);
            this.btnSaveHW.TabIndex = 162;
            this.btnSaveHW.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveHW.TextOffset = new System.Drawing.Point(0, 0);
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
            this.hwDetailed.Location = new System.Drawing.Point(220, 10);
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
            this.integratorTab.Location = new System.Drawing.Point(4, 40);
            this.integratorTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorTab.Name = "integratorTab";
            this.integratorTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorTab.Size = new System.Drawing.Size(1289, 688);
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
            this.synapse.Controls.Add(this.tabPage4);
            this.synapse.Controls.Add(this.tabPage3);
            this.synapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synapse.ItemSize = new System.Drawing.Size(96, 36);
            this.synapse.Location = new System.Drawing.Point(2, 2);
            this.synapse.Margin = new System.Windows.Forms.Padding(0);
            this.synapse.Multiline = true;
            this.synapse.Name = "synapse";
            this.synapse.Padding = new System.Drawing.Point(0, 0);
            this.synapse.SelectedIndex = 0;
            this.synapse.Size = new System.Drawing.Size(1285, 684);
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
            this.integratorInfoTab.Location = new System.Drawing.Point(4, 4);
            this.integratorInfoTab.Margin = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Name = "integratorInfoTab";
            this.integratorInfoTab.Padding = new System.Windows.Forms.Padding(2);
            this.integratorInfoTab.Size = new System.Drawing.Size(1277, 640);
            this.integratorInfoTab.TabIndex = 0;
            this.integratorInfoTab.Text = "Info";
            // 
            // integrator7
            // 
            this.integrator7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator7.ForeColor = System.Drawing.Color.Silver;
            this.integrator7.Location = new System.Drawing.Point(7, 225);
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
            this.integrator6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator6.ForeColor = System.Drawing.Color.Silver;
            this.integrator6.Location = new System.Drawing.Point(38, 183);
            this.integrator6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator6.Name = "integrator6";
            this.integrator6.Size = new System.Drawing.Size(101, 19);
            this.integrator6.TabIndex = 9;
            this.integrator6.Tag = "";
            this.integrator6.Text = "• Commands";
            // 
            // integrator5
            // 
            this.integrator5.AutoSize = true;
            this.integrator5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator5.ForeColor = System.Drawing.Color.Silver;
            this.integrator5.Location = new System.Drawing.Point(38, 158);
            this.integrator5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator5.Name = "integrator5";
            this.integrator5.Size = new System.Drawing.Size(124, 19);
            this.integrator5.TabIndex = 8;
            this.integrator5.Tag = "";
            this.integrator5.Text = "• Any type of file";
            // 
            // integrator4
            // 
            this.integrator4.AutoSize = true;
            this.integrator4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator4.ForeColor = System.Drawing.Color.Silver;
            this.integrator4.Location = new System.Drawing.Point(38, 132);
            this.integrator4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator4.Name = "integrator4";
            this.integrator4.Size = new System.Drawing.Size(149, 19);
            this.integrator4.TabIndex = 7;
            this.integrator4.Tag = "";
            this.integrator4.Text = "• Links to webpages";
            // 
            // integrator3
            // 
            this.integrator3.AutoSize = true;
            this.integrator3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator3.ForeColor = System.Drawing.Color.Silver;
            this.integrator3.Location = new System.Drawing.Point(38, 106);
            this.integrator3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator3.Name = "integrator3";
            this.integrator3.Size = new System.Drawing.Size(157, 19);
            this.integrator3.TabIndex = 6;
            this.integrator3.Tag = "";
            this.integrator3.Text = "• Shortcuts to folders";
            // 
            // integrator2
            // 
            this.integrator2.AutoSize = true;
            this.integrator2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator2.ForeColor = System.Drawing.Color.Silver;
            this.integrator2.Location = new System.Drawing.Point(38, 81);
            this.integrator2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator2.Name = "integrator2";
            this.integrator2.Size = new System.Drawing.Size(113, 19);
            this.integrator2.TabIndex = 5;
            this.integrator2.Tag = "";
            this.integrator2.Text = "• Any program";
            // 
            // integrator1
            // 
            this.integrator1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrator1.ForeColor = System.Drawing.Color.Gainsboro;
            this.integrator1.Location = new System.Drawing.Point(6, 10);
            this.integrator1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.integrator1.Name = "integrator1";
            this.integrator1.Size = new System.Drawing.Size(811, 61);
            this.integrator1.TabIndex = 4;
            this.integrator1.Tag = "dontTheme";
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
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(1277, 640);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Add/Modify";
            // 
            // btnAddItem
            // 
            this.btnAddItem.CheckButton = false;
            this.btnAddItem.Checked = false;
            this.btnAddItem.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddItem.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddItem.CheckedImageTint = System.Drawing.Color.White;
            this.btnAddItem.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAddItem.Content = "Add/Modify";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddItem.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddItem.HoverOutline = System.Drawing.Color.Empty;
            this.btnAddItem.Image = null;
            this.btnAddItem.ImageAutoCenter = true;
            this.btnAddItem.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAddItem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddItem.Location = new System.Drawing.Point(436, 473);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.NormalForeColor = System.Drawing.Color.White;
            this.btnAddItem.NormalImageTint = System.Drawing.Color.White;
            this.btnAddItem.NormalOutline = System.Drawing.Color.Empty;
            this.btnAddItem.OutlineThickness = 1F;
            this.btnAddItem.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddItem.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddItem.PressedOutline = System.Drawing.Color.Empty;
            this.btnAddItem.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAddItem.Size = new System.Drawing.Size(202, 45);
            this.btnAddItem.TabIndex = 85;
            this.btnAddItem.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddItem.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // itemnamegroup
            // 
            this.itemnamegroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemnamegroup.Content = "Item name in menu:";
            this.itemnamegroup.Controls.Add(this.txtItemName);
            this.itemnamegroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnamegroup.ForeColor = System.Drawing.Color.Silver;
            this.itemnamegroup.Location = new System.Drawing.Point(11, 403);
            this.itemnamegroup.Margin = new System.Windows.Forms.Padding(2);
            this.itemnamegroup.Name = "itemnamegroup";
            this.itemnamegroup.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.itemnamegroup.Rounding = new System.Windows.Forms.Padding(4);
            this.itemnamegroup.Size = new System.Drawing.Size(627, 66);
            this.itemnamegroup.TabIndex = 84;
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
            this.security.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.security.Content = "Security:";
            this.security.Controls.Add(this.checkShift);
            this.security.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.security.ForeColor = System.Drawing.Color.Silver;
            this.security.Location = new System.Drawing.Point(11, 338);
            this.security.Margin = new System.Windows.Forms.Padding(2);
            this.security.Name = "security";
            this.security.Padding = new System.Windows.Forms.Padding(4, 22, 4, 4);
            this.security.Rounding = new System.Windows.Forms.Padding(4);
            this.security.Size = new System.Drawing.Size(627, 61);
            this.security.TabIndex = 83;
            // 
            // checkShift
            // 
            this.checkShift.Checked = false;
            this.checkShift.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkShift.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkShift.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkShift.Content = "Show only when SHIFT key is pressed";
            this.checkShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkShift.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShift.ForeColor = System.Drawing.Color.White;
            this.checkShift.Location = new System.Drawing.Point(11, 26);
            this.checkShift.Margin = new System.Windows.Forms.Padding(2);
            this.checkShift.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkShift.Name = "checkShift";
            this.checkShift.OutlineStyle = true;
            this.checkShift.OutlineThickness = 1F;
            this.checkShift.Rounding = 4;
            this.checkShift.ShowSymbols = true;
            this.checkShift.Size = new System.Drawing.Size(300, 25);
            this.checkShift.TabIndex = 83;
            this.checkShift.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkShift.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkShift.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // itemposition
            // 
            this.itemposition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemposition.Content = "Item position:";
            this.itemposition.Controls.Add(this.radioTop);
            this.itemposition.Controls.Add(this.radioMiddle);
            this.itemposition.Controls.Add(this.radioBottom);
            this.itemposition.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemposition.ForeColor = System.Drawing.Color.Silver;
            this.itemposition.Location = new System.Drawing.Point(11, 272);
            this.itemposition.Margin = new System.Windows.Forms.Padding(2);
            this.itemposition.Name = "itemposition";
            this.itemposition.Padding = new System.Windows.Forms.Padding(4, 22, 4, 4);
            this.itemposition.Rounding = new System.Windows.Forms.Padding(4);
            this.itemposition.Size = new System.Drawing.Size(627, 62);
            this.itemposition.TabIndex = 82;
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.radioTop.ForeColor = System.Drawing.Color.White;
            this.radioTop.Location = new System.Drawing.Point(13, 24);
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
            this.radioMiddle.Location = new System.Drawing.Point(133, 24);
            this.radioMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.radioMiddle.Name = "radioMiddle";
            this.radioMiddle.Size = new System.Drawing.Size(77, 23);
            this.radioMiddle.TabIndex = 84;
            this.radioMiddle.Text = "Middle";
            this.radioMiddle.UseVisualStyleBackColor = true;
            this.radioMiddle.CheckedChanged += new System.EventHandler(this.radioMiddle_CheckedChanged);
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.ForeColor = System.Drawing.Color.White;
            this.radioBottom.Location = new System.Drawing.Point(279, 24);
            this.radioBottom.Margin = new System.Windows.Forms.Padding(2);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(78, 23);
            this.radioBottom.TabIndex = 85;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = true;
            this.radioBottom.CheckedChanged += new System.EventHandler(this.radioBottom_CheckedChanged);
            // 
            // icontoaddgroup
            // 
            this.icontoaddgroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.icontoaddgroup.Content = "Icon to add:";
            this.icontoaddgroup.Controls.Add(this.checkDefaultIcon);
            this.icontoaddgroup.Controls.Add(this.btnBrowseIcon);
            this.icontoaddgroup.Controls.Add(this.txtIcon);
            this.icontoaddgroup.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icontoaddgroup.ForeColor = System.Drawing.Color.Silver;
            this.icontoaddgroup.Location = new System.Drawing.Point(11, 178);
            this.icontoaddgroup.Margin = new System.Windows.Forms.Padding(2);
            this.icontoaddgroup.Name = "icontoaddgroup";
            this.icontoaddgroup.Padding = new System.Windows.Forms.Padding(4, 22, 4, 4);
            this.icontoaddgroup.Rounding = new System.Windows.Forms.Padding(4);
            this.icontoaddgroup.Size = new System.Drawing.Size(627, 90);
            this.icontoaddgroup.TabIndex = 81;
            // 
            // checkDefaultIcon
            // 
            this.checkDefaultIcon.Checked = false;
            this.checkDefaultIcon.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkDefaultIcon.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.checkDefaultIcon.CheckedSymbolColor = System.Drawing.Color.White;
            this.checkDefaultIcon.Content = "Use program\'s icon";
            this.checkDefaultIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkDefaultIcon.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDefaultIcon.ForeColor = System.Drawing.Color.White;
            this.checkDefaultIcon.Location = new System.Drawing.Point(11, 58);
            this.checkDefaultIcon.Margin = new System.Windows.Forms.Padding(2);
            this.checkDefaultIcon.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkDefaultIcon.Name = "checkDefaultIcon";
            this.checkDefaultIcon.OutlineStyle = true;
            this.checkDefaultIcon.OutlineThickness = 1F;
            this.checkDefaultIcon.Rounding = 4;
            this.checkDefaultIcon.ShowSymbols = true;
            this.checkDefaultIcon.Size = new System.Drawing.Size(169, 25);
            this.checkDefaultIcon.TabIndex = 82;
            this.checkDefaultIcon.UncheckedForeground = System.Drawing.Color.Empty;
            this.checkDefaultIcon.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.checkDefaultIcon.UncheckedSymbolColor = System.Drawing.Color.Empty;
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
            this.btnBrowseIcon.Location = new System.Drawing.Point(452, 24);
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
            this.txtIcon.Size = new System.Drawing.Size(434, 27);
            this.txtIcon.TabIndex = 81;
            // 
            // itemtoaddgroup
            // 
            this.itemtoaddgroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemtoaddgroup.Content = "Program to add:";
            this.itemtoaddgroup.Controls.Add(this.btnBrowseItem);
            this.itemtoaddgroup.Controls.Add(this.txtItem);
            this.itemtoaddgroup.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtoaddgroup.ForeColor = System.Drawing.Color.Silver;
            this.itemtoaddgroup.Location = new System.Drawing.Point(11, 107);
            this.itemtoaddgroup.Margin = new System.Windows.Forms.Padding(2);
            this.itemtoaddgroup.Name = "itemtoaddgroup";
            this.itemtoaddgroup.Padding = new System.Windows.Forms.Padding(4, 22, 4, 4);
            this.itemtoaddgroup.Rounding = new System.Windows.Forms.Padding(4);
            this.itemtoaddgroup.Size = new System.Drawing.Size(627, 67);
            this.itemtoaddgroup.TabIndex = 80;
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
            this.btnBrowseItem.Location = new System.Drawing.Point(451, 24);
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
            this.txtItem.Size = new System.Drawing.Size(434, 27);
            this.txtItem.TabIndex = 81;
            // 
            // itemtype
            // 
            this.itemtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemtype.Content = "Item Type:";
            this.itemtype.Controls.Add(this.radioCommand);
            this.itemtype.Controls.Add(this.radioProgram);
            this.itemtype.Controls.Add(this.radioFolder);
            this.itemtype.Controls.Add(this.radioLink);
            this.itemtype.Controls.Add(this.radioFile);
            this.itemtype.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtype.ForeColor = System.Drawing.Color.Silver;
            this.itemtype.Location = new System.Drawing.Point(11, 40);
            this.itemtype.Margin = new System.Windows.Forms.Padding(2);
            this.itemtype.Name = "itemtype";
            this.itemtype.Padding = new System.Windows.Forms.Padding(4, 22, 4, 4);
            this.itemtype.Rounding = new System.Windows.Forms.Padding(4);
            this.itemtype.Size = new System.Drawing.Size(627, 63);
            this.itemtype.TabIndex = 79;
            // 
            // radioCommand
            // 
            this.radioCommand.AutoSize = true;
            this.radioCommand.ForeColor = System.Drawing.Color.White;
            this.radioCommand.Location = new System.Drawing.Point(483, 24);
            this.radioCommand.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommand.Name = "radioCommand";
            this.radioCommand.Size = new System.Drawing.Size(101, 23);
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
            this.radioProgram.Location = new System.Drawing.Point(13, 24);
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
            this.radioFolder.Location = new System.Drawing.Point(141, 24);
            this.radioFolder.Margin = new System.Windows.Forms.Padding(2);
            this.radioFolder.Name = "radioFolder";
            this.radioFolder.Size = new System.Drawing.Size(72, 23);
            this.radioFolder.TabIndex = 81;
            this.radioFolder.Text = "Folder";
            this.radioFolder.UseVisualStyleBackColor = true;
            this.radioFolder.CheckedChanged += new System.EventHandler(this.radioFolder_CheckedChanged);
            // 
            // radioLink
            // 
            this.radioLink.AutoSize = true;
            this.radioLink.ForeColor = System.Drawing.Color.White;
            this.radioLink.Location = new System.Drawing.Point(256, 24);
            this.radioLink.Margin = new System.Windows.Forms.Padding(2);
            this.radioLink.Name = "radioLink";
            this.radioLink.Size = new System.Drawing.Size(56, 23);
            this.radioLink.TabIndex = 82;
            this.radioLink.Text = "Link";
            this.radioLink.UseVisualStyleBackColor = true;
            this.radioLink.CheckedChanged += new System.EventHandler(this.radioLink_CheckedChanged);
            // 
            // radioFile
            // 
            this.radioFile.AutoSize = true;
            this.radioFile.ForeColor = System.Drawing.Color.White;
            this.radioFile.Location = new System.Drawing.Point(373, 24);
            this.radioFile.Margin = new System.Windows.Forms.Padding(2);
            this.radioFile.Name = "radioFile";
            this.radioFile.Size = new System.Drawing.Size(51, 23);
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
            this.tabPage9.AutoScroll = true;
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
            this.tabPage9.Size = new System.Drawing.Size(1277, 640);
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
            this.listDesktopItems.BackgroundColor = System.Drawing.Color.White;
            this.listDesktopItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDesktopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDesktopItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listDesktopItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDesktopItems.ForeColor = System.Drawing.Color.White;
            this.listDesktopItems.ForegroundColor = System.Drawing.Color.DimGray;
            this.listDesktopItems.FormattingEnabled = true;
            this.listDesktopItems.HorizontalScrollbar = true;
            this.listDesktopItems.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listDesktopItems.ItemHeight = 21;
            this.listDesktopItems.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listDesktopItems.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.listDesktopItems.ItemRounding = 8;
            this.listDesktopItems.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listDesktopItems.Location = new System.Drawing.Point(0, 0);
            this.listDesktopItems.Margin = new System.Windows.Forms.Padding(2);
            this.listDesktopItems.Name = "listDesktopItems";
            this.listDesktopItems.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listDesktopItems.Rounding = new System.Windows.Forms.Padding(8);
            this.listDesktopItems.SelectedForegroundColor = System.Drawing.Color.White;
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
            this.tabPage10.Location = new System.Drawing.Point(4, 4);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(1277, 640);
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
            this.tabPage11.Location = new System.Drawing.Point(4, 4);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage11.Size = new System.Drawing.Size(1277, 640);
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
            this.listCustomCommands.BackgroundColor = System.Drawing.Color.White;
            this.listCustomCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCustomCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCustomCommands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listCustomCommands.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomCommands.ForeColor = System.Drawing.Color.White;
            this.listCustomCommands.ForegroundColor = System.Drawing.Color.DimGray;
            this.listCustomCommands.FormattingEnabled = true;
            this.listCustomCommands.HorizontalScrollbar = true;
            this.listCustomCommands.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listCustomCommands.ItemHeight = 21;
            this.listCustomCommands.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listCustomCommands.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.listCustomCommands.ItemRounding = 8;
            this.listCustomCommands.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listCustomCommands.Location = new System.Drawing.Point(0, 0);
            this.listCustomCommands.Margin = new System.Windows.Forms.Padding(2);
            this.listCustomCommands.Name = "listCustomCommands";
            this.listCustomCommands.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listCustomCommands.Rounding = new System.Windows.Forms.Padding(8);
            this.listCustomCommands.SelectedForegroundColor = System.Drawing.Color.White;
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
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1277, 640);
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
            this.listSystemVariables.BackgroundColor = System.Drawing.Color.White;
            this.listSystemVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSystemVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSystemVariables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listSystemVariables.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSystemVariables.ForeColor = System.Drawing.Color.White;
            this.listSystemVariables.ForegroundColor = System.Drawing.Color.DimGray;
            this.listSystemVariables.FormattingEnabled = true;
            this.listSystemVariables.HorizontalScrollbar = true;
            this.listSystemVariables.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listSystemVariables.ItemHeight = 21;
            this.listSystemVariables.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listSystemVariables.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.listSystemVariables.ItemRounding = 8;
            this.listSystemVariables.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listSystemVariables.Location = new System.Drawing.Point(0, 0);
            this.listSystemVariables.Margin = new System.Windows.Forms.Padding(2);
            this.listSystemVariables.Name = "listSystemVariables";
            this.listSystemVariables.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listSystemVariables.Rounding = new System.Windows.Forms.Padding(8);
            this.listSystemVariables.SelectedForegroundColor = System.Drawing.Color.White;
            this.listSystemVariables.Size = new System.Drawing.Size(622, 311);
            this.listSystemVariables.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(307, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 27);
            this.button1.TabIndex = 82;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(473, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 27);
            this.button2.TabIndex = 81;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
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
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(473, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 29);
            this.button3.TabIndex = 60;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
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
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1277, 640);
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
            // 
            // btnRestoreFont
            // 
            this.btnRestoreFont.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestoreFont.FlatAppearance.BorderSize = 0;
            this.btnRestoreFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestoreFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestoreFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreFont.ForeColor = System.Drawing.Color.White;
            this.btnRestoreFont.Location = new System.Drawing.Point(286, 445);
            this.btnRestoreFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreFont.Name = "btnRestoreFont";
            this.btnRestoreFont.Size = new System.Drawing.Size(215, 27);
            this.btnRestoreFont.TabIndex = 90;
            this.btnRestoreFont.Text = "Restore default";
            this.btnRestoreFont.UseVisualStyleBackColor = false;
            // 
            // btnSetGlobalFont
            // 
            this.btnSetGlobalFont.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSetGlobalFont.FlatAppearance.BorderSize = 0;
            this.btnSetGlobalFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSetGlobalFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSetGlobalFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetGlobalFont.ForeColor = System.Drawing.Color.White;
            this.btnSetGlobalFont.Location = new System.Drawing.Point(286, 161);
            this.btnSetGlobalFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetGlobalFont.Name = "btnSetGlobalFont";
            this.btnSetGlobalFont.Size = new System.Drawing.Size(215, 27);
            this.btnSetGlobalFont.TabIndex = 89;
            this.btnSetGlobalFont.Text = "Set selected as default";
            this.btnSetGlobalFont.UseVisualStyleBackColor = false;
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
            this.btnRefreshFonts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefreshFonts.FlatAppearance.BorderSize = 0;
            this.btnRefreshFonts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshFonts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFonts.ForeColor = System.Drawing.Color.White;
            this.btnRefreshFonts.Location = new System.Drawing.Point(286, 128);
            this.btnRefreshFonts.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshFonts.Name = "btnRefreshFonts";
            this.btnRefreshFonts.Size = new System.Drawing.Size(215, 27);
            this.btnRefreshFonts.TabIndex = 86;
            this.btnRefreshFonts.Text = "Refresh";
            this.btnRefreshFonts.UseVisualStyleBackColor = false;
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
            this.listFonts.BackgroundColor = System.Drawing.Color.White;
            this.listFonts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listFonts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFonts.ForeColor = System.Drawing.Color.White;
            this.listFonts.ForegroundColor = System.Drawing.Color.DimGray;
            this.listFonts.FormattingEnabled = true;
            this.listFonts.HorizontalScrollbar = true;
            this.listFonts.ItemBackgroundColor = System.Drawing.Color.Empty;
            this.listFonts.ItemHeight = 21;
            this.listFonts.ItemHoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listFonts.ItemHoverForegroundColor = System.Drawing.Color.DimGray;
            this.listFonts.ItemRounding = 8;
            this.listFonts.ItemSelectedBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.listFonts.Location = new System.Drawing.Point(0, 0);
            this.listFonts.Margin = new System.Windows.Forms.Padding(2);
            this.listFonts.Name = "listFonts";
            this.listFonts.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listFonts.Rounding = new System.Windows.Forms.Padding(8);
            this.listFonts.SelectedForegroundColor = System.Drawing.Color.White;
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
            this.optionsTab.Controls.Add(this.cuiLabel2);
            this.optionsTab.Controls.Add(this.pictureBox18);
            this.optionsTab.Controls.Add(this.linkLabel1);
            this.optionsTab.Controls.Add(this.pictureBox16);
            this.optionsTab.Controls.Add(this.label22);
            this.optionsTab.Controls.Add(this.btnDismScan);
            this.optionsTab.Controls.Add(this.btnSfcScannow);
            this.optionsTab.Controls.Add(this.pictureBox15);
            this.optionsTab.Controls.Add(this.pictureBox12);
            this.optionsTab.Controls.Add(this.pictureBox6);
            this.optionsTab.Controls.Add(this.linkLabel7);
            this.optionsTab.Controls.Add(this.pictureBox7);
            this.optionsTab.Controls.Add(this.pictureBox3);
            this.optionsTab.Controls.Add(this.linkLabel3);
            this.optionsTab.Controls.Add(this.pictureBox17);
            this.optionsTab.Controls.Add(this.linkLabel2);
            this.optionsTab.Controls.Add(this.pictureBox14);
            this.optionsTab.Controls.Add(this.pictureBox13);
            this.optionsTab.Controls.Add(this.pictureBox85);
            this.optionsTab.Controls.Add(this.panel9);
            this.optionsTab.Controls.Add(this.linkLabel5);
            this.optionsTab.Controls.Add(this.lblTroubleshoot);
            this.optionsTab.Controls.Add(this.lblUpdating);
            this.optionsTab.Controls.Add(this.l2);
            this.optionsTab.Controls.Add(this.lblTheming);
            this.optionsTab.Controls.Add(this.autoUpdateToggle);
            this.optionsTab.Controls.Add(this.autoStartToggle);
            this.optionsTab.Controls.Add(this.quickAccessToggle);
            this.optionsTab.Controls.Add(this.languagesL);
            this.optionsTab.Controls.Add(this.btnReinforce);
            this.optionsTab.Controls.Add(this.btnOpenConf);
            this.optionsTab.Controls.Add(this.btnViewLog);
            this.optionsTab.Controls.Add(this.btnUpdate);
            this.optionsTab.Controls.Add(this.btnResetConfig);
            this.optionsTab.Controls.Add(this.colorPicker1);
            this.optionsTab.Location = new System.Drawing.Point(4, 40);
            this.optionsTab.Margin = new System.Windows.Forms.Padding(2);
            this.optionsTab.Name = "optionsTab";
            this.optionsTab.Padding = new System.Windows.Forms.Padding(2);
            this.optionsTab.Size = new System.Drawing.Size(1289, 688);
            this.optionsTab.TabIndex = 6;
            this.optionsTab.Text = "Options";
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiLabel2.Content = "This\\ is\\ an\\ unofficial\\ modified\\ version\\.";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.cuiLabel2.Location = new System.Drawing.Point(1037, 661);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(239, 19);
            this.cuiLabel2.TabIndex = 248;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(1251, 480);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 24);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 247;
            this.pictureBox18.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.linkLabel1.ForeColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Location = new System.Drawing.Point(1150, 483);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 19);
            this.linkLabel1.TabIndex = 246;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "dontTheme";
            this.linkLabel1.Text = "Source Code";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(718, 19);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(24, 24);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 245;
            this.pictureBox16.TabStop = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(743, 18);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(302, 25);
            this.label22.TabIndex = 244;
            this.label22.Tag = "dontTheme";
            this.label22.Text = "Windows";
            // 
            // btnDismScan
            // 
            this.btnDismScan.CheckButton = false;
            this.btnDismScan.Checked = false;
            this.btnDismScan.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDismScan.CheckedForeColor = System.Drawing.Color.White;
            this.btnDismScan.CheckedImageTint = System.Drawing.Color.White;
            this.btnDismScan.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDismScan.Content = "DISM";
            this.btnDismScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDismScan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDismScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDismScan.ForeColor = System.Drawing.Color.White;
            this.btnDismScan.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnDismScan.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDismScan.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDismScan.HoverOutline = System.Drawing.Color.Empty;
            this.btnDismScan.Image = ((System.Drawing.Image)(resources.GetObject("btnDismScan.Image")));
            this.btnDismScan.ImageAutoCenter = true;
            this.btnDismScan.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnDismScan.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnDismScan.Location = new System.Drawing.Point(728, 105);
            this.btnDismScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDismScan.Name = "btnDismScan";
            this.btnDismScan.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnDismScan.NormalForeColor = System.Drawing.Color.White;
            this.btnDismScan.NormalImageTint = System.Drawing.Color.White;
            this.btnDismScan.NormalOutline = System.Drawing.Color.Empty;
            this.btnDismScan.OutlineThickness = 1F;
            this.btnDismScan.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnDismScan.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDismScan.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDismScan.PressedOutline = System.Drawing.Color.Empty;
            this.btnDismScan.Rounding = new System.Windows.Forms.Padding(8);
            this.btnDismScan.Size = new System.Drawing.Size(261, 45);
            this.btnDismScan.TabIndex = 243;
            this.btnDismScan.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDismScan.TextOffset = new System.Drawing.Point(1, 0);
            this.btnDismScan.Click += new System.EventHandler(this.btnDismScan_Click);
            // 
            // btnSfcScannow
            // 
            this.btnSfcScannow.CheckButton = false;
            this.btnSfcScannow.Checked = false;
            this.btnSfcScannow.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSfcScannow.CheckedForeColor = System.Drawing.Color.White;
            this.btnSfcScannow.CheckedImageTint = System.Drawing.Color.White;
            this.btnSfcScannow.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSfcScannow.Content = "sfc /scannow";
            this.btnSfcScannow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSfcScannow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSfcScannow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSfcScannow.ForeColor = System.Drawing.Color.White;
            this.btnSfcScannow.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnSfcScannow.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSfcScannow.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSfcScannow.HoverOutline = System.Drawing.Color.Empty;
            this.btnSfcScannow.Image = ((System.Drawing.Image)(resources.GetObject("btnSfcScannow.Image")));
            this.btnSfcScannow.ImageAutoCenter = true;
            this.btnSfcScannow.ImageExpand = new System.Drawing.Point(2, 2);
            this.btnSfcScannow.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnSfcScannow.Location = new System.Drawing.Point(728, 56);
            this.btnSfcScannow.Margin = new System.Windows.Forms.Padding(2);
            this.btnSfcScannow.Name = "btnSfcScannow";
            this.btnSfcScannow.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnSfcScannow.NormalForeColor = System.Drawing.Color.White;
            this.btnSfcScannow.NormalImageTint = System.Drawing.Color.White;
            this.btnSfcScannow.NormalOutline = System.Drawing.Color.Empty;
            this.btnSfcScannow.OutlineThickness = 1F;
            this.btnSfcScannow.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSfcScannow.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSfcScannow.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSfcScannow.PressedOutline = System.Drawing.Color.Empty;
            this.btnSfcScannow.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSfcScannow.Size = new System.Drawing.Size(261, 45);
            this.btnSfcScannow.TabIndex = 242;
            this.btnSfcScannow.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSfcScannow.TextOffset = new System.Drawing.Point(1, 0);
            this.btnSfcScannow.Click += new System.EventHandler(this.btnSfcScannow_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(368, 275);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(24, 24);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 110;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(368, 19);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(24, 24);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 109;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(21, 130);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // linkLabel7
            // 
            this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.linkLabel7.ForeColor = System.Drawing.Color.Gray;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel7.Location = new System.Drawing.Point(1151, 543);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(97, 19);
            this.linkLabel7.TabIndex = 107;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Tag = "dontTheme";
            this.linkLabel7.Text = "FAQs && help";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1251, 540);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 106;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1251, 569);
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
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.Gray;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel3.Location = new System.Drawing.Point(1102, 572);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(146, 19);
            this.linkLabel3.TabIndex = 95;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "dontTheme";
            this.linkLabel3.Text = "Support deadmoon";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(1251, 510);
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
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.linkLabel2.ForeColor = System.Drawing.Color.Gray;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel2.Location = new System.Drawing.Point(1103, 513);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(145, 19);
            this.linkLabel2.TabIndex = 93;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "dontTheme";
            this.linkLabel2.Text = "Original Repository";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(1251, 628);
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
            this.pictureBox13.Location = new System.Drawing.Point(1251, 598);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(24, 24);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 91;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox85
            // 
            this.pictureBox85.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox85.Image")));
            this.pictureBox85.Location = new System.Drawing.Point(21, 321);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(24, 24);
            this.pictureBox85.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox85.TabIndex = 74;
            this.pictureBox85.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.picFlag);
            this.panel9.Controls.Add(this.boxLang);
            this.panel9.Location = new System.Drawing.Point(17, 353);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(348, 53);
            this.panel9.TabIndex = 73;
            // 
            // picFlag
            // 
            this.picFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.picFlag.Content = ((System.Drawing.Image)(resources.GetObject("picFlag.Content")));
            this.picFlag.ImageTint = System.Drawing.Color.White;
            this.picFlag.Location = new System.Drawing.Point(30, 15);
            this.picFlag.Margin = new System.Windows.Forms.Padding(4);
            this.picFlag.Name = "picFlag";
            this.picFlag.OutlineThickness = 1F;
            this.picFlag.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picFlag.Rotation = 0;
            this.picFlag.Rounding = new System.Windows.Forms.Padding(4);
            this.picFlag.Size = new System.Drawing.Size(32, 19);
            this.picFlag.TabIndex = 96;
            // 
            // boxLang
            // 
            this.boxLang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.boxLang.DropDownBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.boxLang.DropDownForeColor = System.Drawing.Color.Silver;
            this.boxLang.ExpandArrowColor = System.Drawing.Color.Gray;
            this.boxLang.ForeColor = System.Drawing.Color.Gainsboro;
            this.boxLang.Items = new string[] {
        "Item 1",
        "Item 2",
        "Item 3"};
            this.boxLang.Location = new System.Drawing.Point(16, 2);
            this.boxLang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxLang.MaxDropDownHeight = 320;
            this.boxLang.Name = "boxLang";
            this.boxLang.NoSelectionText = "None";
            this.boxLang.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.boxLang.OutlineThickness = 1F;
            this.boxLang.Rounding = 8;
            this.boxLang.SelectedIndex = -1;
            this.boxLang.SelectedItem = "";
            this.boxLang.Size = new System.Drawing.Size(261, 45);
            this.boxLang.SortAlphabetically = true;
            this.boxLang.TabIndex = 97;
            this.boxLang.SelectedIndexChanged += new System.EventHandler(this.boxLang_SelectedIndexChanged);
            // 
            // linkLabel5
            // 
            this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.ForeColor = System.Drawing.Color.Gray;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel5.Location = new System.Drawing.Point(1097, 631);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(151, 19);
            this.linkLabel5.TabIndex = 65;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "dontTheme";
            this.linkLabel5.Text = "GNU GPL 3.0 license";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // lblTroubleshoot
            // 
            this.lblTroubleshoot.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroubleshoot.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTroubleshoot.Location = new System.Drawing.Point(393, 18);
            this.lblTroubleshoot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTroubleshoot.Name = "lblTroubleshoot";
            this.lblTroubleshoot.Size = new System.Drawing.Size(273, 25);
            this.lblTroubleshoot.TabIndex = 62;
            this.lblTroubleshoot.Tag = "dontTheme";
            this.lblTroubleshoot.Text = "Troubleshooting";
            // 
            // lblUpdating
            // 
            this.lblUpdating.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdating.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUpdating.Location = new System.Drawing.Point(393, 274);
            this.lblUpdating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(302, 25);
            this.lblUpdating.TabIndex = 61;
            this.lblUpdating.Tag = "dontTheme";
            this.lblUpdating.Text = "Check && update";
            // 
            // l2
            // 
            this.l2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.l2.ForeColor = System.Drawing.Color.Gray;
            this.l2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.l2.LinkColor = System.Drawing.Color.Gainsboro;
            this.l2.Location = new System.Drawing.Point(1127, 601);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(121, 19);
            this.l2.TabIndex = 59;
            this.l2.TabStop = true;
            this.l2.Tag = "dontTheme";
            this.l2.Text = "deadmoon © ∞";
            this.l2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l2_LinkClicked);
            // 
            // lblTheming
            // 
            this.lblTheming.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheming.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTheming.Location = new System.Drawing.Point(46, 128);
            this.lblTheming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheming.Name = "lblTheming";
            this.lblTheming.Size = new System.Drawing.Size(319, 25);
            this.lblTheming.TabIndex = 55;
            this.lblTheming.Tag = "dontTheme";
            this.lblTheming.Text = "Choose your theme";
            this.lblTheming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoUpdateToggle
            // 
            this.autoUpdateToggle.AccessibleName = "Update on launch";
            this.autoUpdateToggle.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.autoUpdateToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoUpdateToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoUpdateToggle.ForeColor = System.Drawing.Color.White;
            this.autoUpdateToggle.LabelText = "Update on launch";
            this.autoUpdateToggle.Location = new System.Drawing.Point(21, 81);
            this.autoUpdateToggle.Margin = new System.Windows.Forms.Padding(6);
            this.autoUpdateToggle.Name = "autoUpdateToggle";
            this.autoUpdateToggle.Size = new System.Drawing.Size(344, 24);
            this.autoUpdateToggle.TabIndex = 105;
            this.autoUpdateToggle.Tag = "themeable";
            this.autoUpdateToggle.ToggleChecked = false;
            this.autoUpdateToggle.ToggleClicked += new System.EventHandler(this.autoUpdateToggle_ToggleClicked);
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
            this.autoStartToggle.Size = new System.Drawing.Size(344, 24);
            this.autoStartToggle.TabIndex = 98;
            this.autoStartToggle.Tag = "themeable";
            this.autoStartToggle.ToggleChecked = false;
            this.autoStartToggle.ToggleClicked += new System.EventHandler(this.autoStartToggle_ToggleClicked);
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
            this.quickAccessToggle.Size = new System.Drawing.Size(344, 24);
            this.quickAccessToggle.TabIndex = 88;
            this.quickAccessToggle.Tag = "themeable";
            this.quickAccessToggle.ToggleChecked = false;
            this.quickAccessToggle.ToggleClicked += new System.EventHandler(this.quickAccessToggle_ToggleClicked);
            // 
            // languagesL
            // 
            this.languagesL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesL.ForeColor = System.Drawing.Color.Gainsboro;
            this.languagesL.Location = new System.Drawing.Point(46, 317);
            this.languagesL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.languagesL.Name = "languagesL";
            this.languagesL.Size = new System.Drawing.Size(319, 28);
            this.languagesL.TabIndex = 71;
            this.languagesL.Tag = "dontTheme";
            this.languagesL.Text = "Choose language";
            this.languagesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReinforce
            // 
            this.btnReinforce.CheckButton = false;
            this.btnReinforce.Checked = false;
            this.btnReinforce.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnReinforce.CheckedForeColor = System.Drawing.Color.White;
            this.btnReinforce.CheckedImageTint = System.Drawing.Color.White;
            this.btnReinforce.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnReinforce.Content = "Reinforce policies";
            this.btnReinforce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinforce.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReinforce.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnReinforce.ForeColor = System.Drawing.Color.White;
            this.btnReinforce.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnReinforce.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReinforce.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReinforce.HoverOutline = System.Drawing.Color.Empty;
            this.btnReinforce.Image = ((System.Drawing.Image)(resources.GetObject("btnReinforce.Image")));
            this.btnReinforce.ImageAutoCenter = true;
            this.btnReinforce.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnReinforce.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnReinforce.Location = new System.Drawing.Point(380, 104);
            this.btnReinforce.Margin = new System.Windows.Forms.Padding(2);
            this.btnReinforce.Name = "btnReinforce";
            this.btnReinforce.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnReinforce.NormalForeColor = System.Drawing.Color.White;
            this.btnReinforce.NormalImageTint = System.Drawing.Color.White;
            this.btnReinforce.NormalOutline = System.Drawing.Color.Empty;
            this.btnReinforce.OutlineThickness = 1F;
            this.btnReinforce.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnReinforce.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReinforce.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReinforce.PressedOutline = System.Drawing.Color.Empty;
            this.btnReinforce.Rounding = new System.Windows.Forms.Padding(8);
            this.btnReinforce.Size = new System.Drawing.Size(261, 45);
            this.btnReinforce.TabIndex = 103;
            this.btnReinforce.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReinforce.TextOffset = new System.Drawing.Point(1, 0);
            this.btnReinforce.Click += new System.EventHandler(this.btnReinforce_Click);
            // 
            // btnOpenConf
            // 
            this.btnOpenConf.CheckButton = false;
            this.btnOpenConf.Checked = false;
            this.btnOpenConf.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnOpenConf.CheckedForeColor = System.Drawing.Color.White;
            this.btnOpenConf.CheckedImageTint = System.Drawing.Color.White;
            this.btnOpenConf.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnOpenConf.Content = "Show configuration folder";
            this.btnOpenConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenConf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenConf.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnOpenConf.ForeColor = System.Drawing.Color.White;
            this.btnOpenConf.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenConf.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenConf.HoverOutline = System.Drawing.Color.Empty;
            this.btnOpenConf.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenConf.Image")));
            this.btnOpenConf.ImageAutoCenter = true;
            this.btnOpenConf.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnOpenConf.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnOpenConf.Location = new System.Drawing.Point(380, 202);
            this.btnOpenConf.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenConf.Name = "btnOpenConf";
            this.btnOpenConf.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.NormalForeColor = System.Drawing.Color.White;
            this.btnOpenConf.NormalImageTint = System.Drawing.Color.White;
            this.btnOpenConf.NormalOutline = System.Drawing.Color.Empty;
            this.btnOpenConf.OutlineThickness = 1F;
            this.btnOpenConf.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnOpenConf.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenConf.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenConf.PressedOutline = System.Drawing.Color.Empty;
            this.btnOpenConf.Rounding = new System.Windows.Forms.Padding(8);
            this.btnOpenConf.Size = new System.Drawing.Size(261, 45);
            this.btnOpenConf.TabIndex = 63;
            this.btnOpenConf.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOpenConf.TextOffset = new System.Drawing.Point(1, 0);
            this.btnOpenConf.Click += new System.EventHandler(this.btnOpenConf_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.CheckButton = false;
            this.btnViewLog.Checked = false;
            this.btnViewLog.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnViewLog.CheckedForeColor = System.Drawing.Color.White;
            this.btnViewLog.CheckedImageTint = System.Drawing.Color.White;
            this.btnViewLog.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnViewLog.Content = "View errors";
            this.btnViewLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewLog.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnViewLog.ForeColor = System.Drawing.Color.White;
            this.btnViewLog.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewLog.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewLog.HoverOutline = System.Drawing.Color.Empty;
            this.btnViewLog.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLog.Image")));
            this.btnViewLog.ImageAutoCenter = true;
            this.btnViewLog.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnViewLog.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnViewLog.Location = new System.Drawing.Point(380, 153);
            this.btnViewLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.NormalForeColor = System.Drawing.Color.White;
            this.btnViewLog.NormalImageTint = System.Drawing.Color.White;
            this.btnViewLog.NormalOutline = System.Drawing.Color.Empty;
            this.btnViewLog.OutlineThickness = 1F;
            this.btnViewLog.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnViewLog.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewLog.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewLog.PressedOutline = System.Drawing.Color.Empty;
            this.btnViewLog.Rounding = new System.Windows.Forms.Padding(8);
            this.btnViewLog.Size = new System.Drawing.Size(261, 45);
            this.btnViewLog.TabIndex = 60;
            this.btnViewLog.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnViewLog.TextOffset = new System.Drawing.Point(1, 0);
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckButton = false;
            this.btnUpdate.Checked = false;
            this.btnUpdate.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImageTint = System.Drawing.Color.White;
            this.btnUpdate.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUpdate.Content = "Check for update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverOutline = System.Drawing.Color.Empty;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAutoCenter = true;
            this.btnUpdate.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.Location = new System.Drawing.Point(380, 308);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.NormalForeColor = System.Drawing.Color.White;
            this.btnUpdate.NormalImageTint = System.Drawing.Color.White;
            this.btnUpdate.NormalOutline = System.Drawing.Color.Empty;
            this.btnUpdate.OutlineThickness = 1F;
            this.btnUpdate.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.PressedOutline = System.Drawing.Color.Empty;
            this.btnUpdate.Rounding = new System.Windows.Forms.Padding(8);
            this.btnUpdate.Size = new System.Drawing.Size(261, 45);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.TextOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.CheckButton = false;
            this.btnResetConfig.Checked = false;
            this.btnResetConfig.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnResetConfig.CheckedForeColor = System.Drawing.Color.White;
            this.btnResetConfig.CheckedImageTint = System.Drawing.Color.White;
            this.btnResetConfig.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnResetConfig.Content = "Repair";
            this.btnResetConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetConfig.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnResetConfig.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnResetConfig.ForeColor = System.Drawing.Color.White;
            this.btnResetConfig.HoverBackground = System.Drawing.Color.DodgerBlue;
            this.btnResetConfig.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetConfig.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetConfig.HoverOutline = System.Drawing.Color.Empty;
            this.btnResetConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnResetConfig.Image")));
            this.btnResetConfig.ImageAutoCenter = true;
            this.btnResetConfig.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnResetConfig.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnResetConfig.Location = new System.Drawing.Point(380, 55);
            this.btnResetConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.NormalBackground = System.Drawing.Color.DodgerBlue;
            this.btnResetConfig.NormalForeColor = System.Drawing.Color.White;
            this.btnResetConfig.NormalImageTint = System.Drawing.Color.White;
            this.btnResetConfig.NormalOutline = System.Drawing.Color.Empty;
            this.btnResetConfig.OutlineThickness = 1F;
            this.btnResetConfig.PressedBackground = System.Drawing.Color.DodgerBlue;
            this.btnResetConfig.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetConfig.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetConfig.PressedOutline = System.Drawing.Color.Empty;
            this.btnResetConfig.Rounding = new System.Windows.Forms.Padding(8);
            this.btnResetConfig.Size = new System.Drawing.Size(261, 45);
            this.btnResetConfig.TabIndex = 56;
            this.btnResetConfig.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnResetConfig.TextOffset = new System.Drawing.Point(1, 0);
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // colorPicker1
            // 
            this.colorPicker1.Content = System.Drawing.Color.DodgerBlue;
            this.colorPicker1.Location = new System.Drawing.Point(31, 160);
            this.colorPicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorPicker1.MinimumSize = new System.Drawing.Size(38, 38);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(139, 136);
            this.colorPicker1.TabIndex = 97;
            this.colorPicker1.WheelThickness = 16;
            this.colorPicker1.ContentChanged += new System.EventHandler(this.ContentChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1299, 801);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.picRestartNeeded);
            this.Controls.Add(this.bpanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.restartAndApply);
            this.Controls.Add(this.picLab);
            this.Controls.Add(this.picUpdate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1298, 840);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimizer Modded";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.bpanel.ResumeLayout(false);
            this.indiciumMenu.ResumeLayout(false);
            this.launcherMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestartNeeded)).EndInit();
            this.panel17.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.universalTab.ResumeLayout(false);
            this.universalTab.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.windows10Tab.ResumeLayout(false);
            this.windows10Tab.PerformLayout();
            this.panelWin11Tweaks.ResumeLayout(false);
            this.panelWin11Tweaks.PerformLayout();
            this.advancedTab.ResumeLayout(false);
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
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel bpanel;
        private Optimizer.MoonTabs tabCollection;
        private System.Windows.Forms.TabPage universalTab;
        private System.Windows.Forms.TabPage windows10Tab;
        private System.Windows.Forms.TabPage cleanerTab;
        private System.Windows.Forms.TabPage startupTab;
        private System.Windows.Forms.Label startupTitle;
        private System.Windows.Forms.Button removeStartupItemB;
        private System.Windows.Forms.TabPage registryFixerTab;
        private System.Windows.Forms.Label registryTitle;
        private CuoreUI.Controls.cuiButton regFixB;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiCheckbox checkRegistryEditor;
        private CuoreUI.Controls.cuiCheckbox checkEnableAll;
        private CuoreUI.Controls.cuiCheckbox checkContextMenu;
        private CuoreUI.Controls.cuiCheckbox checkTaskManager;
        private CuoreUI.Controls.cuiCheckbox checkCommandPrompt;
        private CuoreUI.Controls.cuiCheckbox checkFirewall;
        private CuoreUI.Controls.cuiCheckbox checkRunDialog;
        private CuoreUI.Controls.cuiCheckbox checkFolderOptions;
        private CuoreUI.Controls.cuiCheckbox checkControlPanel;
        private CuoreUI.Controls.cuiCheckbox checkRestartExplorer;
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
        private System.Windows.Forms.LinkLabel linkAdvancedEdit;
        private System.Windows.Forms.LinkLabel linkRestoreDefault;
        private CuoreUI.Controls.cuiListbox listHostEntries;
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
        private CuoreUI.Controls.cuiListbox listDesktopItems;
        private System.Windows.Forms.Label removeIntegratorItemsL;
        private System.Windows.Forms.Button refreshIIB;
        private System.Windows.Forms.Button removeDIB;
        private System.Windows.Forms.Button removeAllIIB;
        private CuoreUI.Controls.cuiGroupBox itemtype;
        private MoonRadio radioCommand;
        private MoonRadio radioProgram;
        private MoonRadio radioFile;
        private MoonRadio radioFolder;
        private MoonRadio radioLink;
        private System.Windows.Forms.Label addItemL;
        private CuoreUI.Controls.cuiGroupBox icontoaddgroup;
        private CuoreUI.Controls.cuiCheckbox checkDefaultIcon;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private CuoreUI.Controls.cuiGroupBox itemtoaddgroup;
        private System.Windows.Forms.Button btnBrowseItem;
        private System.Windows.Forms.TextBox txtItem;
        private CuoreUI.Controls.cuiGroupBox security;
        private CuoreUI.Controls.cuiCheckbox checkShift;
        private CuoreUI.Controls.cuiGroupBox itemposition;
        private MoonRadio radioTop;
        private MoonRadio radioMiddle;
        private MoonRadio radioBottom;
        private CuoreUI.Controls.cuiGroupBox itemnamegroup;
        private System.Windows.Forms.TextBox txtItemName;
        private CuoreUI.Controls.cuiButton btnAddItem;
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
        private CuoreUI.Controls.cuiListbox listCustomCommands;
        private System.Windows.Forms.Label removeCCL;
        private System.Windows.Forms.Button removeCCB;
        private System.Windows.Forms.Button refreshCCB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TabPage modernAppsTab;
        private System.Windows.Forms.Label txtModernAppsTitle;
        private CuoreUI.Controls.cuiButton uninstallModernAppsButton;
        private CuoreUI.Controls.cuiButton refreshModernAppsButton;
        private CuoreUI.Controls.cuiCheckbox chkSelectAllModernApps;
        private CuoreUI.Controls.cuiButton btnResetConfig;
        private CuoreUI.Controls.cuiButton btnUpdate;
        private CuoreUI.Controls.cuiCheckbox chkReadOnly;
        private System.Windows.Forms.Label lblLock;
        private CuoreUI.Controls.cuiCheckbox chkBlock;
        private System.Windows.Forms.TabPage appsTab;
        private System.Windows.Forms.Button btnDownloadApps;
        private System.Windows.Forms.Label appsTitle;
        private System.Windows.Forms.Label setDownDirLbl;
        private CuoreUI.Controls.cuiTextBox txtDownloadFolderTextBox;
        private CuoreUI.Controls.cuiButton txtDownloadFolderButton;
        private System.Windows.Forms.Label txtDownloadStatus;
        private System.Windows.Forms.Label bitPref;
        private System.Windows.Forms.Button goToDownloadsB;
        private System.Windows.Forms.LinkLabel linkWarnings;
        private CuoreUI.Controls.cuiCheckbox cAutoInstall;
        private CuoreUI.Controls.cuiCheckbox chkOnlyRemovable;
        private CuoreUI.Controls.cuiProgressBarHorizontal progressDownloader;
        private System.Windows.Forms.Button btnGetFeed;
        private System.Windows.Forms.Panel panelCommonApps;
        private System.Windows.Forms.LinkLabel l2;
        private System.Windows.Forms.Panel groupSystemTools;
        private CuoreUI.Controls.cuiButton btnViewLog;
        private System.Windows.Forms.Label lblTroubleshoot;
        private System.Windows.Forms.Label lblUpdating;
        private CuoreUI.Controls.cuiButton btnOpenConf;
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
        private System.Windows.Forms.Panel panel10;
        private TextBox txtBackupTitle;
        private Label lblBackupTitle;
        private Label languagesL;
        private PictureBox pictureBox85;
        private Panel panel9;
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
        private ToggleCard tpmSw;
        private ToggleCard xboxSw;
        private ToggleCard inkSw;
        private ToggleCard spellSw;
        private ToggleCard longPathsSw;
        private ToggleCard peopleSw;
        private ToggleCard oldExplorerSw;
        private ToggleCard adsSw;
        private ToggleCard storeUpdatesSw;
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
        private TabPage indiciumTab;
        private MoonTree specsTree;
        private Panel panel12;
        private Panel panel11;
        private ToggleCard hwDetailed;
        private ToolStripMenuItem trayHW;
        private ContextMenuStrip indiciumMenu;
        private ToolStripMenuItem toolHWCopy;
        private ToolStripMenuItem toolHWGoogle;
        private ToolStripMenuItem toolHWDuck;
        private ToolStripSeparator toolStripSeparator2;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox17;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private CuoreUI.Controls.cuiCheckbox edgeSession;
        private CuoreUI.Controls.cuiCheckbox edgeHistory;
        private Label lblFootprint;
        private CuoreUI.Controls.cuiCheckbox edgeCookies;
        private Label lblPretext;
        private CuoreUI.Controls.cuiCheckbox edgeCache;
        private CuoreUI.Controls.cuiCheckbox IECache;
        private CuoreUI.Controls.cuiCheckbox firefoxHistory;
        private CuoreUI.Controls.cuiCheckbox firefoxCookies;
        private CuoreUI.Controls.cuiCheckbox firefoxCache;
        private CuoreUI.Controls.cuiCheckbox chromePws;
        private CuoreUI.Controls.cuiCheckbox chromeSession;
        private CuoreUI.Controls.cuiCheckbox chromeHistory;
        private CuoreUI.Controls.cuiCheckbox chromeCookies;
        private CuoreUI.Controls.cuiCheckbox chromeCache;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private CuoreUI.Controls.cuiCheckbox checkErrorReports;
        private CuoreUI.Controls.cuiCheckbox checkTemp;
        private CuoreUI.Controls.cuiCheckbox checkBin;
        private CuoreUI.Controls.cuiCheckbox checkMiniDumps;
        private PictureBox pictureBox2;
        private Label label8;
        private Panel panel13;
        private Panel panel14;
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
        private CuoreUI.Controls.cuiCheckbox bravePasswords;
        private CuoreUI.Controls.cuiCheckbox braveSession;
        private CuoreUI.Controls.cuiCheckbox braveHistory;
        private CuoreUI.Controls.cuiCheckbox braveCookies;
        private CuoreUI.Controls.cuiCheckbox braveCache;
        private ToolStripMenuItem trayUnlocker;
        private Panel panelUwp;
        private ToggleCard stickersSw;
        private TabPage tabPage1;
        private Panel panel7;
        private CuoreUI.Controls.cuiListbox listPingResults;
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
        private CuoreUI.Controls.cuiColorPickerWheel colorPicker1;
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
        private System.Windows.Forms.Button backupStartupB;
        private System.Windows.Forms.Button restoreStartupB;
        private System.Windows.Forms.Button doBackup;
        private System.Windows.Forms.Button cancelBackup;
        private CuoreUI.Controls.cuiButton btnCopyHW;
        private CuoreUI.Controls.cuiButton btnSaveHW;
        private System.Windows.Forms.Button cleanDriveB;
        private System.Windows.Forms.Button analyzeDriveB;
        private System.Windows.Forms.Button btnWinClean;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button copyB;
        private System.Windows.Forms.Button copyIPB;
        private System.Windows.Forms.Button btnShodan;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnOpenNetwork;
        private System.Windows.Forms.Button flushCacheB;
        private CuoreUI.Controls.cuiButton btnRestoreUwp;
        private CuoreUI.Controls.cuiButton btnRestartDisableDefender;
        private CuoreUI.Controls.cuiButton btnRestart;
        private CuoreUI.Controls.cuiButton btnRestartSafe;
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
        private CuoreUI.Controls.cuiCheckbox chkIncludeWww;
        private TabPage tabPage3;
        private Label fontSetTitle;
        private Panel panel8;
        private CuoreUI.Controls.cuiListbox listFonts;
        private Button btnRefreshFonts;
        private Label lblCurrentFont;
        private Label label11;
        private Button btnRestoreFont;
        private Button btnSetGlobalFont;
        private TextBox txtSearchFonts;
        private Label lblFontsCount;
        private Label lblFontsNumber;
        private CuoreUI.Controls.cuiCheckbox chkAllNics;
        private CuoreUI.Controls.cuiCheckbox chkCustomDns;
        private TextBox txtDns6B;
        private TextBox txtDns6A;
        private Label label12;
        private TextBox txtDns4B;
        private TextBox txtDns4A;
        private Label label10;
        private Button btnSetDns;
        private CuoreUI.Controls.cuiButton btnReinforce;
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
        private CuoreUI.Controls.cuiListbox listSystemVariables;
        private Button button1;
        private Button button2;
        private Label label21;
        private Button button3;
        private TextBox txtSysVar;
        private Label label23;
        private Label label24;
        private ToggleCard regBackupSw;
        private Label label2;
        private Label txtVersion;
        private PictureBox picUpdate;
        private PictureBox picLab;
        private PictureBox picRestartNeeded;
        private Label restartAndApply;
        private CuoreUI.Controls.cuiPictureBox pictureBox1;
        private Panel panel16;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox picFlag;
        private CuoreUI.Controls.cuiComboBox boxLang;
        private PictureBox pictureBox6;
        private Label lblTheming;
        private PictureBox pictureBox15;
        private PictureBox pictureBox12;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private CuoreUI.Controls.cuiComboBox boxAdapter;
        private CuoreUI.Controls.cuiComboBox boxDNS;
        private PictureBox pictureBox16;
        private Label label22;
        private CuoreUI.Controls.cuiButton btnDismScan;
        private CuoreUI.Controls.cuiButton btnSfcScannow;
        private PictureBox pictureBox18;
        private LinkLabel linkLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton hostsLocateBtn;
        private Panel panel17;
    }
}

