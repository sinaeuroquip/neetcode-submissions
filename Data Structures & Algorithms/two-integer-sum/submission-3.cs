public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new Dictionary<int, int>();
for (var x = 0; x < nums.Length; x++)
{
    var val = target - nums[x];
    if (result.ContainsKey(val))
    {
        return new int[] { result[val], x };
    }
    result.TryAdd(nums[x], x);
}
return new int[] { 2, 3 };
    }
}
