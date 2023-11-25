using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class Words
    {
        public static Dictionary<string,int> WordCounter(string inputString)
        {
            var rs= new Dictionary<string,int>();
            var strings=inputString.Split(' ');
            foreach (var s in strings)
            {
                if (string.IsNullOrWhiteSpace(s))
                    continue;
                if (rs.ContainsKey(s))
                {
                    rs[s] ++;
                    continue;
                }
                rs.Add(s, 1 );
            }
            
            return rs;
        }
        public static List<string> TopNWords(string inputString, int nWords)
        {
            
            var orderWords = WordCounter(inputString).OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x=>x.Key).Take(nWords).ToList();
           
            return orderWords;

        }
    }
}
