public class Solution {
    public int Search(int[] nums, int target) {
     //int[] nums = { 5, 6, 7, 1, 2, 3, 4 };
     //int target = 3;

     var b=0;
     var e=nums.Length-1;
     while(b<=e)
     {
        var m=b+(e-b)/2;
        if(nums[m]==target)
        {
            return m;
        }
        if(nums[b]<=nums[m])
        {
            if(nums[b]<=target && target<=nums[m])
            {
                e=m-1;
            }
            else{
                b=m+1;
            }
        }
        else{
             if(nums[m]<= target && target<=nums[e])
             {
                b=m+1;
             }
             else{
                e=m-1;
             }
        }

     }
     return -1;
    }
}
