using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/as-far-from-land-as-possible/
    /// 
    /// Given an N x N grid containing only values 0 and 1, where 0 represents water and 1 represents land, find a water cell such that its distance to the nearest land cell is maximized and return the distance.
    /// The distance used in this problem is the Manhattan distance: the distance between two cells (x0, y0) and (x1, y1) is |x0 - x1| + |y0 - y1|.
    /// If no land or water exists in the grid, return -1.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2019/05/03/1336_ex1.JPG>]
    /// Input: [[1,0,1],[0,0,0],[1,0,1]]
    /// Output: 2
    /// Explanation: The cell (1, 1) is as far as possible from all the land with distance 2.
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2019/05/03/1336_ex2.JPG>]
    /// Input: [[1,0,0],[0,0,0],[0,0,0]]
    /// Output: 4
    /// Explanation: The cell (2, 2) is as far as possible from all the land with distance 4.
    /// 
    /// 
    /// Note:
    /// 1. 1 <= grid.length == grid[0].length <= 100
    /// 2. grid[i][j] is 0 or 1
    /// 
    /// </summary>
    public class N1162_AsFarFromLandAsPossible
    {
        public class Solution1 {
            public int MaxDistance(int[][] grid) {
                throw new NotImplementedException();
            }
        }
    }
}