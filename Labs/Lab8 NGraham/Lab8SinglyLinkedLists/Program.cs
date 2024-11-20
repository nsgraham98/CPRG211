using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8SinglyLinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);    
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            SinglyLinkedList sll = new SinglyLinkedList();
            sll.Head = n1;
            sll.Tail = n5;

            for (Node node = n1; node.Next != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            Node newFirstNode = new Node("test first node");
            sll.InsertFirst(newFirstNode);

            Node newLastNode = new Node("test last node");
            sll.InsertLast(newLastNode);

            Console.WriteLine("Getting last node: ");
            Console.WriteLine(sll.GetLastNode().Data);




            Console.ReadLine();
        }
    }
}
