using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HackerRankApp.Tests
{
    [TestClass()]
    public class BracingTest
    {
        
        [TestMethod()]
        public void IsBracedTest()
        {
            var r = "{}(){[]}";

            var actual = Bracing.IsBraced(r);
            Assert.IsTrue(actual);

        }
        [TestMethod()]
        public void IsBracedTest2()
        {
            var r = "}(){[]}";

            var actual = Bracing.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest3()
        {
            var r = "{[)]";

            var actual = Bracing.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest4()
        {
            var r = "{[)]";

            var actual = Bracing.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest5()
        {
            var r = "openings.Contains(s[i])&&braces.Push(s[i]),closures.Contains(s[i])&&(0==braces.Count&&alert(),s[i]==matching[braces.Peek()]&&braces.Pop());";

            var actual = Bracing.IsBraced(r);
            Assert.IsTrue(actual);

        }
        [TestMethod()]
        public void IsBracedTest6()
        {
            var r = "openings.Contains(s[i])&&braces.Push(s[i]),closures.Contains(s[i])&&(0==braces.Count&&alert(),s[i==matching[braces.Peek()]&&braces.Pop());";

            var actual = Bracing.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest7()
        {
            var r = "{[}";

            var actual = Bracing.IsBraced(r);
            Assert.IsFalse(actual);

        }


    }
}