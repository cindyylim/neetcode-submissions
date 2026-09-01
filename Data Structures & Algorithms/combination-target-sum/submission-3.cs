public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new List<List<int>>();
        Backtrack(nums, 0, new List<int>(), result, target);
        return result;
    }
    private void Backtrack(int[] nums, int start, List<int> curr, List<List<int>> result, int target) {
        if (target == 0) {
            result.Add(new List<int>(curr));
        }
        if (target < 0) {
            return;
        }
        for (int i = start; i < nums.Length; i++) {
            curr.Add(nums[i]);
            Backtrack(nums, i, curr, result, target - nums[i]);
            curr.Remove(nums[i]);
        }
    }
}
