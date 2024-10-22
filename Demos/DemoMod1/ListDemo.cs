using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class ListDemo
    {
        public static void Main(string[] args)
        {
            //array fixed-size
            string[] fruit = new string[3];  // size
            fruit[0] = "Apple";
            fruit[1] = "Mango";
            fruit[2] = "Pear"; // length-1
                               //fruit[3] = "Grapes"; //IndexOutOfRangeException 
           
            Console.WriteLine("Fruit Array");
            //size of array length-1 , fruit[i]
            foreach (string temp in fruit) //temp ="Apple"
            {
                Console.WriteLine(temp);
            }

            //dynamically add and remove elements from the list (grow and shrink )
            //no need to give size
            List<string> vehicle = new List<string>();
            vehicle.Add("Bike"); // [0]
            vehicle.Add("Car");  //1
            vehicle.Add("Truck");  //2
            vehicle.Add("Scooter");  //3
            vehicle.Add("Bike");    //4

            Console.WriteLine("\n******** Initial List *****");
            foreach (string temp in vehicle)
            {
                Console.WriteLine(temp);
            }

            //Access list element by index
            Console.WriteLine("Access List uisng index: "+ vehicle[2]);


            Console.WriteLine("\n********** Remove an element **********");
            vehicle.Remove("Scooter");
            foreach (string temp in vehicle)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("\n********** Insert an element **********");
            vehicle.Insert(0, "Van");
            foreach (string temp in vehicle)
            {
                Console.WriteLine(temp);
            }

            //List operation
            Console.WriteLine("\n\nSize of List: " + vehicle.Count);
            Console.WriteLine("Index of element: "+ vehicle.IndexOf("Truck"));
            Console.WriteLine("Last Index of a duplicated item: " + vehicle.LastIndexOf("Bike"));
            Console.WriteLine("If an element exist: " + vehicle.Contains("Bike"));

            Console.WriteLine("\n******* Sorting *************");
            vehicle.Sort();
            foreach (string temp in vehicle)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("\n******* Reverse *************");
            vehicle.Reverse();
            foreach (string temp in vehicle)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("\n******* Clear *************");
            vehicle.Clear();
            foreach (string temp in vehicle)
            {
                //This loop will not executed as list is empty
                Console.WriteLine(temp);
            }


            /*Person p1 = new Person("Harinder", 30, 123, 'F', true);
            Person p2 = new Person("John", 30, 123, 'F', true);
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);

            double highest = people.Max(p => p.Age); // 45
            var high = people.Find(p => p.Age == highest).FirstName;
            Console.WriteLine("Oldest person is: " + high);*/
           //Harinder
           // SubString(1)// arinder
           // SubString(1,4)// ari



            Console.ReadLine();
        }
    }
}
