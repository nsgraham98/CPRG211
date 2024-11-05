using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabCreatingExceptions
{
    internal class Program
    {
        public class Circle
        {
            double radius;

            public Circle(double radius)
            {
                this.radius = SetRadius(radius);
            }

            public double SetRadius(double radius)
            {
                if (radius <= 0)
                {
                    throw new InvalidRadiusException(radius);
                }
                else
                {
                    return radius;
                }

            }
            


            public override string ToString()
            {
                return $"Radius: {radius}";
            }
        }

        public class InvalidRadiusException : Exception
        {
            public InvalidRadiusException()
            {
                Console.WriteLine("Radius cannot be equal to or greater than zero");
            }
            public InvalidRadiusException(double radius)
            {
                Console.WriteLine($"Radius: {radius} cannot be equal to or greater than zero");
            }
        }

        public static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine(c1.ToString());

            Circle c2 = new Circle(-10);
            Console.WriteLine(c2.ToString());

            Circle c3 = new Circle(0);           
            Console.WriteLine(c3.ToString());

            Console.ReadLine();
        }
    }

}
