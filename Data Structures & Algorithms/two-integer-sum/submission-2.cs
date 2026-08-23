public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                    var keepValAndIndex = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var val = target - nums[i];
                if (keepValAndIndex.ContainsKey(val))
                    return new int[] { keepValAndIndex[val], i };

                keepValAndIndex[nums[i]] = i;
            }
            return new int[] { 0, 0 };
    }
}
