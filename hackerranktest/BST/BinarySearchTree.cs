using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest.BST
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            
            root = InsertRec(root, null, value);
            
        }

        private Node InsertRec(Node root, Node parent, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                root.parent = parent;
                return root;
            }

            if (value < root.data)
                root.left = InsertRec(root.left, root, value);
            else if (value > root.data)
                root.right = InsertRec(root.right, root, value);

            return root;
        }
        //write a find method that finds a node with a given value
        public Node Find(int value)
        {
            return FindRec(root, value);
        }
        //write a FindRec method that finds a node with a given value

        private Node FindRec(Node root, int value)
        {
            if (root == null)
                return null;

            if (root.data == value)
                return root;

            return value < root.data ?
                FindRec(root.left, value) :
                FindRec(root.right, value);
        }

        /// <summary>
        /// Given a node, transverse the whole tree going always to the left
        /// return the lowest possible left node
        /// </summary>
        /// <param name="initialNode"></param>
        /// <returns></returns>
        public Node GoAllTheWayLeft(Node initialNode)
        {
            if (initialNode.left == null)
                return initialNode;

            return GoAllTheWayLeft(initialNode.left);
        }
        /// <summary>
        /// finds the first antecessor that I need to come to the left in order to find it
        /// </summary>
        /// <param name="initialNode"></param>
        /// <returns></returns>
        public Node FirstUpLeft(Node initialNode)
        {
            if (initialNode.parent == null || initialNode.parent.data > initialNode.data)
                return initialNode.parent;
            return FirstUpLeft(initialNode.parent);
        }
        /// <summary>
        /// This is an excersiso on finding the InOrder Successor on a bst
        /// The smallest value tha is greater than the value of a given node
        /// </summary>
        /// <param name="initialNode"></param>
        /// <returns></returns>
        public Node FindInOrderSuccessor(Node initialNode)
        {
           //start searching down, firt to the right, then all the way to the left
           //if there isn't a node to the right, I go firstupleft
            if (initialNode.right != null)
            {
                var NodeDown = GoAllTheWayLeft(initialNode.right);
                return NodeDown;
            }

            var rs= FirstUpLeft(initialNode);
            return rs;

        }
        public bool Search(int value)
        {
            return SearchRec(root, value);
        }

        private bool SearchRec(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.data == value)
                return true;

            return value < root.data ?
                SearchRec(root.left, value) :
                SearchRec(root.right, value);
        }

        public void InorderTraversal()
        {
            InorderTraversalRec(root);
            Console.WriteLine();
        }

        private void InorderTraversalRec(Node root)
        {
            if (root != null)
            {
                InorderTraversalRec(root.left);
                Console.Write(root.data + " ");
                InorderTraversalRec(root.right);
            }
        }
    }
}
