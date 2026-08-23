public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                      Dictionary<int, int> prevMaps = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    var diff = target - nums[i];
    if (!prevMaps.ContainsKey(diff))
    {
        prevMaps.Add(nums[i], i);
    }
    else
    {
        return new int[] { prevMaps[diff], i };
    }
}
return new int[0];
    }
}
