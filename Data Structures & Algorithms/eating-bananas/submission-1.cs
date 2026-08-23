public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
         var l = 1;
            var r = piles.Max();
            var res = r;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var totalHours = 0;
                foreach(var p in piles)
                {
                    totalHours += (int)Math.Ceiling((double)p / mid);
                }
                if(totalHours<=h)
                {
                    res = mid;
                    r= mid-1;
                }
                else
                {
                    l=mid + 1;
                }
            }
            return res;
    }
}
