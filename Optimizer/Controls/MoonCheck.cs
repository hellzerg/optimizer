using System;
using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonCheck : CheckBox
    {
        public MoonCheck()
        {
            DoubleBuffered = true;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            // custom theming
            if (this.Checked)
            {
                this.Tag = "themeable";
                this.Font = new Font(this.Font, FontStyle.Underline);

                this.ForeColor = Options.ForegroundColor;
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
