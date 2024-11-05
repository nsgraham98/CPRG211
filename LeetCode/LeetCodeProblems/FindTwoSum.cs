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
            int index1 = 0;
            int index2 = 0;

            int[] ints = {0, 0};

            foreach (int i in nums)
            {
                foreach (int j in nums)
                {

                    if (index1 == index2)
                    {
                        index2 ++;
                        continue;
                    }
                    else
                    {
                        if (j + i == target)
                        {
                            //int index1 = ;
                            //int index2 = ;
                            int[] foundIndex = { index1, index2 };
                            return foundIndex;
                        }
                        index2 ++;
                    }                 
                }
                index2 = 0;
                index1 ++;
            }

            return ints;
        }

        static void Main(string[] args)
        {
            int[] i1 = { 2, 7, 11, 15 };
            FindTwoSum test1 = new FindTwoSum(i1, 18);

            int[] i2 = {3,3};
            FindTwoSum test2 = new FindTwoSum(i2, 6);


            Console.WriteLine($"{test1.TwoSum(i1, 18)[0]},{test1.TwoSum(i1, 18)[1]}");
            //Console.WriteLine($"{test2.TwoSum(i2, 6)[0]},{test2.TwoSum(i2, 6)[1]} ");
            Console.ReadLine();
        }

        //public override string ToString()
        //{
        //    return $"{nums[0]}, {nums[1]}";
        //}
    }
}
