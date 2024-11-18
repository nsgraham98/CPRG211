using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class CircularArrayDefuseTheBomb
    {
        public int[] Decrypt(int[] code, int k)
        {
            int[] newArray = new int[code.Length];
            int length = code.Length;

            if (k == 0) {return newArray;}

            if (k > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    int newSum = 0;

                    for (int iteration = 1; iteration <= k; iteration++)
                    {
                        int theoryIndex = i + iteration;
                        int realIndex = theoryIndex % length;

                        newSum += code[realIndex];
                    }
                    newArray[i] = newSum;
                }
            }

            if (k < 0)
            {
                for (int i = 0; i < length; i++)
                {
                    int newSum = 0;

                    for (int iteration = -1; iteration >= k; iteration--)
                    {
                        int theoryIndex = i + iteration;
                        int realIndex = theoryIndex % length;

                        while (realIndex < 0)
                        {
                            realIndex = realIndex + length;
                        }
                        
                        newSum += code[realIndex];
                    }
                    newArray[i] = newSum;
                }
            }

            return newArray;

        }
        static void Main(string[] args)
        {
            CircularArrayDefuseTheBomb test = new CircularArrayDefuseTheBomb();
            int[] array = { 5, 7, 1, 4 };
            test.Decrypt(array, -6);
        }
    }
}
