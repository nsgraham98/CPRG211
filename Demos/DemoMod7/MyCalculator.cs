using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod7
{
    public class MyCalculator : SimpleCalculator
    {
        public double add(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 + n2;
        }

        public double divide(double n1, double n2)
        {
            //throw new NotImplementedException();
            if (n2 == 0)
            {
                throw new ArithmeticException("Cant divide by zero");
            }
            return n1 / n2;
        }

        public double multiply(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 * n2;
        }

        public double square(double n1)
        {
            // throw new NotImplementedException();
            return n1 * n1;
        }

        public double squareroot(double n1)
        {
            //throw new NotImplementedException();
            if (n1 < 0)
            {
                throw new SquareRootNegativeException("Cant do square root of a -ve number", n1);
            }
            return Math.Pow(n1, 0.5);
        }

        public double subtract(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 - n2;
        }
    }
}
