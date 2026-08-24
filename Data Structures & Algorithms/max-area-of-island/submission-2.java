class Solution {
    public int maxAreaOfIsland(int[][] grid) {
        boolean[][] visited = new boolean[grid.length][grid[0].length];
        int maxArea = 0 ;
        for (int i =0; i < grid.length; i++) {
            for (int j = 0; j < grid[0].length; j++) {
                if (grid[i][j] == 1 && !visited[i][j]) {
                    maxArea =  Math.max(maxArea, dfs(i, j, visited, grid));
                }
            }
        }
        return maxArea;
    }
    private int dfs(int i, int j, boolean[][] visited, int[][] grid) {
        if (i < 0 || i >= grid.length || j < 0 || j >= grid[0].length || visited[i][j] || grid[i][j] == 0 ) {
            return 0;
        }
        visited[i][j] = true;
        return 1 + dfs(i + 1, j, visited, grid) + dfs(i - 1, j, visited, grid) + dfs(i, j + 1, visited, grid) + dfs(i, j - 1, visited, grid);
    }
}
