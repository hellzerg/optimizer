using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Optimizer
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here

        internal readonly static float Major = 7;
        internal readonly static float Minor = 4;

        internal readonly static bool EXPERIMENTAL_BUILD = false;

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

            // check if another instance is running
            // problem? prevents auto-patching...

            //if (System.Diagnostics.Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Length > 1)
            //{
            //    MessageBox.Show("Optimizer is already running in the background!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

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

                    // for backward compatibility (legacy)
                    if (File.Exists(Options.SettingsFile))
                    {
                        if (File.ReadAllText(Options.SettingsFile).Contains("FirstRun"))
                        {
                            File.Delete(Options.SettingsFile);
                        }
                    }

                    // load settings, if there is no settings, load defaults
                    try
                    {
                        Options.LoadSettings();
                    }
                    catch (Exception ex)
                    {
                        ErrorLogger.LogError("Program.Main", ex.Message, ex.StackTrace);
                    }

                    // checking for silent config argument
                    if (switches.Length == 1)
                    {
                        string arg = switches[0].Trim();

                        // UNSAFE mode switch (allows running on Windows Server 2008+)
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
                                        SilentOps.SilentUpdateOptionsGeneral();
                                        SilentOps.SilentUpdateOptions8();
                                        Options.SaveSettings();
                                    }
                                    else if (SilentOps.CurrentSilentConfig.WindowsVersion == 10 && Utilities.CurrentWindowsVersion == WindowsVersion.Windows10)
                                    {
                                        SilentOps.ProcessSilentConfigGeneral();
                                        SilentOps.ProcessSilentConfigWindows10();
                                        SilentOps.SilentUpdateOptionsGeneral();
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
