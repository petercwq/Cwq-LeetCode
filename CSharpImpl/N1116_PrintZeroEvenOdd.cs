using System;
using System.Collections.Generic;

namespace CSharpImpl
{
    /// <summary>
    /// link: https://leetcode.com/problems/print-zero-even-odd/
    /// 
    /// Suppose you are given the following code:
    /// class ZeroEvenOdd {
    /// public ZeroEvenOdd(int n) { ... }  // constructor public void zero(printNumber) { ... } // only output 0's public void even(printNumber) { ... } // only output even numbers public void odd(printNumber) { ... } // only output odd numbers
    /// }
    /// 
    /// The same instance of ZeroEvenOdd will be passed to three different threads:
    /// 1. Thread A will call zero() which should only output 0's.
    /// 2. Thread B will call even() which should only ouput even numbers.
    /// 3. Thread C will call odd() which should only output odd numbers.
    /// Each of the threads is given a printNumber method to output an integer. Modify the given program to output the series 010203040506... where the length of the series must be 2n.
    /// 
    /// Example 1:
    /// Input: n = 2
    /// Output: "0102"
    /// Explanation: There are three threads being fired asynchronously. One of them calls zero(), the other calls even(), and the last one calls odd(). "0102" is the correct output.
    /// 
    /// Example 2:
    /// Input: n = 5
    /// Output: "0102030405"
    /// 
    /// </summary>
    public class N1116_PrintZeroEvenOdd
    {
        public class ZeroEvenOdd {
            private int n;
            
            public ZeroEvenOdd(int n) {
                this.n = n;
            }
        
            // printNumber(x) outputs "x", where x is an integer.
            public void Zero(Action<int> printNumber) {
                throw new NotImplementedException();
            }
        
            public void Even(Action<int> printNumber) {
                throw new NotImplementedException();
            }
        
            public void Odd(Action<int> printNumber) {
                throw new NotImplementedException();
            }
        }
    }
}