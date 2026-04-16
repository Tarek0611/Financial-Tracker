namespace Financial_Tracker
{
    partial class Show_Reports_Page
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            panel9 = new Panel();
            tblShowReports = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            label1 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel16 = new Panel();
            panel17 = new Panel();
            pictureBox7 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panel18 = new Panel();
            label19 = new Label();
            panel11 = new Panel();
            panel8 = new Panel();
            tblReport = new DataGridView();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            panel13 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            lblTotalExpenses = new Label();
            lblTotalIncome = new Label();
            panel15 = new Panel();
            panel14 = new Panel();
            pictureBox10 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox9 = new PictureBox();
            label2 = new Label();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblShowReports).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel18.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblReport).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel11);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(823, 562);
            panel3.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(10, 15, 30);
            panel9.Controls.Add(tblShowReports);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel18);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(823, 562);
            panel9.TabIndex = 6;
            panel9.Paint += panel9_Paint;
            // 
            // tblShowReports
            // 
            tblShowReports.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblShowReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblShowReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblShowReports.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            tblShowReports.EnableHeadersVisualStyles = false;
            tblShowReports.GridColor = Color.FromArgb(64, 64, 64);
            tblShowReports.Location = new Point(3, 186);
            tblShowReports.Margin = new Padding(3, 2, 3, 2);
            tblShowReports.Name = "tblShowReports";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblShowReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblShowReports.RowHeadersVisible = false;
            tblShowReports.RowHeadersWidth = 100;
            tblShowReports.Size = new Size(796, 509);
            tblShowReports.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Amount";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 225;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Desription";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Date";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Action";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 225;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(189, 215, 238);
            panel10.Controls.Add(label1);
            panel10.Controls.Add(label11);
            panel10.Controls.Add(label12);
            panel10.Controls.Add(label13);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(label15);
            panel10.Controls.Add(panel16);
            panel10.Controls.Add(panel17);
            panel10.Controls.Add(pictureBox7);
            panel10.Controls.Add(label16);
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label18);
            panel10.Location = new Point(11, 8);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(788, 321);
            panel10.TabIndex = 3;
            panel10.Paint += panel10_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 15, 30);
            label1.Location = new Point(317, 77);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 11;
            label1.Text = "$";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(10, 15, 30);
            label11.Location = new Point(317, 114);
            label11.Name = "label11";
            label11.Size = new Size(23, 25);
            label11.TabIndex = 10;
            label11.Text = "$";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(10, 15, 30);
            label12.Location = new Point(317, 24);
            label12.Name = "label12";
            label12.Size = new Size(23, 25);
            label12.TabIndex = 9;
            label12.Text = "$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(10, 15, 30);
            label13.Location = new Point(338, 113);
            label13.Name = "label13";
            label13.Size = new Size(110, 25);
            label13.TabIndex = 8;
            label13.Text = "123,154,22";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(10, 15, 30);
            label14.Location = new Point(338, 77);
            label14.Name = "label14";
            label14.Size = new Size(110, 25);
            label14.TabIndex = 7;
            label14.Text = "123,512,15";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(10, 15, 30);
            label15.Location = new Point(338, 23);
            label15.Name = "label15";
            label15.Size = new Size(110, 25);
            label15.TabIndex = 6;
            label15.Text = "564,216,25";
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Location = new Point(46, 103);
            panel16.Margin = new Padding(3, 2, 3, 2);
            panel16.Name = "panel16";
            panel16.Size = new Size(435, 2);
            panel16.TabIndex = 5;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Location = new Point(46, 50);
            panel17.Margin = new Padding(3, 2, 3, 2);
            panel17.Name = "panel17";
            panel17.Size = new Size(430, 2);
            panel17.TabIndex = 4;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Screenshot_2026_04_10_153210;
            pictureBox7.Location = new Point(528, 10);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(204, 164);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(10, 15, 30);
            label16.Location = new Point(46, 114);
            label16.Name = "label16";
            label16.Size = new Size(117, 25);
            label16.TabIndex = 2;
            label16.Text = "Net Balance";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(10, 15, 30);
            label17.Location = new Point(46, 69);
            label17.Name = "label17";
            label17.Size = new Size(141, 25);
            label17.TabIndex = 1;
            label17.Text = "Total Expenses";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(10, 15, 30);
            label18.Location = new Point(46, 21);
            label18.Name = "label18";
            label18.Size = new Size(126, 25);
            label18.TabIndex = 0;
            label18.Text = "Total Income";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel18.BackColor = Color.FromArgb(35, 45, 63);
            panel18.Controls.Add(label19);
            panel18.Cursor = Cursors.Hand;
            panel18.Location = new Point(3032, 22);
            panel18.Margin = new Padding(3, 2, 3, 2);
            panel18.Name = "panel18";
            panel18.Size = new Size(276, 74);
            panel18.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.AppWorkspace;
            label19.Location = new Point(74, 11);
            label19.Name = "label19";
            label19.Size = new Size(138, 21);
            label19.TabIndex = 0;
            label19.Text = "TOTAL EXPENSES";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel11.BackColor = Color.FromArgb(35, 45, 63);
            panel11.Controls.Add(panel8);
            panel11.Controls.Add(pictureBox9);
            panel11.Controls.Add(label2);
            panel11.Cursor = Cursors.Hand;
            panel11.Location = new Point(1354, 22);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(276, 74);
            panel11.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(10, 15, 30);
            panel8.Controls.Add(tblReport);
            panel8.Controls.Add(panel13);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(276, 74);
            panel8.TabIndex = 4;
            // 
            // tblReport
            // 
            tblReport.BackgroundColor = Color.FromArgb(64, 64, 64);
            tblReport.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tblReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tblReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblReport.Columns.AddRange(new DataGridViewColumn[] { Amount, Description, Date, Action });
            tblReport.EnableHeadersVisualStyles = false;
            tblReport.GridColor = Color.FromArgb(64, 64, 64);
            tblReport.Location = new Point(70, 208);
            tblReport.Margin = new Padding(3, 2, 3, 2);
            tblReport.Name = "tblReport";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tblReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tblReport.RowHeadersVisible = false;
            tblReport.RowHeadersWidth = 100;
            tblReport.Size = new Size(827, 216);
            tblReport.TabIndex = 4;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Desription";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(189, 215, 238);
            panel13.Controls.Add(label10);
            panel13.Controls.Add(label9);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(lblTotal);
            panel13.Controls.Add(lblTotalExpenses);
            panel13.Controls.Add(lblTotalIncome);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(pictureBox10);
            panel13.Controls.Add(label7);
            panel13.Controls.Add(label6);
            panel13.Controls.Add(label5);
            panel13.Location = new Point(70, 12);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(827, 183);
            panel13.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(10, 15, 30);
            label10.Location = new Point(317, 77);
            label10.Name = "label10";
            label10.Size = new Size(23, 25);
            label10.TabIndex = 11;
            label10.Text = "$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(10, 15, 30);
            label9.Location = new Point(317, 114);
            label9.Name = "label9";
            label9.Size = new Size(23, 25);
            label9.TabIndex = 10;
            label9.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(10, 15, 30);
            label8.Location = new Point(317, 24);
            label8.Name = "label8";
            label8.Size = new Size(23, 25);
            label8.TabIndex = 9;
            label8.Text = "$";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(10, 15, 30);
            lblTotal.Location = new Point(338, 113);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "123,154,22";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpenses.ForeColor = Color.FromArgb(10, 15, 30);
            lblTotalExpenses.Location = new Point(338, 77);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(110, 25);
            lblTotalExpenses.TabIndex = 7;
            lblTotalExpenses.Text = "123,512,15";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.FromArgb(10, 15, 30);
            lblTotalIncome.Location = new Point(338, 23);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(110, 25);
            lblTotalIncome.TabIndex = 6;
            lblTotalIncome.Text = "564,216,25";
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(46, 103);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(435, 2);
            panel15.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Location = new Point(46, 50);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(430, 2);
            panel14.TabIndex = 4;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Screenshot_2026_04_10_153210;
            pictureBox10.Location = new Point(528, 10);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(204, 164);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 3;
            pictureBox10.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(10, 15, 30);
            label7.Location = new Point(46, 114);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 2;
            label7.Text = "Net Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(10, 15, 30);
            label6.Location = new Point(46, 69);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 1;
            label6.Text = "Total Expenses";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(10, 15, 30);
            label5.Location = new Point(46, 21);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Income";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.spending;
            pictureBox9.Location = new Point(15, 11);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(56, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(74, 11);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 0;
            label2.Text = "TOTAL EXPENSES";
            // 
            // Show_Reports_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 562);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Show_Reports_Page";
            Text = "Show_Reports_Page";
            Load += Show_Reports_Page_Load;
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblShowReports).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblReport).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel11;
        private PictureBox pictureBox9;
        private Label label2;
        private Panel panel8;
        private DataGridView tblReport;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Action;
        private Panel panel13;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblTotal;
        private Label lblTotalExpenses;
        private Label lblTotalIncome;
        private Panel panel15;
        private Panel panel14;
        private PictureBox pictureBox10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private DataGridView tblShowReports;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel panel10;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel16;
        private Panel panel17;
        private PictureBox pictureBox7;
        private Label label16;
        private Label label17;
        private Label label18;
        private Panel panel18;
        private Label label19;
    }
}