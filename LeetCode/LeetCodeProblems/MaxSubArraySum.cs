using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class MaxSubArraySum
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            int currentSum = 0;
            int largestSum = 0;
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i< nums.Length; i++)
            {
                if (queue.Contains(nums[i]))
                {
                    queue.Enqueue(nums[i]);

                    if (queue.Count <= k)
                    {
                        currentSum += nums[i];
                    }
                    else
                    {
                        currentSum -= queue.Dequeue();
                        currentSum += nums[i];
                    }
                }
                else
                {
                    queue.Enqueue(nums[i]);

                    if (queue.Count <= k)
                    {
                        currentSum += nums[i];
                    }
                    else
                    {
                        currentSum -= queue.Dequeue();
                        currentSum += nums[i];
                    }

                    if (currentSum > largestSum && queue.Count() == k)
                    {
                        largestSum = currentSum;
                    }
                }
            }
            return largestSum;
        }
        static void Main(string[] args)
        {
            MaxSubArraySum test = new MaxSubArraySum();
            int[] array = { 9, 9, 9, 1, 2, 3 };
            test.MaximumSubarraySum(array, 3);
        }
    }
}
