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
            string query = "SELECT id_user, email, username, avatar, role FROM users WHERE email = @Email AND password = @Password";

            var parameters = new Dictionary<string, object>
            {
                { "Email", this.email },
                { "Password", this.password }
            };

            // get data users with method ExecuteQuery using Connection class
            var userData = connection.ExecuteQuery(query, parameters);

            if (userData != null && userData.Count > 0)
            {
                // get first data
                var userRow = userData[0];

                // create session object on users sessions
                UserSessions.CurrentUser = new Users(
                    Convert.ToInt32(userRow["id_user"]),
                    userRow["email"].ToString() ?? "",
                    userRow["username"].ToString() ?? "",
                    userRow["role"].ToString() ?? "",
                    userRow["avatar"].ToString() ?? ""
                );

                return true;
            }
            else
            {
                MessageBox.Show("Email atau password salah!", "Login Gagal");
                return false;
            }
        }
        catch (Exception err)
        {
            MessageBox.Show($"Terjadi kesalahan saat login : {err.Message}", "Error");
            Console.WriteLine($"Error: {err.Message}");
            return false;
        }
    }
}
