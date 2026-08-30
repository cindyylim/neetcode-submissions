public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        HashSet<(int row, int col)> atlantic = new HashSet<(int row, int col)>();        
        HashSet<(int row, int col)> pacific = new HashSet<(int row, int col)>();
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < heights.Length; i++) {
            Dfs(heights, pacific, i, 0);
            Dfs(heights, atlantic, i, heights[0].Length - 1);
        }
        for (int j = 0; j < heights[0].Length; j++) {
            Dfs(heights, pacific, 0, j);
            Dfs(heights, atlantic, heights.Length - 1, j);
        }
        for (int i = 0 ; i < heights.Length; i++) {
            for (int j =0 ; j < heights[0].Length; j++) {
                if (atlantic.Contains((i, j)) && pacific.Contains((i, j))) {
                    result.Add(new List<int>{i, j});
                }
            }
        }
        return result;
    }
    private void Dfs(int[][] heights, HashSet<(int row, int col)> ocean, int row, int col) {
        if (ocean.Contains((row, col))){
            return;
        }
        ocean.Add((row, col));
        (int row, int col)[] dir = {(1, 0), (-1, 0), (0, -1), (0, 1)};
        foreach ((int dr, int dc) in dir){
            int nr = dr + row;
            int nc = dc + col;
            if (nr < 0 || nr >= heights.Length || nc < 0 || nc >= heights[0].Length || heights[nr][nc] < heights[row][col]) {
                continue;
            }
            Dfs(heights, ocean, nr, nc);
        }
    }
}
