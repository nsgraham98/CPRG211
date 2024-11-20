using Lab8SinglyLinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Tests
{
    public class Lab8LinkedListTests
    {
        private SinglyLinkedList sll = new SinglyLinkedList();

        [SetUp]
        public void Setup()
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

            sll.Head = n1;
            sll.Tail = n5;
        }

        [Test]
        public void TestInsertFirst()
        {
            Node testNode = new Node(10);
            sll.InsertFirst(testNode);

            Assert.That(sll.Head.Data, Is.EqualTo(10));

            // 10, 1, 2, 3, 4, 5
        }

        [Test]
        public void TestInsertLast()
        {
            Node testNode = new Node(20);
            sll.InsertLast(testNode);

            Assert.That(sll.Tail.Data, Is.EqualTo(20));

            // 1, 2, 3, 4, 5, 20
        }

        [Test]
        public void TestGetLastNode()
        {
            Node node = sll.GetLastNode();

            Assert.That(node.Data, Is.EqualTo(5));

            // 1, 2, 3, 4, 5
        }

        [Test]
        public void TestInsertAfter()
        {
            Node testNode = new Node(30);
            sll.InsertAfter(30, sll.Head);

            Assert.That(sll.Head.Next.Data, Is.EqualTo(30));

            // 1, 30, 2, 3, 4, 5
        }

        [Test]
        public void TestDeleteNodeByKey()
        {
            sll.DeleteNodeByKey(1);

            Assert.That(sll.Head.Next.Data, Is.EqualTo(3));

            //1, 2, 3, 4, 5, 20
        }

        public void TestReverseLinkedList()
        {
            sll.ReverseLinkedList();

            Assert.That(sll.Head.Data, Is.EqualTo(5));
            Assert.That(sll.Head.Next.Data, Is.EqualTo(4));
            Assert.That(sll.Head.Next.Next.Data, Is.EqualTo(3));
            Assert.That(sll.Head.Next.Next.Next.Data, Is.EqualTo(2));
            Assert.That(sll.Head.Next.Next.Next.Next.Data, Is.EqualTo(1));


            // 5, 4, 3, 2, 1
        }


    }
}
