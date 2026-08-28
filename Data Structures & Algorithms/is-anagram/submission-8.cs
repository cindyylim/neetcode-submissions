public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] count = new int[26];
        foreach (char c in s) {
            count[c-'a'] ++;
        }
        foreach (char c in t) {
            count[c-'a']--;
        }
        foreach (int num in count) {
            if (num != 0) {
                return false;
            }
        }
        return true;
    }
}
