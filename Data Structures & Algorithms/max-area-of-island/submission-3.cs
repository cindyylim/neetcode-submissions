public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        var visited = new HashSet<(int row, int col)>();
        for (int i =0; i < grid.Length; i++){
            for (int j = 0; j < grid[0].Length; j++) {
                if (!visited.Contains((i, j)) && grid[i][j] == 1) {
                    int area = Dfs(i, j, visited, grid);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        return maxArea;
    }
    private int Dfs(int r, int c, HashSet<(int row, int col)> visited, int[][] grid) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || visited.Contains((r, c)) || grid[r][c] == 0) {
            return 0;
        }
        visited.Add((r, c));
        return 1 + Dfs(r + 1 , c, visited, grid) + Dfs(r - 1, c, visited, grid) + Dfs(r, c + 1, visited, grid) + Dfs(r, c- 1, visited, grid);
    }
}
