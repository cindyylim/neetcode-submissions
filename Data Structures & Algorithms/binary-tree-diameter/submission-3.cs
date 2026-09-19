/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private int maxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) {
            return 0;
        }
        CalculateDiameter(root);
        return maxDiameter;
    }
    private int CalculateDiameter(TreeNode root) {
        if (root == null) {
            return 0;
        }
        int left = CalculateDiameter(root.left);
        int right = CalculateDiameter(root.right);
        maxDiameter = Math.Max(maxDiameter, left + right);
        return 1 + Math.Max(left, right);
    }
}
