using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return false;

            // hare and tortoise approach
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (slow.next == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;


            //ListNode redirectedNode = head;


            //while (redirectedNode != null)
            //{
            //    if (redirectedNode.next == head)
            //    {
            //        return true;
            //    }
            //    ListNode tempNode = redirectedNode.next;
            //    redirectedNode.next = head;
            //    redirectedNode = tempNode;
            //}
            //return false;
        }
    }
}
