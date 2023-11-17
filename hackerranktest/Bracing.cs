using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class Bracing
    {
        /// <summary>
        /// Test a string for matching bracings. Every bracing, or braket or parenthesis has to be
        /// closed properly in order to return true
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsBraced(string s)
        {
            var bracesStack = new Stack<char>();
            var closures = new char[] { '}', ']', ')' };
            var openings = new char[] { '{', '[', '(' };

            var matching = new Dictionary<char, char>();
            matching.Add('{', '}');
            matching.Add('[', ']');
            matching.Add('(', ')');

            for (int i = 0; i < s.Length; i++)
            {
                if (openings.Contains(s[i]))
                    bracesStack.Push(s[i]);

                if (closures.Contains(s[i]))
                {
                    if (bracesStack.Count == 0) //stack is empty
                        return false;

                    if (s[i] == matching[bracesStack.Peek()]) //the closure is consistent with the opening
                        bracesStack.Pop();
                    else
                        return false;
                }
            }
            return bracesStack.Count == 0;



        }
    }
}
