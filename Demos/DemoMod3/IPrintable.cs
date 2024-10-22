using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod3
{
    // when to use interface vs. inheritance?
    // eg. if the connection is solid - bungalow (child) "is a" house (parent) ALWAYS -> inheritance ("is a" is good indicator)
    // eg. if the connection is not always solid - house (child) and car (child) can be both be painted (parent), but house and car are not similar -> interface
    // also you can only inherit from one class, but can inherit from multiple interfaces
    public interface IPrintable
    {
        void Print();
    }
}
