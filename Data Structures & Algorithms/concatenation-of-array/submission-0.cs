public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int [] result  = new int [n*2];
        for(int i =0; i <nums.Length;i++)
        {
            result[i] = nums[i];
            result[n+i] = nums[i];
        }
        return result;
    }
}
