public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach(char c in t) {
            freq[c] = freq.GetValueOrDefault(c) + 1;
        }
        int needed = freq.Count;
        int minStart = 0;
        int minLength = int.MaxValue;
        int start = 0;
        for (int i = 0; i < s.Length; i++) {
            if (freq.ContainsKey(s[i])) {
                freq[s[i]]--;
                if (freq[s[i]] == 0) {
                    needed--;
                }
            }
            while (needed == 0) {
                int windowLength = i - start + 1;
                if (windowLength < minLength) {
                    minLength = windowLength;
                    minStart = start;
                }
                if (freq.ContainsKey(s[start])) {
                    freq[s[start]]++;
                    if(freq[s[start]] > 0) {
                        needed++;
                    }
                }
                start++;
            }
        }
        return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
    }
}
