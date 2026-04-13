using BAMS.Forms;
using BAMS.Repositories;


namespace BAMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminRepository repo = new AdminRepository();

            int adminId = repo.GetAdminId(txtUsername.Text, txtPassword.Text);

            if (adminId > 0)
            {
                DashboardForm dashboard = new DashboardForm();

                dashboard.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Admin Credentials");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
