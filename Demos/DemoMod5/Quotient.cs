using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class Quotient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            quotient(n1, n2);
            //try
            //{
            //    int result = quotient(n1, n2);
            //    Console.WriteLine($"{n1}/{n2} is {result} ");
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine("Divisor cant be zero");
            //}
            //if (n2 != 0)
            //{
            //    Console.WriteLine(n1 + "/" + n2 + "is" + (n1 / n2));
            //}
            //else
            //{
            //    Console.WriteLine("Divisor cant be zero");
            //}
            Console.ReadLine();

           
        }
        public static void quotient(int n1, int n2)
        {
            try
            {
                Console.WriteLine($"{n1}/{n2} is {n1/n2} ");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Divisor cant be zero");
            }
            //if (n2 == 0)
            //{
            //    throw new ArithmeticException();
            //}
            //return n1 / n2;
        }
    }
}
