using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
	internal class AddTwoLLNums
	{
		public class Solution
		{
			int[] a1 = new int[1] { 9 };
			int[] a2 = new int[10] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

			public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
			{
				Stack<ListNode> s1 = new Stack<ListNode>();
				while (l1 != null)
				{
					s1.Push(l1);
					l1 = l1.next;
				}
				string revString1 = "";
				foreach (ListNode l in s1)
				{
					revString1 += l.val.ToString();
				}

				Stack<ListNode> s2 = new Stack<ListNode>();
				while (l2 != null)
				{
					s2.Push(l2);
					l2 = l2.next;
				}
				string revString2 = "";
				foreach (ListNode l in s2)
				{
					revString2 += l.val.ToString();
				}

				BigInteger b1 = new BigInteger(revString1);
				BigInteger b2 = new BigInteger(revString2);

				BigInteger resultInt = BigInteger.Add(b1,b2);
				string resultString = resultInt.ToString();

				int temp1 = int.Parse(resultString[0].ToString());

				ListNode head = new ListNode(int.Parse(resultString[0].ToString()));
				resultString = resultString.Substring(1);
				foreach (char c in resultString)
				{
					ListNode temp = new ListNode(int.Parse(c.ToString()), head);
					head = temp;
				}
				return head;
			}
			public class BigInteger
			{
				private List<int> digits;

				// Constructor 
				public BigInteger(string value)
				{
					digits = new List<int>();

					for (int i = value.Length - 1; i >= 0; i--)
					{
						digits.Add(int.Parse(value[i].ToString()));
					}
				}

				// Add function  in BigInteger. 
				public static BigInteger Add(BigInteger a, BigInteger b)
				{
					List<int> sum = new List<int>();
					int carry = 0;
					int i = 0;

					while (i < a.digits.Count || i < b.digits.Count)
					{
						int x = i < a.digits.Count ? a.digits[i] : 0;
						int y = i < b.digits.Count ? b.digits[i] : 0;
						int s = x + y + carry;

						sum.Add(s % 10);
						carry = s / 10;
						i++;
					}

					if (carry > 0)
					{
						sum.Add(carry);
					}

					BigInteger result = new BigInteger("");

					for (int j = sum.Count - 1; j >= 0; j--)
					{
						result.digits.Add(sum[j]);
					}

					return result;
				}
			}
			static void Main(string[] args)
			{
				Solution test = new Solution();
				ListNode l1 = new ListNode(test.a1[test.a1.Length - 1]);
				for (int i = test.a1.Length - 2; i >= 0; i--)
				{
					ListNode temp = new ListNode(test.a1[i], l1);
					l1 = temp;
				}
				ListNode l2 = new ListNode(test.a2[test.a2.Length - 1]);
				for (int i = test.a2.Length - 2; i >= 0; i--)
				{
					ListNode temp = new ListNode(test.a2[i], l2);
					l2 = temp;
				}

				Console.WriteLine(test.AddTwoNumbers(l1, l2));
				Console.ReadLine();
			}
			
		}
	}
}
