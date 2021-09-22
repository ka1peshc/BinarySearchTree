using System;
using System.Collections.Generic;
using System.Text;

namespace BinnarySearchTree
{
    class BinaryTree<T> where T:IComparable
    {
        private Node<T> root;
        
        public Node<T> GetRoot()
        {
            return this.root;
        }
        /// <summary>
        /// Inserting Node 
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="parent">Node</param>
        internal void InsertNode(T value, Node<T> parent)
        {
            
            Node<T> newNode = new Node<T>(value);

            //checking if root node is empty
            if(parent == null)
            {
                this.root = newNode;
                return;
            }
            //checking if value is less than parent data
            if (value.CompareTo(parent.data) < 0)
            {
                if(parent.left == null)
                {
                    parent.left = newNode;
                    return;
                }
                parent = parent.left;
                InsertNode(value,parent); 
            }
            //checking if value is greater than parent data
            if (value.CompareTo(parent.data) > 0)
            {
                if (parent.right == null)
                {
                    parent.right = newNode;
                    return;
                }
                parent = parent.right;
                InsertNode(value,parent);
            }
        }
        /// <summary>
        /// Print in pattern as child.left<--parent.data-->child.right
        /// </summary>
        /// <param name="root"></param>
        internal void Inorder(Node<T> root)
        {
            if(root != null)
            {
                Inorder(root.left);
                Console.Write(root.data+" ");
                Inorder(root.right);
            }
        }
        /// <summary>
        /// Print in pattern as child.left<--child.right<--parent
        /// </summary>
        /// <param name="root"></param>
        internal void PreOrder(Node<T> root)
        {
            if (root != null)
            {
                Console.Write(root.data + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }
        /// <summary>
        /// Print in pattern as parent-->child.left-->child.right
        /// </summary>
        /// <param name="root"></param>
        internal void PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.data + " ");
            }
        }
        /// <summary>
        /// Searching in Binary tree
        /// </summary>
        /// <param name="value">int</param>
        /// <param name="parent">Node</param>
        internal void Search(T value, Node<T> parent)
        {
            if(parent == null)
            {
                Console.WriteLine("Not found");
                return;
            }
            if(value.Equals(parent.data))
            {
                Console.WriteLine("Found value {0}", parent.data);
                return;
            }
            if (value.CompareTo(parent.data) < 0)
            {
                Search(value, parent.left);
            }
            if (value.CompareTo(parent.data) > 0)
            {
                Search(value, parent.right);
            }
        }
    }
}
