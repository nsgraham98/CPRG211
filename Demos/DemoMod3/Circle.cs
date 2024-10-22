using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    public class Circle : Shape, IDrawable, IPrintable // cannot have multiple classes as parent
    {
        double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle()
        {
            
        }

        public Circle(double radius, string color) : base(color) 
        {
            Radius = radius;
        }

        public override void getArea() // Any abstract method in base class MUST have an implementation in child class
        {
            //throw new NotImplementedException();
            Console.WriteLine(3.14 * Math.Pow(Radius,2));
        }

        public override void draw()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
