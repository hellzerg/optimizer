using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Fluent teaching-tip style callout. A non-activating layered popup with per-pixel alpha
    /// (soft shadow, anti-aliased corners and a caret that points at the anchor control).
    /// </summary>
    internal sealed class TipBubble : Form, IMessageFilter {
        static TipBubble _instance;

        Control _anchor;
        Form _owner;
        string _title = string.Empty, _text = string.Empty;
        Bitmap _surface;
        Point _origin;
        byte _alpha;
        readonly Timer _fade = new Timer { Interval = 15 };
        bool _filtering;

        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TOOLWINDOW = 0x80;
        const int WS_EX_NOACTIVATE = 0x8000000;
        const int WM_MOUSEACTIVATE = 0x21;
        const int MA_NOACTIVATE = 3;

        TipBubble()
        {
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            AccessibleRole = AccessibleRole.ToolTip;
            _fade.Tick += Fade_Tick;
        }

        /// <summary>Opens the tip for <paramref name="anchor"/>, or closes it when it is already open for it.</summary>
        internal static void Toggle(Control anchor, string title, string text)
        {
            if (anchor == null || string.IsNullOrWhiteSpace(text)) return;
            if (_instance != null && !_instance.IsDisposed && _instance.Visible && _instance._anchor == anchor)
            {
                _instance.Dismiss();
                return;
            }
            if (_instance == null || _instance.IsDisposed) _instance = new TipBubble();
            _instance.Open(anchor, title, text);
        }

        internal static void CloseAll()
        {
            if (_instance != null && !_instance.IsDisposed && _instance.Visible) _instance.Dismiss();
        }

        protected override bool ShowWithoutActivation { get { return true; } }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED | WS_EX_TOOLWINDOW | WS_EX_NOACTIVATE;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEACTIVATE)
            {
                m.Result = (IntPtr)MA_NOACTIVATE;
                return;
            }
            base.WndProc(ref m);
        }

        protected override void OnPaintBackground(PaintEventArgs e) { }
        protected override void OnPaint(PaintEventArgs e) { }

        // geometry (device pixels)
        static int Shadow { get { return Draw.SI(14); } }
        static int Caret { get { return Draw.SI(8); } }
        static int Pad { get { return Draw.SI(14); } }
        static int GlyphSize { get { return Draw.SI(20); } }

        static Font TitleFont { get { return Typography.Get(10.5f, Typography.Weight.Semibold); } }
        static Font BodyFont { get { return Typography.Get(10f, Typography.Weight.Regular); } }

        void Open(Control anchor, string title, string text)
        {
            Form owner = anchor.FindForm();
            if (owner == null || !anchor.IsHandleCreated) return;

            Detach();
            _anchor = anchor;
            _owner = owner;
            _title = title == null ? string.Empty : title.Trim();
            _text = text.Trim();
            AccessibleName = _title.Length > 0 ? _title : _text;
            AccessibleDescription = _text;

            bool rtl = owner.RightToLeft == RightToLeft.Yes;
            Rectangle anchorRect = anchor.RectangleToScreen(anchor.ClientRectangle);
            Rectangle work = Screen.FromControl(anchor).WorkingArea;

            // point at the middle of the visible text rather than the whole (possibly wide) label
            int textW = Math.Min(anchorRect.Width, TextRenderer.MeasureText(anchor.Text, anchor.Font, Size.Empty, TextFormatFlags.NoPrefix).Width);
            int tipX = rtl ? anchorRect.Right - Math.Max(Draw.SI(12), textW / 2) : anchorRect.Left + Math.Max(Draw.SI(12), textW / 2);
            tipX = Math.Max(work.Left + Draw.SI(24), Math.Min(work.Right - Draw.SI(24), tipX));

            int bodyW = Math.Min(Draw.SI(380), work.Width - Draw.SI(16));
            Size body = Measure(bodyW);

            int gap = Draw.SI(2);
            bool below = anchorRect.Bottom + gap + Caret + body.Height <= work.Bottom || anchorRect.Top - gap - Caret - body.Height < work.Top;
            int bodyTop = below ? anchorRect.Bottom + gap + Caret : anchorRect.Top - gap - Caret - body.Height;

            int lead = Draw.SI(30);
            int bodyLeft = rtl ? tipX + lead - body.Width : tipX - lead;
            bodyLeft = Math.Max(work.Left + Draw.SI(8), Math.Min(work.Right - Draw.SI(8) - body.Width, bodyLeft));

            Rectangle bodyRect = new Rectangle(bodyLeft, bodyTop, body.Width, body.Height);
            Rectangle bounds = Rectangle.Inflate(bodyRect, Shadow, Shadow);

            Render(bounds.Size, new Rectangle(Shadow, Shadow, body.Width, body.Height), tipX - bounds.Left, below, rtl);
            _origin = bounds.Location;

            if (Owner != owner) Owner = owner;
            Bounds = bounds;
            Attach();

            _alpha = 0;
            Commit();
            if (!Visible) Show();
            _fade.Start();
        }

        Size Measure(int maxW)
        {
            int textLeft = Pad + GlyphSize + Draw.SI(10);
            int textW = maxW - textLeft - Pad;
            using (Bitmap probe = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(probe))
            using (StringFormat sf = NewFormat(false))
            {
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                SizeF t = _title.Length > 0 ? g.MeasureString(_title, TitleFont, textW, sf) : SizeF.Empty;
                SizeF b = g.MeasureString(_text, BodyFont, textW, sf);
                int contentW = (int)Math.Ceiling(Math.Max(t.Width, b.Width));
                int contentH = (int)Math.Ceiling(t.Height) + (_title.Length > 0 ? Draw.SI(4) : 0) + (int)Math.Ceiling(b.Height);
                int w = Math.Max(Draw.SI(200), Math.Min(maxW, textLeft + contentW + Pad + Draw.SI(2)));
                int h = Math.Max(GlyphSize, contentH) + Pad * 2;
                return new Size(w, h);
            }
        }

        static StringFormat NewFormat(bool rtl)
        {
            StringFormat sf = new StringFormat(StringFormat.GenericDefault);
            sf.Trimming = StringTrimming.Word;
            if (rtl) sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            return sf;
        }

        void Render(Size size, Rectangle body, int caretX, bool caretOnTop, bool rtl)
        {
            Palette p = ThemeManager.Current;
            if (_surface != null) _surface.Dispose();
            _surface = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(_surface))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                caretX = Math.Max(body.Left + Draw.SI(16), Math.Min(body.Right - Draw.SI(16), caretX));
                using (GraphicsPath shape = Shape(body, caretX, caretOnTop))
                {
                    PaintShadow(g, shape, p);

                    Color fill = p.IsDark ? ColorMath.Blend(p.Layer2, Color.White, 0.04) : p.Layer2;
                    using (SolidBrush b = new SolidBrush(fill)) g.FillPath(b, shape);
                    using (Pen pen = new Pen(p.IsDark ? Color.FromArgb(70, 255, 255, 255) : Color.FromArgb(40, 0, 0, 0), 1f))
                    {
                        g.DrawPath(pen, shape);
                    }
                }

                // accent "info" badge
                int gy = body.Top + Pad;
                Rectangle glyph = rtl
                    ? new Rectangle(body.Right - Pad - GlyphSize, gy, GlyphSize, GlyphSize)
                    : new Rectangle(body.Left + Pad, gy, GlyphSize, GlyphSize);
                using (SolidBrush b = new SolidBrush(p.Accent)) g.FillEllipse(b, glyph);
                using (SolidBrush b = new SolidBrush(p.OnAccent))
                {
                    float cx = glyph.Left + glyph.Width / 2f;
                    float dot = GlyphSize * 0.14f;
                    g.FillEllipse(b, cx - dot / 2f, glyph.Top + GlyphSize * 0.2f, dot, dot);
                    float stemW = GlyphSize * 0.12f;
                    g.FillRectangle(b, cx - stemW / 2f, glyph.Top + GlyphSize * 0.42f, stemW, GlyphSize * 0.38f);
                }

                int textLeft = rtl ? body.Left + Pad : glyph.Right + Draw.SI(10);
                int textRight = rtl ? glyph.Left - Draw.SI(10) : body.Right - Pad;
                RectangleF area = new RectangleF(textLeft, gy, textRight - textLeft, body.Bottom - Pad - gy);

                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                using (StringFormat sf = NewFormat(rtl))
                {
                    if (_title.Length > 0)
                    {
                        SizeF t = g.MeasureString(_title, TitleFont, (int)area.Width, sf);
                        using (SolidBrush b = new SolidBrush(p.TextPrimary)) g.DrawString(_title, TitleFont, b, area, sf);
                        float dy = (float)Math.Ceiling(t.Height) + Draw.SI(4);
                        area.Y += dy;
                        area.Height -= dy;
                    }
                    else
                    {
                        // single-block tips line up with the badge's center
                        float lineH = BodyFont.GetHeight(g);
                        area.Y += Math.Max(0, (GlyphSize - lineH) / 2f);
                    }
                    using (SolidBrush b = new SolidBrush(_title.Length > 0 ? p.TextSecondary : p.TextPrimary))
                    {
                        g.DrawString(_text, BodyFont, b, area, sf);
                    }
                }
            }
        }

        static GraphicsPath Shape(Rectangle body, int caretX, bool caretOnTop)
        {
            float r = Draw.S(8);
            float d = r * 2;
            float cw = Caret;
            RectangleF b = new RectangleF(body.X + 0.5f, body.Y + 0.5f, body.Width - 1f, body.Height - 1f);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(b.Left, b.Top, d, d, 180, 90);
            if (caretOnTop)
            {
                path.AddLine(caretX - cw, b.Top, caretX, b.Top - Caret);
                path.AddLine(caretX, b.Top - Caret, caretX + cw, b.Top);
            }
            path.AddArc(b.Right - d, b.Top, d, d, 270, 90);
            path.AddArc(b.Right - d, b.Bottom - d, d, d, 0, 90);
            if (!caretOnTop)
            {
                path.AddLine(caretX + cw, b.Bottom, caretX, b.Bottom + Caret);
                path.AddLine(caretX, b.Bottom + Caret, caretX - cw, b.Bottom);
            }
            path.AddArc(b.Left, b.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        static void PaintShadow(Graphics g, GraphicsPath shape, Palette p)
        {
            int steps = Shadow;
            int peak = p.IsDark ? 9 : 6;
            using (GraphicsPath shadow = (GraphicsPath)shape.Clone())
            using (Matrix down = new Matrix())
            {
                down.Translate(0, Draw.S(3));
                shadow.Transform(down);
                for (int i = steps; i >= 1; i--)
                {
                    float t = 1f - i / (float)(steps + 1);
                    int a = (int)Math.Round(peak * t * t);
                    if (a <= 0) continue;
                    using (Pen pen = new Pen(Color.FromArgb(a, 0, 0, 0), i * 2f) { LineJoin = LineJoin.Round })
                    {
                        g.DrawPath(pen, shadow);
                    }
                }
            }
        }

        void Fade_Tick(object sender, EventArgs e)
        {
            int next = Math.Min(255, _alpha + 48);
            _alpha = (byte)next;
            Commit();
            if (next >= 255) _fade.Stop();
        }

        void Commit()
        {
            if (_surface == null || !IsHandleCreated && !CreateHandleSafe()) return;

            IntPtr screenDc = NativeMethods.GetDC(IntPtr.Zero);
            IntPtr memDc = NativeMethods.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero, old = IntPtr.Zero;
            try
            {
                hBitmap = _surface.GetHbitmap(Color.FromArgb(0));
                old = NativeMethods.SelectObject(memDc, hBitmap);

                NativeMethods.SIZE size = new NativeMethods.SIZE { cx = _surface.Width, cy = _surface.Height };
                NativeMethods.POINT src = new NativeMethods.POINT();
                NativeMethods.POINT dst = new NativeMethods.POINT { x = _origin.X, y = _origin.Y };
                NativeMethods.BLENDFUNCTION blend = new NativeMethods.BLENDFUNCTION
                {
                    BlendOp = 0,
                    BlendFlags = 0,
                    SourceConstantAlpha = _alpha,
                    AlphaFormat = 1
                };
                NativeMethods.UpdateLayeredWindow(Handle, screenDc, ref dst, ref size, memDc, ref src, 0, ref blend, 2);
            }
            finally
            {
                if (old != IntPtr.Zero) NativeMethods.SelectObject(memDc, old);
                if (hBitmap != IntPtr.Zero) NativeMethods.DeleteObject(hBitmap);
                NativeMethods.DeleteDC(memDc);
                NativeMethods.ReleaseDC(IntPtr.Zero, screenDc);
            }
        }

        bool CreateHandleSafe()
        {
            try { CreateControl(); return IsHandleCreated; }
            catch (Win32Exception) { return false; }
        }

        void Dismiss()
        {
            _fade.Stop();
            Detach();
            Hide();
            _anchor = null;
            if (_surface != null)
            {
                _surface.Dispose();
                _surface = null;
            }
        }

        void Attach()
        {
            if (!_filtering)
            {
                Application.AddMessageFilter(this);
                _filtering = true;
            }
            _owner.Deactivate += Owner_Changed;
            _owner.Move += Owner_Changed;
            _owner.Resize += Owner_Changed;
            _owner.FormClosing += Owner_Changed;
            _anchor.VisibleChanged += Owner_Changed;
            _anchor.Disposed += Owner_Changed;
        }

        void Detach()
        {
            if (_filtering)
            {
                Application.RemoveMessageFilter(this);
                _filtering = false;
            }
            if (_owner != null)
            {
                _owner.Deactivate -= Owner_Changed;
                _owner.Move -= Owner_Changed;
                _owner.Resize -= Owner_Changed;
                _owner.FormClosing -= Owner_Changed;
            }
            if (_anchor != null)
            {
                _anchor.VisibleChanged -= Owner_Changed;
                _anchor.Disposed -= Owner_Changed;
            }
        }

        void Owner_Changed(object sender, EventArgs e)
        {
            if (Visible) Dismiss();
        }

        const int WM_KEYDOWN = 0x100, WM_SYSKEYDOWN = 0x104;
        const int WM_LBUTTONDOWN = 0x201, WM_RBUTTONDOWN = 0x204, WM_MBUTTONDOWN = 0x207;
        const int WM_NCLBUTTONDOWN = 0xA1, WM_NCRBUTTONDOWN = 0xA4;
        const int WM_MOUSEWHEEL = 0x20A, WM_MOUSEHWHEEL = 0x20E;

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            if (!Visible) return false;
            switch (m.Msg)
            {
                case WM_LBUTTONDOWN:
                case WM_RBUTTONDOWN:
                case WM_MBUTTONDOWN:
                case WM_NCLBUTTONDOWN:
                case WM_NCRBUTTONDOWN:
                    // a click on the anchor itself is handled by Toggle (closes the tip)
                    if (_anchor != null && _anchor.IsHandleCreated && m.HWnd == _anchor.Handle) return false;
                    BeginInvoke((Action)Dismiss);
                    return m.HWnd == Handle;
                case WM_MOUSEWHEEL:
                case WM_MOUSEHWHEEL:
                    BeginInvoke((Action)Dismiss);
                    return false;
                case WM_KEYDOWN:
                case WM_SYSKEYDOWN:
                    BeginInvoke((Action)Dismiss);
                    return ((int)m.WParam & 0xFFFF) == (int)Keys.Escape;
            }
            return false;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Detach();
                _fade.Dispose();
                if (_surface != null) _surface.Dispose();
            }
            base.Dispose(disposing);
        }

        static class NativeMethods {
            [StructLayout(LayoutKind.Sequential)]
            internal struct POINT { public int x, y; }

            [StructLayout(LayoutKind.Sequential)]
            internal struct SIZE { public int cx, cy; }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            internal struct BLENDFUNCTION {
                public byte BlendOp, BlendFlags, SourceConstantAlpha, AlphaFormat;
            }

            [DllImport("user32.dll", SetLastError = true)]
            internal static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref POINT pptDst, ref SIZE psize, IntPtr hdcSrc, ref POINT pprSrc, int crKey, ref BLENDFUNCTION pblend, int dwFlags);

            [DllImport("user32.dll")]
            internal static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            internal static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

            [DllImport("gdi32.dll")]
            internal static extern IntPtr CreateCompatibleDC(IntPtr hDC);

            [DllImport("gdi32.dll")]
            internal static extern bool DeleteDC(IntPtr hdc);

            [DllImport("gdi32.dll")]
            internal static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

            [DllImport("gdi32.dll")]
            internal static extern bool DeleteObject(IntPtr hObject);
        }
    }
}
