using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class WriteLetter
    {
        static void Main(string[] args)
        {
            char[] letter = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                        'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                        'v', 'w', 'x', 'y', 'z'};

            using (FileStream raf = new FileStream("..\\..\\letter.dat", FileMode.Create))
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    raf.WriteByte((byte)letter[i]);
                }
            }

            Console.WriteLine("Writing is done");
            Console.ReadLine();
        }
        
    }
}
