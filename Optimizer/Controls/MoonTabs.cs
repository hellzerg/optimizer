using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Optimizer {
    [
        ComVisible(true), ClassInterface(ClassInterfaceType.AutoDispatch),
        DefaultProperty("TabPages"), DefaultEvent("SelectedIndexChanged")
    ]
    public sealed class MoonTabs : TabControl, IThemeable, IThemeContainer {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [Category("Custom"), Description("Indicates whether or not you the components Tabpages Headers have border edges."), DefaultValue(false)]
        public bool BorderEdges { get; set; } = false;

        private int _BorderSize = 0;
        [Category("Custom"), Description("The size of the components border."), DefaultValue(0)]
        public int BorderSize
        {
            get => _BorderSize;
            set => _BorderSize = 0;
        }

        [Category("Custom"), Description("The size of the components Indicator."), DefaultValue(0)]
        public int IndicatorSize { get; set; } = 0;

        private int _DividerSize = 0;
        [Category("Custom"), Description("The size of the components Divider."), DefaultValue(0)]
        public int DividerSize
        {
            get => _DividerSize;
            set => _DividerSize = value.LimitToRange(0, 0);
        }

        [Category("Custom"), Description("Indicates whether or not you can rearrange the components Tabpages.  CLICK on the Tabpages HEADER with the LEFT mousebutton and HOLD DOWN the <SHIFT> KEY, to drag it LEFT or RIGHT."), DefaultValue(false)]
        public bool CanDrag { get; set; }

        [Category("Custom"), Description("Hides the tab headers at runtime (navigation is provided by another control)."), DefaultValue(false)]
        public bool HideHeaders { get; set; }

        private int _hoverIndex = -1;

        StringFormat format = new StringFormat { Alignment = StringAlignment.Center };

        private Bitmap bitDrag = default(Bitmap);

        private bool bDrag, bMouseDown, bShiftKey;
        private Point ptPreviousLocation, ptMaxDrag;
        private int DraggedIndex = -1;

        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        // OVERRIDE TAB HEADER WIDTH
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Send TCM_SETMINTABWIDTH
            string maxTitle = string.Empty;
            foreach (TabPage x in this.TabPages)
            {
                if (x.Text.Length > maxTitle.Length) maxTitle = x.Text;
            }
            Size textSize = TextRenderer.MeasureText(maxTitle, this.Font);

            SendMessage(this.Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)textSize.Width);
        }

        public MoonTabs()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.CacheText, true);

            Alignment = TabAlignment.Top;

            Margin = new Padding(0);
            Padding = new Point(0, 0);

            this.SizeMode = TabSizeMode.Fixed;
        }

        private void SetDragState() => bDrag = (CanDrag && bMouseDown && bShiftKey);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            bMouseDown = true;
            SetDragState();
            if (SelectedIndex == -1 || !CanDrag || HideHeaders) return;
            Rectangle rectDrag = GetTabRect(SelectedIndex);
            ptPreviousLocation = new Point(rectDrag.X, rectDrag.Y);
            rectDrag.Width += 1; rectDrag.Height += 1;

            // the drag ghost is only ever drawn while dragging, so capture it only when dragging is possible
            using (Bitmap src = new Bitmap(Width, Height))
            {
                DrawToBitmap(src, ClientRectangle);
                if (bitDrag != null) bitDrag.Dispose();
                using (Graphics g = Graphics.FromImage(bitDrag = new Bitmap(rectDrag.Width, rectDrag.Height)))
                {
                    g.DrawImage(src, new Rectangle(0, 0, bitDrag.Width, bitDrag.Height), rectDrag, GraphicsUnit.Pixel);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            int hover = -1;
            for (int i = 0; i < TabCount; i++)
            {
                if (GetTabRect(i).Contains(e.Location)) { hover = i; break; }
            }
            if (hover != _hoverIndex) { _hoverIndex = hover; Invalidate(); }

            if (bDrag)
            {
                if (Alignment == TabAlignment.Top || Alignment == TabAlignment.Bottom)
                {
                    ptPreviousLocation = new Point(((e.X < 0) ? 0 : (e.X > ptMaxDrag.X) ? ptMaxDrag.X : e.X), (Alignment == TabAlignment.Top ? BorderSize : ptMaxDrag.Y));
                }

                if (Alignment == TabAlignment.Right || Alignment == TabAlignment.Left)
                {
                    ptPreviousLocation = new Point(ptMaxDrag.X, ((e.Y < 0) ? 0 : (e.Y > ptMaxDrag.Y) ? ptMaxDrag.Y : e.Y));
                }
                for (int i = 0; i < TabCount; i++)
                {
                    if (GetTabRect(i).Contains(PointToClient(Cursor.Position))) { DraggedIndex = i; break; }
                }

                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            void SwapTabPages(TabPage inDestTab)
            {
                int SourceIndex = TabPages.IndexOf(SelectedTab);
                int DestinationIndex = TabPages.IndexOf(inDestTab);

                TabPages[DestinationIndex] = SelectedTab;
                TabPages[SourceIndex] = inDestTab;

                if (SelectedIndex == SourceIndex) { SelectedIndex = DestinationIndex; }
                else if (SelectedIndex == DestinationIndex) { SelectedIndex = SourceIndex; }
            }

            bDrag = bMouseDown = false;

            if (DraggedIndex > -1)
            {
                SwapTabPages(TabPages[DraggedIndex]);
                DraggedIndex = -1;
            }

            SetDragState();
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs ke) { bShiftKey = ke.Shift; SetDragState(); }

        protected override void OnKeyUp(KeyEventArgs e) { bDrag = bShiftKey = false; SetDragState(); }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hoverIndex != -1)
            {
                _hoverIndex = -1;
                Invalidate();
            }
            base.OnMouseLeave(e);
        }

        protected override void WndProc(ref Message m)
        {
            // TCM_ADJUSTRECT: let the pages cover the whole control when headers are hidden (sidebar navigation)
            if (m.Msg == 0x1328 && HideHeaders && !DesignMode)
            {
                m.Result = (IntPtr)1;
                return;
            }
            base.WndProc(ref m);
        }

        public void ApplyTheme(Palette palette)
        {
            Invalidate();
        }

        Color IThemeContainer.ChildSurface
        {
            get { return Parent != null ? Parent.BackColor : ThemeManager.Current.WindowBg; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode) return;

            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);

            if (HideHeaders || TabCount == 0) return;

            bool vertical = Alignment == TabAlignment.Left || Alignment == TabAlignment.Right;

            // hairline separating the pivot from the page content
            using (Pen line = new Pen(p.Stroke))
            {
                Rectangle display = DisplayRectangle;
                if (Alignment == TabAlignment.Top) g.DrawLine(line, 0, display.Top - 1, Width, display.Top - 1);
                else if (Alignment == TabAlignment.Bottom) g.DrawLine(line, 0, display.Bottom, Width, display.Bottom);
            }

            ptMaxDrag = new Point(0, 0);

            for (int i = 0; i < TabCount; i++)
            {
                Rectangle head = GetTabRect(i);
                bool selected = i == SelectedIndex;

                if (!selected && i == _hoverIndex)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (GraphicsPath path = Draw.RoundedRect(RectangleF.Inflate(head, -2, -3), Draw.S(4)))
                    using (SolidBrush b = new SolidBrush(p.ControlHover))
                    {
                        g.FillPath(b, path);
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }

                if (!(bDrag && selected))
                {
                    Color text = selected ? p.TextPrimary : (i == _hoverIndex ? p.TextPrimary : p.TextSecondary);

                    if (vertical)
                    {
                        float angle = Alignment == TabAlignment.Right ? 90 : 270;
                        Size textSize = g.MeasureString(TabPages[i].Text, Font).ToSize();
                        g.TranslateTransform(head.X + head.Width / 2f, head.Y + head.Height / 2f);
                        g.RotateTransform(angle);
                        using (SolidBrush b = new SolidBrush(text))
                        {
                            g.DrawString(TabPages[i].Text, Font, b, new PointF(-textSize.Width / 2f, -textSize.Height / 2f));
                        }
                        g.ResetTransform();
                    }
                    else
                    {
                        TextRenderer.DrawText(g, TabPages[i].Text, Font, head, text,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
                    }
                }

                if (selected)
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    float thickness = Draw.S(3);
                    RectangleF bar;

                    if (vertical)
                    {
                        float len = Math.Min(head.Height * 0.5f, Draw.S(24));
                        float x = Alignment == TabAlignment.Left ? head.Right - thickness - 1 : head.X + 1;
                        bar = new RectangleF(x, head.Y + (head.Height - len) / 2f, thickness, len);
                    }
                    else
                    {
                        int textWidth = TextRenderer.MeasureText(g, TabPages[i].Text, Font).Width;
                        float len = Math.Max(Draw.S(16), Math.Min(head.Width - Draw.S(8), textWidth * 0.6f));
                        float y = Alignment == TabAlignment.Top ? head.Bottom - thickness - 1 : head.Y + 1;
                        bar = new RectangleF(head.X + (head.Width - len) / 2f, y, len, thickness);
                    }

                    using (GraphicsPath path = Draw.RoundedRect(bar, thickness / 2f))
                    using (SolidBrush b = new SolidBrush(bDrag ? p.AccentPressed : p.Accent))
                    {
                        g.FillPath(b, path);
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }

                if (bMouseDown)
                {
                    if (Alignment == TabAlignment.Top || Alignment == TabAlignment.Bottom) { if (i > 0) { ptMaxDrag.X += GetTabRect(i).Width; } }
                    if (Alignment == TabAlignment.Top) { ptMaxDrag.Y = BorderSize; }
                    if (Alignment == TabAlignment.Bottom) { ptMaxDrag.Y = head.Y; }

                    if (vertical) { ptMaxDrag.X = head.X; if (i > 0) { ptMaxDrag.Y += head.Height; } }
                }

                if (bDrag && (bitDrag != null)) { g.DrawImage(bitDrag, new Point(ptPreviousLocation.X, ptPreviousLocation.Y)); }
            }
        }
    }
    public static class MoonTabHelper {
        public static int LimitToRange(this int value, int inclusiveMinimum, int inclusiveMaximum)
        {
            if (value < inclusiveMinimum) { return inclusiveMinimum; }
            if (value > inclusiveMaximum) { return inclusiveMaximum; }
            return value;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b; b = temp;
        }

        public static int TagToInt(object inObject) => Convert.ToInt32((inObject as Control).Tag);
    }
}
