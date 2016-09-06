using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest
{
    public class IndexResult
    {
        public int index { get; set; }
        public string foundString { get; set; }
    }
    public static class extensions
    {
        public static IndexResult IndexOf(this string s,string[] search)
        {
            var result = new IndexResult() { index=0, foundString=string.Empty };
            foreach(var ss in search)
            {
                var r = s.IndexOf(ss);
                if (result.index == 0 &&r >0  )
                {
                    result.index = r; result.foundString = ss;
                    continue;
                }
                if (r < result.index)
                    result.index = r; result.foundString = ss;

            }

            return result;
                
        }
        public static bool Contains(this string s,string[] search )
        {
            foreach (var ss in search)
                if (s.Contains(ss))
                    return true;

            return false;
        }
    }
}
