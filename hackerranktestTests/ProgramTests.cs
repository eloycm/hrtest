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
    public class ProgramTests
    {
        [TestMethod()]
        public void divisionTest()
        {
            var r = Program.division(4, 2);
            Assert.AreEqual(2, r);

        }
        [TestMethod()]
        public void divisionTest4()
        {
            var r = Program.division(300, 2);
            Assert.AreEqual(150, r);

        }
        [TestMethod()]
        public void divisionTest2()
        {
            var r = Program.division(100, 2);
            Assert.AreEqual(50, r);

        }
        [TestMethod()]
        public void divisionTest3()
        {
            var r = Program.division(5, 2);
            Assert.AreEqual(2, r);

        }
        [TestMethod()]
        public void divisionTest5()
        {
            var r = Program.division(6, 2);
            Assert.AreEqual(3, r);

        }
        [TestMethod()]
        public void IsBracedTest()
        {
            var r = "{}(){[]}";

            var actual = Program.IsBraced(r);
            Assert.IsTrue(actual);

        }
        [TestMethod()]
        public void IsBracedTest2()
        {
            var r = "}(){[]}";

            var actual = Program.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest3()
        {
            var r = "{[)]";

            var actual = Program.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest4()
        {
            var r = "{[)]";

            var actual = Program.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest5()
        {
            var r = "openings.Contains(s[i])&&braces.Push(s[i]),closures.Contains(s[i])&&(0==braces.Count&&alert(),s[i]==matching[braces.Peek()]&&braces.Pop());";

            var actual = Program.IsBraced(r);
            Assert.IsTrue(actual);

        }
        [TestMethod()]
        public void IsBracedTest6()
        {
            var r = "openings.Contains(s[i])&&braces.Push(s[i]),closures.Contains(s[i])&&(0==braces.Count&&alert(),s[i==matching[braces.Peek()]&&braces.Pop());";

            var actual = Program.IsBraced(r);
            Assert.IsFalse(actual);

        }
        [TestMethod()]
        public void IsBracedTest7()
        {
            var r = "{[}";

            var actual = Program.IsBraced(r);
            Assert.IsFalse(actual);

        }


    }
}