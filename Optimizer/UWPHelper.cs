using System.Collections.Generic;
using System.Management.Automation;

namespace Optimizer
{
    internal static class UWPHelper
    {
        internal static List<string> GetUWPApps(bool showAll)
        {
            List<string> modernApps = new List<string>();

            using (PowerShell script = PowerShell.Create())
            {
                if (showAll)
                {
                    script.AddScript("Get-AppxPackage | Select -Unique Name | Out-String -Stream");
                }
                else
                {
                    script.AddScript(@"Get-AppxPackage | Where {$_.NonRemovable -like ""False""} | Select -Unique Name | Out-String -Stream");
                }

                string tmp = string.Empty;
                foreach (PSObject x in script.Invoke())
                {
                    tmp = x.ToString().Trim();
                    if (!string.IsNullOrEmpty(tmp) && !tmp.Contains("---") && !tmp.Equals("Name"))
                    {
                        modernApps.Add(tmp);
                    }
                }
            }

            return modernApps;
        }

        internal static bool UninstallUWPApp(string appName)
        {
            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript(string.Format("Get-AppxPackage -AllUsers '{0}' | Remove-AppxPackage", appName));

                script.Invoke();

                return script.Streams.Error.Count > 0;

                // not working on Windows 7 anymore
                //return script.HadErrors;
            }
        }

        // TODO: Reinstall default pre-installed apps
    }
}
