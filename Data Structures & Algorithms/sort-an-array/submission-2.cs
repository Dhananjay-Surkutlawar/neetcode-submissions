public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;
        //Bubble sort        
        for(int i = nums.Length-1; i>0;i--)
        {
            for(int j = 0;j<i;j++)
            {
                if(nums[j]>nums[j+1])
                {
                    int temp = nums[j];
                    nums[j]= nums[j+1];
                    nums[j+1]=temp;
                }
            }
        }

        // selection sort
        //select the minimin and swap wiht the left staring index
        // alawsy consider left side array that you swapped that is always sorted 
        for(int i=0;i<n-2;i++)
        {
            int min = i ;
            for(int j = i ; j<n-1;j++)
            {
                if(nums[j]<nums[min])
                {
                    min = j;
                }
            }
            int temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;
        }
        return nums;
    }
}