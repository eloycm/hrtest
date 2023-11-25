using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hackerranktest;

namespace hackerranktestTests
{
    [TestClass()]
    public class WordsTest
    {
       
        [TestMethod()]
        public void TestTopNwords()
        {
            //var testString = "hola a todos hola a todas y a otros";
            // var words = Words.TopNWords(testString, 1000);
            var expected = new List<string> { "e", "ddd", "aa" };
            var actual = Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"); ;
            CollectionAssert.AreEqual(expected, actual);

            expected = new List<string> { "a", "of", "on" };
            actual = Top3(string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." }));
            CollectionAssert.AreEqual(expected, actual);
        }
        public List<string> Top3(string inputString)
        {
            var rs = Words.TopNWords(inputString, 3);
            return rs;
        }
        [TestMethod()]
        public void TestCamelToUnderscore()
        {
            var inputString = "PascalCaseVariable";
            var expected = "pascal_case_variable";
            var actual =Words.CamelToUnderscore(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
    
}
