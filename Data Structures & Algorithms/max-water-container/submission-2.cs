public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
int left = 0, right = heights.Length - 1;

while (left <= right)
{
    var area = (Math.Min(heights[left], heights[right])) * (right - left);
    res = Math.Max(area,res);
    if (heights[left] < heights[right])
        left++;
    else
        right--;
}
return res;
    }
}
