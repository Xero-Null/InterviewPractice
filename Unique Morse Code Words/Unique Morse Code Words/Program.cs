using System;
using System.Collections.Generic;

/*
    International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
    "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.

    Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.
    For example, "cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-").
    We'll call such a concatenation, the transformation of a word.

    Return the number of different transformations among all words we have.

    Example:
    Input: words = ["gin", "zen", "gig", "msg"]
    Output: 2
    Explanation: 
    The transformation of each word is:
    "gin" -> "--...-."
    "zen" -> "--...-."
    "gig" -> "--...--."
    "msg" -> "--...--."

    There are 2 different transformations, "--...-." and "--...--.".

    Results: Runtime: 92 ms, faster than 97.90% of C# online submissions for Unique Morse Code Words.
             Memory Usage: 22.5 MB, less than 36.36% of C# online submissions for Unique Morse Code Words.
 */

namespace Unique_Morse_Code_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of transformations: " + UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }));

            Console.ReadLine();
        }

        static Dictionary<char, string> mCodes = new Dictionary<char, string>();
        static string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

        public static int UniqueMorseRepresentations(string[] words)
        {
            if (words.Length == 0) return 0;
            if (mCodes.Count == 0)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    mCodes.Add(letters[i], codes[i]);
                }
            }

            string code = "", msg = "";
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int j = 0; j < words.Length; j++)
            {
                code = "";
                msg = "";
                for (int i = 0; i < words[j].Length; i++)
                {
                    mCodes.TryGetValue(words[j][i], out code);
                    msg += code;
                }

                if (!map.ContainsKey(msg))
                    map.Add(msg, j);
            }

            return map.Count;
        }
    }
}
