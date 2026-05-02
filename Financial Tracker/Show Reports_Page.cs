using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Financial_Tracker.FinanceLogic;
namespace Financial_Tracker
{
    public partial class Show_Reports_Page : Form
    {
        public Show_Reports_Page()
        {
            InitializeComponent();
            RefreshReportsData();
            tblShowReports.BackgroundColor = Color.FromArgb(45, 45, 48);
            tblShowReports.BorderStyle = BorderStyle.None;
            tblShowReports.EnableHeadersVisualStyles = false;


            tblShowReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            tblShowReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tblShowReports.ColumnHeadersHeight = 40;


            tblShowReports.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            tblShowReports.DefaultCellStyle.ForeColor = Color.White;
            tblShowReports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 63, 70);
            tblShowReports.RowHeadersVisible = false;
            tblShowReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Page login = new Login_Page();
            login.Show();
        }

        private void Show_Reports_Page_Load(object sender, EventArgs e)
        {
            FinanceManager.LoadFromFile();
            RefreshReportsData();
        }
        private void RefreshReportsData()
        {
            // 1. Update numbers
            double income = Properties.Settings.Default.TotalIncome;
            double expenses = Properties.Settings.Default.TotalExpenses;
            double balance = income - expenses;


            // 2. Display values 
            string currency = Properties.Settings.Default.Currency;
            lblincomereport.Text = income.ToString("N0") + $" {currency}";
            lblexpensesreport.Text = expenses.ToString("N0") + $" {currency}";
            lblbalancereport.Text = balance.ToString("N0") + $" {currency}";

            // 4. Link the table
            if (tblShowReports != null)
            {
                tblShowReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tblShowReports.DataSource = null;
                tblShowReports.DataSource = FinanceLogic.FinanceManager.Transactions.Select(t => new
                {
                    Date = t.Date.ToShortDateString(),
                    Amount = t.Amount.ToString("N2"),
                    Type = t.TType.ToString(),
                    Category = t.Category.ToString(),
                    Description = t.Description
                }).ToArray();
            }
        }
        
    }
}
