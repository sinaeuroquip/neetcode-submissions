public class Solution {
        public bool SearchMatrix(int[][] matrix, int target)
{
    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        return false;

    int row = matrix.Length;
    int col = matrix[0].Length;

    int startingRow = 0, endingRow = row - 1;

    while (startingRow <= endingRow)
    {
        int midRow = startingRow + (endingRow - startingRow) / 2;

        if (target >= matrix[midRow][0] && target <= matrix[midRow][col - 1])
        {
            return SearchInRow(matrix, target, midRow); // <- key fix
        }
        else if (target > matrix[midRow][col - 1])
        {
            startingRow = midRow + 1;
        }
        else
        {
            endingRow = midRow - 1;
        }
    }

    return false;
}

private bool SearchInRow(int[][] matrix, int target, int row)
{
    int st = 0;
    int end = matrix[row].Length - 1;

    while (st <= end) // <- key fix
    {
        int mid = st + (end - st) / 2;

        if (target == matrix[row][mid]) return true;
        if (target > matrix[row][mid]) st = mid + 1;
        else end = mid - 1;
    }

    return false;
}

}
