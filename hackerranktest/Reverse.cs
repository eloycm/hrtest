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
 
    }
}
