using SciMulation.Assets.controls;

namespace SciMulation.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label_Title = new Label();
            button_Start = new ImageButton();
            button_Settings = new ImageButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            button_Credits = new ImageButton();
            label_Footer = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Title.AutoSize = true;
            label_Title.BackColor = Color.Transparent;
            label_Title.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(3, 143);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1194, 128);
            label_Title.TabIndex = 0;
            label_Title.Text = "SciMulation";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            button_Start.Anchor = AnchorStyles.Top;
            button_Start.BackColor = Color.Transparent;
            button_Start.BackgroundImage = (Image)resources.GetObject("button_Start.BackgroundImage");
            button_Start.BackgroundImageLayout = ImageLayout.Center;
            button_Start.FlatAppearance.BorderSize = 0;
            button_Start.FlatStyle = FlatStyle.Flat;
            button_Start.Location = new Point(501, 282);
            button_Start.Margin = new Padding(0);
            button_Start.Name = "button_Start";
            button_Start.NormalImage = Properties.Resources.button_start;
            button_Start.PressedImage = Properties.Resources.button_start_pressed;
            button_Start.Size = new Size(198, 96);
            button_Start.TabIndex = 1;
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button_Settings
            // 
            button_Settings.Anchor = AnchorStyles.Top;
            button_Settings.BackColor = Color.Transparent;
            button_Settings.BackgroundImage = (Image)resources.GetObject("button_Settings.BackgroundImage");
            button_Settings.BackgroundImageLayout = ImageLayout.Center;
            button_Settings.FlatAppearance.BorderSize = 0;
            button_Settings.FlatStyle = FlatStyle.Flat;
            button_Settings.Location = new Point(452, 381);
            button_Settings.Name = "button_Settings";
            button_Settings.NormalImage = Properties.Resources.button_settings;
            button_Settings.PressedImage = Properties.Resources.button_settings_pressed;
            button_Settings.Size = new Size(296, 99);
            button_Settings.TabIndex = 2;
            button_Settings.UseVisualStyleBackColor = false;
            button_Settings.Click += button_Settings_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_Title, 0, 1);
            tableLayoutPanel1.Controls.Add(button_Settings, 0, 3);
            tableLayoutPanel1.Controls.Add(button_Start, 0, 2);
            tableLayoutPanel1.Controls.Add(button_Credits, 0, 4);
            tableLayoutPanel1.Controls.Add(label_Footer, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1200, 768);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button_Credits
            // 
            button_Credits.Anchor = AnchorStyles.Top;
            button_Credits.BackColor = Color.Transparent;
            button_Credits.BackgroundImage = Properties.Resources.button_credits;
            button_Credits.BackgroundImageLayout = ImageLayout.Center;
            button_Credits.FlatAppearance.BorderSize = 0;
            button_Credits.FlatStyle = FlatStyle.Flat;
            button_Credits.Location = new Point(460, 486);
            button_Credits.Name = "button_Credits";
            button_Credits.NormalImage = Properties.Resources.button_credits;
            button_Credits.PressedImage = Properties.Resources.button_credits_pressed;
            button_Credits.Size = new Size(280, 97);
            button_Credits.TabIndex = 3;
            button_Credits.UseVisualStyleBackColor = false;
            // 
            // label_Footer
            // 
            label_Footer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Footer.AutoSize = true;
            label_Footer.BackColor = Color.Transparent;
            label_Footer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Footer.Location = new Point(3, 727);
            label_Footer.Name = "label_Footer";
            label_Footer.Size = new Size(1194, 32);
            label_Footer.TabIndex = 4;
            label_Footer.Text = "A Capstone Project of Group 3; Copyright 2026";
            label_Footer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1200, 768);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 768);
            Name = "Home";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Home";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_Title;
        private ImageButton button_Start;
        private ImageButton button_Settings;
        private TableLayoutPanel tableLayoutPanel1;
        private ImageButton button_Credits;
        private Label label_Footer;
    }
}