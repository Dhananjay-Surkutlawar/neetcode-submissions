public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

    foreach(string s in strs)
    {
        string key = new string(s.OrderBy(c => c).ToArray());

        if(!dict.ContainsKey(key))
        {
            dict[key]=new List<string>();
        }

           dict[key].Add(s);
    }    

    return dict.Values.ToList();
    
    }
}
