using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.ServiceProcess;
using System.Runtime.InteropServices;
using System.Management.Automation;
using Microsoft.Win32;
using System.Management.Automation.Runspaces;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;

namespace Optimizer
{
    public static class Optimize
    {
        internal readonly static string CompatTelRunnerFile = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\CompatTelRunner.exe";
        internal readonly static string CompatTelRunnerFileOff = "CompatTelRunner.exe.OFF";
        internal readonly static string DefaultEdgeDownloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        internal static string GetEdgeDownloadFolder()
        {
            string current = "";

            try
            {
                current = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\Main", "Default Download Directory", DefaultEdgeDownloadFolder).ToString();
            }
            catch
            {
                current = DefaultEdgeDownloadFolder;
                //MessageBox.Show("Registry key is missing!", "Windows Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return current;
        }

        internal static void DisableTelemetryRunner()
        {
            try
            {
                if (File.Exists(CompatTelRunnerFile))
                {
                    CleanHelper.RunCommand(string.Format("takeown /F {0}", CompatTelRunnerFile));
                    CleanHelper.RunCommand(string.Format("icacls \"{0}\" /grant administrators:F", CompatTelRunnerFile));

                    FileSystem.RenameFile(CompatTelRunnerFile, CompatTelRunnerFileOff);
                }
            }
            catch { }
        }

        internal static void RunBatchFile(string file)
        {
            try
            {
                Process cmd = new Process();

                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.FileName = file;
                cmd.StartInfo.UseShellExecute = false;

                cmd.Start();
                cmd.WaitForExit();
                cmd.Close();
            }
            catch { }
        }

        internal static void SetEdgeDownloadFolder(string path)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\Main", "Default Download Directory", path, RegistryValueKind.String);
        }

        internal static void ImportRegistryScript(string file)
        {
            string path = "\"" + file + "\"";

            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "regedit.exe";
                proc.StartInfo.UseShellExecute = false;

                proc = Process.Start("regedit.exe", "/s " + path);

                proc.WaitForExit();
            }
            catch (Exception)
            {
                proc.Dispose();
            }
        }

