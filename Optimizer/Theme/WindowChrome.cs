using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Optional OS-level polish (dark title bar, rounded corners, dark scrollbars).
    /// Every call is version-gated and failure-tolerant, so Windows 7/8 simply keep the classic frame.
    /// </summary>
    public static class WindowChrome {
        const int DWMWA_USE_IMMERSIVE_DARK_MODE_OLD = 19;
        const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
        const int DWMWA_BORDER_COLOR = 34;
        const int DWMWA_CAPTION_COLOR = 35;
        const int DWMWA_TEXT_COLOR = 36;
        const int DWMWCP_ROUND = 2;
        const int DWMWCP_ROUNDSMALL = 3;

        [DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        [DllImport("ntdll.dll")]
        static extern int RtlGetVersion(ref OSVERSIONINFOEX versionInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct OSVERSIONINFOEX {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
            public ushort wServicePackMajor;
            public ushort wServicePackMinor;
            public ushort wSuiteMask;
            public byte wProductType;
            public byte wReserved;
        }

        static readonly Version _osVersion = DetectVersion();

        internal static Version OSVersion { get { return _osVersion; } }

        /// <summary>Windows 10 1809 or newer (dark title bar / dark scrollbars available).</summary>
        internal static bool SupportsDarkMode { get { return _osVersion.Major >= 10 && _osVersion.Build >= 17763; } }

        /// <summary>Windows 11 or newer (rounded corners, caption colors).</summary>
        internal static bool IsWindows11 { get { return _osVersion.Major >= 10 && _osVersion.Build >= 22000; } }

        static Version DetectVersion()
        {
            try
            {
                OSVERSIONINFOEX info = new OSVERSIONINFOEX();
                info.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX));
                if (RtlGetVersion(ref info) == 0)
                {
                    return new Version(info.dwMajorVersion, info.dwMinorVersion, info.dwBuildNumber);
                }
            }
            catch { }
            return Environment.OSVersion.Version;
        }

        const int DWMWA_CLOAK = 13;
        const uint RDW_INVALIDATE = 0x1, RDW_ERASE = 0x4, RDW_ALLCHILDREN = 0x80, RDW_UPDATENOW = 0x100, RDW_FRAME = 0x400;

        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

        /// <summary>
        /// Hides (cloaks) a window from the screen while it keeps rendering, so it can be revealed only
        /// after its first fully themed frame. Windows 8+; returns false where unsupported.
        /// </summary>
        internal static bool Cloak(Form form, bool cloaked)
        {
            if (form == null || !form.IsHandleCreated) return false;
            if (_osVersion.Major < 6 || (_osVersion.Major == 6 && _osVersion.Minor < 2)) return false;
            try
            {
                int value = cloaked ? 1 : 0;
                return DwmSetWindowAttribute(form.Handle, DWMWA_CLOAK, ref value, sizeof(int)) == 0;
            }
            catch { return false; }
        }

        /// <summary>Synchronously paints the window frame, client area and all children.</summary>
        internal static void PaintNow(Control control)
        {
            if (control == null || !control.IsHandleCreated) return;
            try { RedrawWindow(control.Handle, IntPtr.Zero, IntPtr.Zero, RDW_INVALIDATE | RDW_ERASE | RDW_ALLCHILDREN | RDW_UPDATENOW | RDW_FRAME); }
            catch { }
        }

        internal static void Apply(Form form, Palette palette)
        {
            if (form == null || !form.IsHandleCreated) return;

            try
            {
                if (SupportsDarkMode)
                {
                    int dark = palette.IsDark ? 1 : 0;
                    int attr = _osVersion.Build >= 18985 ? DWMWA_USE_IMMERSIVE_DARK_MODE : DWMWA_USE_IMMERSIVE_DARK_MODE_OLD;
                    DwmSetWindowAttribute(form.Handle, attr, ref dark, sizeof(int));
                }

                if (IsWindows11)
                {
                    int corner = DWMWCP_ROUND;
                    DwmSetWindowAttribute(form.Handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref corner, sizeof(int));

                    int caption = ToColorRef(palette.WindowBg);
                    DwmSetWindowAttribute(form.Handle, DWMWA_CAPTION_COLOR, ref caption, sizeof(int));

                    int text = ToColorRef(palette.TextPrimary);
                    DwmSetWindowAttribute(form.Handle, DWMWA_TEXT_COLOR, ref text, sizeof(int));

                    int border = ToColorRef(palette.Stroke);
                    DwmSetWindowAttribute(form.Handle, DWMWA_BORDER_COLOR, ref border, sizeof(int));
                }
            }
            catch { }
        }

        /// <summary>
        /// Switches native scrollbars / list headers to the dark or light Explorer theme.
        /// </summary>
        internal static void ApplyScrollbars(Control control, Palette palette)
        {
            if (!SupportsDarkMode || control == null || !control.IsHandleCreated) return;

            try
            {
                SetWindowTheme(control.Handle, palette.IsDark ? "DarkMode_Explorer" : "Explorer", null);
            }
            catch { }
        }

        internal static void ApplyComboTheme(Control combo, Palette palette)
        {
            if (!SupportsDarkMode || combo == null || !combo.IsHandleCreated) return;

            try
            {
                SetWindowTheme(combo.Handle, palette.IsDark ? "DarkMode_CFD" : "CFD", null);
            }
            catch { }
        }

        /// <summary>
        /// Rounded corners + themed border for popup windows such as context menus (Windows 11 only).
        /// </summary>
        internal static void ApplyPopup(Control popup, Palette palette)
        {
            if (!IsWindows11 || popup == null || !popup.IsHandleCreated) return;

            try
            {
                int corner = DWMWCP_ROUNDSMALL;
                DwmSetWindowAttribute(popup.Handle, DWMWA_WINDOW_CORNER_PREFERENCE, ref corner, sizeof(int));
                int border = ToColorRef(palette.Stroke);
                DwmSetWindowAttribute(popup.Handle, DWMWA_BORDER_COLOR, ref border, sizeof(int));
            }
            catch { }
        }

        static int ToColorRef(System.Drawing.Color c)
        {
            return c.R | (c.G << 8) | (c.B << 16);
        }
    }
}
