public class Solution {
    public int CharacterReplacement(string s, int k) {
        int longestStringLength = 0;
int maxFrequency = 0;
int l = 0;

Dictionary<char, int> charCount = new Dictionary<char, int>();

for (int r = 0; r < s.Length; r++)
{
    char c = s[r];
    if (!charCount.ContainsKey(c))
    {
        charCount[c] = 0;
    }
    charCount[c]++;
    maxFrequency = Math.Max(maxFrequency, charCount[c]);
    int currentLength = r - l + 1;
    if (currentLength-maxFrequency > k)
    {
        charCount[s[l]]--;
        l++;
    }
    currentLength = r - l + 1;
    longestStringLength = Math.Max(longestStringLength, currentLength);

}
return longestStringLength;
    }
}
