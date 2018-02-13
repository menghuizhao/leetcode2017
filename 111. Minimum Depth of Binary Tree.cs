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
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        if(root.left == null && root.right == null) return 1;//is leaf!
        if(root.left == null) return 1 + MinDepth(root.right);
        if(root.right == null) return 1 + MinDepth(root.left);
        return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
    }
}
