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
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1])
                            left++;
                    }
                }
            }
            return res;
    }
}
