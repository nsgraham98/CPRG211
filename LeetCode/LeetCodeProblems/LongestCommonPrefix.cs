using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class LongestCommonPrefix1
    {
        //string[] strs = { "flower", "flow", "flight" };
        //string[] strs = { "dog", "racecar", "car" };
        //string[] strs = { "a" };
        //string[] strs = { "cir", "car" };
        //string[] strs = { "ab", "a" };
        //string[] strs = { "flower", "flower", "flower", "flower" };
        string[] strs = { "c", "acc", "ccc" };

        public string LongestCommonPrefix(string[] strs) // come back to this - doesnt work for all cases
        {
            int validCount = 0;
            int searchLength = 1;
            string baseWord = strs[0].Substring(0);
            string matchedChars = "";
            int maxIndex = strs[0].Length;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < maxIndex)
                {
                    maxIndex = strs[i].Length;
                }

                string tempMatchedChars = "";
                string foreignWord = strs[i];

                for (int j = 0; j < maxIndex; j++)
                {            
                    if (foreignWord.Substring(j,1) == baseWord.Substring(j,1))
                    {
                        tempMatchedChars += foreignWord.Substring(j,1);
                        matchedChars = tempMatchedChars;
                    }
                    else
                    {
                        matchedChars = tempMatchedChars;
                    }          
                }
                //strs.Length == 1 || strs[i].Length == 1
                if ((tempMatchedChars.Length <= matchedChars.Length) || matchedChars == "")
                {
                    matchedChars = tempMatchedChars;
                }
            }
            return matchedChars;
        }
        static void Main(string[] args)
        {
            LongestCommonPrefix1 test = new LongestCommonPrefix1();
            test.LongestCommonPrefix(test.strs);

        }
    }
}
