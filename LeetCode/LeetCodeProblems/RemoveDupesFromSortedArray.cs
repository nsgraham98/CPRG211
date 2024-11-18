using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class RemoveDupesFromSortedArray
    {
        int[] array;
        public int[] Array { get => array; set => array = value; }

        // online solution (better)
        public int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                nums[count] = nums[i];
                count++;
            }
            return count;
        }

        // my janky ass solution
        //{
        //    if (nums.Length == 0) return 0;
        //    if (nums.Length == 1) return nums[0];

        //    List<int> storedNums = new List<int>();

        //    int result = 1;
        //    int i = 0;
        //    int j = 1;

        //    while (nums[i] <= nums[j])
        //    {
        //        if (nums[i] < nums[j])
        //        {
        //            if (System.Array.IndexOf(nums, nums[j]) == System.Array.IndexOf(nums, nums[nums.Length - 1]))
        //            {
        //                nums.SetValue(nums[j], i+1);
        //                result++;
        //                return result;
        //            }
        //            else
        //            {
        //                j++;
        //                i++;
        //                result++;
        //            }
        //        }
        //        while (nums[i] == nums[j])
        //        {
        //            if (System.Array.IndexOf(nums, nums[j]) == System.Array.IndexOf(nums, nums[nums.Length - 1]))
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                j++;
        //            }                   
        //        }
        //        i++;
        //        nums.SetValue(nums[j], i);         
        //        result++;
        //    }
        //    return result;
        //}
        static void Main(string[] args)
        {
            
            RemoveDupesFromSortedArray r = new RemoveDupesFromSortedArray();
            r.Array = new int[3] { 1,1,2 };
            Console.WriteLine(r.RemoveDuplicates(r.array));
            Console.ReadLine();

        }
    }
}
