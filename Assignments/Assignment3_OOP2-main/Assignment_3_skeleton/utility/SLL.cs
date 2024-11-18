using Assignment_3_skeleton.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    
    public class SLL : LinkedListADT
    {
        Node head;
        Node tail;

        public SLL()
        {
            Head = Tail = null;
        }

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }

        public void Append(object data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                head = tail = newNode;
                return;
            }
            
            tail.Next = newNode;
            tail = newNode;
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(object data)
        {
            if (IsEmpty())
            {  return false; }

            Node comparisonNode = Head;
            Node targetNode = new Node(data);

            do
            {
                if (comparisonNode.Data.Equals(targetNode.Data))
                { 
                    return true;
                }
                comparisonNode = comparisonNode.Next;
            }
            while (comparisonNode.Next != null);

            return false;
        }

        public void Delete(int index)
        {
            if (IsEmpty()) { return; }
            if (index == 0) { head = head.Next; }

            int previousNodeIndex = 1;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (previousNodeIndex == index)
                {
                    tempNode.Next = tempNode.Next.Next;
                    return;
                }
                else { previousNodeIndex++; }
            }
        }

        public int IndexOf(object data)
        {
            if (IsEmpty()) { throw new Exception("List is empty"); }

            int index = 0;
            Node targetNode = new Node(data);
            Node comparisonNode = head;
            
            do
            {
                if (comparisonNode.Data.Equals(targetNode.Data))
                {
                    return index;
                }
                else
                {
                    comparisonNode = comparisonNode.Next;
                    index++;
                }
            }
            while (comparisonNode.Next != null);

            throw new Exception("Item not in List");
        }

        public void Insert(object data, int index)
        {
            if (IsEmpty()) { throw new Exception("Invalid index, List is empty"); }
            if (index == 0)
            {
                Prepend(data);
            }

            int previousNodeIndex = 1;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (previousNodeIndex == index)
                {
                    Node newNode = new Node(data, tempNode.Next);
                    tempNode.Next = newNode;
                    return;
                }
                else { previousNodeIndex++; }
            }

            throw new Exception("Index outside of range");
        }


        public bool IsEmpty()
        {
            if (head == null) { 
                return true; }
            else { 
                return false; }
        }

        public void Prepend(object data)
        {
            if (IsEmpty())
            {
                head = tail = new Node(data);
                return;
            }
            Node newNode = new Node(data, head);
            head = newNode;
        }

        public void Replace(object data, int index)
        {
            if (IsEmpty()) { throw new Exception("Invalid index, List is empty"); }
            if (index == 0)
            {
                Node newNode = new Node(data, head.Next);
                head = newNode;
            }

            int previousNodeIndex = 1;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (previousNodeIndex == index)
                {
                    Node newNode = new Node(data, tempNode.Next.Next);
                    tempNode.Next = newNode;
                    return;
                }
                else { previousNodeIndex++; }
            }

            throw new Exception("Index outside of range");
        }

        public object Retrieve(int index)
        {
            if (IsEmpty()) { throw new Exception("Invalid index, List is empty"); }
            if (index == 0)
            {
                return head.Data;
            }

            int currentIndex = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (currentIndex == index)
                {
                    return tempNode.Data;
                }
                else { currentIndex++; }
            }
            throw new Exception("Index outside of range");
        }

        public int Size()
        {
            if (IsEmpty()) {  return 0; }

            Node tempNode = head;
            int size = 1;
            while (tempNode.Next != null)
            {
                size++;
                tempNode = tempNode.Next;
            }
            return size;
        }
    }
}
