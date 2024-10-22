using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Student : Human
    {
        double gpa;
        List<Course> courses;

        public double Gpa { get => gpa; set => gpa = value; }
        public List<Course> Courses { get => courses; set => courses = value; }

        public Student()
        {

        }

        public Student(double gpa, List<Course> courses)
        {
            this.gpa = gpa;
            this.courses = courses;
        }

        public void PrintCourseList()
        {
            foreach (Course c in courses)
            {
                Console.WriteLine(c);
            }

        }

        public override string ToString()
        {
            //return base.ToString();
            PrintCourseList();
            return $"******* Student Info *******\nName: {Name}\nGPA: {Gpa}\n";
        }
    }
}
