class Solution {
    public int longestConsecutive(int[] nums) {
        Set<Integer> seen = new HashSet<>();
        for (int num: nums) {
            seen.add(num);
        }
        int longest = 0;
        for (int i = 0; i < nums.length; i++) {
            if (!seen.contains(nums[i] - 1)){
                int curr = nums[i];
                int currLength = 0;
                while (seen.contains(curr)) {
                    curr++;
                    currLength++;
                }
                longest = Math.max(longest, currLength);
            }
        }
        return longest;
    }
}
