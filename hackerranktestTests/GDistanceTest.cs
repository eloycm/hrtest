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
                new List<string> { "a", "b", "c" },
                new List<string> { "a", "b", "c" },
                new List<string> { "a", ""}
            };
            var myPosition = 0;
            var expected = 0;
            var actual = new hackerranktest.Distance.GDistance().MaxDistanceTo(myFacilities, blocks, myPosition);
            Assert.AreEqual(expected, actual);
        }
    }
}
