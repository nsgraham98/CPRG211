using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class FindSqrt
    {
        public int MySqrt(int x)
        {
            int left = 0;
            int right = x;
            int result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long midSquared = (long)mid * mid;
                
                if (midSquared == x)
                {
                    return mid;                    
                }
                if (midSquared < x)
                {
                    left = mid + 1;
                    result = mid;
                    continue;
                }
                if (midSquared > x)
                {
                    right = mid - 1 ;
                    continue;
                }
                
            }
            return right;
        }
        static void Main(string[] args)
        {
            FindSqrt test = new FindSqrt();
            test.MySqrt(8);
        }
    }
}
