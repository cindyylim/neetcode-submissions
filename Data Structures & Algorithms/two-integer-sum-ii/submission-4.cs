public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length- 1;
        while (left < right) {
            if(numbers[left] + numbers[right] == target) {
                return new int[]{left+1, right+1};
            }
            if (numbers[left]+numbers[right] < target) {
                left++;
            }else {
                right--;
            }
        }
        return new int[0];
    }
}
