namespace Financial_Tracker
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide current form

            Login_Page login = new Login_Page(); // create instance
            login.Show(); // show it
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnContributers_Click(object sender, EventArgs e)
        {
            Contributors contributors = new Contributors();
            contributors.Show();
            this.Hide();
<<<<<<< HEAD
            Contributors contributor = new Contributors();
            contributors.Show();
        }
    }
=======
>>>>>>> 03a15088de4ea64523fc2c92eb76733b7464c0c2

        }

    }
}

