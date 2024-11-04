using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class CircleDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle(-5);
                Console.WriteLine(circle);
            }
            // catch(ArgumentException e)
            catch(InvalidRadiusException e)
            {
                Console.WriteLine(e.Message); // user defined -> parameter you passed -> new ArgumentException("Radius cant be negative");
                Console.WriteLine(e.StackTrace); // system generated message
            }
            Console.WriteLine("CONTINUE");
            Console.ReadLine();
        }
   
    }
}
