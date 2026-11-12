using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class AppCard : UserControl, IThemeable {
        bool _hover;
        Control _host;
        UwpApp _app;

        public AppCard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            foreach (Control c in new Control[] { appTitle, appImage, appSubtitle })
            {
                c.MouseEnter += (s, e) => SetHover(true);
                c.MouseLeave += (s, e) => SetHover(ClientRectangle.Contains(PointToClient(Cursor.Position)));
            }
            appImage.Click += (s, e) => appTitle.Checked = !appTitle.Checked;
            appSubtitle.Click += (s, e) => appTitle.Checked = !appTitle.Checked;
            appTitle.CheckedChanged += (s, e) => Invalidate();

            ApplyTheme(ThemeManager.Current);
        }

        /// <summary>
        /// Packaged app shown by this card. Setting it switches to the two-line layout (friendly name + package name).
        /// </summary>
        public UwpApp App
        {
            get { return _app; }
            set
            {
                _app = value;
                if (value == null) return;

                appTitle.Text = value.Title;
                appSubtitle.Text = value.Name;
                appSubtitle.Visible = true;
                appImage.Image = value.Logo;
                GlyphTint.Apply(appImage, ThemeManager.Current);
                PerformLayout();
            }
        }

        /// <summary>
        /// When false the card keeps the size its owner gives it (grid tile) instead of stretching to the host width.
        /// </summary>
        public bool StretchToHost { get; set; } = true;

        protected override void OnClick(EventArgs e)
        {
            appTitle.Checked = !appTitle.Checked;
            base.OnClick(e);
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (_app == null)
            {
                if (StretchToHost || AutoSize) return;

                int pad = Draw.SI(10), icon = Draw.SI(24);
                appImage.Bounds = new Rectangle(pad, (Height - icon) / 2, icon, icon);
                int tx = pad + icon + Draw.SI(6);
                int th = Math.Min(Height, Math.Max(Draw.SI(24), appTitle.GetPreferredSize(Size.Empty).Height));
                appTitle.Bounds = new Rectangle(tx, (Height - th) / 2, Math.Max(0, Width - tx - Draw.SI(6)), th);
                return;
            }

            int left = Draw.SI(10);
            int top = Draw.SI(6);
            int logo = Draw.SI(32);

            appTitle.Location = new Point(left + logo + Draw.SI(8), top);
            // align the package name with the title text, past the check glyph
            appSubtitle.Location = new Point(appTitle.Left + appTitle.Padding.Left + Draw.SI(27), appTitle.Bottom - Draw.SI(1));

            int content = appSubtitle.Bottom - top;
            appImage.Bounds = new Rectangle(left, top + (content - logo) / 2, logo, logo);
        }

        Color CardFill
        {
            get { return _hover ? ThemeManager.Current.Layer1Hover : ThemeManager.Current.Layer1; }
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = CardFill;
            appImage.BackColor = BackColor;
            appSubtitle.BackColor = BackColor;
            appSubtitle.ForeColor = palette.TextSecondary;
            appTitle.ApplyTheme(palette);
            Invalidate(true);
        }

        void SetHover(bool hover)
        {
            if (_hover == hover) return;
            _hover = hover;
            ApplyTheme(ThemeManager.Current);
        }

        protected override void OnMouseEnter(EventArgs e) { SetHover(true); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { SetHover(ClientRectangle.Contains(PointToClient(Cursor.Position))); base.OnMouseLeave(e); }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (_host != null) _host.SizeChanged -= Host_SizeChanged;
            _host = Parent;
            if (_host == null) return;

            _host.SizeChanged += Host_SizeChanged;
            ApplyTheme(ThemeManager.Current);
            Host_SizeChanged(_host, EventArgs.Empty);
        }

        void Host_SizeChanged(object sender, EventArgs e)
        {
            if (_host == null || !StretchToHost) return;

            // stretch to the column width so cards line up as a uniform list
            int reserve = SystemInformation.VerticalScrollBarWidth + Draw.SI(4);
            int target = _host.ClientSize.Width - reserve - Left;
            if (target > MinimumSize.Width) Width = Math.Max(PreferredSize.Width, target);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            Color stroke = appTitle.Checked ? p.Accent : (p.IsDark ? ColorMath.Blend(p.Layer1, Color.Black, 0.35) : p.Stroke);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(5)))
            using (SolidBrush b = new SolidBrush(CardFill))
            using (Pen pen = new Pen(stroke))
            {
                g.FillPath(b, path);
                g.DrawPath(pen, path);
            }
        }
    }
}