using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Every animal has a sound");
        }
    }
}
