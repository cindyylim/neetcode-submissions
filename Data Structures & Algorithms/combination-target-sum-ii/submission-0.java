class Solution {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        Arrays.sort(candidates);
        List<List<Integer>> res = new ArrayList<>();
        List<Integer> subset = new ArrayList<>();
        dfs(0, subset, 0, candidates, target, res);
        return res;
    }
    private void dfs(int index, List<Integer> subset, int curr, int[] candidates, int target, List<List<Integer>> res){
        if (curr == target){
            res.add(new ArrayList<>(subset));
            return;
        }
        for (int i = index; i < candidates.length; i++){
            if (i > index && candidates[i] == candidates[i-1]){
                continue;
            }
            if (curr + candidates[i] > target) {
                break;
            }
            subset.add(candidates[i]);
            dfs(i+1, subset, curr + candidates[i], candidates, target, res);
            subset.remove(subset.size() - 1);
        }
    }
}
