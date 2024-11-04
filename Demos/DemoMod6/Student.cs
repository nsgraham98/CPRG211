using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    [Serializable] // Step 1: IMPORTANT -> needed to convert Class into bytes
    public class Student
    {
        string name;
        string address;
        string email;
        [NonSerialized] // password will not be serialized (and not stored in .bin file)
        string password;
        double gpa;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public double Gpa { get => gpa; set => gpa = value; }

        public override string ToString()
        {
            return $"\nName: {name}\nAddress: {address}\nEmail: {email}\nPassword: {password}\nGPA: {gpa}";
        }
    }
}
