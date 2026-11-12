using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml;

namespace Optimizer {
    /// <summary>
    /// Packaged (UWP / Store) app enumeration and removal. Uses the Windows Runtime PackageManager
    /// (available since Windows 8) through late binding, so no WinMD reference is required, and falls
    /// back to the Appx PowerShell module when the runtime API is unavailable or fails.
    /// </summary>
    internal static class UWPHelper {
        const int LogoSize = 64;

        sealed class Entry {
            internal UwpApp App;
            internal string LogoPath;
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        static extern int SHLoadIndirectString(string pszSource, StringBuilder pszOutBuf, int cchOutBuf, IntPtr ppvReserved);

        static Type WinRtType(string typeName, string assemblyName)
        {
            return Type.GetType(typeName + ", " + assemblyName + ", ContentType=WindowsRuntime", false);
        }

        static object CreatePackageManager()
        {
            Type t = WinRtType("Windows.Management.Deployment.PackageManager", "Windows.Management.Deployment");
            return t == null ? null : Activator.CreateInstance(t);
        }

        static object Prop(object o, string name)
        {
            if (o == null) return null;
            try
            {
                PropertyInfo p = o.GetType().GetProperty(name);
                return p == null ? null : p.GetValue(o, null);
            }
            catch
            {
                // not available on this Windows version, or the package is in a broken state
                return null;
            }
        }

        internal static List<UwpApp> GetUWPApps(bool showAll)
        {
            // removability information is not exposed before Windows 10
            if (Utilities.CurrentWindowsVersion == WindowsVersion.Windows8) showAll = true;

            List<Entry> entries = null;
            try
            {
                entries = EnumerateWinRt(showAll);
            }
            catch (Exception ex)
            {
                Logger.LogError("UWPHelper.GetUWPApps-WinRT", ex.Message, ex.StackTrace);
            }
            if (entries == null) entries = EnumeratePowerShell(showAll);

            List<UwpApp> apps = new List<UwpApp>(entries.Count);
            foreach (Entry e in entries)
            {
                Complete(e);
                apps.Add(e.App);
            }
            return apps;
        }

        static void Add(Dictionary<string, Entry> byName, List<Entry> list, string name, string fullName,
            string location, bool isFramework, bool removable, string displayName, string logoPath)
        {
            Entry e;
            if (!byName.TryGetValue(name, out e))
            {
                e = new Entry { App = new UwpApp { Name = name, IsFramework = isFramework, IsRemovable = removable } };
                byName.Add(name, e);
                list.Add(e);
            }

            UwpApp app = e.App;
            if (!app.FullNames.Contains(fullName, StringComparer.OrdinalIgnoreCase)) app.FullNames.Add(fullName);
            if (string.IsNullOrEmpty(app.InstallLocation)) app.InstallLocation = location;
            if (string.IsNullOrWhiteSpace(app.DisplayName)) app.DisplayName = displayName;
            if (string.IsNullOrEmpty(e.LogoPath)) e.LogoPath = logoPath;
        }

        static List<Entry> EnumerateWinRt(bool showAll)
        {
            object pm = CreatePackageManager();
            if (pm == null) return null;

            MethodInfo find = pm.GetType().GetMethod("FindPackagesForUser", new[] { typeof(string) });
            IEnumerable packages = find == null ? null : find.Invoke(pm, new object[] { string.Empty }) as IEnumerable;
            if (packages == null) return null;

            Dictionary<string, Entry> byName = new Dictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);
            List<Entry> list = new List<Entry>();

            foreach (object pkg in packages)
            {
                object id = Prop(pkg, "Id");
                string name = Prop(id, "Name") as string;
                string fullName = Prop(id, "FullName") as string;
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(fullName)) continue;

                object resource = Prop(pkg, "IsResourcePackage");
                if (resource is bool && (bool)resource) continue;

                // Windows 10+: System-signed packages ship with the OS and cannot be removed
                object kind = Prop(pkg, "SignatureKind");
                bool removable = kind == null || kind.ToString() != "System";
                if (!showAll && !removable) continue;

                object framework = Prop(pkg, "IsFramework");
                Uri logo = Prop(pkg, "Logo") as Uri;

                Add(byName, list, name, fullName,
                    Prop(Prop(pkg, "InstalledLocation"), "Path") as string,
                    framework is bool && (bool)framework,
                    removable,
                    Prop(pkg, "DisplayName") as string,
                    logo != null && logo.IsFile ? logo.LocalPath : null);
            }

            return list;
        }

