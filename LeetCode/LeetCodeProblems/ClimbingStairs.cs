using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int prevFibb = 0;
            int fibb = 1;
            for (int i = 0; i < n; i++)
            {
                int tempFibb = fibb;
                fibb += prevFibb;
                prevFibb = tempFibb;

            }
            return fibb;
        }
        static void Main(string[] args)
        {
            ClimbingStairs test = new ClimbingStairs();
            test.ClimbStairs(6);
        }
    }
}
