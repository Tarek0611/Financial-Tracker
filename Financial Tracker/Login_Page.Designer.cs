namespace Financial_Tracker
{
    partial class Login_Page
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
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblErrorLogIn = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Impact", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(25, 214);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(110, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(30, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 28);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(35, 45, 65);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(140, 214);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 27);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 45, 65);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(140, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtUserPassword_TextChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.BackgroundImage = Properties.Resources.enter__1_;
            btnLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(194, 420);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(81, 78);
            btnLogIn.TabIndex = 5;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.ForeColor = Color.White;
            rbFemale.Location = new Point(254, 346);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.ForeColor = Color.White;
            rbMale.Location = new Point(140, 346);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 7;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // lblErrorLogIn
            // 
            lblErrorLogIn.AutoSize = true;
            lblErrorLogIn.ForeColor = Color.White;
            lblErrorLogIn.Location = new Point(478, 522);
            lblErrorLogIn.Name = "lblErrorLogIn";
            lblErrorLogIn.Size = new Size(0, 20);
            lblErrorLogIn.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 37, 71);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(302, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 521);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(173, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1175, 659);
            Controls.Add(lblErrorLogIn);
            Controls.Add(panel1);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogIn;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblErrorLogIn;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}