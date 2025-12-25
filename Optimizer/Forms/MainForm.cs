using CuoreUI;
using CuoreUI.Controls;
using Newtonsoft.Json;
using Optimizer.Forms;
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
        List<BackupStartupItem> _backupItems = new List<BackupStartupItem>();

        List<string> _hostsEntries = new List<string>();
        List<string> _customCommands = new List<string>();
        List<string> _desktopItems = new List<string>();
        List<KeyValuePair<string, string>> _modernApps = new List<KeyValuePair<string, string>>();

        bool _trayMenu = false;

        List<PingReply> _pingResults;
        string _shodanIP = string.Empty;
        PingReply tmpReply;

        int _tabHeaderHeightMargin = 6;
        int _tabHeaderWidthMargin = 6;

        DesktopItemType _desktopItemType = DesktopItemType.Program;
        DesktopTypePosition _desktopItemPosition = DesktopTypePosition.Top;

        public List<AppInfo> AppsFromFeed = new List<AppInfo>();

        /* modify these when forking */
        readonly string _feedLink = "https://raw.githubusercontent.com/owtysm2/optimizer/master/feed.json";
        readonly string _feedImages = "https://raw.githubusercontent.com/owtysm2/optimizer/master/images/feed.zip";
        readonly string _moddedGithubProjectLink = "https://github.com/owtysm2/optimizer";
        /* modify these when forking */

        readonly string _licenseLink = "https://www.gnu.org/licenses/gpl-3.0.en.html";
        readonly string _originalGithubProjectLink = "https://github.com/hellzerg/optimizer";

        readonly string _paypalSupportLink = "https://www.paypal.com/paypalme/supportoptimizer";

        readonly string _latestVersionLink = "https://raw.githubusercontent.com/owtysm2/optimizer/master/version.txt";
        readonly string _faqSectionLink = "https://github.com/owtysm2/optimizer/blob/master/FAQ.md";

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
        List<string> _systemVariables = new List<string>();

        ColorOverrider _colorOverrider;

        List<TreeNode> _hwDetailed;
        TreeNode[] _hwSummarized;

        bool _cleanSelectAll = true;
        List<string> _cleanPreviewList;

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
            return string.Format("https://github.com/owtysm2/optimizer/releases/download/{0}/Optimizer.exe", latestVersion);
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

                if (latestVersionFloat > Program.CurrentVersionFloat)
                {
                    if (silentCheck)
                    {
                        picUpdate.Visible = true;
                        return;
                    }

                    /* i dont' want to post changelogs, so the changelog parameter is empty */
                    //                                                         ↓↓↓
                    _updateForm = new UpdateForm(_newVersionMessage, true, string.Empty, latestVersion);
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
                else if (latestVersionFloat == Program.CurrentVersionFloat)
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
                performanceSw.LabelTag = OptionsHelper.TranslationList["performanceTip"].ToString();
                noMenuDelaySw.LabelTag = OptionsHelper.TranslationList["noMenuDelaySw"].ToString();
                allTrayIconsSw.LabelTag = OptionsHelper.TranslationList["allTrayIconsSw"].ToString();
                networkSw.LabelTag = OptionsHelper.TranslationList["networkTip"].ToString();
                defenderSw.LabelTag = OptionsHelper.TranslationList["defenderTip"].ToString();
                smartScreenSw.LabelTag = OptionsHelper.TranslationList["smartScreenTip"].ToString();
                systemRestoreSw.LabelTag = OptionsHelper.TranslationList["systemRestoreTip"].ToString();
                reportingSw.LabelTag = OptionsHelper.TranslationList["reportingTip"].ToString();
                telemetryTasksSw.LabelTag = OptionsHelper.TranslationList["telemetryTasksTip"].ToString();
                officeTelemetrySw.LabelTag = OptionsHelper.TranslationList["officeTelemetryTip"].ToString();
                printSw.LabelTag = OptionsHelper.TranslationList["printTip"].ToString();
                faxSw.LabelTag = OptionsHelper.TranslationList["faxTip"].ToString();
                mediaSharingSw.LabelTag = OptionsHelper.TranslationList["mediaSharingTip"].ToString();
                stickySw.LabelTag = OptionsHelper.TranslationList["stickyTip"].ToString();
                homegroupSw.LabelTag = OptionsHelper.TranslationList["homegroupTip"].ToString();
                superfetchSw.LabelTag = OptionsHelper.TranslationList["superfetchTip"].ToString();
                compatSw.LabelTag = OptionsHelper.TranslationList["compatTip"].ToString();
                disableOneDriveSw.LabelTag = OptionsHelper.TranslationList["disableOneDriveTip"].ToString();
                oldExplorerSw.LabelTag = OptionsHelper.TranslationList["oldExplorerTip"].ToString();
                adsSw.LabelTag = OptionsHelper.TranslationList["adsTip"].ToString();
                uODSw.LabelTag = OptionsHelper.TranslationList["uODTip"].ToString();
                peopleSw.LabelTag = OptionsHelper.TranslationList["peopleTip"].ToString();
                longPathsSw.LabelTag = OptionsHelper.TranslationList["longPathsTip"].ToString();
                inkSw.LabelTag = OptionsHelper.TranslationList["inkTip"].ToString();
                spellSw.LabelTag = OptionsHelper.TranslationList["spellTip"].ToString();
                xboxSw.LabelTag = OptionsHelper.TranslationList["xboxTip"].ToString();
                autoUpdatesSw.LabelTag = OptionsHelper.TranslationList["autoUpdatesTip"].ToString();
                driversSw.LabelTag = OptionsHelper.TranslationList["driversTip"].ToString();
                telemetryServicesSw.LabelTag = OptionsHelper.TranslationList["telemetryServicesTip"].ToString();
                privacySw.LabelTag = OptionsHelper.TranslationList["privacyTip"].ToString();
                ccSw.LabelTag = OptionsHelper.TranslationList["ccTip"].ToString();
                cortanaSw.LabelTag = OptionsHelper.TranslationList["cortanaTip"].ToString();
                edgeAiSw.LabelTag = OptionsHelper.TranslationList["edgeAiTip"].ToString();
                edgeTelemetrySw.LabelTag = OptionsHelper.TranslationList["edgeTelemetryTip"].ToString();
                sensorSw.LabelTag = OptionsHelper.TranslationList["sensorTip"].ToString();
                castSw.LabelTag = OptionsHelper.TranslationList["castTip"].ToString();
                gameBarSw.LabelTag = OptionsHelper.TranslationList["gameBarTip"].ToString();
                insiderSw.LabelTag = OptionsHelper.TranslationList["insiderTip"].ToString();
                storeUpdatesSw.LabelTag = OptionsHelper.TranslationList["storeUpdatesTip"].ToString();
                tpmSw.LabelTag = OptionsHelper.TranslationList["tpmTip"].ToString();
                leftTaskbarSw.LabelTag = OptionsHelper.TranslationList["leftTaskbarTip"].ToString();
                snapAssistSw.LabelTag = OptionsHelper.TranslationList["snapAssistTip"].ToString();
                widgetsSw.LabelTag = OptionsHelper.TranslationList["widgetsTip"].ToString();
                chatSw.LabelTag = OptionsHelper.TranslationList["chatTip"].ToString();
                stickersSw.LabelTag = OptionsHelper.TranslationList["stickersTip"].ToString();
                classicContextSw.LabelTag = OptionsHelper.TranslationList["classicContextTip"].ToString();
                picUpdate.Tag = OptionsHelper.TranslationList["linkUpdate"].ToString() + "!";
                picLab.Tag = OptionsHelper.TranslationList["lblLab"].ToString();
                picRestartNeeded.Tag = OptionsHelper.TranslationList["restartAndApply"].ToString();
                ffTelemetrySw.LabelTag = OptionsHelper.TranslationList["ffTelemetryTip"].ToString();
                vsSw.LabelTag = OptionsHelper.TranslationList["vsTip"].ToString();
                chromeTelemetrySw.LabelTag = OptionsHelper.TranslationList["chromeTelemetryTip"].ToString();
                gameModeSw.LabelTag = OptionsHelper.TranslationList["gameModeTip"].ToString();
                compactModeSw.LabelTag = OptionsHelper.TranslationList["compactModeTip"].ToString();
                hibernateSw.LabelTag = OptionsHelper.TranslationList["hibernateTip"].ToString();
                winSearchSw.LabelTag = OptionsHelper.TranslationList["winSearchTip"].ToString();
                smb1Sw.LabelTag = OptionsHelper.TranslationList["smbTip"].ToString().Replace("{v}", "v1");
                smb2Sw.LabelTag = OptionsHelper.TranslationList["smbTip"].ToString().Replace("{v}", "v2");
                ntfsStampSw.LabelTag = OptionsHelper.TranslationList["ntfsStampTip"].ToString();
                nvidiaTelemetrySw.LabelTag = OptionsHelper.TranslationList["nvidiaTelemetrySw"].ToString();
                vbsSw.LabelTag = OptionsHelper.TranslationList["vbsTip"].ToString();
                hpetSw.LabelTag = OptionsHelper.TranslationList["hpetSw"].ToString();
                loginVerboseSw.LabelTag = OptionsHelper.TranslationList["loginVerboseSw"].ToString();
                classicPhotoViewerSw.LabelTag = OptionsHelper.TranslationList["classicPhotoViewerSw"].ToString();
                copilotSw.LabelTag = OptionsHelper.TranslationList["copilotTip"].ToString();
                hideWeatherSw.LabelTag = OptionsHelper.TranslationList["hideWeatherSw"].ToString();
                modernStandbySw.LabelTag = OptionsHelper.TranslationList["modernStandbySw"].ToString();
                hideSearchSw.LabelTag = OptionsHelper.TranslationList["hideSearchSw"].ToString();
                newsInterestsSw.LabelTag = OptionsHelper.TranslationList["newsInterestsSw"].ToString();
                enableUtcSw.LabelTag = OptionsHelper.TranslationList["enableUtcSw"].ToString();
                regBackupSw.LabelTag = OptionsHelper.TranslationList["regBackupSw"].ToString();
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
        public MainForm(SplashForm _splashForm, bool? disableIndicium = null, bool? disableHostsEditor = null, bool? disableCommonApps = null, bool? disableUWPApps = null, bool? disableStartups = null, bool? disableCleaner = null, bool? disableIntegrator = null, bool? disablePinger = null)
        {
            InitializeComponent();

            // makes the things behind preset panel look nicer when its opened
            // (this is not a "woah rounding in winforms, yay!"-type trick, but rather just a visual QoL fix)
            // (kinda related): 1 px is left below intentionally, for better contrast
            panel18.Left = cuiButton1.Left + ((cuiButton1.Width - panel18.Width) / 2);
            panel18.Top = cuiButton1.Bottom + 1;
            panel18.Height = 12 + (44 * (cuiPanel2.Controls.Count - 1));
            panel18.Region = Region.FromHrgn(Program.CreateRoundRectRgn(1, 1, panel18.Width, panel18.Height, 13, 13));

            if (OptionsHelper.CurrentOptions.UpdateOnLaunch)
            {
                if (!Program.EXPERIMENTAL_BUILD && PingerHelper.IsInternetAvailable())
                {
                    CheckForUpdate(true);
                }
            }

            _splashForm.progressTracker.TasksProgress++;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            CheckForIllegalCrossThreadCalls = false;

            boxLang.Items = (new string[]
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
            pictureBox1.ImageTint = OptionsHelper.CurrentOptions.Theme;

            if (colorPicker1.InvokeRequired)
            {
                colorPicker1.Invoke((Action)(() =>
                {
                    colorPicker1.Content = OptionsHelper.CurrentOptions.Theme;
                }));
            }
            else
            {
                colorPicker1.Content = OptionsHelper.CurrentOptions.Theme;
            }

            launcherMenu.Renderer = new MoonMenuRenderer();
            indiciumMenu.Renderer = new MoonMenuRenderer();

            progressDownloader.Foreground = OptionsHelper.ForegroundColor;
            //progressDownloader.ForeColor = OptionsHelper.ForegroundAccentColor;

            // quick access
            _trayMenu = OptionsHelper.CurrentOptions.EnableTray;
            quickAccessToggle.ToggleChecked = OptionsHelper.CurrentOptions.EnableTray;
            launcherIcon.Visible = OptionsHelper.CurrentOptions.EnableTray;
            autoStartToggle.ToggleChecked = OptionsHelper.CurrentOptions.AutoStart;
            autoUpdateToggle.ToggleChecked = OptionsHelper.CurrentOptions.UpdateOnLaunch;

            // fix SSL/TLS error when contacting internet
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // initial states
            checkDefaultIcon.Checked = true;
            radioProgram.Checked = true;
            radioTop.Checked = true;
            disableOneDriveSw.Visible = false;
            cuiComboBox1.SelectedItem = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";

            // Windows version, architecture, .NET Framework
            //txtVersion.Text = txtVersion.Text.Replace("{OS}", Utilities.GetOS());
            //txtVersion.Text = txtVersion.Text.Replace("{BIT}", Utilities.GetBitness());
            //txtVersion.Text = txtVersion.Text.Replace("{NETFW}", $".NET Framework {Utilities.GetNETFramework()}");

            // system color overriding
            _colorOverrider = new ColorOverrider();
            _colorOverrider.SetColor(KnownColor.Highlight, Color.FromArgb(50, 50, 50).ToArgb());
            _colorOverrider.SetColor(KnownColor.HighlightText, Color.White.ToArgb());

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
                panel16.Top -= defenderSw.Height + 4;

                vbsSw.Visible = false;
                this.Controls.Remove(panelWin11Tweaks);

                if (!_disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                //txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
            {
                LoadUniversalToggleStates();
                LoadWindows10ToggleStates();
                LoadWindows11ToggleStates();

                windows10Tab.Text = "Windows 11";

                defenderSw.Visible = false;
                panel16.Top -= defenderSw.Height + 4;

                vbsSw.Visible = true;
                panelWin11Tweaks.Visible = true;

                if (!_disableUWPApps)
                {
                    chkOnlyRemovable.Checked = true;
                }
                else
                {
                    tabCollection.TabPages.Remove(modernAppsTab);
                }

                //txtOS.Text += string.Format(" ({0})", Utilities.GetWindows10Build());
            }

            _splashForm.progressTracker.TasksProgress++;

            _columnSorter = new ListViewColumnSorter();
            listStartupItems.ListViewItemSorter = _columnSorter;

            specsTree.ImageList = GetHardwareImagesAsImageList();

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
                LoadSystemVariables();
            }
            else
            {
                tabCollection.TabPages.Remove(integratorTab);
            }

            _splashForm.progressTracker.TasksProgress++;

            // APPS DOWNLOADER
            if (!_disableAppsTool)
            {
                GetFeed();
                txtDownloadFolderTextBox.Enabled = false;
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

            _splashForm.progressTracker.TasksProgress++;

            // PINGER
            if (!_disablePinger)
            {
                List<string> boxDnsItemsTemp = boxDNS.Items.ToList();
                boxDnsItemsTemp.AddRange(PingerHelper.DNSOptions);
                boxDNS.Items = boxDnsItemsTemp.ToArray();
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

            if (Program.EXPERIMENTAL_BUILD)
            {
                btnUpdate.Enabled = false;
                btnUpdate.NormalBackground = Color.FromArgb(32, 32, 32);
                btnUpdate.NormalForeColor = Color.FromArgb(96, 96, 96);
                btnUpdate.NormalImageTint = btnUpdate.NormalForeColor;
                btnUpdate.Tag = "dontTheme";

                picLab.Visible = true;
            }

            //InitNetworkMonitoring();
            LoadTranslation();
            EnableToggleEvents();

            // Moved indicium to the end, because GetHardwareSpecs() is now async
            // trying to await it inside another method and then proceeding with the next
            // instructions didn't work. at least the WMI calls now don't take ages..
            // INDICIUM
            if (!_disableIndicium)
            {
                GetHardwareSpecs();
            }
            else
            {
                tabCollection.TabPages.Remove(indiciumTab);
                launcherMenu.Items.RemoveByKey("trayHW");
            }
        }

        // In the designer, ImageList gets re-encoded and the images lose quality over time
        // .. at least for me in VS 2022.
        private ImageList GetHardwareImagesAsImageList()
        {
            var il = new ImageList();
            il.ImageSize = new Size(32, 32);
            il.ColorDepth = ColorDepth.Depth32Bit;

            il.Images.Add("cpu", hwImages.cpu);
            il.Images.Add("ram", hwImages.ram);
            il.Images.Add("gpu", hwImages.gpu);
            il.Images.Add("mobo", hwImages.mobo);
            il.Images.Add("disk", hwImages.disk);
            il.Images.Add("inet", hwImages.inet);
            il.Images.Add("audio", hwImages.audio);
            il.Images.Add("dev", hwImages.dev);

            return il;
        }

        private void LoadSystemVariables()
        {
            listSystemVariables.Items.Clear();
            _systemVariables = IntegratorHelper.GetPathSystemVariables().ToList();
            listSystemVariables.Items.AddRange(_systemVariables.ToArray());
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

            tabControl.ItemSize = new Size(4 + maxTextWidth + _tabHeaderWidthMargin, maxTextHeight + _tabHeaderHeightMargin);
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

            List<string> newBoxAdapterItems = boxAdapter.Items.ToList();
            newBoxAdapterItems.AddRange(nics.Select(z => z.Description).ToArray());
            boxAdapter.Items = newBoxAdapterItems.ToArray();

            if (boxAdapter.Items.Length > 0)
            {
                boxAdapter.SelectedIndex = 0;
            }

            linkDNSv4.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv4A.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6A.LinkClicked += linkDNSIP_LinkClicked;

            LoadNetworkAdapterConfig();
        }

        private void LoadNetworkAdapterConfig()
        {
            if (boxAdapter.Items.Length <= 0)
            {
                return;
            }

            PingerHelper.GetActiveNetworkAdapters();
            if (PingerHelper.NetworkAdapters == null) return;
            if (PingerHelper.NetworkAdapters.Length == 0) return;

            _currentDNS = PingerHelper.GetDNSFromNetworkAdapter(PingerHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();
            if (_currentDNS == null) return;
            if (_currentDNS.Length == 0) return;

            if (Array.Exists(PingerHelper.CloudflareDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CloudflareDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.OpenDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.OpenDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.Quad9DNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.Quad9DNS;
                return;
            }
            else if (Array.Exists(PingerHelper.GoogleDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.GoogleDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.AlternateDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.AlternateDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.AdguardDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.AdguardDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.CleanBrowsingDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CleanBrowsingDNS;
                return;
            }
            else if (Array.Exists(PingerHelper.CleanBrowsingAdultDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CleanBrowsingAdultFilterDNS;
                return;
            }
            else
            {
                boxDNS.Text = Constants.CustomDNS;
                chkCustomDns.Checked = true;
                try
                {
                    if (_currentDNS.Length == 1)
                    {
                        linkDNSv4.Text = _currentDNS[0];
                        txtDns4A.Text = _currentDNS[0];
                    }
                    else if (_currentDNS.Length == 2)
                    {
                        linkDNSv4.Text = _currentDNS[0];
                        linkDNSv4A.Text = _currentDNS[1];
                        txtDns4A.Text = _currentDNS[0];
                        txtDns4B.Text = _currentDNS[1];
                    }
                    else if (_currentDNS.Length == 3)
                    {
                        linkDNSv6.Text = _currentDNS[0];
                        linkDNSv4.Text = _currentDNS[1];
                        linkDNSv4A.Text = _currentDNS[2];
                        txtDns6A.Text = _currentDNS[0];
                        txtDns4A.Text = _currentDNS[1];
                        txtDns4B.Text = _currentDNS[2];
                    }
                    else if (_currentDNS.Length == 4)
                    {
                        linkDNSv4.Text = _currentDNS[2];
                        linkDNSv4A.Text = _currentDNS[3];
                        linkDNSv6.Text = _currentDNS[0];
                        linkDNSv6A.Text = _currentDNS[1];

                        txtDns6A.Text = _currentDNS[2];
                        txtDns6B.Text = _currentDNS[3];
                        txtDns6A.Text = _currentDNS[0];
                        txtDns6B.Text = _currentDNS[1];
                    }
                }
                catch { }
                return;
            }
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
            if (boxAdapter.Items.Length <= 0)
            {
                return;
            }

            if (boxAdapter.SelectedIndex <= -1)
            {
                return;
            }

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
                boxLang.SelectedItem = Constants.ENGLISH;
                Translate(true);
            }
            else
            {
                Translate();
            }

            // set default window size to fit content
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.RU)
            {
                boxLang.SelectedItem = Constants.RUSSIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.TR)
            {
                boxLang.SelectedItem = Constants.TURKISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.EL)
            {
                boxLang.SelectedItem = Constants.HELLENIC;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.DE)
            {
                boxLang.SelectedItem = Constants.GERMAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.PT)
            {
                boxLang.SelectedItem = Constants.PORTUGUESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.FR)
            {
                boxLang.SelectedItem = Constants.FRENCH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.ES)
            {
                boxLang.SelectedItem = Constants.SPANISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.IT)
            {
                boxLang.SelectedItem = Constants.ITALIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.CN)
            {
                boxLang.SelectedItem = Constants.CHINESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.TW)
            {
                boxLang.SelectedItem = Constants.TAIWANESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.CZ)
            {
                boxLang.SelectedItem = Constants.CZECH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.KO)
            {
                boxLang.SelectedItem = Constants.KOREAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.PL)
            {
                boxLang.SelectedItem = Constants.POLISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.AR)
            {
                boxLang.SelectedItem = Constants.ARABIC;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.KU)
            {
                boxLang.SelectedItem = Constants.KURDISH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.HU)
            {
                boxLang.SelectedItem = Constants.HUNGARIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.RO)
            {
                boxLang.SelectedItem = Constants.ROMANIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.NL)
            {
                boxLang.SelectedItem = Constants.DUTCH;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.UA)
            {
                boxLang.SelectedItem = Constants.UKRAINIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.JA)
            {
                boxLang.SelectedItem = Constants.JAPANESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.FA)
            {
                boxLang.SelectedItem = Constants.PERSIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.NE)
            {
                boxLang.SelectedItem = Constants.NEPALI;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.BG)
            {
                boxLang.SelectedItem = Constants.BULGARIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.VN)
            {
                boxLang.SelectedItem = Constants.VIETNAMESE;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.UR)
            {
                boxLang.SelectedItem = Constants.URDU;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.ID)
            {
                boxLang.SelectedItem = Constants.INDONESIAN;
            }
            if (OptionsHelper.CurrentOptions.LanguageCode == LanguageCode.HR)
            {
                boxLang.SelectedItem = Constants.CROATIAN;
            }
        }

        private async void GetHardwareSpecs()
        {
            // instead of running these synchronously,
            // run them at the same time
            var cpuTask = Task.Run(() => GetCPUs());
            var ramTask = Task.Run(() => GetRAM());
            var gpuTask = Task.Run(() => GetGPUs());
            var motherboardTask = Task.Run(() => GetMotherboards());
            var storageTask = Task.Run(() => GetStorage());
            var networkTask = Task.Run(() => GetNetworkAdapters());
            var audioTask = Task.Run(() => GetAudioDevices());
            var peripheralTask = Task.Run(() => GetPeripherals());

            await Task.WhenAll(cpuTask, ramTask, gpuTask, motherboardTask, storageTask, networkTask, audioTask, peripheralTask);
            //MessageBox.Show("done");

            specsTree.Invoke(new Action(() =>
            {
                specsTree.Nodes["cpu"].Nodes.AddRange(cpuTask.Result);
                specsTree.Nodes["ram"].Nodes.AddRange(ramTask.Result);
                specsTree.Nodes["gpu"].Nodes.AddRange(gpuTask.Result);
                specsTree.Nodes["mobo"].Nodes.AddRange(motherboardTask.Result);
                specsTree.Nodes["disk"].Nodes.AddRange(storageTask.Result);
                specsTree.Nodes["inet"].Nodes.AddRange(networkTask.Result);
                specsTree.Nodes["audio"].Nodes.AddRange(audioTask.Result);
                specsTree.Nodes["dev"].Nodes.AddRange(peripheralTask.Result);
                GetOSInfo();

                _hwDetailed = specsTree.Nodes.Cast<TreeNode>().ToList();
                _hwSummarized = BuildHardwareSummaryNodes();

                specsTree.ExpandAll();
                if (specsTree.Nodes.Count > 0)
                {
                    specsTree.Nodes[0].EnsureVisible();
                }
            }));
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

        private TreeNode[] GetAudioDevices()
        {
            List<AudioDevice> audios = IndiciumHelper.GetAudioDevices();
            List<TreeNode> audioNodes = new List<TreeNode>();

            if (audios.Count > 0)
            {
                foreach (AudioDevice device in audios)
                {
                    TreeNode node = new TreeNode(device.ProductName);

                    node.Tag = _primaryItemTag;
                    node.Nodes.Add("Manufacturer: " + device.Manufacturer);
                    node.Nodes.Add("Status: " + device.Status);

                    audioNodes.Add(node);
                    //specsTree.Nodes["audio"].Nodes.Add(node);
                }
            }

            return audioNodes.ToArray();
        }

        private TreeNode[] GetPeripherals()
        {
            IndiciumHelper.GetPeripherals();
            List<TreeNode> peripheralNodes = new List<TreeNode>();

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

                peripheralNodes.Add(kbNodes);
                //specsTree.Nodes["dev"].Nodes.Add(kbNodes);
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

                peripheralNodes.Add(pdNodes);
                //specsTree.Nodes["dev"].Nodes.Add(pdNodes);
            }

            return peripheralNodes.ToArray();
        }

        private TreeNode[] GetNetworkAdapters()
        {
            IndiciumHelper.GetNetworkAdapters();
            List<TreeNode> wifiNodes = new List<TreeNode>();

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

                wifiNodes.Add(physicalsNode);
                //specsTree.Nodes["inet"].Nodes.Add(physicalsNode);
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

                wifiNodes.Add(virtualsNode);
                //specsTree.Nodes["inet"].Nodes.Add(virtualsNode);
            }

            return wifiNodes.ToArray();
        }

        private TreeNode[] GetStorage()
        {
            List<Disk> disks = IndiciumHelper.GetDisks();
            IndiciumHelper.GetVolumes();
            List<TreeNode> storageNodes = new List<TreeNode>();

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

                storageNodes.Add(disksNode);
                //specsTree.Nodes["disk"].Nodes.Add(disksNode);
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

                storageNodes.Add(opticalsNode);
                //specsTree.Nodes["disk"].Nodes.Add(opticalsNode);
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

                storageNodes.Add(volumesNode);
                //specsTree.Nodes["disk"].Nodes.Add(volumesNode);

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

                    storageNodes.Add(removablesNode);
                    //specsTree.Nodes["disk"].Nodes.Add(removablesNode);
                }
            }

            return storageNodes.ToArray();
        }

        private TreeNode[] GetCPUs()
        {
            List<CPU> cpus = IndiciumHelper.GetCPUs();
            List<TreeNode> cpuNodes = new List<TreeNode>();

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

                    cpuNodes.Add(node);
                    //specsTree.Nodes["cpu"].Nodes.Add(node);
                }
            }

            return cpuNodes.ToArray();
        }

        private TreeNode[] GetMotherboards()
        {
            List<Motherboard> mobos = IndiciumHelper.GetMotherboards();
            List<TreeNode> motherboardNodes = new List<TreeNode>();

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

                    motherboardNodes.Add(node);
                    motherboardNodes.Add(node2);
                    //specsTree.Nodes["mobo"].Nodes.Add(node);
                    //specsTree.Nodes["mobo"].Nodes.Add(node2);
                }
            }

            return motherboardNodes.ToArray();
        }

        private TreeNode[] GetGPUs()
        {
            List<GPU> gpus = IndiciumHelper.GetGPUs();
            List<TreeNode> gpuNodes = new List<TreeNode>();

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

                    gpuNodes.Add(node);
                    //specsTree.Nodes["gpu"].Nodes.Add(node);
                }
            }

            return gpuNodes.ToArray();
        }

        private TreeNode[] GetRAM()
        {
            List<RAM> ramInfo = IndiciumHelper.GetRAM();
            VirtualMemory vm = IndiciumHelper.GetVM();

            ByteSize totalRAM = new ByteSize(0);
            string memoryType = string.Empty;
            uint memorySpeed = 0;

            List<TreeNode> ramNodes = new List<TreeNode>();
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

                    ramNodes.Add(node);
                    //specsTree.Nodes["ram"].Nodes.Add(node);
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

                ramNodes.Add(node);
                //specsTree.Nodes["ram"].Nodes.Add(node);
            }

            return ramNodes.ToArray();
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
                    else if (element is cuiButton cb)
                    {
                        cb.Content = x.Value;
                        continue;
                    }
                    else if (element is cuiCheckbox cbx)
                    {
                        cbx.Content = x.Value;
                        continue;
                    }

                    element.Text = x.Value;
                }
            }

            txtVersion.Text = txtVersion.Text.Replace("{VN}", Program.CurrentVersionString);
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
                        AppsFromFeed = JsonConvert.DeserializeObject<List<AppInfo>>(feed);

                        AppCard appCard;
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
                            appCard.appTitle.Content = x.Title;
                            appCard.appTitle.Name = x.Tag;
                            appCard.appTitle.CheckedForeground = OptionsHelper.ForegroundColor;
                            appCard.appTitle.CheckedOutlineColor = OptionsHelper.ForegroundColor;
                            appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;

                            tmpImageFileName = x.Image.Substring(x.Image.LastIndexOf("/") + 1, x.Image.Length - (x.Image.LastIndexOf("/") + 1));
                            appCard.appImage.Image = Image.FromStream(zipEntries.First(ifn => ifn.Name == tmpImageFileName).Open());

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

                        // UI handling
                        btnDownloadApps.Enabled = true;
                        txtFeedError.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        btnDownloadApps.Enabled = false;
                        txtFeedError.Visible = true;

                        Logger.LogError("MainForm.GetFeed", ex.Message, ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                btnDownloadApps.Enabled = false;
                txtFeedError.Visible = true;

                Logger.LogError("MainForm.GetFeed-DownloadImages", ex.Message, ex.StackTrace);
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
                Logger.LogError("MainForm.CleanPC", ex.Message, ex.StackTrace);
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

            if (OptionsHelper.CurrentOptions.AutoStart && OptionsHelper.CurrentOptions.EnableTray)
            {
                this.Hide();
            }

            //DebugHelper.FindDifferenceInTwoJsons();
        }

        private void GetDesktopItems()
        {
            _desktopItems = IntegratorHelper.GetDesktopItems();
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

            foreach (ColumnHeader column in listStartupItems.Columns)
            {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
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
                appCard.BackColor = cuiPanel1.PanelColor;
                appCard.AutoSize = true;
                appCard.Anchor = AnchorStyles.None;
                appCard.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                appCard.appTitle.Content = x.Key;
                appCard.Width = panelUwp.Width - 30;
                appCard.appImage.SizeMode = PictureBoxSizeMode.Zoom;
                appCard.appTitle.CheckedForeground = OptionsHelper.ForegroundColor;
                appCard.appTitle.CheckedOutlineColor = OptionsHelper.ForegroundColor;

                // gets largest picture
                try
                {
                    pngTmp = new DirectoryInfo(x.Value)
                        .EnumerateFiles("*.png", SearchOption.AllDirectories)
                        .OrderByDescending(f => f.Length)
                        .FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Logger.LogError("MainForm.GetModernApps-ImageSearch", ex.Message, ex.StackTrace);
                    pngTmp = null;
                }

                if (pngTmp != null)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(pngTmp.FullName, FileMode.Open, FileAccess.Read))
                        {
                            appCard.appImage.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError("MainForm.GetModernApps-ImageLoad", ex.Message, ex.StackTrace);
                    }
                }

                appCard.Location = new Point(0, panelUwp.Controls.Count * GetItemPadding());
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
                if (c is cuiCheckbox && ((cuiCheckbox)c).Checked)
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
            _customCommands = IntegratorHelper.GetCustomCommands();
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
                OptionsHelper.CurrentOptions.AppsFolder = txtDownloadFolderTextBox.Content;
                OptionsHelper.SaveSettings();
                Environment.Exit(0);
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
                foreach (ListViewItem x in listStartupItems.CheckedItems)
                {
                    var item = _startUpItems.Find(y => y.Name == x.Text);
                    if (item != null)
                    {
                        item.Remove();
                    }
                }

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
                txtItemName.Content = string.Empty;
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
                txtItemName.Content = string.Empty;
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
                txtItemName.Content = string.Empty;
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
                txtItemName.Content = string.Empty;
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
                txtItemName.Content = string.Empty;
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
            txtItemName.Content = string.Empty;

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
                if (c is cuiCheckbox mc) mc.Checked = chkSelectAllModernApps.Checked;
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
            txtDownloadFolderButton.Enabled = false;
            txtDownloadFolderTextBox.Enabled = false;

            linkWarnings.Visible = false;
        }

        private void RenderAppDownloaderFree()
        {
            btnDownloadApps.Enabled = true;
            txtDownloadFolderButton.Enabled = true;
            txtDownloadFolderTextBox.Enabled = true;

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
            if (string.IsNullOrWhiteSpace(txtDownloadFolderTextBox.Content) || !Directory.Exists(txtDownloadFolderTextBox.Content))
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
                if (c is cuiCheckbox && ((cuiCheckbox)c).Checked) maxCount++;
            }

            cuiCheckbox currentCheck;
            Control[] temp;

            foreach (AppInfo x in AppsFromFeed)
            {
                if (string.IsNullOrEmpty(x.Tag)) continue;
                temp = appsTab.Controls.Find(x.Tag, true);
                if (!temp.Any()) continue;
                currentCheck = (cuiCheckbox)temp[0];
                if (currentCheck == null) continue;
                if (!currentCheck.Checked) continue;

                appNameTemp = x.Title;

                if (cuiComboBox1.SelectedItem == "64-bit")
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
                foreach (string a in Directory.GetFiles(txtDownloadFolderTextBox.Content, "*.*", SearchOption.TopDirectoryOnly))
                {
                    using (p = new Process())
                    {
                        count++;
                        p.StartInfo.FileName = a;
                        p.EnableRaisingEvents = true;
                        p.StartInfo.WorkingDirectory = txtDownloadFolderTextBox.Content;

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
                if (c.Name == "cAutoInstall")
                {
                    continue;
                }

                if (c is cuiCheckbox cc && cc.Checked)
                {
                    cc.Checked = false;
                }
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

                        await downloader.DownloadFileTaskAsync(new Uri(app.Link64), Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x64" + fileExtension));
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

                        await downloader.DownloadFileTaskAsync(new Uri(app.Link), Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x86" + fileExtension));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("MainForm.DownloadApp", ex.Message, ex.StackTrace);
                downloadLog += "• " + app.Title + ":" + Environment.NewLine + OptionsHelper.TranslationList["linkInvalid"] + Environment.NewLine + Environment.NewLine;

                if (pref64) try { File.Delete(Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x64.exe")); } catch { }
                if (!pref64) try { File.Delete(Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x86.exe")); } catch { }
                if (pref64) try { File.Delete(Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x64.msi")); } catch { }
                if (!pref64) try { File.Delete(Path.Combine(txtDownloadFolderTextBox.Content, app.Title + "-x86.msi")); } catch { }
            }
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
                }
                // if not, show actual progress
                else
                {
                    txtDownloadStatus.Text = string.Format("({1}/{2}) - {0} - {3} / {4}", appNameTemp, count, maxCount, ByteSize.FromBytes(e.BytesReceived).ToString("MB"), ByteSize.FromBytes(e.TotalBytesToReceive).ToString("MB"));
                    progressDownloader.Value = tempProgress;
                }
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFolderDialog d = new OpenFolderDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                txtDownloadFolderTextBox.Content = d.FolderName;
                OptionsHelper.CurrentOptions.AppsFolder = d.FolderName;
                OptionsHelper.SaveSettings();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtDownloadFolderTextBox.Content))
            {
                Process.Start(txtDownloadFolderTextBox.Content);
            }
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
            GetFeed();
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
            if (string.IsNullOrEmpty(txtPingInput.Text)) return;

            _pingResults = new List<PingReply>();

            listPingResults.Items.Clear();

            if (PingerHelper.PingHost(txtPingInput.Text) == null)
            {
                listPingResults.Items.Add(string.Format("{0} [{1}]", OptionsHelper.TranslationList["hostNotFound"], txtPingInput.Text));
                return;
            }

            Task pinger = new Task(() =>
            {
                btnShodan.Enabled = false;
                btnPing.Enabled = false;

                listPingResults.Items.Add(string.Format("{0}", OptionsHelper.TranslationList["pinging"]));
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
                        listPingResults.Items.Add(string.Format("{0} - {1}: {2} ms - TTL: {3}", _pingResults[i].Status, OptionsHelper.TranslationList["latency"], _pingResults[i].RoundtripTime, _pingResults[i].Options.Ttl));
                    }
                }

                listPingResults.Items.Add("");

                // calculate statistics
                if (_pingResults.Count > 0)
                {
                    long maxLatency = _pingResults.Max(x => x.RoundtripTime);
                    long minLatency = _pingResults.Min(x => x.RoundtripTime);
                    double averageLatency = _pingResults.Average(x => x.RoundtripTime);

                    listPingResults.Items.Add(string.Format("{0} = {1}, {2} = {3}, {4} = {5:F2}", OptionsHelper.TranslationList["min"], minLatency, OptionsHelper.TranslationList["max"], maxLatency, OptionsHelper.TranslationList["avg"], averageLatency));
                }
                else
                {
                    listPingResults.Items.Add(OptionsHelper.TranslationList["timeout"]);
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

            OptionsHelper.CurrentOptions.AppsFolder = txtDownloadFolderTextBox.Content;
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

        private void listStartupItems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.ForeColor = OptionsHelper.ForegroundColor;
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

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_originalGithubProjectLink);
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

        private void boxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLang.SelectedItem == Constants.ENGLISH)
            {
                picFlag.Content = Properties.Resources.united_kingdom;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EN;
            }
            else if (boxLang.SelectedItem == Constants.RUSSIAN)
            {
                picFlag.Content = Properties.Resources.russia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RU;
            }
            else if (boxLang.SelectedItem == Constants.HELLENIC)
            {
                picFlag.Content = Properties.Resources.greece;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.EL;
            }
            else if (boxLang.SelectedItem == Constants.GERMAN)
            {
                picFlag.Content = Properties.Resources.germany;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.DE;
            }
            else if (boxLang.SelectedItem == Constants.ITALIAN)
            {
                picFlag.Content = Properties.Resources.italy;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.IT;
            }
            else if (boxLang.SelectedItem == Constants.CZECH)
            {
                picFlag.Content = Properties.Resources.czech;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CZ;
            }
            else if (boxLang.SelectedItem == Constants.TURKISH)
            {
                picFlag.Content = Properties.Resources.turkey;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TR;
            }
            else if (boxLang.SelectedItem == Constants.SPANISH)
            {
                picFlag.Content = Properties.Resources.spain;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ES;
            }
            else if (boxLang.SelectedItem == Constants.PORTUGUESE)
            {
                picFlag.Content = Properties.Resources.brazil;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PT;
            }
            else if (boxLang.SelectedItem == Constants.FRENCH)
            {
                picFlag.Content = Properties.Resources.france;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FR;
            }
            else if (boxLang.SelectedItem == Constants.CHINESE)
            {
                picFlag.Content = Properties.Resources.china;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.CN;
            }
            else if (boxLang.SelectedItem == Constants.TAIWANESE)
            {
                picFlag.Content = Properties.Resources.china;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.TW;
            }
            else if (boxLang.SelectedItem == Constants.KOREAN)
            {
                picFlag.Content = Properties.Resources.korea;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KO;
            }
            else if (boxLang.SelectedItem == Constants.POLISH)
            {
                picFlag.Content = Properties.Resources.poland;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.PL;
            }
            else if (boxLang.SelectedItem == Constants.ARABIC)
            {
                picFlag.Content = Properties.Resources.egypt;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.AR;
            }
            else if (boxLang.SelectedItem == Constants.KURDISH)
            {
                picFlag.Content = Properties.Resources.kurdish;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.KU;
            }
            else if (boxLang.SelectedItem == Constants.HUNGARIAN)
            {
                picFlag.Content = Properties.Resources.hungary;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HU;
            }
            else if (boxLang.SelectedItem == Constants.ROMANIAN)
            {
                picFlag.Content = Properties.Resources.romania;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.RO;
            }
            else if (boxLang.SelectedItem == Constants.DUTCH)
            {
                picFlag.Content = Properties.Resources.dutch;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NL;
            }
            else if (boxLang.SelectedItem == Constants.UKRAINIAN)
            {
                picFlag.Content = Properties.Resources.ukraine;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UA;
            }
            else if (boxLang.SelectedItem == Constants.JAPANESE)
            {
                picFlag.Content = Properties.Resources.japan;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.JA;
            }
            else if (boxLang.SelectedItem == Constants.PERSIAN)
            {
                picFlag.Content = Properties.Resources.iran;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.FA;
            }
            else if (boxLang.SelectedItem == Constants.NEPALI)
            {
                picFlag.Content = Properties.Resources.nepal;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.NE;
            }
            else if (boxLang.SelectedItem == Constants.BULGARIAN)
            {
                picFlag.Content = Properties.Resources.bulgaria;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.BG;
            }
            else if (boxLang.SelectedItem == Constants.VIETNAMESE)
            {
                picFlag.Content = Properties.Resources.vietnam;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.VN;
            }
            else if (boxLang.SelectedItem == Constants.URDU)
            {
                picFlag.Content = Properties.Resources.pakistan;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.UR;
            }
            else if (boxLang.SelectedItem == Constants.INDONESIAN)
            {
                picFlag.Content = Properties.Resources.indonesia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.ID;
            }
            else if (boxLang.SelectedItem == Constants.CROATIAN)
            {
                picFlag.Content = Properties.Resources.croatia;
                OptionsHelper.CurrentOptions.LanguageCode = LanguageCode.HR;
            }

            OptionsHelper.SaveSettings();
            OptionsHelper.LoadTranslation();
            Translate();

            FixTabHeaderWidth(tabCollection);
            FixTabHeaderWidth(synapse);

            btnUpdate.Focus();
        }

        private void cleanDriveB_Click(object sender, EventArgs e)
        {
            CleanPC();
        }

        private void checkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listCleanPreview.Items.Count < 1)
            {
                foreach (CheckBox x in panel1.Controls.OfType<CheckBox>())
                {
                    x.Checked = !x.Checked;
                }
                return;
            }

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

        private void DisplayCurrentDNS()
        {
            if (boxAdapter.Items.Length <= 0)
            {
                return;
            }

            if (boxAdapter.SelectedIndex <= -1)
            {
                return;
            }

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
            FileUnlockForm fuf = new FileUnlockForm();
            fuf.ShowDialog(this);
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
            ConfirmAndReboot();
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageTint = colorPicker1.Content;
            OptionsHelper.CurrentOptions.Theme = colorPicker1.Content;
            OptionsHelper.ApplyTheme(this);

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

        private void btnRestartDisableDefender_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\RunOnce", "*OptimizerDisableDefender", Assembly.GetExecutingAssembly().Location + " /silentdisabledefender", Microsoft.Win32.RegistryValueKind.String);
            Program.RestartInSafeMode();
        }

        private void ConfirmAndReboot()
        {
            if (MessageBox.Show(_uwpRestoreMessage, "Optimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OptionsHelper.SaveSettings();
                Utilities.Reboot();
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

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(_moddedGithubProjectLink);
        }

        private void btnSfcScannow_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c sfc /scannow",
                Verb = "runas",
                UseShellExecute = true
            });
        }

        private void btnDismScan_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "dism.exe",
                Arguments = "/Online /Cleanup-Image /RestoreHealth",
                Verb = "runas",
                UseShellExecute = true
            });
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            tabCollection.Height = Height - bpanel.Top - tabCollection.ItemSize.Height - 2;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            tabCollection.Height = Height - bpanel.Top - tabCollection.ItemSize.Height - 2;
        }

        private void hostsLocateBtn_Click(object sender, EventArgs e)
        {
            HostsHelper.LocateHosts();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            panel18.Visible = !panel18.Visible;
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;

            string presetName = ((cuiButton)sender).Content;
            Color presetColor = ((cuiButton)sender).ForeColor;
            (Image, string)[] dangerousEntries =
            {
                (Resources.FluentIcons.ic_fluent_dock_row_24_filled, "Remove Start Menu Ads"),
                (Resources.FluentIcons.ic_fluent_data_area_24_filled, "Reduce Windows Telemetry"),
                (Resources.FluentIcons.ic_fluent_rocket_24_filled, "Optimize Windows Performance"),
                (Resources.FluentIcons.ext, "Show File Extensions"),
                (Resources.FluentIcons.ic_fluent_eye_hide_24_filled, "Show Hidden Files"),
                (Resources.FluentIcons.min_crossed, "Disable \"Shake to Minimize\""),
                (Resources.FluentIcons.gpu, "Change GPU Scheduling"),
                (Resources.FluentIcons.ic_fluent_task_list_rtl_24_filled, "Modify System Task Priority"),
            };
            using (PresetPreviewForm ppf = new PresetPreviewForm(presetName, presetColor, dangerousEntries))
            {
                if (ppf.ShowDialog() == DialogResult.Yes)
                {
                    // General Tab
                    officeTelemetrySw.ToggleChecked = true;
                    ffTelemetrySw.ToggleChecked = true;
                    chromeTelemetrySw.ToggleChecked = true;
                    nvidiaTelemetrySw.ToggleChecked = true;
                    vsSw.ToggleChecked = true;
                    telemetryTasksSw.ToggleChecked = true;
                    performanceSw.ToggleChecked = true;

                    // Windows 10/11 Tab
                    if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10 || Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
                    {
                        telemetryServicesSw.ToggleChecked = true;
                        privacySw.ToggleChecked = true;
                        adsSw.ToggleChecked = true;
                        edgeTelemetrySw.ToggleChecked = true;
                    }
                }
            }
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;

            string presetName = ((cuiButton)sender).Content;
            Color presetColor = ((cuiButton)sender).ForeColor;
            (Image, string)[] dangerousEntries =
            {
                (Resources.FluentIcons.ic_fluent_data_area_24_filled, "All of the Basic Preset's tweaks"),
                (Resources.FluentIcons.cross_onedrive, "Remove OneDrive"),
                (Resources.FluentIcons.cross_copilot, "Remove Copilot AI"),
                (Resources.FluentIcons.ic_fluent_sleep_24_filled, "Disable Hibernate && Superfetch"),
                (Resources.FluentIcons.win, "Disable SMBv1 && SMBv2"),
                (Resources.FluentIcons.translate, "Disable spell-checking"),
                (Resources.FluentIcons.translate, "Disable Windows Ink"),
                (Resources.FluentIcons.ic_fluent_data_area_24_filled, "Disable more telemetry"),
                (Resources.FluentIcons.win, "Disable Media Sharing"),
                (Resources.FluentIcons.win, "Disable MyPeople"),
                (Resources.FluentIcons.min_crossed, "Disable Snap-Assist"),
                (Resources.FluentIcons.win, "Disable stickers, chats & widgets"),
            };
            using (PresetPreviewForm ppf = new PresetPreviewForm(presetName, presetColor, dangerousEntries))
            {
                if (ppf.ShowDialog() == DialogResult.Yes)
                {
                    // General Tab
                    officeTelemetrySw.ToggleChecked = true;
                    ffTelemetrySw.ToggleChecked = true;
                    chromeTelemetrySw.ToggleChecked = true;
                    nvidiaTelemetrySw.ToggleChecked = true;
                    vsSw.ToggleChecked = true;
                    telemetryTasksSw.ToggleChecked = true;
                    performanceSw.ToggleChecked = true;

                    mediaSharingSw.ToggleChecked = true;
                    homegroupSw.ToggleChecked = true;
                    smb1Sw.ToggleChecked = true;
                    smb2Sw.ToggleChecked = true;
                    disableOneDriveSw.ToggleChecked = true;
                    superfetchSw.ToggleChecked = true;
                    hibernateSw.ToggleChecked = true;

                    // Windows 10/11 Tab
                    if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10 || Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
                    {
                        telemetryServicesSw.ToggleChecked = true;
                        privacySw.ToggleChecked = true;
                        adsSw.ToggleChecked = true;
                        edgeTelemetrySw.ToggleChecked = true;

                        cortanaSw.ToggleChecked = true;
                        newsInterestsSw.ToggleChecked = true;
                        edgeAiSw.ToggleChecked = true;
                        castSw.ToggleChecked = true;
                        peopleSw.ToggleChecked = true;
                        inkSw.ToggleChecked = true;
                        spellSw.ToggleChecked = true;
                        snapAssistSw.ToggleChecked = true;
                        copilotSw.ToggleChecked = true;
                        widgetsSw.ToggleChecked = true;
                        chatSw.ToggleChecked = true;
                        stickersSw.ToggleChecked = true;
                    }
                }
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "*JSON (.json)|*.json"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Program.ApplyConfigFromJsonTemplate(ofd.FileName);
                }

                panel18.Visible = false;
            }
        }
    }
}