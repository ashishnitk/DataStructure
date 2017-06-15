using System;
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
            tree.Add(22);
            tree.Add(10);
            tree.Add(5);
            tree.Add(1);
            tree.Add(9);
            tree.Add(12);
            tree.Add(11);
            tree.Add(19);
            tree.Add(84);
            tree.Add(48);
            tree.Add(68);
            tree.Add(25);
            tree.Add(74);
            tree.Add(33);
            tree.Add(25);
            tree.Add(47);

            BinaryTree.root.Print();
            // Get Height of the tree
            int h = tree.Height(BinaryTree.root);
            Console.WriteLine("\nHeight of the tree is "+ h.ToString());


            // level order traversal
            for (int i = 1; i <= h; i++)
            {
                tree.PrintGivenLevel(BinaryTree.root, i);
            }

            // spiral traversal

            tree.PreOrderTraversal(BinaryTree.root);
            tree.InOrderTraversal(BinaryTree.root);
            tree.PostOrderTraversal(BinaryTree.root);




            tree.GetPrint2DUtil();

        }
    }
}
