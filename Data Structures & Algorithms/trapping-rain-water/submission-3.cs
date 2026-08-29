public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int leftMax = height[left];
        int right = height.Length - 1;
        int rightMax = height[right];
        int res = 0;
        while(left < right) {
            if (leftMax < rightMax) {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                res += leftMax - height[left];
            }else {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                res += rightMax - height[right];
            }
        }
        return res;
    }
}
