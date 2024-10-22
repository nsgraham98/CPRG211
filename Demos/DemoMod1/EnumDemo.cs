using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod1
{
    public class EnumDemo
    {
        //Enum descriptive name instead of numbers
        // first member of enum has a value 0 each subsequent members is incremented by 1

        enum Days  // enum is abstract class
        { 
            Monday, //0
            Tuesday, //1
            Wednesday, //2
            Thursday, //3
            Friday, //4
            Saturday, //5
            Sunday //6
        }

        // I can change the default value of Enum and any subsequent member without any value will take the incrremented
        // value of the previous member
        enum Colors
        { 
            Red = 1,
            Blue = 12,
            Magenta = 31,
            Green, //32  implicitely assigned
            Yellow, //33  implicitely assigned
            Pink //34  implicitely assigned
        }

        public static void Main(string[] args)
        {
            Days myVar = Days.Friday;
            Console.WriteLine($"Selected days: {myVar}");
            Console.WriteLine($"Chosen color is: {Colors.Yellow}");
            Console.WriteLine($"Chosen color numeric corresponding value is: {(int)Colors.Yellow} ");

            //convert enum to int
            int day = (int)Days.Sunday;
            Console.WriteLine($"Numeric value of selected day is {day}");

            //int to enum conversion
            Days wd = (Days)3;
            Console.WriteLine($"Day corresponding to int Day 3: {wd}");

            //we can get string value of an enum using toString()
            string weekday = Days.Tuesday.ToString();
            Console.WriteLine($"String value id: {weekday}");


            Console.ReadLine();
        }
    }
}
