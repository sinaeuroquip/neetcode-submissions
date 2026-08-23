public class Solution {
    public int LongestConsecutive(int[] nums) {
         if (nums == null || nums.Length == 0)
     return 0;

 Array.Sort(nums);

 int longestScequenceCount = 1;
 int currentScequence = 1;

 for (int i = 1; i < nums.Length; i++)
 {
     if (nums[i] == nums[i - 1])
         continue;

     if (nums[i] == nums[i - 1] + 1)
     {
         currentScequence++;
     }
     else
     {
         currentScequence = 1;
     }
     longestScequenceCount = Math.Max(longestScequenceCount, currentScequence);
 }
 return longestScequenceCount;
    }
}
