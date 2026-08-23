public class Solution {
    public bool hasDuplicate(int[] nums) {
        var listOfint=new List<int>();
foreach (int i in nums)
{
    if (listOfint.Contains(i))
    {
        return true;
    }
    listOfint.Add(i);
}
return false;
    }
}