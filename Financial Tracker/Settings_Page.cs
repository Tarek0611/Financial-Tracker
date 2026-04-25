using System;
using System.Windows.Forms;

namespace Financial_Tracker
{
    public partial class Settings_Page : Form
    {
        public string Currency;

        public Settings_Page()
        {
            InitializeComponent();
        }

        //  Button to save changes
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                bool changed = false;

                if (!string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    Properties.Settings.Default.Username = txtUsername.Text;
                    
                    changed = true;
                }
                else
                {
                    Properties.Settings.Default.Username = "admin";
                }

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    Properties.Settings.Default.Password = txtPassword.Text;
                    changed = true;
                }
                else
                {
                    Properties.Settings.Default.Password = "1234";
                }

                if (!string.IsNullOrWhiteSpace(cmb_Currency.Text))
                {
                    Properties.Settings.Default.Currency = cmb_Currency.Text;
                    changed = true;
                }
                else
                {
                    Properties.Settings.Default.Currency = "EGP";
                }

                if (!string.IsNullOrWhiteSpace(txtBudgetLimit.Text) &&
                    double.TryParse(txtBudgetLimit.Text, out double budget))
                {
                    Properties.Settings.Default.BudgetLimit = budget;
                    changed = true;
                }

                if (!changed)
                {
                    MessageBox.Show("Nothing to update.");
                    return;
                }

                Properties.Settings.Default.Save();

                MessageBox.Show("Settings saved successfully!");

                new Dashboard().Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error occurred!");
            }
        }


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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Page login = new Login_Page();
            login.Show();
        }
    }
}