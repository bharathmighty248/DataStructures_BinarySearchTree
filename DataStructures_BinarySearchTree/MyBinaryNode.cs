using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_BinarySearchTree
{
    public class MyBinaryNode<T> where T:IComparable
    {
        public INode<T> root;
        
        /// <summary>
        /// This Method is For Adding Elements to BST
        /// </summary>
        /// <param name="data"></param>
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

        /// <summary>
        /// This Method is For Displaying The BST
        /// </summary>
        /// <param name="root"></param>
        public void Display(INode<T> root)
        {
            if (root != null)
            {
                Display(root.left);
                Console.Write(root.data + " ");
                Display(root.right);
            }
        }

        /// <summary>
        /// This Method is For Finding Size of BST
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }

        /// <summary>
        /// This Method is For Checking All Are Added or Not
        /// </summary>
        /// <param name="size"></param>
        public void Check(int size)
        {
            if (size==13)
                Console.WriteLine("\nAll Are Added");
            else
                Console.WriteLine("\nSomething Missing..Please Add All Elements Shown in Figure..");

        }

        public bool check = false;
        /// <summary>
        /// This Method Is For Searching Element in BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Search(INode<int> root, int key)
        {
            if (root == null)
            {
                return check;
            }
            Search(root.left, key);
            if (root.data == key)
                return check = true;
            Search(root.right, key);
            if (root.data == key)
                return check = true;
            return check;
        }
    }
    
}
