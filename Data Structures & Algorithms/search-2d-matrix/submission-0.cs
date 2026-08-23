public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
int cols = matrix[0].Length;
int top = 0, bot = rows - 1;
int row = 0;

while (top <= bot)
{
    row = (top + bot) / 2;
    if (target > matrix[row][cols-1])
    {
        top = row + 1;
    }
    else if (target < matrix[row][0])
    {
        bot = row - 1;
    }
    else {
        break;
    }
}
if(!(top<=bot))
    return false;

int l = 0, r = cols - 1;
while (l<=r)
{
    var m = (l + r) / 2;
    if (target > matrix[row][m])
    {
        l = m + 1;
    }
    else if (target < matrix[row][m])
    {
        r = m - 1;
    }
    else {
        return true;
    }
}
return false;
    }
}
