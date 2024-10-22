using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class AnimalTest
    {
        public static void Main(string[] args)
        {
            int i = 10; //Primitive data type
            Animal a1 = new Animal(); // a1 : object if Animal class access instance variables of Animal class
            a1.Name = "Fido"; //set
            a1.Age = 4;
            a1.Species = "Dog";

            // Console.WriteLine($"{a1.Name} is a {a1.Species} who is {a1.Age} years old"); //get
            Console.WriteLine(a1);


            Animal a2 = new Animal();
            a2.Name = "Fluffy";
            a2.Age = 5;
            a2.Species = "Cat";
            //Console.WriteLine($"{a2.Name} is a {a2.Species} who is {a2.Age} years old");
            Console.WriteLine(a2); // implicitely call .ToString()

            //Console c1 = new Console()
            // Object p1 = new Object();

            //Console.WriteLine(a1.Eat());
            Console.WriteLine("Animal a1 method");
            a1.Eat();
            Console.WriteLine("\nAnimal a2 method");
            a2.Eat();

            Console.ReadLine();
        }
    }
}
