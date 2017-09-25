using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementSystem
{
    public class User
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public long Wage { get; set; }
        public DateTime Birthday { get; set; }
        public int AccessModifier { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public List<TaskBase> CurrentTasks { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }
        public User()
        {
            Id = 147851475;
            FullName = "Admin";
            AccessModifier = 5;
            Login = "admin";
            Password = "qwerty123";
            Category = "Admin";
        }
    }
}
