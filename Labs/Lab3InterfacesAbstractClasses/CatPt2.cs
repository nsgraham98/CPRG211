using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public class CatPt2 : AnimalPt2, IAnimal
    {
        public CatPt2() { }
        public CatPt2(string name, string color, int height, int age)
        {
            Name = name;
            Color = color;
            Age = age;
            Height = height;
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public override string Cry()
        {
            return $"Meow!";
        }
    }
}
