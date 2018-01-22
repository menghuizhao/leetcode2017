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
    public List<IList<int>> result { get; set; }
    public IList<IList<int>> LevelOrder(TreeNode root) {
        this.result = new List<IList<int>>();
        if(root == null) return result;
        Helper(root, 0);
        return this.result;
    }
    public void Helper(TreeNode root, int level){
        if(root == null) return;
        IList<int> subList = new List<int>();
        if(level > this.result.Count - 1){
            result.Add(subList);
        }
        var levelList = this.result[level];
        levelList.Add(root.val);
        Helper(root.left, level + 1);
        Helper(root.right, level + 1);
    }
}
