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
    public partial class Settings_Page : Form
    {
        public Settings_Page()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            Expenses_Page expenses_ = new Expenses_Page();
            expenses_.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
=======
        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailProfile_Click(object sender, EventArgs e)
        {

>>>>>>> 7ad76a054d4e6892810515350360dd5890e32e64
        }
    }
}
