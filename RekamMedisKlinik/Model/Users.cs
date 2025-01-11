using System.Security.Cryptography;
using System.Text;

namespace RekamMedisKlinik.Model
{
    internal class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public string Avatar { get; set; }

        private string fileDestination =  @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";

        public Users(int id, string email, string username, string role, string avatar = null)
        {
            this.Id = id;
            this.Email = email;
            this.Username = username;
            this.Role = role;
            this.Avatar = avatar;
        }

        // method get gravatar url
        public string Gravatar()
        {
            if (string.IsNullOrEmpty(this.Avatar))
            {
                return GetGravatarUrl(this.Email);
            }

            return "";
         
        }

        public string AvatarUrl()
        {
            if (!string.IsNullOrEmpty(this.Avatar))
            {
                return this.fileDestination + this.Avatar;
            }

            return "";
        }

        // gravatar method
        private string GetGravatarUrl(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "https://www.gravatar.com/avatar/default";
            }

            string cleanEmail = email.Trim().ToLower();
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(cleanEmail));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));  // Menghasilkan hash MD5
                }
                return $"https://www.gravatar.com/avatar/{sb.ToString()}?s=1024"; // Gambar Gravatar ukuran 1024px
            }
        }
    }
}
