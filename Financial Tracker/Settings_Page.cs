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

        //  زرار الحفظ 
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserProfile.Text == "" || txt_Email.Text == "")
                {
                    MessageBox.Show("من فضلك املأ كل البيانات");
                    return;
                }

                UserName = txtUserProfile.Text;
                UserEmail = txt_Email.Text;

                double.TryParse(txtBudgetProfile.Text, out BudgetLimit);

                if (cmb_Currency.SelectedItem != null)
                    Currency = cmb_Currency.SelectedItem.ToString();
                else
                    Currency = "EGP";

                MessageBox.Show("تم حفظ الإعدادات بنجاح!");

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("حصل خطأ!");
            }
        }

        //  دالة تحذير الميزانية
        public static void CheckBudget(double totalSpent)
        {
            if (BudgetLimit > 0 && totalSpent > BudgetLimit)
            {
                MessageBox.Show(
                    $"⚠️ تخطيت الميزانية ({BudgetLimit} {Currency})\nإجمالي المصاريف: {totalSpent}",
                    "تحذير",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

       

        private void panel8_Paint(object sender, PaintEventArgs e) { }

        private void lblCurrency_Click(object sender, EventArgs e) { }

        private void lblEmailProfile_Click(object sender, EventArgs e) { }

        private void txtUserProfile_TextChanged(object sender, EventArgs e) { }

        private void txt_Email_TextChanged(object sender, EventArgs e) { }

        private void cmb_Currency_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtBudgetProfile_TextChanged(object sender, EventArgs e) { }

        
        // التنقل بين الصفحات )
        

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