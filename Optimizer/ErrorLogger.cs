using System;
using System.IO;

namespace Optimizer
{
    internal static class ErrorLogger
    {
        internal static string ErrorLogFile = Required.CoreFolder + "Optimizer.log";

        internal static void LogError(string functionName, string errorMessage, string errorStackTrace)
        {
            try
            {
                if (!File.Exists(ErrorLogFile) || ( File.Exists(ErrorLogFile) && File.ReadAllText(ErrorLogFile).Trim() == string.Empty ))
                {
                    string bitness = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";

                    if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
                    {
                        File.AppendAllText(ErrorLogFile, string.Format("{0} - {1} ({2})", Utilities.GetOS(), Utilities.GetWindows10Build(), bitness));
                    }
                    else
                    {
                        File.AppendAllText(ErrorLogFile, string.Format("{0} - ({1})", Utilities.GetOS(), bitness));
                    }
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, string.Format("Optimizer {0} - .NET Framework {1} - Experimental build: {2}", Program.GetCurrentVersionTostring(), Utilities.GetNETFramework(), Program.EXPERIMENTAL_BUILD));
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                }

                File.AppendAllText(ErrorLogFile, string.Format("[ERROR] [{0}] in function [{1}]", DateTime.Now.ToString(), functionName));
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, errorMessage);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, errorStackTrace);

                // seperator
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
            }
            catch { }
        }
    }
}
