using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public abstract class AnimalPt2 : IAnimal
    {
        string name;
        string color;
        int age;
        int height;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Age { get => age; set => age = value; }
        public int Height {  get => height; set => height = value; }

        //public AnimalPt2(string name, string color, int age, int height)
        //{
        //    this.Name = name;
        //    this.Color = color;
        //    this.Age = age;
        //    this.Height = height;
        //}
        //public AnimalPt2() { }

        public abstract void Eat();
        public abstract string Cry();
    }
}
