public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        Array.Sort(nums);
        // HashSet<int> set = new ();
        // foreach(int n in nums)
        // {
        //     set.Add(n);
        // }
        //[-1, -1, 0, 1, 3, 4, 5, 6, 7, 8, 9]
        int count = 1;
        int maxCount = 1;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] == nums[i + 1])
            continue;

        if (nums[i] == nums[i + 1] - 1)
        {
            count++;
            maxCount = Math.Max(maxCount, count);
        }
        else
        {
            count = 1;
        }
    }

    return maxCount;
}
}