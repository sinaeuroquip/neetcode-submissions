public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0)
    return 0;

HashSet<int> set = new HashSet<int>(nums);
int longestScequenceCount = 0;

foreach (var num in set)
{
    if(!set.Contains(num-1))
    {
        int currentNum = num;
        int currentScequenceCount = 1;

        while(set.Contains(currentNum+1))
        {
            currentNum++;
            currentScequenceCount++;
        }
        longestScequenceCount = Math.Max(longestScequenceCount, currentScequenceCount);
    }
}

return longestScequenceCount;
    }
}
