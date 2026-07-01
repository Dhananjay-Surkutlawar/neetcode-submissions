public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        string maxLengthString =strs[0]; 
        foreach(string s in strs)
        {
            if(maxLengthString.Length<s.Length)
            {
                maxLengthString = s;
            }
        }
        string res="";
        for(int i =0;i<maxLengthString.Length;i++)
        {
            string result = maxLengthString.Substring(0, i+1);
            int count = 0;
            foreach(string s in strs)
            {
                if(s.StartsWith(result))
                {
                    count++;
                }
            }
            if(count==strs.Length)
         { res=  result; }
        }
        return res;

        

    }
}