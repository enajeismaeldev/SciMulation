namespace SciMulation.Forms
{
    partial class Level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level));
            tableLayoutPanel1 = new TableLayoutPanel();
            label_Title = new Label();
            imageButton1 = new SciMulation.Assets.controls.ImageButton();
            imageButton2 = new SciMulation.Assets.controls.ImageButton();
            button_Exit = new SciMulation.Assets.controls.ImageButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label_Title, 0, 1);
            tableLayoutPanel1.Controls.Add(imageButton1, 0, 3);
            tableLayoutPanel1.Controls.Add(imageButton2, 1, 3);
            tableLayoutPanel1.Controls.Add(button_Exit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 768);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label_Title
            // 
            label_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Title.AutoSize = true;
            label_Title.BackColor = Color.Transparent;
            tableLayoutPanel1.SetColumnSpan(label_Title, 2);
            label_Title.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(3, 104);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(1194, 86);
            label_Title.TabIndex = 0;
            label_Title.Text = "Grade Level";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageButton1
            // 
            imageButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            imageButton1.BackColor = Color.Transparent;
            imageButton1.BackgroundImage = Properties.Resources.button_grade7;
            imageButton1.BackgroundImageLayout = ImageLayout.Center;
            imageButton1.FlatAppearance.BorderSize = 0;
            imageButton1.FlatStyle = FlatStyle.Flat;
            imageButton1.Location = new Point(7, 280);
            imageButton1.Name = "imageButton1";
            imageButton1.NormalImage = Properties.Resources.button_grade7;
            imageButton1.PressedImage = Properties.Resources.button_grade7_pressed;
            imageButton1.Size = new Size(586, 231);
            imageButton1.TabIndex = 6;
            imageButton1.UseVisualStyleBackColor = false;
            // 
            // imageButton2
            // 
            imageButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            imageButton2.BackColor = Color.Transparent;
            imageButton2.BackgroundImage = Properties.Resources.button_grade8;
            imageButton2.BackgroundImageLayout = ImageLayout.Center;
            imageButton2.FlatAppearance.BorderSize = 0;
            imageButton2.FlatStyle = FlatStyle.Flat;
            imageButton2.Location = new Point(607, 280);
            imageButton2.Name = "imageButton2";
            imageButton2.NormalImage = Properties.Resources.button_grade8;
            imageButton2.PressedImage = Properties.Resources.button_grade8_pressed;
            imageButton2.Size = new Size(586, 231);
            imageButton2.TabIndex = 7;
            imageButton2.UseVisualStyleBackColor = false;
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
            // Level
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1200, 768);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 768);
            Name = "Level";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Level";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_Title;
        private Assets.controls.ImageButton imageButton1;
        private Assets.controls.ImageButton imageButton2;
        private Assets.controls.ImageButton button_Exit;
    }
}