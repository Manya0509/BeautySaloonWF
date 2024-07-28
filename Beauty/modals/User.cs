using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string login, string password, string name, string email) 
        { 
            Login = login;
            Password = password;
            Name = name;
            Email = email;
        }
    }
}
