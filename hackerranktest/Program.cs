using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class Program
    {
        static Dictionary<string, string> closures = getClosingMatchs();
        static bool HasSequentialDuplicates(string word)
        {
            if (word.Length > 100)
                throw new Exception("the word should not be longer than 100 characters");
            var chars = word.ToLower().ToCharArray();

            for (int i = 1; i < word.Length; i++)
            {
                if (chars[i - 1] == chars[i])
                    return true;
            }

            return false;

        }
        public static Dictionary<string,string> getClosingMatchs()
        {
            var rs = new Dictionary<string, string>();
            rs.Add("{", "}");
            ; rs.Add("[", "]");
            rs.Add("(", ")");

            return rs;
            
        }
        static int sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;

        }
        
        public static bool TestBraces(string s, string[] a)
        {
            foreach (var ss in a)
            {
                if (!s.Contains(ss) && !s.Contains(closures[ss]))
                    continue;
                if (s.Contains(closures[ss]) && !s.Contains(ss))
                    return false;
                if (!s.Contains(closures[ss]) && s.Contains(ss))
                    return false;

            }
            return true;

        }
        

        public static bool IsBraced(string s)
        {
            var bracesStack = new Stack<char>();
            var closures = new char[] {'}', ']', ')' };
            var openings = new char[] { '{', '[', '(' };

            var matching = new Dictionary<char, char>();
            matching.Add('{', '}');
            matching.Add('[', ']');
            matching.Add('(', ')');

            for (int i = 0; i < s.Length; i++)
            {
                if (openings.Contains(s[i]))
                    bracesStack.Push(s[i]);

                if (closures.Contains(s[i])  )
                {
                    if (bracesStack.Count == 0) //stack is empty
                        return false;

                    if (s[i] == matching[bracesStack.Peek()]) //the closure is consisten with the opening
                        bracesStack.Pop();
                    else
                        return false;   
                }
            }
            return bracesStack.Count == 0;


            
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
        static void Main(string[] args)
        {
            Console.Write( division(4,2));
           // string[] str = new string[] { "{}[]()", "{[}]}" };
           // var rs = braces(str);

        }
    }
}
