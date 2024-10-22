using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using A = System.Console;
*/

namespace DemoMod1
{
    //Define a class FirstDemo
    public class FirstDemo
    {
        //svm+tab   ----- static void Main(string[] args)
        public static void Main(string[] args)
        {
            Console.Write("Hello World!!");
            //cw+tab --- Console.WriteLine
            Console.WriteLine("Welcome to CPRG211");  // "\n"

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();  //generates string   123 SAIT

            Console.WriteLine("Please enter age");
            //int age= int.Parse(Console.ReadLine());
            //When you are sure that the user input is a valid integer representation of a string 

            int age = Convert.ToInt32(Console.ReadLine());
            //can handle various input types not just string
            //int a = Convert.ToInt32(123.345); //123
            //int b = Convert.ToInt32(null); //0
            //int c = Convert.ToInt32("abc");// throw exception

            //Respond the user with a personalized message in expanded form
            //Console.WriteLine("Hello, " + userName + "!! Nice to meet you. I am "+ age + " years old");

            //interpolated form
            Console.WriteLine($"Hello, {userName}!! Nice to meet you. I am {age} years old.");

            //Console.ReadKey();  // any key could also be a enter key, space bar, letter
            Console.WriteLine("Press enter key to exit....");
            Console.ReadLine(); // until user hit enter key

            /*A.WriteLine("HEllo World");
           A.WriteLine("Welcome to CPRG211");

           A.WriteLine("Please hit enter to exit");
           A.ReadLine();*/
        }
    }
}
