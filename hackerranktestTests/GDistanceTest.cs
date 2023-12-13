using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktestTests
{
    [TestClass()]
    public class GDistanceTest
    {
        [TestMethod()]
        public void MaxDistanceToTest()
        {
            var myFacilities = new List<string> { "a", "b", "c" };
            var blocks = new List<string>[]
            {
                new List<string> { "a", "b" },
                new List<string> { "a", "b", "c" },
                new List<string> { "a", ""}
            };
            var myPosition = 0;
            var expected = 1;
            var actual = new hackerranktest.Distance.GDistance().MaxDistanceTo(myFacilities, blocks, myPosition);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDistanceToTest2()
        {
            var myFacilities = new List<string> { "a", "b", "c" };
            var blocks = new List<string>[]
            {
                new List<string> { "a", "b" },
                new List<string> { "a", "b", "c" },
                new List<string> { "a", ""}
            };
            var myPosition = 2;
            var expected = 1;
            var actual = new hackerranktest.Distance.GDistance().MaxDistanceTo(myFacilities, blocks, myPosition);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDistanceToTest3()
        {
            var myFacilities = new List<string> { "a", "b", "c" };
            var blocks = new List<string>[]
            {
                new List<string> { "a", "c" },
                new List<string> { "a", "b" },
                new List<string> { "a", ""}
            };
            var myPosition = 2;
            var expected = 2;
            var actual = new hackerranktest.Distance.GDistance().MaxDistanceTo(myFacilities, blocks, myPosition);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MaxDistanceToTest4()
        {
            var myFacilities = new List<string> { "a", "b", "c" };
            var blocks = new List<string>[]
            {
                new List<string> { "a", "c" },
                new List<string> { "a", "b" },
                new List<string> { "a", ""}
            };
            var myPosition = 1;
            var expected = 1;
            var actual = new hackerranktest.Distance.GDistance().MaxDistanceTo(myFacilities, blocks, myPosition);
            Assert.AreEqual(expected, actual);
        }
    }
}
