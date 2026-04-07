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
            pictureBox1 = new PictureBox();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            lblErrorLogIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_ejfl4dejfl4dejfl_removebg_preview;
            pictureBox1.Location = new Point(450, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(262, 252);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(121, 31);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(262, 325);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(35, 45, 65);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(450, 257);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 27);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 45, 65);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(450, 325);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(35, 45, 65);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(519, 467);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(83, 38);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "LogIn";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.ForeColor = Color.White;
            rbFemale.Location = new Point(413, 393);
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
            rbMale.Location = new Point(270, 393);
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
            lblErrorLogIn.Location = new Point(519, 525);
            lblErrorLogIn.Name = "lblErrorLogIn";
            lblErrorLogIn.Size = new Size(0, 20);
            lblErrorLogIn.TabIndex = 8;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1131, 591);
            Controls.Add(lblErrorLogIn);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(pictureBox1);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogIn;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label lblErrorLogIn;
    }
}