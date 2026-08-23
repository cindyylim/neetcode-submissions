class Solution {
    public boolean checkInclusion(String s1, String s2) {
        if (s1.length() > s2.length()) {
            return false;
        }
        int[] need = new int[26];
        int[] window = new int[26];
        for (char c: s1.toCharArray()) {
            need[c-'a'] += 1;
        }
        int start = 0;
        for (int end = 0; end < s2.length(); end++) {
            window[s2.charAt(end) - 'a'] ++;
            if (end - start + 1 > s1.length()) {
                window[s2.charAt(start) - 'a']--;
                start++;
            }
            if (Arrays.equals(need, window)) {
                return true;
            }
        }
        return false;
    }
}
