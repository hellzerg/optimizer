using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.ServiceProcess;

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
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
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
            catch (Exception)
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

        internal static List<StartupItem> GetStartupItems()
        {
            List<StartupItem> collection = new List<StartupItem>();
            RegistryKey registryKey = null;

            // Get Local Machine Run startup items
            try
            {
                registryKey = Registry.LocalMachine.OpenSubKey(LocalMachineRun, true);
                string[] valueNames = registryKey.GetValueNames();

                foreach (string s in valueNames)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLM;
                    item.StartupType = StartupItemType.Run;

                    collection.Add(item);
                }
            }
            catch { }

            // Get Local Machine Run Once startup items
            try
            {
                registryKey = Registry.LocalMachine.OpenSubKey(LocalMachineRunOnce, true);
                string[] valueNames = registryKey.GetValueNames();

                foreach (string s in valueNames)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLM;
                    item.StartupType = StartupItemType.RunOnce;

                    collection.Add(item);
                }
            }
            catch { }

            // Get Local Machine Run WoW startup items
            try
            {
                registryKey = Registry.LocalMachine.OpenSubKey(LocalMachineRunWoW, true);
                string[] valueNames2 = registryKey.GetValueNames();

                foreach (string s in valueNames2)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLMWoW;
                    item.StartupType = StartupItemType.Run;

                    collection.Add(item);
                }
            }
            catch { }

            // Get Local Machine Run Once WoW startup items
            try
            {
                registryKey = Registry.LocalMachine.OpenSubKey(LocalMachineRunOnceWow, true);
                string[] valueNames2 = registryKey.GetValueNames();

                foreach (string s in valueNames2)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLMWoW;
                    item.StartupType = StartupItemType.RunOnce;

                    collection.Add(item);
                }
            }
            catch { }

            // Get Current User Run startup items
            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(CurrentUserRun, true);
                string[] valueNames3 = registryKey.GetValueNames();

                foreach (string s in valueNames3)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKCU;
                    item.StartupType = StartupItemType.Run;

                    collection.Add(item);
                }
            }
            catch { }

            // Get Current User Run Once startup items
            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(CurrentUserRunOnce, true);
                string[] valueNames3 = registryKey.GetValueNames();

                foreach (string s in valueNames3)
                {
                    RegistryStartupItem item = new RegistryStartupItem();
                    item.Name = s;
                    item.FileLocation = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKCU;
                    item.StartupType = StartupItemType.RunOnce;

                    collection.Add(item);
                }
            }
            catch { }

            registryKey.Dispose();

            // Get Current User Startup folder startup items
            try
            {
                // get shortcuts to files
                string[] shortcuts = Directory.GetFiles(CurrentUserStartupFolder, "*.lnk", SearchOption.AllDirectories);

                // get executables
                string[] files = Directory.GetFiles(CurrentUserStartupFolder, "*.exe", SearchOption.AllDirectories);

                foreach (string shortcut in shortcuts)
                {
                    FolderStartupItem item = new FolderStartupItem();
                    item.Name = Path.GetFileNameWithoutExtension(shortcut);
                    item.FileLocation = GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item);
                }

                foreach (string file in files)
                {
                    FolderStartupItem item2 = new FolderStartupItem();
                    item2.Name = Path.GetFileNameWithoutExtension(file);
                    item2.FileLocation = file;
                    item2.Shortcut = file;
                    item2.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item2);
                }
            }
            catch { }

            // Get Local Machine Startup folder startup items
            try
            {
                // get shortcuts to files
                string[] shortcuts = Directory.GetFiles(LocalMachineStartupFolder, "*.lnk", SearchOption.AllDirectories);

                // get executables
                string[] files = Directory.GetFiles(LocalMachineStartupFolder, "*.exe", SearchOption.AllDirectories);

                foreach (string shortcut in shortcuts)
                {
                    FolderStartupItem item = new FolderStartupItem();
                    item.Name = Path.GetFileNameWithoutExtension(shortcut);
                    item.FileLocation = GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item);
                }

                foreach (string file in files)
                {
                    FolderStartupItem item2 = new FolderStartupItem();
                    item2.Name = Path.GetFileNameWithoutExtension(file);
                    item2.FileLocation = file;
                    item2.Shortcut = file;
                    item2.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item2);
                }
            }
            catch { }

            return collection;
        }

        internal static void EnableFirewall()
        {
            RunCommand("netsh advfirewall set currentprofile state on");
        }

        internal static void EnableCommandPrompt()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
            key.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableControlPanel()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableFolderOptions()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoFolderOptions", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableRunDialog()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoRun", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableContextMenu()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            key.SetValue("NoViewContextMenu", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableTaskManager()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            key.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void EnableRegistryEditor()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            key.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
            key.Close();
        }

        internal static void RunCommand(string command)
        {
            using (Process p = new Process())
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C " + command;

                p.Start();
                p.WaitForExit();
                p.Close();
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
    }
}
