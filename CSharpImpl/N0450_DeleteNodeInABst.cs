using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/delete-node-in-a-bst/
    /// 
    /// Given a root node reference of a BST and a key, delete the node with the given key in the BST. Return the root node reference (possibly updated) of the BST.
    /// Basically, the deletion can be divided into two stages:
    /// 1. Search for a node to remove.
    /// 2. If the node is found, delete the node.
    /// Follow up: Can you solve it with time complexity O(height of tree)?
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/09/04/del_node_1.jpg>]Input: root = [5,3,6,2,4,null,7], key = 3
    /// Output: [5,4,6,2,null,null,7]
    /// Explanation: Given key to delete is 3. So we find the node with value 3 and delete it.
    /// One valid answer is [5,4,6,2,null,null,7], shown in the above BST.
    /// Please notice that another valid answer is [5,2,6,null,4,null,7] and it's also accepted.
    /// [<https://assets.leetcode.com/uploads/2020/09/04/del_node_supp.jpg>]
    /// Example 2:
    /// Input: root = [5,3,6,2,4,null,7], key = 0
    /// Output: [5,3,6,2,4,null,7]
    /// Explanation: The tree does not contain a node with value = 0.
    /// 
    /// Example 3:
    /// Input: root = [], key = 0
    /// Output: []
    /// 
    /// 
    /// Constraints:
    /// * The number of nodes in the tree is in the range [0, 10^4].
    /// * -10^5 <= Node.val <= 10^5
    /// * Each node has a unique value.
    /// * root is a valid binary search tree.
    /// * -10^5 <= key <= 10^5
    /// 
    /// </summary>
    public class N0450_DeleteNodeInABst
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
            public TreeNode DeleteNode(TreeNode root, int key) {
                throw new NotImplementedException();
            }
        }
    }
}