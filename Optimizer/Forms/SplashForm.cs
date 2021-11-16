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
