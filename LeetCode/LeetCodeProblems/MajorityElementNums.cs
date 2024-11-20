using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class MajorityElementNums
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int result = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i  = 0; i < nums.Length;i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = dict[nums[i]]+1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
                if (dict[nums[i]] > count) 
                {
                    count = dict[nums[i]];
                    result = nums[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            MajorityElementNums test = new MajorityElementNums();

            int[] nums = { 3,3,4 };

            test.MajorityElement(nums);
        }
    }
}
