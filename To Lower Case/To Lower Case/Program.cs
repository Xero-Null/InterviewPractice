using System;

/*
    Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
 
    Input: "Hello"
    Output: "hello"

    Results: Runtime: 96 ms, faster than 75.70% of C# online submissions for To Lower Case.
             Memory Usage: 20.5 MB, less than 19.79% of C# online submissions for To Lower Case.
*/

namespace To_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerCase("tEsT CasE 1337"));

            Console.ReadLine();
        }

        public static string ToLowerCase(string str)
        {
            string result = "";

            char[] cStr = str.ToCharArray(); // Convert to char[]
            for (int i = 0; i < cStr.Length; i++) // Iterate through all characters
            {
                if (Char.IsUpper(cStr[i])) // If char is upper, shift to lower
                    cStr[i] = Convert.ToChar(cStr[i] + 32); // Convert to char

                result += cStr[i].ToString(); // Append string
            }

            return result;
        }
    }
}
