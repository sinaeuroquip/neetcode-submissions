public class Solution {
    public int Trap(int[] height) {
        
            var left = 0;
            var right = height.Length - 1;
            var left_max = height[left];
            var right_max = height[right];
            var max_containWater = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    max_containWater += left_max - height[left];
                    left++;
                    left_max = Math.Max(left_max, height[left]);
                }
                else
                {
                    max_containWater += right_max - height[right];
                    right--;
                    right_max=Math.Max(right_max, height[right]);
                }
            }
            return max_containWater;
    }
}
