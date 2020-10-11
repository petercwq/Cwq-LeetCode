using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
    /// 
    /// Given the root of a binary tree, find the maximum value V for which there exists different nodes A and B where V = |A.val - B.val| and A is an ancestor of B.
    /// (A node A is an ancestor of B if either: any child of A is equal to B, or any child of A is an ancestor of B.)
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/09/09/2whqcep.jpg>]
    /// Input: [8,3,10,1,6,null,14,null,null,4,7,13]
    /// Output: 7
    /// Explanation: We have various ancestor-node differences, some of which are given below :
    /// |8 - 3| = 5
    /// |3 - 7| = 4
    /// |8 - 1| = 7
    /// |10 - 13| = 3
    /// Among all possible differences, the maximum value of 7 is obtained by |8 - 1| = 7.
    /// 
    /// 
    /// Note:
    /// 1. The number of nodes in the tree is between 2 and 5000.
    /// 2. Each node will have value between 0 and 100000.
    /// 
    /// </summary>
    public class N1026_MaximumDifferenceBetweenNodeAndAncestor
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
            public int MaxAncestorDiff(TreeNode root) {
                throw new NotImplementedException();
            }
        }
    }
}