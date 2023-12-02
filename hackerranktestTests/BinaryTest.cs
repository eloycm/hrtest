using hackerranktest.BST;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktestTests
{
    [TestClass()]
    public  class BinaryTest
    {
        public BinaryTest() { }

        [TestMethod()]
        public void FindInOrderSuccessorTest()
        {
            //create a new BinarySearchTree    
            var tree = new BinarySearchTree();
            
            tree.Insert(20);
            tree.Insert(9);
            tree.Insert(25);
            tree.Insert(5);
            tree.Insert(12);
            tree.Insert(11);
            tree.Insert(14);
            tree.Insert(15);
            tree.Insert(13);
            tree.Insert(10);
            tree.Insert(8);
            
            var testNode = tree.Find(9);
            var actual = tree.FindInOrderSuccessor(testNode);
            
            var expectedNode = tree.Find(10);
            Assert.AreEqual(expectedNode, actual);

        }
        //write a test method for arrayutil.sort
        [TestMethod()]
        public void SortTest()
        {
            var arr = new int[] { 20, 9, 25, 5, 12, 11, 14, 15, 13, 10, 8 };
            var actual = ArrayUtil.Sort(arr);
            var expected = new List<int> { 5, 8, 9, 10, 11, 12, 13, 14, 15, 20, 25 };
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
