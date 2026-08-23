public class Solution {
    public bool hasDuplicate(int[] nums) {
        var listOfInt=new List<int>();
        bool isExist=false;
        for(int i=0;i<nums.Count();i++){
            if(listOfInt.Contains(nums[i])){
                isExist=true;
                break;
            }
            listOfInt.Add(nums[i]);
        }
       return isExist;
    }
}