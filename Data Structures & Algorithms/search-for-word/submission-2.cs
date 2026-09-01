public class Solution {
    public bool Exist(char[][] board, string word) {
        for (int i =0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (dfs(i, j, board, word, 0)){
                    return true;
                }
            }
        }
        return false;
    }
    private bool dfs(int i, int j, char[][] board, string word, int index) {
        if (index == word.Length){
            return true;
        }
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index]) {
            return false;
        }
        char temp = board[i][j];
        board[i][j] = '#';
        bool found = dfs(i + 1, j, board, word, index + 1) || dfs(i - 1, j, board, word, index + 1) || dfs(i, j + 1, board, word, index + 1) || dfs (i, j - 1, board, word, index + 1);
        board[i][j] = temp;
        return found;
    }
}
