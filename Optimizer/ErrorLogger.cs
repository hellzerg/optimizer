using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                File.AppendAllText(ErrorLogFile, string.Format("[ERROR] in function [{0}]", functionName));
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
