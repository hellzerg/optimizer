using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
