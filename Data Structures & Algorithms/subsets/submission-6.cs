public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        backtrack(nums, 0, new List<int>(), result);
        return result;
    }
    private void backtrack(int[] nums, int start, List<int> curr, List<List<int>> result) {
        result.Add(new List<int>(curr));
        for(int i = start; i < nums.Length; i++) {
            curr.Add(nums[i]);
            backtrack(nums, i + 1, curr, result);
            curr.Remove(nums[i]);
        }
    }
}
