using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public abstract class AnimalPt1
    {
        string name;
        string color;
        int age;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Age { get => age; set => age = value; }

        //public AnimalPt1(string name, string color, int age)
        //{
        //    this.Name = name;
        //    this.Color = color;
        //    this.Age = age;
        //}
        //public AnimalPt1() { }

        public abstract void Eat();
    }
}
