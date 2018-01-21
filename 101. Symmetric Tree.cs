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
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        return Helper(root.left, root.right);

    }
    public bool Helper(TreeNode r1, TreeNode r2){
        if(r1 == null && r2 == null) return true;
        if(r1 == null || r2 == null) return false;
        return r1.val == r2.val && Helper(r1.left, r2.right) && Helper(r1.right, r2.left);
    }
}
