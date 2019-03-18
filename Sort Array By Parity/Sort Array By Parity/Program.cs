using System;
using System.Collections.Generic;

/*
 Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

    You may return any answer array that satisfies this condition.

    Example 1:
    Input: [3,1,2,4]
    Output: [2,4,3,1]
    The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.

    Results: Runtime: 260 ms, faster than 87.21% of C# online submissions for Sort Array By Parity.
             Memory Usage: 31.7 MB, less than 96.05% of C# online submissions for Sort Array By Parity.
 */

namespace Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res = SortArrayByParity(new int[] { 3, 1, 2, 4 });
            Console.WriteLine("Res: [" + res[0] + ", " + res[1] + ", " + res[2] + ", " + res[3] + "]");

            Console.ReadLine();
        }

        public static int[] SortArrayByParity(int[] A)
        {
            Array.Sort(A, (a, b) => (a % 2).CompareTo(b % 2));
            return A;
        }
    }
}
