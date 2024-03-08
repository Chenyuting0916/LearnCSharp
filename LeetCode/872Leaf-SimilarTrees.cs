using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _872Leaf_SimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }

            var root1Leaf = GetLeaf(root1);
            var root2Leaf = GetLeaf(root2);


            return root1Leaf.SequenceEqual(root2Leaf); ;
        }

        public List<int> GetLeaf(TreeNode root)
        {
            var rootLeaf = new List<int>();
            Stack<TreeNode> rootStack = new Stack<TreeNode>();
            rootStack.Push(root);

            while (rootStack.Count != 0)
            {
                var current = rootStack.Pop();
                if (current.left != null)
                {
                    rootStack.Push(current.left);
                }

                if (current.right != null)
                {
                    rootStack.Push(current.right);
                }

                if (current.left == null && current.right == null)
                {
                    rootLeaf.Add(current.val);
                }
            }

            foreach (var i in rootLeaf)
            {
                Console.WriteLine(i);
            }

            return rootLeaf;
        }
    }
}
