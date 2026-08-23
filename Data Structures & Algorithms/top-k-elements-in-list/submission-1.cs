public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary<int, int> count = new Dictionary<int, int>();
 List<int>[] freq = new List<int>[nums.Length + 1];
 for (int i = 0; i < freq.Length; i++)
 {
     freq[i] = new List<int>();
 }
 foreach (int num in nums)
 {
     if (count.ContainsKey(num))
     {
         count[num]++;
     }
     else
     {
         count[num] = 1;
     }
 }
 foreach (var elm in count)
 {
     freq[elm.Value].Add(elm.Key);
 }
 var result = new int[k];
 var index = 0;
 for (int i = freq.Length - 1; i > 0 && index < k; i--)
 {
     foreach (var elm in freq[i])
     {
         result[index++] = elm;
         if (index == k)
         {
             return result;
         }
     }
 }
 return result;
    }
}
