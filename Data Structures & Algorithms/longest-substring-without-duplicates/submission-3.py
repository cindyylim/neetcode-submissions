class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        start = 0
        count = {}
        max_length = 0
        
        for i in range(len(s)):
            if s[i] in count:
                start = max(start, count[s[i]] + 1)
            count[s[i]] = i
            max_length = max(max_length, i - start + 1)
        return max_length