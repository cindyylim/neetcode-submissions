class Solution {
    public int characterReplacement(String s, int k) {
        Map<Character, Integer> freq = new HashMap<>();
        int start = 0;
        int longest = 0;
        int maxFreq = 0;
        for(int i = 0; i < s.length(); i++) {
            freq.compute(s.charAt(i), (key, val) -> val == null ? 1 : val + 1);
            maxFreq = Math.max(maxFreq, freq.get(s.charAt(i)));
            while (i - start + 1 - maxFreq > k) {
                freq.put(s.charAt(start), freq.get(s.charAt(start)) - 1);
                start++;
            }
            longest = Math.max(longest, i - start + 1);
        }
        return longest;
    }
}
