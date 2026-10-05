public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int n  in nums)
        {
            if (!dict.ContainsKey(n))
            {
                dict[n]=1;
            }
            else{
                  dict[n]++;
            }
        }

        List<int>[] buckets = new List<int>[nums.Length + 1]; // array of list

        foreach(var item  in dict)
        {
            int number = item.Key;
            int frequency = item.Value;
            if (buckets[frequency] == null)
            {
                buckets[frequency] = new List<int>();
            }

            buckets[frequency].Add(number);
        }
        List<int> result = new();
        for(int i=buckets.Length-1;i>=0;i--)
        {
            if(buckets[i]== null) continue; 

            foreach(int n in buckets[i])
            {
                result.Add(n);
                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}
