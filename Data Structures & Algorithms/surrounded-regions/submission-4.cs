public class Solution {
    public void Solve(char[][] board) {
        for (int i = 0; i < board.Length; i++) {
            Dfs(board, i, 0);
            Dfs(board, i, board[0].Length - 1);
        }
        for (int j = 0; j < board[0].Length; j++) {
            Dfs(board, 0, j);
            Dfs(board, board.Length - 1, j);
        }
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (board[i][j] == 'O'){
                    board[i][j] = 'X';
                }else if (board[i][j] == '#') {
                    board[i][j] = 'O';
                }
            }
        }
    }
    private void Dfs(char[][] board, int row, int col) {
        if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] != 'O') {
            return;
        }
        board[row][col] = '#';
        Dfs(board, row + 1, col);
        Dfs(board, row - 1, col);
        Dfs(board, row, col + 1);
        Dfs(board, row, col - 1);
    }
}
