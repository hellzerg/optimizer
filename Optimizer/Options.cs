﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Optimizer
{
    [Serializable]
    public class SettingsJson
    {
        public Color ThemeColor { get; set; }
        public string AppsFolder { get; set; }
        public bool EnableTray { get; set; }
        public bool ShowHelp { get; set; }

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

        // apps telemetry
        public bool DisableOffice2016Telemetry { get; set; }
        public bool DisableVisualStudioTelemetry { get; set; }
        public bool DisableNVIDIATelemetry { get; set; }
        public bool DisableFirefoxTemeletry { get; set; }
        public bool DisableChromeTelemetry { get; set; }

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
        public bool DisableFeatureUpdates { get; set; }
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
    }

    internal static class Options
    {
        internal static Color ForegroundColor = Color.FromArgb(153, 102, 204);
        internal static Color ForegroundAccentColor = Color.FromArgb(134, 89, 179);
        internal static Color BackgroundColor = Color.FromArgb(10, 10, 10);
        internal static Color BackAccentColor = Color.FromArgb(40, 40, 40);

        readonly static string _themeFlag = "themeable";
        internal readonly static string SettingsFile = Required.CoreFolder + "\\Optimizer.json";

        internal static SettingsJson CurrentOptions = new SettingsJson();

        internal static dynamic TranslationList;

        internal static void ApplyThemeColor(Form f, Color c)
        {
            SetTheme(f, c, ColorHelper.ChangeColorBrightness(c, 0.7));
        }

        private static void SetTheme(Form f, Color c1, Color c2)
        {
            dynamic c;
            ForegroundColor = c1;
            ForegroundAccentColor = c2;

            Utilities.GetSelfAndChildrenRecursive(f).ToList().ForEach(x =>
            {
                c = x;

                if (x is Button)
                {
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
                if (File.Exists(SettingsFile) && File.ReadAllText(SettingsFile).Contains("\"Color\":"))
                {
                    File.Delete(SettingsFile);
                }
                
                // DEFAULT OPTIONS
                CurrentOptions.ThemeColor = Color.FromArgb(153, 102, 204); // Amethyst color
                CurrentOptions.AppsFolder = Path.Combine(Application.StartupPath, "Optimizer Downloads");
                Directory.CreateDirectory(Options.CurrentOptions.AppsFolder);
                CurrentOptions.EnableTray = false;
                CurrentOptions.ShowHelp = true;

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
                CurrentOptions.DisableFeatureUpdates = false;
                CurrentOptions.DisableCloudClipboard = false;
                CurrentOptions.EnableLongPaths = false;
                CurrentOptions.RemoveCastToDevice = false;
                CurrentOptions.DisableHibernation = false;
                CurrentOptions.DisableSMB1 = false;
                CurrentOptions.DisableSMB2 = false;
                CurrentOptions.DisableNTFSTimeStamp = false;

                CurrentOptions.DisableVisualStudioTelemetry = false;
                CurrentOptions.DisableNVIDIATelemetry = false;
                CurrentOptions.DisableFirefoxTemeletry = false;
                CurrentOptions.DisableChromeTelemetry = false;

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

                using (FileStream fs = File.Open(SettingsFile, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
            else
            {
                CurrentOptions = JsonConvert.DeserializeObject<SettingsJson>(File.ReadAllText(SettingsFile));
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
;            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Options.LoadTranslation", ex.Message, ex.StackTrace);
                TranslationList = JObject.Parse(Properties.Resources.EN);
            }
        }
    }
}
