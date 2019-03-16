using System;
using System.Collections.Generic;

/*
    You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
    Each character in S is a type of stone you have.
    You want to know how many of the stones you have are also jewels.

    The letters in J are guaranteed distinct, and all characters in J and S are letters.
    Letters are case sensitive, so "a" is considered a different type of stone from "A".

    Input: J = "aA", S = "aAAbbbb"
    Output: 3



    Results:
        Runtime: 76 ms, faster than 86.81% of C# online submissions for Jewels and Stones.
        Memory Usage: 21.3 MB, less than 35.55% of C# online submissions for Jewels and Stones.
*/

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int jc = NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine("Jewel count: " + jc); // Output = 3

            jc = NumJewelsInStones("z", "ZZ");
            Console.WriteLine("Jewel count: " + jc); // Output = 0

            jc = NumJewelsInStones("zx", "ZZzzZzZZzfgXxzzzZ");
            Console.WriteLine("Jewel count: " + jc); // Output = 8

            Console.ReadLine();
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int jCount = 0;

            char[] jewels = J.ToCharArray();
            Dictionary<char, int> jewels_Map = new Dictionary<char, int>();
            for (int i = 0; i < jewels.Length; i++)
            {
                jewels_Map.Add(jewels[i], i);
            }

            char[] stones = S.ToCharArray();
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels_Map.ContainsKey(stones[i]))
                    jCount++;
            }

            return jCount;
        }
    }
}
