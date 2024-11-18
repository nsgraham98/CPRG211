using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class LongestCommonPrefix1
    {
        string[] strs = { "flower", "flow", "flight" };
        //string[] strs = { "dog", "racecar", "car" };
        //string[] strs = { "a" };
        //string[] strs = { "cir", "car" };
        //string[] strs = { "ab", "a" };
        //string[] strs = { "flower", "flower", "flower", "flower" };
        //string[] strs = { "c", "acc", "ccc" };

        public string LongestCommonPrefix(string[] strs)
        {
            string initialString = strs[0];
            Stack<char> charStack = new Stack<char>();
            string finalString = "";

            try
            {
                for (int j = 0; j < initialString.Length; j++)
                {
                    charStack.Push(initialString[j]);
                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (char.Parse(strs[i].Substring(j, 1)).Equals(charStack.Peek()))
                        {
                            continue;
                        }
                        else
                        {
                            charStack.Pop();
                            foreach (char c in charStack)
                            {
                                finalString = $"{c}{finalString}";
                            }
                            return finalString;
                        }
                    }
                }
            }
            catch (Exception)
            {
                charStack.Pop();
                foreach (char c in charStack)
                {
                    finalString = $"{c}{finalString}";
                }
                return finalString;
            }
            foreach (char c in charStack)
            {
                finalString = $"{c}{finalString}";
            }
            return finalString;
        }

        static void Main(string[] args)
        {
            LongestCommonPrefix1 test = new LongestCommonPrefix1();
            Console.WriteLine(test.LongestCommonPrefix(test.strs));
            Console.ReadLine(); 
        }
    }
}
