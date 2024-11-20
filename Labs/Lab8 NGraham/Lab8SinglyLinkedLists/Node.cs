using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8SinglyLinkedLists
{
    public class Node
    {
        object data;
        Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public Node(object data)
        {
            Data = data;
        }

        public object Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }
    }
}
