using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod8
{
    public class Node
    {
        object element;
        Node successor;

        public Node(object o)
        {
            Element = o;
        }
        public Node(object element, Node successor)
        {
            Element = element;
            Successor = successor;
        }

        public object Element { get => element; set => element = value; }
        public Node Successor { get => successor; set => successor = value; }
    }
}
