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

            LoadingStatus.Font = FontHelper.Poppins15;

            pictureBox2.BackColor = Options.CurrentOptions.Theme;
        }
    }
}
