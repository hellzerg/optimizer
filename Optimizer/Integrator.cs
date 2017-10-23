using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Drawing.Imaging;

namespace Optimizer
{
    public static class Integrator
    {
        static string _newLine = Environment.NewLine;

        internal static string powerinfo = "Power Menu contains the following:" + _newLine + _newLine + "Lock" + _newLine + "Sign out" + _newLine + "Switch User" + _newLine + "Sleep" + _newLine + "Hibernate" + _newLine + "Restart" + _newLine + "Restart with Boot Options Menu" + _newLine + "Shut down" + _newLine + "Shut down (Hybrid)";

        internal static string systemtoolsinfo = "System Tools Menu contains the following:" + _newLine + _newLine + "Control Panel" + _newLine + "Disk Cleanup" + _newLine + "Device Manager" + _newLine + "Event Viewer" + _newLine + "Registry Editor" + _newLine + "Security Center" + _newLine + "System Configuration" + _newLine + "Task Manager" + _newLine + "Task Scheduler" + _newLine + "Windows Update";

        internal static string systemshortcutsinfo = "System Shortcuts Menu contains the following:" + _newLine + _newLine + "Administrative Tools" + _newLine + "Change Date and Time" + _newLine + "Change Regional Settings" + _newLine + "Folder Options" + _newLine + "God Mode" + _newLine + "Internet Options" + _newLine + "Network Connections" + _newLine + "Power Options" + _newLine + "Programs and Features" + _newLine + "Recycle Bin" + _newLine + "Run" + _newLine + "Search" + _newLine + "Services" + _newLine + "System Properties" + _newLine + "User Accounts" + _newLine + "User Accounts Classic" + _newLine + "Window Switcher";

        internal static string desktopshortcutsinfo = "Desktop Shortcuts Menu contains the following:" + _newLine + _newLine + "Change Theme" + _newLine + "Change Wallpaper" + _newLine + "Change Screen Saver" + _newLine + "Change Desktop Icons" + _newLine + "Change Sound Scheme" + _newLine + "Change Mouse Pointers" + _newLine + "Change DPI Scaling" + _newLine + "Change Window Color and Appearance";

        internal static string windowsappsinfo = "Windows Apps Menu contains the following:" + _newLine + _newLine + "Calculator" + _newLine + "Character Map" + _newLine + "Command Prompt" + _newLine + "Disk Defragmenter" + _newLine + "Internet Explorer" + _newLine + "Notepad" + _newLine + "Paint" + _newLine + "Problem Steps Recorder" + _newLine + "Snipping Tool" + _newLine + "Sound Recorder" + _newLine + "System Restore" + _newLine + "Task Scheduler" + _newLine + "Windows Media Player" + _newLine + "Wordpad";

        internal static string FolderDefaultIcon = @"%systemroot%\system32\imageres.dll,-112";

        private static T DirectCast<T>(object o)
        {
            return (T)o;
        }

        internal static void CreateCustomCommand(string file, string keyword)
        {
            if (!keyword.EndsWith(".exe"))
            {
                keyword = keyword + ".exe";
            }

            string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + keyword;
            
            Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + keyword);
            Registry.SetValue(key, "", file);
            Registry.SetValue(key, "Path", file.Substring(0, file.LastIndexOf("\\")));
        }

        internal static List<string> GetCustomCommands()
        {
            List<string> items = new List<string>();
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\");

            foreach (string command in key.GetSubKeyNames())
            {
                items.Add(command);
            }

            key.Close();

            return items;
        }

