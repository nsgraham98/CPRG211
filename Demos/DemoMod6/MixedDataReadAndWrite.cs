using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class MixedDataReadAndWrite
    {
        static void Main(string[] args)
        {
            using (BinaryWriter outFile = new BinaryWriter(new FileStream("..\\..\\temp.dat", FileMode.Create)))
            {
                outFile.Write("John");
                outFile.Write(1.5);
                outFile.Write(10);
                outFile.Write(true);
            }

            using (BinaryReader inFile = new BinaryReader(new FileStream("..\\..\\temp.dat", FileMode.Open, FileAccess.Read)))
            {
                Console.WriteLine($"{inFile.ReadString()} {inFile.ReadDouble()} {inFile.ReadInt16()} {inFile.ReadBoolean()}");
            }
            Console.ReadLine();
        }
    }
}
