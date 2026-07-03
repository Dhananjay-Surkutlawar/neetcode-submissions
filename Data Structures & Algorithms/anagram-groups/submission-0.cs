public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        // foreach(var s in strs)
        // {
        //      char [] arr = s.ToCharArray();
        //      Array.Sort(arr);
        //      string key = new string (arr);
        //     if (!dict.ContainsKey(key))
        //     {
        //         dict[key] = new List<string>();
        //         foreach(var t in strs)
        //         {
        //             char [] arr2 = t.ToCharArray();
        //             Array.Sort(arr2);
        //             string key2 = new string (arr2);
        //             if(key==key2)
        //             {
        //                 dict[key].Add(t);
        //             }
        //         }
        //         result.Add(dict[key]);
        //     }

        // }


        foreach(var s in strs)
        {
           char []arr = s.ToCharArray();
           Array.Sort(arr);
           string key = new string(arr);;
            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }
             dict[key].Add(s);
        }
        return dict.Values.ToList();
        
    }
}
