using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab6SerializationAndRAF
{
    public class Program
    {
        static void Main(string[] args)
        {
            // PART 1
            Event myEvent = new Event(1, "Calgary");
            BinaryFormatter bf = new BinaryFormatter();

            // Using serialization to serialize the object to a file called event.txt.
            using (FileStream stream = new FileStream("..\\..\\event.txt", FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(stream, myEvent);
            }

            // Use deserialization to deserialize the object from the file and display the values on the Console.
            using (FileStream stream = new FileStream("..\\..\\event.txt", FileMode.Open, FileAccess.Read))
            {
                Event e = (Event)bf.Deserialize(stream);
                Console.WriteLine(e.ToString());
            }

            // PART 2
            ReadFromFile();
            Console.ReadLine();
        }

        /* Create a method called ReadFromFile, where you write the word “Hackathon” to the file, and then 
         * read the first, middle and last characters using StreamWriter and the Seek method. */
        public static void ReadFromFile()
        {
            string path = "..\\..\\event.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hackathon");
            }

            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                long length = "Hackathon".Length;

                stream.Seek(0, SeekOrigin.Begin);
                int first = stream.ReadByte();
                Console.WriteLine($"The First Character is: {(char)first}");

                stream.Seek(length/2, SeekOrigin.Begin);
                int middle = stream.ReadByte();
                Console.WriteLine($"The Middle Character is: {(char)middle}");

                stream.Seek(length-1, SeekOrigin.Begin);
                int last = stream.ReadByte();
                Console.WriteLine($"The Last Character is: {(char)last}");
            }
        }
    }
    [Serializable]
    public class Event
    {
        int eventNum;
        string location;

        public Event() { }
        public Event(int eventNum, string location)
        {
            this.EventNum = eventNum;
            this.Location = location;
        }
        
        public int EventNum { get => eventNum; set => eventNum = value; }
        public string Location { get => location; set => location = value; }

        public override string ToString()
        {
            return $"Event Number: {eventNum}\nLocation: {location}";
        }
    }
}
