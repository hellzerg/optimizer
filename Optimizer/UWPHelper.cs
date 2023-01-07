using System.Collections.Generic;
using System.Management.Automation;

namespace Optimizer
{
    internal static class UWPHelper
    {
        internal static List<KeyValuePair<string, string>> GetUWPApps(bool showAll)
        {
            List<KeyValuePair<string, string>> modernApps = new List<KeyValuePair<string, string>>();

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
                    modernApps.Add(new KeyValuePair<string, string>(tmp[0], tmp[1]));
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

        internal static bool RestoreAllUWPApps()
        {
            string cmd = "Get-AppxPackage -AllUsers | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}";

            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript(cmd);
                script.Invoke();
                return script.Streams.Error.Count > 0;
            }
        }
    }
}
