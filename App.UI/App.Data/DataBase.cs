using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using Newtonsoft.Json;
using System.IO;

namespace AppData
{
    public class DataBase
    {
        private List<User> users;

        public DataBase()
        {
            users = new List<User>();
            FileStream fs = new FileStream(@"json.txt", FileMode.OpenOrCreate);
            using (StreamReader sw = new StreamReader(fs, Encoding.Default))
            {
                JsonSerializer serializer = new JsonSerializer();
                users = (List<User>)serializer.Deserialize(sw, typeof(List<User>));
            }
            if(users == null)
            {
                users = new List<User>();
            }
        }

        public void SaveUser(User user)
        {
            users.Add(user);

            JsonSerializer serializer = new JsonSerializer();
            FileStream fs = new FileStream(@"json.txt", FileMode.OpenOrCreate);
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Default ))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, users);
            }
           
        }

        public int Count()
        {
            if (users != null)
            {
                return users.Count;
            }
            return 0;
        }

        public bool CheckLogin(string login)
        {
            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user.Login == login)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CheckEmail(string email)
        {
            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user.Email == email)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CheckAutorization(string login, string password)
        {
            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
