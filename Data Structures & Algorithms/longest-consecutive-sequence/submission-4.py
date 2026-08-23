class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        seen = set()
        for num in nums:
            seen.add(num)
        longest = 0
        for num in nums:
            if num - 1 not in seen:
                start = num
                length = 1
                while start + 1 in seen:
                    start += 1
                    length += 1
                longest = max(longest, length)
        return longest