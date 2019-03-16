using System;
using System.Collections.Generic;

/*
    There is a brick wall in front of you.
    The wall is rectangular and has several rows of bricks.
    The bricks have the same height but different width.
    You want to draw a vertical line from the top to the bottom and cross the least bricks.

    The brick wall is represented by a list of rows.
    Each row is a list of integers representing the width of each brick in this row from left to right.

    If your line go through the edge of a brick, then the brick is not considered as crossed.
    You need to find out how to draw the line to cross the least bricks and return the number of crossed bricks.

    You cannot draw a line just along one of the two vertical edges of the wall, in which case the line will obviously cross no bricks.


    Input: [[1,2,2,1],
            [3,1,2],
            [1,3,2],
            [2,4],
            [3,1,2],
            [1,3,1,1]]

Output: 2

    Visual Example:

    *|**|**|*
    ***|*|**
    *|***|**
    **|****
    ***|*|**
    *|***|*|*
    
         ^ Least bricks 2

    Results: Runtime: 132 ms, faster than 98.21% of C# online submissions for Brick Wall.
             Memory Usage: 33.5 MB, less than 25.00% of C# online submissions for Brick Wall.

 */

namespace BrickWall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            IList<IList<int>> wall = new List<IList<int>>(new List<int[]> {
                                                                                new int[] { 1, 2, 2, 1},
                                                                                new int[] { 3, 1, 2 },
                                                                                new int[] { 1, 3, 2 },
                                                                                new int[] { 2, 4 },
                                                                                new int[] { 3, 1, 2 },
                                                                                new int[] { 1, 3, 1, 1 }
                                                                           });

            Console.WriteLine("Ex1: Lowest Brick Count: A2(" + LeastBricks(wall) + ")");

            // Example 2
            wall = new List<IList<int>>(new List<int[]> {
                                                                                new int[] { 1 },
                                                                                new int[] { 1 },
                                                                                new int[] { 1 }
                                                                           });
            Console.WriteLine("Ex2: Lowest Brick Count: A2(" + LeastBricks(wall) + ")");

            // Example 3
            wall = new List<IList<int>>(new List<int[]> {
                                                                                new int[] { 1,1 },
                                                                                new int[] { 2 },
                                                                                new int[] { 1,1 }
                                                                           });
            Console.WriteLine("Ex3: Lowest Brick Count: A2(" + LeastBricks(wall) + ")");

            // Example 4
            wall = new List<IList<int>>(new List<int[]> {
                                                                                new int[] { 100000000 },
                                                                                new int[] { 100000000 },
                                                                                new int[] { 100000000 }
                                                                           });
            Console.WriteLine("Ex4: Lowest Brick Count: A2(" + LeastBricks(wall) + ")");

            Console.ReadLine();
        }

        public static int LeastBricks(IList<IList<int>> wall)
        {
            Dictionary<int, int> edges = new Dictionary<int, int>();

            int maxEdgesPerColumn = 0,
                cIndex = 0,
                edgeCountOnRow = 0;

            for (int i = 0; i < wall.Count; i++)
            {
                cIndex = 0;
                for (int j = 0; j < wall[i].Count - 1; j++) // Iterate until 1 row from last
                {
                    cIndex += wall[i][j]; // Incriment per edge
                    edges.TryGetValue(cIndex, out edgeCountOnRow); // Check to see if there are any edges on this column index

                    if (++edgeCountOnRow > maxEdgesPerColumn) // Incriment edge count (for wall.count subtraction)
                        maxEdgesPerColumn = edgeCountOnRow; // Set highest value

                    edges[cIndex] = edgeCountOnRow; // Add edge into map
                }
            }

            return (wall.Count - maxEdgesPerColumn); // Subtract max edges found from maximum wall column count
        }
    }
}
