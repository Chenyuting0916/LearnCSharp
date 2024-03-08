using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _104MaximumDepthofBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return Math.Max(left, right) + 1;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
