public class Solution {
    public int MajorityElement(int[] nums) {
    //     Dictionary<int, int> dict = new Dictionary<int, int>();

    //     foreach(int n in nums)
    //     {
    //         if (!dict.ContainsKey(n))
    //         {
    //             dict.Add(n, 1);
    //         }
    //         else
    //         {
    //           dict[n] = dict[n] + 1;
    //         }
    //     }
    //     int morethan =nums.Length/2;
    //     foreach (var item in dict)
    //     {
    //         if (item.Value >morethan)
    //         {
    //            return item.Key;
    //         }
    //     }
    //     return 0 ;
    // }
    int maxFreq = 0;
    int maxEle = 0;

        foreach(int i in nums)
        {
           int totalCount = nums.Count(c=>c == i);
           if(totalCount>maxFreq)
           {
             maxFreq = totalCount;
             maxEle = i;
           }

        }
        return maxEle;
    }
}