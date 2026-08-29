public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;
        while (left < right) {
            int height = Math.Min(heights[left], heights[right]);
            int width = right - left;
            maxArea = Math.Max(height*width, maxArea);
            if (heights[left] < heights[right]) {
                left++;
            }else{
                right--;
            }
        }
        return maxArea;
    }
}
