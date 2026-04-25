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
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // We pull data from NextBox 
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            //  Data verification
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Hello, you are logged in");

                //  Open the Dashboard and hide the login page
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error in name or password. Try again!");

                // Cleaning the cells
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}