        internal static bool DoesServiceExist(string sn)
        {
            return ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(sn));
        }

        internal static void RebootPC()
        {
            Process.Start("shutdown", "/r /t 0");
        }

        internal static void ActivateMain()
        {
            Program.main.Activate();
        }

        internal static void StopService(string servicename)
        {
            if (DoesServiceExist(servicename) == true)
            {
                ServiceController sc = new ServiceController(servicename);
                if (sc.CanStop)
                {
                    sc.Stop();
                }
            }
        }

        internal static void StartService(string servicename)
        {
            if (DoesServiceExist(servicename) == true)
            {
                ServiceController sc = new ServiceController(servicename);

                try
                {
                    sc.Start();
                }
                catch { }
            }
        }

        internal static void PerformanceTweaks()
        {
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

            StopService("DiagTrack");
            StopService("diagnosticshub.standardcollector.service");
            StopService("dmwappushservice");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 0, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 8, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, RegistryValueKind.DWord);
        }

        internal static void DisableMediaPlayerSharing()
        {
            StopService("WMPNetworkSvc");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WMPNetworkSvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableNetworkThrottling()
        {
            Int32 tempInt = Convert.ToInt32("ffffffff", 16);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", tempInt, RegistryValueKind.DWord);
            //CleanHelper.RunCommand("netsh interface tcp set heuristics disabled");
        }

        internal static void BlockSkypeAds()
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", "https", "00000004", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\ZoneMap\\Domains\\skype.com\\apps", "http", "00000004", RegistryValueKind.DWord);
        }

        internal static void DisableHomeGroup()
        {
            StopService("HomeGroupListener");
            StopService("HomeGroupProvider");

            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupProvider", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisablePrintSpooler()
        {
            StopService("Spooler");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Spooler", "Start", "3", RegistryValueKind.DWord);
        }

        internal static void EnablePrintSpooler()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Spooler", "Start", "2", RegistryValueKind.DWord);

            StartService("Spooler");
        }

        internal static void DisableSuperfetch()
        {
            StopService("SysMain");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SysMain", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableSystemRestore()
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.FileName = "vssadmin";
                cmd.StartInfo.Arguments = "delete shadows /for=c: /all /quiet";
                cmd.StartInfo.UseShellExecute = false;
                //cmd.StartInfo.RedirectStandardOutput = true;
                cmd.Start();
                //MessageBox.Show(cmd.StandardOutput.ReadToEnd());
                cmd.WaitForExit();
                cmd.Close();
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            StopService("VSS");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\SystemRestore", "DisableConfig", "00000001", RegistryValueKind.DWord);
            //Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\VSS", "Start", "4", RegistryValueKind.DWord);

        }

        internal static void DisableDefender()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
            Registry.ClassesRoot.DeleteSubKeyTree(@"\CLSID\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
        }

        internal static void DisableErrorReporting()
        {
            StopService("WerSvc");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\WerSvc", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableTransparency()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", "00000000", RegistryValueKind.DWord);
        }

        internal static void EnableDarkTheme()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "00000000", RegistryValueKind.DWord);
        }

        internal static void RestoreLegacyVolumeSlider()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion\MTCUVC", "EnableMtcUvc", "00000000", RegistryValueKind.DWord);

            // enable title bar color
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM", "ColorPrevalence", "00000001", RegistryValueKind.DWord);

            // disable task bar, start menu and action center color
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "ColorPrevalence", "00000000", RegistryValueKind.DWord);
        }

        internal static void UninstallOneDrive()
        {
            RunBatchFile(Required.RequiredFolder + "\\OneDrive_Uninstaller.cmd");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "1", RegistryValueKind.DWord);
        }

        internal static void DisableCortana()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "AllowCortana", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "DisableWebSearch", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search", "ConnectedSearchUseWeb", "0", RegistryValueKind.DWord);
        }

        internal static void DisableDataTelemetry()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener", "Start", "0", RegistryValueKind.DWord);
        }

        internal static void DisableDiagnosticsTracking()
        {
            StopService("DiagTrack");
            StopService("diagnosticshub.standardcollector.service");
            StopService("dmwappushservice");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableWAPPush()
        {
            StopService("dmwappushservice");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableXboxLive()
        {
            StopService("XboxNetApiSvc");
            StopService("XblAuthManager");
            StopService("XblGameSave");
            StopService("XboxGipSvc");
            StopService("xbgm");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxNetApiSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblAuthManager", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XblGameSave", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\XboxGipSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\xbgm", "Start", "4", RegistryValueKind.DWord);

            RunBatchFile(Required.RequiredFolder + "\\DisableXboxTasks.bat");
        }

        internal static void DisableAutomaticUpdates()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "AUOptions", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU", "NoAutoUpdate", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config", "DODownloadMode", "0", RegistryValueKind.DWord);
        }

        internal static void RemoveWindows10Icon()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\GWX", "DisableGWX", "00000001", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "DisableOSUpgrade", "00000001", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "AllowOSUpgrade", "00000000", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\OSUpgrade", "ReservationsAllowed", "00000000", RegistryValueKind.DWord);
        }

        internal static void DisableOneDrive()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OneDrive", "DisableFileSyncNGSC", "1", RegistryValueKind.DWord);
        }

        internal static void EnableSensorServices()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DcpSvc", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensrSvc", "Start", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensorService", "Start", "2", RegistryValueKind.DWord);

            StartService("DcpSvc");
            StartService("SensrSvc");
            StartService("SensorService");
        }

        internal static void DisableSensorServices()
        {
            StopService("DcpSvc");
            StopService("SensrSvc");
            StopService("SensorService");

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\DcpSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensrSvc", "Start", "4", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SensorService", "Start", "4", RegistryValueKind.DWord);
        }

        internal static void DisableTelemetryTasks()
        {
            DisableTelemetryRunner();

            RunBatchFile(Required.RequiredFolder + "\\DisableTelemetryTasks.bat");
        }

        internal static void DisableOfficeTelemetryTasks()
        {
            RunBatchFile(Required.RequiredFolder + "\\DisableOfficeTelemetryTasks.bat");

            ImportRegistryScript(Required.RequiredFolder + "\\DisableOfficeTelemetryTasks.reg");
        }

        internal static void DisablePrivacyOptions()
        {
            // Turn off KMS Client Online AVS Validation
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\CurrentVersion\Software Protection Platform", "NoGenTicket", "1", RegistryValueKind.DWord);

            // General
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost\EnableWebContentEvaluation", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\SmartGlass", "UserAuthPolicy", "0", RegistryValueKind.DWord);

            // Location
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E6AD100E-5F4E-44CD-BE0F-2265D88D14F5}", "Value", "Deny", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", "Value", "Deny", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Sensor\Permissions\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}", "SensorPermissionState", "0", RegistryValueKind.DWord);

            // Camera
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{E5323777-F976-4f5b-9B55-B94699C46E44}", "Value", "Deny", RegistryValueKind.String);

            // Microphone
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{2EEF81BE-33FA-4800-9670-1CD474972C3F}", "Value", "Deny", RegistryValueKind.String);

            // Notifications
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{52079E78-A92B-413F-B213-E8FE35712E72}", "Value", "Deny", RegistryValueKind.String);

            // Speech, inking & typing
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Personalization\Settings", "AcceptedPrivacyPolicy", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Language", "Enabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitTextCollection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization", "RestrictImplicitInkCollection", "1", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\InputPersonalization\TrainedDataStore", "HarvestContacts", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Input\TIPC", "Enabled", "0", RegistryValueKind.DWord);

            // Account info
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{C1D23ACC-752B-43E5-8448-8D0E519CD6D6}", "Value", "Deny", RegistryValueKind.String);

            // Contacts
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{7D7E8402-7C54-4821-A34E-AEEFD62DED93}", "Value", "Deny", RegistryValueKind.String);

            // Calendar
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{D89823BA-7180-4B81-B50C-7E471E6121A3}", "Value", "Deny", RegistryValueKind.String);

            // Call history
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{8BC668CF-7728-45BD-93F8-CF2B3B41D7AB}", "Value", "Deny", RegistryValueKind.String);

            // Email
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{9231CB4C-BF57-4AF3-8C55-FDA7BFCC04C5}", "Value", "Deny", RegistryValueKind.String);

            // Tasks

            // Messaging
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{21157C1F-2651-4CC1-90CA-1F28B02263F6}", "Value", "Deny", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{992AFA70-6F47-4148-B3E9-3003349C1548}", "Value", "Deny", RegistryValueKind.String);

            // Radios
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\{A8804298-2D5F-42E3-9531-9C8C39EB29CE}", "Value", "Deny", RegistryValueKind.String);

            // Other devices
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\AppPrivacy", "LetAppsSyncWithDevices", "2", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\DeviceAccess\Global\LooselyCoupled", "Value", "0", RegistryValueKind.DWord);

            // Feedback & diagnostics
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules", "PeriodInNanoSeconds", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Siuf\Rules", "NumberOfSIUFInPeriod", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\DataCollection", "AllowTelemetry", "0", RegistryValueKind.DWord);

            // App diagnostics

            // Wi-Fi Sense
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\WcmSvc\wifinetworkmanager\config", "AutoConnectAllowedOEM", "0", RegistryValueKind.DWord);
        }

        internal static void DisableGameBar()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR", "AppCaptureEnabled", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\System\GameConfigStore", "GameDVR_Enabled", "0", RegistryValueKind.DWord);
        }

        internal static void DisableSyncProviderNotifications()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSyncProviderNotifications", "0", RegistryValueKind.DWord);
        }

        internal static void DisableStartMenuAds()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", "0", RegistryValueKind.DWord);
        }

        internal static void DisableSilentAppInstall()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", "SilentInstalledAppsEnabled", "0", RegistryValueKind.DWord);
        }

        internal static void DisableMyPeople()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People", "PeopleBand", "0", RegistryValueKind.DWord);
        }

        internal static void ExcludeDrivers()
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate", "ExcludeWUDriversInQualityUpdate", "1", RegistryValueKind.DWord);
        }
    }
}
