using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class UserManager
    {
        static public List<User> users = new List<User>();

        static public void Registration(string login, string password, string name, string email)
        {
            User user = new User(login, password, name, email);

            users.Add(user);
        }

        static public bool IsUserExist(string login)
        {
            return users.Any(x => x.Login == login);
        }

        static public bool IsUserLogin(string login, string password)
        { 
            //for (int i = 0; i < users.Count; i++) 
            //{
            //    if (users[i].Login == login && users[i].Password == password)
            //    {
            //        return true;
            //    }
            //}

            //return false;

            return users.Any(x => x.Login == login && x.Password == password);
        }

    }
}
