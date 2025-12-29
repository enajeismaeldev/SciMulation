using SciMulation.Utils;
using System.Text;

namespace SciMulation.Forms;

public partial class Credits : Form
{
    public Credits()
    {
        InitializeComponent();
        Initialize();

        DoubleBuffered = true;
        BackColor = Color.FromArgb(245, 255, 255);

        label_Title.Font = AppFonts.Get(48f, FontWeight.Ultrabold, FontSlant.Regular);
        lblCredits.Font = AppFonts.Get(18f, FontWeight.Regular, FontSlant.Regular);
    }

    public void Initialize()
    {
        var reseachers = new Researchers[]
        {
            new Researchers("Leonardo De Caprio", "Project Leader"),
            new Researchers("Trevor Noah", "Member"),
            new Researchers("Steve Harvey", "Member"),
            new Researchers("Jackie Chan", "Member"),
        };

        var teachers = new Teachers[]
{
            new Teachers("Ms.Minchin 1"),
            new Teachers("Ms.Minchin 2"),
            new Teachers("Ms.Minchin 3"),
            new Teachers("Ms.Minchin 4"),
            new Teachers("Ms.Minchin 5"),
        };

        var sources = new Sources[]
        {
            new Sources("Lesson 1", "Wikipedia"),
            new Sources("Lesson 2", "Wikipedia"),
            new Sources("Lesson 3", "Wikipedia"),
            new Sources("Lesson 4", "Wikipedia"),
            new Sources("Lesson 5", "Wikipedia")
        };


        var credits = new StringBuilder();

        credits.AppendLine("Researchers");
        credits.AppendLine("");
        foreach (var reseacher in reseachers)
        {
            credits.AppendLine($"{reseacher.Name} - {reseacher.AssignedAs}");
        }
        credits.AppendLine("");
        credits.AppendLine("");

        credits.AppendLine("Teachers");
        credits.AppendLine("");
        foreach (var teacher in teachers)
        {
            credits.AppendLine($"{teacher.Name}");
        }
        credits.AppendLine("");
        credits.AppendLine("");

        credits.AppendLine("Sources");
        credits.AppendLine("");
        foreach (var source in sources)
        {
            credits.AppendLine($"{source.Lesson}");
            credits.AppendLine($"{source.Source}");
        }
        credits.AppendLine("");
        credits.AppendLine("");

        credits.AppendLine("© 2026");

        lblCredits.Text = credits.ToString();
        lblCredits.Left = (panelCredits.Width - lblCredits.Width) / 2;
        lblCredits.Top = panelCredits.Height;

        creditsTimer.Tick += CreditsTimer_Tick;
        creditsTimer.Start();
    }

    private void CreditsTimer_Tick(object sender, EventArgs e)
    {
        lblCredits.Top -= 1;

        if (lblCredits.Bottom < 0)
        {
            creditsTimer.Stop();
        }
    }

    private void Credits_FormClosing(object sender, FormClosingEventArgs e)
    {
        creditsTimer.Tick -= CreditsTimer_Tick;
    }

    public class Teachers
    {
        public Teachers(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class Sources
    {
        public Sources(string lesson, string source)
        {
            Lesson = lesson;
            Source = source;
        }

        public string Lesson { get; set; }
        public string Source { get; set; }
    }

    public class Researchers
    {
        public Researchers(string name, string assignedAs)
        {
            Name = name;
            AssignedAs = assignedAs;
        }

        public string Name { get; set; }
        public string AssignedAs { get; set; }
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
