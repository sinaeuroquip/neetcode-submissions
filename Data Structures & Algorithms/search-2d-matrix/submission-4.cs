public class Solution {
                        public bool SearchMatrix(int[][] matrix, int target)
        {
            //1  2  3
            //4  5  6
            //8  7  9
            //10 12 13
            //22 26 28
            //33 44 48
            //50 55 60
            var row = matrix.Length;
            var col = matrix[0].Length;
            var top = 0;
            var bottom = row - 1;

            while (top <= bottom)
            {
                var mid = top + (bottom - top) / 2;
                if (target >= matrix[mid][0] && target <= matrix[mid][col - 1])
                {
                    //to bynary search in this row
                    return BinarySearchInTheRow(matrix, target, mid);
                }
                else if (target > matrix[mid][col - 1])
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

        private bool BinarySearchInTheRow(int[][] matrix, int target, int suspectedRow)
        {
            //22 26 28
            var left = 0;
            var right = matrix[suspectedRow].Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (target == matrix[suspectedRow][mid])
                {
                    return true;
                }
                else if (target > matrix[suspectedRow][mid])
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
