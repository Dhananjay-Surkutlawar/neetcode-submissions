public class Solution {
    public int LongestConsecutive(int[] nums) {
    HashSet<int> set = new HashSet<int>(nums);
    int maxCount=0;
     //[ -1, 0, 1, 3, 4, 5, 6, 7, 8, 9]
    foreach(int n in  set)
    {
        if(!set.Contains(n-1))
        {
            int curr =n;
            int currCount=1;

             while (set.Contains(curr + 1))
             {
                curr++;
                currCount++;
             }
             maxCount = Math.Max(maxCount, currCount);
        }
    }

return maxCount;


    //     if(nums.Length==0) return 0;
    //     Array.Sort(nums);
    //     //[-1, -1, 0, 1, 3, 4, 5, 6, 7, 8, 9]
    //     int count = 1;
    //     int maxCount = 1;
    // for (int i = 0; i < nums.Length - 1; i++)
    // {
    //     if (nums[i] == nums[i + 1])
    //         continue;

    //     if (nums[i] == nums[i + 1] - 1)
    //     {
    //         count++;
    //         maxCount = Math.Max(maxCount, count);
    //     }
    //     else
    //     {
    //         count = 1;
    //     }
    // }

    return maxCount;
}
}