using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ManagementSystem
{
    public class Database : IDatabase
    {
        public long Id { get; set; }
        private List<User> users;

        public Database()
        {
            users = new List<User>();
            if (File.Exists("ManagmentSystemDatabase.json"))
            {
                using (FileStream fileStream = new FileStream("ManagmentSystemDatabase.json", FileMode.Open))
                {
                    byte[] bytes = new byte[fileStream.Length];
                    fileStream.Read(bytes, 0, bytes.Length);
                    string str = Encoding.Default.GetString(bytes);
                    if (JsonConvert.DeserializeAnonymousType(str, users) != null)
                    {
                        users = JsonConvert.DeserializeAnonymousType(str, users);
                    }
                }
            }
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream("ManagmentSystemDatabase.json", FileMode.OpenOrCreate))
            {
                string jsonusers = "";
                jsonusers = JsonConvert.SerializeObject(users);
                byte[] bytes = Encoding.Default.GetBytes(jsonusers);
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }
        public void Add(User user)
        {
            this.users.Add(user);
        }
        public void Delete(User user)
        {
            bool isAppear = users.Contains(user);
            int index;
            if (isAppear)
            {
                index = users.IndexOf(user);
                users.RemoveAt(index);
            }
        }
        public User GetUser(long id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }
        public List<User> GetUsers()
        {
            return users;
        }
    }
}