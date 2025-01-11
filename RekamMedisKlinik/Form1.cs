using RekamMedisKlinik.Properties;
using RekamMedisKlinik.Session;

namespace RekamMedisKlinik
{
    public partial class FormLogin : Form
    {
        private string email;
        private string password;
        public FormLogin()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            // exti application
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // check session is clear or not
            if (UserSessions.CurrentUser != null)
            {
                new FormMenu().Show();
                this.Hide();
                return;
            }
            else
            {
                // validation not empty email or password
                if (string.IsNullOrWhiteSpace(this.email) || string.IsNullOrWhiteSpace(this.password))
                {
                    MessageBox.Show("Email dan password harus diisi!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // instance login class
                Login login = new Login(this.email, this.password);

                // verify login access
                if (login.VerifyLogin())
                {
                    new FormMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chcBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.chcBoxShowPassword.Checked;
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }
    }
}
