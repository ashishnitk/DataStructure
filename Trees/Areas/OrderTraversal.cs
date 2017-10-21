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
        #region OrderTraversal
        internal void PrintGivenLevel(Node root, int level, bool flag)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.WriteLine(root.data);
            else if (level > 1)
            {
                if (flag)
                {
                    PrintGivenLevel(root.left, level - 1, flag);
                    PrintGivenLevel(root.right, level - 1, flag);
                }
                else
                {
                    PrintGivenLevel(root.right, level - 1, flag);
                    PrintGivenLevel(root.left, level - 1, flag);
                }

            }
        }

        internal void PreOrderTraversal(Node root)
        {
            Console.WriteLine(root.data);

            if (root.left != null)
                PreOrderTraversal(root.left);
            if (root.right != null)
                PreOrderTraversal(root.right);
        }

        internal void InOrderTraversal(Node root)
        {
            if (root.left != null)
                InOrderTraversal(root.left);
            Console.WriteLine(root.data);

            if (root.right != null)
                InOrderTraversal(root.right);
        }

        internal void PostOrderTraversal(Node root)
        {
            if (root.left != null)
                PostOrderTraversal(root.left);
            if (root.right != null)
                PostOrderTraversal(root.right);
            Console.WriteLine(root.data);
        }
        #endregion
    }
}
