using System;
using System.Windows.Forms;

namespace Financial_Tracker
{
    public partial class Settings_Page : Form
    {
        
        public static string UserName = "";
        public static string UserEmail = "";
        public static double BudgetLimit = 0;
        public static string Currency = "EGP";

        public Settings_Page()
        {
            InitializeComponent();
        }

        //  Button to save changes
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserProfile.Text == "" || txt_Email.Text == "")
                {
                    MessageBox.Show("Please fill out all the information");
                    return;
                }

                UserName = txtUserProfile.Text;
                UserEmail = txt_Email.Text;

                double.TryParse(txtBudgetProfile.Text, out BudgetLimit);

                if (cmb_Currency.SelectedItem != null)
                    Currency = cmb_Currency.SelectedItem.ToString();
                else
                    Currency = "EGP";

                MessageBox.Show("Settings saved successfully!");

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred!");
            }
        }

        //  Budget warning function
        public static void CheckBudget(double totalSpent)
        {
            if (BudgetLimit > 0 && totalSpent > BudgetLimit)
            {
                MessageBox.Show(
                    $"⚠️ Over budget ({BudgetLimit} {Currency})\nTotal expenses: {totalSpent}",
                    "warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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