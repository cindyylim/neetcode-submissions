class Solution {
    public int[] maxSlidingWindow(int[] nums, int k) {
        Deque<Integer> queue = new ArrayDeque<>();
        int[] result = new int[nums.length - k + 1];
        int resultIndex = 0;
        for (int i = 0; i < nums.length; i++) {
            while(!queue.isEmpty() && queue.peekFirst() <= i - k){
                queue.pollFirst();
            }
            while(!queue.isEmpty() && nums[queue.peekLast()] < nums[i]){
                queue.pollLast();
            }
            queue.offer(i);
            if (i >= k - 1) {
                result[resultIndex++] = nums[queue.peekFirst()];
            }
        }
        return result;
    }
}