        static object PsValue(PSObject o, string name)
        {
            try
            {
                PSPropertyInfo p = o.Properties[name];
                return p == null ? null : p.Value;
            }
            catch
            {
                return null;
            }
        }

        static bool PsBool(PSObject o, string name)
        {
            object v = PsValue(o, name);
            if (v is bool) return (bool)v;
            bool parsed;
            return v != null && bool.TryParse(v.ToString(), out parsed) && parsed;
        }

        static List<Entry> EnumeratePowerShell(bool showAll)
        {
            Dictionary<string, Entry> byName = new Dictionary<string, Entry>(StringComparer.OrdinalIgnoreCase);
            List<Entry> list = new List<Entry>();

            using (PowerShell script = PowerShell.Create())
            {
                script.AddScript("Get-AppxPackage");

                Collection<PSObject> psResult;
                try
                {
                    psResult = script.Invoke();
                }
                catch (Exception ex)
                {
                    Logger.LogError("UWPHelper.GetUWPApps-PowerShell", ex.Message, ex.StackTrace);
                    return list;
                }

                if (psResult == null) return list;

                foreach (PSObject x in psResult)
                {
                    if (x == null) continue;

                    string name = PsValue(x, "Name") as string;
                    string fullName = PsValue(x, "PackageFullName") as string;
                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(fullName)) continue;
                    if (PsBool(x, "IsResourcePackage")) continue;

                    bool removable = !PsBool(x, "NonRemovable");
                    if (!showAll && !removable) continue;

                    Add(byName, list, name, fullName, PsValue(x, "InstallLocation") as string,
                        PsBool(x, "IsFramework"), removable, null, null);
                }
            }

