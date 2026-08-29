public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            int[] temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }
        int m = nums1.Length;
        int n = nums2.Length;
        int left =0;
        int right = m;
        int half = (m + n + 1) / 2;
        while (left <= right) {
            int i = left + (right - left) / 2;
            int j = half - i;
            int left1 = i > 0 ? nums1[i-1] : int.MinValue;
            int right1 = i < m ? nums1[i] : int.MaxValue;
            int left2 = j > 0 ? nums2[j-1] : int.MinValue;
            int right2 = j < n ? nums2[j] : int.MaxValue;
            if (left1 <= right2 && left2 <= right1) {
                if ((m + n) % 2 == 0) {
                    return (double)((Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0);
                }else{
                    return Math.Max(left1, left2);
                }
            }
            if (left1 > right2) {
                right = i - 1;
            }else {
                left = i + 1;
            }
        }
        return -1;
    }
}
