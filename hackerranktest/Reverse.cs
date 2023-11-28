using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class Reverse
    {
        /// <summary>
        /// This is a demo on how to use the stack structure to revert
        /// the order of an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="InputArray">Array to be reverted</param>
        /// <returns>the reverted array</returns>
        public static T[] ReverseArray<T>(T[] InputArray)
        {
            var myStack = new Stack<T>();
            for (int i = 0; i < InputArray.Length; i++)
            {
                myStack.Push(InputArray[i]);
            }
            return myStack.ToArray();
        }

        /// <summary>
        /// reverses a string using the stack method
        /// </summary>
        /// <param name="InputString"></param>
        /// <returns>reverted string</returns>
        public static string ReverseString(string InputString)
        {
            var myStack = new Stack<char>();
            for (int i = 0;i < InputString.Length;i++)
            {
                myStack.Push(InputString[i]);
            }
            var rs = myStack.ToString();
            return rs;
        }
       /// <summary>
       /// Checks if a number is a palindrome based only in math operations
       /// </summary>
       /// <param name="number">number to be tested</param>
       /// <returns>true if number is a palindrome</returns>
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
        /// <summary>
        /// uses string reversion to determine if a number is a palindrome
        /// </summary>
        /// <param name="number">number to be tested</param>
        /// <returns>true if number is a palindrome</returns>
        public static bool IsPalindromeNumber2(int number)
        {
            var sNumber = number.ToString();
            var reverted =ReverseString(sNumber);
            return reverted == sNumber;
        }

    }
}
