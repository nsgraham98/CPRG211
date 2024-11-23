using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	internal class TakeEachCharFromLeftAndRight
	{
		public int TakeCharacters(string s, int k)
		{
			if (k == 0) return 0;

			int[] count = {0, 0, 0};


		}
        static void Main(string[] args)
        {
            TakeEachCharFromLeftAndRight test = new TakeEachCharFromLeftAndRight();
            Console.WriteLine(test.TakeCharacters("caaababcaa", 2));
			Console.ReadLine();
        }
    }
}
