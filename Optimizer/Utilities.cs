using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.ServiceProcess;
using System.Management.Automation;
using System.Drawing;
using System.Threading.Tasks;

namespace Optimizer
{
    internal static class Utilities
    {
        internal static readonly string LocalMachineRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string LocalMachineRunWoW = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnceWow = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string CurrentUserRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string CurrentUserRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string LocalMachineStartupFolder = CleanHelper.ProgramData + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
        internal static readonly string CurrentUserStartupFolder = CleanHelper.ProfileAppDataRoaming + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

        internal readonly static string DefaultEdgeDownloadFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        internal static WindowsVersion CurrentWindowsVersion = WindowsVersion.Unsupported;

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

        internal static string GetOS()
        {
            string os = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");

            if (os.Contains("Windows 7"))
            {
                CurrentWindowsVersion = WindowsVersion.Windows7;
            }
            if ((os.Contains("Windows 8")) || (os.Contains("Windows 8.1")))
            {
                CurrentWindowsVersion = WindowsVersion.Windows8;
            }
            if (os.Contains("Windows 10"))
            {
                CurrentWindowsVersion = WindowsVersion.Windows10;
            }

            if (Program.UNSAFE_MODE)
            {
                if (os.Contains("Windows Server 2008"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows7;
                }
                if (os.Contains("Windows Server 2012"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows8;
                }
                if (os.Contains("Windows Server 2016"))
                {
                    CurrentWindowsVersion = WindowsVersion.Windows10;
                }
            }

            return os;
        }

        internal static string GetBitness()
        {
            string bitness = string.Empty;

            if (Environment.Is64BitOperatingSystem)
            {
                bitness = "You are working with 64-bit architecture";
            }
            else
            {
                bitness = "You are working with 32-bit architecture";
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

        internal static string GetEdgeDownloadFolder()
        {
            string current = string.Empty;

            try
            {
                current = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\Main", "Default Download Directory", DefaultEdgeDownloadFolder).ToString();
            }
            catch
            {
                current = DefaultEdgeDownloadFolder;
            }

            return current;
        }

        internal static void SetEdgeDownloadFolder(string path)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\Main", "Default Download Directory", path, RegistryValueKind.String);
        }

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
            catch { }
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
            catch
            {
                p.Dispose();
            }
            finally
            {
                p.Dispose();
            }
        }

        internal static void Reboot()
        {
            Process.Start("shutdown", "/r /t 0");
        }

        internal static void ActivateMainForm()
        {
            Program.MainForm.Activate();
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
                catch { }
            }
        }

        private static void GetRegistryStartupItemsHelper(ref List<StartupItem> list, StartupItemLocation location, StartupItemType type)
        {
            string keyPath = string.Empty;
            RegistryKey hive = null;

            if (location == StartupItemLocation.HKLM)
            {
                hive = Registry.LocalMachine;

                if (type == StartupItemType.Run)
                {
                    keyPath = LocalMachineRun;
                }
                else if (type == StartupItemType.RunOnce)
                {
                    keyPath = LocalMachineRunOnce;
                }
            }
            else if (location == StartupItemLocation.HKLMWoW)
            {
                hive = Registry.LocalMachine;

                if (type == StartupItemType.Run)
                {
                    keyPath = LocalMachineRunWoW;
                }
                else if (type == StartupItemType.RunOnce)
                {
                    keyPath = LocalMachineRunOnceWow;
                }
            }
            else if (location == StartupItemLocation.HKCU)
            {
                hive = Registry.CurrentUser;

                if (type == StartupItemType.Run)
                {
                    keyPath = CurrentUserRun;
                }
                else if (type == StartupItemType.RunOnce)
                {
                    keyPath = CurrentUserRunOnce;
                }
            }

            if (hive != null)
            {
                RegistryKey key = hive.OpenSubKey(keyPath, true);

                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    foreach (string x in valueNames)
                    {
                        try
                        {
                            RegistryStartupItem item = new RegistryStartupItem();
                            item.Name = x;
                            item.FileLocation = key.GetValue(x).ToString();
                            item.Key = key;
                            item.RegistryLocation = location;
                            item.StartupType = type;

                            list.Add(item);
                        }
                        catch { }
                    }
                }
            }
        }

