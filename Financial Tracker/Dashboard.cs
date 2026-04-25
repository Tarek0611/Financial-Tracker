using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Financial_Tracker
{
    public partial class Dashboard : Form
    {

        double income = 5000;
        double totalExpenses = 180;

        public Dashboard()
        {
            InitializeComponent();            
            // Call accounts
            CalculateFinancials();
        }

        private void CalculateFinancials()
        {
            Settings_Page.CheckBudget(totalExpenses);
        }



        private void button5_Click(object sender, EventArgs e) // Balance button
        {
            double balance = income - totalExpenses;
            MessageBox.Show("Your total balance is: " + balance + " EGP", "Financial Summary");
        }

        private void button6_Click(object sender, EventArgs e) // Income button
        {
            MessageBox.Show("Total Income: " + income + " EGP", "Income Details");
        }

        private void button7_Click(object sender, EventArgs e) // Expenses button
        {
            MessageBox.Show("Total Expenses: " + totalExpenses + " EGP", "Expense Details");
        }


        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Settings_Page settings = new Settings_Page();
            settings.Show();
            this.Hide();
        }


        private void btn_Expenses_Click(object sender, EventArgs e)
        {
            Expenses_Page expenses_ = new Expenses_Page();
            expenses_.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Page login = new Login_Page();
            login.Show();
        }

        private void btn_ShowTotalExpenses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Expenses is 180 EGP", "Expense Details");
        }

        private void btn_ShowTotalBalance_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Your Total Balance is: 4,820 EGP", "Financial Summary");
            }
        }

        private void btn_ShowTotalIncome_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Your Total Income is: 5,000 EGP", "Financial Summary");
            }
        }
    }



    public enum ExpenseType { Food, Transport, Shopping, Entertainment, Health }
    public class Expense
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public ExpenseType Type { get; set; }
    }
}