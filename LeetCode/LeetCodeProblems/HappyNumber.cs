using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            bool happy = false;
            Dictionary<int, int> foundValues = new Dictionary<int, int> ();

            while (!happy)
            {
                string nString = n.ToString();
                int[] digitArray = new int[nString.Length];
                n = 0;

                for (int i = 0; i < digitArray.Length; i++)
                {
                    digitArray[i] = int.Parse(nString.Substring (i,1)) * int.Parse(nString.Substring(i, 1));
                    n = n + digitArray[i];
                }

                if (foundValues.ContainsKey(n))
                {
                    return false;
                }
                else
                {
                    foundValues.Add(n, n);
                }

                if (n == 1)
                { return true; }
            }
            return happy;
        }
        static void Main(string[] args)
        {
            HappyNumber test = new HappyNumber();
            test.IsHappy(19);
        }
    }
}
