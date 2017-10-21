using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;

namespace Optimizer
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here
        internal readonly static float Major = 3;
        internal readonly static float Minor = 3;

        /* END OF VERSION PROPERTIES */

        internal static MainForm main;

        private readonly static string noadminmsg = "Optimizer needs to be run as administrator!\nApp will now close...";
        private readonly static string unsupportedmsg = "Optimizer works in Windows 7 or higher!\nApp will now close...";

        internal static string GetCurrentVersionToString()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionToString());
        }

        private static bool IsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static bool IsSevenOrHigher()
        {
            string os = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");
            bool legit;

            if ((os.Contains("XP")) || (os.Contains("Vista")) || os.Contains("Server 2003"))
            {
                legit = false;
            }
            else
            {
                legit = true;
            }
            return legit;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsAdmin() == false)
            {
                MessagerForm f = new MessagerForm(null, MessagerType.Error, noadminmsg);
                f.ShowDialog();

                Application.Exit();
            }
            else
            {
                if (IsSevenOrHigher() == true)
                {
                    string resource = "Optimizer.Newtonsoft.Json.dll";
                    EmbeddedAssembly.Load(resource, "Newtonsoft.Json.dll");
                    AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

                    if (!Directory.Exists(Required.CoreFolder))
                    {
                        Required.Deploy();
                    }

                    // for backward compatibility
                    if (File.Exists(Options.SettingsFile))
                    {
                        if (File.ReadAllText(Options.SettingsFile).Contains("FirstRun"))
                        {
                            File.Delete(Options.SettingsFile);
                        }
                    }

                    // load settings, if there is no settings, load defaults
                    Options.LoadSettings();

                    Application.Run(new MainForm());
                }
                else
                {
                    MessagerForm f = new MessagerForm(null, MessagerType.Error, unsupportedmsg);
                    f.ShowDialog();

                    Application.Exit();
                }
            }            
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
