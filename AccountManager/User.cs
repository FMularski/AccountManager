using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class User
    {
        public int Id;
        public string Login;
        public string Email;
        public string Password;
        public string Pin;

        public User(string login, string email, string password, string pin)
        {
            Id = 0;
            Login = login;
            Email = email;
            Password = password;
            Pin = pin;
        }
    }
}
