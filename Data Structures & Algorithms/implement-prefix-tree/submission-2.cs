public class PrefixTree {
    private class TrieNode {
        public TrieNode[] children;
        public bool isWord;
        public TrieNode() {
            children = new TrieNode[26];
            isWord = false;
        }
    }
    private TrieNode root;
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        for (int i = 0; i < word.Length; i++) {
            int index = word[i] - 'a';
            if (curr.children[index] == null) {
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isWord = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        for (int i = 0; i < word.Length; i++) {
            int index = word[i]- 'a';
            if (curr.children[index] == null) {
                return false;
            }
            curr = curr.children[index];
        }
        return curr.isWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;
        for (int i = 0; i < prefix.Length; i++) {
            int index = prefix[i]- 'a';
            if (curr.children[index] == null) {
                return false;
            }
            curr = curr.children[index];
        }
        return true;
    }
}
