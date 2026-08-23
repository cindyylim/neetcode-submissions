class Solution {
    public boolean isAnagram(String s, String t) {
        int[] freq = new int[26];
        Arrays.fill(freq, 0);
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
