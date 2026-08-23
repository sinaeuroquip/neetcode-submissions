public class Solution {

    public string Encode(IList<string> strs) {
            string encodedStr = string.Empty;
            foreach (var str in strs)
            {
                encodedStr = encodedStr + str.Length + "#" + str;
            }
            return encodedStr;
    }

    public List<string> Decode(string s) {
                                var result = new List<string>();
            var i = 0;
            while (i < s.Length)
            {
                var j = i;
                while (s[j] != '#')
                {
                    j++;
                }
                var length = int.Parse(s.Substring(i, j - i));
                i = j + 1;
                result.Add(s.Substring(i, length));
                i = i + length;
            }
            return result;
   }
}