            return list;
        }

        // fills in what the runtime did not provide: friendly name (Windows 8 / unresolved) and logo
        static void Complete(Entry e)
        {
            UwpApp app = e.App;
            bool needName = string.IsNullOrWhiteSpace(app.DisplayName) || IsResourceReference(app.DisplayName);
            string logo = ExistingFile(e.LogoPath);

            string manifestName = null, manifestLogo = null;
            if (needName || logo == null) ReadManifest(app.InstallLocation, out manifestName, out manifestLogo);

            if (needName) app.DisplayName = ResolveString(manifestName, app);
            if (logo == null) logo = ResolveLogo(app.InstallLocation, manifestLogo);
            app.Logo = LoadLogo(logo);
        }

        static bool IsResourceReference(string value)
        {
            return value.StartsWith("ms-resource:", StringComparison.OrdinalIgnoreCase);
        }

        static string ExistingFile(string path)
        {
            try
            {
                return !string.IsNullOrEmpty(path) && File.Exists(path) ? path : null;
            }
            catch
            {
                return null;
            }
        }

        static void ReadManifest(string location, out string displayName, out string logo)
        {
            displayName = null;
            logo = null;
            if (string.IsNullOrEmpty(location)) return;

            try
            {
                string manifest = Path.Combine(location, "AppxManifest.xml");
                if (!File.Exists(manifest)) return;

                XmlDocument doc = new XmlDocument { XmlResolver = null };
                doc.Load(manifest);

                XmlNode node = doc.SelectSingleNode("/*[local-name()='Package']/*[local-name()='Properties']/*[local-name()='DisplayName']");
                if (node != null) displayName = node.InnerText.Trim();

                node = doc.SelectSingleNode("/*[local-name()='Package']/*[local-name()='Properties']/*[local-name()='Logo']");
                if (node != null) logo = node.InnerText.Trim();
            }
            catch (Exception ex)
            {
                Logger.LogError("UWPHelper.ReadManifest", ex.Message, ex.StackTrace);
            }
        }

        static string ResolveString(string value, UwpApp app)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            if (!IsResourceReference(value)) return value;

            string key = value.Substring("ms-resource:".Length);
            List<string> uris = new List<string>();
            if (key.StartsWith("//", StringComparison.Ordinal))
            {
                uris.Add("ms-resource:" + key);
            }
            else if (key.StartsWith("/", StringComparison.Ordinal))
            {
                uris.Add("ms-resource://" + app.Name + key);
            }
            else
            {
                uris.Add("ms-resource://" + app.Name + "/Resources/" + key);
                if (key.IndexOf('/') >= 0) uris.Add("ms-resource://" + app.Name + "/" + key);
            }

            StringBuilder buffer = new StringBuilder(1024);
            foreach (string fullName in app.FullNames)
            {
                foreach (string uri in uris)
                {
                    buffer.Clear();
                    try
                    {
                        if (SHLoadIndirectString("@{" + fullName + "?" + uri + "}", buffer, buffer.Capacity, IntPtr.Zero) == 0)
                        {
                            string resolved = buffer.ToString().Trim();
                            if (resolved.Length > 0 && !IsResourceReference(resolved)) return resolved;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError("UWPHelper.ResolveString", ex.Message, ex.StackTrace);
                        return null;
                    }
                }
            }
            return null;
        }

        static int QualifierRank(string path)
        {
            string p = path.ToLowerInvariant();
            int rank;
            if (p.Contains("scale-100") || p.Contains("targetsize-48")) rank = 0;
            else if (p.Contains("scale-200") || p.Contains("targetsize-64")) rank = 1;
            else if (p.Contains("scale-150") || p.Contains("scale-125")) rank = 2;
            else rank = 3;
            // high-contrast variants look wrong on a regular card
            if (p.Contains("contrast-")) rank += 10;
            return rank;
        }

        static string ResolveLogo(string location, string relative)
        {
            try
            {
                if (string.IsNullOrEmpty(location) || !Directory.Exists(location)) return null;

                if (!string.IsNullOrEmpty(relative))
                {
                    string full = Path.Combine(location, relative.TrimStart('\\', '/'));
                    if (File.Exists(full)) return full;

                    // assets are usually stored with resource qualifiers, e.g. StoreLogo.scale-100.png
                    string dir = Path.GetDirectoryName(full);
                    if (Directory.Exists(dir))
                    {
                        string best = Directory.EnumerateFiles(dir, Path.GetFileNameWithoutExtension(full) + "*" + Path.GetExtension(full), SearchOption.AllDirectories)
                            .OrderBy(QualifierRank)
                            .FirstOrDefault();
                        if (best != null) return best;
                    }
                }

                // last resort: the largest picture in the package
                FileInfo largest = new DirectoryInfo(location)
                    .EnumerateFiles("*.png", SearchOption.AllDirectories)
                    .OrderByDescending(f => f.Length)
                    .FirstOrDefault();
                return largest == null ? null : largest.FullName;
            }
            catch (Exception ex)
            {
                Logger.LogError("UWPHelper.ResolveLogo", ex.Message, ex.StackTrace);
                return null;
            }
        }

        // loads a small detached copy so no file handle or lazy GDI+ stream is kept alive
        static Image LoadLogo(string path)
        {
            if (path == null) return null;

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (Image source = Image.FromStream(fs))
                {
                    double scale = Math.Min(1.0, (double)LogoSize / Math.Max(source.Width, source.Height));
                    int w = Math.Max(1, (int)Math.Round(source.Width * scale));
                    int h = Math.Max(1, (int)Math.Round(source.Height * scale));

                    Bitmap logo = new Bitmap(w, h, PixelFormat.Format32bppArgb);
                    using (Graphics g = Graphics.FromImage(logo))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.DrawImage(source, new Rectangle(0, 0, w, h));
                    }
                    return logo;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("UWPHelper.LoadLogo", ex.Message, ex.StackTrace);
                return null;
            }
        }

        /// <summary>Removes every installed architecture of the app for the current user. Returns true when an error occurred.</summary>
        internal static bool UninstallUWPApp(UwpApp app)
        {
            bool failed = app.FullNames.Count == 0;
            try
            {
                foreach (string fullName in app.FullNames)
                {
                    if (!RemoveWithPackageManager(fullName)) failed = true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("UWPHelper.UninstallUWPApp-WinRT", ex.Message, ex.StackTrace);
                failed = true;
            }

            return failed ? RemoveWithPowerShell(app.Name) : false;
        }

        static bool RemoveWithPackageManager(string fullName)
        {
            object pm = CreatePackageManager();
            Type asyncInfo = WinRtType("Windows.Foundation.IAsyncInfo", "Windows.Foundation");
            if (pm == null || asyncInfo == null) return false;

            object operation = pm.GetType().GetMethod("RemovePackageAsync", new[] { typeof(string) }).Invoke(pm, new object[] { fullName });
            PropertyInfo status = asyncInfo.GetProperty("Status");

            string state;
            while ((state = status.GetValue(operation, null).ToString()) == "Started")
            {
                Thread.Sleep(100);
            }

            if (state == "Completed") return true;

            Exception error = asyncInfo.GetProperty("ErrorCode").GetValue(operation, null) as Exception;
            Logger.LogError("UWPHelper.RemovePackage", fullName + ": " + (error != null ? error.Message : state), string.Empty);
            return false;
        }

        static bool RemoveWithPowerShell(string appName)
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