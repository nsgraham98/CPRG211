using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class Rectangle
    {
        double width;
        double length;

        public Rectangle()
        {
            this.length =1;
            this.width = 1;
        }
        public Rectangle(double w, double l)
        {
            this.Width = w;
            this.Length = l;
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }

        public double CalculateArea() // user defined method
        {
            return this.Length * this.Width;
        }


        public override string ToString()
        {
            //return base.ToString();
            return $"Rectangle dimensions are: {Width} and {Length} with an Area of {(this.Length* this.Width)} ";
        }
    }

// Parent - superclass, general, base class
// Child - subclass, derived, specialized, inherited
}
