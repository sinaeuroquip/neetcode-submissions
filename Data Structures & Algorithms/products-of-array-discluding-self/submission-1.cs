public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        var multiplicationval = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    multiplicationval = multiplicationval * nums[j];
                }
            }
            result[i]=multiplicationval;
            multiplicationval = 1;
        }

        return result;
    }
}
