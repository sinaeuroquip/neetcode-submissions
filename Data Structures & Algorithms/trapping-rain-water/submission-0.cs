public class Solution {
    public int Trap(int[] height) {
         var left = 0;
 var right = height.Length - 1;
 var left_max = height[left];
 var right_max = height[right];
 var water_trap = 0;

 while (left < right)
 {
     if (left_max < right_max)
     {
         water_trap += left_max - height[left];
         left++;
         left_max=Math.Max(left_max, height[left]);
     }
     else
     {
         water_trap += right_max - height[right];
         right--;
         right_max=Math.Max(right_max, height[right]);
     }
 }
 return water_trap;
    }
}
