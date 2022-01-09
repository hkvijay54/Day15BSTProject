using Day15Assignment_BST;
using System;

namespace day15_binary_tree
{
    class Program
    {
        //Ability to create the binary tree shown in thefigure -Check if all are added with using size method in Binary Tree
        static void Main(string[] args)
        {
            BinaryTree obj = new BinaryTree();
            obj.Insert(56);
            obj.Insert(30);
            obj.Insert(70);
            obj.Insert(22);
            obj.Insert(40);
            obj.Insert(60);
            obj.Insert(95);
            obj.Insert(11);
            obj.Insert(65);
            obj.Insert(3);
            obj.Insert(16);
            obj.Insert(63);
            obj.Insert(67);
            obj.TraversePreorder(obj.root);
            Console.WriteLine();
        }
    }
}