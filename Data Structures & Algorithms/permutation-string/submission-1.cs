public class Solution {
    public bool CheckInclusion(string s1, string s2) {
    
            if (s1.Length > s2.Length)
            {
                return false;
            }
            var map = new Dictionary<char, int>();
            foreach (var ch in s1)
            {
                if (!map.ContainsKey(ch))
                {
                    map[ch] = 0;
                }
                map[ch]++;
            }
            var l = 0;
            var count = s1.Length;

            for (int r = 0; r < s2.Length; r++)
            {
                var rCh = s2[r];
                if (!map.ContainsKey(rCh))
                {
                    map[rCh] = 0;
                }
                var rChVal = map[rCh];
                if (rChVal > 0)
                {
                    count--;
                }
                if (count == 0)
                {
                    return true;
                }
                map[rCh] = rChVal - 1;
                if (r - l + 1 == s1.Length)
                {
                    var lCh = s2[l];
                    var lChVal = map[lCh];
                    if (lChVal >= 0)
                    {
                        count++;
                    }
                    map[lCh] = lChVal + 1;
                    l++;
                }
            }
            return false;                   
                       
    }
}
