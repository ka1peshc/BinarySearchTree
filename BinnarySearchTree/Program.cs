using System;

namespace BinnarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinaryTree<int> BT = new BinaryTree<int>();
            BT.InsertNode(56,BT.GetRoot());
            BT.InsertNode(30, BT.GetRoot());
            BT.InsertNode(70, BT.GetRoot());
            BT.InsertNode(22, BT.GetRoot());
            BT.InsertNode(40, BT.GetRoot());
            BT.InsertNode(11, BT.GetRoot());
            BT.InsertNode(3, BT.GetRoot());
            BT.InsertNode(16, BT.GetRoot());
            BT.InsertNode(60, BT.GetRoot());
            BT.InsertNode(95, BT.GetRoot());
            BT.InsertNode(65, BT.GetRoot());
            BT.InsertNode(63, BT.GetRoot());
            BT.InsertNode(67, BT.GetRoot());
            Node<int> root = BT.GetRoot();
            BT.Inorder(root);
            BT.PreOrder(root);
            BT.PostOrder(root);
        }
    }
}
