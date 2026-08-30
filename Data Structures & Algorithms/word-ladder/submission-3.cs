public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> words = new HashSet<string>(wordList);
        if (!words.Contains(endWord)){
            return 0;
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int length = 1;
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++) {
                string word = queue.Dequeue();
                if (word.Equals(endWord)){
                    return length;
                }
                char[] chars = word.ToCharArray();
                for (int j = 0; j < chars.Length; j++) {
                    char original = chars[j];
                    for (char c = 'a'; c <= 'z'; c++) {
                        if (original == c) {
                            continue;
                        }
                        chars[j] = c;
                        string nextWord = new string(chars);
                        if (words.Contains(nextWord)){
                            queue.Enqueue(nextWord);
                            words.Remove(nextWord);
                        }
                    }
                    chars[j] = original;
                }
            }
            length++;
        }
        return 0;
    }
}
