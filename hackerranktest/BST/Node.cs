using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hackerranktest.BST
{
    public class Node
    {
        public int data;
        public Node left, right, parent;

        public Node(int value)
        {
            data = value;
            left = right = null;
        }
    }
}
