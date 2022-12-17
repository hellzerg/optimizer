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
                    Optimize.EnablePerformanceTweaks();
                }
                else
                {
                    Optimize.DisablePerformanceTweaks();
                }
            }

            if (CurrentSilentConfig.DisableNetworkThrottling.HasValue)
            {
                if (CurrentSilentConfig.DisableNetworkThrottling.Value)
                {
                    Optimize.DisableNetworkThrottling();
                }
                else
                {
                    Optimize.EnableNetworkThrottling();
                }
            }

            if (CurrentSilentConfig.DisableWindowsDefender.HasValue)
            {
                if (CurrentSilentConfig.DisableWindowsDefender.Value)
                {
                    Optimize.DisableDefender();
                }
                else
                {
                    Optimize.EnableDefender();
                }
            }

            if (CurrentSilentConfig.DisableSystemRestore.HasValue)
            {
                if (CurrentSilentConfig.DisableSystemRestore.Value)
                {
                    Optimize.DisableSystemRestore();
                }
                else
                {
                    Optimize.EnableSystemRestore();
                }
            }

            if (CurrentSilentConfig.DisablePrintService.HasValue)
            {
                if (CurrentSilentConfig.DisablePrintService.Value)
                {
                    Optimize.DisablePrintService();
                }
                else
                {
                    Optimize.EnablePrintService();
                }
            }

            if (CurrentSilentConfig.DisableMediaPlayerSharing.HasValue)
            {
                if (CurrentSilentConfig.DisableMediaPlayerSharing.Value)
                {
                    Optimize.DisableMediaPlayerSharing();
                }
                else
                {
                    Optimize.EnableMediaPlayerSharing();
                }
            }

            if (CurrentSilentConfig.DisableErrorReporting.HasValue)
            {
                if (CurrentSilentConfig.DisableErrorReporting.Value)
                {
                    Optimize.DisableErrorReporting();
                }
                else
                {
                    Optimize.EnableErrorReporting();
                }
            }

            if (CurrentSilentConfig.DisableHomeGroup.HasValue)
            {
                if (CurrentSilentConfig.DisableHomeGroup.Value)
                {
                    Optimize.DisableHomeGroup();
                }
                else
                {
                    Optimize.EnableHomeGroup();
                }
            }

            if (CurrentSilentConfig.DisableSuperfetch.HasValue)
            {
                if (CurrentSilentConfig.DisableSuperfetch.Value)
                {
                    Optimize.DisableSuperfetch();
                }
                else
                {
                    Optimize.EnableSuperfetch();
                }
            }

            if (CurrentSilentConfig.DisableTelemetryTasks.HasValue)
            {
                if (CurrentSilentConfig.DisableTelemetryTasks.Value)
                {
                    Optimize.DisableTelemetryTasks();
                }
                else
                {
                    Optimize.EnableTelemetryTasks();
                }
            }

            if (CurrentSilentConfig.DisableOffice2016Telemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableOffice2016Telemetry.Value)
                {
                    Optimize.DisableOffice2016Telemetry();
                }
                else
                {
                    Optimize.EnableOffice2016Telemetry();
                }
            }

            if (CurrentSilentConfig.DisableCompatibilityAssistant.HasValue)
            {
                if (CurrentSilentConfig.DisableCompatibilityAssistant.Value)
                {
                    Optimize.DisableCompatibilityAssistant();
                }
                else
                {
                    Optimize.EnableCompatibilityAssistant();
                }
            }

            if (CurrentSilentConfig.DisableFaxService.HasValue)
            {
                if (CurrentSilentConfig.DisableFaxService.Value)
                {
                    Optimize.DisableFaxService();
                }
                else
                {
                    Optimize.EnableFaxService();
                }
            }

            if (CurrentSilentConfig.DisableSmartScreen.HasValue)
            {
                if (CurrentSilentConfig.DisableSmartScreen.Value)
                {
                    Optimize.DisableSmartScreen();
                }
                else
                {
                    Optimize.EnableSmartScreen();
                }
            }

            if (CurrentSilentConfig.DisableStickyKeys.HasValue)
            {
                if (CurrentSilentConfig.DisableStickyKeys.Value)
                {
                    Optimize.DisableStickyKeys();
                }
                else
                {
                    Optimize.EnableStickyKeys();
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
                    Optimize.DisableSMB("1");
                }
                else
                {
                    Optimize.EnableSMB("1");
                }
            }

            if (CurrentSilentConfig.DisableSMB2.HasValue)
            {
                if (CurrentSilentConfig.DisableSMB2.Value)
                {
                    Optimize.DisableSMB("2");
                }
                else
                {
                    Optimize.EnableSMB("2");
                }
            }

            if (CurrentSilentConfig.DisableNTFSTimeStamp.HasValue)
            {
                if (CurrentSilentConfig.DisableNTFSTimeStamp.Value)
                {
                    Optimize.DisableNTFSTimeStamp();
                }
                else
                {
                    Optimize.EnableNTFSTimeStamp();
                }
            }

            if (CurrentSilentConfig.DisableSearch.HasValue)
            {
                if (CurrentSilentConfig.DisableSearch.Value)
                {
                    Optimize.DisableSearch();
                }
                else
                {
                    Optimize.EnableSearch();
                }
            }

            if (CurrentSilentConfig.DisableChromeTelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableChromeTelemetry.Value)
                {
                    Optimize.DisableChromeTelemetry();
                }
                else
                {
                    Optimize.EnableChromeTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableFirefoxTemeletry.HasValue)
            {
                if (CurrentSilentConfig.DisableFirefoxTemeletry.Value)
                {
                    Optimize.DisableFirefoxTelemetry();
                }
                else
                {
                    Optimize.EnableFirefoxTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableVisualStudioTelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableVisualStudioTelemetry.Value)
                {
                    Optimize.DisableVisualStudioTelemetry();
                }
                else
                {
                    Optimize.EnableVisualStudioTelemetry();
                }
            }

            if (CurrentSilentConfig.DisableNVIDIATelemetry.HasValue)
            {
                if (CurrentSilentConfig.DisableNVIDIATelemetry.Value)
                {
                    Optimize.DisableNvidiaTelemetry();
                }
                else
                {
                    Optimize.EnableNvidiaTelemetry();
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
                    Optimize.DisableOneDrive();
                }
                else
                {
                    Optimize.EnableOneDrive();
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
                    Optimize.EnableGamingMode();
                }
                else
                {
                    Optimize.DisableGamingMode();
                }
            }

            if (CurrentSilentConfig.EnableLegacyVolumeSlider.HasValue)
            {
                if (CurrentSilentConfig.EnableLegacyVolumeSlider.Value)
                {
                    Optimize.EnableLegacyVolumeSlider();
                }
                else
                {
                    Optimize.DisableLegacyVolumeSlider();
                }
            }

            if (CurrentSilentConfig.DisableQuickAccessHistory.HasValue)
            {
                if (CurrentSilentConfig.DisableQuickAccessHistory.Value)
                {
                    Optimize.DisableQuickAccessHistory();
                }
                else
                {
                    Optimize.EnableQuickAccessHistory();
                }
            }

            if (CurrentSilentConfig.DisableStartMenuAds.HasValue)
            {
                if (CurrentSilentConfig.DisableStartMenuAds.Value)
                {
                    Optimize.DisableStartMenuAds();
                }
                else
                {
                    Optimize.EnableStartMenuAds();
                }
            }

            if (CurrentSilentConfig.UninstallOneDrive.HasValue)
            {
                if (CurrentSilentConfig.UninstallOneDrive.Value)
                {
                    Task t = new Task(() => Optimize.UninstallOneDrive());
                    t.Start();
                }
                else
                {
                    Task t = new Task(() => Optimize.InstallOneDrive());
                    t.Start();
                }
            }

            if (CurrentSilentConfig.DisableMyPeople.HasValue)
            {
                if (CurrentSilentConfig.DisableMyPeople.Value)
                {
                    Optimize.DisableMyPeople();
                }
                else
                {
                    Optimize.EnableMyPeople();
                }
            }

            if (CurrentSilentConfig.EnableLongPaths.HasValue)
            {
                if (CurrentSilentConfig.EnableLongPaths.Value)
                {
                    Optimize.EnableLongPaths();
                }
                else
                {
                    Optimize.DisableLongPaths();
                }
            }

            if (CurrentSilentConfig.DisableAutomaticUpdates.HasValue)
            {
                if (CurrentSilentConfig.DisableAutomaticUpdates.Value)
                {
                    Optimize.DisableAutomaticUpdates();
                }
                else
                {
                    Optimize.EnableAutomaticUpdates();
                }
            }

            if (CurrentSilentConfig.ExcludeDrivers.HasValue)
            {
                if (CurrentSilentConfig.ExcludeDrivers.Value)
                {
                    Optimize.ExcludeDrivers();
                }
                else
                {
                    Optimize.IncludeDrivers();
                }
            }

            if (CurrentSilentConfig.DisableTelemetryServices.HasValue)
            {
                if (CurrentSilentConfig.DisableTelemetryServices.Value)
                {
                    Optimize.DisableTelemetryServices();
                }
                else
                {
                    Optimize.EnableTelemetryServices();
                }
            }

            if (CurrentSilentConfig.DisablePrivacyOptions.HasValue)
            {
                if (CurrentSilentConfig.DisablePrivacyOptions.Value)
                {
                    Optimize.EnhancePrivacy();
                }
                else
                {
                    Optimize.CompromisePrivacy();
                }
            }

            if (CurrentSilentConfig.DisableCortana.HasValue)
            {
                if (CurrentSilentConfig.DisableCortana.Value)
                {
                    Optimize.DisableCortana();
                }
                else
                {
                    Optimize.EnableCortana();
                }
            }

            if (CurrentSilentConfig.DisableSensorServices.HasValue)
            {
                if (CurrentSilentConfig.DisableSensorServices.Value)
                {
                    Optimize.DisableSensorServices();
                }
                else
                {
                    Optimize.EnableSensorServices();
                }
            }

            if (CurrentSilentConfig.DisableWindowsInk.HasValue)
            {
                if (CurrentSilentConfig.DisableWindowsInk.Value)
                {
                    Optimize.DisableWindowsInk();
                }
                else
                {
                    Optimize.EnableWindowsInk();
                }
            }

            if (CurrentSilentConfig.DisableSpellingTyping.HasValue)
            {
                if (CurrentSilentConfig.DisableSpellingTyping.Value)
                {
                    Optimize.DisableSpellingAndTypingFeatures();
                }
                else
                {
                    Optimize.EnableSpellingAndTypingFeatures();
                }
            }

            if (CurrentSilentConfig.DisableXboxLive.HasValue)
            {
                if (CurrentSilentConfig.DisableXboxLive.Value)
                {
                    Optimize.DisableXboxLive();
                }
                else
                {
                    Optimize.EnableXboxLive();
                }
            }

            if (CurrentSilentConfig.DisableGameBar.HasValue)
            {
                if (CurrentSilentConfig.DisableGameBar.Value)
                {
                    Optimize.DisableGameBar();
                }
                else
                {
                    Optimize.EnableGameBar();
                }
            }

            if (CurrentSilentConfig.DisableInsiderService.HasValue)
            {
                if (CurrentSilentConfig.DisableInsiderService.Value)
                {
                    Optimize.DisableInsiderService();
                }
                else
                {
                    Optimize.EnableInsiderService();
                }
            }

            if (CurrentSilentConfig.DisableStoreUpdates.HasValue)
            {
                if (CurrentSilentConfig.DisableStoreUpdates.Value)
                {
                    Optimize.DisableStoreUpdates();
                }
                else
                {
                    Optimize.EnableStoreUpdates();
                }
            }

            if (CurrentSilentConfig.DisableCloudClipboard.HasValue)
            {
                if (CurrentSilentConfig.DisableCloudClipboard.Value)
                {
                    Optimize.DisableCloudClipboard();
                }
                else
                {
                    Optimize.EnableCloudClipboard();
                }
            }

            if (CurrentSilentConfig.RemoveCastToDevice.HasValue)
            {
                if (CurrentSilentConfig.RemoveCastToDevice.Value)
                {
                    Optimize.RemoveCastToDevice();
                }
                else
                {
                    Optimize.AddCastToDevice();
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
                    Optimize.AlignTaskbarToLeft();
                }
                else
                {
                    Optimize.AlignTaskbarToCenter();
                }
            }

            if (CurrentSilentConfig.DisableStickers.HasValue)
            {
                if (CurrentSilentConfig.DisableStickers.Value)
                {
                    Optimize.DisableStickers();
                }
                else
                {
                    Optimize.EnableStickers();
                }
            }

            if (CurrentSilentConfig.CompactMode.HasValue)
            {
                if (CurrentSilentConfig.CompactMode.Value)
                {
                    Optimize.EnableFilesCompactMode();
                }
                else
                {
                    Optimize.DisableFilesCompactMode();
                }
            }

            if (CurrentSilentConfig.DisableSnapAssist.HasValue)
            {
                if (CurrentSilentConfig.DisableSnapAssist.Value)
                {
                    Optimize.DisableSnapAssist();
                }
                else
                {
                    Optimize.EnableSnapAssist();
                }
            }

            if (CurrentSilentConfig.DisableWidgets.HasValue)
            {
                if (CurrentSilentConfig.DisableWidgets.Value)
                {
                    Optimize.DisableWidgets();
                }
                else
                {
                    Optimize.EnableWidgets();
                }
            }

            if (CurrentSilentConfig.DisableChat.HasValue)
            {
                if (CurrentSilentConfig.DisableChat.Value)
                {
                    Optimize.DisableChat();
                }
                else
                {
                    Optimize.EnableChat();
                }
            }

            if (CurrentSilentConfig.TaskbarSmaller.HasValue)
            {
                if (CurrentSilentConfig.TaskbarSmaller.Value)
                {
                    Optimize.SmallerTaskbar();
                }
                else
                {
                    Optimize.DefaultTaskbarSize();
                }
            }

            if (CurrentSilentConfig.DisableVBS.HasValue)
            {
                if (CurrentSilentConfig.DisableVBS.Value)
                {
                    Optimize.DisableVirtualizationBasedSecurity();
                }
                else
                {
                    Optimize.EnableVirtualizationBasedSecurity();
                }
            }

            if (CurrentSilentConfig.ClassicRibbon.HasValue)
            {
                if (CurrentSilentConfig.ClassicRibbon.Value)
                {
                    Optimize.EnableFileExplorerClassicRibbon();
                }
                else
                {
                    Optimize.DisableFileExplorerClassicRibbon();
                }
            }

            if (CurrentSilentConfig.ClassicMenu.HasValue)
            {
                if (CurrentSilentConfig.ClassicMenu.Value)
                {
                    Optimize.DisableShowMoreOptions();
                }
                else
                {
                    Optimize.EnableShowMoreOptions();
                }
            }

            if (CurrentSilentConfig.DisableTPMCheck.HasValue)
            {
                if (CurrentSilentConfig.DisableTPMCheck.Value)
                {
                    Optimize.DisableTPMCheck();
                }
                else
                {
                    Optimize.EnableTPMCheck();
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
            if (CurrentSilentConfig.TaskbarSmaller.HasValue)
            {
                Options.CurrentOptions.TaskbarSmaller = CurrentSilentConfig.TaskbarSmaller.Value;
            }
            if (CurrentSilentConfig.ClassicRibbon.HasValue)
            {
                Options.CurrentOptions.ClassicRibbon = CurrentSilentConfig.ClassicRibbon.Value;
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
