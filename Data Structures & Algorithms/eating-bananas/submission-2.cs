public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int right = piles.Max();
        int left = 1;
        int result = right;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            long time = 0;
            foreach (int pile in piles) {
                time += (pile + mid - 1) / mid;
            }
            if (time <= h) {
                result = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return result;
    }
}
