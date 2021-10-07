using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public class ColoredCheckList : CheckedListBox
    {
        public ColoredCheckList()
        {
            DoubleBuffered = true;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Color foreColor = Color.Silver;
            Color accentColor = Color.MediumOrchid;

            switch (Options.CurrentOptions.Color)
            {
                case Theme.Caramel:
                    accentColor = Color.DarkOrange;
                    break;
                case Theme.Lime:
                    accentColor = Color.LimeGreen;
                    break;
                case Theme.Magma:
                    accentColor = Color.Tomato;
                    break;
                case Theme.Minimal:
                    accentColor = Color.Gray;
                    break;
                case Theme.Ocean:
                    accentColor = Color.DodgerBlue;
                    break;
                case Theme.Zerg:
                    accentColor = Color.MediumOrchid;
                    break;
            }

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
