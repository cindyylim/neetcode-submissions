public class Solution {
    public int CharacterReplacement(string s, int k) {
        int length = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        int maxFreq = 0;
        int start = 0;
        for(int i =0; i< s.Length; i++) {
            map[s[i]] = map.GetValueOrDefault(s[i]) + 1;
            maxFreq = Math.Max(maxFreq, map[s[i]]);
            while (i - start + 1 > maxFreq + k) {
                map[s[start]] = map[s[start]] - 1;
                start++;
            }
            length = Math.Max(length, i - start + 1);
        }
        return length;
    }
}
