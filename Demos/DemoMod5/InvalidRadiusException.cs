using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod5
{
    public class InvalidRadiusException : Exception // user defined exception needs Exception as parent
    {
        public InvalidRadiusException() : base("Invalid Radius: Radius cant be negative") { }
        public InvalidRadiusException(double radius) : base($"Invalid radius: {radius}")
        {

        }

    }
}
