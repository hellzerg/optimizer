using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Optimizer {
    internal static class HostsHelper {
        internal static string NewLine = Environment.NewLine;
        internal static readonly string HostsFile = CleanHelper.System32Folder + "\\drivers\\etc\\hosts";

        internal static void RestoreDefaultHosts()
        {
            try
            {
                WriteHostsAtomically(Properties.Resources.hosts);
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RestoreDefaultHosts", ex.Message, ex.StackTrace);
                FluentMessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                string[] sanitized = (lines ?? new string[0])
                    .Select(line => string.IsNullOrEmpty(line) || line.StartsWith("#", StringComparison.Ordinal) ? line ?? string.Empty : SanitizeEntry(line))
                    .ToArray();
                WriteHostsLinesAtomically(sanitized);
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.SaveHosts", ex.Message, ex.StackTrace);
                FluentMessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "Optimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string current = File.Exists(HostsFile) ? File.ReadAllText(HostsFile) : string.Empty;
                WriteHostsTextAtomically(current + NewLine + entry);
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.AddEntry", ex.Message, ex.StackTrace);
                FluentMessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void RemoveEntry(string entry)
        {
            try
            {
                WriteHostsLinesAtomically(File.ReadAllLines(HostsFile).Where(line => !string.Equals(line, entry, StringComparison.Ordinal)));
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RemoveEntry", ex.Message, ex.StackTrace);
                FluentMessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void RemoveEntryFromTemplate(string domain)
        {
            try
            {
                string normalizedDomain = NormalizeHostName(domain);
                if (normalizedDomain.Length == 0) return;

                List<string> lines = new List<string>();
                foreach (string line in File.ReadAllLines(HostsFile))
                {
                    string updatedLine = RemoveHostName(line, normalizedDomain);
                    if (updatedLine != null) lines.Add(updatedLine);
                }

                WriteHostsLinesAtomically(lines);
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
                if (collection == null || collection.Count == 0) return;

                HashSet<string> entries = new HashSet<string>(collection, StringComparer.Ordinal);
                WriteHostsLinesAtomically(File.ReadAllLines(HostsFile).Where(line => !entries.Contains(line)));
            }
            catch (Exception ex)
            {
                Logger.LogError("HostsHelper.RemoveAllEntries", ex.Message, ex.StackTrace);
                FluentMessageBox.Show(OptionsHelper.TranslationList("dnsCacheM").ToString(), "DNS Cache is running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string NormalizeHostName(string hostName)
        {
            return string.IsNullOrWhiteSpace(hostName) ? string.Empty : hostName.Trim().TrimEnd('.');
        }

        static string RemoveHostName(string line, string domain)
        {
            if (string.IsNullOrWhiteSpace(line) || line.TrimStart().StartsWith("#", StringComparison.Ordinal)) return line;

            int commentIndex = line.IndexOf('#');
            string mapping = commentIndex >= 0 ? line.Substring(0, commentIndex) : line;
            string comment = commentIndex >= 0 ? line.Substring(commentIndex) : string.Empty;
            string[] tokens = mapping.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 2) return line;

            List<string> hostNames = new List<string>();
            bool removed = false;
            for (int i = 1; i < tokens.Length; i++)
            {
                if (string.Equals(NormalizeHostName(tokens[i]), domain, StringComparison.OrdinalIgnoreCase))
                    removed = true;
                else
                    hostNames.Add(tokens[i]);
            }

            if (!removed) return line;
            if (hostNames.Count == 0) return null;

            string updated = tokens[0] + " " + string.Join(" ", hostNames);
            return comment.Length == 0 ? updated : updated + " " + comment;
        }

        static void WriteHostsLinesAtomically(IEnumerable<string> lines)
        {
            string[] values = lines == null ? new string[0] : lines.ToArray();
            string content = values.Length == 0 ? string.Empty : string.Join(Environment.NewLine, values) + Environment.NewLine;
            WriteHostsTextAtomically(content);
        }

        static void WriteHostsTextAtomically(string content)
        {
            WriteHostsAtomically(new System.Text.UTF8Encoding(false).GetBytes(content ?? string.Empty));
        }

        static void WriteHostsAtomically(byte[] contents)
        {
            string directory = Path.GetDirectoryName(HostsFile);
            string temporaryFile = Path.Combine(directory, ".hosts." + Guid.NewGuid().ToString("N") + ".tmp");
            try
            {
                using (FileStream stream = new FileStream(temporaryFile, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough))
                {
                    stream.Write(contents, 0, contents.Length);
                    stream.Flush(true);
                }

                if (File.Exists(HostsFile))
                    File.Replace(temporaryFile, HostsFile, null);
                else
                    File.Move(temporaryFile, HostsFile);
            }
            finally
            {
                if (File.Exists(temporaryFile)) File.Delete(temporaryFile);
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
