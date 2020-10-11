using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/edit-distance/
    /// 
    /// Given two words word1 and word2, find the minimum number of operations required to convert word1 to word2.
    /// You have the following 3 operations permitted on a word:
    /// 1. Insert a character
    /// 2. Delete a character
    /// 3. Replace a character
    /// Example 1:
    /// Input: word1 = "horse", word2 = "ros"
    /// Output: 3
    /// Explanation: horse -> rorse (replace 'h' with 'r') rorse -> rose (remove 'r') rose -> ros (remove 'e')
    /// 
    /// Example 2:
    /// Input: word1 = "intention", word2 = "execution"
    /// Output: 5
    /// Explanation: intention -> inention (remove 't') inention -> enention (replace 'i' with 'e') enention -> exention (replace 'n' with 'x') exention -> exection (replace 'n' with 'c') exection -> execution (insert 'u')
    /// 
    /// </summary>
    public class N0072_EditDistance
    {
        public class Solution1 {
            public int MinDistance(string word1, string word2) {
                throw new NotImplementedException();
            }
        }
    }
}