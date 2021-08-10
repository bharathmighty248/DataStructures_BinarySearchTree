using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_BinarySearchTree
{
    public class MyBinaryNode<T> where T:IComparable
    {
        public INode<T> root;
        public void Add(T data)
        {
            INode<T> newNode = new INode<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> current = root;
                INode<T> parent;
                while (true)
                {
                    parent = current;
                    if(current.data.CompareTo(data) > 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void Display(INode<T> root)
        {
            if (root != null)
            {
                Display(root.left);
                Console.Write(root.data + " ");
                Display(root.right);
            }
        }
    }
    
}
