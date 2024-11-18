using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ArrayPlusOneInteger
    {
        public int[] PlusOne(int[] digits)
        {          
            int index = digits.Length -1 ;

            while (digits[index] == 9)
            {
                if (index == 0)
                {
                    digits = new int[digits.Length+1];
                    digits[0] = 1;
                    return digits;
                }
                digits[index] = 0 ;
                index--;
            }
            digits[index]++;
            return digits;
        }
        static void Main(string[] args)
        {
            ArrayPlusOneInteger array = new ArrayPlusOneInteger();
            int[] digits = { 9 };
            array.PlusOne(digits);
            Console.ReadLine();
        }
    }
}
