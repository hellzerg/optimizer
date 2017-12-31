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
        internal readonly static float Minor = 8;

        internal static string GetCurrentVersion()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        /* END OF VERSION PROPERTIES */

        internal static MainForm MainForm;

        readonly static string _adminMissingMessage = "Optimizer needs to be run as administrator!\nApp will now close...";
        readonly static string _unsupportedMessage = "Optimizer works in Windows 7 or higher!\nApp will now close...";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Utilities.IsAdmin())
            {
                HelperForm f = new HelperForm(null, MessageType.Error, _adminMissingMessage);
                f.ShowDialog();

                Application.Exit();
            }
            else
            {
                if (Utilities.IsCompatible())
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
                    HelperForm f = new HelperForm(null, MessageType.Error, _unsupportedMessage);
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
