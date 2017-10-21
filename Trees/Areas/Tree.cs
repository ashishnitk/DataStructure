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
     
        /// <summary>
        /// Get height of the tree
        /// </summary>
        /// <returns></returns>
        public int Height(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int lheight = Height(root.left);
                int rheight = Height(root.right);

                if (lheight > rheight)
                    return (lheight + 1);
                else
                    return (rheight + 1);
            }
        }

        /// <summary> SEARCH A ITEM IN A TREE
        /// If root.data is equal to search.data
        ///   return root
        ///else
        ///   while data not found
        ///
        ///      If data is greater than node.data
        ///         goto right subtree
        ///      else
        ///         goto left subtree
        ///
        ///
        ///      If data found
        ///         return node
        ///
        ///   endwhile 
        ///   
        ///   return data not found
        ///
        ///end if  
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Search(Object data)
        {
            Node current = root;
            Console.WriteLine("Visiting element");

            while (current.data != data)
            {
                if (current != null)
                    Console.WriteLine(current.data);

                //go to left tree
                if ((int)current.data > (int)data)
                    current = current.left;
                else //else go to right tree
                    current = current.right;

                //not found
                if (current == null)
                    return null;
                return current;
            }
            return null;
        }
    }
}
