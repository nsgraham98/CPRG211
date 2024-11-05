using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class CheckIsPalindrome
    {
        int x;
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();

            int increment = 0;
            int decrement = s.Length -1;
            bool isValid = true;

            foreach (char c in s)
            {
                if (s[increment] == s[decrement])
                {
                    increment++;
                    decrement--;
                }
                else
                {
                    isValid = false;                   
                }
            }
            return isValid;
        }
        static void Main(string[] args)
        {
            CheckIsPalindrome p = new CheckIsPalindrome();
            Console.WriteLine(p.IsPalindrome(1234321));
            Console.WriteLine(p.IsPalindrome(123456));
            Console.ReadLine();


        }
    }

}
