using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod7
{
    public class SquareRootNegativeException :Exception
    {
        public SquareRootNegativeException(string m, double n) : base (m + n)
        { }
    }
}
