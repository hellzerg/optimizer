using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Optimizer
{
    internal static class StartupHelper
    {
        internal static readonly string LocalMachineRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string LocalMachineRunWoW = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string LocalMachineRunOnceWow = "Software\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce";
        internal static readonly string CurrentUserRun = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
        internal static readonly string CurrentUserRunOnce = "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce";

        internal static readonly string LocalMachineStartupFolder = CleanHelper.ProgramData + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";
        internal static readonly string CurrentUserStartupFolder = CleanHelper.ProfileAppDataRoaming + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup";

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
                try
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
                            catch (Exception ex)
                            {
                                ErrorLogger.LogError("Utilities.GetRegistryStartupItemsHelper", ex.Message, ex.StackTrace);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.GetRegistryStartupItemsHelper", ex.Message, ex.StackTrace);
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
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.GetFolderStartupItemsHelper", ex.Message, ex.StackTrace);
                }
            }

            foreach (string shortcut in shortcuts)
            {
                try
                {
                    FolderStartupItem item = new FolderStartupItem();
                    item.Name = Path.GetFileNameWithoutExtension(shortcut);
                    item.FileLocation = Utilities.GetShortcutTargetFile(shortcut);
                    item.Shortcut = shortcut;
                    item.RegistryLocation = StartupItemLocation.Folder;

                    list.Add(item);
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogError("Utilities.GetFolderStartupItemsHelper", ex.Message, ex.StackTrace);
                }
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

            if (Directory.Exists(CurrentUserStartupFolder))
            {
                string[] currentUserFiles = Directory.EnumerateFiles(CurrentUserStartupFolder, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".exe") || s.EndsWith(".bat")).ToArray();
                string[] currentUserShortcuts = Directory.GetFiles(CurrentUserStartupFolder, "*.lnk", SearchOption.AllDirectories);
                GetFolderStartupItemsHelper(ref startupItems, currentUserFiles, currentUserShortcuts);
            }

            if (Directory.Exists(LocalMachineStartupFolder))
            {
                string[] localMachineFiles = Directory.EnumerateFiles(LocalMachineStartupFolder, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".exe") || s.EndsWith(".bat")).ToArray();
                string[] localMachineShortcuts = Directory.GetFiles(LocalMachineStartupFolder, "*.lnk", SearchOption.AllDirectories);
                GetFolderStartupItemsHelper(ref startupItems, localMachineFiles, localMachineShortcuts);
            }

            return startupItems;
        }
    }
}
