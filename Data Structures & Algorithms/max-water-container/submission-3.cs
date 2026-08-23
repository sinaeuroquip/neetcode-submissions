public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
var r = heights.Length - 1;
var max_area = 0;
while (l < r) {
    max_area = Math.Max(Math.Min(heights[l], heights[r]) * (r - l), max_area);
    if (heights[l] < heights[r])
        l++;
    else
        r--;
}
return max_area;
    }
}
