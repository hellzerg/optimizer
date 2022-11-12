using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonTree : TreeView
    {
        string[] rootNodes =
        {
            "cpu", "ram", "mobo", "gpu", "disk", "inet", "audio", "dev"
        };

        string _primaryItemTag = "_primary";

        public MoonTree()
        {
            this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.None;
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
            Rectangle r = new Rectangle();
            r.X = 0;
            r.Y = e.Bounds.Y;

            r.Height = e.Bounds.Height;
            r.Width = 100000;

            if (e.Node.IsSelected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), r); //e.Bounds
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), r); //e.Bounds
            }

            if (FindName(e.Node.Name)) TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Node.Bounds, Color.Silver);
            else if (e.Node.Tag != null && e.Node.Tag.ToString() == _primaryItemTag) TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Node.Bounds, Options.ForegroundColor);
            else TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Node.Bounds, Color.White);

            if (this.ImageList != null && this.ImageList.Images.Count > 0 && e.Node.SelectedImageIndex > -1)
            {
                e.Graphics.DrawImage(this.ImageList.Images[e.Node.SelectedImageIndex], e.Bounds.Left + 15 * e.Node.Level + 5, e.Bounds.Top);
            }
        }
    }
}
