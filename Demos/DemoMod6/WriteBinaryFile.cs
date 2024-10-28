using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class WriteBinaryFile
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 8, 10 };
            string filepath = "..\\..\\numbers.dat";
            using (BinaryWriter outFile = new BinaryWriter(File.Open(filepath, FileMode.Create))) // needs path, and instruction of what to do (FileMode.Create)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    outFile.Write(number[i]);
                }
            }
            Console.WriteLine("Writing numbers into binary file.");
            Console.ReadLine();
        }
    }
}
