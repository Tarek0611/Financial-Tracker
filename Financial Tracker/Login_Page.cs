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


            Color myDefaultColor = Color.FromArgb(35, 45, 65);
            Color errorColor = Color.FromArgb(120, 40, 40);

            txtUserName.BackColor = myDefaultColor;
            txtPassword.BackColor = myDefaultColor;
            lblErrorLogIn.Visible = false;

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.BackColor = errorColor;
                lblErrorLogIn.Text = "Please enter your new username";
                lblErrorLogIn.Visible = true;
                txtUserName.Focus();
                return;
            }

            // Verify that the user wrote the password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.BackColor = errorColor;
                lblErrorLogIn.Text = "Please set a password";
                lblErrorLogIn.Visible = true;
                txtPassword.Focus();
                return;
            }

            //  Check the type selection (if you want Basic)
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                lblErrorLogIn.Text = "Please select gender (male/female)";
                lblErrorLogIn.Visible = true;
                return;
            }

            // 
            string gender = rbMale.Checked ? "Male" : "Female";

            // Show a welcome message with the name he entered
            MessageBox.Show($"Welcome {txtUserName.Text}!\nYour account has been created and logged in successfully.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //  Go to Dashboard
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }




        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

            txtUserName.BackColor = Color.FromArgb(35, 45, 65);
        }
        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

            txtPassword.BackColor = Color.FromArgb(35, 45, 65);
        }

    }

}
