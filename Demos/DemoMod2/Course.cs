using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Course
    {
        string courseCode;
        string courseName;

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseName { get => courseName; set => courseName = value; }

        public Course() { }

        public Course(string courseCode, string courseName)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Course Info:\nCourse Code: {CourseCode}\nCourse Name: {CourseName}\n";
        }
    }
}
