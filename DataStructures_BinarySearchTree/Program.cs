using System;

namespace DataStructures_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryNode<int> tree = new DataStructures_BinarySearchTree.MyBinaryNode<int>();
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            tree.Display(tree.root);
        }
    }
}
