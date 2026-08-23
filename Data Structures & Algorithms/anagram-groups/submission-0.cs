public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
    var grpAnagram = new List<List<string>>();
    var alreadyScanned = new HashSet<string>();
    for (int i = 0; i < strs.Length; i++)
    {
        var firstSortedElement = SortString(strs[i]);
        if (alreadyScanned.Contains(firstSortedElement))
            continue;

        var grp = new List<string>() { strs[i] };

        for (int j = i + 1; j < strs.Length; j++)
        {
            if (strs[i].Length != strs[j].Length)
                continue;

            var nextSortedElement = SortString(strs[j]);

            if (firstSortedElement == nextSortedElement)
            {
                grp.Add(strs[j]);
            }
        }
        grpAnagram.Add(grp);
        alreadyScanned.Add(firstSortedElement);
    }
    return grpAnagram;
}

public string SortString(string str)
{
    char[] chars = str.ToCharArray();
    Array.Sort(chars);

    return new string(chars);
}
}
