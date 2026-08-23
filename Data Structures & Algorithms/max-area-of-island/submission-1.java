class Solution {
    public int maxAreaOfIsland(int[][] grid) {
        int area = 0;
        for (int r = 0; r < grid.length; r++) {
            for (int c = 0; c < grid[0].length; c++) {
                area = Math.max(area, dfs(grid, r, c));
            }
        }
        return area;
    }
    private int dfs(int[][] grid, int r, int c) {
        if (r < 0 || c < 0 || r >= grid.length || c >= grid[0].length || grid[r][c] == 0) {
            return 0;
        }
        grid[r][c] = 0;
        int res = 1;
        res += dfs(grid, r + 1, c);
        res += dfs(grid, r, c+1);
        res += dfs(grid, r - 1, c);
        res += dfs(grid, r, c-1);
        return res;
    }
}
