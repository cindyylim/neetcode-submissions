class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        state = {}
        for i, num in enumerate(nums):
            diff = target - num
            if diff in state:
                return [state[diff], i]
            state[num] = i
        return [-1,-1]