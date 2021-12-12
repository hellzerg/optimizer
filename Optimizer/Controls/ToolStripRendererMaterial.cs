using System.Drawing;
using System.Windows.Forms;

namespace Optimizer
{
    internal class ToolStripRendererMaterial : ToolStripProfessionalRenderer
    {
        internal ToolStripRendererMaterial() : base(new ColorsMaterial())
        {

        }

        //protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        //{
        //    var tsMenuItem = e.Item as ToolStripMenuItem;
        //    if (tsMenuItem != null)
        //        e.ArrowColor = Options.ForegroundColor;
        //    base.OnRenderArrow(e);
        //}
    }

    internal class ColorsMaterial : ProfessionalColorTable
    {
        public override Color SeparatorLight
        {
            get { return Options.BackAccentColor; }
        }

        public override Color SeparatorDark
        {
            get { return Options.BackAccentColor; }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Options.BackgroundColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Options.BackgroundColor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Options.BackgroundColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Options.BackgroundColor;
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return Options.BackgroundColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Options.BackAccentColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Options.BackAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Options.BackAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Options.BackAccentColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Options.BackAccentColor;
            }
        }
    }
}
