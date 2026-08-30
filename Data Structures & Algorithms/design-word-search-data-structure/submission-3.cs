public class WordDictionary {
    private class TrieNode {
        public TrieNode[] children;
        public bool isWord;
        public TrieNode() {
            children = new TrieNode[26];
            isWord = false;
        }
    }
    private TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode curr = root;
        foreach (char c in word) {
            int index = c - 'a';
            if (curr.children[index] == null) {
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isWord = true;
    }
    
    public bool Search(string word) {
        return Dfs(0, word, root);
    }
    private bool Dfs(int index, string word, TrieNode node) {
        if (index == word.Length){
            return node.isWord;
        }
        char c = word[index];
        if (c == '.') {
            foreach (TrieNode child in node.children) {
                if (child != null && Dfs(index + 1, word, child)){
                    return true;
                }
            }
            return false;
        }
        if (node.children[c - 'a'] == null) {
            return false;
        }
        return Dfs(index + 1, word, node.children[c-'a']);
    }
}
