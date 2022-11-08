using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonCheckList : CheckedListBox
    {
        public MoonCheckList()
        {
            DoubleBuffered = true;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Color foreColor = Color.White;
            Color accentColor = Options.ForegroundColor;

            if (this.Items.Count > 0)
            {
                if (e.Index >= 0)
                {
                    foreColor = GetItemChecked(e.Index) ? accentColor : foreColor;
                }
                else
                {
                    foreColor = e.ForeColor;
                }
            }

            var tweakedEventArgs = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                e.State,
                foreColor,
                e.BackColor);

            base.OnDrawItem(tweakedEventArgs);
        }
    }
}
