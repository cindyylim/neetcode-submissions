class Solution {
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        List<List<Integer>> res = new ArrayList<>();
        Arrays.sort(nums);
        backtrack(0, new ArrayList<>(), nums, res);
        return res;
    }
    private void backtrack(int i, List<Integer> subset, int[] nums, List<List<Integer>> res) {
        res.add(new ArrayList<>(subset));
        for (int j = i; j < nums.length; j++) {
            if (j > i && nums[j] == nums[j-1]) {
                continue;
            }
            subset.add(nums[j]);
            backtrack(j + 1, subset, nums, res);
            subset.remove(subset.size() - 1);
        }
    }
}
