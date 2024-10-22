using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public class DogPt1 : AnimalPt1
    {
        public DogPt1() { }
        public DogPt1(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public override string ToString()
        {
            return $"Dog Name: {Name}\nColor: {Color}\nAge: {Age}";
        }
    }
}
