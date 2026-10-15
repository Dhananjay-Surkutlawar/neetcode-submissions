public class Solution {
    public int MaxArea(int[] heights) {
    int max = 0;
    int left=0;
    int right = heights.Length-1;

    while(left<right)
    {
        int diff = right - left;//width
        int minResult = Math.Min(heights[right], heights[left]);// taking the lowest height 
        int area = diff * minResult; // lowest height * diff // area
        max = Math.Max(max, area);// got the rea which is max from old
        if (heights[left] < heights[right])
        {
            left++; 
        }
        else
        {
            right--;
        }
    }


      

        return max;
    }
}
