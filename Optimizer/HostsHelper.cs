using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optimizer
{
    internal static class HostsHelper
    {
        internal static string NewLine = Environment.NewLine;
        internal static readonly string HostsFile = CleanHelper.System32Folder + "\\drivers\\etc\\hosts";

        internal static void RestoreDefaultHosts()
        {
            try
            {
                if (File.Exists(HostsFile))
                {
                    File.Delete(HostsFile);
                }

                File.WriteAllBytes(HostsFile, Properties.Resources.hosts);
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RestoreDefaultHosts", ex.Message, ex.StackTrace);
                MessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static string[] ReadHosts()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamReader sr = File.OpenText(HostsFile))
                {
                    sb.Append(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.ReadHosts", ex.Message, ex.StackTrace);
            }

            return sb.ToString().Split(Environment.NewLine.ToCharArray());
            //return File.ReadAllLines(HostsFile);
        }

        internal static string ReadHostsFast()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamReader sr = File.OpenText(HostsFile))
                {
                    sb.Append(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.ReadHostsFast", ex.Message, ex.StackTrace);
            }

            return sb.ToString();
        }

        internal static void LocateHosts()
        {
            Utilities.FindFile(HostsFile);
        }

        internal static void SaveHosts(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].StartsWith("#") && (!string.IsNullOrEmpty(lines[i])))
                {
                    lines[i] = SanitizeEntry(lines[i]);
                }
            }

            try
            {
                File.WriteAllText(HostsFile, string.Empty);
                File.WriteAllLines(HostsFile, lines);
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.SaveHosts", ex.Message, ex.StackTrace);
                MessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static List<string> GetHostsEntries()
        {
            List<string> entries = new List<string>();

            //string[] lines = File.ReadAllLines(HostsFile);
            string[] lines = ReadHosts();

            foreach (string line in lines)
            {
                if (!line.StartsWith("#") && (!string.IsNullOrEmpty(line)))
                {
                    entries.Add(line.Replace(" ", " : "));
                }
            }

            return entries;
        }

        internal static void AddEntry(string entry)
        {
            try
            {
                File.AppendAllText(HostsFile, NewLine + $"{entry}");
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.AddEntry", ex.Message, ex.StackTrace);
                MessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void RemoveEntry(string entry)
        {
            try
            {
                File.WriteAllLines(HostsFile, File.ReadLines(HostsFile).Where(x => x != entry).ToList());
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RemoveEntry", ex.Message, ex.StackTrace);
                MessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void RemoveEntryFromTemplate(string domain)
        {
            try
            {
                File.WriteAllLines(HostsFile, File.ReadLines(HostsFile).Where(x => !x.Contains(domain)).ToList());
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RemoveEntryFromTemplate", ex.Message, ex.StackTrace);
            }
        }

        internal static void RemoveAllEntries(List<string> collection)
        {
            try
            {
                foreach (string text in collection)
                {
                    File.WriteAllLines(HostsFile, File.ReadLines(HostsFile).Where(l => l != text).ToList());
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RemoveAllEntries", ex.Message, ex.StackTrace);
                MessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static string SanitizeEntry(string entry)
        {
            // remove multiple white spaces and keep only one
            return Regex.Replace(entry, @"\s{2,}", " ");
        }

        internal static bool GetReadOnly()
        {
            try
            {
                return new FileInfo(HostsFile).IsReadOnly;
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.ReadOnly", ex.Message, ex.StackTrace);
                return false;
            }
        }

        internal static void ReadOnly(bool enable)
        {
            try
            {
                FileInfo fi = new FileInfo(HostsFile);
                fi.IsReadOnly = enable;
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.ReadOnly", ex.Message, ex.StackTrace);
            }
        }
    }
}
