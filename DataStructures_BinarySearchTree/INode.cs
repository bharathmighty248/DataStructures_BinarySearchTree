using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_BinarySearchTree
{
    public class INode<T> where T: IComparable
    {
        public T data;
        public INode<T> left;
        public INode<T> right;
        public INode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
