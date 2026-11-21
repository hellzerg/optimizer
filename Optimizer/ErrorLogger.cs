using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Optimizer {
    internal static class Logger {
        internal static string ErrorLogFile = Path.Combine(CoreHelper.CoreFolder, "Optimizer.log");

        static readonly object _logSync = new object();
        static string _checkedHeaderFile;
        static StringBuilder _silentReportLog;

        private static void LogErrorSilent(string functionName, string errorMessage, string errorStackTrace)
        {
            _silentReportLog.AppendLine(string.Format("[ERROR] [{0}] in function [{1}]", DateTime.Now.ToString(), functionName));
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine(errorMessage);
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine(errorStackTrace);
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine();
        }

        internal static void LogInfoSilent(string message)
        {
            _silentReportLog.AppendLine($"[OK] {message}");
            _silentReportLog.AppendLine();
        }

        internal static void InitializeSilentReport()
        {
            _silentReportLog = new StringBuilder();

            _silentReportLog.AppendLine(Utilities.GetWindowsDetails());
            _silentReportLog.AppendLine(string.Format("Optimizer {0} - .NET Framework {1} - Experimental build: {2}", Program.GetCurrentVersionTostring(), Utilities.GetNETFramework(), Program.EXPERIMENTAL_BUILD));
            _silentReportLog.AppendLine($"{DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}");

            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine();
        }

        internal static void GenerateSilentReport()
        {
            try
            {
                File.WriteAllText($"Optimizer.SilentReport.{DateTime.Now.ToString("yyyyMMddTHHmm")}.log", _silentReportLog.ToString());
            }
            catch { }
        }

        internal static void LogError(string functionName, string errorMessage, string errorStackTrace)
        {
            if (Program.SILENT_MODE)
            {
                LogErrorSilent(functionName, errorMessage, errorStackTrace);
                return;
            }

            try
            {
                lock (_logSync)
                {
                    EnsureLogHeader();

                    StringBuilder entry = new StringBuilder();
                    entry.AppendLine(string.Format("[ERROR] [{0}] in function [{1}]", DateTime.Now.ToString(), functionName));
                    entry.AppendLine();
                    entry.AppendLine(errorMessage);
                    entry.AppendLine();
                    entry.AppendLine(errorStackTrace);
                    entry.AppendLine();
                    entry.AppendLine();
                    entry.AppendLine();
                    File.AppendAllText(ErrorLogFile, entry.ToString());
                }
            }
            catch { }
        }

        static void EnsureLogHeader()
        {
            if (string.Equals(_checkedHeaderFile, ErrorLogFile, StringComparison.OrdinalIgnoreCase)) return;

            bool checkedSuccessfully = false;
            try
            {
                string currentVersion = Program.Major.ToString(CultureInfo.InvariantCulture) + "." + Program.Minor.ToString(CultureInfo.InvariantCulture);
                Version parsedCurrent;
                if (!Version.TryParse(currentVersion, out parsedCurrent)) return;

                if (!File.Exists(ErrorLogFile) || new FileInfo(ErrorLogFile).Length == 0)
                {
                    StringBuilder header = new StringBuilder();
                    header.AppendLine(Utilities.GetWindowsDetails());
                    header.AppendLine(string.Format("Optimizer {0} - .NET Framework {1} - Experimental build: {2}", currentVersion, Utilities.GetNETFramework(), Program.EXPERIMENTAL_BUILD));
                    header.AppendLine();
                    header.AppendLine();
                    File.AppendAllText(ErrorLogFile, header.ToString());
                    checkedSuccessfully = true;
                    return;
                }

                string contents = File.ReadAllText(ErrorLogFile);
                int lineStart = 0;
                while (lineStart < contents.Length)
                {
                    int lineEnd = contents.IndexOf('\n', lineStart);
                    int lineLength = (lineEnd < 0 ? contents.Length : lineEnd) - lineStart;
                    string line = contents.Substring(lineStart, lineLength).TrimEnd('\r');

                    const string prefix = "Optimizer ";
                    if (line.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    {
                        int versionStart = prefix.Length;
                        int separator = line.IndexOf(" - ", versionStart, StringComparison.Ordinal);
                        Version loggedVersion;
                        string loggedVersionText = separator > versionStart ? line.Substring(versionStart, separator - versionStart) : string.Empty;
                        bool versionParsed = Version.TryParse(loggedVersionText, out loggedVersion)
                            || Version.TryParse(loggedVersionText.Replace(',', '.'), out loggedVersion);
                        if (separator > versionStart && versionParsed && loggedVersion < parsedCurrent)
                        {
                            string updatedLine = line.Substring(0, versionStart) + currentVersion + line.Substring(separator);
                            string updatedContents = contents.Substring(0, lineStart) + updatedLine + contents.Substring(lineStart + line.Length);
                            WriteLogAtomically(updatedContents);
                        }

                        break;
                    }

                    if (lineEnd < 0) break;
                    lineStart = lineEnd + 1;
                }

                checkedSuccessfully = true;
            }
            catch { }
            finally
            {
                if (checkedSuccessfully) _checkedHeaderFile = ErrorLogFile;
            }
        }

        static void WriteLogAtomically(string contents)
        {
            string directory = Path.GetDirectoryName(ErrorLogFile);
            string temporaryFile = Path.Combine(directory, Path.GetFileName(ErrorLogFile) + "." + Guid.NewGuid().ToString("N") + ".tmp");
            try
            {
                byte[] bytes = new UTF8Encoding(false).GetBytes(contents);
                using (FileStream stream = new FileStream(temporaryFile, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.WriteThrough))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush(true);
                }

                File.Replace(temporaryFile, ErrorLogFile, null);
            }
            finally
            {
                if (File.Exists(temporaryFile)) File.Delete(temporaryFile);
            }
        }
    }
}
