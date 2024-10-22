using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class TestPerson
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("First Person Details are setup by DEFAULT Constructor");
            Console.WriteLine("Name: " + p1.Name);
            Console.WriteLine("ID: "+ p1.Id);
            Console.WriteLine("Salary: " + p1.Sal);
            Console.WriteLine("Gender: "+ p1.Gender);
            Console.WriteLine("Is Vaccinated: "+ p1.IsVaccinated);

            Console.WriteLine("Second Person Details ");
            Person p2 = new Person("Harinder", 101, 3000, 'F', true);
            Console.WriteLine("Name: " + p2.Name);
            Console.WriteLine("ID: " + p2.Id);
            Console.WriteLine("Salary: " + p2.Sal);
            Console.WriteLine("Gender: " + p2.Gender);
            Console.WriteLine("Is Vaccinated: " + p2.IsVaccinated);

            Console.WriteLine("Third Person Details");
            Person p3 = new Person("Mike", 102, 8000, 'M', true);
            Console.WriteLine("Name: " + p3.Name);
            Console.WriteLine("ID: " + p3.Id);
            Console.WriteLine("Salary: " + p3.Sal);
            Console.WriteLine("Gender: " + p3.Gender);
            Console.WriteLine("Is Vaccinated: " + p3.IsVaccinated);

            //Local variable with a primitive data type
            string name = "John";
            Console.WriteLine(name);

            int i = 10;
            Console.WriteLine(int.MaxValue);
            int j;
            j = i;
            Console.WriteLine(j + "    " + i);

            //Object
            Console.WriteLine("Before Assignment");
            Console.WriteLine("Name of Second Person: " + p2.Name);
            Console.WriteLine("Name of Third Person: " + p3.Name);
            
            //Assignment
            p2 = p3;
            Console.WriteLine("\nAfter Assignment");
            Console.WriteLine("Name of Second Person: " + p2.Name);
            Console.WriteLine("Name of Third Person: " + p3.Name);

            //Pass by reference and Pass by value
            displayPersonInfo(p3, i); // object, simple variable
            Console.WriteLine("Value of i : " + i);

            Person newPerson = changePersonInfo(p3);
            Console.WriteLine("\n\nNew Person Details");
            Console.WriteLine("Name: " + newPerson.Name);
            Console.WriteLine("ID: " + newPerson.Id);
            Console.WriteLine("Salary: " + newPerson.Sal);
            Console.WriteLine("Gender: " + newPerson.Gender);
            Console.WriteLine("Is Vaccinated: " + newPerson.IsVaccinated);

            Console.ReadLine();
        }

        public static void displayPersonInfo(Person x, int h) // h =10
        {
            h = 5000;
            Console.WriteLine("Name: " + x.Name);
            Console.WriteLine("ID: " + x.Id);
            Console.WriteLine("Salary: " + x.Sal);
            Console.WriteLine("Gender: " + x.Gender);
            Console.WriteLine("Is Vaccinated: " + x.IsVaccinated);
            Console.WriteLine("Value of Primitive datatype " + h);

        }

        public static Person changePersonInfo(Person y)
        {
            y.Name = "John";
            y.Id = 199;
            return y;
        }
    }
}
