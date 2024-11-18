using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal class LinkedListMergeTwoSorted
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            // geeks for geeks elegant solution

            //ListNode newNodeHead = null;
            ListNode newNodeTail = null;
            //bool nodeHeadExists = false;

            if (list1 == null) { return list2; }
            if (list2 == null) { return list1; }

            if (list1.val <= list2.val)
            {
                newNodeTail = list1;
                newNodeTail.next = MergeTwoLists(list1.next, list2);
            }
            else
            {
                newNodeTail = list2;
                newNodeTail.next = MergeTwoLists(list1, list2.next);
            }
            return newNodeTail;
        }

        // my long ass solution

            //while (list1 != null && list2 != null)
            //{
            //    // checking and creating NodeHead
            //    if (!nodeHeadExists)
            //    {
            //        if (list1.val <= list2.val)
            //        {
            //            newNodeHead = list1;
            //            list1 = list1.next;
            //            newNodeTail = newNodeHead;
            //            nodeHeadExists = true;
            //        }
            //        else
            //        {
            //            newNodeHead = list2;
            //            list2 = list2.next;
            //            newNodeTail = newNodeHead;
            //            nodeHeadExists = true;
            //        }
            //    }

            //    else
            //    {
            //        if (list1.val <= list2.val)
            //        {
            //            newNodeTail.next = list1;
            //            newNodeTail = newNodeTail.next;
            //            list1 = list1.next;
            //        }
            //        else
            //        {
            //            newNodeTail.next = list2;
            //            newNodeTail = newNodeTail.next;
            //            list2 = list2.next;
            //        }
            //    }                 
            //}

            //while (list1 == null ^ list2 == null)
            //{
            //    if (!nodeHeadExists)
            //    {
            //        if (list1 == null)
            //        {
            //            newNodeHead = list2;
            //            list2 = list2.next;
            //            newNodeTail = newNodeHead;
            //            nodeHeadExists = true;
            //        }
            //        else
            //        {
            //            newNodeHead = list1;
            //            list1 = list1.next;
            //            newNodeTail = newNodeHead;
            //            nodeHeadExists = true;
            //        }
            //    }
            //    else
            //    {
            //        if (list1 == null)
            //        {
            //            newNodeTail.next = list2;
            //            newNodeTail = newNodeTail.next;
            //            list2 = list2.next;
            //        }
            //        else
            //        {
            //            newNodeTail.next = list1;
            //            newNodeTail = newNodeTail.next;
            //            list1 = list1.next;
            //        }
            //    }
            //}
            //if (list1 == null && list2 == null)
            //{
            //    if (nodeHeadExists)
            //    {
            //        return newNodeHead;
            //    }
            //}
            //return list1;


        static void Main(string[] args)
        {
            ListNode l3 = new ListNode(4);
            ListNode l2 = new ListNode(2, l3);
            ListNode l1 = new ListNode(1, l2);

            ListNode l6 = new ListNode(4);
            ListNode l5 = new ListNode(3, l6);
            ListNode l4 = new ListNode(1, l5);


            LinkedListMergeTwoSorted test = new LinkedListMergeTwoSorted();
            ListNode testNode = test.MergeTwoLists(l1, l4);

            while (testNode != null)
            {
                Console.WriteLine(testNode.val);
                testNode = testNode.next;
            }

            Console.ReadLine();
        }
    }
}
