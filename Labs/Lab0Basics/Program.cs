using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a low number");
            int lowNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a high number");
            int highNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Difference between {lowNum} and {highNum} is {highNum - lowNum}");

            Console.ReadLine();





        }

    }
}
