public class Solution {
    public int OrangesRotting(int[][] grid) {
        int fresh = 0;
        Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 1){
                    fresh++;
                }else if (grid[i][j] == 2) {
                    queue.Enqueue((i, j));
                }
            }
        }
        int minutes = 0;
        (int dr, int dc)[] directions = {(-1, 0), (1, 0), (0, -1), (0, 1)};
        while (fresh > 0 && queue.Count > 0) {
            minutes++;
            int size = queue.Count;
            for (int i =0; i < size; i++) {
                var (row, col) = queue.Dequeue();
                foreach ((int dr, int dc) in directions) {
                    int nr = dr + row;
                    int nc = dc + col;
                    if (nr >= 0 && nr < grid.Length && nc >= 0 && nc < grid[0].Length && grid[nr][nc] == 1){
                        fresh--;
                        grid[nr][nc] = 2;
                        queue.Enqueue((nr, nc));
                    }
                }
            }
        }
        return fresh > 0 ? -1 : minutes;
    }
}
