using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public class CatPt1 : AnimalPt1
    {
        public CatPt1() { }
        public CatPt1(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public override string ToString()
        {
            return $"Cat Name: {Name}\nColor: {Color}\nAge: {Age}";
        }
    }
}
