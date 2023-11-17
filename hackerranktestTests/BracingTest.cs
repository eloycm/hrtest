using Microsoft.VisualStudio.TestTools.UnitTesting;
using hackerranktest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hackerranktest;
namespace hackerranktest.Tests
{
    [TestClass()]
    public class BracingTest
    {
        [TestMethod()]
        public void divisionTest()
        {
            var r = IntMath.division(4, 2);
            Assert.AreEqual(2, r);

        }
        [TestMethod()]
        public void divisionTest4()
        {
            var r = IntMath.division(300, 2);
            Assert.AreEqual(150, r);

        }
        [TestMethod()]
        public void divisionTest2()
        {
            var r = IntMath.division(100, 2);
            Assert.AreEqual(50, r);

        }
        [TestMethod()]
        public void divisionTest3()
        {
            var r = IntMath.division(5, 2);
            Assert.AreEqual(2, r);

        }
        [TestMethod()]
        public void divisionTest5()
        {
            var r = IntMath.division(6, 2);
            Assert.AreEqual(3, r);

        }
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