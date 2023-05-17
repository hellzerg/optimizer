using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

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

        internal static void ProcessAllActions()
        {
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
            {
                ProcessTweaksGeneral();
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
            {
                ProcessTweaksGeneral();
                ProcessTweaksWindows8();
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
            {
                ProcessTweaksGeneral();
                ProcessTweaksWindows10();
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows11)
            {
                ProcessTweaksGeneral();
                ProcessTweaksWindows11();
            }

            ProcessHosts();
            ProcessPinger();
            ProcessProcessControl();
            ProcessIntegrator();
            ProcessAdvanced();
            ProcessRegistryFix();
            ProcessCleaner();
            ProcessPostAction();
        }

        internal static bool ProcessWindowsVersionCompatibility()
        {
            return CurrentSilentConfig.WindowsVersion == ((int)Utilities.CurrentWindowsVersion);
        }

        internal static void ProcessPostAction()
        {
            if (CurrentSilentConfig.PostAction.Restart.HasValue &&
                CurrentSilentConfig.PostAction.Restart.Value == true)
            {
                string restartType = CurrentSilentConfig.PostAction.RestartType;
                if (!string.IsNullOrEmpty(restartType))
                {
                    if (restartType == RestartType.Normal.ToString())
                    {
                        Program.RestartInNormalMode();
                    }
                    if (restartType == RestartType.SafeMode.ToString())
                    {
                        Program.RestartInSafeMode();
                    }
                    if (restartType == RestartType.DisableDefender.ToString())
                    {
                        Program.SetRunOnceDisableDefender();
                    }
                    if (restartType == RestartType.EnableDefender.ToString())
                    {
                        Program.SetRunOnceEnableDefender();
                    }
                }
            }
        }

        internal static void ProcessCleaner()
        {
            try
            {
                if (CurrentSilentConfig.Cleaner.TempFiles.HasValue && CurrentSilentConfig.Cleaner.TempFiles.Value) CleanHelper.PreviewTemp();
                if (CurrentSilentConfig.Cleaner.BsodDumps.HasValue && CurrentSilentConfig.Cleaner.BsodDumps.Value) CleanHelper.PreviewMinidumps();
                if (CurrentSilentConfig.Cleaner.ErrorReports.HasValue && CurrentSilentConfig.Cleaner.ErrorReports.Value) CleanHelper.PreviewErrorReports();
                if (CurrentSilentConfig.Cleaner.InternetExplorer.HasValue && CurrentSilentConfig.Cleaner.InternetExplorer.Value) CleanHelper.PreviewInternetExplorerCache();

                bool chromeCache = (CurrentSilentConfig.Cleaner.GoogleChrome.Cache.HasValue) ? CurrentSilentConfig.Cleaner.GoogleChrome.Cache.Value : false;
                bool chromeCookies = (CurrentSilentConfig.Cleaner.GoogleChrome.Cookies.HasValue) ? CurrentSilentConfig.Cleaner.GoogleChrome.Cookies.Value : false;
                bool chromeHistory = (CurrentSilentConfig.Cleaner.GoogleChrome.History.HasValue) ? CurrentSilentConfig.Cleaner.GoogleChrome.History.Value : false;
                bool chromeSession = (CurrentSilentConfig.Cleaner.GoogleChrome.Session.HasValue) ? CurrentSilentConfig.Cleaner.GoogleChrome.Session.Value : false;
                bool chromePasswords = (CurrentSilentConfig.Cleaner.GoogleChrome.Passwords.HasValue) ? CurrentSilentConfig.Cleaner.GoogleChrome.Passwords.Value : false;

                bool ffCache = (CurrentSilentConfig.Cleaner.MozillaFirefox.Cache.HasValue) ? CurrentSilentConfig.Cleaner.MozillaFirefox.Cache.Value : false;
                bool ffCookies = (CurrentSilentConfig.Cleaner.MozillaFirefox.Cookies.HasValue) ? CurrentSilentConfig.Cleaner.MozillaFirefox.Cookies.Value : false;
                bool ffHistory = (CurrentSilentConfig.Cleaner.MozillaFirefox.History.HasValue) ? CurrentSilentConfig.Cleaner.MozillaFirefox.History.Value : false;

                bool braveCache = (CurrentSilentConfig.Cleaner.BraveBrowser.Cache.HasValue) ? CurrentSilentConfig.Cleaner.BraveBrowser.Cache.Value : false;
                bool braveCookies = (CurrentSilentConfig.Cleaner.BraveBrowser.Cookies.HasValue) ? CurrentSilentConfig.Cleaner.BraveBrowser.Cookies.Value : false;
                bool braveHistory = (CurrentSilentConfig.Cleaner.BraveBrowser.History.HasValue) ? CurrentSilentConfig.Cleaner.BraveBrowser.History.Value : false;
                bool braveSession = (CurrentSilentConfig.Cleaner.BraveBrowser.Session.HasValue) ? CurrentSilentConfig.Cleaner.BraveBrowser.Session.Value : false;
                bool bravePasswords = (CurrentSilentConfig.Cleaner.BraveBrowser.Passwords.HasValue) ? CurrentSilentConfig.Cleaner.BraveBrowser.Passwords.Value : false;

                bool edgeCache = (CurrentSilentConfig.Cleaner.MicrosoftEdge.Cache.HasValue) ? CurrentSilentConfig.Cleaner.MicrosoftEdge.Cache.Value : false;
                bool edgeCookies = (CurrentSilentConfig.Cleaner.MicrosoftEdge.Cookies.HasValue) ? CurrentSilentConfig.Cleaner.MicrosoftEdge.Cookies.Value : false;
                bool edgeHistory = (CurrentSilentConfig.Cleaner.MicrosoftEdge.History.HasValue) ? CurrentSilentConfig.Cleaner.MicrosoftEdge.History.Value : false;
                bool edgeSession = (CurrentSilentConfig.Cleaner.MicrosoftEdge.Session.HasValue) ? CurrentSilentConfig.Cleaner.MicrosoftEdge.Session.Value : false;

                CleanHelper.PreviewChromeClean(chromeCache, chromeCookies, chromeHistory, chromeSession, chromePasswords);
                CleanHelper.PreviewFireFoxClean(ffCache, ffCookies, ffHistory);
                CleanHelper.PreviewEdgeClean(edgeCache, edgeCookies, edgeHistory, edgeSession);
                CleanHelper.PreviewBraveClean(braveCache, braveCookies, braveHistory, braveSession, bravePasswords);

                CleanHelper.Clean();
                if (CurrentSilentConfig.Cleaner.RecycleBin.HasValue && CurrentSilentConfig.Cleaner.RecycleBin.Value) CleanHelper.EmptyRecycleBin();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("MainForm.CleanPC", ex.Message, ex.StackTrace);
            }
        }

        internal static void ProcessHosts()
        {
            var addList = CurrentSilentConfig.HostsEditor.Add.Where(x => !string.IsNullOrEmpty(x.Domain) && !string.IsNullOrEmpty(x.IpAddress));
            var blockList = CurrentSilentConfig.HostsEditor.Block.Where(x => !string.IsNullOrEmpty(x));

            foreach (AddHostsEntry x in addList)
            {
                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(x.IpAddress) + " " + HostsHelper.SanitizeEntry(x.Domain), x.Comment);
            }
            foreach (string x in blockList)
            {
                HostsHelper.AddEntry("0.0.0.0 " + HostsHelper.SanitizeEntry(x));
            }
        }

        internal static void ProcessPinger()
        {
            string dns = CurrentSilentConfig.Pinger.SetDns;
            if (!string.IsNullOrEmpty(dns) && PingerHelper.DNSOptions.Contains(dns))
            {
                if (dns == "Automatic")
                {
                    PingerHelper.ResetDefaultDNSForAllNICs();
                }
                if (dns == "Cloudflare")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CloudflareDNSv4, PingerHelper.CloudflareDNSv6);
                }
                if (dns == "OpenDNS")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.OpenDNSv4, PingerHelper.OpenDNSv6);
                }
                if (dns == "Quad9")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.Quad9DNSv4, PingerHelper.Quad9DNSv6);
                }
                if (dns == "Google")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.GoogleDNSv4, PingerHelper.GoogleDNSv6);
                }
                if (dns == "AlternateDNS")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.AlternateDNSv4, PingerHelper.AlternateDNSv6);
                }
                if (dns == "Adguard")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.AdguardDNSv4, PingerHelper.AdguardDNSv6);
                }
                if (dns == "CleanBrowsing")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CleanBrowsingDNSv4, PingerHelper.CleanBrowsingDNSv6);
                }
                if (dns == "CleanBrowsing (adult filter)")
                {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CleanBrowsingAdultDNSv4, PingerHelper.CleanBrowsingAdultDNSv6);
                }
            }
            if (CurrentSilentConfig.Pinger.FlushDnsCache.HasValue &&
                CurrentSilentConfig.Pinger.FlushDnsCache.Value == true)
            {
                PingerHelper.FlushDNSCache();
            }
        }

        internal static void ProcessProcessControl()
        {
            var allowList = CurrentSilentConfig.ProcessControl.Allow.Where(x => !string.IsNullOrEmpty(x));
            var blockList = CurrentSilentConfig.ProcessControl.Prevent.Where(x => !string.IsNullOrEmpty(x));

            foreach (string x in allowList)
            {
                Utilities.AllowProcessToRun(x);
            }
            foreach (string x in blockList)
            {
                Utilities.PreventProcessFromRunning(x);
            }
        }

        internal static void ProcessRegistryFix()
        {
            if (CurrentSilentConfig.RegistryFix.TaskManager.HasValue &&
                CurrentSilentConfig.RegistryFix.TaskManager.Value == true)
            {
                Utilities.EnableTaskManager();
            }
            if (CurrentSilentConfig.RegistryFix.CommandPrompt.HasValue &&
                CurrentSilentConfig.RegistryFix.CommandPrompt.Value == true)
            {
                Utilities.EnableCommandPrompt();
            }
            if (CurrentSilentConfig.RegistryFix.ControlPanel.HasValue &&
                CurrentSilentConfig.RegistryFix.ControlPanel.Value == true)
            {
                Utilities.EnableControlPanel();
            }
            if (CurrentSilentConfig.RegistryFix.FolderOptions.HasValue &&
                CurrentSilentConfig.RegistryFix.FolderOptions.Value == true)
            {
                Utilities.EnableFolderOptions();
            }
            if (CurrentSilentConfig.RegistryFix.RunDialog.HasValue &&
                CurrentSilentConfig.RegistryFix.RunDialog.Value == true)
            {
                Utilities.EnableRunDialog();
            }
            if (CurrentSilentConfig.RegistryFix.RightClickMenu.HasValue &&
                CurrentSilentConfig.RegistryFix.RightClickMenu.Value == true)
            {
                Utilities.EnableContextMenu();
            }
            if (CurrentSilentConfig.RegistryFix.WindowsFirewall.HasValue &&
                CurrentSilentConfig.RegistryFix.WindowsFirewall.Value == true)
            {
                Utilities.EnableFirewall();
            }
            if (CurrentSilentConfig.RegistryFix.RegistryEditor.HasValue &&
                CurrentSilentConfig.RegistryFix.RegistryEditor.Value == true)
            {
                Utilities.EnableRegistryEditor();
            }
        }

        internal static void ProcessIntegrator()
        {
            if (CurrentSilentConfig.Integrator.OpenWithCmd.HasValue)
            {
                if (CurrentSilentConfig.Integrator.OpenWithCmd.Value)
                {
                    IntegratorHelper.InstallOpenWithCMD();
                }
                else
                {
                    IntegratorHelper.DeleteOpenWithCMD();
                }
            }
            if (CurrentSilentConfig.Integrator.TakeOwnership.HasValue)
            {
                IntegratorHelper.InstallTakeOwnership(!CurrentSilentConfig.Integrator.TakeOwnership.Value);
            }
        }

        internal static void ProcessAdvanced()
        {
            if (CurrentSilentConfig.UnlockAllCores.HasValue &&
                CurrentSilentConfig.UnlockAllCores.Value == true)
            {
                Utilities.UnlockAllCores();
            }

            if (CurrentSilentConfig.SvchostProcessSplitting.Disable.HasValue)
            {
                if (CurrentSilentConfig.SvchostProcessSplitting.Disable.Value &&
                    CurrentSilentConfig.SvchostProcessSplitting.Ram.HasValue &&
                    CurrentSilentConfig.SvchostProcessSplitting.Ram > 0)
                {
                    Utilities.DisableSvcHostProcessSplitting(CurrentSilentConfig.SvchostProcessSplitting.Ram.Value);
                }
                else
                {
                    Utilities.EnableSvcHostProcessSplitting();
                }
            }
        }


        // TODO: Map all values to settings.json for consistency
        #region General Tweaks
        internal static void ProcessTweaksGeneral()
        {
            if (CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.Value)
                {
                    OptimizeHelper.EnablePerformanceTweaks();
                }
                else
                {
                    OptimizeHelper.DisablePerformanceTweaks();
                }
                Options.CurrentOptions.EnablePerformanceTweaks = CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableNetworkThrottling.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableNetworkThrottling.Value)
                {
                    OptimizeHelper.DisableNetworkThrottling();
                }
                else
                {
                    OptimizeHelper.EnableNetworkThrottling();
                }
                Options.CurrentOptions.DisableNetworkThrottling = CurrentSilentConfig.Tweaks.DisableNetworkThrottling.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableWindowsDefender.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableWindowsDefender.Value)
                {
                    OptimizeHelper.DisableDefender();
                }
                else
                {
                    OptimizeHelper.EnableDefender();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSystemRestore.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSystemRestore.Value)
                {
                    OptimizeHelper.DisableSystemRestore();
                }
                else
                {
                    OptimizeHelper.EnableSystemRestore();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisablePrintService.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisablePrintService.Value)
                {
                    OptimizeHelper.DisablePrintService();
                }
                else
                {
                    OptimizeHelper.EnablePrintService();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableMediaPlayerSharing.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableMediaPlayerSharing.Value)
                {
                    OptimizeHelper.DisableMediaPlayerSharing();
                }
                else
                {
                    OptimizeHelper.EnableMediaPlayerSharing();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableErrorReporting.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableErrorReporting.Value)
                {
                    OptimizeHelper.DisableErrorReporting();
                }
                else
                {
                    OptimizeHelper.EnableErrorReporting();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableHomeGroup.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableHomeGroup.Value)
                {
                    OptimizeHelper.DisableHomeGroup();
                }
                else
                {
                    OptimizeHelper.EnableHomeGroup();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSuperfetch.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSuperfetch.Value)
                {
                    OptimizeHelper.DisableSuperfetch();
                }
                else
                {
                    OptimizeHelper.EnableSuperfetch();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableTelemetryTasks.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableTelemetryTasks.Value)
                {
                    OptimizeHelper.DisableTelemetryTasks();
                }
                else
                {
                    OptimizeHelper.EnableTelemetryTasks();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableOffice2016Telemetry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableOffice2016Telemetry.Value)
                {
                    OptimizeHelper.DisableOffice2016Telemetry();
                }
                else
                {
                    OptimizeHelper.EnableOffice2016Telemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableCompatibilityAssistant.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableCompatibilityAssistant.Value)
                {
                    OptimizeHelper.DisableCompatibilityAssistant();
                }
                else
                {
                    OptimizeHelper.EnableCompatibilityAssistant();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableFaxService.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableFaxService.Value)
                {
                    OptimizeHelper.DisableFaxService();
                }
                else
                {
                    OptimizeHelper.EnableFaxService();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSmartScreen.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSmartScreen.Value)
                {
                    OptimizeHelper.DisableSmartScreen();
                }
                else
                {
                    OptimizeHelper.EnableSmartScreen();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableStickyKeys.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableStickyKeys.Value)
                {
                    OptimizeHelper.DisableStickyKeys();
                }
                else
                {
                    OptimizeHelper.EnableStickyKeys();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableHibernation.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableHibernation.Value)
                {
                    Utilities.DisableHibernation();
                }
                else
                {
                    Utilities.EnableHibernation();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSMB1.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSMB1.Value)
                {
                    OptimizeHelper.DisableSMB("1");
                }
                else
                {
                    OptimizeHelper.EnableSMB("1");
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSMB2.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSMB2.Value)
                {
                    OptimizeHelper.DisableSMB("2");
                }
                else
                {
                    OptimizeHelper.EnableSMB("2");
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableNTFSTimeStamp.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableNTFSTimeStamp.Value)
                {
                    OptimizeHelper.DisableNTFSTimeStamp();
                }
                else
                {
                    OptimizeHelper.EnableNTFSTimeStamp();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSearch.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSearch.Value)
                {
                    OptimizeHelper.DisableSearch();
                }
                else
                {
                    OptimizeHelper.EnableSearch();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableChromeTelemetry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableChromeTelemetry.Value)
                {
                    OptimizeHelper.DisableChromeTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableChromeTelemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableFirefoxTemeletry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableFirefoxTemeletry.Value)
                {
                    OptimizeHelper.DisableFirefoxTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableFirefoxTelemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableVisualStudioTelemetry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableVisualStudioTelemetry.Value)
                {
                    OptimizeHelper.DisableVisualStudioTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableVisualStudioTelemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableNVIDIATelemetry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableNVIDIATelemetry.Value)
                {
                    OptimizeHelper.DisableNvidiaTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableNvidiaTelemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableHPET.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableHPET.Value)
                {
                    Utilities.DisableHPET();
                }
                else
                {
                    Utilities.EnableHPET();
                }
            }

            if (CurrentSilentConfig.Tweaks.EnableLoginVerbose.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.EnableLoginVerbose.Value)
                {
                    Utilities.EnableLoginVerbose();
                }
                else
                {
                    Utilities.DisableLoginVerbose();
                }
            }
        }
        #endregion

        #region Windows 8 Tweaks
        internal static void ProcessTweaksWindows8()
        {
            if (CurrentSilentConfig.Tweaks.DisableOneDrive.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableOneDrive.Value)
                {
                    OptimizeHelper.DisableOneDrive();
                }
                else
                {
                    OptimizeHelper.EnableOneDrive();
                }
            }
        }
        #endregion

        #region Windows 10 Tweaks
        internal static void ProcessTweaksWindows10()
        {
            if (CurrentSilentConfig.Tweaks.EnableGamingMode.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.EnableGamingMode.Value)
                {
                    OptimizeHelper.EnableGamingMode();
                }
                else
                {
                    OptimizeHelper.DisableGamingMode();
                }
            }

            if (CurrentSilentConfig.Tweaks.EnableLegacyVolumeSlider.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.EnableLegacyVolumeSlider.Value)
                {
                    OptimizeHelper.EnableLegacyVolumeSlider();
                }
                else
                {
                    OptimizeHelper.DisableLegacyVolumeSlider();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableQuickAccessHistory.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableQuickAccessHistory.Value)
                {
                    OptimizeHelper.DisableQuickAccessHistory();
                }
                else
                {
                    OptimizeHelper.EnableQuickAccessHistory();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableStartMenuAds.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableStartMenuAds.Value)
                {
                    OptimizeHelper.DisableStartMenuAds();
                }
                else
                {
                    OptimizeHelper.EnableStartMenuAds();
                }
            }

            if (CurrentSilentConfig.Tweaks.UninstallOneDrive.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.UninstallOneDrive.Value)
                {
                    OptimizeHelper.UninstallOneDrive();
                }
                else
                {
                    OptimizeHelper.InstallOneDrive();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableMyPeople.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableMyPeople.Value)
                {
                    OptimizeHelper.DisableMyPeople();
                }
                else
                {
                    OptimizeHelper.EnableMyPeople();
                }
            }

            if (CurrentSilentConfig.Tweaks.EnableLongPaths.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.EnableLongPaths.Value)
                {
                    OptimizeHelper.EnableLongPaths();
                }
                else
                {
                    OptimizeHelper.DisableLongPaths();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableAutomaticUpdates.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableAutomaticUpdates.Value)
                {
                    OptimizeHelper.DisableAutomaticUpdates();
                }
                else
                {
                    OptimizeHelper.EnableAutomaticUpdates();
                }
            }

            if (CurrentSilentConfig.Tweaks.ExcludeDrivers.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.ExcludeDrivers.Value)
                {
                    OptimizeHelper.ExcludeDrivers();
                }
                else
                {
                    OptimizeHelper.IncludeDrivers();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableTelemetryServices.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableTelemetryServices.Value)
                {
                    OptimizeHelper.DisableTelemetryServices();
                }
                else
                {
                    OptimizeHelper.EnableTelemetryServices();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisablePrivacyOptions.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisablePrivacyOptions.Value)
                {
                    OptimizeHelper.EnhancePrivacy();
                }
                else
                {
                    OptimizeHelper.CompromisePrivacy();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableCortana.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableCortana.Value)
                {
                    OptimizeHelper.DisableCortana();
                }
                else
                {
                    OptimizeHelper.EnableCortana();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSensorServices.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSensorServices.Value)
                {
                    OptimizeHelper.DisableSensorServices();
                }
                else
                {
                    OptimizeHelper.EnableSensorServices();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableWindowsInk.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableWindowsInk.Value)
                {
                    OptimizeHelper.DisableWindowsInk();
                }
                else
                {
                    OptimizeHelper.EnableWindowsInk();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSpellingTyping.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSpellingTyping.Value)
                {
                    OptimizeHelper.DisableSpellingAndTypingFeatures();
                }
                else
                {
                    OptimizeHelper.EnableSpellingAndTypingFeatures();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableXboxLive.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableXboxLive.Value)
                {
                    OptimizeHelper.DisableXboxLive();
                }
                else
                {
                    OptimizeHelper.EnableXboxLive();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableGameBar.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableGameBar.Value)
                {
                    OptimizeHelper.DisableGameBar();
                }
                else
                {
                    OptimizeHelper.EnableGameBar();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableInsiderService.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableInsiderService.Value)
                {
                    OptimizeHelper.DisableInsiderService();
                }
                else
                {
                    OptimizeHelper.EnableInsiderService();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableStoreUpdates.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableStoreUpdates.Value)
                {
                    OptimizeHelper.DisableStoreUpdates();
                }
                else
                {
                    OptimizeHelper.EnableStoreUpdates();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableCloudClipboard.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableCloudClipboard.Value)
                {
                    OptimizeHelper.DisableCloudClipboard();
                }
                else
                {
                    OptimizeHelper.EnableCloudClipboard();
                }
            }

            if (CurrentSilentConfig.Tweaks.RemoveCastToDevice.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.RemoveCastToDevice.Value)
                {
                    OptimizeHelper.RemoveCastToDevice();
                }
                else
                {
                    OptimizeHelper.AddCastToDevice();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableEdgeTelemetry.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableEdgeTelemetry.Value)
                {
                    OptimizeHelper.DisableEdgeTelemetry();
                }
                else
                {
                    OptimizeHelper.EnableEdgeTelemetry();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableEdgeDiscoverBar.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableEdgeDiscoverBar.Value)
                {
                    OptimizeHelper.DisableEdgeDiscoverBar();
                }
                else
                {
                    OptimizeHelper.EnableEdgeDiscoverBar();
                }
            }
        }
        #endregion

        #region Windows 11 Tweaks
        internal static void ProcessTweaksWindows11()
        {
            if (CurrentSilentConfig.Tweaks.TaskbarToLeft.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.TaskbarToLeft.Value)
                {
                    OptimizeHelper.AlignTaskbarToLeft();
                }
                else
                {
                    OptimizeHelper.AlignTaskbarToCenter();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableStickers.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableStickers.Value)
                {
                    OptimizeHelper.DisableStickers();
                }
                else
                {
                    OptimizeHelper.EnableStickers();
                }
            }

            if (CurrentSilentConfig.Tweaks.CompactMode.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.CompactMode.Value)
                {
                    OptimizeHelper.EnableFilesCompactMode();
                }
                else
                {
                    OptimizeHelper.DisableFilesCompactMode();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableSnapAssist.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableSnapAssist.Value)
                {
                    OptimizeHelper.DisableSnapAssist();
                }
                else
                {
                    OptimizeHelper.EnableSnapAssist();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableWidgets.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableWidgets.Value)
                {
                    OptimizeHelper.DisableWidgets();
                }
                else
                {
                    OptimizeHelper.EnableWidgets();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableChat.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableChat.Value)
                {
                    OptimizeHelper.DisableChat();
                }
                else
                {
                    OptimizeHelper.EnableChat();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableVBS.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableVBS.Value)
                {
                    OptimizeHelper.DisableVirtualizationBasedSecurity();
                }
                else
                {
                    OptimizeHelper.EnableVirtualizationBasedSecurity();
                }
            }

            if (CurrentSilentConfig.Tweaks.ClassicMenu.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.ClassicMenu.Value)
                {
                    OptimizeHelper.DisableShowMoreOptions();
                }
                else
                {
                    OptimizeHelper.EnableShowMoreOptions();
                }
            }

            if (CurrentSilentConfig.Tweaks.DisableTPMCheck.HasValue)
            {
                if (CurrentSilentConfig.Tweaks.DisableTPMCheck.Value)
                {
                    OptimizeHelper.DisableTPMCheck();
                }
                else
                {
                    OptimizeHelper.EnableTPMCheck();
                }
            }
        }
        #endregion
    }
}
