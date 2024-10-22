using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabInterfacesAbstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {            
            // Part 1
            Console.WriteLine("Enter dog1 name: ");
            DogPt1 dog1 = new DogPt1((Console.ReadLine()), "Brown", 5);
            Console.WriteLine($"Dog Name: {dog1.Name}\nColor: {dog1.Color}\nAge: {dog1.Age}");
            dog1.Eat();

            Console.WriteLine("Enter cat1 name: ");
            CatPt1 cat1 = new CatPt1((Console.ReadLine()), "Black", 3);
            Console.WriteLine($"Cat Name: {cat1.Name}\nColor: {cat1.Color}\nAge: {cat1.Age}");
            cat1.Eat();


            // Part 2
            Console.WriteLine("Enter dog2 name: ");
            string d2Name = Console.ReadLine();
            Console.WriteLine("Enter dog2 height: ");
            int d2Height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter dog2 color: ");
            string d2Color = Console.ReadLine();
            Console.WriteLine("Enter dog2 age: ");
            int d2Age = Convert.ToInt16(Console.ReadLine());

            DogPt2 dog2 = new DogPt2(d2Name, d2Color, d2Height, d2Age);
            Console.WriteLine($"Dog Name: {dog2.Name}\nColor: {dog2.Color}\nAge: {dog2.Age}, Height: {dog2.Height}");
            dog2.Eat();
            Console.WriteLine(dog2.Cry()); 

            Console.WriteLine("Enter cat2 name: ");
            string c2Name = Console.ReadLine();
            Console.WriteLine("Enter cat2 height: ");
            int c2Height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter cat2 color: ");
            string c2Color = Console.ReadLine();
            Console.WriteLine("Enter cat2 age: ");
            int c2Age = Convert.ToInt16(Console.ReadLine());

            CatPt2 cat2 = new CatPt2(c2Name, c2Color, c2Height, c2Age);
            Console.WriteLine($"Cat Name: {cat2.Name}\nColor: {cat2.Color}\nAge: {cat2.Age}, Height: {cat2.Height}");
            cat2.Eat();
            Console.WriteLine(cat2.Cry()); 

            List<AnimalPt2> aList = new List<AnimalPt2>();
            aList.Add(cat2);
            aList.Add(dog2);
            DogPt2 a3 = new DogPt2("Bobby", "White", 10, 30);
            aList.Add(a3);
            Console.WriteLine($"Animal 1 Name: {cat2.Name}\nAnimal 2 Name: {dog2.Name}\nAnimal 3 Name: {a3.Name}");




            Console.ReadLine();


        }
    }
}
 