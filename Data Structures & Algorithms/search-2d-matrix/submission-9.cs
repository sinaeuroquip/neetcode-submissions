public class Solution {
                public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = matrix.Length;
            var col = matrix[0].Length;
            var top = 0;
            var bottom = row - 1;

            while (top <= bottom)
            {
                var mid = top + (bottom - top) / 2;
                if (target >= matrix[mid][0] && target <= matrix[mid][col - 1])
                {
                    // search in this row
                    return SearchInRow(matrix, mid, target);
                }
                if (target >= matrix[mid][col - 1])
                {
                    top = mid + 1;
                }
                else
                {
                    bottom = mid - 1;
                }
            }
            return false;
        }
        private bool SearchInRow(int[][] matrix, int rowNo, int target)
        {
            var left = 0;
            var right = matrix[rowNo].Length-1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (target == matrix[rowNo][mid])
                {
                    return true;
                }
                else if (target > matrix[rowNo][mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
}