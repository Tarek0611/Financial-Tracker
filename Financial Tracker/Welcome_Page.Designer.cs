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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnContributers = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 37, 71);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(336, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 548);
            panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(26, 37, 71);
            btnGo.BackgroundImage = Properties.Resources.next_button;
            btnGo.BackgroundImageLayout = ImageLayout.Zoom;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Location = new Point(208, 415);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(92, 87);
            btnGo.TabIndex = 6;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(26, 37, 71);
            label2.Font = new Font("Impact", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(34, 292);
            label2.Name = "label2";
            label2.Size = new Size(446, 54);
            label2.TabIndex = 4;
            label2.Text = "Your Financial Tracker";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(26, 37, 71);
            label1.Font = new Font("Impact", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(132, 247);
            label1.Name = "label1";
            label1.Size = new Size(245, 54);
            label1.TabIndex = 3;
            label1.Text = "Welcome to";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.expense;
            pictureBox3.Location = new Point(258, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money;
            pictureBox2.Location = new Point(156, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.welcome;
            pictureBox1.Location = new Point(189, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnContributers
            // 
            btnContributers.BackColor = Color.FromArgb(10, 15, 30);
            btnContributers.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContributers.ForeColor = Color.White;
            btnContributers.Location = new Point(31, 599);
            btnContributers.Name = "btnContributers";
            btnContributers.Size = new Size(147, 48);
            btnContributers.TabIndex = 1;
            btnContributers.Text = "Contributers";
            btnContributers.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
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
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_04_07_at_4_41_24_PM_removebg_preview;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(1106, 12);
            button4.Name = "button4";
            button4.Size = new Size(42, 37);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Button btnGo;
        private Button btnContributers;
        private Button button3;
        private Button button4;
    }
}
