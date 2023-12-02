using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest.BST
{
    public class ArrayUtil
    {
        public static int[] ToArray(Node root)
        {
            var list = new List<int>();
            ToArrayRec(root, list);
            return list.ToArray();
        }

        private static void ToArrayRec(Node root, List<int> list)
        {
            if (root == null)
                return;

            ToArrayRec(root.left, list);
            list.Add(root.data);
            ToArrayRec(root.right, list);
        }
        public static List<int> Sort(int[] arr)
        {
            //sort the array with the binary search tree
            var bst = new BinarySearchTree();
            foreach (var item in arr)
                bst.Insert(item);
            var rs = bst.InorderTraversal();
            return rs;
        }
    }
}
