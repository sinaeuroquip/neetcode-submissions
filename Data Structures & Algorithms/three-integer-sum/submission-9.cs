public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
       Array.Sort(nums);
var res = new List<List<int>>();

for (int i = 0; i < nums.Length; i++)
{
    if (i > 0 && nums[i] == nums[i - 1])
        continue;

    var left = i + 1;
    var right = nums.Length - 1;

    while (left < right)
    {
        var total = nums[i] + nums[left] + nums[right];
        if (total > 0)
            right--;
        if (total < 0)
            left++;
        if (total == 0)
        {
            res.Add(new List<int>() { nums[i], nums[left], nums[right] });
            left++;
            while (left < right && nums[left] == nums[left - 1])
                left++;
        }
    }
}
return res;
    }
}
