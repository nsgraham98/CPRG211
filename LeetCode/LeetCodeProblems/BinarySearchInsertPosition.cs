using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class BinarySearchInsertPosition
    {
        int[] array;
        public BinarySearchInsertPosition(int[] array)
        {
            this.array = array;
        }

        public int SearchInsert(int[] nums, int target)
        {
            int index = Array.BinarySearch(nums, target);

            // check if search returns bitwise complement of the insertion point
            // ~x = -(x + 1)
            if (index < 0)
            {
                index = -(index + 1);
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 6 };
            int target = 2;
            BinarySearchInsertPosition obj = new BinarySearchInsertPosition(array);
            Console.WriteLine(obj.SearchInsert(array, target));
            Console.ReadLine();
        }
    }
}
