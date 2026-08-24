/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    private int maxPathSum;
    public int maxPathSum(TreeNode root) {
        if (root == null){
            return 0;
        }
        maxPathSum = Integer.MIN_VALUE;
        dfs(root);
        return maxPathSum;
    }
    private int dfs(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int left = Math.max(0, dfs(root.left));
        int right = Math.max(0, dfs(root.right));
        maxPathSum = Math.max(maxPathSum, left + right + root.val);
        return root.val + Math.max(left, right);
    }
}
