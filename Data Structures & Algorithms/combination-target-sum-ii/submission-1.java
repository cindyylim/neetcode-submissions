class Solution {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        List<List<Integer>> result = new ArrayList<>();
        Arrays.sort(candidates);
        backtrack(candidates, 0, new ArrayList<>(), result, target);
        return result;
    }
    private void backtrack(int[] candidates, int start, List<Integer> current, List<List<Integer>> result, int target) {
        if (target == 0) {
            result.add(new ArrayList<>(current));
            return;
        }
        if (target < 0) {
            return;
        }
        for (int i = start; i < candidates.length; i++) {
            if (i > start && candidates[i] == candidates[i-1]){
                continue;
            }
            current.add(candidates[i]);
            backtrack(candidates, i + 1, current, result, target - candidates[i]);
            current.remove(current.size() - 1);
        }
    }
}
