using SciMulation.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SciMulation
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();

            IsMdiContainer = true;
            BackColor = Color.FromArgb(245, 255, 255);
            ControlBox = false;
            MinimizeBox = false;
            MaximizeBox = false;

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            UpdateStyles();

            OpenForm<Home>();
        }

        public string CurrentMode { get; set; } = "Windowed";

        public void OpenForm<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }

            var child = new T
            {
                MdiParent = this,
                AutoScroll = false,
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Normal,
                MinimizeBox = false,
                MaximizeBox = false,
                ControlBox = false,
            };

            child.Show();
        }
    }
}
