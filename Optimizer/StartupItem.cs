using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optimizer
{
    public class StartupItem
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public StartupItemLocation RegistryLocation { get; set; }
        public StartupItemType RegistryType { get; set; }

        public virtual void Remove() { }
        public virtual void LocateFile() { }
        public virtual void LocateKey() { }

        public override string ToString()
        {
            if (RegistryLocation == StartupItemLocation.Folder) return RegistryLocation.ToString();
            return string.Format("{0}:{1}", RegistryLocation, RegistryType);
        }
    }

    public class FolderStartupItem : StartupItem
    {
        public string Shortcut { get; set; }

        public override void Remove()
        {
            try
            {
                if (File.Exists(Shortcut))
                {
                    File.Delete(Shortcut);
                }
            }
            catch { }
        }

        public override void LocateFile()
        {
            try
            {
                CleanHelper.FindFile(Location);
            }
            catch { }
        }
    }

    public class RegistryStartupItem : StartupItem
    {
        public RegistryKey Key { get; set; }

        public override void LocateKey()
        {
            try
            {
                CleanHelper.FindKeyInRegistry(Key.ToString());
            }
            catch { }
            //finally { Key.Close(); }
        }

        public override void Remove()
        {
            try
            {
                Key.DeleteValue(Name, false);
            }
            catch { }
            finally { Key.Close(); }
        }

        public override void LocateFile()
        {
            try
            {
                CleanHelper.FindFile(SanitizePath(Location));
            }
            catch { }
        }

        private string SanitizePath(string s)
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

        //private int CountOccurences(string data, string occurence)
        //{
        //    return (data.Length - data.Replace(occurence, string.Empty).Length) / occurence.Length;
        //}

        //private string SanitizePath(string s)
        //{
        //    string n = "";

        //    Regex r = new Regex("\".*?\"");
        //    var matches = r.Matches(s);

        //    if (matches.Count > 0)
        //    {
        //        s = matches[0].ToString();
        //    }

        //    foreach (char c in s)
        //    {
        //        if (c != '"')
        //        {
        //            n += c;
        //        }
        //    }

        //    int i = n.LastIndexOf(".exe");
        //    n = n.Substring(0, i + 4);

        //    return n;
        //}
    }
}
