using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Rectangle : Shape
    {
        double length;
        double height;

        public double Length { get => length; set => length = value; }
        public double Height { get => height; set => height = value; }

        public Rectangle()
        {

        }

        public Rectangle(string color, bool filled, DateTime dateCreated, double length, double height) : base(color, filled, dateCreated)
        {
            //this.color = color;
            //this.filled = filled;
            //this.dateCreated = dateCreated;
            this.Length = length;
            this.Height = height;
        }
        public string Color
        {
            get { return "Orange"; }
        }

        public override void printInfo() // overrides virtual printInfo() in parent class
        {
            Console.WriteLine("\n Rectangle Information");
            Console.WriteLine($"Rectangle Color: {Color}");
            Console.WriteLine($"Rectangle is Filled: {Filled}");
            Console.WriteLine($"Rectangle Creation Date: {DateCreated}");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Rectangle:\nLength: {Length}\nHeight: {Height}\nColor: {Color}\nFilled: {Filled}\nDate Created: {DateCreated}\n";
        }
    }
}
