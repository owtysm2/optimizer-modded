using CuoreUI.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    internal static class OptionsHelper
    {
        internal static Color DefaultForegroundColor = Color.FromArgb(73, 235, 149);

        internal static Color ForegroundColor = DefaultForegroundColor;
        internal static Color ForegroundAccentColor = ColorHelper.ChangeColorBrightness(ForegroundColor, 0.7);
        internal static Color BackgroundColor = Color.FromArgb(10, 10, 10);
        internal static Color BackAccentColor = Color.FromArgb(40, 40, 40);
        internal static Color TextColor;

        internal readonly static string SettingsFile = CoreHelper.CoreFolder + "\\Optimizer Modded.json";

        internal static Options CurrentOptions = new Options();

        internal static dynamic TranslationList;

        internal static Color GetContrastColor(Color c)
        {
            double brightness = c.R * 0.299 + c.G * 0.587 + c.B * 0.114;
            return brightness > Constants.CONTRAST_THRESHOLD ? Color.Black : Color.White;
        }

        internal static void ApplyTheme(Form f)
        {
            SetTheme(f, CurrentOptions.Theme);
        }

        private static void SetTheme(Form f, Color newForegroundColor)
        {
            dynamic c;

            ForegroundColor = newForegroundColor;
            ForegroundAccentColor = ColorHelper.ChangeColorBrightness(newForegroundColor, 0.7);

            TextColor = GetContrastColor(CurrentOptions.Theme);
            var TextColorHover = Color.FromArgb(192, TextColor);
            var TextColorPress = Color.FromArgb(156, TextColor);

            Utilities.GetSelfAndChildrenRecursive(f).ToList().ForEach(x =>
            {
                c = x;

                if (c.Tag?.ToString() == "dontTheme")
                {
                    return;
                }

                if (x is Button)
                {
                    c.ForeColor = TextColor;
                    c.BackColor = ForegroundColor;
                    c.FlatAppearance.BorderColor = ForegroundColor;
                    c.FlatAppearance.MouseDownBackColor = ForegroundAccentColor;
                    c.FlatAppearance.MouseOverBackColor = ForegroundAccentColor;
                    c.FlatAppearance.BorderSize = 0;
                }
                else if (x is ToggleCard tc)
                {
                    tc.Toggle.CheckedBackground = ForegroundColor;
                    tc.Toggle.CheckedForeground = TextColor;
                }
                else if (x is cuiButton cb)
                {
                    cb.ForeColor = TextColor;
                    cb.HoverForeColor = TextColorHover;
                    cb.PressedForeColor = TextColorPress;

                    cb.NormalImageTint = TextColor;
                    cb.HoverImageTint = TextColorHover;
                    cb.PressedImageTint = TextColorPress;

                    cb.NormalBackground = ForegroundColor;
                    cb.HoverBackground = ForegroundColor;
                    cb.PressedBackground = ForegroundColor;
                }
                else if (x is cuiProgressBarHorizontal cpbh)
                {
                    cpbh.Foreground = ForegroundColor;
                }
                else if (x is cuiCheckbox cbx)
                {
                    cbx.CheckedForeground = ForegroundColor;
                    cbx.CheckedOutlineColor = ForegroundColor;
                    cbx.CheckedSymbolColor = TextColor;
                }
                else if (x is AppCard ac)
                {
                    ac.appTitle.CheckedForeground = ForegroundColor;
                    ac.appTitle.CheckedOutlineColor = ForegroundColor;
                }
                else if (x is cuiListbox cl)
                {
                    cl.ItemSelectedBackgroundColor = ForegroundColor;
                    cl.SelectedForegroundColor = TextColor;
                }
                else if (x is LinkLabel)
                {
                    if ((string)c.Tag == Constants.THEME_FLAG)
                    {
                        c.LinkColor = ForegroundColor;
                        c.VisitedLinkColor = ForegroundColor;
                        c.ActiveLinkColor = ForegroundAccentColor;
                    }
                }
                else if (x is cuiTextBox ctb)
                {
                    ctb.FocusOutlineColor = ForegroundColor;
                }
                else if (x is CheckBox || x is RadioButton || x is Label)
                {
                    if ((string)c.Tag == Constants.THEME_FLAG)
                    {
                        c.ForeColor = ForegroundColor;
                    }
                }

                c.Invalidate();
            });
        }

        internal static void LegacyCheck()
        {
            if (File.Exists(SettingsFile))
            {
                if (File.ReadAllText(SettingsFile).Contains("FirstRun"))
                {
                    File.Delete(SettingsFile);
                }
            }
        }

        internal static void SaveSettings()
        {
            if (File.Exists(SettingsFile))
            {
                string jsonFile = File.ReadAllText(SettingsFile);
                string jsonMemory = JsonConvert.SerializeObject(CurrentOptions);

                // check to see if no changes have been made
                if (JToken.DeepEquals(JObject.Parse(jsonFile), JObject.Parse(jsonMemory))) return;

                File.Delete(SettingsFile);

                using (FileStream fs = File.Open(SettingsFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
        }

        internal static void LoadSettings()
        {
            if (!File.Exists(SettingsFile) || File.ReadAllText(SettingsFile).Contains("\"Color\":"))
            {
                // settings migration for new color picker
                if (File.Exists(SettingsFile) && File.ReadAllText(SettingsFile).Contains("\"Color\":"))
                {
                    Options tmpJson = JsonConvert.DeserializeObject<Options>(File.ReadAllText(SettingsFile));
                    tmpJson.Theme = DefaultForegroundColor;
                    CurrentOptions = tmpJson;
                }
                else
                {
                    // DEFAULT OPTIONS
                    CurrentOptions.Theme = DefaultForegroundColor;
                    CurrentOptions.AppsFolder = string.Empty;
                    CurrentOptions.EnableTray = false;
                    CurrentOptions.AutoStart = false;
                    CurrentOptions.InternalDNS = Constants.INTERNAL_DNS;
                    CurrentOptions.UpdateOnLaunch = true;

                    CurrentOptions.DisableIndicium = false;
                    CurrentOptions.DisableAppsTool = false;
                    CurrentOptions.DisableHostsEditor = false;
                    CurrentOptions.DisableUWPApps = false;
                    CurrentOptions.DisableStartupTool = false;
                    CurrentOptions.DisableCleaner = false;
                    CurrentOptions.DisableIntegrator = false;
                    CurrentOptions.DisablePinger = false;

                    CurrentOptions.LanguageCode = LanguageCode.EN;

                    CurrentOptions.EnablePerformanceTweaks = false;
                    CurrentOptions.DisableNetworkThrottling = false;
                    CurrentOptions.DisableWindowsDefender = false;
                    CurrentOptions.DisableSystemRestore = false;
                    CurrentOptions.DisablePrintService = false;
                    CurrentOptions.DisableMediaPlayerSharing = false;
                    CurrentOptions.DisableErrorReporting = false;
                    CurrentOptions.DisableHomeGroup = false;
                    CurrentOptions.DisableSuperfetch = false;
                    CurrentOptions.DisableTelemetryTasks = false;
                    CurrentOptions.DisableOffice2016Telemetry = false;
                    CurrentOptions.DisableCompatibilityAssistant = false;
                    CurrentOptions.DisableFaxService = false;
                    CurrentOptions.DisableSmartScreen = false;
                    CurrentOptions.DisableStickyKeys = false;
                    CurrentOptions.EnableGamingMode = false;
                    CurrentOptions.EnableLegacyVolumeSlider = false;
                    CurrentOptions.DisableQuickAccessHistory = false;
                    CurrentOptions.DisableStartMenuAds = false;
                    CurrentOptions.UninstallOneDrive = false;
                    CurrentOptions.DisableMyPeople = false;
                    CurrentOptions.DisableAutomaticUpdates = false;
                    CurrentOptions.ExcludeDrivers = false;
                    CurrentOptions.DisableTelemetryServices = false;
                    CurrentOptions.DisablePrivacyOptions = false;
                    CurrentOptions.DisableCortana = false;
                    CurrentOptions.DisableSensorServices = false;
                    CurrentOptions.DisableWindowsInk = false;
                    CurrentOptions.DisableSpellingTyping = false;
                    CurrentOptions.DisableXboxLive = false;
                    CurrentOptions.DisableGameBar = false;
                    CurrentOptions.DisableInsiderService = false;
                    CurrentOptions.DisableStoreUpdates = false;
                    CurrentOptions.DisableCloudClipboard = false;
                    CurrentOptions.EnableLongPaths = false;
                    CurrentOptions.RemoveCastToDevice = false;
                    CurrentOptions.DisableHibernation = false;
                    CurrentOptions.DisableSMB1 = false;
                    CurrentOptions.DisableSMB2 = false;
                    CurrentOptions.DisableNTFSTimeStamp = false;
                    CurrentOptions.DisableSearch = false;
                    CurrentOptions.RestoreClassicPhotoViewer = false;

                    CurrentOptions.DisableVisualStudioTelemetry = false;
                    CurrentOptions.DisableFirefoxTemeletry = false;
                    CurrentOptions.DisableChromeTelemetry = false;
                    CurrentOptions.DisableNVIDIATelemetry = false;

                    CurrentOptions.DisableEdgeDiscoverBar = false;
                    CurrentOptions.DisableEdgeTelemetry = false;

                    CurrentOptions.DisableOneDrive = false;

                    CurrentOptions.TaskbarToLeft = false;
                    CurrentOptions.DisableSnapAssist = false;
                    CurrentOptions.DisableWidgets = false;
                    CurrentOptions.DisableChat = false;
                    CurrentOptions.ClassicMenu = false;
                    CurrentOptions.DisableTPMCheck = false;
                    CurrentOptions.CompactMode = false;
                    CurrentOptions.DisableStickers = false;
                    CurrentOptions.DisableVBS = false;
                    CurrentOptions.DisableCoPilotAI = false;

                    CurrentOptions.DisableHPET = false;
                    CurrentOptions.EnableRegistryBackups = false;
                    CurrentOptions.EnableLoginVerbose = false;

                    CurrentOptions.RemoveMenusDelay = false;
                    CurrentOptions.ShowAllTrayIcons = false;
                    CurrentOptions.DisableModernStandby = false;
                    CurrentOptions.EnableUtcTime = false;
                    CurrentOptions.DisableNewsInterests = false;
                    CurrentOptions.HideTaskbarSearch = false;
                    CurrentOptions.HideTaskbarWeather = false;

                    using (FileStream fs = File.Open(SettingsFile, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(fs))
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(jw, CurrentOptions);
                    }
                }
            }
            else
            {
                CurrentOptions = JsonConvert.DeserializeObject<Options>(File.ReadAllText(SettingsFile));
            }

            // prevent options from corruption
            if (CurrentOptions.Theme == Color.Empty || CurrentOptions.Theme == Color.FromArgb(0, 0, 0, 0))
            {
                CurrentOptions.Theme = DefaultForegroundColor;
            }

            LoadTranslation();
        }

        internal static void LoadTranslation()
        {
            // load proper translation list
            try
            {
                if (CurrentOptions.LanguageCode == LanguageCode.EN) TranslationList = JObject.Parse(Properties.Resources.EN);
                if (CurrentOptions.LanguageCode == LanguageCode.RU) TranslationList = JObject.Parse(Properties.Resources.RU);
                if (CurrentOptions.LanguageCode == LanguageCode.EL) TranslationList = JObject.Parse(Properties.Resources.EL);
                if (CurrentOptions.LanguageCode == LanguageCode.TR) TranslationList = JObject.Parse(Properties.Resources.TR);
                if (CurrentOptions.LanguageCode == LanguageCode.DE) TranslationList = JObject.Parse(Properties.Resources.DE);
                if (CurrentOptions.LanguageCode == LanguageCode.ES) TranslationList = JObject.Parse(Properties.Resources.ES);
                if (CurrentOptions.LanguageCode == LanguageCode.PT) TranslationList = JObject.Parse(Properties.Resources.PT);
                if (CurrentOptions.LanguageCode == LanguageCode.FR) TranslationList = JObject.Parse(Properties.Resources.FR);
                if (CurrentOptions.LanguageCode == LanguageCode.IT) TranslationList = JObject.Parse(Properties.Resources.IT);
                if (CurrentOptions.LanguageCode == LanguageCode.CN) TranslationList = JObject.Parse(Properties.Resources.CN);
                if (CurrentOptions.LanguageCode == LanguageCode.CZ) TranslationList = JObject.Parse(Properties.Resources.CZ);
                if (CurrentOptions.LanguageCode == LanguageCode.TW) TranslationList = JObject.Parse(Properties.Resources.TW);
                if (CurrentOptions.LanguageCode == LanguageCode.KO) TranslationList = JObject.Parse(Properties.Resources.KO);
                if (CurrentOptions.LanguageCode == LanguageCode.PL) TranslationList = JObject.Parse(Properties.Resources.PL);
                if (CurrentOptions.LanguageCode == LanguageCode.AR) TranslationList = JObject.Parse(Properties.Resources.AR);
                if (CurrentOptions.LanguageCode == LanguageCode.KU) TranslationList = JObject.Parse(Properties.Resources.KU);
                if (CurrentOptions.LanguageCode == LanguageCode.HU) TranslationList = JObject.Parse(Properties.Resources.HU);
                if (CurrentOptions.LanguageCode == LanguageCode.RO) TranslationList = JObject.Parse(Properties.Resources.RO);
                if (CurrentOptions.LanguageCode == LanguageCode.NL) TranslationList = JObject.Parse(Properties.Resources.NL);
                if (CurrentOptions.LanguageCode == LanguageCode.UA) TranslationList = JObject.Parse(Properties.Resources.UA);
                if (CurrentOptions.LanguageCode == LanguageCode.JA) TranslationList = JObject.Parse(Properties.Resources.JA);
                if (CurrentOptions.LanguageCode == LanguageCode.FA) TranslationList = JObject.Parse(Properties.Resources.FA);
                if (CurrentOptions.LanguageCode == LanguageCode.NE) TranslationList = JObject.Parse(Properties.Resources.NE);
                if (CurrentOptions.LanguageCode == LanguageCode.BG) TranslationList = JObject.Parse(Properties.Resources.BG);
                if (CurrentOptions.LanguageCode == LanguageCode.VN) TranslationList = JObject.Parse(Properties.Resources.VN);
                if (CurrentOptions.LanguageCode == LanguageCode.UR) TranslationList = JObject.Parse(Properties.Resources.UR);
                if (CurrentOptions.LanguageCode == LanguageCode.ID) TranslationList = JObject.Parse(Properties.Resources.ID);
                if (CurrentOptions.LanguageCode == LanguageCode.HR) TranslationList = JObject.Parse(Properties.Resources.HR);
            }
            catch (Exception ex)
            {
                Logger.LogError("Options.LoadTranslation", ex.Message, ex.StackTrace);
                TranslationList = JObject.Parse(Properties.Resources.EN);
            }
        }
    }
}
