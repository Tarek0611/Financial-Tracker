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
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 1. بنعمل نسخة (Object) من الفورم اللي عايزين نفتحها
            AddIncome frm = new AddIncome();

            // 2. بنعرض الفورم كـ Popup فوق الداشبورد
            frm.ShowDialog();

        }
    }
    
}
