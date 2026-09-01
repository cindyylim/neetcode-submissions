public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(candidates);
        Backtrack(candidates, 0, new List<int>(), result, target);
        return result;
    }
    private void Backtrack(int[] candidates, int start, List<int> curr, List<List<int>> result, int target) {
        if (target == 0) {
            result.Add(new List<int>(curr));
        }
        if (target < 0) {
            return;
        }
        for (int i = start; i < candidates.Length; i++) {
            if (i > start && candidates[i] == candidates[i-1]){
                continue;
            }
            curr.Add(candidates[i]);
            Backtrack(candidates, i + 1, curr, result, target - candidates[i]);
            curr.Remove(candidates[i]);
        }
    }
}
