public class ReferenceSolution : Solution
{
    // O(81) time. One set of (unit kind, unit index, digit) catches every repeat.
    public override bool IsValidSudoku(char[][] board)
    {
        var seen = new HashSet<(int Kind, int Unit, char Digit)>();
        for (int r = 0; r < 9; r += 1)
        {
            for (int c = 0; c < 9; c += 1)
            {
                char v = board[r][c];
                if (v == '.')
                {
                    continue;
                }
                int box = r / 3 * 3 + c / 3;
                if (!seen.Add((0, r, v)) || !seen.Add((1, c, v)) || !seen.Add((2, box, v)))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
