namespace Financial_Tracker
{
    partial class Expenses_Page
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses_Page));
            panel8 = new Panel();
            tblExopenses = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label1 = new Label();
            lblmoney = new Label();
            lblExpen = new Label();
            btnGo = new Button();
            panel2 = new Panel();
            label3 = new Label();
            welcome_label = new Label();
            panel1 = new Panel();
            panel7 = new Panel();
            button4 = new Button();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblExopenses).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(10, 15, 30);
            panel8.Controls.Add(tblExopenses);
            panel8.Controls.Add(panel3);
            panel8.Controls.Add(btnGo);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(220, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(955, 534);
            panel8.TabIndex = 5;
            // 
            // tblExopenses
            // 
            tblExopenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblExopenses.BackgroundColor = Color.FromArgb(35, 45, 63);
            tblExopenses.BorderStyle = BorderStyle.None;
            tblExopenses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 106, 135);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblExopenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblExopenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblExopenses.Columns.AddRange(new DataGridViewColumn[] { colDate, colDescription, colAmount, colAction });
            tblExopenses.EnableHeadersVisualStyles = false;
            tblExopenses.Location = new Point(25, 120);
            tblExopenses.Name = "tblExopenses";
            tblExopenses.RowHeadersVisible = false;
            tblExopenses.RowHeadersWidth = 51;
            tblExopenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblExopenses.Size = new Size(901, 289);
            tblExopenses.TabIndex = 1;
            tblExopenses.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            // 
            // colAction
            // 
            colAction.HeaderText = "Action";
            colAction.MinimumWidth = 6;
            colAction.Name = "colAction";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 45, 63);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblmoney);
            panel3.Controls.Add(lblExpen);
            panel3.Location = new Point(333, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 98);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(35, 41);
            label1.TabIndex = 1;
            label1.Text = "$";
            label1.Click += label1_Click;
            // 
            // lblmoney
            // 
            lblmoney.AutoSize = true;
            lblmoney.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmoney.ForeColor = Color.Gainsboro;
            lblmoney.Location = new Point(39, 40);
            lblmoney.Name = "lblmoney";
            lblmoney.Size = new Size(170, 41);
            lblmoney.TabIndex = 2;
            lblmoney.Text = "17,757,278";
            // 
            // lblExpen
            // 
            lblExpen.AutoSize = true;
            lblExpen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpen.ForeColor = Color.DarkGray;
            lblExpen.Location = new Point(15, 12);
            lblExpen.Name = "lblExpen";
            lblExpen.Size = new Size(174, 28);
            lblExpen.TabIndex = 0;
            lblExpen.Text = "TOTAL EXPENSES";
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(10, 15, 30);
            btnGo.BackgroundImage = (Image)resources.GetObject("btnGo.BackgroundImage");
            btnGo.BackgroundImageLayout = ImageLayout.Zoom;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Location = new Point(833, 415);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(122, 119);
            btnGo.TabIndex = 7;
            btnGo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 45, 65);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(welcome_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 125);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(62, 83);
            label3.Name = "label3";
            label3.Size = new Size(224, 22);
            label3.TabIndex = 1;
            label3.Text = "Enjoy managing your finances";
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_label.ForeColor = Color.White;
            welcome_label.Location = new Point(35, 12);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(308, 54);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "Welcome back,";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 55);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 659);
            panel1.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(35, 45, 63);
            panel7.Controls.Add(button4);
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(0, 581);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 45);
            panel7.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 45, 63);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(47, 0);
            button4.Name = "button4";
            button4.Size = new Size(103, 45);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.logout;
            pictureBox5.Location = new Point(3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 45, 63);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(0, 343);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 60);
            panel6.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 45, 63);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(65, 3);
            button3.Name = "button3";
            button3.Size = new Size(151, 55);
            button3.TabIndex = 6;
            button3.Text = "Settings";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.cogwheel;
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 45, 63);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 264);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 60);
            panel5.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 45, 63);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(65, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 55);
            button2.TabIndex = 6;
            button2.Text = "Expenses";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.budget;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 45, 63);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 170);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 60);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 45, 63);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(63, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 55);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dashboard__1_;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Expenses_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 659);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Expenses_Page";
            Text = "Expenses_Page";
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblExopenses).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Panel panel3;
        private Label label1;
        private Label lblExpen;
        private Panel panel2;
        private Label label3;
        private Label welcome_label;
        private Panel panel1;
        private Panel panel7;
        private Button button4;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Button button3;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Button button2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblmoney;
        private DataGridView tblExopenses;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colAction;
        private Button btnGo;
    }
}