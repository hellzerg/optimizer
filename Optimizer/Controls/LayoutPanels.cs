using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Rounded "Layer 1" surface used to group related content.
    /// </summary>
    public sealed class CardPanel : Panel, IThemeable, IThemeContainer {
        public CardPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Padding = new Padding(16);
        }

        [DefaultValue(typeof(Padding), "16, 16, 16, 16")]
        public new Padding Padding
        {
            get { return base.Padding; }
            set { base.Padding = value; }
        }

        public Color ChildSurface { get { return ThemeManager.Current.Layer1; } }

        public void ApplyTheme(Palette palette)
        {
            BackColor = palette.Layer1;
            ForeColor = palette.TextPrimary;
            if (AutoScroll) ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnParentBackColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(7)))
            using (SolidBrush b = new SolidBrush(p.Layer1))
            using (Pen pen = new Pen(p.IsDark ? ColorMath.Blend(p.Layer1, Color.Black, 0.35) : p.Stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }
        }
    }

    internal static class LayoutUtil {
        static readonly System.Reflection.MethodInfo GetState =
            typeof(Control).GetMethod("GetState", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, new[] { typeof(int) }, null);

        /// <summary>The control's own Visible flag; <see cref="Control.Visible"/> is false whenever a parent is hidden.</summary>
        internal static bool IsShown(Control c)
        {
            if (c.Visible) return true;
            if (GetState == null) return false;
            return (bool)GetState.Invoke(c, new object[] { 0x2 });
        }

        static readonly System.Reflection.MethodInfo ArrangedSetBounds = GetArrangedSetBounds();

        static System.Reflection.MethodInfo GetArrangedSetBounds()
        {
            Type t = typeof(Control).Assembly.GetType("System.Windows.Forms.Layout.IArrangedElement");
            return t == null ? null : t.GetMethod("SetBounds", new[] { typeof(Rectangle), typeof(BoundsSpecified) });
        }

        /// <summary>
        /// Moves a control the way the built-in layout engines do. The public setters mark bounds as
        /// user-specified, which makes AutoScale scale them again on every nested scaling pass.
        /// </summary>
        internal static void Arrange(Control c, Rectangle bounds)
        {
            if (c.Bounds == bounds) return;
            if (ArrangedSetBounds != null) ArrangedSetBounds.Invoke(c, new object[] { bounds, BoundsSpecified.None });
            else c.Bounds = bounds;
        }
    }

    /// <summary>
    /// Vertical stack. Children anchored Left|Right are stretched to the full width, and the panel
    /// can size its own height to its content so it can live inside a <see cref="ColumnsPanel"/>.
    /// </summary>
    public sealed class StackPanel : Panel {
        static readonly StackLayoutEngine Engine = new StackLayoutEngine();
        bool _autoHeight = true;

        public StackPanel()
        {
            Margin = new Padding(0);
        }

        public override System.Windows.Forms.Layout.LayoutEngine LayoutEngine
        {
            get { return Engine; }
        }

        [DefaultValue(true)]
        [Category("Layout")]
        [Description("Resizes the panel height to fit its visible children.")]
        public bool AutoHeight
        {
            get { return _autoHeight; }
            set { _autoHeight = value; PerformLayout(); }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.VisibleChanged += Child_VisibleChanged;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            e.Control.VisibleChanged -= Child_VisibleChanged;
            base.OnControlRemoved(e);
            PerformLayout();
        }

        void Child_VisibleChanged(object sender, EventArgs e)
        {
            PerformLayout();
        }

        sealed class StackLayoutEngine : System.Windows.Forms.Layout.LayoutEngine {
            public override bool Layout(object container, LayoutEventArgs layoutEventArgs)
            {
                StackPanel panel = (StackPanel)container;
                Rectangle area = panel.DisplayRectangle;
                Padding pad = panel.Padding;
                int inner = Math.Max(0, area.Width - pad.Horizontal);
                int y = area.Top + pad.Top;
                bool any = false;

                // Controls collection is in z-order; designer adds them so index order is top-to-bottom.
                foreach (Control c in panel.Controls)
                {
                    // Visible reports false for every child while the parent is hidden; honour the child's own flag instead.
                    if (!LayoutUtil.IsShown(c)) continue;
                    any = true;

                    Padding m = c.Margin;
                    bool stretch = (c.Anchor & (AnchorStyles.Left | AnchorStyles.Right)) == (AnchorStyles.Left | AnchorStyles.Right);
                    int w = stretch ? Math.Max(0, inner - m.Horizontal) : c.Width;
                    if (c.AutoSize && !stretch) w = c.GetPreferredSize(new Size(inner - m.Horizontal, 0)).Width;
                    int h = c.AutoSize && !stretch ? c.GetPreferredSize(new Size(w, 0)).Height : c.Height;

                    y += m.Top;
                    LayoutUtil.Arrange(c, new Rectangle(area.Left + pad.Left + m.Left, y, w, h));
                    y += c.Height + m.Bottom;
                }

                if (panel._autoHeight && !panel.AutoScroll)
                {
                    int height = (any ? y - area.Top : pad.Top) + pad.Bottom;
                    if (panel.Height != height)
                    {
                        LayoutUtil.Arrange(panel, new Rectangle(panel.Left, panel.Top, panel.Width, height));
                        return true;
                    }
                }

                return false;
            }

        }
    }

    /// <summary>
    /// Responsive masonry layout: places its children (usually <see cref="StackPanel"/> sections)
    /// in one or two columns depending on the available width. Scrolls vertically when needed.
    /// </summary>
    public sealed class ColumnsPanel : Panel {
        int _maxColumns = 2;
        int _minColumnWidth = 380;
        int _gap = 24;
        bool _inLayout;

        public ColumnsPanel()
        {
            AutoScroll = true;
            DoubleBuffered = true;
            Padding = new Padding(28, 8, 28, 28);
        }

        [DefaultValue(true)]
        public override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { base.AutoScroll = value; }
        }

        [DefaultValue(2)]
        [Category("Layout")]
        public int MaxColumns
        {
            get { return _maxColumns; }
            set { _maxColumns = Math.Max(1, value); PerformLayout(); }
        }

        [DefaultValue(380)]
        [Category("Layout")]
        [Description("Minimum column width (in 96 DPI pixels) before the panel falls back to fewer columns.")]
        public int MinColumnWidth
        {
            get { return _minColumnWidth; }
            set { _minColumnWidth = Math.Max(50, value); PerformLayout(); }
        }

        [DefaultValue(24)]
        [Category("Layout")]
        public int Gap
        {
            get { return _gap; }
            set { _gap = Math.Max(0, value); PerformLayout(); }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.SizeChanged += Child_SizeChanged;
            e.Control.VisibleChanged += Child_SizeChanged;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            e.Control.SizeChanged -= Child_SizeChanged;
            e.Control.VisibleChanged -= Child_SizeChanged;
            base.OnControlRemoved(e);
        }

        void Child_SizeChanged(object sender, EventArgs e)
        {
            if (!_inLayout) PerformLayout();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (_inLayout) return;
            _inLayout = true;

            try
            {
                int gap = Draw.SI(_gap);
                int avail = ClientSize.Width - Padding.Horizontal;
                int columns = _maxColumns;
                while (columns > 1 && (avail - gap * (columns - 1)) / columns < Draw.SI(_minColumnWidth)) columns--;

                int colWidth = Math.Max(0, (avail - gap * (columns - 1)) / columns);
                int[] heights = new int[columns];

                Point scroll = AutoScrollPosition;

                for (int i = 0; i < Controls.Count; i++)
                {
                    Control c = Controls[i];
                    if (!LayoutUtil.IsShown(c)) continue;

                    int col = 0;
                    for (int k = 1; k < columns; k++) if (heights[k] < heights[col]) col = k;

                    if (c.Width != colWidth) LayoutUtil.Arrange(c, new Rectangle(c.Left, c.Top, colWidth, c.Height));
                    if (c is StackPanel) c.PerformLayout();

                    int x = Padding.Left + col * (colWidth + gap);
                    int y = Padding.Top + heights[col];
                    LayoutUtil.Arrange(c, new Rectangle(x + scroll.X, y + scroll.Y, c.Width, c.Height));

                    heights[col] += c.Height + gap;
                }
            }
            finally
            {
                _inLayout = false;
            }

            base.OnLayout(levent);
        }
    }

    /// <summary>
    /// Group box with a Fluent card look (rounded border, caption on top).
    /// </summary>
    public sealed class FluentGroup : GroupBox, IThemeable, IThemeContainer {
        public FluentGroup()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        public Color ChildSurface { get { return ThemeManager.Current.Layer1; } }

        public void ApplyTheme(Palette palette)
        {
            BackColor = palette.Layer1;
            ForeColor = palette.TextSecondary;
            Invalidate();
        }

        public override Rectangle DisplayRectangle
        {
            get
            {
                int top = Font.Height + Draw.SI(14);
                int side = Draw.SI(12);
                return new Rectangle(side, top, Math.Max(0, Width - side * 2), Math.Max(0, Height - top - side));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(7)))
            using (SolidBrush b = new SolidBrush(p.Layer1))
            using (Pen pen = new Pen(p.IsDark ? ColorMath.Blend(p.Layer1, Color.Black, 0.35) : p.Stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }
            g.SmoothingMode = SmoothingMode.None;

            Rectangle caption = new Rectangle(Draw.SI(12), Draw.SI(8), Width - Draw.SI(24), Font.Height + 2);
            TextRenderer.DrawText(g, Text, Font, caption, Enabled ? p.TextPrimary : p.TextDisabled,
                TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis);
        }
    }
}
