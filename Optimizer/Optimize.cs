using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;

namespace Optimizer
{
    public static class Optimize
    {
        readonly static string CompatTelRunnerFile = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), @"Windows\System32\CompatTelRunner.exe");

        readonly static string CompatTelRunnerFileOff = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), @"Windows\System32\CompatTelRunner.exe.OFF");

        readonly static string CompatTelRunnerFileName = "CompatTelRunner.exe";
        readonly static string CompatTelRunnerFileNameOff = "CompatTelRunner.exe.OFF";

        readonly static string DiagnosisAutoLoggerFolder = Path.Combine(CleanHelper.ProgramData, @"Microsoft\Diagnosis\ETLLogs\AutoLogger");

        internal static void DisableTelemetryRunner()
        {
            try
            {
                if (File.Exists(CompatTelRunnerFileOff)) File.Delete(CompatTelRunnerFileOff);

                if (File.Exists(CompatTelRunnerFile))
                {
                    Utilities.RunCommand(string.Format("takeown /F {0}", CompatTelRunnerFile));
                    Utilities.RunCommand(string.Format("icacls \"{0}\" /grant administrators:F", CompatTelRunnerFile));

                    FileSystem.RenameFile(CompatTelRunnerFile, CompatTelRunnerFileNameOff);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.DisableTelemetryRunner", ex.Message, ex.StackTrace);
            }
        }

        internal static void EnableTelemetryRunner()
        {
            try
            {
                if (File.Exists(CompatTelRunnerFileOff))
                {
                    FileSystem.RenameFile(CompatTelRunnerFileOff, CompatTelRunnerFileName);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableTelemetryRunner", ex.Message, ex.StackTrace);
            }
        }

        internal static void EnablePerformanceTweaks()
        {
            // enable auto-complete in Run Dialog 
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);

            // show all tray icons
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);

            // disable Remote Assistance
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);

            // disable shaking to minimize
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);

            Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
            Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");

            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "8");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
            Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "8");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");

            Utilities.StopService("DiagTrack");
            Utilities.StopService("diagnosticshub.standardcollector.service");
            Utilities.StopService("dmwappushservice");

            Utilities.RunCommand("sc config \"RemoteRegistry\" start= disabled");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", "1", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", "1", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 8, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", "High", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", "High", RegistryValueKind.String);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "Priority", 8, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
        }

        internal static void DisablePerformanceTweaks()
        {
            try
            {
                // disable auto-complete in Run Dialog
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", true).DeleteValue("Append Completion", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", true).DeleteValue("AutoSuggest", false);

                // hide tray icons
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true).DeleteValue("EnableAutoTray", false);

                // enable Remote Assistance
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);

                // enable shaking to minimize
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);

                Registry.ClassesRoot.DeleteSubKeyTree(@"AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", false);
                Registry.ClassesRoot.DeleteSubKeyTree(@"AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", false);

                Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("AutoEndTasks", false);
                Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("HungAppTimeout", false);
                Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
                Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);

                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
                Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");

                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoResolveSearch", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoResolveTrack", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true).DeleteValue("NoInternetOpenWith", false);

                Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");

                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "2", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "2", RegistryValueKind.DWord);

                Utilities.StartService("DiagTrack");
                Utilities.StartService("diagnosticshub.standardcollector.service");
                Utilities.StartService("dmwappushservice");

                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Hidden", "0", RegistryValueKind.DWord);
                //Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", "0", RegistryValueKind.DWord);

                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("GPU Priority", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("Priority", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("Scheduling Category", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", true).DeleteValue("SFIO Priority", false);

                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("GPU Priority", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("Priority", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("Scheduling Category", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Low Latency", true).DeleteValue("SFIO Priority", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.DisablePerformanceTweaks", ex.Message, ex.StackTrace);
            }
        }

        internal static void DisableTelemetryServices()
        {
            Utilities.StopService("DiagTrack");
            Utilities.StopService("diagnosticshub.standardcollector.service");
            Utilities.StopService("dmwappushservice");
            Utilities.StopService("DcpSvc");
            Utilities.StopService("DPS");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DcpSvc", "Start", "4", RegistryValueKind.DWord);
            Utilities.RunCommand("sc config \"DPS\" start=disabled");

            Utilities.RunCommand("reg add \"HKLM\\Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowAutoConnectToWiFiSenseHotspots\" /v value /t REG_DWORD /d 0 /f");
            Utilities.RunCommand("reg add \"HKLM\\Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowWiFiHotSpotReporting\" /v value /t REG_DWORD /d 0 /f");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\SQMClient\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\SQMLogger", "Start", "0", RegistryValueKind.DWord);
        }

        internal static void EnableTelemetryServices()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DcpSvc", "Start", "2", RegistryValueKind.DWord);
            Utilities.RunCommand("sc config \"DPS\" start=demand");

            Utilities.StartService("DiagTrack");
            Utilities.StartService("diagnosticshub.standardcollector.service");
            Utilities.StartService("dmwappushservice");
            Utilities.StartService("DcpSvc");
            Utilities.StartService("DPS");
        }

        internal static void DisableMediaPlayerSharing()
        {
            Utilities.StopService("WMPNetworkSvc");
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WMPNetworkSvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void EnableMediaPlayerSharing()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WMPNetworkSvc", "Start", "2", RegistryValueKind.DWord);
            Utilities.StartService("WMPNetworkSvc");
        }

        internal static void DisableNetworkThrottling()
        {
            Int32 tempInt = Convert.ToInt32("ffffffff", 16);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", tempInt, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Psched", "NonBestEffortLimit", 0, RegistryValueKind.DWord);
        }

        internal static void EnableNetworkThrottling()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Psched", "NonBestEffortLimit", 80, RegistryValueKind.DWord);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", true).DeleteValue("NetworkThrottlingIndex", false);

                Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dnscache\Parameters", true).DeleteValue("MaxCacheTtl", false);
                Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Dnscache\Parameters", true).DeleteValue("MaxNegativeCacheTtl", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableNetworkThrottling", ex.Message, ex.StackTrace);
            }
        }

        internal static void DisableSkypeAds()
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", "https", "00000004", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", "http", "00000004", RegistryValueKind.DWord);
        }

        internal static void EnableSkypeAds()
        {
            try
            {
                Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", true).DeleteValue("http", false);
                Registry.CurrentUser.OpenSubKey(@"Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", true).DeleteValue("https", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableSkypeAds", ex.Message, ex.StackTrace);
            }
        }

        internal static void DisableHomeGroup()
        {
            Utilities.StopService("HomeGroupListener");
            Utilities.StopService("HomeGroupProvider");

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupProvider", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void EnableHomeGroup()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupProvider", "Start", "2", RegistryValueKind.DWord);

            Utilities.StartService("HomeGroupListener");
            Utilities.StartService("HomeGroupProvider");
        }

        internal static void DisablePrintService()
        {
            Utilities.StopService("Spooler");
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Spooler", "Start", "3", RegistryValueKind.DWord);
        }

        internal static void EnablePrintService()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Spooler", "Start", "2", RegistryValueKind.DWord);
            Utilities.StartService("Spooler");
        }

        internal static void DisableSuperfetch()
        {
            Utilities.StopService("SysMain");
            //Utilities.StopService("Schedule");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SysMain", "Start", "4", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\Schedule", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnableSuperfetch", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnablePrefetcher", "0", RegistryValueKind.DWord);
        }

        internal static void EnableSuperfetch()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SysMain", "Start", "2", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\Schedule", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnableSuperfetch", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters", "EnablePrefetcher", "1", RegistryValueKind.DWord);

            Utilities.StartService("SysMain");
            //Utilities.StartService("Schedule");
        }

        internal static void EnableCompatibilityAssistant()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PcaSvc", "Start", "2", RegistryValueKind.DWord);
            Utilities.StartService("PcaSvc");
        }

        internal static void DisableCompatibilityAssistant()
        {
            Utilities.StopService("PcaSvc");
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\PcaSvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableSystemRestore()
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "vssadmin";
                    p.StartInfo.Arguments = "delete shadows /for=c: /all /quiet";
                    p.StartInfo.UseShellExecute = false;

                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.DisableSystemRestore", ex.Message, ex.StackTrace);
            }

            Utilities.StopService("VSS");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableConfig", "00000001", RegistryValueKind.DWord);
        }

        internal static void EnableSystemRestore()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableConfig", "00000000", RegistryValueKind.DWord);

            Utilities.StartService("VSS");
        }

        internal static void DisableDefender()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
            Registry.ClassesRoot.DeleteSubKeyTree(@"\CLSID\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);

            RegistryKey k = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);

            using (RegistryKey tmp = k.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                tmp.DeleteValue("WindowsDefender", false);
                tmp.DeleteValue("SecurityHealth", false);
            }

            string rootPath;
            if (Environment.Is64BitOperatingSystem)
            {
                rootPath = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
            }
            else
            {
                rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            }

            Utilities.RunCommand(@"regsvr32 /u /s """ + rootPath + "\"");
            Utilities.RunCommand("Gpupdate /Force");
        }

        internal static void EnableDefender()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\MpEngine", "MpEnablePus", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "PUAProtection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Policy Manager", "DisableScanningNetworkFiles", "0", RegistryValueKind.DWord);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true).DeleteValue("DisableRealtimeMonitoring", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true).DeleteValue("DisableAntiSpyware", false);
            Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Windows Defender\Spynet", true).DeleteValue("SpyNetReporting", false);
            Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\Windows Defender\Spynet", true).DeleteValue("SubmitSamplesConsent", false);
            Registry.LocalMachine.OpenSubKey(@"Software\Policies\Microsoft\MRT", true).DeleteValue("DontReportInfectionInformation", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", true).DeleteValue("DisableBehaviorMonitoring", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", true).DeleteValue("DisableOnAccessProtection", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", true).DeleteValue("DisableScanOnRealtimeEnable", false);

            Utilities.RunCommand("Gpupdate /Force");
        }

        internal static void DisableErrorReporting()
        {
            Utilities.StopService("WerSvc");
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WerSvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void EnableErrorReporting()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WerSvc", "Start", "2", RegistryValueKind.DWord);
            Utilities.StartService("WerSvc");
        }

        // not used

        //internal static void DisableTransparency()
        //{
        //    Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "00000000", RegistryValueKind.DWord);
        //}

        //internal static void EnableTransparency()
        //{
        //    Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "00000001", RegistryValueKind.DWord);
        //}

        internal static void EnableDarkTheme()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", "AppsUseLightTheme", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", "SystemUsesLightTheme", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "0", RegistryValueKind.DWord);
        }

        internal static void EnableLightTheme()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", "AppsUseLightTheme", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes", "SystemUsesLightTheme", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1", RegistryValueKind.DWord);
        }

        internal static void EnableLegacyVolumeSlider()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", "00000000", RegistryValueKind.DWord);
        }

        internal static void DisableLegacyVolumeSlider()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", "00000001", RegistryValueKind.DWord);
        }

        internal static void EnableTaskbarColor()
        {
            // disable transparency
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM", "ColorPrevalence", "00000001", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "ColorPrevalence", "00000000", RegistryValueKind.DWord);
        }

        internal static void DisableTaskbarColor()
        {
            // enable transparency
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "1", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM", "ColorPrevalence", "00000000", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "ColorPrevalence", "00000001", RegistryValueKind.DWord);
        }

        internal static void UninstallOneDrive()
        {
            Utilities.RunBatchFile(Required.ScriptsFolder + "OneDrive_Uninstaller.cmd");
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "1", RegistryValueKind.DWord);

            // delete OneDrive folders
            string[] oneDriveFolders =
            {
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\OneDrive",
                Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "OneDriveTemp",
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\OneDrive",
                Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft OneDrive"
            };

            foreach (string x in oneDriveFolders)
            {
                if (Directory.Exists(x))
                {
                    try
                    {
                        Directory.Delete(x, true);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError("Optimize.UninstallOneDrive", ex.Message, ex.StackTrace);
                    }
                }
            }

            // delete scheduled tasks
            Utilities.RunCommand(@"SCHTASKS /Delete /TN ""OneDrive Standalone Update Task"" /F");
            Utilities.RunCommand(@"SCHTASKS /Delete /TN ""OneDrive Standalone Update Task v2"" /F");

            // remove OneDrive from Windows Explorer
            string rootKey = @"CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}";
            Registry.ClassesRoot.CreateSubKey(rootKey);
            int byteArray = BitConverter.ToInt32(BitConverter.GetBytes(0xb090010d), 0);
            var reg = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);

            try
            {
                using (var key = Registry.ClassesRoot.OpenSubKey(rootKey, true))
                {
                    key.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                }

                using (var key = Registry.ClassesRoot.OpenSubKey(rootKey + "\\ShellFolder", true))
                {
                    if (key != null)
                    {
                        key.SetValue("Attributes", byteArray, RegistryValueKind.DWord);
                    }
                }

                var reg2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                using (var key = reg2.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.DeleteValue("OneDriveSetup", false);
                }

                // 64-bit Windows modifications
                if (Environment.Is64BitOperatingSystem)
                {
                    using (var key = reg.OpenSubKey(rootKey, true))
                    {
                        if (key != null)
                        {
                            key.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                        }
                    }

                    using (var key = reg.OpenSubKey(rootKey + "\\ShellFolder", true))
                    {
                        if (key != null)
                        {
                            key.SetValue("Attributes", byteArray, RegistryValueKind.DWord);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.UninstallOneDrive", ex.Message, ex.StackTrace);
            }
        }

        internal static void InstallOneDrive()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "0", RegistryValueKind.DWord);

                string oneDriveInstaller;
                if (Environment.Is64BitOperatingSystem)
                {
                    oneDriveInstaller = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Windows\\SysWOW64\\OneDriveSetup.exe");
                }
                else
                {
                    oneDriveInstaller = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Windows\\System32\\OneDriveSetup.exe");
                }
                Process.Start(oneDriveInstaller);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.InstallOneDrive", ex.Message, ex.StackTrace);
            }
        }

        internal static void DisableCortana()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\SearchSettings", "IsDeviceSearchHistoryEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "DisableWebSearch", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "ConnectedSearchUseWeb", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "ConnectedSearchUseWebOverMeteredConnections", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "HistoryViewEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "DeviceHistoryEnabled", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCloudSearch", "0", RegistryValueKind.DWord);
        }

        internal static void EnableCortana()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "DisableWebSearch", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "ConnectedSearchUseWeb", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "ConnectedSearchUseWebOverMeteredConnections", "1", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "HistoryViewEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Search", "DeviceHistoryEnabled", "1", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCloudSearch", "1", RegistryValueKind.DWord);
        }

        internal static void DisableXboxLive()
        {
            Utilities.StopService("XboxNetApiSvc");
            Utilities.StopService("XblAuthManager");
            Utilities.StopService("XblGameSave");
            Utilities.StopService("XboxGipSvc");
            Utilities.StopService("xbgm");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxNetApiSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblAuthManager", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblGameSave", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxGipSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\xbgm", "Start", "4", RegistryValueKind.DWord);

            Utilities.RunBatchFile(Required.ScriptsFolder + "DisableXboxTasks.bat");
        }

        internal static void EnableXboxLive()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxNetApiSvc", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblAuthManager", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblGameSave", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxGipSvc", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\xbgm", "Start", "2", RegistryValueKind.DWord);

            try
            {
                if (!File.Exists(Required.ScriptsFolder + "EnableXboxTasks.bat"))
                {
                    File.WriteAllText(Required.ScriptsFolder + "EnableXboxTasks.bat", Properties.Resources.EnableXboxTasks);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableXboxLive", ex.Message, ex.StackTrace);
            }

            Utilities.RunBatchFile(Required.ScriptsFolder + "EnableXboxTasks.bat");
        }

        internal static void DisableAutomaticUpdates()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization", "SystemSettingsDownloadMode", "3", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_USERS\S-1-5-20\Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Settings", "DownloadMode", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "UxOption", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoRebootWithLoggedOnUsers", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", "DODownloadMode", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DoSvc", "Start", "4", RegistryValueKind.DWord);

            // disable silent app install
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableSoftLanding", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableWindowsConsumerFeatures", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "OemPreInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload", "2", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "MaintenanceDisabled", "1", RegistryValueKind.DWord);

            Utilities.StopService("DoSvc");
        }

        internal static void EnableAutomaticUpdates()
        {
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\DeliveryOptimization", true).DeleteValue("SystemSettingsDownloadMode", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", true).DeleteValue("UxOption", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true).DeleteValue("AUOptions", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true).DeleteValue("NoAutoUpdate", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", true).DeleteValue("NoAutoRebootWithLoggedOnUsers", false);
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", true).DeleteValue("DODownloadMode", false);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DoSvc", "Start", "3", RegistryValueKind.DWord);

            //Utilities.StartService("DoSvc");

            // enable silent app install
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", "MaintenanceDisabled", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableSoftLanding", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\CloudContent", "DisableWindowsConsumerFeatures", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "OemPreInstalledAppsEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore", "AutoDownload", "4", RegistryValueKind.DWord);
        }

        // no longer useful

        //internal static void RemoveWindows10Icon()
        //{
        //    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GWX", "DisableGWX", "00000001", RegistryValueKind.DWord);
        //    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "DisableOSUpgrade", "00000001", RegistryValueKind.DWord);
        //    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "AllowOSUpgrade", "00000000", RegistryValueKind.DWord);
        //    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "ReservationsAllowed", "00000000", RegistryValueKind.DWord);
        //}

        internal static void DisableOneDrive()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "1", RegistryValueKind.DWord);
        }

        internal static void EnableOneDrive()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "0", RegistryValueKind.DWord);
        }

        internal static void EnableSensorServices()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensrSvc", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensorService", "Start", "2", RegistryValueKind.DWord);

            Utilities.StartService("SensrSvc");
            Utilities.StartService("SensorService");
        }

        internal static void DisableSensorServices()
        {
            Utilities.StopService("SensrSvc");
            Utilities.StopService("SensorService");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensrSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensorService", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableTelemetryTasks()
        {
            // Deny System access to DiagnosisAutoLogger folder
            Utilities.RunCommand(string.Format("icacls {0} /deny SYSTEM:`(OI`)`(CI`)F", DiagnosisAutoLoggerFolder));

            DisableTelemetryRunner();
            Utilities.RunBatchFile(Required.ScriptsFolder + "DisableTelemetryTasks.bat");
        }

        internal static void EnableTelemetryTasks()
        {
            //EnableTelemetryRunner();

            try
            {
                if (!File.Exists(Required.ScriptsFolder + "EnableTelemetryTasks.bat"))
                {
                    File.WriteAllText(Required.ScriptsFolder + "EnableTelemetryTasks.bat", Properties.Resources.EnableTelemetryTasks);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableTelemetryTasks", ex.Message, ex.StackTrace);
            }

            Utilities.RunBatchFile(Required.ScriptsFolder + "EnableTelemetryTasks.bat");
        }

        internal static void DisableOffice2016Telemetry()
        {
            Utilities.RunBatchFile(Required.ScriptsFolder + "DisableOfficeTelemetryTasks.bat");
            Utilities.ImportRegistryScript(Required.ScriptsFolder + "DisableOfficeTelemetryTasks.reg");
        }

        internal static void EnableOffice2016Telemetry()
        {
            try
            {
                if (!File.Exists(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.reg"))
                {
                    File.WriteAllText(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.reg", Properties.Resources.EnableOfficeTelemetry);
                }

                if (!File.Exists(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.bat"))
                {
                    File.WriteAllText(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.bat", Properties.Resources.EnableOfficeTelemetryTasks);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableOffice2016Telemetry", ex.Message, ex.StackTrace);
            }

            Utilities.RunBatchFile(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.bat");
            Utilities.ImportRegistryScript(Required.ScriptsFolder + "EnableOfficeTelemetryTasks.reg");
        }

        internal static void EnhancePrivacy()
        {
            // Find my device
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\FindMyDevice", "AllowFindMyDevice", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Settings\FindMyDevice", "LocationSyncEnabled", "0", RegistryValueKind.DWord);

            // Timeline
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "EnableActivityFeed", "0", RegistryValueKind.DWord);

            // Shared Experiences
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "EnableCdp", "0", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack", "ShowedToastAtLevel", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\SOFTWARE\Microsoft\Windows\CurrentVersion\Diagnostics\DiagTrack", "ShowedToastAtLevel", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Speech_OneCore\Settings\OnlineSpeechPrivacy", "HasAccepted", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location", "Value", "Deny", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Settings\FindMyDevice", "LocationSyncEnabled", "0", RegistryValueKind.DWord);

            // Disable location tracking
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Sensor\Overrides\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", "SensorPermissionState", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\lfsvc\Service\Configuration", "Status", "0", RegistryValueKind.DWord);

            // Disable biometrics
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Biometrics", "Enabled", "0", RegistryValueKind.DWord);

            // News feeding
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Feeds", "ShellFeedsTaskbarOpenOnHover", "0", RegistryValueKind.DWord);

            // Turn off share apps across devices
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CDP", "CdpSessionUserAuthzPolicy", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CDP", "NearShareChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CDP", "RomeSdkChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);

            // Turn off KMS Client Online AVS Validation
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\CurrentVersion\Software Protection Platform", "NoGenTicket", "1", RegistryValueKind.DWord);

            // General
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost", "EnableWebContentEvaluation", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost\EnableWebContentEvaluation", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\SmartGlass", "UserAuthPolicy", "0", RegistryValueKind.DWord);

            // Speech, inking & typing
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Personalization\Settings", "AcceptedPrivacyPolicy", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Language", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitTextCollection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitInkCollection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization\TrainedDataStore", "HarvestContacts", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Input\TIPC", "Enabled", "0", RegistryValueKind.DWord);

            // Other devices
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsSyncWithDevices", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled", "Value", "Deny", RegistryValueKind.String);

            // Feedback & diagnostics
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection", "MaxTelemetryAllowed", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "UploadUserActivities", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules", "PeriodInNanoSeconds", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules", "NumberOfSIUFInPeriod", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);

            // Wi-Fi Sense
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\wifinetworkmanager\config", "AutoConnectAllowedOEM", "0", RegistryValueKind.DWord);

            // Hotspot 2.0
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\Tethering", "Hotspot2SignUp", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WlanSvc\AnqpCache", "OsuRegistrationStatus", "0", RegistryValueKind.DWord);

            // Mobile Hotspot remote startup
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\Tethering", "RemoteStartupDisabled", "1", RegistryValueKind.DWord);

            // Projecting to this PC
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Connect", "AllowProjectionToPC", "0", RegistryValueKind.DWord);

            // attempt to enable Local Group Policy Editor on Windows 10 Home editions
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10 && Utilities.GetOS().ToLowerInvariant().Contains("home"))
            {
                Utilities.EnableGPEDitor();
            }
        }

        internal static void CompromisePrivacy()
        {
            // Find my device
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\FindMyDevice", "AllowFindMyDevice", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Settings\FindMyDevice", "LocationSyncEnabled", "1", RegistryValueKind.DWord);

            // Timeline
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System", true).DeleteValue("EnableActivityFeed", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.CompromisePrivacy", ex.Message, ex.StackTrace);
            }

            // Shared Experiences
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System", true).DeleteValue("EnableCdp", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.CompromisePrivacy", ex.Message, ex.StackTrace);
            }

            // Enable location tracking
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Sensor\Overrides\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", "SensorPermissionState", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\lfsvc\Service\Configuration", "Status", "1", RegistryValueKind.DWord);

            // Enable biometrics
            try
            {
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Biometrics", true).DeleteValue("Enabled", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.CompromisePrivacy", ex.Message, ex.StackTrace);
            }

            // Turn off KMS Client Online AVS Validation
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\CurrentVersion\Software Protection Platform", "NoGenTicket", "0", RegistryValueKind.DWord);

            // General
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost", "EnableWebContentEvaluation", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost\EnableWebContentEvaluation", "Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\SmartGlass", "UserAuthPolicy", "1", RegistryValueKind.DWord);

            // Other devices
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsSyncWithDevices", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled", "Value", "Allow", RegistryValueKind.String);

            // Feedback & diagnostics
            try
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Siuf\Rules", true).DeleteValue("PeriodInNanoSeconds", false);
                Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Siuf\Rules", true).DeleteValue("NumberOfSIUFInPeriod", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.CompromisePrivacy", ex.Message, ex.StackTrace);
            }

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection", "AllowTelemetry", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "1", RegistryValueKind.DWord);

            // Wi-Fi Sense
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\wifinetworkmanager\config", "AutoConnectAllowedOEM", "1", RegistryValueKind.DWord);

            // Hotspot 2.0
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\Tethering", "Hotspot2SignUp", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WlanSvc\AnqpCache", "OsuRegistrationStatus", "1", RegistryValueKind.DWord);

            // Mobile Hotspot remote startup
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\Tethering", "RemoteStartupDisabled", "0", RegistryValueKind.DWord);

            // Projecting to this PC
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Connect", "AllowProjectionToPC", "1", RegistryValueKind.DWord);
        }

        internal static void DisableGameBar()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "AutoGameModeEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "AppCaptureEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "AudioCaptureEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "CursorCaptureEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "UseNexusForGameBarEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "ShowStartupPanel", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "AllowAutoGameMode", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\System\GameConfigStore", "GameDVR_Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\GameDVR", "AllowGameDVR", "0", RegistryValueKind.DWord);
        }

        internal static void EnableGameBar()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "AutoGameModeEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "AppCaptureEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "AudioCaptureEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\GameDVR", "CursorCaptureEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "UseNexusForGameBarEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "ShowStartupPanel", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\GameBar", "AllowAutoGameMode", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\System\GameConfigStore", "GameDVR_Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows\GameDVR", "AllowGameDVR", "1", RegistryValueKind.DWord);
        }

        internal static void DisableQuickAccessHistory()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager", "EnthusiastMode", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSyncProviderNotifications", "0", RegistryValueKind.DWord);

            using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true))
            {
                k.SetValue("ShowFrequent", 0, RegistryValueKind.DWord);
                k.SetValue("ShowRecent", 0, RegistryValueKind.DWord);
            }

            using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true))
            {
                k.SetValue("LaunchTo", 1, RegistryValueKind.DWord);
            }

            // Hide search button from taskbar
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search", "SearchboxTaskbarMode", "0", RegistryValueKind.DWord);

            // Hide task view button from taskbar
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowTaskViewButton", "0", RegistryValueKind.DWord);
        }

        internal static void EnableQuickAccessHistory()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\OperationStatusManager", "EnthusiastMode", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSyncProviderNotifications", "1", RegistryValueKind.DWord);

            using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true))
            {
                k.SetValue("ShowFrequent", 1, RegistryValueKind.DWord);
                k.SetValue("ShowRecent", 1, RegistryValueKind.DWord);
            }

            using (RegistryKey k = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true))
            {
                k.SetValue("LaunchTo", 2, RegistryValueKind.DWord);
                k.DeleteValue("ShowTaskViewButton", false);
            }

            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Search", true).DeleteValue("SearchboxTaskbarMode", false);
        }

        internal static void DisableStartMenuAds()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "ContentDeliveryAllowed", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEverEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-314559Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338387Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338389Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338393Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-353694Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-353696Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-310093Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338388Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContentEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SoftLandingEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "FeatureManagementEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer", "DisableSearchBoxSuggestions", 1, RegistryValueKind.DWord);
        }

        internal static void EnableStartMenuAds()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "ContentDeliveryAllowed", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "PreInstalledAppsEverEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-314559Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338387Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338389Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338393Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-353694Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-353696Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-310093Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContent-338388Enabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SubscribedContentEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SoftLandingEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "FeatureManagementEnabled", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\Explorer", "DisableSearchBoxSuggestions", 0, RegistryValueKind.DWord);
        }

        internal static void DisableMyPeople()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People", "PeopleBand", "0", RegistryValueKind.DWord);
        }

        internal static void EnableMyPeople()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People", "PeopleBand", "1", RegistryValueKind.DWord);
        }

        internal static void ExcludeDrivers()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ExcludeWUDriversInQualityUpdate", "value", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Update", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
        }

        internal static void IncludeDrivers()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update\ExcludeWUDriversInQualityUpdate", "value", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\Update", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\current\device\Update", "ExcludeWUDriversInQualityUpdate", "0", RegistryValueKind.DWord);
        }

        internal static void DisableWindowsInk()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace", "AllowWindowsInkWorkspace", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace", "AllowSuggestedAppsInWindowsInkWorkspace", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableInkingWithTouch", "0", RegistryValueKind.DWord);
        }

        internal static void EnableWindowsInk()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace", "AllowWindowsInkWorkspace", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace", "AllowSuggestedAppsInWindowsInkWorkspace", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableInkingWithTouch", "1", RegistryValueKind.DWord);
        }

        internal static void DisableSpellingAndTypingFeatures()
        {
            // Spelling
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableAutocorrection", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableSpellchecking", "0", RegistryValueKind.DWord);

            // Typing
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableDoubleTapSpace", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnablePredictionSpaceInsertion", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableTextPrediction", "0", RegistryValueKind.DWord);
        }

        internal static void EnableSpellingAndTypingFeatures()
        {
            // Spelling
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableAutocorrection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableSpellchecking", "1", RegistryValueKind.DWord);

            // Typing
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableDoubleTapSpace", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnablePredictionSpaceInsertion", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\TabletTip\1.7", "EnableTextPrediction", "1", RegistryValueKind.DWord);
        }

        internal static void EnableFaxService()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Fax", "Start", "3", RegistryValueKind.DWord);
        }

        internal static void DisableFaxService()
        {
            Utilities.StopService("Fax");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Fax", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void EnableInsiderService()
        {
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "3", RegistryValueKind.DWord);
        }

        internal static void DisableInsiderService()
        {
            Utilities.StopService("wisvc");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableForcedFeatureUpdates()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "DisableOSUpgrade", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "AllowOSUpgrade", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "ReservationsAllowed", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore", "DisableOSUpgrade", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\UpgradeNotification", "UpgradeAvailable", "0", RegistryValueKind.DWord);

            try
            {
                string buildNumber = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", string.Empty);
                if (!string.IsNullOrEmpty(buildNumber)) Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "TargetReleaseVersionInfo", buildNumber, RegistryValueKind.String);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "TargetReleaseVersion", "1", RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.DisableForcedFeatureUpdates", ex.Message, ex.StackTrace);
            }
        }

        internal static void EnableForcedFeatureUpdates()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "DisableOSUpgrade", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "AllowOSUpgrade", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "ReservationsAllowed", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore", "DisableOSUpgrade", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\UpgradeNotification", "UpgradeAvailable", "1", RegistryValueKind.DWord);

            try
            {
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true).DeleteValue("TargetReleaseVersionInfo", false);
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", true).DeleteValue("TargetReleaseVersion", false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.EnableForcedFeatureUpdates", ex.Message, ex.StackTrace);
            }
        }

        internal static void DisableSmartScreen()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "SaveZoneInformation", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "ScanWithAntiVirus", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "ShellSmartScreenLevel", "Warn", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "EnableSmartScreen", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "SmartScreenEnabled", "Off", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\PhishingFilter", "EnabledV9", "0", RegistryValueKind.DWord);
        }

        internal static void EnableSmartScreen()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "SaveZoneInformation", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "ScanWithAntiVirus", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "EnableSmartScreen", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "SmartScreenEnabled", "On", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\PhishingFilter", "EnabledV9", "1", RegistryValueKind.DWord);
        }

        internal static void DisableCloudClipboard()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowClipboardHistory", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowCrossDeviceClipboard", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Clipboard", "EnableClipboardHistory", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Clipboard", "EnableClipboardHistory", "0", RegistryValueKind.DWord);
        }

        internal static void EnableCloudClipboard()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowClipboardHistory", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowCrossDeviceClipboard", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Clipboard", "EnableClipboardHistory", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Clipboard", "EnableClipboardHistory", "1", RegistryValueKind.DWord);
        }

        // Working only on Windows 10
        // Removes 260 character path limit
        internal static void EnableLongPaths()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem", "LongPathsEnabled", "1", RegistryValueKind.DWord);
        }

        internal static void DisableLongPaths()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem", "LongPathsEnabled", "0", RegistryValueKind.DWord);
        }

        internal static void DisableStickyKeys()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\StickyKeys", "Flags", "506", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "Flags", "122", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\ToggleKeys", "Flags", "58", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\StickyKeys", "Flags", "506", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\Keyboard Response", "Flags", "122", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\ToggleKeys", "Flags", "58", RegistryValueKind.String);
        }

        internal static void EnableStickyKeys()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\StickyKeys", "Flags", "510", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "Flags", "126", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Accessibility\ToggleKeys", "Flags", "62", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\StickyKeys", "Flags", "510", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\Keyboard Response", "Flags", "126", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_USERS\.DEFAULT\Control Panel\Accessibility\ToggleKeys", "Flags", "62", RegistryValueKind.String);
        }

        internal static void RemoveCastToDevice()
        {
            try
            {
                Utilities.RunCommand("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Blocked\" /V {7AD84985-87B4-4a16-BE58-8B72A5B390F7} /T REG_SZ /D \"Play to Menu\" /F");
                //Utilities.RestartExplorer();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.RemoveCastToDevice", ex.Message, ex.StackTrace);
            }
        }

        internal static void AddCastToDevice()
        {
            try
            {
                Utilities.RunCommand("REG Delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Blocked\" /V {7AD84985-87B4-4a16-BE58-8B72A5B390F7} /F");
                //Utilities.RestartExplorer();
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Optimize.AddCastToDevice", ex.Message, ex.StackTrace);
            }
        }

        // ACTION CENTER = NOTIFICATION CENTER
        internal static void DisableActionCenter()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\PushNotifications", "ToastEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows\Explorer", "DisableNotificationCenter", "1", RegistryValueKind.DWord);
        }

        internal static void EnableActionCenter()
        {
            Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", true).DeleteValue("DisableNotificationCenter", false);
            Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\PushNotifications", true).DeleteValue("ToastEnabled", false);
        }

        /* Windows 11 tweaks */

        // DEPRECATED
        //internal static void EnableWindows10Start()
        //{
        //    Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowClassicMode", "1", RegistryValueKind.DWord);
        //}

        //internal static void DisableWindows10Start()
        //{
        //    Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_ShowClassicMode", "0", RegistryValueKind.DWord);
        //}

        internal static void AlignTaskbarToLeft()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAl", "0", RegistryValueKind.DWord);
        }

        internal static void AlignTaskbarToCenter()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarAl", "1", RegistryValueKind.DWord);
        }

        internal static void DisableSnapAssist()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableSnapAssistFlyout", "0", RegistryValueKind.DWord);
        }

        internal static void EnableSnapAssist()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableSnapAssistFlyout", "1", RegistryValueKind.DWord);
        }

        internal static void DisableWidgets()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa", "0", RegistryValueKind.DWord);
        }

        internal static void EnableWidgets()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarDa", "1", RegistryValueKind.DWord);
        }

        internal static void DisableChat()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarMn", "0", RegistryValueKind.DWord);
        }

        internal static void EnableChat()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarMn", "1", RegistryValueKind.DWord);
        }

        internal static void SmallerTaskbar()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSi", "0", RegistryValueKind.DWord);
        }

        internal static void DefaultTaskbarSize()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "TaskbarSi", "1", RegistryValueKind.DWord);
        }

        internal static void DisableShowMoreOptions()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32", "", "");
        }

        internal static void EnableShowMoreOptions()
        {
            Registry.CurrentUser.DeleteSubKeyTree(@"Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", false);
        }

        internal static void DisableTPMCheck()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup", "AllowUpgradesWithUnsupportedTPMOrCPU", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassTPMCheck", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassRAMCheck", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\LabConfig", "BypassSecureBootCheck", "1", RegistryValueKind.DWord);
        }

        internal static void EnableTPMCheck()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup", "AllowUpgradesWithUnsupportedTPMOrCPU", "0", RegistryValueKind.DWord);
            Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassTPMCheck", false);
            Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassRAMCheck", false);
            Registry.LocalMachine.OpenSubKey(@"SYSTEM\Setup\LabConfig", true).DeleteValue("BypassSecureBootCheck", false);
        }

        internal static void EnableFileExplorerClassicRibbon()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked", "{e2bf9676-5f8f-435c-97eb-11607a5bedf7}", "");
        }

        internal static void DisableFileExplorerClassicRibbon()
        {
            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked", true).DeleteValue("{e2bf9676-5f8f-435c-97eb-11607a5bedf7}", false);
        }
    }
}
