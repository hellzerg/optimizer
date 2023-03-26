using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

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
            catch (Exception ex)
            {
                ErrorLogger.LogError("SilentOps.GetSilentConfig", ex.Message, ex.StackTrace);
                CurrentSilentConfig = null;
            }
            return CurrentSilentConfig;
        }

        // silent config processing for universal tweaks
        internal static void ProcessSilentConfigGeneral()
        {
            if (CurrentSilentConfig.EnablePerformanceTweaks.HasValue)
            {
                if (CurrentSilentConfig.EnablePerformanceTweaks.Value)
                {
                    OptimizeHelper.EnablePerformanceTweaks();
                }
                else
                {
                    OptimizeHelper.DisablePerformanceTweaks();
                }
            }

            if (CurrentSilentConfig.DisableNetworkThrottling.HasValue)
            {
                if (CurrentSilentConfig.DisableNetworkThrottling.Value)
                {
                    OptimizeHelper.DisableNetworkThrottling();
                }
                else
                {
                    OptimizeHelper.EnableNetworkThrottling();
                }
            }

            if (CurrentSilentConfig.DisableWindowsDefender.HasValue)
            {
                if (CurrentSilentConfig.DisableWindowsDefender.Value)
                {
                    OptimizeHelper.DisableDefender();
                }
                else
                {
                    OptimizeHelper.EnableDefender();
                }
            }

            if (CurrentSilentConfig.DisableSystemRestore.HasValue)
            {
                if (CurrentSilentConfig.DisableSystemRestore.Value)
                {
                    OptimizeHelper.DisableSystemRestore();
                }
                else
                {
                    OptimizeHelper.EnableSystemRestore();
                }
            }

            if (CurrentSilentConfig.DisablePrintService.HasValue)
            {
                if (CurrentSilentConfig.DisablePrintService.Value)
                {
                    OptimizeHelper.DisablePrintService();
                }
                else
                {
                    OptimizeHelper.EnablePrintService();
                }
            }

            if (CurrentSilentConfig.DisableMediaPlayerSharing.HasValue)
            {
                if (CurrentSilentConfig.DisableMediaPlayerSharing.Value)
                {
                    OptimizeHelper.DisableMediaPlayerSharing();
                }
                else
                {
                    OptimizeHelper.EnableMediaPlayerSharing();
                }
            }

            if (CurrentSilentConfig.DisableErrorReporting.HasValue)
            {
                if (CurrentSilentConfig.DisableErrorReporting.Value)
                {
                    OptimizeHelper.DisableErrorReporting();
                }
                else
                {
                    OptimizeHelper.EnableErrorReporting();
                }
            }

            if (CurrentSilentConfig.DisableHomeGroup.HasValue)
            {
                if (CurrentSilentConfig.DisableHomeGroup.Value)
                {
                    OptimizeHelper.DisableHomeGroup();
                }
                else
                {
                    OptimizeHelper.EnableHomeGroup();
                }
            }

            if (CurrentSilentConfig.DisableSuperfetch.HasValue)
            {
                if (CurrentSilentConfig.DisableSuperfetch.Value)
                {
                    OptimizeHelper.DisableSuperfetch();
                }
                else
                {
                    OptimizeHelper.EnableSuperfetch();
                }
            }

            if (CurrentSilentConfig.DisableTelemetryTasks.HasValue)
            {
                if (CurrentSilentConfig.DisableTelemetryTasks.Value)
                {
                    OptimizeHelper.DisableTelemetryTasks();
                }
                else
                {
                    OptimizeHelper.EnableTelemetryTasks();
                }
            }

            if (CurrentSilentConfig.DisableOffice2016Telemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableOffice2016Telemetry.Value)
                {
                    OptimizeHelper.DisableOffice2016Telemetry();
                }
                else
                {
                    OptimizeHelper.EnableOffice2016Telemetry();
                }
            }

            if (CurrentSilentConfig.DisableCompatibilityAssistant.HasValue)
            {
                if (CurrentSilentConfig.DisableCompatibilityAssistant.Value)
                {
                    OptimizeHelper.DisableCompatibilityAssistant();
                }
                else
                {
                    OptimizeHelper.EnableCompatibilityAssistant();
                }
            }

            if (CurrentSilentConfig.DisableFaxService.HasValue)
            {
                if (CurrentSilentConfig.DisableFaxService.Value)
                {
                    OptimizeHelper.DisableFaxService();
                }
                else
                {
                    OptimizeHelper.EnableFaxService();
                }
            }

            if (CurrentSilentConfig.DisableSmartScreen.HasValue)
            {
                if (CurrentSilentConfig.DisableSmartScreen.Value)
                {
                    OptimizeHelper.DisableSmartScreen();
                }
                else
                {
                    OptimizeHelper.EnableSmartScreen();
                }
            }

            if (CurrentSilentConfig.DisableStickyKeys.HasValue)
            {
                if (CurrentSilentConfig.DisableStickyKeys.Value)
                {
                    OptimizeHelper.DisableStickyKeys();
                }
                else
                {
                    OptimizeHelper.EnableStickyKeys();
                }
            }

            if (CurrentSilentConfig.DisableHibernation.HasValue)
            {
                if (CurrentSilentConfig.DisableHibernation.Value)
                {
                    Utilities.DisableHibernation();
                }
                else
                {
                    Utilities.EnableHibernation();
                }
            }

            if (CurrentSilentConfig.DisableSMB1.HasValue)
            {
                if (CurrentSilentConfig.DisableSMB1.Value)
                {
                    OptimizeHelper.DisableSMB("1");
                }
                else
                {
                    OptimizeHelper.EnableSMB("1");
                }
            }

            if (CurrentSilentConfig.DisableSMB2.HasValue)
            {
                if (CurrentSilentConfig.DisableSMB2.Value)
                {
                    OptimizeHelper.DisableSMB("2");
                }
                else
                {
                    OptimizeHelper.EnableSMB("2");
                }
            }

            if (CurrentSilentConfig.DisableNTFSTimeStamp.HasValue)
            {
                if (CurrentSilentConfig.DisableNTFSTimeStamp.Value)
                {
                    OptimizeHelper.DisableNTFSTimeStamp();
                }
                else
                {
                    OptimizeHelper.EnableNTFSTimeStamp();
                }
            }

            if (CurrentSilentConfig.DisableSearch.HasValue)
            {
                if (CurrentSilentConfig.DisableSearch.Value)
                {
                    OptimizeHelper.DisableSearch();
                }
                else
                {
                    OptimizeHelper.EnableSearch();
                }
            }

            if (CurrentSilentConfig.DisableChromeTelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableChromeTelemetry.Value)
                {
                    OptimizeHelper.DisableChromeTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableChromeTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableFirefoxTemeletry.HasValue)
            {
                if (CurrentSilentConfig.DisableFirefoxTemeletry.Value)
                {
                    OptimizeHelper.DisableFirefoxTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableFirefoxTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableVisualStudioTelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableVisualStudioTelemetry.Value)
                {
                    OptimizeHelper.DisableVisualStudioTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableVisualStudioTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableNVIDIATelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableNVIDIATelemetry.Value)
                {
                    OptimizeHelper.DisableNvidiaTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableNvidiaTelemetry();
                }
            }
        }

        // silent config processing for Windows 8 tweaks
        internal static void ProcessSilentConfigWindows8()
        {
            if (CurrentSilentConfig.DisableOneDrive.HasValue)
            {
                if (CurrentSilentConfig.DisableOneDrive.Value)
                {
                    OptimizeHelper.DisableOneDrive();
                }
                else
                {
                    OptimizeHelper.EnableOneDrive();
                }
            }

        }

        // silent config processing for Windows 10 tweaks
        internal static void ProcessSilentConfigWindows10()
        {
            if (CurrentSilentConfig.EnableGamingMode.HasValue)
            {
                if (CurrentSilentConfig.EnableGamingMode.Value)
                {
                    OptimizeHelper.EnableGamingMode();
                }
                else
                {
                    OptimizeHelper.DisableGamingMode();
                }
            }

            if (CurrentSilentConfig.EnableLegacyVolumeSlider.HasValue)
            {
                if (CurrentSilentConfig.EnableLegacyVolumeSlider.Value)
                {
                    OptimizeHelper.EnableLegacyVolumeSlider();
                }
                else
                {
                    OptimizeHelper.DisableLegacyVolumeSlider();
                }
            }

            if (CurrentSilentConfig.DisableQuickAccessHistory.HasValue)
            {
                if (CurrentSilentConfig.DisableQuickAccessHistory.Value)
                {
                    OptimizeHelper.DisableQuickAccessHistory();
                }
                else
                {
                    OptimizeHelper.EnableQuickAccessHistory();
                }
            }

            if (CurrentSilentConfig.DisableStartMenuAds.HasValue)
            {
                if (CurrentSilentConfig.DisableStartMenuAds.Value)
                {
                    OptimizeHelper.DisableStartMenuAds();
                }
                else
                {
                    OptimizeHelper.EnableStartMenuAds();
                }
            }

            if (CurrentSilentConfig.UninstallOneDrive.HasValue)
            {
                if (CurrentSilentConfig.UninstallOneDrive.Value)
                {
                    Task t = new Task(() => OptimizeHelper.UninstallOneDrive());
                    t.Start();
                }
                else
                {
                    Task t = new Task(() => OptimizeHelper.InstallOneDrive());
                    t.Start();
                }
            }

            if (CurrentSilentConfig.DisableMyPeople.HasValue)
            {
                if (CurrentSilentConfig.DisableMyPeople.Value)
                {
                    OptimizeHelper.DisableMyPeople();
                }
                else
                {
                    OptimizeHelper.EnableMyPeople();
                }
            }

            if (CurrentSilentConfig.EnableLongPaths.HasValue)
            {
                if (CurrentSilentConfig.EnableLongPaths.Value)
                {
                    OptimizeHelper.EnableLongPaths();
                }
                else
                {
                    OptimizeHelper.DisableLongPaths();
                }
            }

            if (CurrentSilentConfig.DisableAutomaticUpdates.HasValue)
            {
                if (CurrentSilentConfig.DisableAutomaticUpdates.Value)
                {
                    OptimizeHelper.DisableAutomaticUpdates();
                }
                else
                {
                    OptimizeHelper.EnableAutomaticUpdates();
                }
            }

            if (CurrentSilentConfig.ExcludeDrivers.HasValue)
            {
                if (CurrentSilentConfig.ExcludeDrivers.Value)
                {
                    OptimizeHelper.ExcludeDrivers();
                }
                else
                {
                    OptimizeHelper.IncludeDrivers();
                }
            }

            if (CurrentSilentConfig.DisableTelemetryServices.HasValue)
            {
                if (CurrentSilentConfig.DisableTelemetryServices.Value)
                {
                    OptimizeHelper.DisableTelemetryServices();
                }
                else
                {
                    OptimizeHelper.EnableTelemetryServices();
                }
            }

            if (CurrentSilentConfig.DisablePrivacyOptions.HasValue)
            {
                if (CurrentSilentConfig.DisablePrivacyOptions.Value)
                {
                    OptimizeHelper.EnhancePrivacy();
                }
                else
                {
                    OptimizeHelper.CompromisePrivacy();
                }
            }

            if (CurrentSilentConfig.DisableCortana.HasValue)
            {
                if (CurrentSilentConfig.DisableCortana.Value)
                {
                    OptimizeHelper.DisableCortana();
                }
                else
                {
                    OptimizeHelper.EnableCortana();
                }
            }

            if (CurrentSilentConfig.DisableSensorServices.HasValue)
            {
                if (CurrentSilentConfig.DisableSensorServices.Value)
                {
                    OptimizeHelper.DisableSensorServices();
                }
                else
                {
                    OptimizeHelper.EnableSensorServices();
                }
            }

            if (CurrentSilentConfig.DisableWindowsInk.HasValue)
            {
                if (CurrentSilentConfig.DisableWindowsInk.Value)
                {
                    OptimizeHelper.DisableWindowsInk();
                }
                else
                {
                    OptimizeHelper.EnableWindowsInk();
                }
            }

            if (CurrentSilentConfig.DisableSpellingTyping.HasValue)
            {
                if (CurrentSilentConfig.DisableSpellingTyping.Value)
                {
                    OptimizeHelper.DisableSpellingAndTypingFeatures();
                }
                else
                {
                    OptimizeHelper.EnableSpellingAndTypingFeatures();
                }
            }

            if (CurrentSilentConfig.DisableXboxLive.HasValue)
            {
                if (CurrentSilentConfig.DisableXboxLive.Value)
                {
                    OptimizeHelper.DisableXboxLive();
                }
                else
                {
                    OptimizeHelper.EnableXboxLive();
                }
            }

            if (CurrentSilentConfig.DisableGameBar.HasValue)
            {
                if (CurrentSilentConfig.DisableGameBar.Value)
                {
                    OptimizeHelper.DisableGameBar();
                }
                else
                {
                    OptimizeHelper.EnableGameBar();
                }
            }

            if (CurrentSilentConfig.DisableInsiderService.HasValue)
            {
                if (CurrentSilentConfig.DisableInsiderService.Value)
                {
                    OptimizeHelper.DisableInsiderService();
                }
                else
                {
                    OptimizeHelper.EnableInsiderService();
                }
            }

            if (CurrentSilentConfig.DisableStoreUpdates.HasValue)
            {
                if (CurrentSilentConfig.DisableStoreUpdates.Value)
                {
                    OptimizeHelper.DisableStoreUpdates();
                }
                else
                {
                    OptimizeHelper.EnableStoreUpdates();
                }
            }

            if (CurrentSilentConfig.DisableCloudClipboard.HasValue)
            {
                if (CurrentSilentConfig.DisableCloudClipboard.Value)
                {
                    OptimizeHelper.DisableCloudClipboard();
                }
                else
                {
                    OptimizeHelper.EnableCloudClipboard();
                }
            }

            if (CurrentSilentConfig.RemoveCastToDevice.HasValue)
            {
                if (CurrentSilentConfig.RemoveCastToDevice.Value)
                {
                    OptimizeHelper.RemoveCastToDevice();
                }
                else
                {
                    OptimizeHelper.AddCastToDevice();
                }
            }
        }

        // silent config processing for Windows 11 tweaks
        internal static void ProcessSilentConfigWindows11()
        {
            if (CurrentSilentConfig.TaskbarToLeft.HasValue)
            {
                if (CurrentSilentConfig.TaskbarToLeft.Value)
                {
                    OptimizeHelper.AlignTaskbarToLeft();
                }
                else
                {
                    OptimizeHelper.AlignTaskbarToCenter();
                }
            }

            if (CurrentSilentConfig.DisableStickers.HasValue)
            {
                if (CurrentSilentConfig.DisableStickers.Value)
                {
                    OptimizeHelper.DisableStickers();
                }
                else
                {
                    OptimizeHelper.EnableStickers();
                }
            }

            if (CurrentSilentConfig.CompactMode.HasValue)
            {
                if (CurrentSilentConfig.CompactMode.Value)
                {
                    OptimizeHelper.EnableFilesCompactMode();
                }
                else
                {
                    OptimizeHelper.DisableFilesCompactMode();
                }
            }

            if (CurrentSilentConfig.DisableSnapAssist.HasValue)
            {
                if (CurrentSilentConfig.DisableSnapAssist.Value)
                {
                    OptimizeHelper.DisableSnapAssist();
                }
                else
                {
                    OptimizeHelper.EnableSnapAssist();
                }
            }

            if (CurrentSilentConfig.DisableWidgets.HasValue)
            {
                if (CurrentSilentConfig.DisableWidgets.Value)
                {
                    OptimizeHelper.DisableWidgets();
                }
                else
                {
                    OptimizeHelper.EnableWidgets();
                }
            }

            if (CurrentSilentConfig.DisableChat.HasValue)
            {
                if (CurrentSilentConfig.DisableChat.Value)
                {
                    OptimizeHelper.DisableChat();
                }
                else
                {
                    OptimizeHelper.EnableChat();
                }
            }

            if (CurrentSilentConfig.DisableVBS.HasValue)
            {
                if (CurrentSilentConfig.DisableVBS.Value)
                {
                    OptimizeHelper.DisableVirtualizationBasedSecurity();
                }
                else
                {
                    OptimizeHelper.EnableVirtualizationBasedSecurity();
                }
            }

            if (CurrentSilentConfig.ClassicMenu.HasValue)
            {
                if (CurrentSilentConfig.ClassicMenu.Value)
                {
                    OptimizeHelper.DisableShowMoreOptions();
                }
                else
                {
                    OptimizeHelper.EnableShowMoreOptions();
                }
            }

            if (CurrentSilentConfig.DisableTPMCheck.HasValue)
            {
                if (CurrentSilentConfig.DisableTPMCheck.Value)
                {
                    OptimizeHelper.DisableTPMCheck();
                }
                else
                {
                    OptimizeHelper.EnableTPMCheck();
                }
            }
        }

        // updating options using silent config
        internal static void SilentUpdateOptionsGeneral()
        {
            if (CurrentSilentConfig.EnablePerformanceTweaks.HasValue)
            {
                Options.CurrentOptions.EnablePerformanceTweaks = CurrentSilentConfig.EnablePerformanceTweaks.Value;
            }
            if (CurrentSilentConfig.DisableNetworkThrottling.HasValue)
            {
                Options.CurrentOptions.DisableNetworkThrottling = CurrentSilentConfig.DisableNetworkThrottling.Value;
            }
            if (CurrentSilentConfig.DisableWindowsDefender.HasValue)
            {
                Options.CurrentOptions.DisableWindowsDefender = CurrentSilentConfig.DisableWindowsDefender.Value;
            }
            if (CurrentSilentConfig.DisableSystemRestore.HasValue)
            {
                Options.CurrentOptions.DisableSystemRestore = CurrentSilentConfig.DisableSystemRestore.Value;
            }
            if (CurrentSilentConfig.DisablePrintService.HasValue)
            {
                Options.CurrentOptions.DisablePrintService = CurrentSilentConfig.DisablePrintService.Value;
            }
            if (CurrentSilentConfig.DisableMediaPlayerSharing.HasValue)
            {
                Options.CurrentOptions.DisableMediaPlayerSharing = CurrentSilentConfig.DisableMediaPlayerSharing.Value;
            }
            if (CurrentSilentConfig.DisableErrorReporting.HasValue)
            {
                Options.CurrentOptions.DisableErrorReporting = CurrentSilentConfig.DisableErrorReporting.Value;
            }
            if (CurrentSilentConfig.DisableHomeGroup.HasValue)
            {
                Options.CurrentOptions.DisableHomeGroup = CurrentSilentConfig.DisableHomeGroup.Value;
            }
            if (CurrentSilentConfig.DisableSuperfetch.HasValue)
            {
                Options.CurrentOptions.DisableSuperfetch = CurrentSilentConfig.DisableSuperfetch.Value;
            }
            if (CurrentSilentConfig.DisableSearch.HasValue)
            {
                Options.CurrentOptions.DisableSearch = CurrentSilentConfig.DisableSearch.Value;
            }
            if (CurrentSilentConfig.DisableTelemetryTasks.HasValue)
            {
                Options.CurrentOptions.DisableTelemetryTasks = CurrentSilentConfig.DisableTelemetryTasks.Value;
            }
            if (CurrentSilentConfig.DisableOffice2016Telemetry.HasValue)
            {
                Options.CurrentOptions.DisableOffice2016Telemetry = CurrentSilentConfig.DisableOffice2016Telemetry.Value;
            }
            if (CurrentSilentConfig.DisableCompatibilityAssistant.HasValue)
            {
                Options.CurrentOptions.DisableCompatibilityAssistant = CurrentSilentConfig.DisableCompatibilityAssistant.Value;
            }
            if (CurrentSilentConfig.DisableFaxService.HasValue)
            {
                Options.CurrentOptions.DisableFaxService = CurrentSilentConfig.DisableFaxService.Value;
            }
            if (CurrentSilentConfig.DisableHibernation.HasValue)
            {
                Options.CurrentOptions.DisableHibernation = CurrentSilentConfig.DisableHibernation.Value;
            }
            if (CurrentSilentConfig.DisableSMB1.HasValue)
            {
                Options.CurrentOptions.DisableSMB1 = CurrentSilentConfig.DisableSMB1.Value;
            }
            if (CurrentSilentConfig.DisableSMB2.HasValue)
            {
                Options.CurrentOptions.DisableSMB2 = CurrentSilentConfig.DisableSMB2.Value;
            }
            if (CurrentSilentConfig.DisableNTFSTimeStamp.HasValue)
            {
                Options.CurrentOptions.DisableNTFSTimeStamp = CurrentSilentConfig.DisableNTFSTimeStamp.Value;
            }
            if (CurrentSilentConfig.DisableSmartScreen.HasValue)
            {
                Options.CurrentOptions.DisableSmartScreen = CurrentSilentConfig.DisableSmartScreen.Value;
            }
            if (CurrentSilentConfig.DisableStickyKeys.HasValue)
            {
                Options.CurrentOptions.DisableStickyKeys = CurrentSilentConfig.DisableStickyKeys.Value;
            }
            if (CurrentSilentConfig.DisableVisualStudioTelemetry.HasValue)
            {
                Options.CurrentOptions.DisableVisualStudioTelemetry = CurrentSilentConfig.DisableVisualStudioTelemetry.Value;
            }
            if (CurrentSilentConfig.DisableFirefoxTemeletry.HasValue)
            {
                Options.CurrentOptions.DisableFirefoxTemeletry = CurrentSilentConfig.DisableFirefoxTemeletry.Value;
            }
            if (CurrentSilentConfig.DisableChromeTelemetry.HasValue)
            {
                Options.CurrentOptions.DisableChromeTelemetry = CurrentSilentConfig.DisableChromeTelemetry.Value;
            }
            if (CurrentSilentConfig.DisableNVIDIATelemetry.HasValue)
            {
                Options.CurrentOptions.DisableNVIDIATelemetry = CurrentSilentConfig.DisableNVIDIATelemetry.Value;
            }
        }

        internal static void SilentUpdateOptions8()
        {
            if (CurrentSilentConfig.DisableOneDrive.HasValue)
            {
                Options.CurrentOptions.DisableOneDrive = CurrentSilentConfig.DisableOneDrive.Value;
            }
        }

        internal static void SilentUpdateOptions11()
        {
            if (CurrentSilentConfig.DisableStickers.HasValue)
            {
                Options.CurrentOptions.DisableStickers = CurrentSilentConfig.DisableStickers.Value;
            }
            if (CurrentSilentConfig.TaskbarToLeft.HasValue)
            {
                Options.CurrentOptions.TaskbarToLeft = CurrentSilentConfig.TaskbarToLeft.Value;
            }
            if (CurrentSilentConfig.CompactMode.HasValue)
            {
                Options.CurrentOptions.CompactMode = CurrentSilentConfig.CompactMode.Value;
            }
            if (CurrentSilentConfig.DisableSnapAssist.HasValue)
            {
                Options.CurrentOptions.DisableSnapAssist = CurrentSilentConfig.DisableSnapAssist.Value;
            }
            if (CurrentSilentConfig.DisableWidgets.HasValue)
            {
                Options.CurrentOptions.DisableWidgets = CurrentSilentConfig.DisableWidgets.Value;
            }
            if (CurrentSilentConfig.DisableChat.HasValue)
            {
                Options.CurrentOptions.DisableChat = CurrentSilentConfig.DisableChat.Value;
            }
            if (CurrentSilentConfig.ClassicMenu.HasValue)
            {
                Options.CurrentOptions.ClassicMenu = CurrentSilentConfig.ClassicMenu.Value;
            }
            if (CurrentSilentConfig.DisableTPMCheck.HasValue)
            {
                Options.CurrentOptions.DisableTPMCheck = CurrentSilentConfig.DisableTPMCheck.Value;
            }
            if (CurrentSilentConfig.DisableVBS.HasValue)
            {
                Options.CurrentOptions.DisableVBS = CurrentSilentConfig.DisableVBS.Value;
            }
        }

        internal static void SilentUpdateOptions10()
        {
            if (CurrentSilentConfig.EnableLegacyVolumeSlider.HasValue)
            {
                Options.CurrentOptions.EnableLegacyVolumeSlider = CurrentSilentConfig.EnableLegacyVolumeSlider.Value;
            }
            if (CurrentSilentConfig.EnableGamingMode.HasValue)
            {
                Options.CurrentOptions.EnableGamingMode = CurrentSilentConfig.EnableGamingMode.Value;
            }
            if (CurrentSilentConfig.DisableQuickAccessHistory.HasValue)
            {
                Options.CurrentOptions.DisableQuickAccessHistory = CurrentSilentConfig.DisableQuickAccessHistory.Value;
            }
            if (CurrentSilentConfig.DisableStartMenuAds.HasValue)
            {
                Options.CurrentOptions.DisableStartMenuAds = CurrentSilentConfig.DisableStartMenuAds.Value;
            }
            if (CurrentSilentConfig.UninstallOneDrive.HasValue)
            {
                Options.CurrentOptions.UninstallOneDrive = CurrentSilentConfig.UninstallOneDrive.Value;
            }
            if (CurrentSilentConfig.DisableMyPeople.HasValue)
            {
                Options.CurrentOptions.DisableMyPeople = CurrentSilentConfig.DisableMyPeople.Value;
            }
            if (CurrentSilentConfig.EnableLongPaths.HasValue)
            {
                Options.CurrentOptions.EnableLongPaths = CurrentSilentConfig.EnableLongPaths.Value;
            }
            if (CurrentSilentConfig.DisableAutomaticUpdates.HasValue)
            {
                Options.CurrentOptions.DisableAutomaticUpdates = CurrentSilentConfig.DisableAutomaticUpdates.Value;
            }
            if (CurrentSilentConfig.ExcludeDrivers.HasValue)
            {
                Options.CurrentOptions.ExcludeDrivers = CurrentSilentConfig.ExcludeDrivers.Value;
            }
            if (CurrentSilentConfig.DisableTelemetryServices.HasValue)
            {
                Options.CurrentOptions.DisableTelemetryServices = CurrentSilentConfig.DisableTelemetryServices.Value;
            }
            if (CurrentSilentConfig.DisablePrivacyOptions.HasValue)
            {
                Options.CurrentOptions.DisablePrivacyOptions = CurrentSilentConfig.DisablePrivacyOptions.Value;
            }
            if (CurrentSilentConfig.DisableCortana.HasValue)
            {
                Options.CurrentOptions.DisableCortana = CurrentSilentConfig.DisableCortana.Value;
            }
            if (CurrentSilentConfig.DisableSensorServices.HasValue)
            {
                Options.CurrentOptions.DisableSensorServices = CurrentSilentConfig.DisableSensorServices.Value;
            }
            if (CurrentSilentConfig.DisableWindowsInk.HasValue)
            {
                Options.CurrentOptions.DisableWindowsInk = CurrentSilentConfig.DisableWindowsInk.Value;
            }
            if (CurrentSilentConfig.DisableSpellingTyping.HasValue)
            {
                Options.CurrentOptions.DisableSpellingTyping = CurrentSilentConfig.DisableSpellingTyping.Value;
            }
            if (CurrentSilentConfig.DisableXboxLive.HasValue)
            {
                Options.CurrentOptions.DisableXboxLive = CurrentSilentConfig.DisableXboxLive.Value;
            }
            if (CurrentSilentConfig.DisableGameBar.HasValue)
            {
                Options.CurrentOptions.DisableGameBar = CurrentSilentConfig.DisableGameBar.Value;
            }
            if (CurrentSilentConfig.DisableInsiderService.HasValue)
            {
                Options.CurrentOptions.DisableInsiderService = CurrentSilentConfig.DisableInsiderService.Value;
            }
            if (CurrentSilentConfig.DisableStoreUpdates.HasValue)
            {
                Options.CurrentOptions.DisableStoreUpdates = CurrentSilentConfig.DisableStoreUpdates.Value;
            }
            if (CurrentSilentConfig.DisableCloudClipboard.HasValue)
            {
                Options.CurrentOptions.DisableCloudClipboard = CurrentSilentConfig.DisableCloudClipboard.Value;
            }
            if (CurrentSilentConfig.RemoveCastToDevice.HasValue)
            {
                Options.CurrentOptions.RemoveCastToDevice = CurrentSilentConfig.RemoveCastToDevice.Value;
            }
        }
    }
}
