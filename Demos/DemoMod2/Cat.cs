using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Cat : Animal
    {
       public override void animalSound()
        {
            Console.WriteLine("The cat says meow");
        }
        public void jumps()
        {
            Console.WriteLine("The cat jumps");
        }
    }
}
