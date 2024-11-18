using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class StringLengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] strings = s.Split(' ');
            string last = strings[strings.Length - 1];
            int length = last.Length;
            return length;
        }
    }
}
