using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeQuestion
{
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
    public class Tree
    {
        public async Task<int> SolveAsync(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int l = int.MaxValue, r = int.MaxValue;
            if (root.left != null) l = await SolveAsync(root.left);
            if (root.right != null) r = await SolveAsync(root.right);
            return 1 + Math.Min(l, r);
        }

        static void Main(string[] args)
        {
            Tree minDepth = new Tree();
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(2);
            root.left.right = new TreeNode(6);
            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(10);
            Console.WriteLine("Minimum depth of Binary tree is :" + minDepth.SolveAsync(root).Result);
        }
    }

}
