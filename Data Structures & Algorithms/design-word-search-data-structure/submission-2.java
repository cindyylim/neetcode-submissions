class WordDictionary {
    class TrieNode {
        private TrieNode[] children = new TrieNode[26];
        private boolean isWord = false;
    }
    private TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }

    public void addWord(String word) {
        TrieNode curr = root;
        for (char c: word.toCharArray()) {
            int index = c - 'a';
            if (curr.children[index] == null) {
                curr.children[index] = new TrieNode();
            }
            curr = curr.children[index];
        }
        curr.isWord = true;
    }

    public boolean search(String word) {
        return dfs(0, word, root);
    }

    private boolean dfs(int index, String word, TrieNode node) {
        if (index == word.length()) {
            return node.isWord;
        }
        char c = word.charAt(index);
        if (c == '.') {
            for (TrieNode child : node.children) {
                if (child != null && dfs(index + 1, word, child)){
                    return true;
                }
            }
            return false;
        }
        int childIndex = c - 'a';
        if (node.children[childIndex]== null) {
            return false;
        }
        return dfs(index + 1, word, node.children[childIndex]);
    }
}
