from collections import Counter
class Solution:
    def minWindow(self, s: str, t: str) -> str:
        count = Counter(t)
        left, start = 0, 0
        missing = len(t)
        min_length = float('inf')
        for right in range(len(s)):
            if count[s[right]] > 0:
                missing -= 1
            count[s[right]] -= 1
            while missing == 0:
                if right - left + 1 < min_length:
                    min_length = right - left + 1
                    start = left
                count[s[left]] += 1
                if count[s[left]] > 0:
                    missing += 1
                left += 1
        return "" if min_length == float('inf') else s[start:start+min_length]