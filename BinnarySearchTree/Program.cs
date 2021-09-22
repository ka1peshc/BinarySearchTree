using System;

namespace BinnarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinaryTree<int> BT = new BinaryTree<int>();
            BT.InsertNode(56);
            BT.InsertNode(30);
            BT.InsertNode(70);
            BT.InsertNode(22);
            BT.InsertNode(40);
            BT.InsertNode(11);
            BT.InsertNode(3);
            BT.InsertNode(16);
            BT.InsertNode(60);
            BT.InsertNode(95);
            BT.InsertNode(65);
            BT.InsertNode(63);
            BT.InsertNode(67);
            Node<int> root = BT.GetRoot();
            BT.Inorder(root);
        }
    }
}
