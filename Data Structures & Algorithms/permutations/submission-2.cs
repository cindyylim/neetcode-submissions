public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Backtrack(nums, new List<int>(), result);
        return result;
    }
    private void Backtrack(int[] nums, List<int> curr, List<List<int>> result) {
        if (nums.Length == curr.Count) {
            result.Add(new List<int>(curr));
            return;
        }
        foreach (int num in nums) {
            if (curr.Contains(num)){
                continue;
            }
            curr.Add(num);
            Backtrack(nums, curr, result);
            curr.Remove(num);
        }
    }
}
