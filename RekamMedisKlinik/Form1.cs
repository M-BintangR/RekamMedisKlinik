namespace RekamMedisKlinik
{
    public partial class frmLogin : Form
    {
        private string email;
        private string password;
        public frmLogin()
        {
            InitializeComponent();
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (this.password == "adminadmin" && this.email == "admin@gmail.com")
            {
                new FormMenu().Show();
                this.Hide();
            }
            else
            {
                // Menampilkan pesan error
                MessageBox.Show("Email atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chcBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
