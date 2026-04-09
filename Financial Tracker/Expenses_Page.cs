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
    public partial class Expenses_Page : Form
    {
        public Expenses_Page()
        {
            InitializeComponent();

            //Head coloring
            tblExopenses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
            tblExopenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tblExopenses.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 37, 41); // عشان ميتغيرش لما تضغط عليه

            // Background coloring
            tblExopenses.BackgroundColor = Color.FromArgb(26, 28, 30);
            tblExopenses.DefaultCellStyle.BackColor = Color.FromArgb(26, 28, 30);
            tblExopenses.DefaultCellStyle.ForeColor = Color.White;
            tblExopenses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 100);


            tblExopenses.DefaultCellStyle.SelectionForeColor = Color.White; ;
            tblExopenses.DefaultCellStyle.SelectionForeColor = Color.White;

        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings_Page setting_Page = new Settings_Page();
            setting_Page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
