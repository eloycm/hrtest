using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankApp
{
    public class IntMath
    {
        public static int sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;

        }

        public static int division(int numerator, int denominator)
        {
            int result = 0;
            while (numerator >= denominator)
            {
                numerator = numerator - denominator;
                result++;
            }
            return result;
        }
    }
}
