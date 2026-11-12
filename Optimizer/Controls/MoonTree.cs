using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed class MoonTree : TreeView, IThemeable {
        string[] rootNodes =
        {
            "cpu", "ram", "mobo", "gpu", "disk", "inet", "audio", "dev"
        };

        string _primaryItemTag = "_primary";

        public MoonTree()
        {
            this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.BackColor = ThemeManager.Current.WindowBg;
            this.ForeColor = ThemeManager.Current.TextPrimary;
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
        }

        public void ApplyTheme(Palette palette)
        {
            if (Parent != null) BackColor = Parent.BackColor;
            ForeColor = palette.TextPrimary;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        private bool FindName(string name)
        {
            foreach (string x in rootNodes)
            {
                if (x == name) return true;
            }
            return false;
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(0, e.Bounds.Y, this.ClientSize.Width, e.Bounds.Height);
            using (SolidBrush back = new SolidBrush(BackColor)) g.FillRectangle(back, r);

            if (e.Node.IsSelected)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                RectangleF sr = new RectangleF(r.X + 2, r.Y + 1, r.Width - 4, r.Height - 2);
                using (GraphicsPath path = Draw.RoundedRect(sr, Draw.S(4)))
                using (SolidBrush b = new SolidBrush(p.Selection))
                {
                    g.FillPath(b, path);
                }
                g.SmoothingMode = SmoothingMode.None;
            }

            Color color;
            if (FindName(e.Node.Name)) color = p.TextSecondary;
            else if (e.Node.Tag != null && e.Node.Tag.ToString() == _primaryItemTag) color = p.AccentText;
            else color = p.TextPrimary;

            TextRenderer.DrawText(g, e.Node.Text, this.Font, e.Node.Bounds, color, TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix);

            if (this.ImageList != null && this.ImageList.Images.Count > 0 && e.Node.SelectedImageIndex > -1)
            {
                g.DrawImage(this.ImageList.Images[e.Node.SelectedImageIndex], e.Bounds.Left + 15 * e.Node.Level + 5, e.Bounds.Top);
            }
        }
    }
}