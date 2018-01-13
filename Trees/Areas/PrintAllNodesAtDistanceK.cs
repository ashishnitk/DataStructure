using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Models;

namespace Trees.Areas
{
    partial class BinaryTree
    {

        internal int PrintkDistanceNode(Node node, Node target, int k)
        {
            if (node == null)
                return -1;

            if (node == target)
            {
                // if target is same as root use the downward function to print all nodes at 
                // distance k in subtree rooted with target root
                PrintkDistanceNodeDown(node, k);
                return 0;
            }

            //recur for left subtree
            int dl = PrintkDistanceNode(node.left, target, k);

            // check if target node was found in left subtree
            if (dl != -1)
            {
                // if root is at distance k from target, print root
                // note that dl is distance of root's left child from target
                if (dl + 1 == k)
                {
                    Console.WriteLine(node.data + Environment.NewLine);
                }
                else // go to right subtree and print all k-dl-2 distant nodes
                {
                    PrintkDistanceNodeDown(node.right, k - dl - 2);
                }
                return 1 + dl;
            }
            // MIRROR OF ABOVE CODE FOR RIGHT SUBTREE
            // Note that we reach here only when node was not found in left 
            // subtree
            int dr = PrintkDistanceNode(node.right, target, k);
            if (dr != -1)
            {
                if (dr + 1 == k)
                {
                    Console.WriteLine(node.data + Environment.NewLine);
                }
                else
                    PrintkDistanceNodeDown(node.left, k - dr - 2);
                return 1 + dr;
            }

            // If target was neither present in left nor in right subtree
            return -1;
            
        }

        internal void PrintkDistanceNodeDown(Node root1, int k)
        {
            if (root1 == null && k < 0)
            {
                return;
            }
            if (k == 0)
            {
                Console.WriteLine(root1.data);
                Console.WriteLine(Environment.NewLine);
            }
            PrintkDistanceNodeDown(root.left, k - 1);
            PrintkDistanceNodeDown(root.right, k - 1);
        }
    }
}
