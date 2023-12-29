using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Optimizer {
    internal static class SilentOps {
        internal static SilentConfig CurrentSilentConfig;

        internal static SilentConfig GetSilentConfig(string path) {
            try {
                CurrentSilentConfig = JsonConvert.DeserializeObject<SilentConfig>(File.ReadAllText(path));
            }
            catch (Exception ex) {
                Logger.LogError("SilentOps.GetSilentConfig", ex.Message, ex.StackTrace);
                CurrentSilentConfig = null;
            }
            return CurrentSilentConfig;
        }

        internal static void ProcessAllActions() {
            Logger.InitializeSilentReport();

            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows7) {
                ProcessTweaksGeneral();
                Logger.LogInfoSilent("Tweaks | Windows 7");
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8) {
                ProcessTweaksGeneral();
                ProcessTweaksWindows8();
                Logger.LogInfoSilent("Tweaks | Windows 8.1");
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10) {
                ProcessTweaksGeneral();
                ProcessTweaksWindows10();
                Logger.LogInfoSilent("Tweaks | Windows 10");
            }
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows11) {
                ProcessTweaksGeneral();
                ProcessTweaksWindows10();
                ProcessTweaksWindows11();
                Logger.LogInfoSilent("Tweaks | Windows 11");
            }

            ProcessAdvancedTweaks();
            ProcessHosts();
            ProcessPinger();
            ProcessProcessControl();
            ProcessIntegrator();
            ProcessRegistryFix();
            ProcessCleaner();
            Logger.GenerateSilentReport();

            ProcessPostAction();
        }

        internal static bool ProcessWindowsVersionCompatibility() {
            return CurrentSilentConfig.WindowsVersion == ((int)Utilities.CurrentWindowsVersion);
        }

        internal static void ProcessPostAction() {
            if (CurrentSilentConfig.PostAction.Restart.HasValue &&
                CurrentSilentConfig.PostAction.Restart.Value == true) {
                string restartType = CurrentSilentConfig.PostAction.RestartType;
                if (!string.IsNullOrEmpty(restartType)) {
                    if (restartType == RestartType.Normal.ToString()) {
                        Program.RestartInNormalMode();
                    }
                    if (restartType == RestartType.SafeMode.ToString()) {
                        Program.RestartInSafeMode();
                    }
                    if (restartType == RestartType.DisableDefender.ToString()) {
                        Program.SetRunOnceDisableDefender();
                    }
                    if (restartType == RestartType.EnableDefender.ToString()) {
                        Program.SetRunOnceEnableDefender();
                    }
                }
            }
        }

        internal static void ProcessCleaner() {
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
            Logger.LogInfoSilent($"Cleaner | Options");
        }

        internal static void ProcessHosts() {
            var addList = CurrentSilentConfig.HostsEditor.Add.Where(x => !string.IsNullOrEmpty(x.Domain) && !string.IsNullOrEmpty(x.IpAddress));
            var blockList = CurrentSilentConfig.HostsEditor.Block.Where(x => !string.IsNullOrEmpty(x));
            var removeList = CurrentSilentConfig.HostsEditor.Remove.Where(x => !string.IsNullOrEmpty(x));
            var includeWwwCname = CurrentSilentConfig.HostsEditor.IncludeWwwCname.HasValue ? CurrentSilentConfig.HostsEditor.IncludeWwwCname.Value : false;

            foreach (AddHostsEntry x in addList) {
                HostsHelper.AddEntry(HostsHelper.SanitizeEntry(x.IpAddress) + " " + HostsHelper.SanitizeEntry(x.Domain));
                if (includeWwwCname) {
                    HostsHelper.AddEntry(HostsHelper.SanitizeEntry(x.IpAddress) + " www." + HostsHelper.SanitizeEntry(x.Domain));
                }
                Logger.LogInfoSilent($"Hosts | Add entry: {x.IpAddress} {x.Domain}");
            }
            foreach (string x in blockList) {
                HostsHelper.AddEntry("0.0.0.0 " + HostsHelper.SanitizeEntry(x));
                Logger.LogInfoSilent($"Hosts | Block entry: {x}");
            }
            foreach (string x in removeList) {
                HostsHelper.RemoveEntryFromTemplate(x);
                Logger.LogInfoSilent($"Hosts | Remove entry: {x}");
            }
        }

        internal static void ProcessPinger() {
            string dnsOption = CurrentSilentConfig.Pinger.SetDns;

            if (dnsOption == Constants.CustomDNS) {
                bool atLeastOnePrimary4 = CurrentSilentConfig.Pinger.CustomDNSv4.Length > 0 && CurrentSilentConfig.Pinger.CustomDNSv4.Length < 3;
                bool atLeastOnePrimary6 = CurrentSilentConfig.Pinger.CustomDNSv6.Length > 0 && CurrentSilentConfig.Pinger.CustomDNSv6.Length < 3;
                bool notEmptyDNS4 = Array.Exists(CurrentSilentConfig.Pinger.CustomDNSv4, (x => !string.IsNullOrEmpty(x)));
                bool notEmptyDNS6 = Array.Exists(CurrentSilentConfig.Pinger.CustomDNSv6, (x => !string.IsNullOrEmpty(x)));

                if (atLeastOnePrimary4 && atLeastOnePrimary6 && notEmptyDNS4 && notEmptyDNS6) {
                    PingerHelper.SetDNSForAllNICs(CurrentSilentConfig.Pinger.CustomDNSv4, CurrentSilentConfig.Pinger.CustomDNSv6);
                    Logger.LogInfoSilent("Pinger | Set DNS to custom:");
                    Logger.LogInfoSilent($"Pinger | IPv4: {string.Join(", ", CurrentSilentConfig.Pinger.CustomDNSv4)}");
                    Logger.LogInfoSilent($"Pinger | IPv6: {string.Join(", ", CurrentSilentConfig.Pinger.CustomDNSv6)}");
                }
            }

            if (!string.IsNullOrEmpty(dnsOption) && PingerHelper.DNSOptions.Contains(dnsOption)) {
                if (dnsOption == Constants.AutomaticDNS) {
                    PingerHelper.ResetDefaultDNSForAllNICs();
                }
                if (dnsOption == Constants.CloudflareDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CloudflareDNSv4, PingerHelper.CloudflareDNSv6);
                }
                if (dnsOption == Constants.OpenDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.OpenDNSv4, PingerHelper.OpenDNSv6);
                }
                if (dnsOption == Constants.Quad9DNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.Quad9DNSv4, PingerHelper.Quad9DNSv6);
                }
                if (dnsOption == Constants.GoogleDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.GoogleDNSv4, PingerHelper.GoogleDNSv6);
                }
                if (dnsOption == Constants.AlternateDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.AlternateDNSv4, PingerHelper.AlternateDNSv6);
                }
                if (dnsOption == Constants.AdguardDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.AdguardDNSv4, PingerHelper.AdguardDNSv6);
                }
                if (dnsOption == Constants.CleanBrowsingDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CleanBrowsingDNSv4, PingerHelper.CleanBrowsingDNSv6);
                }
                if (dnsOption == Constants.CleanBrowsingAdultFilterDNS) {
                    PingerHelper.SetDNSForAllNICs(PingerHelper.CleanBrowsingAdultDNSv4, PingerHelper.CleanBrowsingAdultDNSv6);
                }
                Logger.LogInfoSilent($"Pinger | Set DNS to: {dnsOption}");
            }
            if (CurrentSilentConfig.Pinger.FlushDnsCache.HasValue &&
                CurrentSilentConfig.Pinger.FlushDnsCache.Value == true) {
                PingerHelper.FlushDNSCache();
                Logger.LogInfoSilent($"Pinger | Flush DNS cache");
            }
        }

        internal static void ProcessProcessControl() {
            var allowList = CurrentSilentConfig.ProcessControl.Allow.Where(x => !string.IsNullOrEmpty(x));
            var blockList = CurrentSilentConfig.ProcessControl.Prevent.Where(x => !string.IsNullOrEmpty(x));

            foreach (string x in allowList) {
                Utilities.AllowProcessToRun(x);
                Logger.LogInfoSilent($"ProcessControl | Allow process: {x}");
            }
            foreach (string x in blockList) {
                Utilities.PreventProcessFromRunning(x);
                Logger.LogInfoSilent($"ProcessControl | Prevent process: {x}");
            }
        }

        internal static void ProcessRegistryFix() {
            if (CurrentSilentConfig.RegistryFix.TaskManager.HasValue &&
                CurrentSilentConfig.RegistryFix.TaskManager.Value == true) {
                Utilities.EnableTaskManager();
                Logger.LogInfoSilent($"RegistryFix | EnableTaskManager");
            }
            if (CurrentSilentConfig.RegistryFix.CommandPrompt.HasValue &&
                CurrentSilentConfig.RegistryFix.CommandPrompt.Value == true) {
                Utilities.EnableCommandPrompt();
                Logger.LogInfoSilent($"RegistryFix | EnableCommandPrompt");
            }
            if (CurrentSilentConfig.RegistryFix.ControlPanel.HasValue &&
                CurrentSilentConfig.RegistryFix.ControlPanel.Value == true) {
                Utilities.EnableControlPanel();
                Logger.LogInfoSilent($"RegistryFix | EnableControlPanel");
            }
            if (CurrentSilentConfig.RegistryFix.FolderOptions.HasValue &&
                CurrentSilentConfig.RegistryFix.FolderOptions.Value == true) {
                Utilities.EnableFolderOptions();
                Logger.LogInfoSilent($"RegistryFix | EnableFolderOptions");
            }
            if (CurrentSilentConfig.RegistryFix.RunDialog.HasValue &&
                CurrentSilentConfig.RegistryFix.RunDialog.Value == true) {
                Utilities.EnableRunDialog();
                Logger.LogInfoSilent($"RegistryFix | EnableRunDialog");
            }
            if (CurrentSilentConfig.RegistryFix.RightClickMenu.HasValue &&
                CurrentSilentConfig.RegistryFix.RightClickMenu.Value == true) {
                Utilities.EnableContextMenu();
                Logger.LogInfoSilent($"RegistryFix | EnableContextMenu");
            }
            if (CurrentSilentConfig.RegistryFix.WindowsFirewall.HasValue &&
                CurrentSilentConfig.RegistryFix.WindowsFirewall.Value == true) {
                Utilities.EnableFirewall();
                Logger.LogInfoSilent($"RegistryFix | EnableFirewall");
            }
            if (CurrentSilentConfig.RegistryFix.RegistryEditor.HasValue &&
                CurrentSilentConfig.RegistryFix.RegistryEditor.Value == true) {
                Utilities.EnableRegistryEditor();
                Logger.LogInfoSilent($"RegistryFix | EnableRegistryEditor");
            }
        }

        internal static void ProcessIntegrator() {
            if (CurrentSilentConfig.Integrator.OpenWithCmd.HasValue) {
                if (CurrentSilentConfig.Integrator.OpenWithCmd.Value) {
                    IntegratorHelper.InstallOpenWithCMD();
                    Logger.LogInfoSilent($"Integrator | InstallOpenWithCMD");
                }
                else {
                    IntegratorHelper.DeleteOpenWithCMD();
                    Logger.LogInfoSilent($"Integrator | DeleteOpenWithCMD");
                }
            }
            if (CurrentSilentConfig.Integrator.TakeOwnership.HasValue) {
                IntegratorHelper.InstallTakeOwnership(!CurrentSilentConfig.Integrator.TakeOwnership.Value);
                Logger.LogInfoSilent($"Integrator | TakeOwnership to {CurrentSilentConfig.Integrator.TakeOwnership.Value}");
            }
        }

        internal static void ProcessAdvancedTweaks() {
            if (CurrentSilentConfig.AdvancedTweaks.UnlockAllCores.HasValue &&
                CurrentSilentConfig.AdvancedTweaks.UnlockAllCores.Value == true) {
                Utilities.UnlockAllCores();
                Logger.LogInfoSilent("AdvancedTweaks | UnlockAllCores");
            }

            if (CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Disable.HasValue) {
                if (CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Disable.Value &&
                    CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Ram.HasValue &&
                    CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Ram > 0) {
                    Utilities.DisableSvcHostProcessSplitting(CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Ram.Value);
                    Logger.LogInfoSilent($"AdvancedTweaks | DisableSvcHostProcessSplitting | RAM capacity: {CurrentSilentConfig.AdvancedTweaks.SvchostProcessSplitting.Ram.Value} GB");
                }
                else {
                    Utilities.EnableSvcHostProcessSplitting();
                    Logger.LogInfoSilent("AdvancedTweaks | EnableSvcHostProcessSplitting");
                }
            }

            if (CurrentSilentConfig.AdvancedTweaks.DisableHPET.HasValue) {
                if (CurrentSilentConfig.AdvancedTweaks.DisableHPET.Value) {
                    Utilities.DisableHPET();
                }
                else {
                    Utilities.EnableHPET();
                }
                OptionsHelper.CurrentOptions.DisableHPET = CurrentSilentConfig.AdvancedTweaks.DisableHPET.Value;
            }

            if (CurrentSilentConfig.AdvancedTweaks.EnableLoginVerbose.HasValue) {
                if (CurrentSilentConfig.AdvancedTweaks.EnableLoginVerbose.Value) {
                    Utilities.EnableLoginVerbose();
                }
                else {
                    Utilities.DisableLoginVerbose();
                }
                OptionsHelper.CurrentOptions.EnableLoginVerbose = CurrentSilentConfig.AdvancedTweaks.EnableLoginVerbose.Value;
            }
        }


        #region General Tweaks
        internal static void ProcessTweaksGeneral() {
            if (CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.HasValue) {
                if (CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.Value) {
                    OptimizeHelper.EnablePerformanceTweaks();
                }
                else {
                    OptimizeHelper.DisablePerformanceTweaks();
                }
                OptionsHelper.CurrentOptions.EnablePerformanceTweaks = CurrentSilentConfig.Tweaks.EnablePerformanceTweaks.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableNetworkThrottling.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableNetworkThrottling.Value) {
                    OptimizeHelper.DisableNetworkThrottling();
                }
                else {
                    OptimizeHelper.EnableNetworkThrottling();
                }
                OptionsHelper.CurrentOptions.DisableNetworkThrottling = CurrentSilentConfig.Tweaks.DisableNetworkThrottling.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableWindowsDefender.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableWindowsDefender.Value) {
                    OptimizeHelper.DisableDefender();
                }
                else {
                    OptimizeHelper.EnableDefender();
                }
                OptionsHelper.CurrentOptions.DisableWindowsDefender = CurrentSilentConfig.Tweaks.DisableWindowsDefender.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSystemRestore.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSystemRestore.Value) {
                    OptimizeHelper.DisableSystemRestore();
                }
                else {
                    OptimizeHelper.EnableSystemRestore();
                }
                OptionsHelper.CurrentOptions.DisableSystemRestore = CurrentSilentConfig.Tweaks.DisableSystemRestore.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisablePrintService.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisablePrintService.Value) {
                    OptimizeHelper.DisablePrintService();
                }
                else {
                    OptimizeHelper.EnablePrintService();
                }
                OptionsHelper.CurrentOptions.DisablePrintService = CurrentSilentConfig.Tweaks.DisablePrintService.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableMediaPlayerSharing.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableMediaPlayerSharing.Value) {
                    OptimizeHelper.DisableMediaPlayerSharing();
                }
                else {
                    OptimizeHelper.EnableMediaPlayerSharing();
                }
                OptionsHelper.CurrentOptions.DisableMediaPlayerSharing = CurrentSilentConfig.Tweaks.DisableMediaPlayerSharing.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableErrorReporting.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableErrorReporting.Value) {
                    OptimizeHelper.DisableErrorReporting();
                }
                else {
                    OptimizeHelper.EnableErrorReporting();
                }
                OptionsHelper.CurrentOptions.DisableErrorReporting = CurrentSilentConfig.Tweaks.DisableErrorReporting.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableHomeGroup.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableHomeGroup.Value) {
                    OptimizeHelper.DisableHomeGroup();
                }
                else {
                    OptimizeHelper.EnableHomeGroup();
                }
                OptionsHelper.CurrentOptions.DisableHomeGroup = CurrentSilentConfig.Tweaks.DisableHomeGroup.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSuperfetch.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSuperfetch.Value) {
                    OptimizeHelper.DisableSuperfetch();
                }
                else {
                    OptimizeHelper.EnableSuperfetch();
                }
                OptionsHelper.CurrentOptions.DisableSuperfetch = CurrentSilentConfig.Tweaks.DisableSuperfetch.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableTelemetryTasks.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableTelemetryTasks.Value) {
                    OptimizeHelper.DisableTelemetryTasks();
                }
                else {
                    OptimizeHelper.EnableTelemetryTasks();
                }
                OptionsHelper.CurrentOptions.DisableTelemetryTasks = CurrentSilentConfig.Tweaks.DisableTelemetryTasks.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableOffice2016Telemetry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableOffice2016Telemetry.Value) {
                    OptimizeHelper.DisableOffice2016Telemetry();
                }
                else {
                    OptimizeHelper.EnableOffice2016Telemetry();
                }
                OptionsHelper.CurrentOptions.DisableOffice2016Telemetry = CurrentSilentConfig.Tweaks.DisableOffice2016Telemetry.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableCompatibilityAssistant.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableCompatibilityAssistant.Value) {
                    OptimizeHelper.DisableCompatibilityAssistant();
                }
                else {
                    OptimizeHelper.EnableCompatibilityAssistant();
                }
                OptionsHelper.CurrentOptions.DisableCompatibilityAssistant = CurrentSilentConfig.Tweaks.DisableCompatibilityAssistant.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableFaxService.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableFaxService.Value) {
                    OptimizeHelper.DisableFaxService();
                }
                else {
                    OptimizeHelper.EnableFaxService();
                }
                OptionsHelper.CurrentOptions.DisableFaxService = CurrentSilentConfig.Tweaks.DisableFaxService.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSmartScreen.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSmartScreen.Value) {
                    OptimizeHelper.DisableSmartScreen();
                }
                else {
                    OptimizeHelper.EnableSmartScreen();
                }
                OptionsHelper.CurrentOptions.DisableSmartScreen = CurrentSilentConfig.Tweaks.DisableSmartScreen.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableStickyKeys.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableStickyKeys.Value) {
                    OptimizeHelper.DisableStickyKeys();
                }
                else {
                    OptimizeHelper.EnableStickyKeys();
                }
                OptionsHelper.CurrentOptions.DisableStickyKeys = CurrentSilentConfig.Tweaks.DisableStickyKeys.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableHibernation.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableHibernation.Value) {
                    Utilities.DisableHibernation();
                }
                else {
                    Utilities.EnableHibernation();
                }
                OptionsHelper.CurrentOptions.DisableHibernation = CurrentSilentConfig.Tweaks.DisableHibernation.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSMB1.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSMB1.Value) {
                    OptimizeHelper.DisableSMB("1");
                }
                else {
                    OptimizeHelper.EnableSMB("1");
                }
                OptionsHelper.CurrentOptions.DisableSMB1 = CurrentSilentConfig.Tweaks.DisableSMB1.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSMB2.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSMB2.Value) {
                    OptimizeHelper.DisableSMB("2");
                }
                else {
                    OptimizeHelper.EnableSMB("2");
                }
                OptionsHelper.CurrentOptions.DisableSMB2 = CurrentSilentConfig.Tweaks.DisableSMB2.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableNTFSTimeStamp.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableNTFSTimeStamp.Value) {
                    OptimizeHelper.DisableNTFSTimeStamp();
                }
                else {
                    OptimizeHelper.EnableNTFSTimeStamp();
                }
                OptionsHelper.CurrentOptions.DisableNTFSTimeStamp = CurrentSilentConfig.Tweaks.DisableNTFSTimeStamp.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSearch.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSearch.Value) {
                    OptimizeHelper.DisableSearch();
                }
                else {
                    OptimizeHelper.EnableSearch();
                }
                OptionsHelper.CurrentOptions.DisableSearch = CurrentSilentConfig.Tweaks.DisableSearch.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableChromeTelemetry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableChromeTelemetry.Value) {
                    OptimizeHelper.DisableChromeTelemetry();
                }
                else {
                    OptimizeHelper.EnableChromeTelemetry();
                }
                OptionsHelper.CurrentOptions.DisableChromeTelemetry = CurrentSilentConfig.Tweaks.DisableChromeTelemetry.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableFirefoxTemeletry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableFirefoxTemeletry.Value) {
                    OptimizeHelper.DisableFirefoxTelemetry();
                }
                else {
                    OptimizeHelper.EnableFirefoxTelemetry();
                }
                OptionsHelper.CurrentOptions.DisableFirefoxTemeletry = CurrentSilentConfig.Tweaks.DisableFirefoxTemeletry.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableVisualStudioTelemetry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableVisualStudioTelemetry.Value) {
                    OptimizeHelper.DisableVisualStudioTelemetry();
                }
                else {
                    OptimizeHelper.EnableVisualStudioTelemetry();
                }
                OptionsHelper.CurrentOptions.DisableVisualStudioTelemetry = CurrentSilentConfig.Tweaks.DisableVisualStudioTelemetry.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableNVIDIATelemetry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableNVIDIATelemetry.Value) {
                    OptimizeHelper.DisableNvidiaTelemetry();
                }
                else {
                    OptimizeHelper.EnableNvidiaTelemetry();
                }
                OptionsHelper.CurrentOptions.DisableNVIDIATelemetry = CurrentSilentConfig.Tweaks.DisableNVIDIATelemetry.Value;
            }
        }
        #endregion

        #region Windows 8 Tweaks
        internal static void ProcessTweaksWindows8() {
            if (CurrentSilentConfig.Tweaks.DisableOneDrive.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableOneDrive.Value) {
                    OptimizeHelper.DisableOneDrive();
                }
                else {
                    OptimizeHelper.EnableOneDrive();
                }
                OptionsHelper.CurrentOptions.DisableOneDrive = CurrentSilentConfig.Tweaks.DisableOneDrive.Value;
            }
        }
        #endregion

        #region Windows 10 Tweaks
        internal static void ProcessTweaksWindows10() {
            if (CurrentSilentConfig.Tweaks.EnableGamingMode.HasValue) {
                if (CurrentSilentConfig.Tweaks.EnableGamingMode.Value) {
                    OptimizeHelper.EnableGamingMode();
                }
                else {
                    OptimizeHelper.DisableGamingMode();
                }
                OptionsHelper.CurrentOptions.EnableGamingMode = CurrentSilentConfig.Tweaks.EnableGamingMode.Value;
            }

            if (CurrentSilentConfig.Tweaks.EnableLegacyVolumeSlider.HasValue) {
                if (CurrentSilentConfig.Tweaks.EnableLegacyVolumeSlider.Value) {
                    OptimizeHelper.EnableLegacyVolumeSlider();
                }
                else {
                    OptimizeHelper.DisableLegacyVolumeSlider();
                }
                OptionsHelper.CurrentOptions.EnableLegacyVolumeSlider = CurrentSilentConfig.Tweaks.EnableLegacyVolumeSlider.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableQuickAccessHistory.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableQuickAccessHistory.Value) {
                    OptimizeHelper.DisableQuickAccessHistory();
                }
                else {
                    OptimizeHelper.EnableQuickAccessHistory();
                }
                OptionsHelper.CurrentOptions.DisableQuickAccessHistory = CurrentSilentConfig.Tweaks.DisableQuickAccessHistory.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableStartMenuAds.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableStartMenuAds.Value) {
                    OptimizeHelper.DisableStartMenuAds();
                }
                else {
                    OptimizeHelper.EnableStartMenuAds();
                }
                OptionsHelper.CurrentOptions.DisableStartMenuAds = CurrentSilentConfig.Tweaks.DisableStartMenuAds.Value;
            }

            if (CurrentSilentConfig.Tweaks.UninstallOneDrive.HasValue) {
                if (CurrentSilentConfig.Tweaks.UninstallOneDrive.Value) {
                    OptimizeHelper.UninstallOneDrive();
                }
                else {
                    OptimizeHelper.InstallOneDrive();
                }
                OptionsHelper.CurrentOptions.UninstallOneDrive = CurrentSilentConfig.Tweaks.UninstallOneDrive.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableMyPeople.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableMyPeople.Value) {
                    OptimizeHelper.DisableMyPeople();
                }
                else {
                    OptimizeHelper.EnableMyPeople();
                }
                OptionsHelper.CurrentOptions.DisableMyPeople = CurrentSilentConfig.Tweaks.DisableMyPeople.Value;
            }

            if (CurrentSilentConfig.Tweaks.EnableLongPaths.HasValue) {
                if (CurrentSilentConfig.Tweaks.EnableLongPaths.Value) {
                    OptimizeHelper.EnableLongPaths();
                }
                else {
                    OptimizeHelper.DisableLongPaths();
                }
                OptionsHelper.CurrentOptions.EnableLongPaths = CurrentSilentConfig.Tweaks.EnableLongPaths.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableAutomaticUpdates.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableAutomaticUpdates.Value) {
                    OptimizeHelper.DisableAutomaticUpdates();
                }
                else {
                    OptimizeHelper.EnableAutomaticUpdates();
                }
                OptionsHelper.CurrentOptions.DisableAutomaticUpdates = CurrentSilentConfig.Tweaks.DisableAutomaticUpdates.Value;
            }

            if (CurrentSilentConfig.Tweaks.ExcludeDrivers.HasValue) {
                if (CurrentSilentConfig.Tweaks.ExcludeDrivers.Value) {
                    OptimizeHelper.ExcludeDrivers();
                }
                else {
                    OptimizeHelper.IncludeDrivers();
                }
                OptionsHelper.CurrentOptions.ExcludeDrivers = CurrentSilentConfig.Tweaks.ExcludeDrivers.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableTelemetryServices.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableTelemetryServices.Value) {
                    OptimizeHelper.DisableTelemetryServices();
                }
                else {
                    OptimizeHelper.EnableTelemetryServices();
                }
                OptionsHelper.CurrentOptions.DisableTelemetryServices = CurrentSilentConfig.Tweaks.DisableTelemetryServices.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisablePrivacyOptions.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisablePrivacyOptions.Value) {
                    OptimizeHelper.EnhancePrivacy();
                }
                else {
                    OptimizeHelper.CompromisePrivacy();
                }
                OptionsHelper.CurrentOptions.DisablePrivacyOptions = CurrentSilentConfig.Tweaks.DisablePrivacyOptions.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableCortana.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableCortana.Value) {
                    OptimizeHelper.DisableCortana();
                }
                else {
                    OptimizeHelper.EnableCortana();
                }
                OptionsHelper.CurrentOptions.DisableCortana = CurrentSilentConfig.Tweaks.DisableCortana.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSensorServices.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSensorServices.Value) {
                    OptimizeHelper.DisableSensorServices();
                }
                else {
                    OptimizeHelper.EnableSensorServices();
                }
                OptionsHelper.CurrentOptions.DisableSensorServices = CurrentSilentConfig.Tweaks.DisableSensorServices.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableWindowsInk.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableWindowsInk.Value) {
                    OptimizeHelper.DisableWindowsInk();
                }
                else {
                    OptimizeHelper.EnableWindowsInk();
                }
                OptionsHelper.CurrentOptions.DisableWindowsInk = CurrentSilentConfig.Tweaks.DisableWindowsInk.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSpellingTyping.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSpellingTyping.Value) {
                    OptimizeHelper.DisableSpellingAndTypingFeatures();
                }
                else {
                    OptimizeHelper.EnableSpellingAndTypingFeatures();
                }
                OptionsHelper.CurrentOptions.DisableSpellingTyping = CurrentSilentConfig.Tweaks.DisableSpellingTyping.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableXboxLive.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableXboxLive.Value) {
                    OptimizeHelper.DisableXboxLive();
                }
                else {
                    OptimizeHelper.EnableXboxLive();
                }
                OptionsHelper.CurrentOptions.DisableXboxLive = CurrentSilentConfig.Tweaks.DisableXboxLive.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableGameBar.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableGameBar.Value) {
                    OptimizeHelper.DisableGameBar();
                }
                else {
                    OptimizeHelper.EnableGameBar();
                }
                OptionsHelper.CurrentOptions.DisableGameBar = CurrentSilentConfig.Tweaks.DisableGameBar.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableInsiderService.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableInsiderService.Value) {
                    OptimizeHelper.DisableInsiderService();
                }
                else {
                    OptimizeHelper.EnableInsiderService();
                }
                OptionsHelper.CurrentOptions.DisableInsiderService = CurrentSilentConfig.Tweaks.DisableInsiderService.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableStoreUpdates.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableStoreUpdates.Value) {
                    OptimizeHelper.DisableStoreUpdates();
                }
                else {
                    OptimizeHelper.EnableStoreUpdates();
                }
                OptionsHelper.CurrentOptions.DisableStoreUpdates = CurrentSilentConfig.Tweaks.DisableStoreUpdates.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableCloudClipboard.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableCloudClipboard.Value) {
                    OptimizeHelper.DisableCloudClipboard();
                }
                else {
                    OptimizeHelper.EnableCloudClipboard();
                }
                OptionsHelper.CurrentOptions.DisableCloudClipboard = CurrentSilentConfig.Tweaks.DisableCloudClipboard.Value;
            }

            if (CurrentSilentConfig.Tweaks.RemoveCastToDevice.HasValue) {
                if (CurrentSilentConfig.Tweaks.RemoveCastToDevice.Value) {
                    OptimizeHelper.RemoveCastToDevice();
                }
                else {
                    OptimizeHelper.AddCastToDevice();
                }
                OptionsHelper.CurrentOptions.RemoveCastToDevice = CurrentSilentConfig.Tweaks.RemoveCastToDevice.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableEdgeTelemetry.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableEdgeTelemetry.Value) {
                    OptimizeHelper.DisableEdgeTelemetry();
                }
                else {
                    OptimizeHelper.EnableEdgeTelemetry();
                }
                OptionsHelper.CurrentOptions.DisableEdgeTelemetry = CurrentSilentConfig.Tweaks.DisableEdgeTelemetry.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableEdgeDiscoverBar.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableEdgeDiscoverBar.Value) {
                    OptimizeHelper.DisableEdgeDiscoverBar();
                }
                else {
                    OptimizeHelper.EnableEdgeDiscoverBar();
                }
                OptionsHelper.CurrentOptions.DisableEdgeDiscoverBar = CurrentSilentConfig.Tweaks.DisableEdgeDiscoverBar.Value;
            }

            if (CurrentSilentConfig.Tweaks.RestoreClassicPhotoViewer.HasValue) {
                if (CurrentSilentConfig.Tweaks.RestoreClassicPhotoViewer.Value) {
                    OptimizeHelper.RestoreClassicPhotoViewer();
                }
                else {
                    OptimizeHelper.DisableClassicPhotoViewer();
                }
                OptionsHelper.CurrentOptions.RestoreClassicPhotoViewer = CurrentSilentConfig.Tweaks.RestoreClassicPhotoViewer.Value;
            }
        }
        #endregion

        #region Windows 11 Tweaks
        internal static void ProcessTweaksWindows11() {
            if (CurrentSilentConfig.Tweaks.TaskbarToLeft.HasValue) {
                if (CurrentSilentConfig.Tweaks.TaskbarToLeft.Value) {
                    OptimizeHelper.AlignTaskbarToLeft();
                }
                else {
                    OptimizeHelper.AlignTaskbarToCenter();
                }
                OptionsHelper.CurrentOptions.TaskbarToLeft = CurrentSilentConfig.Tweaks.TaskbarToLeft.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableStickers.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableStickers.Value) {
                    OptimizeHelper.DisableStickers();
                }
                else {
                    OptimizeHelper.EnableStickers();
                }
                OptionsHelper.CurrentOptions.DisableStickers = CurrentSilentConfig.Tweaks.DisableStickers.Value;
            }

            if (CurrentSilentConfig.Tweaks.CompactMode.HasValue) {
                if (CurrentSilentConfig.Tweaks.CompactMode.Value) {
                    OptimizeHelper.EnableFilesCompactMode();
                }
                else {
                    OptimizeHelper.DisableFilesCompactMode();
                }
                OptionsHelper.CurrentOptions.CompactMode = CurrentSilentConfig.Tweaks.CompactMode.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableSnapAssist.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableSnapAssist.Value) {
                    OptimizeHelper.DisableSnapAssist();
                }
                else {
                    OptimizeHelper.EnableSnapAssist();
                }
                OptionsHelper.CurrentOptions.DisableSnapAssist = CurrentSilentConfig.Tweaks.DisableSnapAssist.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableWidgets.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableWidgets.Value) {
                    OptimizeHelper.DisableWidgets();
                }
                else {
                    OptimizeHelper.EnableWidgets();
                }
                OptionsHelper.CurrentOptions.DisableWidgets = CurrentSilentConfig.Tweaks.DisableWidgets.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableChat.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableChat.Value) {
                    OptimizeHelper.DisableChat();
                }
                else {
                    OptimizeHelper.EnableChat();
                }
                OptionsHelper.CurrentOptions.DisableChat = CurrentSilentConfig.Tweaks.DisableChat.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableVirtualizationBasedTechnology.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableVirtualizationBasedTechnology.Value) {
                    OptimizeHelper.DisableVirtualizationBasedSecurity();
                }
                else {
                    OptimizeHelper.EnableVirtualizationBasedSecurity();
                }
                OptionsHelper.CurrentOptions.DisableVBS = CurrentSilentConfig.Tweaks.DisableVirtualizationBasedTechnology.Value;
            }

            if (CurrentSilentConfig.Tweaks.ClassicMenu.HasValue) {
                if (CurrentSilentConfig.Tweaks.ClassicMenu.Value) {
                    OptimizeHelper.DisableShowMoreOptions();
                }
                else {
                    OptimizeHelper.EnableShowMoreOptions();
                }
                OptionsHelper.CurrentOptions.ClassicMenu = CurrentSilentConfig.Tweaks.ClassicMenu.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableTPMCheck.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableTPMCheck.Value) {
                    OptimizeHelper.DisableTPMCheck();
                }
                else {
                    OptimizeHelper.EnableTPMCheck();
                }
                OptionsHelper.CurrentOptions.DisableTPMCheck = CurrentSilentConfig.Tweaks.DisableTPMCheck.Value;
            }

            if (CurrentSilentConfig.Tweaks.DisableCoPilotAI.HasValue) {
                if (CurrentSilentConfig.Tweaks.DisableCoPilotAI.Value) {
                    OptimizeHelper.DisableCoPilotAI();
                }
                else {
                    OptimizeHelper.EnableCoPilotAI();
                }
                OptionsHelper.CurrentOptions.DisableCoPilotAI = CurrentSilentConfig.Tweaks.DisableCoPilotAI.Value;
            }
        }
        #endregion
    }
}
