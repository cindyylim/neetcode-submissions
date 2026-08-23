class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        arr = range(0, len(nums) + 1)
        expected_sum = sum(arr)
        actual = sum(nums)
        return expected_sum - actual