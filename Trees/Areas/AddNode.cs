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
        public static Node root = null;


        /// <summary> ADD ITEMS TO THE TREE
        ///If root is NULL
        ///   then create root node
        ///return
        ///  
        ///If root exists then
        ///   compare the data with node.data
        ///  
        ///   while until insertion position is located
        ///  
        ///      If data is greater than node.data
        ///         goto right subtree
        ///      else
        ///         goto left subtree
        ///  
        ///   endwhile
        ///  
        ///   insert data
        ///
        ///end If
        /// </summary>
        /// <param name="data"></param>
        public void Add(Object data)
        {
            Node tempnode = new Node() { data = data, right = null, left = null };
            Node current = null;
            Node parent = null;

            // if tree is empty, create a node
            if (root == null)
            {
                root = tempnode;
            }
            else
            {
                current = root;
                parent = null;
                while (true)
                {
                    parent = current;

                    // go to left of the tree
                    if ((int)data < (int)parent.data)
                    {
                        current = current.left;

                        // insert to the left
                        if (current == null)
                        {
                            parent.left = tempnode;
                            return;
                        }
                    }
                    // go to right of the tree
                    else
                    {
                        current = current.right;

                        // insert to the right
                        if (current == null)
                        {
                            parent.right = tempnode;
                            return;
                        }
                    }
                }
            }
        }
    }
}
