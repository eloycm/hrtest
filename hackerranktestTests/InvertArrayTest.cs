using hackerranktest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankApp.Tests
{
    [TestClass()]
    public class InvertArrayTest
    {
        [TestMethod()]
        public void StringReverseTest()
        {
            var s = "this is a test string";
            var sArray = s.ToCharArray();
            var invertedArray =Reverse.ReverseArray<char>(sArray);
            var actual = new string(invertedArray);
            var expected = "gnirts tset a si siht";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WordReverseTest()
        {
            var s = "this is a test string";
            var sArray = s.Split(' ');
            var invertedArray = Reverse.ReverseArray<string>(sArray);
            var actual = string.Join(" ", invertedArray);
            var expected = "string test a is this";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeNumberTest()
        {
            var expected = Reverse.IsPalindromeNumber(12321);
            var actual = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void PalindromeNumberTest2()
        {
            var expected = Reverse.IsPalindromeNumber(123);
            var actual = false;
            Assert.AreEqual(expected, actual);
        }

    }
}
