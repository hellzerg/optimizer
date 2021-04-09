using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    internal class ToolStripRendererMaterial : ToolStripProfessionalRenderer
    {
        internal ToolStripRendererMaterial() : base(new ColorsMaterial())
        {

        }
    }

    internal class ColorsMaterial : ProfessionalColorTable
    {
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
                return Options.ForegroundColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Options.ForegroundColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Options.ForegroundAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Options.ForegroundAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Options.ForegroundAccentColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Options.ForegroundColor;
            }
        }
    }
}
