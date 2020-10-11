using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/out-of-boundary-paths/
    /// 
    /// There is an m by n grid with a ball. Given the start coordinate (i,j) of the ball, you can move the ball to adjacent cell or cross the grid boundary in four directions (up, down, left, right). However, you can at most move N times. Find out the number of paths to move the ball out of grid boundary. The answer may be very large, return it after mod 10^9 + 7.
    /// 
    /// Example 1:
    /// Input: m = 2, n = 2, N = 2, i = 0, j = 0
    /// Output: 6
    /// Explanation:
    /// <https://assets.leetcode.com/uploads/2018/10/13/out_of_boundary_paths_1.png>
    /// Example 2:
    /// Input: m = 1, n = 3, N = 3, i = 0, j = 1
    /// Output: 12
    /// Explanation:
    /// <https://assets.leetcode.com/uploads/2018/10/12/out_of_boundary_paths_2.png>
    /// 
    /// Note:
    /// 1. Once you move the ball out of boundary, you cannot move it back.
    /// 2. The length and height of the grid is in range [1,50].
    /// 3. N is in range [0,50].
    /// 
    /// </summary>
    public class N0576_OutOfBoundaryPaths
    {
        public class Solution1 {
            public int FindPaths(int m, int n, int N, int i, int j) {
                throw new NotImplementedException();
            }
        }
    }
}