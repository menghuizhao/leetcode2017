/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return Helper(nums);
    }
    public TreeNode Helper(int[] nums){
        if(nums == null || nums.Length == 0) return null;
        int mid = nums.Length / 2;
        //GetRange count: (mid - 1) - 0 + 1
        int[] left = mid - 1 >= 0 ? nums.ToList().GetRange(0, mid).ToArray() : new int[0];
        //GetRange count: (nums.Length - 1) - (mid + 1) + 1
        int[] right = mid + 1 <= nums.Length - 1 ? nums.ToList().GetRange(mid + 1, nums.Length - mid - 1 ).ToArray() : new int[0];
        TreeNode leftTree = Helper(left);
        TreeNode rightTree = Helper(right);
        TreeNode root = new TreeNode(nums[mid]);
        root.left = leftTree;
        root.right = rightTree;
        return root;
    }
}
