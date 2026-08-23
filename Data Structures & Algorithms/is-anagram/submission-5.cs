public class Solution {
    public bool IsAnagram(string s, string t) {
       var isValidAnagram = true;
if (s.Length != t.Length)
{
    isValidAnagram = false;
    return isValidAnagram;
}
var characterCounter = new Dictionary<char, int>();
foreach (char c in s)
{
    if (characterCounter.ContainsKey(c))
    {
        characterCounter[c]++;
    }
    else
    {
        characterCounter[c] = 1;
    }
}
foreach (char c in t)
{
    if (!characterCounter.ContainsKey(c))
    {
        isValidAnagram = false;
        return isValidAnagram;
    }
    else
    {
        characterCounter[c]--;
    }
}
isValidAnagram = !characterCounter.Any(x => x.Value < 0);
isValidAnagram = characterCounter.All(x => x.Value == 0);
return isValidAnagram;
    }
}
