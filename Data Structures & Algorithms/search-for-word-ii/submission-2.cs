public class Solution {
    private class TrieNode {
        public TrieNode[] children;
        public string word;
        public TrieNode() {
            children = new TrieNode[26];
            word = null;
        }
    }
    public List<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        foreach (string s in words) {
            InsertWord(root, s);
        }
        List<string> result = new List<string>();
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++){
                Dfs(i, j, board, root, result);
            }         
        }
        return result;
    }

    private void Dfs(int row, int col, char[][] board, TrieNode node, List<string> result) {
        if (row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] == '#') {
            return;
        }
        char c = board[row][col];
        TrieNode child = node.children[c-'a'];
        if (child == null) {
            return;
        }
        if (child.word != null) {
            result.Add(child.word);
            child.word = null;
        }
        board[row][col] = '#';
        Dfs(row + 1, col, board, child, result);
        Dfs(row - 1, col, board, child, result);
        Dfs(row, col + 1, board, child, result);
        Dfs(row, col - 1, board, child, result);
        board[row][col] = c;
    }
    private void InsertWord(TrieNode node, string s) {
        foreach (char c in s) {
            int index = c - 'a';
            if (node.children[index] == null) {
                node.children[index] = new TrieNode();
            }
            node = node.children[index];
        }
        node.word = s;
    }
}
