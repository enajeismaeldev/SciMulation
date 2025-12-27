using SciMulation.Utils;

namespace SciMulation.Forms
{
    public partial class SimulationList : Form
    {
        public SimulationList()
        {
            InitializeComponent();

            DoubleBuffered = true;
            BackColor = Color.FromArgb(245, 255, 255);

            label_Title.Font = AppFonts.Get(48f, FontWeight.Ultrabold, FontSlant.Regular);
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
