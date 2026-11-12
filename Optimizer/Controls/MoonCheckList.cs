using System.Drawing;
using System.Windows.Forms;

namespace Optimizer {
    public sealed class MoonCheckList : CheckedListBox, IThemeable {
        public MoonCheckList()
        {
            DoubleBuffered = true;
            BorderStyle = BorderStyle.None;
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = palette.TextPrimary;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Color foreColor = p.TextPrimary;

            if (this.Items.Count > 0)
            {
                if (e.Index >= 0)
                {
                    foreColor = GetItemChecked(e.Index) ? p.AccentText : foreColor;
                }
                else
                {
                    foreColor = e.ForeColor;
                }
            }

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            var tweakedEventArgs = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                selected ? (e.State & ~DrawItemState.Selected) : e.State,
                foreColor,
                selected ? p.Selection : BackColor);

            base.OnDrawItem(tweakedEventArgs);
        }

        string _emptyText = string.Empty;

        /// <summary>Message painted when the list has no items.</summary>
        [System.ComponentModel.Browsable(false), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string EmptyText
        {
            get { return _emptyText; }
            set { _emptyText = value ?? string.Empty; if (Items.Count == 0) Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x000F && Items.Count == 0 && _emptyText.Length > 0)
            {
                using (Graphics g = CreateGraphics())
                {
                    Rectangle r = new Rectangle(Draw.SI(16), Draw.SI(24), System.Math.Max(0, ClientSize.Width - Draw.SI(32)), System.Math.Max(0, ClientSize.Height - Draw.SI(24)));
                    TextRenderer.DrawText(g, _emptyText, Typography.Get(10.5f, Typography.Weight.Regular), r, ThemeManager.Current.TextSecondary,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
                }
            }
        }
    }
}