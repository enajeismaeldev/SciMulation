using SciMulation.Utils;

namespace SciMulation.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(245, 255, 255);

            label_Title.Font = AppFonts.Get(90f, FontWeight.Ultrabold, FontSlant.Regular);
            label_Footer.Font = AppFonts.Get(18f, FontWeight.Regular, FontSlant.Regular);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (MdiParent is Layout mdi)
            {
                mdi.OpenForm<Level>();
                Close();
            }
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            if (MdiParent is Layout mdi)
            {
                mdi.OpenForm<Settings>();
                Close();
            }
        }
    }
}
