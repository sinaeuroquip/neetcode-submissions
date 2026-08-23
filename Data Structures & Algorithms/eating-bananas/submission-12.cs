public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var left = 1;
var right = piles.Max();
var res= right;
while(left<=right)
{
    var mid = left + (right - left) / 2;
    var totalHours = 0;
    foreach (var pile in piles)
    {
        totalHours += (int)Math.Ceiling((double)pile / mid);
    }
    if(totalHours<=h)
    {
        res = mid;
        right = mid - 1;
    }
    else
    {
        left = mid + 1;
    }
}
return res;
    }
}
