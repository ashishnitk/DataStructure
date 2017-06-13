using System;
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
        const int COUNT = 1;
        /// <summary>
        /// Function to print binary tree in 2D
        /// It does reverse inorder traversal
        /// </summary>
        internal void GetPrint2DUtil()
        {
            Print2DUtil(root, 0);
        }

        private void Print2DUtil(Node root, int space)
        {
            if (root == null)
                return;

            // Increase distance between levels
            space += COUNT;

            // Process right child first
            Print2DUtil(root.right, space);

            // Print current node after space
            // count
            Console.WriteLine("\n");
            for (int i = COUNT; i < space; i++)
                Console.WriteLine(" ");
            Console.WriteLine(root.data + "\n");

            // Process left child
            Print2DUtil(root.left, space);

        }

        internal void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.WriteLine(root.data); 
            else if (level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
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

        /// <summary>
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


    }


}
