using System;

namespace Print_BST_keys_in_the_given_range
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(20);
            root.left = new Node(8);
            root.left.left = new Node(7);
            root.left.right = new Node(9);
            root.right = new Node(22);
            root.right.left = new Node(21);
            root.right.right = new Node(23);
            PrintNodeInRange(root, 6,9);
        }

        public class Node
        {
            public int val { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }
            public Node(int val = 0)
            {
                this.val = val;
                left = right = null;
            }
        }

        static void PrintNodeInRange(Node root, int k1, int k2)
        {
            if (root == null) return;

            if (root.val > k1)
            {
                PrintNodeInRange(root.left, k1, k2);
            }
            if (root.val >= k1 && root.val <= k2) Console.WriteLine(root.val);
            if (k2 > root.val)
            {
                PrintNodeInRange(root.right, k1, k2);
            }
        }
    }
}
