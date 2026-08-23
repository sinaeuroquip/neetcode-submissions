public class Solution {
public List<List<string>> GroupAnagrams(string[] strs)
{
     Dictionary<string, List<string>> groupAnagram = new Dictionary<string, List<string>>();
 foreach (string str in strs)
 {
     var allSmallCharecter = new int[26];

     foreach (char chr in str)
     {
         allSmallCharecter[chr - 'a']++;
     }
     var key = string.Join(",", allSmallCharecter);
     if (!groupAnagram.ContainsKey(key))
     {
         groupAnagram[key] = new List<string>();
     }
     groupAnagram[key].Add(str);
 }
 return groupAnagram.Values.ToList<List<string>>();
}
}
