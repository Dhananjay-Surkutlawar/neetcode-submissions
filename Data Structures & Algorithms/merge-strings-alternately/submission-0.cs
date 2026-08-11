public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result ="";
        int index =0;
        while (index < word1.Length || index < word2.Length)
        {
            if(word1.Length>index)
            {
                result= result +word1[index];
            }
            if(word2.Length>index)
            {
                result= result +word2[index]; 
            }
            index++;
        
        }
        return result;
    }
}