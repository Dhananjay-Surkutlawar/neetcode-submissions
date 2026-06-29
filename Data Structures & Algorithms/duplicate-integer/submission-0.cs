public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        for(int i =0; i<nums.Length;i++)
        {
            bool isAdded  = set.Add(nums[i]);
            if(!isAdded)
            {
                return true;
            }
        }
        return false;
    }
}