using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode treeNode = ConstructBSTFromArray(nums, 0, nums.Length - 1);
            return treeNode;
        }

        public TreeNode ConstructBSTFromArray(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;

            TreeNode treeNode = new TreeNode(nums[mid]);

            treeNode.left = ConstructBSTFromArray(nums, left, mid - 1);
            treeNode.right = ConstructBSTFromArray(nums, mid + 1, right);

            return treeNode;
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
