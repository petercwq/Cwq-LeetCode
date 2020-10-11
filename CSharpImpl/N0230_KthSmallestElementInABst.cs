using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    /// 
    /// Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.
    /// 
    /// Example 1:
    /// Input: root = [3,1,4,null,2], k = 1 3 / \ 1 4 \
    /// 2
    /// Output: 1
    /// 
    /// Example 2:
    /// Input: root = [5,3,6,2,4,null,null,1], k = 3 5 / \ 3 6 / \ 2 4 / 1
    /// Output: 3
    /// 
    /// Follow up:
    /// What if the BST is modified (insert/delete operations) often and you need to find the kth smallest frequently? How would you optimize the kthSmallest routine?
    /// 
    /// Constraints:
    /// * The number of elements of the BST is between 1 to 10^4.
    /// * You may assume k is always valid, 1 ≤ k ≤ BST's total elements.
    /// 
    /// </summary>
    public class N0230_KthSmallestElementInABst
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
            public int KthSmallest(TreeNode root, int k) {
                throw new NotImplementedException();
            }
        }
    }
}