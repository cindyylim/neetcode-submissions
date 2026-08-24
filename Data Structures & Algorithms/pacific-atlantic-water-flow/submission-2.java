class Solution {
    public List<List<Integer>> pacificAtlantic(int[][] heights) {
        boolean[][] pacific = new boolean[heights.length][heights[0].length];
        boolean[][] atlantic = new boolean[heights.length][heights[0].length];
        for (int c = 0; c < heights[0].length; c++) {
            dfs(pacific, 0, c, heights);
        }
        for (int r = 0; r < heights.length; r++) {
            dfs(pacific, r, 0, heights);
        }
        for (int c = 0; c < heights[0].length; c++) {
            dfs(atlantic, heights.length - 1, c, heights);
        }
        for (int r = 0; r < heights.length; r ++) {
            dfs(atlantic, r, heights[0].length - 1, heights);
        }
        List<List<Integer>> result = new ArrayList<>();
        for (int i =0; i < heights.length; i++) {
            for (int j = 0; j < heights[0].length; j++) {
                if (atlantic[i][j] && pacific[i][j]) {
                    result.add(List.of(i, j));
                }
            }
        }
        return result;
    }
    private void dfs(boolean[][] visited, int r, int c, int[][] heights){
        visited[r][c] = true;
        int[][] directions = {{-1, 0}, {1, 0}, {0, 1}, {0, -1}};
        for (int[] dir : directions) {
            int nr = r + dir[0];
            int nc = c + dir[1];
            if (nr < 0 || nr >= heights.length || nc < 0 || nc >= heights[0].length || visited[nr][nc] || heights[nr][nc] < heights[r][c]){
                continue;
            }
            dfs(visited, nr, nc, heights);
        }
    }
}
