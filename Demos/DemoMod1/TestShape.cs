using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class TestShape
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Circle 1 Details");
            Circle c1 = new Circle();
            //c1.Circle(); // Cant call a constructor explicitely
            Console.WriteLine(c1);
            Console.WriteLine("Number of Circle: " + Circle.numberOfCircles); // c1.numberOfCircles == ERROR

            Console.WriteLine("Circle 2 Details");
            Circle c2 = new Circle(5, "Red");
            Console.WriteLine(c2);
            Console.WriteLine("Number of Circle: " + Circle.numberOfCircles);


            Console.WriteLine("Circle 3 Details");
            Circle c3 = new Circle("Blue", 9);
            Console.WriteLine(c3);
            Console.WriteLine("Number of Circle: " + Circle.numberOfCircles);


            Rectangle r1 = new Rectangle(5,2);
            Console.WriteLine(r1);

            Console.ReadLine();
        }
    }
}
