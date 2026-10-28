public class ReferenceSolution : Solution
{
    public override bool IsValidSudoku(char[][] board)
    {
        var seen = new HashSet<(int Kind, int Unit, char Digit)>();
        for (int r = 0; r < 9; r++)
        for (int c = 0; c < 9; c++)
        {
            char v = board[r][c];
            if (v == '.') continue;
            if (!seen.Add((0, r, v)) || !seen.Add((1, c, v)) || !seen.Add((2, r / 3 * 3 + c / 3, v))) return false;
        }
        return true;
    }
}
