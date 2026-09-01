public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        List<List<string>> result = new List<List<string>>();
        char[][] board = new char[n][];
        for (int i = 0; i < n; i++) {
            board[i] = new char[n];
            Array.Fill(board[i], '.');
        }
        bool[] cols = new bool[n];
        bool[] diag1 = new bool[2*n -1];
        bool[] diag2 = new bool[2*n -1];
        Backtrack(0, n, board, cols, diag1, diag2, result);
        return result;
     }
     private void Backtrack(int row, int n, char[][] board, bool[] cols, bool[] diag1, bool[] diag2, List<List<string>> result) {
        if (row == n) {
            List<string> solution = new List<string>();
            foreach (char[] array in board) {
                solution.Add(new string(array));
            }
            result.Add(solution);
            return;
        }
        for (int col = 0; col < n; col++) {
            int d1 = row - col + n - 1;
            int d2 = row + col;
            if (cols[col] || diag1[d1] || diag2[d2]){
                continue;
            }
            board[row][col] = 'Q';
            cols[col] = true;
            diag1[d1] = true;
            diag2[d2] = true;
            Backtrack(row+ 1, n, board, cols, diag1, diag2, result);
            board[row][col] = '.';
            cols[col] = false;
            diag1[d1] = false;
            diag2[d2] = false;
        }
     }
}
