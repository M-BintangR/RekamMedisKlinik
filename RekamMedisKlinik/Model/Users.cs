using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekamMedisKlinik.Model
{
    internal class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public Users(int id, string email, string username, string role)
        {
            Id = id;
            Email = email;
            Username = username;
            Role = role;
        }
    }
}
