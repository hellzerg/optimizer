using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optimizer
{
    internal static class HostsHelper
    {
        internal static string NewLine = Environment.NewLine;
        internal static readonly string HostsFile = CleanHelper.System32Folder + "\\drivers\\etc\\hosts";

        //static string AdBlockBasicLink = "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling/hosts";
        //static string AdBlockWithPornLink = "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-porn/hosts";
        //static string AdBlockWithSocialLink = "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-social/hosts";
        //static string AdBlockUltimateLink = "https://raw.githubusercontent.com/StevenBlack/hosts/master/alternates/fakenews-gambling-porn-social/hosts";

        static WebClient _client = new WebClient()
        {
            Encoding = Encoding.UTF8
        };

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
                ErrorLogger.LogError("HostsHelper.RestoreDefaultHosts", ex.Message, ex.StackTrace);
                MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //internal static void AdblockBasic()
        //{
        //    try
        //    {
        //        if (File.Exists(HostsFile))
        //        {
        //            File.Delete(HostsFile);
        //        }

        //        File.WriteAllText(HostsFile, _client.DownloadString(AdBlockBasicLink));
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogger.LogError("HostsHelper.AdblockBasic", ex.Message, ex.StackTrace);
        //        MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //internal static void AdBlockWithPorn()
        //{
        //    try
        //    {
        //        if (File.Exists(HostsFile))
        //        {
        //            File.Delete(HostsFile);
        //        }

        //        File.WriteAllText(HostsFile, _client.DownloadString(AdBlockWithPornLink));
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogger.LogError("HostsHelper.AdBlockWithPorn", ex.Message, ex.StackTrace);
        //        MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //internal static void AdBlockWithSocial()
        //{
        //    try
        //    {
        //        if (File.Exists(HostsFile))
        //        {
        //            File.Delete(HostsFile);
        //        }

        //        File.WriteAllText(HostsFile, _client.DownloadString(AdBlockWithSocialLink));
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogger.LogError("HostsHelper.AdBlockWithSocial", ex.Message, ex.StackTrace);
        //        MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //internal static void AdBlockUltimate()
        //{
        //    try
        //    {
        //        if (File.Exists(HostsFile))
        //        {
        //            File.Delete(HostsFile);
        //        }

        //        File.WriteAllText(HostsFile, _client.DownloadString(AdBlockUltimateLink));
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogger.LogError("HostsHelper.AdBlockUltimate", ex.Message, ex.StackTrace);
        //        MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

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
                ErrorLogger.LogError("HostsHelper.ReadHosts", ex.Message, ex.StackTrace);
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
                ErrorLogger.LogError("HostsHelper.ReadHostsFast", ex.Message, ex.StackTrace);
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
                ErrorLogger.LogError("HostsHelper.SaveHosts", ex.Message, ex.StackTrace);
                MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                File.AppendAllText(HostsFile, NewLine + entry);
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("HostsHelper.AddEntry", ex.Message, ex.StackTrace);
                MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ErrorLogger.LogError("HostsHelper.RemoveEntry", ex.Message, ex.StackTrace);
                MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ErrorLogger.LogError("HostsHelper.RemoveAllEntries", ex.Message, ex.StackTrace);
                MessageBox.Show(Options.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ErrorLogger.LogError("HostsHelper.ReadOnly", ex.Message, ex.StackTrace);
                return false;
            }
        }

        // edit read-only attibute
        internal static void ReadOnly(bool enable)
        {
            try
            {
                FileInfo fi = new FileInfo(HostsFile);
                fi.IsReadOnly = enable;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("HostsHelper.ReadOnly", ex.Message, ex.StackTrace);
            }
        }
    }
}
