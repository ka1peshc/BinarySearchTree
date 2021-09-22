using System;
using System.Collections.Generic;
using System.Text;

namespace BinnarySearchTree
{
    class Node<T> where T:IComparable
    {
        public T data;
        public Node<T> left;
        public Node<T> right;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
