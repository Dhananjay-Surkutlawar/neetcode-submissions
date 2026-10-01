public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> list = new HashSet<int>();
        foreach(int n in nums)
        {
           if(!list.Add(n))
           return true; 
        }
        return false;
    }
}