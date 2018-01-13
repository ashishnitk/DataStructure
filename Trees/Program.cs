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
            Node target = BinaryTree.root.right.left;
            tree.PrintkDistanceNode(BinaryTree.root,target,2);

            Node lca = tree.lca(BinaryTree.root, 25, 74);
            Console.WriteLine(lca.data);

            // Get Height of the tree
            int h = tree.Height(BinaryTree.root);
            Console.WriteLine("\nHeight of the tree is " + h.ToString());

            Console.WriteLine("\n preorder traversal \n");

            tree.PreOrderTraversal(BinaryTree.root);

            Console.WriteLine("\n Inorder traversal \n");
            tree.InOrderTraversal(BinaryTree.root);

            Console.WriteLine("\n postorder traversal \n");

            tree.PostOrderTraversal(BinaryTree.root);

            bool flag = true;
            Console.WriteLine("Level order traversal\n");
            for (int i = 1; i <= h; i++)
            {
                tree.PrintGivenLevel(BinaryTree.root, i, flag);
            }

            Console.WriteLine("Spiral traversal using level order traversal\n");
            for (int i = 1; i <= h; i++)
            {
                tree.PrintGivenLevel(BinaryTree.root, i, flag);
                flag = !flag;
            }


        }
    }
}
