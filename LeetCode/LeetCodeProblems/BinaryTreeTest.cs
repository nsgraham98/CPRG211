using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCodeProblems
{
    public class BinNode
    {
        public int data;
        public BinNode left, right;

        public BinNode(int v)
        {
            data = v;
            left = right = null;
        }
    }
    internal class BinaryTreeTest
    {
        // Function to print inorder traversal
        // left -> root -> right
        public static void printInorder(BinNode node)
        {
            if (node == null)
                return;

            // First recur on left subtree
            printInorder(node.left);

            // Now deal with the node
            Console.Write(node.data + " ");

            // Then recur on right subtree
            printInorder(node.right);
        }

// =============================================================
        // Function to print preorder traversal
        // root -> left -> right
        public static void printPreorder(BinNode node)
        {
            if (node == null)
                return;

            // Deal with the node
            Console.Write(node.data + " ");

            // Recur on left subtree
            printPreorder(node.left);

            // Recur on right subtree
            printPreorder(node.right);
        }

// =============================================================
        // Function to print postorder traversal
        // left -> right -> root
        static void printPostorder(BinNode node)
        {
            if (node == null)
                return;

            // First recur on left subtree
            printPostorder(node.left);

            // Then recur on right subtree
            printPostorder(node.right);

            // Now deal with the node
            Console.Write(node.data + " ");
        }

        // =============================================================
        // Given a binary tree. Print
        // its nodes in level order using
        // array for implementing queue
        static void printLevelOrder(BinNode root)
        {
            Queue<BinNode> queue = new Queue<BinNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {

                BinNode curr = queue.Dequeue();
                Console.Write(curr.data + " ");

                // Enqueue left child
                if (curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }

                // Enqueue right child
                if (curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
        }

            // Print nodes at the current level
            static void printCurrentLevel(BinNode root,
                                              int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data + " ");
            }
            else if (level > 1)
            {
                printCurrentLevel(root.left, level - 1);
                printCurrentLevel(root.right, level - 1);
            }
        }
        // Driver code
        public static void Main()
        {
            BinNode root = new BinNode(1);
            root.left = new BinNode(2);
            root.right = new BinNode(3);
            root.left.left = new BinNode(4);
            root.left.right = new BinNode(5);
            root.right.right = new BinNode(6);

            // Function call
            Console.WriteLine(
                "Inorder traversal of binary tree is: ");
            //printInorder(root);
            //printPreorder(root);
            //printPostorder(root);
            printLevelOrder(root);
        }
    }

}
