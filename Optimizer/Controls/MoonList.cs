using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonList : ListBox
    {
        public MoonList()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.BorderStyle = BorderStyle.None;

            this.MeasureItem += MoonListBox_MeasureItem;
            this.DrawItem += MoonListBox_DrawItem;
        }

        private void MoonListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if (this.Items.Count <= 0) return;

            e.DrawBackground();

            Brush myBrush = new SolidBrush(Color.White);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
            }

            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), e.Bounds);

            }

            e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void MoonListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Font.Height;
        }
    }
}
