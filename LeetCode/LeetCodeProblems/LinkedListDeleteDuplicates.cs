using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class LinkedListDeleteDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) { return null; }
            if (head.next == null) { return head; }

            ListNode tempNode = head;

            while (tempNode.next != null)
            {
                while (tempNode.next.val == tempNode.val)
                {
                    if (tempNode.next.next != null)
                    {
                        tempNode.next = tempNode.next.next;
                    }
                    else
                    {
                        tempNode.next = null;
                        return head;
                    }
                }
                tempNode = tempNode.next;
            }          
            return head;
        }

        ListNode node;
        static void Main(string[] args)
        {
            ListNode l5 = new ListNode(3);
            ListNode l4 = new ListNode(3, l5);
            ListNode l3 = new ListNode(2, l4);
            ListNode l2 = new ListNode(1, l3);
            ListNode l1 = new ListNode(1, l2);

            LinkedListDeleteDuplicates test = new LinkedListDeleteDuplicates();
            ListNode testnode = test.DeleteDuplicates(l1);
            do
            {
                Console.WriteLine(testnode.val);
                testnode = testnode.next;
            }
            while (testnode != null);

            Console.ReadLine();
        }
    }
}
