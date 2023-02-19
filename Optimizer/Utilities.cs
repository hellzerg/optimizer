using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    internal static class Utilities
    {
        // DEPRECATED
        //internal readonly static string DefaultEdgeDownloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        internal static WindowsVersion CurrentWindowsVersion = WindowsVersion.Unsupported;

        static string productName = string.Empty;
        static string buildNumber = string.Empty;

        internal delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        internal static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }

        internal static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            }

            controls.Add(parent);
            return controls;
        }

        internal static Color ToGrayScale(this Color originalColor)
        {
            if (originalColor.Equals(Color.Transparent))
                return originalColor;

            int grayScale = (int)((originalColor.R * .299) + (originalColor.G * .587) + (originalColor.B * .114));
            return Color.FromArgb(grayScale, grayScale, grayScale);
        }

        internal static string GetWindowsDetails()
        {
            string bitness = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            if (CurrentWindowsVersion == WindowsVersion.Windows10 || CurrentWindowsVersion == WindowsVersion.Windows11)
            {
                return string.Format("{0} - {1} ({2})", GetOS(), GetWindows10Build(), bitness);
            }
            else
            {
                return string.Format("{0} - ({1})", GetOS(), bitness);
            }
        }

        internal static string GetWindows10Build()
        {
            return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "DisplayVersion", "");
        }

        internal static string GetOS()
        {
            productName = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");

            if (productName.Contains("Windows 7"))
            {
                CurrentWindowsVersion = WindowsVersion.Windows7;
            }
            if ((productName.Contains("Windows 8")) || (productName.Contains("Windows 8.1")))
            {
                CurrentWindowsVersion = WindowsVersion.Windows8;
            }
            if (productName.Contains("Windows 10"))
            {
                buildNumber = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuild", "");

                if (Convert.ToInt32(buildNumber) >= 22000)
                {
                    productName = productName.Replace("Windows 10", "Windows 11");
                    CurrentWindowsVersion = WindowsVersion.Windows11;
                }
                else
                {
                    CurrentWindowsVersion = WindowsVersion.Windows10;
                }
            }

            if (Program.UNSAFE_MODE)
            {
                if (productName.Contains("Windows Server 2008"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows7;
                }
                if (productName.Contains("Windows Server 2012"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows8;
                }
                if (productName.Contains("Windows Server 2016") || productName.Contains("Windows Server 2019") || productName.Contains("Windows Server 2022"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows10;
                }
            }

            return productName;
        }

        internal static string GetBitness()
        {
            string bitness;

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "You are working with 64-bit";
            }
            else
            {
                bitness = "You are working with 32-bit";
            }

            return bitness;
        }

        internal static bool IsAdmin()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        internal static bool IsCompatible()
        {
            bool legit;
            string os = GetOS();

            if ((os.Contains("XP")) || (os.Contains("Vista")) || os.Contains("Server 2003"))
            {
                legit = false;
            }
            else
            {
                legit = true;
            }
            return legit;
        }

        // DEPRECATED
        //internal static string GetEdgeDownloadFolder()
        //{
        //    string current = string.Empty;

        //    try
        //    {
        //        current = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge", "DownloadDirectory", DefaultEdgeDownloadFolder).ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        current = DefaultEdgeDownloadFolder;
        //        ErrorLogger.LogError("Utilities.GetEdgeDownloadFolder", ex.Message, ex.StackTrace);
        //    }

        //    return current;
        //}

        // DEPRECATED
        //internal static void SetEdgeDownloadFolder(string path)
        //{
        //    Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge", "DownloadDirectory", path, RegistryValueKind.String);
        //}

        internal static void RunBatchFile(string batchFile)
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = batchFile;
                    p.StartInfo.UseShellExecute = false;

                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.RunBatchFile", ex.Message, ex.StackTrace);
            }
        }

        internal static void ImportRegistryScript(string scriptFile)
        {
            string path = "\"" + scriptFile + "\"";

            Process p = new Process();
            try
            {
                p.StartInfo.FileName = "regedit.exe";
                p.StartInfo.UseShellExecute = false;

                p = Process.Start("regedit.exe", "/s " + path);

                p.WaitForExit();
            }
            catch (Exception ex)
            {
                p.Dispose();
                ErrorLogger.LogError("Utilities.ImportRegistryScript", ex.Message, ex.StackTrace);
            }
            finally
            {
                p.Dispose();
            }
        }

        internal static void Reboot()
        {
            Options.SaveSettings();
            Process.Start("shutdown.exe", "/r /t 0");
        }

        internal static void DisableHibernation()
        {
            Utilities.RunCommand("powercfg -h off");
            Utilities.RunCommand("powercfg -h off");
        }

        internal static void EnableHibernation()
        {
            Utilities.RunCommand("powercfg -h on");
            Utilities.RunCommand("powercfg -h on");
        }

        internal static void ActivateMainForm()
        {
            Program._MainForm.Activate();
        }

        internal static bool ServiceExists(string serviceName)
        {
            return ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(serviceName));
        }

        internal static void StopService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);
                if (sc.CanStop)
                {
                    sc.Stop();
                }
            }
        }

        internal static void StartService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);

                try
                {
                    sc.Start();
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.StartService", ex.Message, ex.StackTrace);
                }
            }
        }

        internal static void EnableFirewall()
        {
            RunCommand("netsh advfirewall set currentprofile state on");
        }

        internal static void EnableCommandPrompt()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System"))
            {
                key.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableControlPanel()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"))
            {
                key.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableFolderOptions()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"))
            {
                key.SetValue("NoFolderOptions", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableRunDialog()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"))
            {
                key.SetValue("NoRun", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableContextMenu()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer"))
            {
                key.SetValue("NoViewContextMenu", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableTaskManager()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"))
            {
                key.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
            }
        }

        internal static void EnableRegistryEditor()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System"))
            {
                key.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
            }
        }

        internal static void RunCommand(string command)
        {
            using (Process p = new Process())
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C " + command;
                p.StartInfo.CreateNoWindow = true;

                try
                {
                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.RunCommand", ex.Message, ex.StackTrace);
                }
            }
        }

        internal static void FindFile(string fileName)
        {
            if (File.Exists(fileName)) Process.Start("explorer.exe", $"/select, \"{fileName}\"");
        }

        internal static void FindFolder(string folder)
        {
            if (Directory.Exists(folder)) RunCommand($"explorer.exe \"{folder}\"");
        }

        internal static string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = Path.GetFileName(shortcutFilename);

            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);

            if (folderItem != null)
            {
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty;
        }

        internal static void RestartExplorer()
        {
            const string explorer = "explorer.exe";
            string explorerPath = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), explorer);

            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (string.Compare(process.MainModule.FileName, explorerPath, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        process.Kill();
                    }
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.RestartExplorer", ex.Message, ex.StackTrace);
                }
            }

            Thread.Sleep(TimeSpan.FromSeconds(1));
            Process.Start(explorer);
        }

        internal static void FindKeyInRegistry(string key)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit", "LastKey", key);
                Process.Start("regedit");
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.FindKeyInRegistry", ex.Message, ex.StackTrace);
            }
        }

        internal static void Repair(bool withoutRestart = false)
        {
            try
            {
                Directory.Delete(Required.CoreFolder, true);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.ResetConfiguration", ex.Message, ex.StackTrace);
            }
            finally
            {
                if (!withoutRestart)
                {
                    // BYPASS SINGLE-INSTANCE MECHANISM
                    if (Program.MUTEX != null)
                    {
                        Program.MUTEX.ReleaseMutex();
                        Program.MUTEX.Dispose();
                        Program.MUTEX = null;
                    }

                    Application.Restart();
                }
            }
        }

        internal static Task RunAsync(this Process process)
        {
            var tcs = new TaskCompletionSource<object>();
            process.EnableRaisingEvents = true;
            process.Exited += (s, e) => tcs.TrySetResult(null);

            if (!process.Start()) tcs.SetException(new Exception("Failed to start process."));
            return tcs.Task;
        }

        internal static string SanitizeFileFolderName(string fileName)
        {
            char[] invalids = Path.GetInvalidFileNameChars();
            return string.Join("_", fileName.Split(invalids, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
        }

        // attempt to enable Local Group Policy Editor on Windows 10 Home editions
        internal static void EnableGPEDitor()
        {
            Utilities.RunBatchFile(Required.ScriptsFolder + "GPEditEnablerInHome.bat");
        }

        internal static void TryDeleteRegistryValue(bool localMachine, string path, string valueName)
        {
            try
            {
                if (localMachine) Registry.LocalMachine.OpenSubKey(path, true).DeleteValue(valueName, false);
                if (!localMachine) Registry.CurrentUser.OpenSubKey(path, true).DeleteValue(valueName, false);
            }
            catch { }
        }

        internal static void TryDeleteRegistryValueDefaultUsers(string path, string valueName)
        {
            try
            {
                Registry.Users.OpenSubKey(path, true).DeleteValue(valueName, false);
            }
            catch { }
        }

        internal static void DisableProtectedService(string serviceName)
        {
            using (TokenPrivilege.TakeOwnership)
            {
                using (RegistryKey allServicesKey = Registry.LocalMachine.OpenSubKeyWritable(@"SYSTEM\CurrentControlSet\Services"))
                {
                    allServicesKey.GrantFullControlOnSubKey(serviceName);
                    using (RegistryKey serviceKey = allServicesKey.OpenSubKeyWritable(serviceName))
                    {
                        if (serviceKey == null) return;

                        foreach (string subkeyName in serviceKey.GetSubKeyNames())
                        {
                            serviceKey.TakeOwnershipOnSubKey(subkeyName);
                            serviceKey.GrantFullControlOnSubKey(subkeyName);
                        }
                        serviceKey.SetValue("Start", "4", RegistryValueKind.DWord);
                    }
                }
            }
        }

        internal static void RestoreWindowsPhotoViewer()
        {
            const string PHOTO_VIEWER_SHELL_COMMAND =
                @"%SystemRoot%\System32\rundll32.exe ""%ProgramFiles%\Windows Photo Viewer\PhotoViewer.dll"", ImageView_Fullscreen %1";
            const string PHOTO_VIEWER_CLSID = "{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}";

            Registry.SetValue(@"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open", "MuiVerb", "@photoviewer.dll,-3043");
            Registry.SetValue(
                @"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\command", valueName: null,
                PHOTO_VIEWER_SHELL_COMMAND, RegistryValueKind.ExpandString
            );
            Registry.SetValue(@"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\DropTarget", "Clsid", PHOTO_VIEWER_CLSID);

            string[] imageTypes = { "Paint.Picture", "giffile", "jpegfile", "pngfile" };
            foreach (string type in imageTypes)
            {
                Registry.SetValue(
                    $@"HKEY_CLASSES_ROOT\{type}\shell\open\command", valueName: null,
                    PHOTO_VIEWER_SHELL_COMMAND, RegistryValueKind.ExpandString
                );
                Registry.SetValue($@"HKEY_CLASSES_ROOT\{type}\shell\open\DropTarget", "Clsid", PHOTO_VIEWER_CLSID);
            }
        }

        internal static void EnableProtectedService(string serviceName)
        {
            using (TokenPrivilege.TakeOwnership)
            {
                using (RegistryKey allServicesKey = Registry.LocalMachine.OpenSubKeyWritable(@"SYSTEM\CurrentControlSet\Services"))
                {
                    allServicesKey.GrantFullControlOnSubKey(serviceName);
                    using (RegistryKey serviceKey = allServicesKey.OpenSubKeyWritable(serviceName))
                    {
                        if (serviceKey == null) return;

                        foreach (string subkeyName in serviceKey.GetSubKeyNames())
                        {
                            serviceKey.TakeOwnershipOnSubKey(subkeyName);
                            serviceKey.GrantFullControlOnSubKey(subkeyName);
                        }
                        serviceKey.SetValue("Start", "2", RegistryValueKind.DWord);
                    }
                }
            }
        }

        public static RegistryKey OpenSubKeyWritable(this RegistryKey registryKey, string subkeyName, RegistryRights? rights = null)
        {
            RegistryKey subKey;

            if (rights == null)
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
            else
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, rights.Value);

            if (subKey == null)
            {
                ErrorLogger.LogError("Utilities.OpenSubKeyWritable", $"Subkey {subkeyName} not found.", "-");
            }

            return subKey;
        }

        internal static SecurityIdentifier RetrieveCurrentUserIdentifier()
            => WindowsIdentity.GetCurrent().User ?? throw new Exception("Unable to retrieve current user SID.");

        internal static void GrantFullControlOnSubKey(this RegistryKey registryKey, string subkeyName)
        {
            using (RegistryKey subKey = registryKey.OpenSubKeyWritable(subkeyName,
                RegistryRights.TakeOwnership | RegistryRights.ChangePermissions
            ))
            {
                RegistrySecurity accessRules = subKey.GetAccessControl();
                SecurityIdentifier currentUser = RetrieveCurrentUserIdentifier();
                accessRules.SetOwner(currentUser);
                accessRules.ResetAccessRule(
                    new RegistryAccessRule(
                        currentUser,
                        RegistryRights.FullControl,
                        InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                        PropagationFlags.None,
                        AccessControlType.Allow
                    )
                );
                subKey.SetAccessControl(accessRules);
            }
        }

        internal static void TakeOwnershipOnSubKey(this RegistryKey registryKey, string subkeyName)
        {
            using (RegistryKey subKey = registryKey.OpenSubKeyWritable(subkeyName, RegistryRights.TakeOwnership))
            {
                RegistrySecurity accessRules = subKey.GetAccessControl();
                accessRules.SetOwner(RetrieveCurrentUserIdentifier());
                subKey.SetAccessControl(accessRules);
            }
        }

        internal static string GetNETFramework()
        {
            string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            int netRelease;

            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    netRelease = (int)ndpKey.GetValue("Release");
                }
                else
                {
                    return "4.0";
                }
            }

            if (netRelease >= 528040)
                return "4.8";
            if (netRelease >= 461808)
                return "4.7.2";
            if (netRelease >= 461308)
                return "4.7.1";
            if (netRelease >= 460798)
                return "4.7";
            if (netRelease >= 394802)
                return "4.6.2";
            if (netRelease >= 394254)
                return "4.6.1";
            if (netRelease >= 393295)
                return "4.6";
            if (netRelease >= 379893)
                return "4.5.2";
            if (netRelease >= 378675)
                return "4.5.1";
            if (netRelease >= 378389)
                return "4.5";

            return "4.0";
        }

        internal static void SearchWith(string term, bool ddg)
        {
            try
            {
                if (ddg) Process.Start(string.Format("https://duckduckgo.com/?q={0}", term));
                if (!ddg) Process.Start(string.Format("https://www.google.com/search?q={0}", term));
            }
            catch { }
        }

        // [!!!]
        internal static void UnlockAllCores()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMax", 0, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMin", 0, RegistryValueKind.DWord);
            }
            catch { }
        }

        internal static void DisableHPET()
        {
            Utilities.RunCommand("bcdedit /deletevalue useplatformclock");
            Thread.Sleep(500);
            Utilities.RunCommand("bcdedit /set disabledynamictick yes");
        }

        internal static void EnableHPET()
        {
            Utilities.RunCommand("bcdedit /set useplatformclock true");
            Thread.Sleep(500);
            Utilities.RunCommand("bcdedit /set disabledynamictick no");
        }

        // [!!!]
        //internal static void ChangeNumberOfSvcHostByRAM(string ram)
        //{
        //    try
        //    {
        //        float kbs = float.Parse(ram);
        //        Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control", "SvcHostSplitThresholdInKB", kbs * 1024 * 1024, RegistryValueKind.DWord);
        //    }
        //    catch { }
        //}

        internal static void RegisterAutoStart()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    k.SetValue("Optimizer", Assembly.GetEntryAssembly().Location);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.AddToStartup", ex.Message, ex.StackTrace);
            }
        }

        internal static void UnregisterAutoStart()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    k.DeleteValue("Optimizer", false);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.DeleteFromStartup", ex.Message, ex.StackTrace);
            }
        }

        internal static void PreventProcessFromRunning(string pName)
        {
            try
            {
                using (RegistryKey ifeo = Registry.LocalMachine.OpenSubKeyWritable(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", RegistryRights.FullControl))
                {
                    if (ifeo == null) return;

                    ifeo.GrantFullControlOnSubKey("Image File Execution Options");

                    using (RegistryKey k = ifeo.OpenSubKeyWritable("Image File Execution Options", RegistryRights.FullControl))
                    {
                        if (k == null) return;

                        k.CreateSubKey(pName);
                        k.GrantFullControlOnSubKey(pName);

                        using (RegistryKey f = k.OpenSubKeyWritable(pName, RegistryRights.FullControl))
                        {
                            if (f == null) return;

                            f.SetValue("Debugger", @"%windir%\System32\taskkill.exe");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Utilities.PreventProcessFromRunning", ex.Message, ex.StackTrace);
            }
        }
    }
}
