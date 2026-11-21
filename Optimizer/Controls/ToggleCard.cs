using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Windows 11 Settings-style row: label on the left, switch on the right.
    /// </summary>
    public sealed partial class ToggleCard : UserControl, IThemeable {
        public event EventHandler ToggleClicked;

        bool _hover;
        readonly Timer _hoverTimer;

        public ToggleCard()
        {
            InitializeComponent();
            _hoverTimer = new Timer { Interval = 50 };
            _hoverTimer.Tick += HoverTimer_Tick;
            Disposed += ToggleCard_Disposed;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            this.IsAccessible = true;
            Label.IsAccessible = true;
            Toggle.IsAccessible = true;
            Panel.IsAccessible = true;

            this.AccessibleName = LabelText;
            Label.AccessibleName = LabelText;
            Toggle.AccessibleName = LabelText;
            Panel.AccessibleName = LabelText;

            foreach (Control c in new Control[] { Panel, Label, Toggle })
            {
                c.MouseEnter += Card_MouseEnter;
                c.MouseLeave += Card_MouseLeave;
                c.MouseMove += Card_MouseMove;
            }

            ApplyTheme(ThemeManager.Current);
        }

        public string LabelText
        {
            get { return Label.Text; }
            set
            {
                Label.Text = value;
                this.AccessibleName = value;
                Label.AccessibleName = value;
                Toggle.AccessibleName = value;
                Panel.AccessibleName = LabelText;
            }
        }

        public bool ToggleChecked
        {
            get { return Toggle.Checked; }
            set { Toggle.Checked = value; }
        }

        Color CardFill
        {
            get { return _hover ? ThemeManager.Current.Layer1Hover : ThemeManager.Current.Layer1; }
        }

        public void ApplyTheme(Palette palette)
        {
            Color fill = CardFill;
            BackColor = fill;
            Panel.BackColor = fill;
            Label.BackColor = fill;
            Label.ForeColor = palette.TextPrimary;
            Toggle.ApplyTheme(palette);
            Invalidate(true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(5)))
            using (SolidBrush b = new SolidBrush(CardFill))
            {
                g.FillPath(b, path);
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnParentBackColorChanged(e);
        }

        void SetHover(bool hover)
        {
            if (_hover == hover)
            {
                if (hover && !_hoverTimer.Enabled) _hoverTimer.Start();
                else if (!hover && _hoverTimer.Enabled) _hoverTimer.Stop();
                return;
            }

            _hover = hover;
            if (hover) _hoverTimer.Start();
            else _hoverTimer.Stop();
            ApplyTheme(ThemeManager.Current);
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            SetHover(true);
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            RefreshHoverFromCursor();
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            RefreshHoverFromCursor();
        }

        void RefreshHoverFromCursor()
        {
            if (IsDisposed || Disposing || !IsHandleCreated)
            {
                SetHover(false);
                return;
            }

            SetHover(RectangleToScreen(ClientRectangle).Contains(Cursor.Position));
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            RefreshHoverFromCursor();
        }

        private void ToggleCard_Disposed(object sender, EventArgs e)
        {
            _hoverTimer.Stop();
            _hoverTimer.Tick -= HoverTimer_Tick;
            _hoverTimer.Dispose();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            SetHover(true);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            RefreshHoverFromCursor();
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            RefreshHoverFromCursor();
            base.OnMouseLeave(e);
        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleClicked != null) ToggleClicked(sender, e);
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label.Font = Typography.WithStyle(Label.Font, FontStyle.Regular);
            Label.ForeColor = ThemeManager.Current.TextPrimary;
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label.Cursor = Label.Tag == null ? Cursors.Default : Cursors.Hand;
            if (Label.Tag == null) return;

            Label.Font = Typography.WithStyle(Label.Font, FontStyle.Underline);
            Label.ForeColor = ThemeManager.Current.AccentText;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (Label.Tag == null) return;
            TipBubble.Toggle(Label, LabelText, Label.Tag.ToString());
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            Label_MouseEnter(sender, e);
        }
    }
}