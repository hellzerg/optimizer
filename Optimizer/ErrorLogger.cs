using System;
using System.IO;

namespace Optimizer
{
    internal static class ErrorLogger
    {
        internal static string ErrorLogFile = Path.Combine(Required.CoreFolder, "Optimizer.log");

        internal static void LogError(string functionName, string errorMessage, string errorStackTrace)
        {
            try
            {
                if (!File.Exists(ErrorLogFile) || (File.Exists(ErrorLogFile) && File.ReadAllText(ErrorLogFile).Trim() == string.Empty))
                {
                    File.AppendAllText(ErrorLogFile, Utilities.GetWindowsDetails());
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
            finally
            {
                if (!Options.CurrentOptions.DisableOptimizerTelemetry)
                {
                    TelemetryHelper.GenerateTelemetryData(functionName, errorMessage, errorStackTrace);
                }
            }
        }
    }
}