        private static void GetFolderStartupItemsHelper(ref List<StartupItem> list, string[] files, string[] shortcuts)
        {
            foreach (string file in files)
            {
                try
                {
                    FolderStartupItem item = new FolderStartupItem();
                    item.Name = Path.GetFileNameWithoutExtension(file);
                    item.FileLocation = file;
                    item.Shortcut = file;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    list.Add(item);
                }
                catch { }
            }

            foreach (string shortcut in shortcuts)
            {
                try
                {
                    FolderStartupItem item = new FolderStartupItem();
                    item.Name = Path.GetFileNameWithoutExtension(shortcut);
                    item.FileLocation = GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    list.Add(item);
                }
                catch { }
            }
        }

        internal static List<StartupItem> GetStartupItems()
        {
            List<StartupItem> startupItems = new List<StartupItem>();

            GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKLM, StartupItemType.Run);
            GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKLM, StartupItemType.RunOnce);

            GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKCU, StartupItemType.Run);
            GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKCU, StartupItemType.RunOnce);

            if (Environment.Is64BitOperatingSystem)
            {
                GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKLMWoW, StartupItemType.Run);
                GetRegistryStartupItemsHelper(ref startupItems, StartupItemLocation.HKLMWoW, StartupItemType.RunOnce);
            }

            string[] currentUserFiles = Directory.GetFiles(CurrentUserStartupFolder, "*.exe", SearchOption.AllDirectories);
            string[] currentUserShortcuts = Directory.GetFiles(CurrentUserStartupFolder, "*.lnk", SearchOption.AllDirectories);
            GetFolderStartupItemsHelper(ref startupItems, currentUserFiles, currentUserShortcuts);

            string[] localMachineFiles = Directory.GetFiles(LocalMachineStartupFolder, "*.exe", SearchOption.AllDirectories);
            string[] localMachineShortcuts = Directory.GetFiles(LocalMachineStartupFolder, "*.lnk", SearchOption.AllDirectories);
            GetFolderStartupItemsHelper(ref startupItems, localMachineFiles, localMachineShortcuts);

            return startupItems;
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

                try
                {
                    p.Start();
                    p.WaitForExit();
                    p.Close();
                }
                catch { }
            }
        }

        internal static void FindFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                Process.Start("explorer.exe", "/select, " + fileName);
            }
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
                catch { }
            }

            Process.Start(explorer);
        }

        internal static void FindKeyInRegistry(string key)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit", "LastKey", key);
                Process.Start("regedit");
            }
            catch { }
        }

        internal static List<string> GetModernApps(bool showAll)
        {
            List<string> modernApps = new List<string>();

            using (PowerShell script = PowerShell.Create())
            {
                if (showAll)
                {
                    script.AddScript("Get-AppxPackage -AllUsers | Select -Unique Name | Out-String -Stream");
                }
                else
                {
                    script.AddScript(@"Get-AppxPackage -AllUsers | Where {$_.NonRemovable -like ""False""} | Select -Unique Name | Out-String -Stream");
                }

                string tmp = string.Empty;
                foreach (PSObject x in script.Invoke())
                {
                    tmp = x.ToString().Trim();
                    if (!string.IsNullOrEmpty(tmp) && !tmp.Contains("---") && !tmp.Equals("Name"))
                    {
                        modernApps.Add(tmp);
                    }
                }
            }

            return modernApps;
        }

        internal static bool UninstallModernApp(string appName)
        {
            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript(string.Format("Get-AppxPackage -AllUsers *{0}* | Remove-AppxPackage", appName));

                script.Invoke();

                return script.Streams.Error.Count > 0;

                // not working on Windows 7 anymore
                //return script.HadErrors;
            }
        }

        internal static void ResetConfiguration()
        {
            try
            {
                Directory.Delete(Required.CoreFolder, true);
            }
            catch { }
            finally
            {
                Application.Restart();
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
    }
}
