using System;
using System.Drawing;
using System.Drawing.Text;

namespace Optimizer
{
    internal static class FontHelper
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        static PrivateFontCollection fonts = new PrivateFontCollection();

        internal static Font Poppins15;

        internal static void LoadFont()
        {
            byte[] fontData = Properties.Resources.Poppins_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            uint dummy = 0;

            fonts.AddMemoryFont(fontPtr, Properties.Resources.Poppins_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Poppins_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Poppins15 = new Font(fonts.Families[0], 13f);
        }
    }
}
