using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Circle : Shape // Child : Parent -> Circle inherits attributes from Shape class
    {
        double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle()
        {

        }

        public Circle(string color, bool filled, DateTime dateCreated, double radius) : base(color, filled, dateCreated) // base class constructor
        {
            Radius = radius;

            // vv not needed vv - base(color, filled, dateCreated) is used instead

            //this.color = color;
            //this.filled = filled;
            //this.dateCreated = dateCreated;
        }

        public string Color
        {
            get { return "Green"; }
        }

        public sealed override void printInfo() // overrides virtual printInfo() in parent class
                                                // sealed disallows overriding in child classes
        {
            Console.WriteLine("\n Circle Information");
            Console.WriteLine($"Circle Color: {Color}");
            Console.WriteLine($"Circle is Filled: {Filled}");
            Console.WriteLine($"Circle Creation Date: {DateCreated}");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Circle:\nRadius: {Radius}\nColor: {Color}\nFilled: {Filled}\nDate Created: {DateCreated}\n";
        }
    }
}
