
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class InputMismatchException
    {
        static void Main(string[] args)
        {
            bool continueInput = true;

            try
            {
                Console.WriteLine("Enter an integer");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine($"entered number is {number}");
                continueInput = false;
            }
            catch (FormatException)
            // catch() -> without () -> general catch handler
            // catch(Exception e) -> general catch handler
            {
                Console.WriteLine("Error. Invalid input.");
            }

            Console.WriteLine("CONTINUE");

            Console.ReadLine();
        }
    }
}
