public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        backtrack(nums, 0, new List<int>(), result);
        return result;
    }
    private void backtrack(int[] nums, int start, List<int> curr, List<List<int>> result) {
        result.Add(new List<int>(curr));
        for (int i = start; i < nums.Length; i++) {
            if (i > start && nums[i] == nums[i-1]) {
                continue;
            }
            curr.Add(nums[i]);
            backtrack(nums, i + 1, curr, result);
            curr.Remove(nums[i]);
        }
    }
}
