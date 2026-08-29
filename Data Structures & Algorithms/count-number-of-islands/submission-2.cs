public class Solution {
    public int NumIslands(char[][] grid) {
        var visited = new HashSet<(int row, int col)>();
        int numIslands = 0;
        for(int i =0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == '1' && !visited.Contains((i, j))){
                    dfs(i, j, grid, visited);
                    numIslands++;
                }
            }
        }
        return numIslands;
    }
    private void dfs(int r, int c, char[][] grid, HashSet<(int row, int col)> visited) {
        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || visited.Contains((r,c)) || grid[r][c] == '0') {
            return;
        }
        visited.Add((r, c));
        dfs(r + 1, c, grid, visited);
        dfs(r - 1, c, grid, visited);
        dfs(r, c + 1, grid, visited);
        dfs(r, c - 1, grid, visited);
    }
}
