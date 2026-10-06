public class Solution {
    public int SubarraySum(int[] nums, int k) {
    int count = 0;
    int prefixSum = 0;

    Dictionary<int, int> map = new Dictionary<int, int>();

    map[0] = 1;

    foreach (int num in nums)
    {
        prefixSum += num;
        int needed = prefixSum - k;

        if (map.ContainsKey(needed))
        {
            count += map[needed];
        }
        if (map.ContainsKey(prefixSum))
        {
            map[prefixSum]++;
        }
        else
        {
            map[prefixSum] = 1;
        }
    }

    return count;
}
}