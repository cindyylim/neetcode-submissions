public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        int length = 0;
        int start = 0;
        for(int i =0; i < s.Length; i++){
            if (map.ContainsKey(s[i])) {
                start = Math.Max(start, map[s[i]] + 1);
            }
            length = Math.Max(length, i - start + 1);
            map[s[i]] = i;
        }
        return length;
    }
}
