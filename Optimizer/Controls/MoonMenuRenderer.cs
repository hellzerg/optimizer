using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    internal sealed class MoonMenuRenderer : ToolStripProfessionalRenderer {
        internal MoonMenuRenderer() : base(new MoonColors())
        {
            RoundedEdges = false;
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected || !e.Item.Enabled)
            {
                base.OnRenderMenuItemBackground(e);
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF r = new RectangleF(Draw.S(4), 1, e.Item.Width - Draw.S(8), e.Item.Height - 2);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(4)))
            using (SolidBrush b = new SolidBrush(ThemeManager.Current.Selection))
            {
                g.FillPath(b, path);
            }

            if (e.ToolStrip is ToolStripDropDown)
            {
                float barH = r.Height * 0.45f;
                RectangleF bar = new RectangleF(r.X + Draw.S(3), r.Y + (r.Height - barH) / 2f, Draw.S(3), barH);
                using (GraphicsPath path = Draw.RoundedRect(bar, Draw.S(1.5f)))
                using (SolidBrush b = new SolidBrush(ThemeManager.Current.AccentText))
                {
                    g.FillPath(b, path);
                }
            }
            g.SmoothingMode = SmoothingMode.None;
        }

        // Width of the icon column: leading room for the hover accent bar plus the 16px glyph.
        internal static Size GlyphSlot
        {
            get { return new Size(Draw.SI(30), Draw.SI(16)); }
        }

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            if (!(e.Item.Tag is SidebarNav.Glyph))
            {
                base.OnRenderItemImage(e);
                return;
            }

            int size = Draw.SI(16);
            Rectangle slot = e.ImageRectangle;
            Rectangle glyph = new Rectangle(slot.Right - size, (e.Item.Height - size) / 2, size, size);
            Color color = e.Item.Enabled ? ThemeManager.Current.TextPrimary : ThemeManager.Current.TextDisabled;

            Graphics g = e.Graphics;
            SmoothingMode oldMode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SidebarNav.PaintGlyph(g, (SidebarNav.Glyph)e.Item.Tag, glyph, color);
            g.SmoothingMode = oldMode;
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            Color color = e.Item.Enabled ? ThemeManager.Current.TextPrimary : ThemeManager.Current.TextDisabled;
            if (!(e.ToolStrip is ToolStripDropDown) || !(e.Item is ToolStripMenuItem))
            {
                e.TextColor = color;
                base.OnRenderItemText(e);
                return;
            }

            Rectangle r = new Rectangle(e.TextRectangle.X, 0, e.Item.Width - e.TextRectangle.X, e.Item.Height);
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine
                | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding;
            ToolStripMenuItem mi = (ToolStripMenuItem)e.Item;
            if (mi.ShowShortcutKeys && !string.IsNullOrEmpty(mi.ShortcutKeyDisplayString) && e.Text == mi.ShortcutKeyDisplayString && e.Text != mi.Text)
            {
                Rectangle sr = new Rectangle(0, 0, e.Item.Width - Draw.SI(12), e.Item.Height);
                Color badge = e.Item.Enabled ? Tones.Success(ThemeManager.Current) : color;
                TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont, sr, badge, (flags & ~TextFormatFlags.Left) | TextFormatFlags.Right);
                return;
            }
            if (mi.HasDropDownItems) r.Width -= Draw.SI(20);
            TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont, r, color, flags);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
                e.ArrowColor = ThemeManager.Current.TextSecondary;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            int y = e.Item.Height / 2;
            using (Pen pen = new Pen(ThemeManager.Current.Stroke))
            {
                e.Graphics.DrawLine(pen, Draw.SI(8), y, e.Item.Width - Draw.SI(8), y);
            }
        }
    }

    internal sealed class MoonColors : ProfessionalColorTable {
        public MoonColors()
        {
            UseSystemColors = false;
        }

        static Palette P { get { return ThemeManager.Current; } }

        public override Color SeparatorLight { get { return P.Stroke; } }
        public override Color SeparatorDark { get { return P.Stroke; } }
        public override Color ToolStripDropDownBackground { get { return P.Layer2; } }
        public override Color ImageMarginGradientBegin { get { return P.Layer2; } }
        public override Color ImageMarginGradientMiddle { get { return P.Layer2; } }
        public override Color ImageMarginGradientEnd { get { return P.Layer2; } }
        public override Color ToolStripBorder { get { return P.Stroke; } }
        public override Color MenuBorder { get { return P.Stroke; } }
        public override Color MenuItemSelected { get { return P.Selection; } }
        public override Color MenuItemSelectedGradientBegin { get { return P.Selection; } }
        public override Color MenuItemSelectedGradientEnd { get { return P.Selection; } }
        public override Color MenuItemBorder { get { return P.Selection; } }
        public override Color MenuItemPressedGradientBegin { get { return P.ControlPressed; } }
        public override Color MenuItemPressedGradientEnd { get { return P.ControlPressed; } }
        public override Color CheckBackground { get { return P.Selection; } }
        public override Color CheckSelectedBackground { get { return P.Selection; } }
        public override Color CheckPressedBackground { get { return P.Selection; } }
    }
}