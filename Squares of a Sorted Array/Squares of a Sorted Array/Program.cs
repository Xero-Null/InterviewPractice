using System;
using System.Collections.Generic;

/*
    Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.

    Example 1:
    Input: [-4,-1,0,3,10]
    Output: [0,1,9,16,100]

    Example 2:
    Input: [-7,-3,2,3,11]
    Output: [4,9,9,49,121]

    Results: Runtime: 308 ms, faster than 89.71% of C# online submissions for Squares of a Sorted Array.
             Memory Usage: 41.8 MB, less than 8.57% of C# online submissions for Squares of a Sorted Array.
 */

namespace Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            Console.WriteLine("Result: [" + res[0] + ", " + res[1] + ", " + res[2] + ", " + res[3] + ", " + res[4] + "]");

            res = SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            Console.WriteLine("Result: [" + res[0] + ", " + res[1] + ", " + res[2] + ", " + res[3] + ", " + res[4] + "]");

            Console.ReadLine();
        }

        public static int[] SortedSquares(int[] A)
        {
            List<int> sqrList = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                sqrList.Add(Math.Abs(A[i] * A[i]));
            }

            sqrList.Sort((a,b) => a.CompareTo(b));

            return sqrList.ToArray();
        }
    }
}
