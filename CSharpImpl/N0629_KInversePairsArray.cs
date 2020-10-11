using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/k-inverse-pairs-array/
    /// 
    /// Given two integers n and k, find how many different arrays consist of numbers from 1 to n such that there are exactly k inverse pairs.
    /// We define an inverse pair as following: For i_th and j_th element in the array, if i < j and a[i] > a[j] then it's an inverse pair; Otherwise, it's not.
    /// Since the answer may be very large, the answer should be modulo 10^9 + 7.
    /// Example 1:
    /// Input: n = 3, k = 0
    /// Output: 1
    /// Explanation: Only the array [1,2,3] which consists of numbers from 1 to 3 has exactly 0 inverse pair.
    /// 
    /// 
    /// Example 2:
    /// Input: n = 3, k = 1
    /// Output: 2
    /// Explanation: The array [1,3,2] and [2,1,3] have exactly 1 inverse pair.
    /// 
    /// 
    /// Note:
    /// 1. The integer n is in the range [1, 1000] and k is in the range [0, 1000].
    /// 
    /// 
    /// </summary>
    public class N0629_KInversePairsArray
    {
        public class Solution1 {
            public int KInversePairs(int n, int k) {
                throw new NotImplementedException();
            }
        }
    }
}