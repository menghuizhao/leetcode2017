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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return root;
        if(root.left == null && root.right == null) return root;
        var invLeft = InvertTree(root.left);
        var invRight = InvertTree(root.right);
        root.left = invRight;
        root.right = invLeft;
        return root;
    }
}
