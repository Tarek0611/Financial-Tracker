using Microsoft.VisualBasic;
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
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                // Verify the inputs
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in the amount and select a category! ⚠️", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtAmount.Text, out double amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount!");
                    return;
                }

                // Calculate the current balance
                double currentBalance = Properties.Settings.Default.TotalIncome - Properties.Settings.Default.TotalExpenses;

                // The first condition: If the balance will be completely exhausted (preventing the transaction)
                if (currentBalance - amountValue < 0)
                {
                    MessageBox.Show("Transaction failed! Your balance is 0. You cannot spend more! ⛔", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                // The second condition: If the balance falls below 3000 (warning only)
                if (currentBalance - amountValue < 3000)
                {
                    MessageBox.Show("Warning: Your balance is dropping below 3000 EGP! ⚠️", "Low Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }

                var newExpense = new FinanceLogic.Expense()
                {
                    Amount = amountValue,
                    Date = dtpDate.Value,
                    Category = (FinanceLogic.Category)cmbCategory.SelectedIndex,
                    Description = txtDescription.Text
                };

                // Update settings and save the file
                Properties.Settings.Default.TotalExpenses += amountValue;
                Properties.Settings.Default.Save();

                FinanceManager.AddTransaction(newExpense);
                FinanceManager.SaveToFile();

                MessageBox.Show("Expense added successfully! ✅");

                txtAmount.Clear();
                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDiscardProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
