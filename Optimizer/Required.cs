using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Optimizer
{
    public static class Required
    {
        internal readonly static string CoreFolder = CleanHelper.ProgramData + "\\Optimizer\\";
        internal readonly static string ReadyMadeMenus = CleanHelper.ProgramData + "\\Optimizer\\ReadyMadeMenus\\";
        internal readonly static string RequiredFolder = CleanHelper.ProgramData + "\\Optimizer\\Required\\";
        internal readonly static string ExtractedIcons = CleanHelper.ProgramData + "\\Optimizer\\ExtractedIcons\\";
        internal readonly static string FavIcons = CleanHelper.ProgramData + "\\Optimizer\\FavIcons\\";

        internal static void Deploy()
        {
            if (!Directory.Exists(CoreFolder))
            {
                Directory.CreateDirectory(CoreFolder);
            }
            if (!Directory.Exists(ReadyMadeMenus))
            {
                Directory.CreateDirectory(ReadyMadeMenus);
            }
            if (!Directory.Exists(RequiredFolder))
            {
                Directory.CreateDirectory(RequiredFolder);
            }
            if (!Directory.Exists(ExtractedIcons))
            {
                Directory.CreateDirectory(ExtractedIcons);
            }
            if (!Directory.Exists(FavIcons))
            {
                Directory.CreateDirectory(FavIcons);
            }

            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\DesktopShortcuts.reg", Properties.Resources.DesktopShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\SystemShortcuts.reg", Properties.Resources.SystemShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\PowerMenu.reg", Properties.Resources.PowerMenu);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\SystemTools.reg", Properties.Resources.SystemTools);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\WindowsApps.reg", Properties.Resources.WindowsApps);
            }
            catch { }

            try
            {
                File.WriteAllText(RequiredFolder + "\\DisableOfficeTelemetryTasks.bat", Properties.Resources.DisableOfficeTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(RequiredFolder + "\\DisableOfficeTelemetryTasks.reg", Properties.Resources.DisableOfficeTelemetry);
            }
            catch { }
            try
            {
                File.WriteAllText(RequiredFolder + "\\DisableTelemetryTasks.bat", Properties.Resources.DisableTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(RequiredFolder + "\\DisableXboxTasks.bat", Properties.Resources.DisableXboxTasks);
            }
            catch { }
            try
            {
                File.WriteAllBytes(RequiredFolder + "\\OneDrive_Uninstaller.cmd", Properties.Resources.OneDrive_Uninstaller);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\InstallTakeOwnership.reg", Properties.Resources.InstallTakeOwnership);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenus + "\\RemoveTakeOwnership.reg", Properties.Resources.RemoveTakeOwnership);
            }
            catch { }
        }

        internal static void Clean()
        {
            CleanHelper.EmptyFolder(CoreFolder);
        }
    }
}
