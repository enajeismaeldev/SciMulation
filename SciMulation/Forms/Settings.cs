using SciMulation.Properties;
using SciMulation.Utils;

namespace SciMulation.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            DoubleBuffered = true;
            BackColor = Color.FromArgb(245, 255, 255);

            label_Title.Font = AppFonts.Get(48f, FontWeight.Ultrabold, FontSlant.Regular);
            label_Fullscreen.Font = AppFonts.Get(36f, FontWeight.Regular, FontSlant.Regular);
        }

        private const string Windowed = "Windowed";
        private const string FullScreen = "FullScreen";


        private void SyncCurrentMode()
        {
            if (MdiParent is Layout mdi)
            {
                if (mdi.CurrentMode == Windowed)
                {
                    button_Mode.Image = Resources.button_fullscreen;
                    button_Mode.NormalImage = Resources.button_fullscreen;
                    button_Mode.PressedImage = Resources.button_fullscreen_pressed;
                }
                else
                {
                    button_Mode.Image = Resources.button_windowed;
                    button_Mode.NormalImage = Resources.button_windowed;
                    button_Mode.PressedImage = Resources.button_windowed_pressed;
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (MdiParent is Layout mdi)
            {
                mdi.OpenForm<Home>();
                Close();
            }
        }

        private void button_Mode_Click(object sender, EventArgs e)
        {
            if (MdiParent is Layout mdi)
            {
                if (mdi.CurrentMode == Windowed)
                {
                    mdi.CurrentMode = FullScreen;
                    mdi.WindowState = FormWindowState.Maximized;

                    WindowState = FormWindowState.Maximized;

                    button_Mode.Image = Resources.button_fullscreen;
                    button_Mode.NormalImage = Resources.button_fullscreen;
                    button_Mode.PressedImage = Resources.button_fullscreen_pressed;
                }
                else
                {
                    mdi.CurrentMode = Windowed;
                    mdi.WindowState = FormWindowState.Normal;

                    WindowState = FormWindowState.Normal;

                    button_Mode.Image = Resources.button_windowed;
                    button_Mode.NormalImage = Resources.button_windowed;
                    button_Mode.PressedImage = Resources.button_windowed_pressed;
                }
            }
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            SyncCurrentMode();
        }
    }
}
