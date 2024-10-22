using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    public interface IDrawable : IPrintable // interfaces must begin with 'I' -> IDrawable
                                            // interface can have interface as parent
    {
        //NO datafields
        //string name; <- no
        //string Name { get; set; }

        void draw(); // can create methods with no body, no access modifier, no abstract keyword -> (implicitely abstract)
    }
}