        internal static void DeleteCustomCommand(string command)
        {
            Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + command, false);
        }

        private static void CreateDefaultCommand(string itemName)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + itemName, true);
            key.CreateSubKey("command", RegistryKeyPermissionCheck.Default);
            key.Close();
        }

        internal static List<string> GetDesktopItems()
        {
            List<string> items = new List<string>();
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", false);

            foreach (string item in key.GetSubKeyNames())
            {
                // filter the list, so the default items will not be visible
                if (item.Contains("Gadgets")) continue;
                if (item.Contains("Display")) continue;
                if (item.Contains("Personalize")) continue;

                items.Add(item);
            }

            key.Close();
            return items;
        }

        internal static void RemoveItem(string name)
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);

                try
                {
                    key.DeleteSubKey(name + "\\command");
                }
                catch { }
                key.DeleteSubKey(name);
            }
            catch { }
        }

        internal static void RemoveAllItems(List<string> items)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);

            foreach (string item in items)
            {
                try
                {
                    try
                    {
                        key.DeleteSubKey(item + "\\command");
                    }
                    catch { }
                    key.DeleteSubKey(item);
                }
                catch { }
            }
        }

        internal static string ExtractIconFromExecutable(string itemName, string fileName)
        {
            string iconPath = string.Empty;

            if (File.Exists(fileName))
            {
                Icon ico = Icon.ExtractAssociatedIcon(fileName);

                Clipboard.SetImage(ico.ToBitmap());
                Clipboard.GetImage().Save(Required.ExtractedIcons + "\\" + itemName + ".ico", ImageFormat.Bmp);
                Clipboard.Clear();

                iconPath = Required.ExtractedIcons + "\\" + itemName + ".ico";
            }

            return iconPath;
        }

        internal static string DownloadFavicon(string link, string name)
        {
            string favicon = string.Empty;

            try
            {
                Uri url = new Uri(link);
                if (url.HostNameType == UriHostNameType.Dns)
                {
                    Image.FromStream(((HttpWebResponse)WebRequest.Create("http://" + url.Host + "/favicon.ico").GetResponse()).GetResponseStream()).Save(Required.FavIcons + name + ".ico", ImageFormat.Bmp);
                    favicon = Required.FavIcons + name + ".ico";
                }
            }
            catch { }

            return favicon;
        }

        internal static void AddItem(string name, string item, string icon, DesktopTypePosition position, bool shift, DesktopItemType type)
        {
            switch (type)
            {
                case DesktopItemType.Program:
                    RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
                    key.Close();
                    CreateDefaultCommand(name);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name + "\\command", "", item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + name, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Folder:
                    RegistryKey key3 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key3.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
                    key3.Close();
                    CreateDefaultCommand(name);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name + "\\command", "", "explorer " + item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + name, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Link:
                    RegistryKey key4 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key4.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
                    key4.Close();
                    CreateDefaultCommand(name);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name + "\\command", "", "explorer " + item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + name, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.File:
                    RegistryKey key5 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key5.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
                    key5.Close();
                    CreateDefaultCommand(name);
                    string def = @"""";
                    string def2 = "explorer.exe";

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name + "\\command", "", def2 + " " + def + item + def);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + name, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Command:
                    RegistryKey key6 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key6.CreateSubKey(name, RegistryKeyPermissionCheck.Default);
                    key6.Close();
                    CreateDefaultCommand(name);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name + "\\command", "", item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + name, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + name, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
            }
        }

        internal static void TakeOwnership(bool remove)
        {
            if (!File.Exists(Required.ReadyMadeMenus + "\\InstallTakeOwnership.reg"))
            {
                try
                {
                    File.WriteAllText(Required.ReadyMadeMenus + "\\InstallTakeOwnership.reg", Properties.Resources.InstallTakeOwnership);
                }
                catch { }
            }
            if (!File.Exists(Required.ReadyMadeMenus + "\\RemoveTakeOwnership.reg"))
            {
                try
                {
                    File.WriteAllText(Required.ReadyMadeMenus + "\\RemoveTakeOwnership.reg", Properties.Resources.RemoveTakeOwnership);
                }
                catch { }
            }
            
            if (!remove)
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\InstallTakeOwnership.reg");
            }
            else
            {
                Utilities.ImportRegistryScript(Required.ReadyMadeMenus + "\\RemoveTakeOwnership.reg");
            }
        }
    }
}
