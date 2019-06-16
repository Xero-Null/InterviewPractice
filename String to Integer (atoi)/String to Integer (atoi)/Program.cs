using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Implement atoi which converts a string to an integer.

    The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

    The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

    If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

    If no valid conversion could be performed, a zero value is returned.

    Note:

    Only the space character ' ' is considered as whitespace character.
    Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN (−231) is returned.
    Example 1:

    Input: "42"
    Output: 42
    Example 2:

    Input: "   -42"
    Output: -42
    Explanation: The first non-whitespace character is '-', which is the minus sign.
                 Then take as many numerical digits as possible, which gets 42.
    Example 3:

    Input: "4193 with words"
    Output: 4193
    Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.
    Example 4:

    Input: "words and 987"
    Output: 0
    Explanation: The first non-whitespace character is 'w', which is not a numerical 
                 digit or a +/- sign. Therefore no valid conversion could be performed.
    Example 5:

    Input: "-91283472332"
    Output: -2147483648
    Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer.
                 Thefore INT_MIN (−231) is returned.

    Results:
    Runtime: 68 ms, faster than 100.00% of C# online submissions for String to Integer (atoi).
    Memory Usage: 23.8 MB, less than 6.91% of C# online submissions for String to Integer (atoi).
     
*/

namespace String_to_Integer__atoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "3.14159";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "words and 987";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "+1";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "+-2";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "2147483648";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "20000000000000000000";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            str = "-   234";
            Console.WriteLine($"Entering string [{str}] -> Result: [{MyAtoi(str)}]");

            Console.ReadKey();
        }

        enum Status { None, Positive, Negative}
        public static int MyAtoi(string str)
        {
            if (str.Length == 0) return 0;

            char[] strCHR = str.ToCharArray();
            string valueSTR = "";

            Status st = Status.None;
            for (int i = 0; i < strCHR.Length; i++)
            {
                if (Char.IsNumber(strCHR[i]))
                {
                    valueSTR += strCHR[i].ToString();
                }
                else if ((char.IsWhiteSpace(strCHR[i])) && (valueSTR.Length > 0))
                {
                    break;
                }
                else if ((strCHR[i].ToString().Contains('-')) && (valueSTR.Length == 0))
                {
                    if (st == Status.None)
                        st = Status.Negative;
                    else
                        return 0;
                }
                else if ((strCHR[i].ToString().Contains('+')) && (valueSTR.Length == 0))
                {
                    if (st == Status.None)
                        st = Status.Positive;
                    else
                        return 0;
                }
                else if ((!char.IsWhiteSpace(strCHR[i])) && (valueSTR.Length > 0))
                {
                    break;
                }
                else if ((!char.IsWhiteSpace(strCHR[i])) && (valueSTR.Length == 0) && (!strCHR[i].ToString().Contains('+')))
                {
                    return 0;
                }
                else if ((char.IsWhiteSpace(strCHR[i])) && (st != Status.None))
                {
                    return 0;
                }
            }

            int value = 0;
            if (valueSTR.Length > 0)
            {
                if (!int.TryParse(valueSTR, out value))
                {
                    if ((st == Status.None) || (st == Status.Positive))
                        return int.MaxValue;
                    else
                        return int.MinValue;
                }
            }

            if (st == Status.Negative)
                return -value;
            else
                return (int)value;
        }
    }
}
