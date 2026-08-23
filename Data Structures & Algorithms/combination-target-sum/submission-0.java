class Solution {
    public List<List<Integer>> combinationSum(int[] nums, int target) {
        List<List<Integer>> res = new ArrayList<>();
        List<Integer> curr = new ArrayList<>();
        dfs(nums, 0, 0, curr, target, res);
        return res;
    }
        private void dfs(int[] nums, int i, int total, List<Integer> curr, int target, List<List<Integer>> res) {
            if (total == target) {
                res.add(new ArrayList<>(curr));
                return;
            }
            if (i >= nums.length || total > target){
                return;
            }
            curr.add(nums[i]);
            dfs(nums, i, total + nums[i], curr, target, res);
            curr.remove(curr.size()-1);
            dfs(nums, i+1, total, curr, target, res);
        }
    
}
