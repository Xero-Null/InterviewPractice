using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.

    Return the quotient after dividing dividend by divisor.

    The integer division should truncate toward zero.

    Example 1:

    Input: dividend = 10, divisor = 3
    Output: 3
    Example 2:

    Input: dividend = 7, divisor = -3
    Output: -2
    Note:

    Both dividend and divisor will be 32-bit signed integers.
    The divisor will never be 0.

    Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 231 − 1 when the division result overflows.

    Results:
        Runtime: 36 ms, faster than 99.43% of C# online submissions for Divide Two Integers.
        Memory Usage: 12.8 MB, less than 100.00% of C# online submissions for Divide Two Integers.
 */

namespace Divide_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result: {Divide(10, 3)}");

            Console.WriteLine($"Result: {Divide(7, -3)}");

            Console.WriteLine($"Result: {Divide(-2147483648, -1)}");

            Console.WriteLine($"Result: {Divide(-2147483648, 1)}");

            Console.WriteLine($"Result: {Divide(2147483647, 1)}");

            Console.WriteLine($"Result: {Divide(2147483647, 2)}");

            Console.WriteLine($"Result: {Divide(-2147483648, -1)}");

            Console.WriteLine($"Result: {Divide(2147483647, 3)}");

            Console.WriteLine($"Result: {Divide(-1010369383, -2147483648)}");

            Console.ReadKey();
        }

        public static int Divide(int dividend, int divisor)
        {
            if ((dividend == int.MinValue) && (divisor == -1))
                return int.MaxValue;

            bool negative = ((dividend < 0) ^ (divisor < 0)) ? true : false;
            int result = 0, power = 32;
            long divD = Math.Abs((long)dividend), divS = Math.Abs((long)divisor);

            while (divD >= divS)
            {
                while ((divS << power) > divD)
                    power--;

                divD -= divS << power;
                result += 1 << power;
            }

            return (negative ? -result : result);
        }
    }
}
