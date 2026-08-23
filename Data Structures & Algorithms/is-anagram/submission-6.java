class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        }
        int[] freq = new int[26];
        
        for (char c: s.toCharArray()) {
            freq[c - 'a'] += 1;
        }
        for (char c: t.toCharArray()) {
            freq[c - 'a'] -=1;
        }
        for (int count: freq) {
            if (count != 0) return false;
        }
        return true;
    }
}
