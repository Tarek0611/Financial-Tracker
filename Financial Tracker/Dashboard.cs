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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings_Page settings = new Settings_Page();
            settings.Show();
            this.Hide();

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Settings_Page setting_Page = new Settings_Page();
            setting_Page.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Settings_Page setting_Page = new Settings_Page();
            setting_Page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Expenses_Page expenses_ = new Expenses_Page();
            expenses_.Show();
            this.Hide();
        }
    }

}
