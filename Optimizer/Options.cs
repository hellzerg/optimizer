using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Optimizer
{
    public class SettingsJson
    {
        public Theme Color { get; set; }

        public bool EnablePerformanceTweaks { get; set; }
        public bool DisableNetworkThrottling { get; set; }
        public bool DisableWindowsDefender { get; set; }
        public bool DisableSystemRestore { get; set; }
        public bool DisablePrintService { get; set; }
        public bool DisableMediaPlayerSharing { get; set; }
        public bool BlockSkypeAds { get; set; }
        public bool DisableErrorReporting { get; set; }
        public bool DisableHomeGroup { get; set; }
        public bool DisableSuperfetch { get; set; }
        public bool DisableTelemetryTasks { get; set; }
        public bool DisableOffice2016Telemetry { get; set; }
        public bool DisableCompatibilityAssistant { get; set; }
        public bool DisableFaxService { get; set; }
        public bool DisableSmartScreen { get; set; }
        public bool DisableCloudClipboard { get; set; }
        public bool DisableStickyKeys { get; set; }

        public bool EnableLegacyVolumeSlider { get; set; }
        public bool EnableTaskbarColor { get; set; }
        public bool DisableQuickAccessHistory { get; set; }
        public bool DisableStartMenuAds { get; set; }
        public bool EnableDarkTheme { get; set; }
        public bool UninstallOneDrive { get; set; }
        public bool DisableMyPeople { get; set; }
        public bool DisableAutomaticUpdates { get; set; }
        public bool ExcludeDrivers { get; set; }
        public bool DisableTelemetryServices { get; set; }
        public bool DisablePrivacyOptions { get; set; }
        public bool DisableSilentAppInstall { get; set; }
        public bool DisableCortana { get; set; }
        public bool DisableSensorServices { get; set; }
        public bool DisableWindowsInk { get; set; }
        public bool DisableSpellingTyping { get; set; }
        public bool DisableXboxLive { get; set; }
        public bool DisableGameBar { get; set; }
        public bool DisableInsiderService { get; set; }
        public bool DisableFeatureUpdates { get; set; }
        public bool EnableLongPaths { get; set; }

        public bool DisableOneDrive { get; set; }
    }

    internal static class Options
    {
        readonly static string _themeFlag = "themeable";
        internal readonly static string SettingsFile = Required.CoreFolder + "\\Optimizer.json";

        internal static SettingsJson CurrentOptions = new SettingsJson();

        internal static void ApplyTheme(Form f)
        {
            switch (CurrentOptions.Color)
            {
                case Theme.Caramel:
                    SetTheme(f, Color.DarkOrange, Color.Chocolate);
                    break;
                case Theme.Lime:
                    SetTheme(f, Color.LimeGreen, Color.ForestGreen);
                    break;
                case Theme.Magma:
                    SetTheme(f, Color.Tomato, Color.Red);
                    break;
                case Theme.Minimal:
                    SetTheme(f, Color.Gray, Color.DimGray);
                    break;
                case Theme.Ocean:
                    SetTheme(f, Color.DodgerBlue, Color.RoyalBlue);
                    break;
                case Theme.Zerg:
                    SetTheme(f, Color.MediumOrchid, Color.DarkOrchid);
                    break;
            }
        }

        private static void SetTheme(Form f, Color c1, Color c2)
        {
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.BackColor = c1);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.BorderColor = c1);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseDownBackColor = c2);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseOverBackColor = c2);

            foreach (ToggleSwitch tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<ToggleSwitch>().ToList())
            {
                if ((string)tmp.Tag == _themeFlag)
                {
                    tmp.SetRenderer(new ToggleSwitchRenderer());
                }
            }
            foreach (Label tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<Label>().ToList())
            {
                if ((string)tmp.Tag == _themeFlag)
                {
                    tmp.ForeColor = c1;
                }
            }
            foreach (LinkLabel tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<LinkLabel>().ToList())
            {
                if ((string)tmp.Tag == _themeFlag)
                {
                    tmp.LinkColor = c1;
                    tmp.VisitedLinkColor = c1;
                    tmp.ActiveLinkColor = c2;
                }
            }
            foreach (CheckBox tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<CheckBox>().ToList())
            {
                if ((string)tmp.Tag == _themeFlag)
                {
                    tmp.ForeColor = c1;
                }
            }
        }

        internal static void SaveSettings()
        {
            if (File.Exists(SettingsFile))
            {
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
            if (!File.Exists(SettingsFile))
            {
                CurrentOptions.Color = Theme.Zerg;

                CurrentOptions.EnablePerformanceTweaks = false;
                CurrentOptions.DisableNetworkThrottling = false;
                CurrentOptions.DisableWindowsDefender = false;
                CurrentOptions.DisableSystemRestore = false;
                CurrentOptions.DisablePrintService = false;
                CurrentOptions.DisableMediaPlayerSharing = false;
                CurrentOptions.BlockSkypeAds = false;
                CurrentOptions.DisableErrorReporting = false;
                CurrentOptions.DisableHomeGroup = false;
                CurrentOptions.DisableSuperfetch = false;
                CurrentOptions.DisableTelemetryTasks = false;
                CurrentOptions.DisableOffice2016Telemetry = false;
                CurrentOptions.DisableCompatibilityAssistant = false;
                CurrentOptions.DisableFaxService = false;
                CurrentOptions.DisableSmartScreen = false;
                CurrentOptions.DisableStickyKeys = false;

                CurrentOptions.EnableLegacyVolumeSlider = false;
                CurrentOptions.EnableTaskbarColor = false;
                CurrentOptions.DisableQuickAccessHistory = false;
                CurrentOptions.DisableStartMenuAds = false;
                CurrentOptions.EnableDarkTheme = false;
                CurrentOptions.UninstallOneDrive = false;
                CurrentOptions.DisableMyPeople = false;
                CurrentOptions.DisableAutomaticUpdates = false;
                CurrentOptions.ExcludeDrivers = false;
                CurrentOptions.DisableTelemetryServices = false;
                CurrentOptions.DisablePrivacyOptions = false;
                CurrentOptions.DisableSilentAppInstall = false;
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

                CurrentOptions.DisableOneDrive = false;

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
        }
    }
}
