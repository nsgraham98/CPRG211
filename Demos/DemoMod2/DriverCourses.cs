using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoMod2
{
    public class DriverCourses
    {
        static List<Course> courses = new List<Course>();
        static void Main(string[] args)
        {
            LoadCourseListFromFile();
            Student s1 = new Student(); //hard coding s1 obj just for example - can use user inputs for values in assingment
            s1.Name = "John";
            s1.Age = 25;
            s1.Sin = 12345;
            s1.Courses = courses;
            s1.Gpa = 4;
            Console.WriteLine(s1);
            Console.ReadLine();
        }

        // Read from file and load the list
        public static void LoadCourseListFromFile()
        {
            string path = "..\\..\\res\\courses.txt";//relative path --- bin -> Debug -> exe (starting point)

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] fields = line.Split('_'); //fields[0], fields[1]
                string code = fields[0]; //CPRG211
                string name = fields[1]; //OOP2
                courses.Add(new Course(code, name)); //courses = list (is loaded by end of the loop)
            }
        }
    }
}
