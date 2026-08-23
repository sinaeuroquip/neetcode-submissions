public class Solution {
    public bool IsAnagram(string s, string t) {
       
            if (s.Length != t.Length)
                return false;
            var charecterCount = new Dictionary<char, int>();
            foreach (var c in s.ToLower())
            {
                charecterCount.TryAdd(c, 0);
                charecterCount[c]++;
            }
            foreach (var secondStrChar in t.ToLower())
            {
                if (!charecterCount.ContainsKey(secondStrChar))
                    return false;

                charecterCount[secondStrChar]--;
                if (charecterCount[secondStrChar] < 0)
                    return false;
            }
            return charecterCount.All(x => x.Value == 0);
    }
}
