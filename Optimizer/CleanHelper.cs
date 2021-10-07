using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Optimizer
{
    internal static class CleanHelper
    {
        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        internal static readonly string System32Folder = Environment.GetFolderPath(Environment.SpecialFolder.System);
        internal static readonly string TempFolder = Path.GetTempPath();
        internal static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        internal static readonly string ProfileAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //internal static readonly string ProfileAppDataLocalLow = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low";
        //internal static readonly string OSDrive = System32Folder.Substring(0, 3);
        internal static readonly string OSDriveWindows = Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine);

        internal static List<string> PreviewCleanList = new List<string>();

        internal static void PreviewFolder(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (FileInfo file in di.GetFiles("*", SearchOption.AllDirectories))
                {
                    try
                    {
                        PreviewCleanList.Add(file.FullName);
                    }
                    catch { }
                }

                foreach (DirectoryInfo dir in di.GetDirectories("*", SearchOption.AllDirectories))
                {
                    try
                    {
                        PreviewCleanList.Add(dir.FullName);
                    }
                    catch { }
                }
            }
            catch { }
        }

        internal static void Clean()
        {
            foreach (string x in PreviewCleanList)
            {
                try
                {
                    if (Directory.Exists(x)) Directory.Delete(x);
                    if (File.Exists(x)) File.Delete(x);
                }
                catch { }
            }
        }

        internal static void EmptyRecycleBin()
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlag.SHERB_NOSOUND | RecycleFlag.SHERB_NOCONFIRMATION);
        }

        internal static void PreviewTemp()
        {
            PreviewFolder(TempFolder);
        }

        internal static void PreviewMinidumps()
        {
            PreviewFolder(OSDriveWindows + "\\Minidump");
        }

        internal static void PreviewErrorReports()
        {
            PreviewFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportArchive");
            PreviewFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ReportQueue");
            PreviewFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\Temp");
            PreviewFolder(ProfileAppDataLocal + "\\Microsoft\\Windows\\WER\\ERC");
            PreviewFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportArchive");
            PreviewFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ReportQueue");
            PreviewFolder(ProgramData + "\\Microsoft\\Windows\\WER\\Temp");
            PreviewFolder(ProgramData + "\\Microsoft\\Windows\\WER\\ERC");
        }

        // only for TEMP folder
        internal static ByteSize CheckFootprint()
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(TempFolder);
                return ByteSize.FromBytes(info.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("CleanHelper.CleanLogs", ex.Message, ex.StackTrace);
                return ByteSize.FromBytes(0);
            }
        }
    }
}
