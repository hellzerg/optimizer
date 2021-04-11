using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public class ColoredRadioButton : RadioButton
    {
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            // custom theming
            if (this.Checked)
            {
                this.Tag = "themeable";
                this.Font = new Font(this.Font, FontStyle.Underline);

                switch (Options.CurrentOptions.Color)
                {
                    case Theme.Caramel:
                        this.ForeColor = Color.DarkOrange;
                        break;
                    case Theme.Lime:
                        this.ForeColor = Color.LimeGreen;
                        break;
                    case Theme.Magma:
                        this.ForeColor = Color.Tomato;
                        break;
                    case Theme.Minimal:
                        this.ForeColor = Color.Gray;
                        break;
                    case Theme.Ocean:
                        this.ForeColor = Color.DodgerBlue;
                        break;
                    case Theme.Zerg:
                        this.ForeColor = Color.MediumOrchid;
                        break;
                }
            }
            else
            {
                this.Tag = string.Empty;
                this.ForeColor = Color.White;
                this.Font = new Font(this.Font, FontStyle.Regular);
            }
        }
    }
}
