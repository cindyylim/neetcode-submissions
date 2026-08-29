public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var deque = new LinkedList<int>();
        int[] result = new int[nums.Length -k + 1];
        for(int i =0; i < nums.Length; i++) {
            while (deque.Count > 0 && deque.First.Value <= i - k) {
                deque.RemoveFirst();
            }
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i]) {
                deque.RemoveLast();
            }
            deque.AddLast(i);
            if (i >= k - 1 ) {
                result[i - k + 1] = nums[deque.First.Value];
            }
        }
        return result;
    }
}
