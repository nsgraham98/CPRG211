using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9ConsoleD
{
    public class Driver
    {
        static void Main(string[] args)
        {
            ProductManagementSystem p = new ProductManagementSystem();

            Console.WriteLine("Product Management System");
            Console.WriteLine("1. Dispaly");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    p.display();
                    Console.ReadLine();
                    break;
                case 2:
                    p.insert();
                    break;
                case 3:
                    p.update();
                    break;
                case 4:
                    p.delete();
                    break;

            }
            p.disconnect();
               
        }
    }
}
