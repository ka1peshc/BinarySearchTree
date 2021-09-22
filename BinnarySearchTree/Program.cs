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
            
            Node<int> root = BT.GetRoot();
            BT.Inorder(root);
        }
    }
}
