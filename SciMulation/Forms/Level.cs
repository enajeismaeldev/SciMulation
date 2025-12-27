using SciMulation.Utils;

namespace SciMulation.Forms
{
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(245, 255, 255);

            label_Title.Font = AppFonts.Get(48f, FontWeight.Ultrabold, FontSlant.Regular);
        }

        private void button_Grade7_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MdiParent is Layout mdi)
            {
                mdi.OpenForm<Home>();
                Close();
            }
        }
    }
}
