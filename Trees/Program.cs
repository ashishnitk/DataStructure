﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Areas;
using Trees.Models;
namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(2);
            tree.Add(5);
            tree.Add(1);
            tree.Add(9);
            tree.Add(12);
            tree.Add(22);
            tree.Add(12);
            tree.Add(8);
            tree.Add(7);

            tree.GetPrint2DUtil();

            // Get Height of the tree
            Console.WriteLine(tree.GetHeight());



        }
    }
}
