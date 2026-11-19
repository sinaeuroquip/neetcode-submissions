public class Solution {
    public bool CheckInclusion(string s1, string s2) {
                    //s1 = "ab";
            //s2 = "ertbaghe";

            if (s1.Length > s2.Length)
                return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

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
                var val = map[rCh];
                if (val > 0)
                {
                    count--;
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    map[rCh] = val - 1;

                    if (r - l + 1 == s1.Length)
                    {
                        var leftCh = s2[l];
                        int leftVal = map[leftCh];
                        if (leftVal >= 0)
                        {
                            count++;
                        }
                        map[leftCh] = leftVal + 1;
                        l++;
                    }
                }
            }
            return false;

    }
}
