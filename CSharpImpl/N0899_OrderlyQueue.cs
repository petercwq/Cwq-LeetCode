using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/orderly-queue/
    /// 
    /// A string S of lowercase letters is given.  Then, we may make any number of moves.
    /// In each move, we choose one of the first K letters (starting from the left), remove it, and place it at the end of the string.
    /// Return the lexicographically smallest string we could have after any number of moves.
    /// 
    /// 
    /// Example 1:
    /// Input: S = "cba", K = 1
    /// Output: "acb"
    /// Explanation: In the first move, we move the 1st character ("c") to the end, obtaining the string "bac". In the second move, we move the 1st character ("b") to the end, obtaining the final result "acb".
    /// 
    /// Example 2:
    /// Input: S = "baaca", K = 3
    /// Output: "aaabc"
    /// Explanation: In the first move, we move the 1st character ("b") to the end, obtaining the string "aacab". In the second move, we move the 3rd character ("c") to the end, obtaining the final result "aaabc".
    /// 
    /// 
    /// Note:
    /// 1. 1 <= K <= S.length <= 1000
    /// 2. S consists of lowercase letters only.
    /// 
    /// 
    /// </summary>
    public class N0899_OrderlyQueue
    {
        public class Solution1 {
            public string OrderlyQueue(string S, int K) {
                throw new NotImplementedException();
            }
        }
    }
}