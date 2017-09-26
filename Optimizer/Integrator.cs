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
        private static string nl = Environment.NewLine;

        internal static string powerinfo = "Power Menu contains the following:" + nl + nl + "Lock" + nl + "Sign out" + nl + "Switch User" + nl + "Sleep" + nl + "Hibernate" + nl + "Restart" + nl + "Restart with Boot Options Menu" + nl + "Shut down" + nl + "Shut down (Hybrid)";
        internal static string systemtoolsinfo = "System Tools Menu contains the following:" + nl + nl + "Control Panel" + nl + "Disk Cleanup" + nl + "Device Manager" + nl + "Event Viewer" + nl + "Registry Editor" + nl + "Security Center" + nl + "System Configuration" + nl + "Task Manager" + nl + "Task Scheduler" + nl + "Windows Update";
        internal static string systemshortcutsinfo = "System Shortcuts Menu contains the following:" + nl + nl + "Administrative Tools" + nl + "Change Date and Time" + nl + "Change Regional Settings" + nl + "Folder Options" + nl + "God Mode" + nl + "Internet Options" + nl + "Network Connections" + nl + "Power Options" + nl + "Programs and Features" + nl + "Recycle Bin" + nl + "Run" + nl + "Search" + nl + "Services" + nl + "System Properties" + nl + "User Accounts" + nl + "User Accounts Classic" + nl + "Window Switcher";
        internal static string desktopshortcutsinfo = "Desktop Shortcuts Menu contains the following:" + nl + nl + "Change Theme" + nl + "Change Wallpaper" + nl + "Change Screen Saver" + nl + "Change Desktop Icons" + nl + "Change Sound Scheme" + nl + "Change Mouse Pointers" + nl + "Change DPI Scaling" + nl + "Change Window Color and Appearance";
        internal static string windowsappsinfo = "Windows Apps Menu contains the following:" + nl + nl + "Calculator" + nl + "Character Map" + nl + "Command Prompt" + nl + "Disk Defragmenter" + nl + "Internet Explorer" + nl + "Notepad" + nl + "Paint" + nl + "Problem Steps Recorder" + nl + "Snipping Tool" + nl + "Sound Recorder" + nl + "System Restore" + nl + "Task Scheduler" + nl + "Windows Media Player" + nl + "Wordpad";

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

            string regkey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + keyword;
            
            Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + keyword);
            Registry.SetValue(regkey, "", file);
            Registry.SetValue(regkey, "Path", file.Substring(0, file.LastIndexOf("\\")));
        }

        internal static List<string> GetCustomCommands()
        {
            List<string> items = new List<string>();
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\");

            foreach (string cmd in key.GetSubKeyNames())
            {
                items.Add(cmd);
            }

            key.Close();

            return items;
        }

        internal static void DeleteCustomCommand(string name)
        {
            Registry.LocalMachine.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + name);
        }

        private static void CreateDefaultCommand(string itemnick)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + itemnick, true);
            key.CreateSubKey("command", RegistryKeyPermissionCheck.Default);
            key.Close();
        }

        internal static List<string> GetDesktopItems()
        {
            List<string> items = new List<string>();
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", false);

            foreach (string item in key.GetSubKeyNames())
            {
                items.Add(item);
            }

            // filter the list, so the default items will not be visible
            if (items.Contains("Gadgets")) { items.Remove("Gadgets"); }
            if (items.Contains("Display")) { items.Remove("Display"); }
            if (items.Contains("Personalize")) { items.Remove("Personalize"); }

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

        internal static string ExtractIconFromExecutable(string itemnick, string exe)
        {
            string iconpath = string.Empty;

            if (File.Exists(exe))
            {
                Icon ico = Icon.ExtractAssociatedIcon(exe);
                Clipboard.SetImage(ico.ToBitmap());
                Clipboard.GetImage().Save(Required.ExtractedIcons + "\\" + itemnick + ".ico", System.Drawing.Imaging.ImageFormat.Bmp);
                Clipboard.Clear();

                iconpath = Required.ExtractedIcons + "\\" + itemnick + ".ico";
            }

            return iconpath;
        }

        internal static string DownloadFavicon(string link, string nick)
        {
            string favicon = string.Empty;

            try
            {
                Uri url = new Uri(link);
                if (url.HostNameType == UriHostNameType.Dns)
                {
                    Image.FromStream(((HttpWebResponse)WebRequest.Create("http://" + url.Host + "/favicon.ico").GetResponse()).GetResponseStream()).Save(Required.FavIcons + nick + ".ico", ImageFormat.Bmp);
                    favicon = Required.FavIcons + nick + ".ico";
                }
            }
            catch
            {
                
            }

            return favicon;
        }

        internal static void AddItem(string nick, string item, string icon, DesktopTypePosition position, bool shift, DesktopItemType type)
        {
            switch (type)
            {
                case DesktopItemType.Program:
                    RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key.CreateSubKey(nick, RegistryKeyPermissionCheck.Default);
                    key.Close();
                    CreateDefaultCommand(nick);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick + "\\command", "", item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + nick, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Folder:
                    RegistryKey key3 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key3.CreateSubKey(nick, RegistryKeyPermissionCheck.Default);
                    key3.Close();
                    CreateDefaultCommand(nick);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick + "\\command", "", "explorer " + item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + nick, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Link:
                    RegistryKey key4 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key4.CreateSubKey(nick, RegistryKeyPermissionCheck.Default);
                    key4.Close();
                    CreateDefaultCommand(nick);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick + "\\command", "", "explorer " + item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + nick, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.File:
                    RegistryKey key5 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key5.CreateSubKey(nick, RegistryKeyPermissionCheck.Default);
                    key5.Close();
                    CreateDefaultCommand(nick);
                    string def = @"""";
                    string def2 = "explorer.exe";

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick + "\\command", "", def2 + " " + def + item + def);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + nick, true);
                        key2.DeleteValue("Extended", false);
                        key2.Close();
                    }

                    break;
                case DesktopItemType.Command:
                    RegistryKey key6 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
                    key6.CreateSubKey(nick, RegistryKeyPermissionCheck.Default);
                    key6.Close();
                    CreateDefaultCommand(nick);

                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick + "\\command", "", item);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Icon", icon);
                    Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Position", position.ToString());

                    if (shift)
                    {
                        Registry.SetValue(@"HKEY_CLASSES_ROOT\DesktopBackground\Shell\" + nick, "Extended", "");
                    }
                    else
                    {
                        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\" + nick, true);
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
                Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\InstallTakeOwnership.reg");
            }
            else
            {
                Optimize.ImportRegistryScript(Required.ReadyMadeMenus + "\\RemoveTakeOwnership.reg");
            }
        }
    }
}
