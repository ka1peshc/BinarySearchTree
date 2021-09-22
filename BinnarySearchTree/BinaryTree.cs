using System;
using System.Collections.Generic;
using System.Text;

namespace BinnarySearchTree
{
    class BinaryTree<T> where T:IComparable
    {
        private Node<T> root;
        //public BinaryTree()
        //{
        //    this.root = null;
        //}
        public Node<T> GetRoot()
        {
            return this.root;
        }
        internal void InsertNode(T value)
        {
            Node<T> tempRoot = this.root;
            Node<T> newNode = new Node<T>(value);

            //checking if root node is empty
            if(tempRoot == null)
            {
                this.root = newNode;
                return;
            }
            if (value.CompareTo(tempRoot.data) < 0)
            {
                if(tempRoot.left == null)
                {
                    tempRoot.left = newNode;
                    return;
                }
                tempRoot = tempRoot.left;
                InsertNode(value); 
            }
            //value greater than root data
            if (value.CompareTo(tempRoot.data) > 0)
            {
                if (tempRoot.right == null)
                {
                    tempRoot.right = newNode;
                    return;
                }
                tempRoot = tempRoot.right;
                InsertNode(value);
            }
        }

        internal void Inorder(Node<T> root)
        {
            if(root != null)
            {
                Inorder(root.left);
                Console.Write(root.data+" ");
                Inorder(root.right);
            }
        }
    }
}
