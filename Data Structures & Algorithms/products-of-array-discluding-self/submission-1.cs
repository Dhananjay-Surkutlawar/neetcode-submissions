public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        // int [] arr = new int [nums.Length];
        // for(int i = 0;i<nums.Length;i++)
        // {   
        //     int product = 1;
        //     for(int j =0; j<nums.Length;j++ )
        //     {
        //         if(i == j)
        //         continue;
        //         product  = product* nums[j];
        //     }
        //     arr[i]= product;
        // }
        // return arr;

        int [] left = new int [nums.Length];
        int [] right = new int [nums.Length];

        left[0] = 1 ; 
        right [nums.Length-1] = 1 ;

        for(int i = 1;i<nums.Length;i++)
        {
            left[i] = left[i-1] * nums[i-1] ;
        } 
        for(int i = nums.Length-2 ;i>-1 ; i--)
        {
            right[i] = right[i+1] * nums[i+1] ;
        }

        int [] ans = new int [nums.Length];

        for(int i = 0 ; i<nums.Length;i++)
        {
            ans[i] = left[i] * right [i] ; 
        }
        return ans;

    }
}
