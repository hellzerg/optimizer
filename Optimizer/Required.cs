using System.IO;
using System.Text;

namespace Optimizer
{
    internal static class Required
    {
        internal readonly static string CoreFolder = CleanHelper.ProgramData + "\\Optimizer\\";
        internal readonly static string ReadyMadeMenusFolder = CleanHelper.ProgramData + "\\Optimizer\\ReadyMadeMenus\\";
        internal readonly static string ScriptsFolder = CleanHelper.ProgramData + "\\Optimizer\\Required\\";
        internal readonly static string ExtractedIconsFolder = CleanHelper.ProgramData + "\\Optimizer\\ExtractedIcons\\";
        internal readonly static string FavIconsFolder = CleanHelper.ProgramData + "\\Optimizer\\FavIcons\\";
        internal readonly static string StartupItemsBackupFolder = CleanHelper.ProgramData + "\\Optimizer\\StartupBackup\\";

        readonly static string[] readyMadeMenusItems =
        {
            ReadyMadeMenusFolder + "DesktopShortcuts.reg",
            ReadyMadeMenusFolder + "SystemShortcuts.reg",
            ReadyMadeMenusFolder + "PowerMenu.reg",
            ReadyMadeMenusFolder + "SystemTools.reg",
            ReadyMadeMenusFolder + "WindowsApps.reg",
            ReadyMadeMenusFolder + "InstallTakeOwnership.reg",
            ReadyMadeMenusFolder + "RemoveTakeOwnership.reg",
        };

        readonly static string[] readyMadeMenusFiles =
        {
            Properties.Resources.DesktopShortcuts,
            Properties.Resources.SystemShortcuts,
            Properties.Resources.PowerMenu,
            Properties.Resources.SystemTools,
            Properties.Resources.WindowsApps,
            Properties.Resources.InstallTakeOwnership,
            Properties.Resources.RemoveTakeOwnership
        };

        readonly static string[] scriptItems =
        {
            ScriptsFolder + "DisableOfficeTelemetryTasks.bat",
            ScriptsFolder + "DisableOfficeTelemetryTasks.reg",
            ScriptsFolder + "EnableOfficeTelemetryTasks.bat",
            ScriptsFolder + "EnableOfficeTelemetryTasks.reg",
            ScriptsFolder + "DisableTelemetryTasks.bat",
            ScriptsFolder + "EnableTelemetryTasks.bat",
            ScriptsFolder + "DisableXboxTasks.bat",
            ScriptsFolder + "EnableXboxTasks.bat",
            ScriptsFolder + "OneDrive_Uninstaller.cmd",
            ScriptsFolder + "GPEditEnablerInHome.bat",
            ScriptsFolder + "AddOpenWithCMD.reg"
        };

        readonly static string[] scriptFiles =
        {
            Properties.Resources.DisableOfficeTelemetryTasks,
            Properties.Resources.DisableOfficeTelemetry,
            Properties.Resources.EnableOfficeTelemetryTasks,
            Properties.Resources.EnableOfficeTelemetry,
            Properties.Resources.DisableTelemetryTasks,
            Properties.Resources.EnableTelemetryTasks,
            Properties.Resources.DisableXboxTasks,
            Properties.Resources.EnableXboxTasks,
            Encoding.UTF8.GetString(Properties.Resources.OneDrive_Uninstaller),
            Properties.Resources.GPEditEnablerInHome,
            Properties.Resources.AddOpenWithCMD
        };

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
            if (!Directory.Exists(StartupItemsBackupFolder))
            {
                Directory.CreateDirectory(StartupItemsBackupFolder);
            }

            for (int i = 0; i < readyMadeMenusItems.Length; i++)
            {
                if (!File.Exists(readyMadeMenusItems[i])) File.WriteAllText(readyMadeMenusItems[i], readyMadeMenusFiles[i]);
            }

            for (int i = 0; i < scriptItems.Length; i++)
            {
                if (!File.Exists(scriptItems[i]))
                {
                    if (scriptItems[i].Contains("OneDrive"))
                    {
                        File.WriteAllBytes(scriptItems[i], Encoding.UTF8.GetBytes(scriptFiles[i]));
                    }
                    else
                    {
                        File.WriteAllText(scriptItems[i], scriptFiles[i]);
                    }
                }
            }
        }
    }
}
