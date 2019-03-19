using System;

/*
    Given a binary matrix A, we want to flip the image horizontally, then invert it, and return the resulting image.

    To flip an image horizontally means that each row of the image is reversed.  For example, flipping [1, 1, 0] horizontally results in [0, 1, 1].

    To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0. For example, inverting [0, 1, 1] results in [1, 0, 0].

    Example 1:

    Input: [[1,1,0],[1,0,1],[0,0,0]]
    Output: [[1,0,0],[0,1,0],[1,1,1]]
    Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
    Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]

    Results: Runtime: 252 ms, faster than 99.15% of C# online submissions for Flipping an Image.
             Memory Usage: 30 MB, less than 98.21% of C# online submissions for Flipping an Image.
 */

namespace Flipping_an_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ex1 = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 }, new int[] { 0, 0, 0 } };

            int[][] res = FlipAndInvertImage(ex1);
            Console.WriteLine("res: [[" + res[0][0] + ", " + res[0][1] + ", " + res[0][2] + "], [" + res[1][0] + ", " + res[1][1] + ", " + res[1][2] + "], [" + res[2][0] + ", " + res[2][1] + ", " + res[2][2] + "]]");

            Console.ReadLine();
        }

        public static int[][] FlipAndInvertImage(int[][] A)
        {
            if ((A.Length == 0) || (A[0].Length == 0)) return A;

            int[][] res = new int[A.Length][];
            int posX = 0;
            for (int i = 0; i < A.Length; i++)
            {
                res[i] = new int[A[i].Length];
                posX = A[i].Length;
                for (int j = 0; j < A[i].Length; j++)
                {
                    res[i][j] = (A[i][--posX] == 1 ? 0 : 1);
                }
            }

            return res;
        }
    }
}
