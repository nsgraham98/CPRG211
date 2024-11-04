using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class DriverSerialization
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "John";
            s1.Address = "123 Street";
            s1.Email = "email@email.com";
            s1.Password = "password";
            s1.Gpa = 3.8;

            BinaryFormatter bf = new BinaryFormatter(); //2nd Step

            serialize(bf, s1); // convert s1 into bytes
            deserialize(bf); // Restore bytes back into object

            Console.ReadLine();
        }

        public static void serialize(BinaryFormatter bf, Student s1) // converts object to bytes
        {
            using (FileStream stream = new FileStream("..\\..\\student.bin", FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(stream, s1); // 3rd step: Serialize() -> IMPORTANT convert s1 into bytes
            }
        }

        public static void deserialize(BinaryFormatter bf) // restore bytes back into object
        {
            using (FileStream stream = new FileStream("..\\..\\student.bin", FileMode.Open, FileAccess.Read))
            {
                Student s = (Student)bf.Deserialize(stream); // Deserialize() IMPORTANT -> need to cast back to appropriate type 
                Console.WriteLine(s.ToString());               
            }
        }
    }
}
