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

            var topRow = 0;
            var bottomRow = row - 1;
            while (topRow <= bottomRow)
            {
                var midRow = topRow + (bottomRow - topRow) / 2;
                if (target >= matrix[midRow][0] && target <= matrix[midRow][col - 1])
                {
                    // do binary search
                    return SearchInRow(matrix, target, midRow);
                }
                else if (target > matrix[midRow][col - 1])
                {
                    topRow = midRow + 1;
                }
                else
                {
                    bottomRow = midRow - 1;
                }
            }
            return false;
        }

        private bool SearchInRow(int[][] matrix, int target, int row)
        {
            //22 26 28
            var l = 0;
            var r = matrix[row].Length - 1;
            while (l <= r) {
                var mid = l + (r - l) / 2;
                if (target == matrix[row][mid])
                {
                    return true;
                }
                else if (target > matrix[row][mid])
                {
                    l= mid + 1;
                }
                else { 
                 r = mid-1;
                }
            }
            return false;
        }

}
