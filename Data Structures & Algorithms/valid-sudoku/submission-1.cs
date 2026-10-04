public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                char num = board[row][col];

                if (num == '.') continue;

                if (
                    !seen.Add(num + "at row" + row) ||
                    !seen.Add(num + "at col" + col) ||
                    !seen.Add(num + "at box" + row / 3 + "-" + col / 3)
                )
                {
                    return false;
                }
            }
        }

        return true;
    }
}
