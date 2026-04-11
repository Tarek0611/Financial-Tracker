namespace Financial_Tracker
{
    partial class Welcome_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGo = new Button();
            label2 = new Label();
            label1 = new Label();
            btnContributers = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(26, 37, 71);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(336, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 398);
            panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top;
            btnGo.BackColor = Color.FromArgb(26, 37, 71);
            btnGo.BackgroundImage = Properties.Resources.next_button;
            btnGo.BackgroundImageLayout = ImageLayout.Zoom;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Location = new Point(206, 271);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(92, 87);
            btnGo.TabIndex = 6;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(26, 37, 71);
            label2.Font = new Font("Impact", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(35, 180);
            label2.Name = "label2";
            label2.Size = new Size(290, 35);
            label2.TabIndex = 4;
            label2.Text = "Your Financial Tracker";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 37, 71);
            label1.Font = new Font("Impact", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(442, 98);
            label1.TabIndex = 3;
            label1.Text = "Welcome to";
            // 
            // btnContributers
            // 
            btnContributers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnContributers.BackColor = Color.FromArgb(10, 15, 30);
            btnContributers.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContributers.ForeColor = Color.White;
            btnContributers.Location = new Point(31, 599);
            btnContributers.Name = "btnContributers";
            btnContributers.Size = new Size(147, 48);
            btnContributers.TabIndex = 1;
            btnContributers.Text = "Contributors";
            btnContributers.UseVisualStyleBackColor = false;
            btnContributers.Click += btnContributers_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(10, 15, 30);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1070, 30);
            button3.Name = "button3";
            button3.Size = new Size(68, 66);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_04_07_at_4_41_24_PM_removebg_preview;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1081, 12);
            button4.Name = "button4";
            button4.Size = new Size(67, 68);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            // 
            // Welcome_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1175, 659);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnContributers);
            Controls.Add(panel1);
            Name = "Welcome_Page";
            Text = "Welcome Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnGo;
        private Button btnContributers;
        private Button button3;
        private Button button4;
    }
}
