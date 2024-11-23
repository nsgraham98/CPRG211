using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Recursion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Lab test = new Lab();

            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");
			int n = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("Enter number m: ");
			int m = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(test.Sum(n, m));

            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");

			int d = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Total number of divisions: {test.Divide(d)}");

			Console.ReadLine();
		}
	}
	public class Lab
	{
		public int sum;
		public int divCount;
		public int Sum(int n, int m)
		{
			if (n <= m)
			{
				sum += n;
				n++;
				Sum(n, m);
			}
			return sum;
		}
		public int Divide(int n)
		{
			if (n % 2 == 0)
			{
				n = n / 2;
				divCount++;
				Divide(n);
			}
			return divCount;
		}
	}
}
