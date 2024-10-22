using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Driver
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Color = "Red";
            s1.Filled = true;
            s1.DateCreated = DateTime.Now; // DateTime represents an instance in time, in this case "Now"
            Console.WriteLine(s1);

            Console.WriteLine("Second Shape:");
            Shape s2 = new Shape("Grey", false, DateTime.Now);
            Console.WriteLine(s2);

            Console.WriteLine("\nThird Shape");
            Shape c1 = new Circle("Blue", true, DateTime.Now, 2.3);
            Console.WriteLine(c1);

            Console.WriteLine("\nFourth Shape");
            Circle c2 = new Circle();
            //c2.Color = "Maroon"; // ERROR as there is no set in the circle color property
            Console.WriteLine($"C2 color: {c2.Color}");

            Console.WriteLine("\nFifth Shape");
            Rectangle r1 = new Rectangle("Yellow", true, DateTime.Now, 6.5, 5.2);
            Console.WriteLine(r1);


            // a // is NOT accessable (protected int a from Shapes.cs)
            // b // IS accessable (internal int b from Shapes.cs) 



            Console.ReadLine();


        }
    }
}
