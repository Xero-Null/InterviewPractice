using System;

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
