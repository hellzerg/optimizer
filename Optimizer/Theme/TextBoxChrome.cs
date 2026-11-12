using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Repaints the non-client border of bordered text boxes in Fluent colors (accent line on focus)
    /// and adds inner text margins. Works on every Windows version since it only uses WM_NCPAINT.
    /// </summary>
    public sealed class TextBoxChrome : NativeWindow {
        const int WM_NCPAINT = 0x85;
        const int WM_SETFOCUS = 0x07;
        const int WM_KILLFOCUS = 0x08;
        const int WM_ENABLE = 0x0A;
        const int EM_SETMARGINS = 0xD3;
        const int EC_LEFTMARGIN = 0x1;
        const int EC_RIGHTMARGIN = 0x2;
        const int RDW_INVALIDATE = 0x1;
        const int RDW_FRAME = 0x400;

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr rect, IntPtr region, int flags);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        static readonly ConditionalWeakTable<TextBoxBase, TextBoxChrome> _attached = new ConditionalWeakTable<TextBoxBase, TextBoxChrome>();

        readonly TextBoxBase _box;

        TextBoxChrome(TextBoxBase box)
        {
            _box = box;
            _box.HandleCreated += (s, e) => Hook();
            _box.HandleDestroyed += (s, e) => ReleaseHandle();
            if (_box.IsHandleCreated) Hook();
        }

        internal static void Attach(TextBoxBase box)
        {
            TextBoxChrome chrome;
            if (_attached.TryGetValue(box, out chrome))
            {
                chrome.Refresh();
                return;
            }
            _attached.Add(box, new TextBoxChrome(box));
        }

        void Hook()
        {
            if (Handle != IntPtr.Zero) ReleaseHandle();
            AssignHandle(_box.Handle);

            if (_box is TextBox && !_box.Multiline)
            {
                int m = Draw.SI(6);
                SendMessage(_box.Handle, EM_SETMARGINS, (IntPtr)(EC_LEFTMARGIN | EC_RIGHTMARGIN), (IntPtr)((m & 0xFFFF) | (m << 16)));
            }
            Refresh();
        }

        void Refresh()
        {
            if (_box.IsHandleCreated) RedrawWindow(_box.Handle, IntPtr.Zero, IntPtr.Zero, RDW_FRAME | RDW_INVALIDATE);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_NCPAINT:
                    PaintBorder();
                    break;
                case WM_SETFOCUS:
                case WM_KILLFOCUS:
                case WM_ENABLE:
                    Refresh();
                    break;
            }
        }

        void PaintBorder()
        {
            if (_box.BorderStyle == BorderStyle.None) return;

            IntPtr dc = GetWindowDC(Handle);
            if (dc == IntPtr.Zero) return;

            try
            {
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    Palette p = ThemeManager.Current;
                    int w = _box.Width, h = _box.Height;
                    bool focused = _box.Focused && !_box.ReadOnly;

                    Color border = focused ? ColorMath.Blend(p.Stroke, p.TextSecondary, 0.3) : p.Stroke;
                    using (Pen pen = new Pen(border)) g.DrawRectangle(pen, 0, 0, w - 1, h - 1);

                    if (_box.BorderStyle == BorderStyle.Fixed3D)
                    {
                        using (Pen pen = new Pen(_box.BackColor)) g.DrawRectangle(pen, 1, 1, w - 3, h - 3);
                    }

                    if (focused)
                    {
                        using (Pen pen = new Pen(p.Accent)) g.DrawLine(pen, 0, h - 1, w - 1, h - 1);
                    }
                }
            }
            catch { }
            finally
            {
                ReleaseDC(Handle, dc);
            }
        }
    }
}