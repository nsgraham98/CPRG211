using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{

    class Person
    {
        public Person()
        {
            Console.WriteLine("Persons Constructor is invoked: Level 1");
        }
    }

    class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Employee Constructor is invoked: Level 2");
        }
    }
    class Faculty : Employee
    {
        public Faculty()
        {
            Console.WriteLine("Faculty Constructor is invoked: Level 3");
        }
    }
    public class Driver2
    {
        static void Main(string[] args)
        {
            Faculty f = new Faculty();

            Console.ReadLine();
        }
    }
}
