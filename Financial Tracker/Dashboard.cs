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


        public Dashboard()
        {
            InitializeComponent();
            RefreshReportsData();
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



        private void RefreshReportsData()
        {
            //Update numbers (income, expenses, balance)
            double income = Properties.Settings.Default.TotalIncome;
            double expenses = Properties.Settings.Default.TotalExpenses;
            double balance = income - expenses;

            // Display values in labels 
            lbl_IncomeValue.Text = income.ToString("N0") + " $";
            lbl_ExpenseValue.Text = expenses.ToString("N0") + " $";
            lbl_BalanceValue.Text = balance.ToString("N0") + " $"; 



            // Update the table
            FinanceLogic.FinanceManager.LoadFromFile();

            // Link the table to List
            if (dgvTransactions != null)
            {
                dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransactions.DataSource = null;
                dgvTransactions.DataSource = FinanceLogic.FinanceManager.Transactions.Select(t => new {
                    Date = t.Date.ToShortDateString(),
                    Amount = t.Amount.ToString("N2"),
                    Type = t.TType.ToString(),
                    Category = t.Category.ToString(),
                    Description = t.Description
                }).ToList();
            }
        }

        //The event that automatically refreshes the screen as soon as you open it or return to it
        private void Show_Reports_Page_Activated(object sender, EventArgs e)
        {
            RefreshReportsData();
        }
        public enum ExpenseType { Food, Transport, Shopping, Entertainment, Health }
        public class Expense
        {
            public string Name { get; set; }
            public double Amount { get; set; }
            public ExpenseType Type { get; set; }
        }
    }
}