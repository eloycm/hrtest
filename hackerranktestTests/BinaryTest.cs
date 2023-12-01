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

    }
}
