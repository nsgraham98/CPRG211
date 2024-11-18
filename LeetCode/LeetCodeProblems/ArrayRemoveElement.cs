using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class ArrayRemoveElement
    {
        int[] array;


        // Online solution (uses Lists)

        //public int RemoveElement(int[] nums, int val)
        //{
        //    List<int> numList = new List<int>(nums);
        //    numList.RemoveAll(item => item == val);
        //    numList.CopyTo(nums);
        //    return numList.Count;
        //}

        // my solution
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1 && nums[0] == val)
            {
                nums = new int[0] { };
                return 0;
            }

            int indexDecrement = nums.Length - 1;
            int indexIncrement = 0;

            while ((indexDecrement - indexIncrement) >= 0)
            {
                if (nums[indexIncrement] == val && nums[indexDecrement] != val)
                {
                    int temp = nums[indexDecrement];
                    nums[indexDecrement] = nums[indexIncrement];
                    nums[indexIncrement] = temp;
                    indexIncrement++;
                    indexDecrement--;
                    continue;
                }
                if (nums[indexIncrement] != val && nums[indexDecrement] != val)
                {
                    indexIncrement++;
                    continue;
                }
                
                if (nums[indexIncrement] == val && nums[indexDecrement] == val)
                {
                    indexDecrement--;
                    continue;
                }
                if (nums[indexIncrement] != val && nums[indexDecrement] == val)
                {
                    indexIncrement++;
                    indexDecrement--;
                    continue;
                }
            }
            return indexIncrement;
        }
        static void Main(string[] args)
        {
            ArrayRemoveElement obj = new ArrayRemoveElement();
            obj.array = new int[] { 2};
            

            Console.WriteLine(obj.RemoveElement(obj.array, 3));
            foreach (int i in obj.array)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
