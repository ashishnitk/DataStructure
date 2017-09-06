﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Models;
namespace Trees.Areas
{

    public class BinaryTree
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


        public Node lca(Node node, int n1, int n2)
        {
            if (node == null)
                return null;

            // If both n1 and n2 are smaller than root, then LCA lies in left
            if ((int)node.data > n1 && (int)node.data > n2)
                return lca(node.left, n1, n2);

            // If both n1 and n2 are greater than root, then LCA lies in right
            if ((int)node.data < n1 && (int)node.data < n2)
                return lca(node.right, n1, n2);

            return node;

        }


    }
}
