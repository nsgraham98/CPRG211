using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod7
{
    public interface SimpleCalculator
    {
        double add(double n1, double n2);
        double subtract(double n1, double n2);
        double multiply(double n1, double n2);
        double divide(double n1, double n2);
        double square(double n1);
        double squareroot(double n1);
    }
}
