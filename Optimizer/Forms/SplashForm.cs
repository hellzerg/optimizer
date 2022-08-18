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

            switch (Options.CurrentOptions.Color)
            {
                case Theme.Amber:
                    //pictureBox1.Image = Properties.Resources.loadingAmber;
                    pictureBox2.Image = Properties.Resources.bannerAmber;
                    break;
                case Theme.Jade:
                    //pictureBox1.Image = Properties.Resources.loadingJade;
                    pictureBox2.Image = Properties.Resources.bannerJade;
                    break;
                case Theme.Ruby:
                    //pictureBox1.Image = Properties.Resources.loadingRuby;
                    pictureBox2.Image = Properties.Resources.bannerRuby;
                    break;
                case Theme.Silver:
                    //pictureBox1.Image = Properties.Resources.loadingSilver;
                    pictureBox2.Image = Properties.Resources.bannerSilver;
                    break;
                case Theme.Azurite:
                    //pictureBox1.Image = Properties.Resources.loadingAzurite;
                    pictureBox2.Image = Properties.Resources.bannerAzurite;
                    break;
                case Theme.Amethyst:
                    //pictureBox1.Image = Properties.Resources.loadingAmethyst;
                    pictureBox2.Image = Properties.Resources.bannerAmethyst;
                    break;
            }
        }
    }
}
