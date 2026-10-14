public class Solution {
    public void Rotate(int[] nums, int k) {

         for (int i = 0; i < k; i++)
        {
            int last = nums[nums.Length - 1];
           for(int j=nums.Length-1;j>0;j--)
           {
               nums[j]=nums[j-1];
               
           }
            

            nums[0] = last;
        }
    }
}