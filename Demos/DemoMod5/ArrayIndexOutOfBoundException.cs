using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class ArrayIndexOutOfBoundException
    {
        static void Main(string[] args)
        {
            string[] names = { "Mike", "Ellen", "Mark" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}

