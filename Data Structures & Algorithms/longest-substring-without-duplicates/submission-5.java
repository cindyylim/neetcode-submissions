class Solution {
    public int lengthOfLongestSubstring(String s) {
        Map<Character, Integer> map = new HashMap<>();
        int start = 0;
        int longest = 0;
        for(int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            if (map.containsKey(c)){
                start = Math.max(start, map.get(c) + 1);
            }
            longest = Math.max(longest, i - start + 1);
            map.put(c, i);
        }
        return longest;
    }
}
