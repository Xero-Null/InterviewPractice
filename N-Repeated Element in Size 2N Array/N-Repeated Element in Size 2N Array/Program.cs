using System;
using System.Collections.Generic;

/*
 In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.

    Return the element repeated N times.

    Example 1:

    Input: [1,2,3,3]
    Output: 3
    Example 2:

    Input: [2,1,2,5,3,2]
    Output: 2
    Example 3:

    Input: [5,1,5,2,5,3,5,4]
    Output: 5

    Results: Runtime: 124 ms, faster than 98.57% of C# online submissions for N-Repeated Element in Size 2N Array.
             Memory Usage: 30.7 MB, less than 81.82% of C# online submissions for N-Repeated Element in Size 2N Array.
 */


namespace N_Repeated_Element_in_Size_2N_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repeated Times: " + RepeatedNTimes(new int[] { 1, 2, 3, 3 }));
            Console.WriteLine("Repeated Times: " + RepeatedNTimes(new int[] { 2, 1, 2, 5, 3, 2 }));
            Console.WriteLine("Repeated Times: " + RepeatedNTimes(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }));

            Console.ReadLine();
        }

        public static int RepeatedNTimes(int[] A)
        {
            if (A.Length == 0)
                return 0;

            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (hash.Contains(A[i]))
                {
                    return A[i];
                }
                else
                {
                    hash.Add(A[i]);
                }
            }

            return 0;
        }
    }
}
