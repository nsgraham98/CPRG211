using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod6
{
    public class TextFileReadWriteUsing
    {
        static void Main(string[] args)
        {
            string path = "..\\..\\sample.txt";

            using (StreamWriter writer = new StreamWriter(path)) // do not need to close because of "using (StreamWriter......)"
            {
                writer.WriteLine("one\ntwo\nthree");
            }

            StreamReader sr = new StreamReader(path);
            using (sr)
            {
                int lineNumber = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0} : {1}:", lineNumber, line);
                    line = sr.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
