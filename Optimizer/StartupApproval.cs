using Microsoft.Win32;
using System;
using System.IO;

namespace Optimizer {
    /// <summary>
    /// Reads and writes the Enabled/Disabled state that Task Manager and Settings › Startup Apps keep under
    /// Explorer\StartupApproved (Windows 8 and newer). Each value is 12 bytes: byte 0 is even when the item is
    /// enabled and odd when disabled; bytes 4-11 hold the FILETIME of when it was disabled. A missing value means enabled.
    /// </summary>
    internal static class StartupApproval {
        const string ApprovedRoot = @"Software\Microsoft\Windows\CurrentVersion\Explorer\StartupApproved\";

        static readonly bool _supported = ComputeSupported();

        internal static bool IsSupported { get { return _supported; } }

        static bool ComputeSupported()
        {
            try
            {
                Version v = WindowChrome.OSVersion;
                return v.Major > 6 || (v.Major == 6 && v.Minor >= 2);
            }
            catch
            {
                return false;
            }
        }

        static bool TryResolve(StartupItem item, out RegistryKey hive, out string subKey, out string valueName)
        {
            hive = null;
            subKey = null;
            valueName = null;
            if (!_supported || item == null) return false;

            FolderStartupItem folder = item as FolderStartupItem;
            if (folder != null)
            {
                if (string.IsNullOrEmpty(folder.Shortcut)) return false;
                hive = item.RegistryLocation == StartupItemLocation.LMStartupFolder ? Registry.LocalMachine : Registry.CurrentUser;
                subKey = ApprovedRoot + "StartupFolder";
                valueName = Path.GetFileName(folder.Shortcut);
                return true;
            }

            if (!(item is RegistryStartupItem) || item.StartupType != StartupItemType.Run || string.IsNullOrEmpty(item.Name)) return false;

            switch (item.RegistryLocation)
            {
                case StartupItemLocation.HKCU:
                    hive = Registry.CurrentUser;
                    subKey = ApprovedRoot + "Run";
                    break;
                case StartupItemLocation.HKLM:
                    hive = Registry.LocalMachine;
                    subKey = ApprovedRoot + "Run";
                    break;
                case StartupItemLocation.HKLMWoW:
                    hive = Registry.LocalMachine;
                    subKey = ApprovedRoot + "Run32";
                    break;
                default:
                    return false;
            }
            valueName = item.Name;
            return true;
        }

        internal static bool CanToggle(StartupItem item)
        {
            RegistryKey hive;
            string subKey, valueName;
            return TryResolve(item, out hive, out subKey, out valueName);
        }

        /// <summary>
        /// Returns the item's state, or null when the item cannot be toggled on this system.
        /// </summary>
        internal static bool? GetEnabled(StartupItem item)
        {
            RegistryKey hive;
            string subKey, valueName;
            if (!TryResolve(item, out hive, out subKey, out valueName)) return null;

            try
            {
                using (RegistryKey key = hive.OpenSubKey(subKey, false))
                {
                    byte[] data = key == null ? null : key.GetValue(valueName) as byte[];
                    if (data == null || data.Length == 0) return true;
                    return (data[0] & 1) == 0;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StartupApproval.GetEnabled", ex.Message, ex.StackTrace);
                return true;
            }
        }

        internal static bool SetEnabled(StartupItem item, bool enabled)
        {
            RegistryKey hive;
            string subKey, valueName;
            if (!TryResolve(item, out hive, out subKey, out valueName)) return false;

            try
            {
                using (RegistryKey key = hive.CreateSubKey(subKey, true))
                {
                    if (key == null) return false;

                    byte[] old = key.GetValue(valueName) as byte[];
                    byte[] data = new byte[12];
                    // Keep any extra flag bits Windows stored in the first dword; only flip the "disabled" bit.
                    if (old != null && old.Length >= 4) Array.Copy(old, data, 4);
                    else data[0] = 0x02;

                    if (enabled)
                    {
                        data[0] = (byte)(data[0] & ~1);
                    }
                    else
                    {
                        data[0] = (byte)(data[0] | 1);
                        Array.Copy(BitConverter.GetBytes(DateTime.UtcNow.ToFileTimeUtc()), 0, data, 4, 8);
                    }

                    key.SetValue(valueName, data, RegistryValueKind.Binary);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StartupApproval.SetEnabled", ex.Message, ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// Re-reads the item's state into <see cref="StartupItem.CanToggle"/> and <see cref="StartupItem.Enabled"/>.
        /// </summary>
        internal static void Refresh(StartupItem item)
        {
            bool? state = GetEnabled(item);
            item.CanToggle = state.HasValue;
            item.Enabled = state ?? true;
        }
    }
}
