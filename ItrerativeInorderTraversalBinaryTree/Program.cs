using System;

namespace ItrerativeInorderTraversalBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.left = new Node(0);
            tree.left.left = new Node(5);
            tree.left.right = new Node(6);
            tree.right = new Node(-10);
            tree.right.left = new Node(11);

            IterativeInOrderTeravelsal II = new IterativeInOrderTeravelsal();
            

            Console.WriteLine(string.Join(" , " , II.IterativeInorder(tree)));
            Console.ReadLine();
        }
    }
}
