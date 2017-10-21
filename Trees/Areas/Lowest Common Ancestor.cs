using System;
using Trees.Models;

namespace Trees.Areas
{
    partial class BinaryTree
    {
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
