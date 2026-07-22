public class Solution {
    public List<int> MajorityElement(int[] nums) {
        
      Dictionary<int, int> dict = new Dictionary<int, int>();

      foreach(int n in nums)
      {
        if(!dict.ContainsKey(n))
        {
            dict[n] = 1 ;
            continue;
        }
        else
        {
            dict[n] = dict[n]+1;
        }
      }

        List<int> result = new List<int>();
        foreach (KeyValuePair<int, int> item in dict)
        {
            if(item.Value  > nums.Length/3 )
            {
                result.Add(item.Key);
            }
        }
        return result;

    }
}