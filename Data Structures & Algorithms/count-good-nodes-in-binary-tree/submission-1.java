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
    public int goodNodes(TreeNode root) {
        if (root == null) {
            return 0;
        }
        return findGoodNodes(root, root.val);
    }
    private int findGoodNodes(TreeNode node, int max) {
        if (node == null) {
            return 0;
        }
        int result = 0;
        if (node.val >= max) {
            result = 1;
        }
        return findGoodNodes(node.left, Math.max(node.val, max)) + findGoodNodes(node.right, Math.max(node.val, max)) + result;
    }
}
