using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says woof");
        }
        public void bark()
        {
            Console.WriteLine("The dog barks");
        }
    }
}
