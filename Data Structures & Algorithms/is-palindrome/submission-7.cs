public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
while (left < right)
{
    var leftChar = s[left];
    var rightChar = s[right];

    var isLeftCharecterValid = char.IsLetterOrDigit(leftChar);
    var isRightCharecterValid = char.IsLetterOrDigit(rightChar);
    if (!isLeftCharecterValid)
    {
        left++;
        continue;
    }
    if(!isRightCharecterValid)
    {
        right--;
        continue;
    }
    if (isLeftCharecterValid && isRightCharecterValid)
    {
        if (char.ToLowerInvariant(leftChar) != char.ToLowerInvariant(rightChar))
            return false;
    }
    left++;
    right--;
}
return true;
    }
}
