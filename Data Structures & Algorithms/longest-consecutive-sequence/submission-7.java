class Solution {
    public int longestConsecutive(int[] nums) {
        Set<Integer> seen = new HashSet<>();
        for (int num: nums) {
            seen.add(num);
        }
        int longest = 0;
        for (int num: seen) {
            if (!seen.contains(num - 1)){
                int curr = num;
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
