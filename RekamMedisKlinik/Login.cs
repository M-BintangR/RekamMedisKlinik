using RekamMedisKlinik.Model;
using RekamMedisKlinik.Session;
using RekamMedisKlinik;

public class Login
{
    private string email;
    private string password;
    private readonly Connection connection;

    public Login(string email, string password)
    {
        this.email = email;
        this.password = password;
        this.connection = new Connection();
    }

    public bool VerifyLogin()
    {
        try
        {
            string query = "SELECT id, email, username, role FROM users WHERE email = @Email AND password = @Password";

            var parameters = new Dictionary<string, object>
            {
                { "Email", this.email },
                { "Password", this.password }
            };

            // Menggunakan ExecuteQuery untuk mendapatkan data pengguna
            var userData = connection.ExecuteQuery(query, parameters);

            if (userData != null && userData.Count > 0)
            {
                // Ambil data pengguna pertama dari hasil query
                var userRow = userData[0]; // Mengambil baris pertama hasil query

                // Membuat objek Users dan menyimpannya ke dalam UserSession
                UserSessions.CurrentUser = new Users(
                    Convert.ToInt32(userRow["id"]),
                    userRow["email"].ToString(),
                    userRow["username"].ToString(),
                    userRow["role"].ToString()
                );

                return true;
            }
            else
            {
                MessageBox.Show("Email atau password salah!", "Login Gagal");
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Terjadi kesalahan saat login.", "Error");
            Console.WriteLine($"Error: {ex.Message}");
            return false;
        }
    }
}
