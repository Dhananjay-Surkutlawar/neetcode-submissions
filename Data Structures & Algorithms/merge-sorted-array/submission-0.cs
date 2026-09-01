public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int last = nums1.Length - 1;
        int left = m - 1;
        int right = n - 1;

        while (right >= 0)
        {
            if (left >= 0 && nums1[left] > nums2[right])
            {
                nums1[last] = nums1[left];
                left--;
            }
            else
            {
                nums1[last] = nums2[right];
                right--;
            }

            last--;
        }
    }
}