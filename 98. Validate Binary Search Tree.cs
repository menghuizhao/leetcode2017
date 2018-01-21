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
    public bool IsValidBST(TreeNode root) {
        //Even this question needs to handle overflow
        return Helper(root, Int64.MinValue, Int64.MaxValue);
    }
    public bool Helper(TreeNode root, long low, long high){
        if(root == null) return true;
        if(root.val <= low || root.val >= high) return false;
        TreeNode left = root.left;
        TreeNode right = root.right;
        if(left != null && left.val >= root.val){
            return false;
        }
        if(right != null && right.val <= root.val){
            return false;
        }
        bool leftValid = left == null || Helper(left, low, (long)root.val);
        bool rightValid = right == null || Helper(right, (long)root.val, high);
        return leftValid && rightValid;
    }
}
