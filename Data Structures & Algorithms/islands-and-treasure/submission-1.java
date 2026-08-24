class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<int[]> queue = new LinkedList<>();
        for (int i =0; i < grid.length; i++) {
            for (int j = 0; j < grid[0].length; j++) {
                if (grid[i][j] == 0) {
                    queue.add(new int[]{i, j});
                }
            }
        }
        int[][] directions = {
            {-1, 0}, {1, 0}, {0, -1}, {0, 1}
        };
        while (!queue.isEmpty()) {
            int[] cell = queue.remove();
            int i = cell[0];
            int j = cell[1];
            for (int[] dir: directions) {
                int nr = i + dir[0];
                int nc = j + dir[1];
                if (nr < 0 || nr >= grid.length || nc < 0 || nc >= grid[0].length || grid[nr][nc] != Integer.MAX_VALUE){
                    continue;
                }
                grid[nr][nc] = grid[i][j] + 1;
                queue.add(new int[]{nr, nc});
            }
        }
    }
}
