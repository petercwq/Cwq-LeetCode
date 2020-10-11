using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/check-if-word-is-valid-after-substitutions/
    /// 
    /// Given a string s, determine if it is valid.
    /// A string s is valid if, starting with an empty string t = "", you can transform t into s after performing the following operation any number of times:
    /// * Insert string "abc" into any position in t. More formally, t becomes t_left + "abc" + t_right, where t == t_left + t_right. Note that t_left and t_right may be empty.
    /// Return true if s is a valid string, otherwise, return false.
    /// 
    /// Example 1:
    /// Input: s = "aabcbc"
    /// Output: true
    /// Explanation:
    /// "" -> "abc" -> "aabcbc"
    /// Thus, "aabcbc" is valid.
    /// 
    /// Example 2:
    /// Input: s = "abcabcababcc"
    /// Output: true
    /// Explanation:
    /// "" -> "abc" -> "abcabc" -> "abcabcabc" -> "abcabcababcc"
    /// Thus, "abcabcababcc" is valid.
    /// 
    /// Example 3:
    /// Input: s = "abccba"
    /// Output: false
    /// Explanation: It is impossible to get "abccba" using the operation.
    /// 
    /// Example 4:
    /// Input: s = "cababc"
    /// Output: false
    /// Explanation: It is impossible to get "cababc" using the operation.
    /// 
    /// 
    /// Constraints:
    /// * 1 <= s.length <= 2 * 10^4
    /// * s consists of letters 'a', 'b', and 'c'
    /// 
    /// </summary>
    public class N1003_CheckIfWordIsValidAfterSubstitutions
    {
        public class Solution1 {
            public bool IsValid(string s) {
                throw new NotImplementedException();
            }
        }
    }
}