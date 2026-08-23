class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        freq = {}
        max_freq = 0
        start = 0
        longest = 0
        for i, char in enumerate(s):
            freq[char] = freq.get(char, 0) + 1
            max_freq = max(max_freq, freq[char])
            while max_freq + k < i - start + 1:
                freq[s[start]] -= 1
                start += 1
            longest = max(longest, i - start + 1)
        return longest