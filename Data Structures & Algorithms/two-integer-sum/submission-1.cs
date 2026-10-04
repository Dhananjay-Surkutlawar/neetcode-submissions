public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    //  brute force
    //     for (int i =0 ; i<nums.Length-1 ; i++)
    //     {
    //         for(int j = i+1 ; j<nums.Length;j++)
    //         {
    //             if(nums[i]+nums[j] == target)
    //             {
    //                return new int[] { i, j };
    //             }
    //         }
    //     }
    //    return new int[] { };

    Dictionary<int ,int> dict = new ();
    for(int i =0;i<nums.Length;i++)
    {
        dict[nums[i]]=i;
    }

    for(int i = 0 ;i<nums.Length;i++)
    {
        int remain = target - nums[i];

        if(dict.ContainsKey(remain) && i!= dict[remain] )
        {
            return new int [] {i,dict[remain]};
        }
    }
    return new int[] { };
    }
}
