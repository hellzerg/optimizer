using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed class MoonList : ListBox, IThemeable {
        public MoonList()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.MeasureItem += MoonListBox_MeasureItem;
            this.DrawItem += MoonListBox_DrawItem;
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = palette.TextPrimary;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        private void MoonListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if (this.Items.Count <= 0) return;

            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            using (SolidBrush back = new SolidBrush(BackColor)) g.FillRectangle(back, e.Bounds);

            if (selected)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                RectangleF r = new RectangleF(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 4, e.Bounds.Height - 2);
                using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(4)))
                using (SolidBrush b = new SolidBrush(p.Selection))
                {
                    g.FillPath(b, path);
                }

                float barH = r.Height * 0.5f;
                using (GraphicsPath bar = Draw.RoundedRect(new RectangleF(r.X, r.Y + (r.Height - barH) / 2, Draw.S(3), barH), Draw.S(1.5f)))
                using (SolidBrush b = new SolidBrush(p.Accent))
                {
                    g.FillPath(b, bar);
                }
                g.SmoothingMode = SmoothingMode.None;
            }

            object item = this.Items[e.Index];
            string text = item.ToString();
            Color color = p.TextPrimary;
            if (ItemColor != null)
            {
                Color? custom = ItemColor(item);
                if (custom.HasValue) color = custom.Value;
            }

            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix;
            Rectangle textRect = new Rectangle(e.Bounds.X + Draw.SI(10), e.Bounds.Y, e.Bounds.Width - Draw.SI(12), e.Bounds.Height);

            int fullWidth = textRect.Width;
            string badge = ItemBadge != null ? ItemBadge(item) : null;
            if (!string.IsNullOrEmpty(badge))
            {
                Font badgeFont = Typography.Get(8f, Typography.Weight.Semibold);
                Size bs = TextRenderer.MeasureText(g, badge, badgeFont, Size.Empty, TextFormatFlags.NoPadding);
                int bw = bs.Width + Draw.SI(14), bh = bs.Height + Draw.SI(4);
                Rectangle br = new Rectangle(e.Bounds.Right - bw - Draw.SI(10), e.Bounds.Y + (e.Bounds.Height - bh) / 2, bw, bh);
                Color tint = ItemBadgeColor != null ? ItemBadgeColor(item) : p.Danger;

                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath pill = Draw.RoundedRect(br, bh / 2f))
                using (SolidBrush b = new SolidBrush(ColorMath.Blend(BackColor, tint, 0.22)))
                {
                    g.FillPath(b, pill);
                }
                g.SmoothingMode = SmoothingMode.None;
                TextRenderer.DrawText(g, badge, badgeFont, br, tint, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix);
                textRect.Width = br.Left - Draw.SI(8) - textRect.Left;
            }

            int split = ColumnSeparator == null ? -1 : text.IndexOf(ColumnSeparator, System.StringComparison.Ordinal);
            if (split >= 0)
            {
                int col = Math.Min(Draw.SI(FirstColumnWidth), fullWidth / 2);
                Rectangle first = new Rectangle(textRect.X, textRect.Y, col - Draw.SI(8), textRect.Height);
                Rectangle second = new Rectangle(textRect.X + col, textRect.Y, Math.Max(0, textRect.Width - col), textRect.Height);
                TextRenderer.DrawText(g, text.Substring(0, split), this.Font, first, selected ? color : p.TextSecondary, flags);
                TextRenderer.DrawText(g, text.Substring(split + ColumnSeparator.Length), this.Font, second, color, flags);
                return;
            }

            TextRenderer.DrawText(g, text, this.Font, textRect, color, flags);
        }

        /// <summary>Optional per-item text color.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<object, Color?> ItemColor { get; set; }

        /// <summary>Optional per-item pill drawn at the right edge (null/empty = none).</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<object, string> ItemBadge { get; set; }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<object, Color> ItemBadgeColor { get; set; }

        /// <summary>When set, item text is split at the first occurrence and drawn as two columns.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ColumnSeparator { get; set; }

        /// <summary>Width of the first column in 96 DPI pixels.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FirstColumnWidth { get; set; } = 160;

        /// <summary>Message painted when the list has no items.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyText
        {
            get { return _emptyText; }
            set { _emptyText = value ?? string.Empty; if (Items.Count == 0) Invalidate(); }
        }
        string _emptyText = string.Empty;

        const int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && Items.Count == 0 && _emptyText.Length > 0)
            {
                using (Graphics g = CreateGraphics())
                {
                    Rectangle r = new Rectangle(Draw.SI(16), Draw.SI(24), Math.Max(0, ClientSize.Width - Draw.SI(32)), Math.Max(0, ClientSize.Height - Draw.SI(24)));
                    TextRenderer.DrawText(g, _emptyText, Typography.Get(10.5f, Typography.Weight.Regular), r, ThemeManager.Current.TextSecondary,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
                }
            }
        }

        private void MoonListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Font.Height + Draw.SI(10);
        }
    }
}