using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class Reverse
    {
        public static T[] ReverseArray<T>(T[] InputArray)
        {
            var myStack = new Stack<T>();
            for (int i = 0; i < InputArray.Length; i++)
            {
                myStack.Push(InputArray[i]);
            }
            return myStack.ToArray();
        }
        public static bool IsPalindromeNumber(int number)
        {
            if (number < 0 || (number % 10 == 0 && number != 0))
            {
                return false;
            }

            int reversedNumber = 0;
            int originalNumber = number;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }

    }
}
