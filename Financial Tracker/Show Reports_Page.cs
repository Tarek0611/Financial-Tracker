using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Tracker
{
    public partial class Show_Reports_Page : Form
    {
        public Show_Reports_Page()
        {
            InitializeComponent();
            tblShowReports.BackgroundColor = Color.FromArgb(45, 45, 48);
            tblShowReports.BorderStyle = BorderStyle.None;
            tblShowReports.EnableHeadersVisualStyles = false;


            tblShowReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            tblShowReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tblShowReports.ColumnHeadersHeight = 40;


            tblShowReports.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            tblShowReports.DefaultCellStyle.ForeColor = Color.White;
            tblShowReports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 63, 70);
            tblShowReports.RowHeadersVisible = false;
            tblShowReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Page login = new Login_Page();
            login.Show();
        }
    }
}
