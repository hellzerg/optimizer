using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;

namespace Optimizer {
    internal static class FontHelper {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        static PrivateFontCollection fonts = new PrivateFontCollection();

        internal static Font Poppins15;

        internal static void LoadFont() {
            byte[] fontData = Properties.Resources.Poppins_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            uint dummy = 0;

            fonts.AddMemoryFont(fontPtr, Properties.Resources.Poppins_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Poppins_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Poppins15 = new Font(fonts.Families[0], 13f);
        }

        internal static IEnumerable<string> GetAvailableFonts() {
            return new InstalledFontCollection().Families.Select(x => x.Name);
        }

        internal static void ChangeGlobalFont(string fontName) {
            try {
                using (RegistryKey fontsKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", true)) {
                    fontsKey.SetValue("Segoe UI (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Bold (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Bold Italic (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Italic (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Light (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Semibold (TrueType)", "");
                    fontsKey.SetValue("Segoe UI Symbol (TrueType)", "");
                }

                using (RegistryKey fontSubstitutesKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\FontSubstitutes", true)) {
                    fontSubstitutesKey.SetValue("Segoe UI", fontName);
                }
            }
            catch (Exception ex) {
                Logger.LogError("FontHelper.ChangeGlobalFont", ex.Message, ex.StackTrace);
            }
        }

        internal static string GetCurrentGlobalFont() {
            try {
                using (RegistryKey fontSubstitutesKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\FontSubstitutes", false)) {
                    return fontSubstitutesKey.GetValue("Segoe UI", string.Empty) as string;
                }
            }
            catch (Exception ex) {
                Logger.LogError("FontHelper.GetCurrentGlobalFont", ex.Message, ex.StackTrace);
                return string.Empty;
            }
        }

        internal static void RestoreDefaultGlobalFont() {
            try {
                using (RegistryKey fontsKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", true)) {
                    fontsKey.SetValue("Segoe UI (TrueType)", "segoeui.ttf");
                    fontsKey.SetValue("Segoe UI Black (TrueType)", "seguibl.ttf");
                    fontsKey.SetValue("Segoe UI Black Italic (TrueType)", "seguibli.ttf");
                    fontsKey.SetValue("Segoe UI Bold (TrueType)", "segoeuib.ttf");
                    fontsKey.SetValue("Segoe UI Bold Italic (TrueType)", "segoeuiz.ttf");
                    fontsKey.SetValue("Segoe UI Emoji (TrueType)", "seguiemj.ttf");
                    fontsKey.SetValue("Segoe UI Historic (TrueType)", "seguihis.ttf");
                    fontsKey.SetValue("Segoe UI Italic (TrueType)", "segoeuii.ttf");
                    fontsKey.SetValue("Segoe UI Light (TrueType)", "segoeuil.ttf");
                    fontsKey.SetValue("Segoe UI Light Italic (TrueType)", "seguili.ttf");
                    fontsKey.SetValue("Segoe UI Semibold (TrueType)", "seguisb.ttf");
                    fontsKey.SetValue("Segoe UI Semibold Italic (TrueType)", "seguisbi.ttf");
                    fontsKey.SetValue("Segoe UI Semilight (TrueType)", "segoeuisl.ttf");
                    fontsKey.SetValue("Segoe UI Semilight Italic (TrueType)", "seguisli.ttf");
                    fontsKey.SetValue("Segoe UI Symbol (TrueType)", "seguisym.ttf");
                    fontsKey.SetValue("Segoe MDL2 Assets (TrueType)", "segmdl2.ttf");
                    fontsKey.SetValue("Segoe Print (TrueType)", "segoepr.ttf");
                    fontsKey.SetValue("Segoe Print Bold (TrueType)", "segoeprb.ttf");
                    fontsKey.SetValue("Segoe Script (TrueType)", "segoesc.ttf");
                    fontsKey.SetValue("Segoe Script Bold (TrueType)", "segoescb.ttf");
                }

                using (RegistryKey fontSubstitutesKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\FontSubstitutes", true)) {
                    fontSubstitutesKey.DeleteValue("Segoe UI", false);
                }
            }
            catch (Exception ex) {
                Logger.LogError("FontHelper.RestoreDefaultGlobalFont", ex.Message, ex.StackTrace);
            }
        }
    }
}
