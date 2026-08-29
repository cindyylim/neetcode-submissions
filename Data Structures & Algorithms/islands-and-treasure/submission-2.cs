public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) {
                    queue.Enqueue((i, j));
                }
            }
        }

        (int row, int col)[] dir = {(1, 0), (-1, 0), (0, 1), (0, -1)};
        while (queue.Count > 0) {
            (int row, int col) = queue.Dequeue();
            foreach ((int dr, int dc) in dir) {
                int nr = dr + row;
                int nc = dc + col;
                if (nr < 0 || nr >= grid.Length || nc < 0 || nc >= grid[0].Length || grid[nr][nc] != int.MaxValue) {
                    continue;
                }
                grid[nr][nc] = grid[row][col] + 1;
                queue.Enqueue((nr, nc));
            }
        }
    }
}
