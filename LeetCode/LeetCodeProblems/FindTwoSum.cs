using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class FindTwoSum
    {
        int[] nums;
        int target;

        public FindTwoSum(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] filler = { 0, 0 };

            foreach (int i in nums)
            {
                int diff = target - i;
                int iIndex = Array.IndexOf(nums, i);
                int matchingSumIndex = Array.IndexOf(nums, diff, iIndex+1);

                if (matchingSumIndex > -1 && matchingSumIndex != iIndex)
                {
                    int[] ints = {iIndex, matchingSumIndex};
                    return ints;
                }
            }
            return filler;
        }

        static void Main(string[] args)
        {
            int[] i1 = { 2, 7, 11, 15 };
            FindTwoSum test1 = new FindTwoSum(i1, 18);

            int[] i2 = {3,2,4};
            FindTwoSum test2 = new FindTwoSum(i2, 6);

            int[] i3 = { 3,3};
            FindTwoSum test3 = new FindTwoSum(i3, 6);


            //Console.WriteLine($"{test1.TwoSum(i1, 18)[0]},{test1.TwoSum(i1, 18)[1]}");
            //Console.WriteLine($"{test2.TwoSum(i2, 6)[0]},{test2.TwoSum(i2, 6)[1]} ");
            Console.WriteLine($"{test3.TwoSum(i3, 6)[0]},{test3.TwoSum(i3, 6)[1]} ");
            Console.ReadLine();
        }

        //public override string ToString()
        //{
        //    return $"{nums[0]}, {nums[1]}";
        //}
    }
}
