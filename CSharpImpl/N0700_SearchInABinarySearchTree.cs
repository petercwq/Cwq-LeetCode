using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/search-in-a-binary-search-tree/
    /// 
    /// Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
    /// For example,
    /// Given the tree: 4 / \ 2 7 / \ 1 3 And the value to search: 2
    /// 
    /// You should return this subtree:
    /// 2 / \ 1 3
    /// 
    /// In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.
    /// Note that an empty tree is represented by NULL, therefore you would see the expected output (serialized tree format) as [], not null.
    /// 
    /// </summary>
    public class N0700_SearchInABinarySearchTree
    {
        /**
         * Definition for a binary tree node.
         * public class TreeNode {
         *     public int val;
         *     public TreeNode left;
         *     public TreeNode right;
         *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         *         this.val = val;
         *         this.left = left;
         *         this.right = right;
         *     }
         * }
         */
        public class Solution1 {
            public TreeNode SearchBST(TreeNode root, int val) {
                throw new NotImplementedException();
            }
        }
    }
}