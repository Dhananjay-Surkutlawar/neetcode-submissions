public class Solution {
    public bool IsAnagram(string s, string t) {
    
    // char [] s1 = s.ToCharArray();
    // char [] s2 = t.ToCharArray();
    // Array.Sort(s1);
    // Array.Sort(s2);
    // return new string(s1) == new string(s2);
    if(s.Length != t.Length) return false;
    Dictionary<char , int> dict = new ();

    foreach(char c in s)
    {
        if(dict.ContainsKey(c))
        {
            dict[c]++;
        }else{
            dict[c]=1;
        }
    }

    foreach(char c in t)
    {
        if(!dict.ContainsKey(c))
        return false;

        dict[c]--;

        if(dict[c]<0)
        return false;
    }
    return true;

    }
}
