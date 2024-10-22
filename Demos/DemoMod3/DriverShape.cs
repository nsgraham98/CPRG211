using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    public class DriverShape // NOTE FOR ASSINGMENT: APPLIANCE MUST BE ABSTRACT CLASS
    {
        static void Main(string[] args)
        {
            //Shape s1 = new Shape(); // cannot create shape object because shape IS an abstract class

            Circle c1 = new Circle(2,"red"); // can create because Circle IS NOT an abstract class
            c1.getArea();

            Shape s2 = new Circle(3, "green"); // can create
            Shape s3 = new Circle(4, "pink");
            s2.getArea();

            // can create an array of shapes
            Shape[] shapes = new Shape[10]; //creating 10 shapes

            shapes[0] = s2;
            shapes[1] = s3;

            //IDrawable d1 = new IDrawable(); // ERROR cannot create object of an interface (IDrawable)
            IDrawable[] drawables = new IDrawable[10];
            drawables[0] = c1;
            drawables[1] = s2;

            Console.ReadLine();
        }
    }
}
