using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    public class Rectangle : Shape // Concrete class/method
    {
        double length;
        double width;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public Rectangle()
        {
            
        }

        public Rectangle(double length, double width, string c) : base(c)
        {
            Length = length;
            Width = width;
        }

        public override void getArea()
        {
            //throw new NotImplementedException();
            Console.WriteLine(Length * Width);
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
