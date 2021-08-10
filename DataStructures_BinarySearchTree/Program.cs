﻿using System;

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
            tree.Add(22);
            tree.Add(40);
            tree.Add(60);
            tree.Add(95);
            tree.Add(11);
            tree.Add(65);
            tree.Add(3);
            tree.Add(16);
            tree.Add(63);
            tree.Add(67);
            tree.Display(tree.root);
            int size = tree.Size(tree.root);
            Console.WriteLine("\n\nSize Of BST is: " + size);
            tree.Check(size);
        }
    }
}
