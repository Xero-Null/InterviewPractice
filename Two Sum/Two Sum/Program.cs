using System;
using System.Collections.Generic;

/*
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:

    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].

    Results: Runtime: 248 ms, faster than 99.30% of C# online submissions for Two Sum.
             Memory Usage: 29 MB, less than 52.64% of C# online submissions for Two Sum.
 */

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ind = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine("Indices found: [" + ind[0] + ", " + ind[1] + "]");

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];

            if (nums.Length >= 2)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();

                int sTarget = 0, stIndex = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sTarget = target - nums[i];
                    if (map.ContainsKey(sTarget))
                    {
                        map.TryGetValue(sTarget, out stIndex);
                        res[0] = stIndex;
                        res[1] = i;
                        return res;
                    }

                    if (!map.ContainsKey(nums[i]))
                        map.Add(nums[i], i);
                }
            }

            res[0] = -1;
            res[1] = -1;

            return res;
        }
    }
}
