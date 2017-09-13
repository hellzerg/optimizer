using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

namespace Optimizer
{
    public static class CleanHelper
    {
        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        internal static readonly string System32Folder = Environment.GetFolderPath(Environment.SpecialFolder.System);
        internal static readonly string TempFolder = Path.GetTempPath();
        internal static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        internal static readonly string ProfileAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        internal static readonly string ProfileAppDataLocalLow = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low";
        internal static readonly string OSDrive = System32Folder.Substring(0, 3);
        internal static readonly string OSDriveWindows = Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine);
        internal static readonly string uTorrentCache = ProfileAppDataRoaming + "\\uTorrent\\dlimagecache";

        internal static readonly string LocalMachineRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string LocalMachineRunWoW = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnceWow = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string CurrentUserRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string CurrentUserRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string LocalMachineStartupFolder = ProgramData + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
        internal static readonly string CurrentUserStartupFolder = ProfileAppDataRoaming + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

        internal static void EmptyFolder(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.IsReadOnly = false;
                        file.Delete();
                    }
                    catch { }
                }

                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch { }
                }
            }
            catch { }
        }

        internal static void EmptyRecycleBin()
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }

        internal static void CleanTemp()
        {
            EmptyFolder(TempFolder);
        }
       
        internal static void CleanUTorrent()
        {
            EmptyFolder(uTorrentCache);
        }
      
        internal static void CleanFileZilla()
        {
            try
            {
                File.Delete(ProfileAppDataRoaming + "\\FileZilla\\recentservers.xml");
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        internal static void CleanMiniDumps()
        {
            EmptyFolder(OSDriveWindows + "\\Minidump");
        }
       
        internal static void CleanErrorReports()
        {
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportArchive");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportQueue");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\Temp");
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ERC");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportArchive");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportQueue");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\Temp");
            EmptyFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ERC");
        }
      
        internal static void CleanPrefetch()
        {
            EmptyFolder(OSDriveWindows + "\\Prefetch");
        }
       
        internal static void CleanMediaPlayersCache()
        {
            EmptyFolder(ProfileAppDataLocal + "\\Microsoft\\Media Player");
            EmptyFolder(ProfileAppDataLocalLow + "\\Apple Computer\\QuickTime\\downloads");
            EmptyFolder(ProfileAppDataRoaming + "\\Macromedia");

            try
            {
                File.Delete(ProfileAppDataLocalLow + "\\Apple Computer\\QuickTime\\QTPlayerSession.xml");
            }
            catch { }
        }
     
        internal static void CleanLogs()
        {
            EmptyFolder(System32Folder + "\\LogFiles");
            EmptyFolder(OSDrive + "\\inetpub\\logs\\LogFiles");
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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLM;
                    item.RegistryType = StartupItemType.Run;

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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLM;
                    item.RegistryType = StartupItemType.RunOnce;

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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLMWoW;
                    item.RegistryType = StartupItemType.Run;

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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKLMWoW;
                    item.RegistryType = StartupItemType.RunOnce;

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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKCU;
                    item.RegistryType = StartupItemType.Run;

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
                    item.Location = registryKey.GetValue(s).ToString();
                    item.Key = registryKey;
                    item.RegistryLocation = StartupItemLocation.HKCU;
                    item.RegistryType = StartupItemType.RunOnce;

                    collection.Add(item);
                }
            }
            catch { }

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
                    item.Location = GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item);
                }

                foreach (string file in files)
                {
                    FolderStartupItem item2 = new FolderStartupItem();
                    item2.Name = Path.GetFileNameWithoutExtension(file);
                    item2.Location = file;
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
                    item.Location = GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    collection.Add(item);
                }

                foreach (string file in files)
                {
                    FolderStartupItem item2 = new FolderStartupItem();
                    item2.Name = Path.GetFileNameWithoutExtension(file);
                    item2.Location = file;
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

        internal static void RunCommand(string cmd)
        {
            new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C" + cmd
                }
            }.Start();
        }

        internal static void FindFile(string filename)
        {
            if (File.Exists(filename))
            {
                Process.Start("explorer.exe", "/select, " + filename);
            }
        }

        internal static string GetShortcutTargetFile(string shortcutFilename)
        {
            string pathOnly = Path.GetDirectoryName(shortcutFilename);
            string filenameOnly = System.IO.Path.GetFileName(shortcutFilename);

            Shell32.Shell shell = new Shell32.Shell();
            Shell32.Folder folder = shell.NameSpace(pathOnly);
            Shell32.FolderItem folderItem = folder.ParseName(filenameOnly);

            if (folderItem != null)
            {
                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }

            return string.Empty; // not found
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
