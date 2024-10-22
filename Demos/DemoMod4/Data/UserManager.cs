using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod4.Data
{
    public class UserManager
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\..\\Resources\\res\\Users.txt");

        public static List<User> users = new List<User>();

        public UserManager()
        {
            populateUsers();
        }
        private void populateUsers()
        {
            User user;
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(',');
                int id = int.Parse(parts[0]);
                string email = parts[1];

                user = new User(id, email); // user obj
                users.Add(user); // Add user obj into the users List
            }

        }

        public static List<User> GetUsers() { return users; } // returns users List
    }
}
