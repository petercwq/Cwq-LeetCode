using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/array-of-doubled-pairs/
    /// 
    /// Given an array of integers A with even length, return true if and only if it is possible to reorder it such that A[2 * i + 1] = 2 * A[2 * i] for every 0 <= i < len(A) / 2.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Example 1:
    /// Input: A = [3,1,3,6]
    /// Output: false
    /// 
    /// Example 2:
    /// Input: A = [2,1,2,6]
    /// Output: false
    /// 
    /// Example 3:
    /// Input: A = [4,-2,2,-4]
    /// Output: true
    /// Explanation: We can take two groups, [-2,-4] and [2,4] to form [-2,-4,2,4] or [2,4,-2,-4].
    /// 
    /// Example 4:
    /// Input: A = [1,2,4,16,8,4]
    /// Output: false
    /// 
    /// 
    /// Constraints:
    /// * 0 <= A.length <= 3 * 10^4
    /// * A.length is even.
    /// * -10^5 <= A[i] <= 10^5
    /// 
    /// </summary>
    public class N0954_ArrayOfDoubledPairs
    {
        public class Solution1 {
            public bool CanReorderDoubled(int[] A) {
                throw new NotImplementedException();
            }
        }
    }
}