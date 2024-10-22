using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod4.Data
{
    public class User
    {
        int id;
        string email;

        public User() { }
        public User(int id, string email)
        {
            this.Id = id;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
    }
}
