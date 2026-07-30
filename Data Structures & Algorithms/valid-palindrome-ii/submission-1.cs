public class Solution {
    public bool ValidPalindrome(string s) {
        int left =0;
        int right=s.Length-1;
        while(left<right)
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {  
              return Valid(s,left,right-1) || Valid(s,left+1,right);
               
            }
            
            left++;
            right--;
        }   
        return true;
        
    }
    public bool Valid(string s ,int left , int right)
    {
        while(left<right)
        {
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {  
              
               return false;
            }
            
            left++;
            right--;
        }   
        return true;
    }
}