using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public class DogPt2 : AnimalPt2, IAnimal
    {
        public DogPt2() { }
        public DogPt2(string name, string color, int height, int age)
        {
            Name = name;
            Color = color;
            Age = age;
            Height = height;
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public override string Cry()
        {
            return $"Woof!";
        }
    }
}
