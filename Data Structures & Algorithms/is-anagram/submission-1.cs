public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
{
    return false;
}

Dictionary<char, int> count = new Dictionary<char, int>();
foreach (char c in s)
{
    var lower_c = char.ToLowerInvariant(c);
    count.TryAdd(lower_c, 0);
    count[lower_c]++;
}
foreach (char c in t)
{
    var lower_c = char.ToLowerInvariant(c);
    if (!count.ContainsKey(lower_c))
        return false;

    count[lower_c]--;

    if (count[lower_c] < 0)
    {
        return false;
    }
}
return count.All(x => x.Value == 0);
    }
}
