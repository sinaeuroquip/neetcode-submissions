public class Solution {
    public int LengthOfLongestSubstring(string s) {

            int res = 0;
            int left = 0;
            HashSet<char> set = new HashSet<char>();
            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                res = Math.Max(res, right -left + 1);
            }

            return res;
    }
}
