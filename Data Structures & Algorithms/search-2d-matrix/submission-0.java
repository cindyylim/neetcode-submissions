class Solution {
    public boolean searchMatrix(int[][] matrix, int target) {
        int top = 0;
        int bottom = matrix.length - 1;
        while (top <= bottom) {
            int mid = top + ((bottom - top) / 2);
            if (target < matrix[mid][0]) {
                bottom = mid - 1;
            } else if (target > matrix[mid][matrix[0].length-1]) {
                top = mid + 1;
            } else {
                break;
            }
        }
        if (!(top <= bottom)) {
            return false;
        }
        int row = (top + bottom) / 2;
        int left = 0;
        int right = matrix[0].length - 1;
        while (left <= right) {
            int mid = left + ((right - left) / 2);
            if (target < matrix[row][mid]) {
                right = mid - 1;
            } else if (target > matrix[row][mid]) {
                left = mid + 1;
            }else {
                return true;
            }
        }
        return false;
    }
}
