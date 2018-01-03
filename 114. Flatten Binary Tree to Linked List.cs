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
    public void Flatten(TreeNode root) {
        if(root == null) return;
        if(root.left == null && root.right == null) return;
        Flatten(root.left);  //flatten left subtree
        Flatten(root.right); //flatten right subtree
        Concat(root.left, root.right);
        root.right = root.left ?? root.right; // if there is no left subtree, don't overwrite right subtree
        root.left = null;
    }

    // t1 and t2 must be flattened
    public void Concat(TreeNode t1, TreeNode t2) {
      if(t1 == null || t2 == null) return;
      var iterator1 = t1;
      while(iterator1.right != null){
        iterator1 = iterator1.right;
      }
      iterator1.right = t2;
    }
}


https://www.jiuzhang.com/solution/flatten-binary-tree-to-linked-list/
