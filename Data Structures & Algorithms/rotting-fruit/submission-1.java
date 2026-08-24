class Solution {
    public int orangesRotting(int[][] grid) {
        Queue<int[]> queue = new LinkedList<>();
        int fresh = 0;
        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[0].length; j++) {
                if (grid[i][j] == 1) {
                    fresh ++;
                }else if (grid[i][j] == 2) {
                    queue.add(new int[]{i, j});
                }
            }
        }
        int minutes = 0;
        int[][] directions = {{0, 1}, {0, -1}, {1, 0}, {-1, 0}};
        while (fresh > 0 && !queue.isEmpty()) {
            int size = queue.size();
            for (int i =0;i < size; i++) {
                int[] cell = queue.remove();
                int r = cell[0];
                int c = cell[1];
                for (int[] direction: directions) {
                    int nr = r + direction[0];
                    int nc = c + direction[1];
                    if (nr < 0 || nr >= grid.length || nc < 0 || nc >= grid[0].length || grid[nr][nc] != 1) {
                        continue;
                    }
                    fresh--;
                    grid[nr][nc] = 2;
                    queue.add(new int[]{nr, nc});
                }
            }
            minutes++;
            
        }
        return fresh == 0 ? minutes : -1;
    }
}
