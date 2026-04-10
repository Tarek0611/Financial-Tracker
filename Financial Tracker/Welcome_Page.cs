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
<<<<<<< HEAD
            Contributors contributors = new Contributors();
            contributors.Show();
            this.Hide();
=======


            Contributors contributors = new Contributors();
            contributors.Show();
>>>>>>> a2a312b8762e4a8f98cb3e1c4438b41c1fd5fa5e
        }
    }

}

