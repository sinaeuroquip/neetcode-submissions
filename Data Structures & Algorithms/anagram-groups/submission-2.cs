public class Solution {
public List<List<string>> GroupAnagrams(string[] strs)
{
    var result = new Dictionary<string, List<string>>();
foreach (var str in strs)
{
    var allSmallLetter = new int[26];
    foreach (var chr in str)
    {
        allSmallLetter[chr - 'a']++;
    }
    var key = string.Join(',', allSmallLetter);
    if (!result.ContainsKey(key))
    {
        result[key] = new List<string>();
    }
    result[key].Add(str);
}
return result.Values.ToList<List<string>>();
}
}
