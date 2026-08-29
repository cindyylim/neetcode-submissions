public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int result = right;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int total = 0;
            foreach (int pile in piles) {
                total += (pile + mid - 1)/ mid;
            }
            if (total <= h) {
                result = mid;
                right = mid - 1;
            }else {
                left = mid + 1;
            }
        }
        return result;
    }
}
