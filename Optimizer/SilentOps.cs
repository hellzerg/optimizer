using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Optimizer
{
    internal static class SilentOps
    {
        internal static SilentConfig CurrentSilentConfig;

        internal static SilentConfig GetSilentConfig(string path)
        {
            try
            {
                CurrentSilentConfig = JsonConvert.DeserializeObject<SilentConfig>(File.ReadAllText(path));
            }
            catch
            {
                CurrentSilentConfig = null;
            }
            return CurrentSilentConfig;
        }

        // silent config processing for universal tweaks
        internal static void ProcessSilentConfigGeneral()
        {
            if (CurrentSilentConfig.EnablePerformanceTweaks)
            {
                Optimize.EnablePerformanceTweaks();
            }
            else
            {
                Optimize.DisablePerformanceTweaks();
            }
            if (CurrentSilentConfig.DisableNetworkThrottling)
            {
                Optimize.DisableNetworkThrottling();
            }
            else
            {
                Optimize.EnableNetworkThrottling();
            }
            if (CurrentSilentConfig.DisableWindowsDefender)
            {
                Optimize.DisableDefender();
            }
            else
            {
                Optimize.EnableDefender();
            }
            if (CurrentSilentConfig.DisableSystemRestore)
            {
                Optimize.DisableSystemRestore();
            }
            else
            {
                Optimize.EnableSystemRestore();
            }
            if (CurrentSilentConfig.DisablePrintService)
            {
                Optimize.DisablePrintService();
            }
            else
            {
                Optimize.EnablePrintService();
            }
            if (CurrentSilentConfig.DisableMediaPlayerSharing)
            {
                Optimize.DisableMediaPlayerSharing();
            }
            else
            {
                Optimize.EnableMediaPlayerSharing();
            }
            if (CurrentSilentConfig.BlockSkypeAds)
            {
                Optimize.DisableSkypeAds();
            }
            else
            {
                Optimize.EnableSkypeAds();
            }
            if (CurrentSilentConfig.DisableErrorReporting)
            {
                Optimize.DisableErrorReporting();
            }
            else
            {
                Optimize.EnableErrorReporting();
            }
            if (CurrentSilentConfig.DisableHomeGroup)
            {
                Optimize.DisableHomeGroup();
            }
            else
            {
                Optimize.EnableHomeGroup();
            }
            if (CurrentSilentConfig.DisableSuperfetch)
            {
                Optimize.DisableSuperfetch();
            }
            else
            {
                Optimize.EnableSuperfetch();
            }
            if (CurrentSilentConfig.DisableTelemetryTasks)
            {
                Optimize.DisableTelemetryTasks();
            }
            else
            {
                Optimize.EnableTelemetryTasks();
            }
            if (CurrentSilentConfig.DisableOffice2016Telemetry)
            {
                Optimize.DisableOffice2016Telemetry();
            }
            else
            {
                Optimize.EnableOffice2016Telemetry();
            }
            if (CurrentSilentConfig.DisableCompatibilityAssistant)
            {
                Optimize.DisableCompatibilityAssistant();
            }
            else
            {
                Optimize.EnableCompatibilityAssistant();
            }
            if (CurrentSilentConfig.DisableFaxService)
            {
                Optimize.DisableFaxService();
            }
            else
            {
                Optimize.EnableFaxService();
            }
            if (CurrentSilentConfig.DisableSmartScreen)
            {
                Optimize.DisableSmartScreen();
            }
            else
            {
                Optimize.EnableSmartScreen();
            }
            if (CurrentSilentConfig.DisableStickyKeys)
            {
                Optimize.DisableStickyKeys();
            }
            else
            {
                Optimize.EnableStickyKeys();
            }
        }

        // silent config processing for Windows 8 tweaks
        internal static void ProcessSilentConfigWindows8()
        {
            if (CurrentSilentConfig.DisableOneDrive)
            {
                Optimize.DisableOneDrive();
            }
            else
            {
                Optimize.EnableOneDrive();
            }
        }

        // silent config processing for Windows 10 tweaks
        internal static void ProcessSilentConfigWindows10()
        {
            if (CurrentSilentConfig.EnableLegacyVolumeSlider)
            {
                Optimize.EnableLegacyVolumeSlider();
            }
            else
            {
                Optimize.DisableLegacyVolumeSlider();
            }
            if (CurrentSilentConfig.EnableTaskbarColor)
            {
                Optimize.EnableTaskbarColor();
            }
            else
            {
                Optimize.DisableTaskbarColor();
            }
            if (CurrentSilentConfig.DisableQuickAccessHistory)
            {
                Optimize.DisableQuickAccessHistory();
            }
            else
            {
                Optimize.EnableQuickAccessHistory();
            }
            if (CurrentSilentConfig.DisableStartMenuAds)
            {
                Optimize.DisableStartMenuAds();
            }
            else
            {
                Optimize.EnableStartMenuAds();
            }
            if (CurrentSilentConfig.EnableDarkTheme)
            {
                Optimize.EnableDarkTheme();
            }
            else
            {
                Optimize.EnableLightTheme();
            }
            if (CurrentSilentConfig.UninstallOneDrive)
            {
                Task t = new Task(() => Optimize.UninstallOneDrive());
                t.Start();
            }
            else
            {
                Task t = new Task(() => Optimize.InstallOneDrive());
                t.Start();
            }
            if (CurrentSilentConfig.DisableMyPeople)
            {
                Optimize.DisableMyPeople();
            }
            else
            {
                Optimize.EnableMyPeople();
            }
            if (CurrentSilentConfig.EnableLongPaths)
            {
                Optimize.EnableLongPaths();
            }
            else
            {
                Optimize.DisableLongPaths();
            }
            if (CurrentSilentConfig.DisableAutomaticUpdates)
            {
                Optimize.DisableAutomaticUpdates();
            }
            else
            {
                Optimize.EnableAutomaticUpdates();
            }
            if (CurrentSilentConfig.ExcludeDrivers)
            {
                Optimize.ExcludeDrivers();
            }
            else
            {
                Optimize.IncludeDrivers();
            }
            if (CurrentSilentConfig.DisableTelemetryServices)
            {
                Optimize.DisableTelemetryServices();
            }
            else
            {
                Optimize.EnableTelemetryServices();
            }
            if (CurrentSilentConfig.DisablePrivacyOptions)
            {
                Optimize.DisablePrivacyOptions();
            }
            else
            {
                Optimize.EnablePrivacyOptions();
            }
            if (CurrentSilentConfig.DisableSilentAppInstall)
            {
                Optimize.DisableSilentAppInstall();
            }
            else
            {
                Optimize.EnableSilentAppInstall();
            }
            if (CurrentSilentConfig.DisableCortana)
            {
                Optimize.DisableCortana();
            }
            else
            {
                Optimize.EnableCortana();
            }
            if (CurrentSilentConfig.DisableSensorServices)
            {
                Optimize.DisableSensorServices();
            }
            else
            {
                Optimize.EnableSensorServices();
            }
            if (CurrentSilentConfig.DisableWindowsInk)
            {
                Optimize.DisableWindowsInk();
            }
            else
            {
                Optimize.EnableWindowsInk();
            }
            if (CurrentSilentConfig.DisableSpellingTyping)
            {
                Optimize.DisableSpellingAndTypingFeatures();
            }
            else
            {
                Optimize.EnableSpellingAndTypingFeatures();
            }
            if (CurrentSilentConfig.DisableXboxLive)
            {
                Optimize.DisableXboxLive();
            }
            else
            {
                Optimize.EnableXboxLive();
            }
            if (CurrentSilentConfig.DisableGameBar)
            {
                Optimize.DisableGameBar();
            }
            else
            {
                Optimize.EnableGameBar();
            }
            if (CurrentSilentConfig.DisableInsiderService)
            {
                Optimize.DisableInsiderService();
            }
            else
            {
                Optimize.EnableInsiderService();
            }
            if (CurrentSilentConfig.DisableFeatureUpdates)
            {
                Optimize.DisableForcedFeatureUpdates();
            }
            else
            {
                Optimize.EnableForcedFeatureUpdates();
            }
            if (CurrentSilentConfig.DisableCloudClipboard)
            {
                Optimize.DisableCloudClipboard();
            }
            else
            {
                Optimize.EnableCloudClipboard();
            }
        }

        // updating options using silent config
        internal static void SilentUpdateOptionsGeneral()
        {
            Options.CurrentOptions.EnablePerformanceTweaks = CurrentSilentConfig.EnablePerformanceTweaks;
            Options.CurrentOptions.DisableNetworkThrottling = CurrentSilentConfig.DisableNetworkThrottling;
            Options.CurrentOptions.DisableWindowsDefender = CurrentSilentConfig.DisableWindowsDefender;
            Options.CurrentOptions.DisableSystemRestore = CurrentSilentConfig.DisableSystemRestore;
            Options.CurrentOptions.DisablePrintService = CurrentSilentConfig.DisablePrintService;
            Options.CurrentOptions.DisableMediaPlayerSharing = CurrentSilentConfig.DisableMediaPlayerSharing;
            Options.CurrentOptions.BlockSkypeAds = CurrentSilentConfig.BlockSkypeAds;
            Options.CurrentOptions.DisableErrorReporting = CurrentSilentConfig.DisableErrorReporting;
            Options.CurrentOptions.DisableHomeGroup = CurrentSilentConfig.DisableHomeGroup;
            Options.CurrentOptions.DisableSuperfetch = CurrentSilentConfig.DisableSuperfetch;
            Options.CurrentOptions.DisableTelemetryTasks = CurrentSilentConfig.DisableTelemetryTasks;
            Options.CurrentOptions.DisableOffice2016Telemetry = CurrentSilentConfig.DisableOffice2016Telemetry;
            Options.CurrentOptions.DisableCompatibilityAssistant = CurrentSilentConfig.DisableCompatibilityAssistant;
            Options.CurrentOptions.DisableFaxService = CurrentSilentConfig.DisableFaxService;
            Options.CurrentOptions.DisableSmartScreen = CurrentSilentConfig.DisableSmartScreen;
            Options.CurrentOptions.DisableStickyKeys = CurrentSilentConfig.DisableStickyKeys;
        }

        internal static void SilentUpdateOptions8()
        {
            Options.CurrentOptions.DisableOneDrive = CurrentSilentConfig.DisableOneDrive;
        }

        internal static void SilentUpdateOptions10()
        {
            Options.CurrentOptions.EnableLegacyVolumeSlider = CurrentSilentConfig.EnableLegacyVolumeSlider;
            Options.CurrentOptions.EnableTaskbarColor = CurrentSilentConfig.EnableTaskbarColor;
            Options.CurrentOptions.DisableQuickAccessHistory = CurrentSilentConfig.DisableQuickAccessHistory;
            Options.CurrentOptions.DisableStartMenuAds = CurrentSilentConfig.DisableStartMenuAds;
            Options.CurrentOptions.EnableDarkTheme = CurrentSilentConfig.EnableDarkTheme;
            Options.CurrentOptions.UninstallOneDrive = CurrentSilentConfig.UninstallOneDrive;
            Options.CurrentOptions.DisableMyPeople = CurrentSilentConfig.DisableMyPeople;
            Options.CurrentOptions.EnableLongPaths = CurrentSilentConfig.EnableLongPaths;
            Options.CurrentOptions.DisableAutomaticUpdates = CurrentSilentConfig.DisableAutomaticUpdates;
            Options.CurrentOptions.ExcludeDrivers = CurrentSilentConfig.ExcludeDrivers;
            Options.CurrentOptions.DisableTelemetryServices = CurrentSilentConfig.DisableTelemetryServices;
            Options.CurrentOptions.DisablePrivacyOptions = CurrentSilentConfig.DisablePrivacyOptions;
            Options.CurrentOptions.DisableSilentAppInstall = CurrentSilentConfig.DisableSilentAppInstall;
            Options.CurrentOptions.DisableCortana = CurrentSilentConfig.DisableCortana;
            Options.CurrentOptions.DisableSensorServices = CurrentSilentConfig.DisableSensorServices;
            Options.CurrentOptions.DisableWindowsInk = CurrentSilentConfig.DisableWindowsInk;
            Options.CurrentOptions.DisableSpellingTyping = CurrentSilentConfig.DisableSpellingTyping;
            Options.CurrentOptions.DisableXboxLive = CurrentSilentConfig.DisableXboxLive;
            Options.CurrentOptions.DisableGameBar = CurrentSilentConfig.DisableGameBar;
            Options.CurrentOptions.DisableInsiderService = CurrentSilentConfig.DisableInsiderService;
            Options.CurrentOptions.DisableFeatureUpdates = CurrentSilentConfig.DisableFeatureUpdates;
            Options.CurrentOptions.DisableCloudClipboard = CurrentSilentConfig.DisableCloudClipboard;
        }
    }
}
