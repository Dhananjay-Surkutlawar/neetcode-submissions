public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int [] arr = new int [nums.Length];
        for(int i = 0;i<nums.Length;i++)
        {   
            int product = 1;
            for(int j =0; j<nums.Length;j++ )
            {
                if(i == j)
                continue;
                product  = product* nums[j];
            }
            arr[i]= product;
        }
        return arr;

    }
}
