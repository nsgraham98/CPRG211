using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class BasicMath
    {
        public double Add(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 + n2;
        }
        public double Subtract(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 - n2;
        }

        public double Divide(double n1, double n2)
        {
            //throw new NotImplementedException();
            if (n2 == 0)
            {
                throw new ArithmeticException("Cant divide by zero");
            }
            return n1 / n2;
        }

        public double Multiply(double n1, double n2)
        {
            //throw new NotImplementedException();
            return n1 * n2;
        }
    }
}
