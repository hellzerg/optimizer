using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    [Serializable]
    public sealed class SettingsJson
    {
        public Color Theme { get; set; }
        public string AppsFolder { get; set; }
        public bool EnableTray { get; set; }
        public bool AutoStart { get; set; }

        public string TelemetryClientID { get; set; }
        public bool DisableOptimizerTelemetry { get; set; }

        public LanguageCode LanguageCode { get; set; }

        // universal
        public bool EnablePerformanceTweaks { get; set; }
        public bool DisableNetworkThrottling { get; set; }
        public bool DisableWindowsDefender { get; set; }
        public bool DisableSystemRestore { get; set; }
        public bool DisablePrintService { get; set; }
        public bool DisableMediaPlayerSharing { get; set; }
        public bool DisableErrorReporting { get; set; }
        public bool DisableHomeGroup { get; set; }
        public bool DisableSuperfetch { get; set; }
        public bool DisableTelemetryTasks { get; set; }
        public bool DisableCompatibilityAssistant { get; set; }
        public bool DisableFaxService { get; set; }
        public bool DisableSmartScreen { get; set; }
        public bool DisableCloudClipboard { get; set; }
        public bool DisableStickyKeys { get; set; }
        public bool DisableHibernation { get; set; }
        public bool DisableSMB1 { get; set; }
        public bool DisableSMB2 { get; set; }
        public bool DisableNTFSTimeStamp { get; set; }
        public bool DisableSearch { get; set; }

        // apps telemetry
        public bool DisableOffice2016Telemetry { get; set; }
        public bool DisableVisualStudioTelemetry { get; set; }
        public bool DisableFirefoxTemeletry { get; set; }
        public bool DisableChromeTelemetry { get; set; }
        public bool DisableNVIDIATelemetry { get; set; }

        // windows 8
        public bool DisableOneDrive { get; set; }

        // windows 10
        public bool EnableLegacyVolumeSlider { get; set; }
        public bool DisableQuickAccessHistory { get; set; }
        public bool DisableStartMenuAds { get; set; }
        public bool UninstallOneDrive { get; set; }
        public bool DisableMyPeople { get; set; }
        public bool DisableAutomaticUpdates { get; set; }
        public bool ExcludeDrivers { get; set; }
        public bool DisableTelemetryServices { get; set; }
        public bool DisablePrivacyOptions { get; set; }
        public bool DisableCortana { get; set; }
        public bool DisableSensorServices { get; set; }
        public bool DisableWindowsInk { get; set; }
        public bool DisableSpellingTyping { get; set; }
        public bool DisableXboxLive { get; set; }
        public bool DisableGameBar { get; set; }
        public bool DisableInsiderService { get; set; }
        public bool DisableStoreUpdates { get; set; }
        public bool EnableLongPaths { get; set; }
        public bool RemoveCastToDevice { get; set; }
        public bool EnableGamingMode { get; set; }

        // windows 11
        public bool TaskbarToLeft { get; set; }
        public bool DisableSnapAssist { get; set; }
        public bool DisableWidgets { get; set; }
        public bool DisableChat { get; set; }
        public bool TaskbarSmaller { get; set; }
        public bool ClassicRibbon { get; set; }
        public bool ClassicMenu { get; set; }
        public bool DisableTPMCheck { get; set; }
        public bool CompactMode { get; set; }
        public bool DisableStickers { get; set; }
        public bool DisableVBS { get; set; }
    }

    internal static class Options
    {
        const int CONTRAST_THRESHOLD = 149;

        internal static Color ForegroundColor = Color.FromArgb(153, 102, 204);
        internal static Color ForegroundAccentColor = Color.FromArgb(134, 89, 179);
        internal static Color BackgroundColor = Color.FromArgb(10, 10, 10);
        internal static Color BackAccentColor = Color.FromArgb(40, 40, 40);
        internal static Color TextColor;

        readonly static string _themeFlag = "themeable";
        internal readonly static string SettingsFile = Required.CoreFolder + "\\Optimizer.json";

        internal static SettingsJson CurrentOptions = new SettingsJson();

        internal static dynamic TranslationList;

        internal static Color GetContrastColor(Color c)
        {
            double brightness = c.R * 0.299 + c.G * 0.587 + c.B * 0.114;
            return brightness > CONTRAST_THRESHOLD ? Color.Black : Color.White;
        }

        internal static void ApplyTheme(Form f)
        {
            SetTheme(f, CurrentOptions.Theme, ColorHelper.ChangeColorBrightness(CurrentOptions.Theme, 0.7));
        }

        private static void SetTheme(Form f, Color c1, Color c2)
        {
            dynamic c;
            ForegroundColor = c1;
            ForegroundAccentColor = c2;
            TextColor = GetContrastColor(CurrentOptions.Theme);

            Utilities.GetSelfAndChildrenRecursive(f).ToList().ForEach(x =>
            {
                c = x;

                if (x is Button)
                {
                    c.ForeColor = TextColor;
                    c.BackColor = c1;
                    c.FlatAppearance.BorderColor = c1;
                    c.FlatAppearance.MouseDownBackColor = c2;
                    c.FlatAppearance.MouseOverBackColor = c2;
                    c.FlatAppearance.BorderSize = 0;
                }

                if (x is LinkLabel)
                {
                    if ((string)c.Tag == _themeFlag)
                    {
                        c.LinkColor = c1;
                        c.VisitedLinkColor = c1;
                        c.ActiveLinkColor = c2;
                    }
                }

                if (x is CheckBox || x is RadioButton || x is Label)
                {
                    if ((string)c.Tag == _themeFlag)
                    {
                        c.ForeColor = c1;
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
                    SettingsJson tmpJson = JsonConvert.DeserializeObject<SettingsJson>(File.ReadAllText(SettingsFile));
                    tmpJson.Theme = Color.FromArgb(153, 102, 204);
                    CurrentOptions = tmpJson;
                }
                else
                {
                    // DEFAULT OPTIONS
                    CurrentOptions.Theme = Color.FromArgb(153, 102, 204);
                    CurrentOptions.AppsFolder = Path.Combine(Application.StartupPath, "OptimizerDownloads");
                    Directory.CreateDirectory(Options.CurrentOptions.AppsFolder);
                    CurrentOptions.EnableTray = false;
                    CurrentOptions.AutoStart = false;

                    CurrentOptions.TelemetryClientID = Guid.NewGuid().ToString().ToUpperInvariant();
                    CurrentOptions.DisableOptimizerTelemetry = false;

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

                    CurrentOptions.DisableVisualStudioTelemetry = false;
                    CurrentOptions.DisableFirefoxTemeletry = false;
                    CurrentOptions.DisableChromeTelemetry = false;
                    CurrentOptions.DisableNVIDIATelemetry = false;

                    CurrentOptions.DisableOneDrive = false;

                    CurrentOptions.TaskbarToLeft = false;
                    CurrentOptions.DisableSnapAssist = false;
                    CurrentOptions.DisableWidgets = false;
                    CurrentOptions.DisableChat = false;
                    CurrentOptions.TaskbarSmaller = false;
                    CurrentOptions.ClassicRibbon = false;
                    CurrentOptions.ClassicMenu = false;
                    CurrentOptions.DisableTPMCheck = false;
                    CurrentOptions.CompactMode = false;
                    CurrentOptions.DisableStickers = false;
                    CurrentOptions.DisableVBS = false;

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
                CurrentOptions = JsonConvert.DeserializeObject<SettingsJson>(File.ReadAllText(SettingsFile));
            }

            // prevent options from corruption
            if (CurrentOptions.Theme == Color.Empty || CurrentOptions.Theme == Color.FromArgb(0, 0, 0, 0))
            {
                CurrentOptions.Theme = Color.FromArgb(153, 102, 204);
            }
            // generate random telemetry ID if not present
            if (string.IsNullOrEmpty(CurrentOptions.TelemetryClientID))
            {
                CurrentOptions.TelemetryClientID = Guid.NewGuid().ToString().ToUpperInvariant();
                SaveSettings();
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
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Options.LoadTranslation", ex.Message, ex.StackTrace);
                TranslationList = JObject.Parse(Properties.Resources.EN);
            }
        }
    }
}
