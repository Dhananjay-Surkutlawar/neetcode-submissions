public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

    // foreach(string s in strs)
    // {
    //     string key = new string(s.OrderBy(c => c).ToArray());

    //     if(!dict.ContainsKey(key))
    //     {
    //         dict[key]=new List<string>();
    //     }

    //        dict[key].Add(s);
    // }    

    // return dict.Values.ToList();

    foreach(string s in strs)
    {
        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
          string key = "";

        for (int i = 0; i < 26; i++)
        {
            if (count[i] > 0)
            {
                key += (char)('a' + i);
                key += count[i];
            }
        }
        if(!dict.ContainsKey(key))
        {
            dict[key]=new List<string>();
        }

           dict[key].Add(s);
    }
    return dict.Values.ToList();
    
    }
}
