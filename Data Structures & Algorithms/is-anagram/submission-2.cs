public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
    return false;

Dictionary<char, int> charCount = new Dictionary<char, int>();

foreach (char c in s)
{
    var lower_c = char.ToLower(c);
    charCount.TryAdd(lower_c, 0);
    charCount[lower_c]++;
}
foreach (char secondChar in t)
{
    var lower_secondChar = char.ToLower(secondChar);
    if (!charCount.ContainsKey(lower_secondChar))
        return false;

    charCount[lower_secondChar]--;

    if (charCount[lower_secondChar] < 0)
        return false;
}
return charCount.All(x => x.Value == 0);
    }
}
