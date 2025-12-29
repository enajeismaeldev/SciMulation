namespace SciMulation.Forms
{
    partial class Credits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Title = new Label();
            button_Exit = new SciMulation.Assets.controls.ImageButton();
            panelCredits = new Panel();
            lblCredits = new Label();
            creditsTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panelCredits.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label_Title, 0, 1);
            tableLayoutPanel1.Controls.Add(button_Exit, 0, 0);
            tableLayoutPanel1.Controls.Add(panelCredits, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(1200, 768);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Title.AutoSize = true;
            label_Title.BackColor = Color.Transparent;
            label_Title.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(3, 104);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1194, 86);
            label_Title.TabIndex = 0;
            label_Title.Text = "Credits";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Exit
            // 
            button_Exit.Anchor = AnchorStyles.Right;
            button_Exit.BackgroundImage = Properties.Resources.button_exit;
            button_Exit.BackgroundImageLayout = ImageLayout.Center;
            button_Exit.FlatAppearance.BorderSize = 0;
            button_Exit.FlatStyle = FlatStyle.Flat;
            button_Exit.Location = new Point(1105, 3);
            button_Exit.Name = "button_Exit";
            button_Exit.NormalImage = Properties.Resources.button_exit;
            button_Exit.PressedImage = Properties.Resources.button_exit_pressed;
            button_Exit.Size = new Size(92, 91);
            button_Exit.TabIndex = 8;
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // panelCredits
            // 
            panelCredits.BackColor = Color.Transparent;
            panelCredits.Controls.Add(lblCredits);
            panelCredits.Dock = DockStyle.Fill;
            panelCredits.Location = new Point(3, 200);
            panelCredits.Name = "panelCredits";
            panelCredits.Size = new Size(1194, 565);
            panelCredits.TabIndex = 9;
            // 
            // lblCredits
            // 
            lblCredits.AutoSize = true;
            lblCredits.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCredits.Location = new Point(587, 10);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(24, 32);
            lblCredits.TabIndex = 0;
            lblCredits.Text = "-";
            lblCredits.TextAlign = ContentAlignment.TopCenter;
            // 
            // creditsTimer
            // 
            creditsTimer.Interval = 30;
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 768);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 768);
            Name = "Credits";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            FormClosing += Credits_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelCredits.ResumeLayout(false);
            panelCredits.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Title;
        private Assets.controls.ImageButton button_Exit;
        private Panel panelCredits;
        private Label lblCredits;
        private System.Windows.Forms.Timer creditsTimer;
    }
}