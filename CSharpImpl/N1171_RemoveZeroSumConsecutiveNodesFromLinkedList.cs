using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/
    /// 
    /// Given the head of a linked list, we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.
    /// After doing so, return the head of the final linked list.  You may return any such answer.
    /// 
    /// (Note that in the examples below, all sequences are serializations of ListNode objects.)
    /// Example 1:
    /// Input: head = [1,2,-3,3,1]
    /// Output: [3,1]
    /// Note: The answer [1,2,1] would also be accepted.
    /// 
    /// Example 2:
    /// Input: head = [1,2,3,-3,4]
    /// Output: [1,2,4]
    /// 
    /// Example 3:
    /// Input: head = [1,2,3,-3,-2]
    /// Output: [1]
    /// 
    /// 
    /// Constraints:
    /// * The given linked list will contain between 1 and 1000 nodes.
    /// * Each node in the linked list has -1000 <= node.val <= 1000.
    /// 
    /// </summary>
    public class N1171_RemoveZeroSumConsecutiveNodesFromLinkedList
    {
        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */
        public class Solution1 {
            public ListNode RemoveZeroSumSublists(ListNode head) {
                throw new NotImplementedException();
            }
        }
    }
}