using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfacesAbstractClasses
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }
        int Height { get; set; }
        int Age { get; set; }
        void Eat();
        string Cry();
    }
}
