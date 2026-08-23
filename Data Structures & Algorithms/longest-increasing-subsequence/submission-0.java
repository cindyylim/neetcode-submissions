class Solution {
    private int[][] memo;
    public int lengthOfLIS(int[] nums) {
        int n = nums.length;
        memo = new int[n][n+1];
        for (int[] row: memo) {
            Arrays.fill(row, -1);
        }
        return dfs(0, -1, nums);
    }
    private int dfs(int i, int j, int[] nums) {
        if (i == nums.length) {
            return 0;
        }
        if (memo[i][j+1] != -1) {
            return memo[i][j+1];
        }
        int LIS = dfs(i + 1, j, nums);
        if (j == -1 || nums[j] < nums[i]) {
            LIS = Math.max(LIS, 1 + dfs(i + 1, i, nums));
        }
        return LIS;
    }
}
