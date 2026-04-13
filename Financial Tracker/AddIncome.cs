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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }



        private void AddIncome_Load(object sender, EventArgs e)
        {
            // اكتب هنا الكود اللي عايزه يتنفذ لما الشاشة تفتح
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
                if (!decimal.TryParse(txtAmount.Text, out decimal amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount!");
                    return;
                }

                // عمل Object من نوع Income
                var newIncome = new FinanceLogic.Income()
                {
                    Amount = amountValue,
                    Date = dtpDate.Value,
                    Category = (FinanceLogic.Category)cmbCategory.SelectedIndex,
                    Description = txtDescription.Text
                };

                // الحفظ
                FinanceLogic.FinanceManager.AddTransaction(newIncome);
                FinanceLogic.FinanceManager.SaveToFile();

                MessageBox.Show("Income added successfully! 💰");

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
