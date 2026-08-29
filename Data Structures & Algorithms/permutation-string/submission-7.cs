public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }
        int[] count = new int[26];
        foreach(char c in s1) {
            count[c - 'a']++;
        }
        int[] window = new int[26];
        int start = 0;
        for(int i = 0; i < s2.Length; i++) {
            window[s2[i] - 'a']++;
            if (i - start + 1 > s1.Length) {
                window[s2[start] - 'a']--;
                start++;
            }
            if (window.SequenceEqual(count)) {
                return true;
            }
        }
        return false;
    }
}
