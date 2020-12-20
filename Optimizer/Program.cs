using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Optimizer
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here

        internal readonly static float Major = 5;
        internal readonly static float Minor = 7;

        internal static string GetCurrentVersionTostring()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionTostring());
        }

        /* END OF VERSION PROPERTIES */

        // Enables the corresponding Windows tab for Windows Server machines
        internal static bool UNSAFE_MODE = false;

        const string _jsonAssembly = @"Optimizer.Newtonsoft.Json.dll";

        internal static MainForm MainForm;

        readonly static string _adminMissingMessage = "Optimizer needs to be run as administrator!\nApp will now close...";
        readonly static string _unsupportedMessage = "Optimizer works in Windows 7 or higher!\nApp will now close...";

        [STAThread]
        static void Main(string[] switches)
        {
            EmbeddedAssembly.Load(_jsonAssembly, _jsonAssembly.Replace("Optimizer.", string.Empty));
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

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

                    // checking for silent config argument
                    if (switches.Length == 1)
                    {
                        string arg = switches[0].Trim();

                        if (arg == "/unsafe")
                        {
                            UNSAFE_MODE = true;
                            Application.Run(new MainForm());
                            return;
                        }

                        if (arg.StartsWith("/"))
                        {
                            if (File.Exists(arg.Remove(0, 1)))
                            {
                                SilentOps.GetSilentConfig(arg.Remove(0, 1));

                                if (SilentOps.CurrentSilentConfig != null)
                                {
                                    if (SilentOps.CurrentSilentConfig.WindowsVersion == 7 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows7)
                                    {
                                        SilentOps.ProcessSilentConfigGeneral();
                                        SilentOps.SilentUpdateOptionsGeneral();
                                        Options.SaveSettings();
                                    }
                                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 8 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows8)
                                    {
                                        SilentOps.ProcessSilentConfigGeneral();
                                        SilentOps.ProcessSilentConfigWindows8();
                                        SilentOps.SilentUpdateOptions8();
                                        Options.SaveSettings();
                                    }
                                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 10 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
                                    {
                                        SilentOps.ProcessSilentConfigGeneral();
                                        SilentOps.ProcessSilentConfigWindows10();
                                        SilentOps.SilentUpdateOptions10();
                                        Options.SaveSettings();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Windows version does not match!", "Invalid config file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Environment.Exit(0);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Config file is in invalid format!", "Invalid config file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Config file does not exist!", "Invalid config file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid argument. Example: optimizer.exe /silent.conf", "Invalid argument", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Application.Run(new MainForm());
                    }
                }
                else
                {
                    HelperForm f = new HelperForm(null, MessageType.Error, _unsupportedMessage);
                    f.ShowDialog();

                    Application.Exit();
                }
            }
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
