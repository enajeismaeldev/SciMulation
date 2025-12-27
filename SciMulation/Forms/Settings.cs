using SciMulation.Utils;

namespace SciMulation.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(245, 255, 255);

            label_Title.Font = AppFonts.Get(48f, FontWeight.Ultrabold, FontSlant.Regular);
            label_Fullscreen.Font = AppFonts.Get(36f, FontWeight.Regular, FontSlant.Regular);
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
