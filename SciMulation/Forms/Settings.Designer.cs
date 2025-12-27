namespace SciMulation.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Title = new Label();
            label_Fullscreen = new Label();
            button_Exit = new SciMulation.Assets.controls.ImageButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_Title, 0, 1);
            tableLayoutPanel1.Controls.Add(label_Fullscreen, 0, 2);
            tableLayoutPanel1.Controls.Add(button_Exit, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 768);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Title.AutoSize = true;
            label_Title.BackColor = Color.Transparent;
            label_Title.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(3, 101);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1194, 86);
            label_Title.TabIndex = 0;
            label_Title.Text = "Settings";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Fullscreen
            // 
            label_Fullscreen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Fullscreen.AutoSize = true;
            label_Fullscreen.BackColor = Color.Transparent;
            label_Fullscreen.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Fullscreen.Location = new Point(3, 199);
            label_Fullscreen.Name = "label_Fullscreen";
            label_Fullscreen.Size = new Size(1194, 65);
            label_Fullscreen.TabIndex = 1;
            label_Fullscreen.Text = "Mode";
            label_Fullscreen.TextAlign = ContentAlignment.MiddleCenter;
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
            button_Exit.TabIndex = 2;
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 768);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 768);
            Name = "Settings";
            Text = "Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Title;
        private Label label_Fullscreen;
        private Assets.controls.ImageButton button_Exit;
    }
}