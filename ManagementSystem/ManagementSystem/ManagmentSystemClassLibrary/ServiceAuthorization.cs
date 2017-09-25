using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class ServiceAuthorization : Service
    {
        public User admin = new User();

        public bool AuthorityVerify(string login, string password)
        {
            Database.Add(admin);
            foreach (var user in Database.GetUsers())
            {
                if (user.Login == login && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
