using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class DriverAnimal
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.animalSound();

            Cat c1 = new Cat();
            c1.animalSound();

            Cat c2 = new Cat();
            c1 = c2; //c1 and c2 point same memory location c2

            if (c1 == c2) //checks memory location, NOT values
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Animal a2 = new Cat();
            a2.animalSound();
            //a2.jumps(); // ERROR bc not every animal is a cat
            ((Cat)a2).jumps(); //casting --> ??? look this up

            if(a2 is Cat) // returns true
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //Cat c3 = new Animal(); //ERROR 
            Cat c3 = (Cat) new Animal(); // casting

            Console.ReadLine();
        }
    }
}
