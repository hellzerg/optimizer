using System.IO;

namespace Optimizer
{
    internal static class Required
    {
        internal readonly static string CoreFolder = CleanHelper.ProgramData + "\\Optimizer\\";
        internal readonly static string ReadyMadeMenusFolder = CleanHelper.ProgramData + "\\Optimizer\\ReadyMadeMenus\\";
        internal readonly static string ScriptsFolder = CleanHelper.ProgramData + "\\Optimizer\\Required\\";
        internal readonly static string ExtractedIconsFolder = CleanHelper.ProgramData + "\\Optimizer\\ExtractedIcons\\";
        internal readonly static string FavIconsFolder = CleanHelper.ProgramData + "\\Optimizer\\FavIcons\\";

        internal static void Deploy()
        {
            if (!Directory.Exists(CoreFolder))
            {
                Directory.CreateDirectory(CoreFolder);
            }
            if (!Directory.Exists(ReadyMadeMenusFolder))
            {
                Directory.CreateDirectory(ReadyMadeMenusFolder);
            }
            if (!Directory.Exists(ScriptsFolder))
            {
                Directory.CreateDirectory(ScriptsFolder);
            }
            if (!Directory.Exists(ExtractedIconsFolder))
            {
                Directory.CreateDirectory(ExtractedIconsFolder);
            }
            if (!Directory.Exists(FavIconsFolder))
            {
                Directory.CreateDirectory(FavIconsFolder);
            }

            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "DesktopShortcuts.reg", Properties.Resources.DesktopShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "SystemShortcuts.reg", Properties.Resources.SystemShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "PowerMenu.reg", Properties.Resources.PowerMenu);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "SystemTools.reg", Properties.Resources.SystemTools);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "WindowsApps.reg", Properties.Resources.WindowsApps);
            }
            catch { }

            try
            {
                File.WriteAllText(ScriptsFolder + "DisableOfficeTelemetryTasks.bat", Properties.Resources.DisableOfficeTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableOfficeTelemetryTasks.reg", Properties.Resources.DisableOfficeTelemetry);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableOfficeTelemetryTasks.bat", Properties.Resources.EnableOfficeTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableOfficeTelemetryTasks.reg", Properties.Resources.EnableOfficeTelemetry);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableTelemetryTasks.bat", Properties.Resources.DisableTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableTelemetryTasks.bat", Properties.Resources.EnableTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableXboxTasks.bat", Properties.Resources.DisableXboxTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableXboxTasks.bat", Properties.Resources.EnableXboxTasks);
            }
            catch { }
            try
            {
                File.WriteAllBytes(ScriptsFolder + "OneDrive_Uninstaller.cmd", Properties.Resources.OneDrive_Uninstaller);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "InstallTakeOwnership.reg", Properties.Resources.InstallTakeOwnership);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "RemoveTakeOwnership.reg", Properties.Resources.RemoveTakeOwnership);
            }
            catch { }
        }

        internal static void Clean()
        {
            CleanHelper.EmptyFolder(CoreFolder);
        }
    }
}
