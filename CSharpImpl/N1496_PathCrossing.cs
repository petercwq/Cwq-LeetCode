using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/path-crossing/
    /// 
    /// Given a string path, where path[i] = 'N', 'S', 'E' or 'W', each representing moving one unit north, south, east, or west, respectively. You start at the origin (0, 0) on a 2D plane and walk on the path specified by path.
    /// Return True if the path crosses itself at any point, that is, if at any time you are on a location you've previously visited. Return False otherwise.
    /// 
    /// Example 1:
    /// [<https://assets.leetcode.com/uploads/2020/06/10/screen-shot-2020-06-10-at-123929-pm.png>]
    /// Input: path = "NES"
    /// Output: false
    /// Explanation: Notice that the path doesn't cross any point more than once.
    /// 
    /// Example 2:
    /// [<https://assets.leetcode.com/uploads/2020/06/10/screen-shot-2020-06-10-at-123843-pm.png>]
    /// Input: path = "NESWW"
    /// Output: true
    /// Explanation: Notice that the path visits the origin twice.
    /// 
    /// 
    /// Constraints:
    /// * 1 <= path.length <= 10^4
    /// * path will only consist of characters in {'N', 'S', 'E', 'W}
    /// 
    /// </summary>
    public class N1496_PathCrossing
    {
        public class Solution1 {
            public bool IsPathCrossing(string path) {
                throw new NotImplementedException();
            }
        }
    }
}