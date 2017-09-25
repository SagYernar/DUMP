using System.Collections.Generic;

namespace ManagementSystem
{
    public interface IDatabase
    {
        void Save();
        void Delete(User user);
        void Add(User user);

        User GetUser(long id);
        List<User> GetUsers();
    }
}