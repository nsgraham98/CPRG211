using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class ReadLetter
    {
        static void Main(string[] args)
        {
            using(FileStream raf = new FileStream("..\\..\\letter.dat", FileMode.Open))
            {
                long pos;
                char ch;

                // reading 6th character
                pos = 5;
                raf.Seek(pos, SeekOrigin.Begin); //.Seek moves the file pointer
                ch = (char)raf.ReadByte();
                Console.WriteLine($"The sixth character is {ch}");
                
                long length = raf.Length;
                raf.Seek(length/2, SeekOrigin.Begin);
                int middle = raf.ReadByte()-1;
                Console.WriteLine($"The middle character is {(char)middle}");
            }
            Console.ReadLine();
        }
    }
}
