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
            Color myDefaultColor = Color.FromArgb(35, 45, 65);
            Color errorColor = Color.FromArgb(120, 40, 40);

            txtUserName.BackColor = myDefaultColor;
            txtPassword.BackColor = myDefaultColor;
            lblErrorLogIn.Visible = false;

            //  Verify username
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.BackColor = errorColor;
                lblErrorLogIn.Text = "⚠️ اسم المستخدم مطلوب!";
                lblErrorLogIn.ForeColor = Color.Tomato;
                lblErrorLogIn.Visible = true;
                txtUserName.Focus();
                return;
            }

            //  Password verification
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = errorColor;
                lblErrorLogIn.Text = "⚠️ كلمة المرور مطلوبة!";
                lblErrorLogIn.ForeColor = Color.Tomato;
                lblErrorLogIn.Visible = true;
                txtPassword.Focus();
                return;
            }


            if (txtUserName.Text == "Mohamed" && txtPassword.Text == "123")
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Go to the next form 
            }
            else
            {
                lblErrorLogIn.Text = "❌ البيانات غير صحيحة!";
                lblErrorLogIn.Visible = true;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
            txtUserName.BackColor = Color.FromArgb(35, 45, 65);
        }
    }
    }
}
