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
            tree.Add(10);
            tree.Add(5);
            tree.Add(1);
            tree.Add(9);
            tree.Add(12);
            tree.Add(22);
            tree.Add(11);
            
           
            // Get Height of the tree
            int h =tree.Height(BinaryTree.root);


            // level order traversal
            for (int i = 1; i <= h; i++)
            {
                tree.PrintGivenLevel(BinaryTree.root,i);
            }

            tree.PreOrderTraversal(BinaryTree.root);
            tree.InOrderTraversal(BinaryTree.root);
            tree.PostOrderTraversal(BinaryTree.root);


           

            tree.GetPrint2DUtil();
            
        }
    }
}
