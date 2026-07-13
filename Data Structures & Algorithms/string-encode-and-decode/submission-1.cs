public class Solution {

    public string Encode(IList<string> strs) {
        
        // string result = string.Empty;
        // foreach(string s in strs)
        // {
        //     result  = result + s +"+00+";
        // }
        // return result;
        StringBuilder sb = new StringBuilder();

        foreach (string s in strs)
        {
            sb.Append(s);
            sb.Append("+00+");
        }

        return sb.ToString();
    }
    public List<string> Decode(string s) {
    
    // string[] parts = s.Split("+00+");

    // List<string> result = new List<string>();

    // foreach (string part in parts)
    // {
    //     result.Add(part);
    // }
    // return result ;
     string[] parts = s.Split("+00+");

    List<string> result = new List<string>();

    // Ignore the last empty part caused by the trailing "+00+"
    for (int i = 0; i < parts.Length - 1; i++)
    {
        result.Add(parts[i]);
    }

    return result;
   }
}
