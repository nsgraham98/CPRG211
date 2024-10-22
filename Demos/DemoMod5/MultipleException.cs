using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class MultipleException
    {
        static void Main(string[] args)
        {
            try
            {

                string filepath = "..\\..\\test.txt";
                StreamReader sr = new StreamReader(filepath);

                int inputString = int.Parse(sr.ReadLine());
                Console.WriteLine(inputString);
            }
            catch (FileNotFoundException e) // specific -> order for exception stack should be specific first, general last
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) // specific
            {
                Console.WriteLine("Format is wrong");
            }
            catch (Exception e) // generic
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Inside finally block");
            }

                Console.WriteLine("CONTINUE");
            Console.ReadLine();
        }
    }
}
