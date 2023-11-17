using HackerRankApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankApp.Tests
{
    [TestClass()]
    public class IntMathTest
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
    }
}
