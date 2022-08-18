using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Windows.Forms;

namespace Optimizer
{
    internal static class UWPHelper
    {
        internal static Dictionary<string, string> GetUWPApps(bool showAll)
        {
            Dictionary<string, string> modernApps = new Dictionary<string, string>();

            using (PowerShell script = PowerShell.Create())
            {
                if (showAll)
                {
                    script.AddScript("Get-AppxPackage | Select Name,InstallLocation");
                }
                else
                {
                    script.AddScript(@"Get-AppxPackage | Where {$_.NonRemovable -like ""False""} | Select  Name,InstallLocation");
                }

                string[] tmp;
                

                foreach (PSObject x in script.Invoke())
                {
                    tmp = x.ToString().Replace("@", string.Empty).Replace("{", string.Empty).Replace("}", string.Empty).Replace("Name=", string.Empty).Replace("InstallLocation=", string.Empty).Trim().Split(';');

                    modernApps.Add(tmp[0], tmp[1]);
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
