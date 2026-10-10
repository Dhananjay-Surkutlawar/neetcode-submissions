public class Solution {
    public void SortColors(int[] nums) {

        int left=0;
        int right= nums.Length-1;
        int current =0;
        while (current <= right)
        {
            if (nums[current] == 0)
            {
                int temp =nums[current];
                nums[current] = nums[left];
                nums[left]  =temp;
                left++;
                current++;
            }
            else if (nums[current] == 1)
            {
                 current++;
            }
            else // nums[current] == 2
            {
                int temp =nums[current];
                nums[current] = nums[right];
                nums[right]  =temp;
                right--;
            }
        }
    }
}