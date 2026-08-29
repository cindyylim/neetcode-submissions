public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        for (int i =0; i <= heights.Length; i++) {
            int height = i == heights.Length ? 0 : heights[i];
            while(stack.Count > 0 && height < heights[stack.Peek()]) {
                int h = heights[stack.Pop()];
                int w;
                if (stack.Count == 0) {
                    w = i;
                }else {
                    w = i - stack.Peek() - 1;
                }
                maxArea = Math.Max(maxArea, w * h);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
