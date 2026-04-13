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
                // 1. التحقق إن الحقول مش فاضية (لازم يختار من القائمة)
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in the amount and select a category! ⚠️", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // التأكد من المدخلات
                if (!decimal.TryParse(txtAmount.Text, out decimal amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount!");
                    return;
                }

                // عمل Object من نوع Expense (اللي هو ابن للـ Transaction)
                var newExpense = new FinanceLogic.Expense()
                {
                    Amount = amountValue,
                    Date = dtpDate.Value,
                    Category = (FinanceLogic.Category)cmbCategory.SelectedIndex,
                    Description = txtDescription.Text
                };

                // استدعاء الميثودز من الـ FinanceManager
                FinanceLogic.FinanceManager.AddTransaction(newExpense);
                FinanceLogic.FinanceManager.SaveToFile();

                MessageBox.Show("Expense added successfully! ✅");

                // تنظيف الخانات
                txtAmount.Clear();
                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiscardProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
