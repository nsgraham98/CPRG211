using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod2
{
    public class Shape // Object is the parent of all C# classes
    {
        string color;
        bool filled;
        DateTime dateCreated;
        private int a;
        private int b;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        protected int A { get => a; set => a = value; }
        internal int B { get => b; set => b = value; }

        public Shape() // default constructor
        {
            this.Color = "Pink";
            this.a = 10;
            this.b = 5;
        }

        public Shape(string color, bool filled, DateTime dateCreated)
        {
            this.color = color;
            this.filled = filled;
            this.dateCreated = dateCreated;
        }

        public virtual void printInfo() // virtual can be overriden by child class
        {
            Console.WriteLine("\n Shape Information");
            Console.WriteLine($"Shape Color: {Color}");
            Console.WriteLine($"Shape is Filled: {Filled}");
            Console.WriteLine($"Shape Creation Date: {DateCreated}");
        }

        public virtual void printColor()
        {
            Console.WriteLine("White");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Color: {Color}\nFilled: {Filled}\nDate Created: {DateCreated}\n";
        }
    }
}
