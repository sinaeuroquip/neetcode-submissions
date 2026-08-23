public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
      Array.Sort(nums);
var res = new List<List<int>>();
for (int i = 0; i < nums.Length; i++)
{
    if (i != 0 && nums[i] == nums[i - 1])
        continue;

    var l = i + 1;
    var r = nums.Length - 1;

    while (l < r)
    {
        var total = nums[i] + nums[l] + nums[r];
        if (total > 0)
            r--;
        else if (total < 0)
            l++;
        else
        {
            res.Add(new List<int>() { nums[i], nums[l], nums[r] });
            l++;
            while (l < r && nums[l] == nums[l-1])
                l++;
        }
    }
}
return res;
    }
}
