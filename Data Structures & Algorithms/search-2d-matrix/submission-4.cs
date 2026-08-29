public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0;
        int right = matrix[0].Length * matrix.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int row = mid / matrix[0].Length;
            int col = mid % matrix[0].Length;
            if (matrix[row][col] == target) {
                return true;
            }
            if (matrix[row][col] < target) {
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        return false;
    }
}
