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

        // SYSTEM FOLDERS
        internal static readonly string System32Folder = Environment.GetFolderPath(Environment.SpecialFolder.System);
        internal static readonly string TempFolder = Path.GetTempPath();
        internal static readonly string ProfileAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static readonly string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        internal static readonly string ProfileAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //internal static readonly string ProfileAppDataLocalLow = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low";
        //internal static readonly string OSDrive = System32Folder.Substring(0, 3);
        internal static readonly string OSDriveWindows = Environment.GetEnvironmentVariable("WINDIR", EnvironmentVariableTarget.Machine);

        // INTERNET EXPLORER CACHE
        static string[] ieCache =
        {
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\INetCache\\IE"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WebCache.old")
        };

        // CHROME FOLDERS
        static string chromeFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\Google\\Chrome\\User Data");
        static string[] chromeUserDataCacheDirs = { "Default\\Cache", "Default\\Code Cache\\", "Default\\GPUCache\\", "ShaderCache", "Default\\Service Worker\\CacheStorage\\", "Default\\Service Worker\\ScriptCache\\", "GrShaderCache\\GPUCache\\", "Default\\File System\\", "Default\\JumpListIconsMostVisited\\", "Default\\JumpListIconsRecentClosed\\", "Default\\Service Worker\\Database" };
        static string chromePasswordsDir = Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Login Data");
        static string[] chromeSessionDirs =
        {
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Sessions"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Session Storage"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Extension State"),
        };
        static string[] chromeCookiesDirs =
        {
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\IndexedDB"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Cookies"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\Cookies-journal")
        };
        static string[] chromeHistoryDirs =
        {
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\History"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\History Provider Cache"),
            Path.Combine(ProfileAppDataLocal, "Google\\Chrome\\User Data\\Default\\History-journal")
        };

        // FIREFOX FOLDERS
        static string firefoxRoaming = Path.Combine(ProfileAppDataRoaming, "Mozilla\\Firefox\\Profiles");
        static string firefoxLocal = Path.Combine(ProfileAppDataLocal, "Mozilla\\Firefox\\Profiles");

        // EDGE FOLDERS
        static string edgeHistory = Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\History");
        static string[] edgeCookies =
        {
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Cookies"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\IndexedDB")
        };
        static string[] edgeSession =
        {
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Sessions"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Session Storage"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Extension State")
        };
        static string[] edgeCache =
        {
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Cache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Code Cache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\GPUCache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\ShaderCache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\CacheStorage"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\ScriptCache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\GrShaderCache\\GPUCache"),
            Path.Combine(ProfileAppDataLocal, "Microsoft\\Edge\\User Data\\Default\\Service Worker\\Database"),
        };

        // BRAVE FOLDERS
        static string braveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\BraveSoftware\\Brave-Browser\\User Data");
        static string[] braveUserDataCacheDirs = { "Default\\Cache", "Default\\Code Cache\\", "Default\\GPUCache\\", "ShaderCache", "Default\\Service Worker\\CacheStorage\\", "Default\\Service Worker\\ScriptCache\\", "GrShaderCache\\GPUCache\\", "Default\\File System\\", "Default\\JumpListIconsMostVisited\\", "Default\\JumpListIconsRecentClosed\\", "Default\\Service Worker\\Database" };
        static string bravePasswordsDir = Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Login Data");
        static string[] braveSessionDirs =
        {
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Sessions"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Session Storage"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Extension State"),
        };
        static string[] braveCookiesDirs =
        {
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\IndexedDB"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\Cookies-journal")
        };
        static string[] braveHistoryDirs =
        {
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\History"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\History Provider Cache"),
            Path.Combine(ProfileAppDataLocal, "BraveSoftware\\Brave-Browser\\User Data\\Default\\History-journal")
        };


        internal static List<string> PreviewCleanList = new List<string>();

        internal static ByteSize PreviewSizeToBeFreed = new ByteSize(0);

        internal static void PreviewFolder(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    PreviewCleanList.Add(path);
                    return;
                }

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
            PreviewSizeToBeFreed += CalculateSize(TempFolder);
        }

        internal static void PreviewMinidumps()
        {
            PreviewFolder(Path.Combine(OSDriveWindows, "Minidump"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(OSDriveWindows, "Minidump"));
        }

        internal static void PreviewErrorReports()
        {
            PreviewFolder(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportArchive"));
            PreviewFolder(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportQueue"));
            PreviewFolder(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\Temp"));
            PreviewFolder(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ERC"));
            PreviewFolder(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ReportArchive"));
            PreviewFolder(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ReportQueue"));
            PreviewFolder(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\Temp"));
            PreviewFolder(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ERC"));

            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportArchive"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ReportQueue"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\Temp"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProfileAppDataLocal, "Microsoft\\Windows\\WER\\ERC"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ReportArchive"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ReportQueue"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\Temp"));
            PreviewSizeToBeFreed += CalculateSize(Path.Combine(ProgramData, "Microsoft\\Windows\\WER\\ERC"));
        }

        internal static ByteSize CalculateSize(string fileOrFolder)
        {
            ByteSize totalSize = new ByteSize(0);
            bool isFolder = Directory.Exists(fileOrFolder);

            try
            {
                if (isFolder)
                {
                    DirectoryInfo dir = new DirectoryInfo(fileOrFolder);
                    totalSize += totalSize.AddBytes(dir.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
                }
                else
                {
                    FileInfo file = new FileInfo(fileOrFolder);
                    totalSize = totalSize.AddBytes(file.Length);
                }
            }
            catch { }

            return totalSize;
        }

        internal static void PreviewEdgeClean(bool cache, bool cookies, bool seachHistory, bool session)
        {
            if (cache)
            {
                foreach (string x in edgeCache)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (cookies)
            {
                foreach (string x in edgeCookies)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (seachHistory)
            {
                PreviewFolder(edgeHistory);
                PreviewSizeToBeFreed += CalculateSize(edgeHistory);
            }

            if (session)
            {
                foreach (string x in edgeSession)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }
        }

        internal static void PreviewInternetExplorerCache()
        {
            foreach (string x in ieCache)
            {
                PreviewFolder(x);
                PreviewSizeToBeFreed += CalculateSize(x);
            }
        }

        internal static void PreviewFireFoxClean(bool cache, bool cookies, bool searchHistory)
        {
            foreach (string x in Directory.EnumerateDirectories(firefoxRoaming))
            {
                if (x.ToLowerInvariant().Contains("release"))
                {
                    if (cookies)
                    {
                        PreviewFolder(Path.Combine(x, "cookies.sqlite"));
                        PreviewSizeToBeFreed += CalculateSize(Path.Combine(x, "cookies.sqlite"));
                    }

                    if (searchHistory)
                    {
                        PreviewFolder(Path.Combine(x, "places.sqlite"));
                        PreviewSizeToBeFreed += CalculateSize(Path.Combine(x, "places.sqlite"));
                    }

                    if (cache)
                    {
                        PreviewFolder(Path.Combine(x, "shader-cache"));
                        PreviewSizeToBeFreed += CalculateSize(Path.Combine(x, "shader-cache"));
                    }
                }
            }

            if (cache)
            {
                foreach (string x in Directory.EnumerateDirectories(firefoxLocal))
                {
                    if (x.ToLowerInvariant().Contains("release"))
                    {
                        PreviewFolder(Path.Combine(x, "cache2"));
                        PreviewSizeToBeFreed += CalculateSize(Path.Combine(x, "cache2"));
                    }
                }
            }
        }

        internal static void PreviewBraveClean(bool cache, bool cookies, bool searchHistory, bool session, bool passwords)
        {
            if (cache)
            {
                foreach (string x in braveUserDataCacheDirs)
                {
                    PreviewFolder(Path.Combine(braveFolder, x));
                    PreviewSizeToBeFreed += CalculateSize(Path.Combine(braveFolder, x));
                }
            }

            if (session)
            {
                foreach (string x in braveSessionDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (cookies)
            {
                foreach (string x in braveCookiesDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (searchHistory)
            {
                foreach (string x in braveHistoryDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (passwords)
            {
                PreviewFolder(bravePasswordsDir);
                PreviewSizeToBeFreed += CalculateSize(bravePasswordsDir);
            }
        }

        internal static void PreviewChromeClean(bool cache, bool cookies, bool searchHistory, bool session, bool passwords)
        {
            if (cache)
            {
                foreach (string x in chromeUserDataCacheDirs)
                {
                    PreviewFolder(Path.Combine(chromeFolder, x));
                    PreviewSizeToBeFreed += CalculateSize(Path.Combine(chromeFolder, x));
                }
            }

            if (session)
            {
                foreach (string x in chromeSessionDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (cookies)
            {
                foreach (string x in chromeCookiesDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (searchHistory)
            {
                foreach (string x in chromeHistoryDirs)
                {
                    PreviewFolder(x);
                    PreviewSizeToBeFreed += CalculateSize(x);
                }
            }

            if (passwords)
            {
                PreviewFolder(chromePasswordsDir);
                PreviewSizeToBeFreed += CalculateSize(chromePasswordsDir);
            }
        }
    }
}
