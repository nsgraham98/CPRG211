using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod8
{
    public class SLL
    {
        Node head;
        Node tail;
        int size = 0;

        public bool Empty // Property -> returns true if head == null
        {
            get
            {
                return (head == null);
            }
        }

        public SLL()
        {
            Head = Tail = null;
        }

        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public int Size { get => size; set => size = value; }

        public void AddToHead(object o) 
        {
            head = new Node(o, head); // adding new node before original head -> assigning head to added node
            if (tail == null) 
            {
                tail = head;
            }
        }
        public void Append(object data)
        {
            if(!Empty)
            {
                tail.Successor = new Node(data); // new node after tail
                tail = tail.Successor;  // assigning tail away from old tail (now 2nd last node) -> assigning to new last node
            }
            else
            {
                tail = head = new Node(data); // making only existing node both head and tail
            }
        }

        // OPTIONAL
        public void Print()
        {
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Successor) // iterates through SLL
            {
                Console.WriteLine(tempNode.Element);
            }
        }
    }
}
