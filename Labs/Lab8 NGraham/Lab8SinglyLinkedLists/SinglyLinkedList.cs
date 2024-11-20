using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab8SinglyLinkedLists.Program;

namespace Lab8SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        Node head;
        Node tail;

        public SinglyLinkedList()
        {
            Head = Tail = null;
        }

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }

        public void InsertFirst(Node newNode)
        {
            if (IsEmpty())
            {
                head = tail = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;
        }
        public void InsertLast(Node newNode)
        {
            if (IsEmpty())
            {
                head = tail = newNode;
                return;
            }
            tail.Next = newNode;
            tail = newNode;
        }

        public Node GetLastNode()
        {
            if (IsEmpty()) { throw new Exception("Error. Linked List is empty"); }

            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (tempNode.Next == null)
                {
                    tail = tempNode;
                    return tail;
                }
            }
            return tail;
        }

        public void InsertAfter(object data, Node previousNode)
        {
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (previousNode == tempNode)
                {
                    Node newNode = new Node(data, previousNode.Next);
                    previousNode.Next = newNode;
                    return;
                }
            }
        }

        public void DeleteNodeByKey(int key)
        {
            int count = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (count + 1 == key)
                {
                    tempNode.Next = tempNode.Next.Next;
                }
                count++;
            }
        }

        public void ReverseLinkedList()
        {
            List<Node> list = new List<Node>();

            for (Node node = head; node != null; node = node.Next)
            {
                list.Add(node);
            }

            head = tail = list[list.Count() - 1];

            for (int i = list.Count() - 2; i <= 0; i--)
            {
                InsertLast(list[i]);
            }

        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}