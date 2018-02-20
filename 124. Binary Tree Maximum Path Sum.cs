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
    private int max = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        if(root == null) return 0;
        helper(root);
        return max;
    }
    private int helper(TreeNode root){
        if(root == null) return 0;
        int leftMax = helper(root.left);
        int rightMax = helper(root.right);
        int current = Math.Max(root.val, Math.Max(root.val + leftMax, root.val + rightMax)); // 存着这个作为当前 dp 的返回值
        int k = largestOfFour(root.val, root.val + leftMax, root.val + rightMax, root.val + leftMax + rightMax);
        if(k > this.max){
            this.max = k;
        }
        return current;
    }
    private int largestOfFour(int a, int b, int c, int d){
        return Math.Max(a, Math.Max(b, Math.Max(c, d)));
    }

}
//递归+ dp, dp为helper(r),包含r的最大值，r不能是转折点（不能去另一边往下拐，这就不是path了）
