using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9Databases
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            ProductManagementSystem p  = new ProductManagementSystem();

            Console.WriteLine("Product Management  System");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    p.Display();
                    Console.ReadLine();
                    break;
                case 2:
                    p.Insert();
                    Console.ReadLine();
                    break;
                case 3:
                    p.Update();
                    Console.ReadLine();
                    break;
                case 4:
                    p.Delete();
                    Console.ReadLine();
                    break;
            }
            p.Disconnect();
        }
    }

}
