public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums) {
            set.Add(num);
        }
        int longest = 0;
        foreach(int num in set) {
            if (!set.Contains(num - 1)) {
                int length = 1;
                int curr = num + 1;
                while (set.Contains(curr)) {
                    length++;
                    curr++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
