public class Solution {
    public int FirstMissingPositive(int[] nums) {
        List<int> list = nums.ToList();
        int result = 1;
        while(true)
        {
            if(list.Contains(result))
            {
                result++;
            }
            else{
                break;
            }
        }
        return result;
    }
}