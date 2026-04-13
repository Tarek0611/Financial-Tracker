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
            //  نسحب البيانات من التكست بوكس  
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            //  التحقق من البيانات
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("أهلاً بك! جاري الدخول...");

                // 3. فتح الـ Dashboard وإخفاء صفحة الدخول
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                // 4. في حالة الخطأ
                MessageBox.Show("خطأ في الاسم أو كلمة السر.. حاول تاني!");

                // تنظيف الخانات للتحضير لمحاولة جديدة
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus(); // وضع المؤشر في خانة الاسم
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}