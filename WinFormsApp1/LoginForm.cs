namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(logintextBox.Text =="Ketan"&&passwordtextBox.Text=="Ketan123")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}