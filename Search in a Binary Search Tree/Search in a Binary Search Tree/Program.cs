using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.

    For example, 

    Given the tree:
        4
       / \
      2   7
     / \
    1   3

    And the value to search: 2

    You should return this subtree:

      2     
     / \   
    1   3


    In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.

    Note that an empty tree is represented by NULL, therefore you would see the expected output (serialized tree format) as [], not null.

    Definition for a binary tree node.
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    Results:
    Runtime: 124 ms, faster than 39.50% of C# online submissions for Search in a Binary Search Tree.
    Memory Usage: 32.1 MB, less than 17.90% of C# online submissions for Search in a Binary Search Tree.
 */

namespace Search_in_a_Binary_Search_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public void AddNode(int v)
        {
            if (v > val)
            {
                if (right == null)
                {
                    right = new TreeNode(v);
                }
                else
                {
                    AddSubNode(ref right, v);
                }
            }
            else
            {
                if (left == null)
                {
                    left = new TreeNode(v);
                }
                else
                {
                    AddSubNode(ref left, v);
                }
            }
        }

        private void AddSubNode(ref TreeNode n, int v)
        {
            if (v > n.val)
            {
                if (n.right == null)
                {
                    n.right = new TreeNode(v);
                }
                else
                {
                    AddSubNode(ref n.right, v);
                }
            }
            else
            {
                if (n.left == null)
                {
                    n.left = new TreeNode(v);
                }
                else
                {
                    AddSubNode(ref n.left, v);
                }
            }
        }
    }

    class Program
    {
        private static TreeNode
            tree;

        static void Main(string[] args)
        {
            tree = new TreeNode(4);
            tree.AddNode(2);
            tree.AddNode(7);
            tree.AddNode(1);
            tree.AddNode(3);

            TreeNode foundNode = SearchBST(tree, 2);
            if (foundNode != null)
                Console.WriteLine("Found tree [" + foundNode.val + "] with left = [" + (foundNode.left == null ? "NULL" : foundNode.left.val.ToString()) + "] and right = [" + (foundNode.right == null ? "NULL" : foundNode.right.val.ToString() + "]"));
            else
                Console.WriteLine("A node could not be found");

            Console.ReadKey();
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;

            if (val == root.val) return root;

            if (val > root.val)
                return SearchBST(root.right, val);
            else
                return SearchBST(root.left, val);
        }
    }
}
