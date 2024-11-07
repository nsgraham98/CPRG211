using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod8
{
    public class Driver
    {
        static void Main(string[] args)
        {
            SLL s = new SLL();

            Console.WriteLine("Adding first node: (using Append)");
            s.Append("a"); // adding first node
            s.Print();

            Console.WriteLine("\nAdding other nodes: (using Append)");
            s.Append("b"); // adding other nodes
            s.Append("c");
            s.Append("d");
            s.Print();

            Console.ReadLine();
        }
    }
}
