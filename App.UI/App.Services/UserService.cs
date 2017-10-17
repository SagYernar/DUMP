using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using AppData;

namespace AppServices
{
    public class UserService
    {
        DataBase dataBase;

        public UserService()
        {
            dataBase = new DataBase();
        }
        public void AddUser(User user)
        {
            dataBase.SaveUser(user);
        }

        public bool CheckLogin(string login)
        {
            if (dataBase.CheckLogin(login))
            {
                return true;
            }
            return false;
        }

        public bool CheckEmail(string email)
        {
            if (dataBase.CheckEmail(email))
            {
                return true;
            }
            return false;
        }

        public bool CheckAutorization(string login, string password)
        {
            if (dataBase.CheckAutorization(login, password))
            {
                return true;
            }
            return false;
        }
    }
}
