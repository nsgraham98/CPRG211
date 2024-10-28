using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class ReadBinaryFile
    {
        static void Main(string[] args)
        {
            string filepath = "..\\..\\numbers.dat";
            Console.WriteLine("Reading from binary file.");

            bool end = false;
            int number;
            using (BinaryReader inFile = new BinaryReader(File.Open(filepath, FileMode.Open)))
            {
                while (!end)
                {
                    try
                    {
                        number = inFile.ReadInt32(); // ReadDouble(), ReadString(), ReadInt16, etc
                        Console.WriteLine(number);
                    }
                    catch (Exception e)
                    {
                        end = true;
                    }
                    
                }
            }
            Console.ReadLine();

        }
    }
}
