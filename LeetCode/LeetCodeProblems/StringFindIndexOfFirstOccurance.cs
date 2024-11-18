using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class StringFindIndexOfFirstOccurance
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) { return -1; }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;                
        }
    }
}
