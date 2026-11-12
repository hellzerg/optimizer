using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optimizer {
    public sealed class MoonCheck : CheckBox, IThemeable, IChoice {
        bool _hover;
        bool _pressed;

        public MoonCheck()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
        }

        bool IChoice.KeyboardCues { get { return ShowKeyboardCues; } }
        bool IChoice.FocusCues { get { return ShowFocusCues; } }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = palette.TextPrimary;
            Invalidate();
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            // keeps the legacy marker that other code paths use to recognize checked items
            this.Tag = this.Checked ? Constants.THEME_FLAG : string.Empty;
            Invalidate();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return ChoicePainter.PreferredSize(this, Image);
        }

        protected override void OnMouseEnter(EventArgs eventargs) { _hover = true; Invalidate(); base.OnMouseEnter(eventargs); }
        protected override void OnMouseLeave(EventArgs eventargs) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(eventargs); }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (mevent.Button == MouseButtons.Left) { _pressed = true; Invalidate(); }
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _pressed = false;
            Invalidate();
            base.OnMouseUp(mevent);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            ChoicePainter.Paint(this, pevent.Graphics, false, CheckState, _hover, _pressed, Image);
        }
    }
}