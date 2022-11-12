using Microsoft.Win32;
using System;
using System.IO;

namespace Optimizer
{
    internal class StartupItem
    {
        internal string Name { get; set; }
        internal string FileLocation { get; set; }
        internal StartupItemLocation RegistryLocation { get; set; }
        internal StartupItemType StartupType { get; set; }

        internal virtual void Remove() { }
        internal virtual void LocateFile() { }
        internal virtual void LocateKey() { }

        public override string ToString()
        {
            if (RegistryLocation == StartupItemLocation.Folder) return RegistryLocation.ToString();
            return string.Format("{0}:{1}", RegistryLocation, StartupType);
        }
    }

    internal sealed class FolderStartupItem : StartupItem
    {
        internal string Shortcut { get; set; }

        internal override void Remove()
        {
            try
            {
                if (File.Exists(Shortcut))
                {
                    File.Delete(Shortcut);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("FolderStartupItem.Remove", ex.Message, ex.StackTrace);
            }
        }

        internal override void LocateFile()
        {
            try
            {
                Utilities.FindFile(FileLocation);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("FolderStartupItem.LocateFile", ex.Message, ex.StackTrace);
            }
        }
    }

    internal sealed class RegistryStartupItem : StartupItem
    {
        internal RegistryKey Key { get; set; }

        internal override void LocateKey()
        {
            try
            {
                Utilities.FindKeyInRegistry(Key.ToString());
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("RegistryStartupItem.LocateKey", ex.Message, ex.StackTrace);
            }
        }

        internal override void Remove()
        {
            try
            {
                Key.DeleteValue(Name, false);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("RegistryStartupItem.Remove", ex.Message, ex.StackTrace);
            }
        }

        internal override void LocateFile()
        {
            try
            {
                Utilities.FindFile(SanitizePath(FileLocation));
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("RegistryStartupItem.LocateFile", ex.Message, ex.StackTrace);
            }
        }

        internal string SanitizePath(string s)
        {
            s = s.Replace("\"", string.Empty);
            int i;

            while (s.Contains("/"))
            {
                i = s.LastIndexOf("/");
                s = s.Substring(0, i);
            }

            i = s.IndexOf(".exe");
            s = s.Substring(0, i + 4);

            return s.Trim();
        }
    }
}
