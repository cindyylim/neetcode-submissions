class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        max_length = 0
        window = {}
        start = 0
        max_freq = 0
        for i, char in enumerate(s):
            window[char] = window.get(char, 0) + 1
            max_freq = max(max_freq, window[char])
            if (i - start + 1) - max_freq > k:
                window[s[start]] -= 1
                start += 1
            max_length = max(max_length, i - start + 1)
        return max_length 
