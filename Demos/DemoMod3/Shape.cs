using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    public abstract class Shape : IDrawable // abstract methods can only belong to abstract classes
    {
        string color;

        public string Color { get => color; set => color = value; }

        public Shape() // constructors in (abstract) shape class is not defined to instantiate a shape BUT INSTEAD to be used by the child class
        {
            
        }

        public Shape(string c)
        {
            color = c;
        }

        public abstract void getArea(); // abstract -> no implementation, no body

        // signature -> accessmodifier returntype methodName(parameterlist) -> eg. public void test()
        public void test() // non-abstract method
        {
            Console.WriteLine("Abstract class can have non-abstract methods");
        }

        public abstract void draw();

        public abstract void Print();
    }
}
