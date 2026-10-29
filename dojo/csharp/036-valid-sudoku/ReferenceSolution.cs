public class ReferenceSolution : Solution
{
    // O(81) time. One set of (unit kind, unit index, digit) catches every repeat.
    public override bool IsValidSudoku(char[][] board)
    {
        // Kind 0 is a row, 1 is a column and 2 is a 3x3 box.
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
                // Boxes are numbered 0 to 8, left to right, then top to bottom.
                int box = r / 3 * 3 + c / 3;
                // Add returns false when the digit was already seen in that unit.
                if (!seen.Add((0, r, v)) || !seen.Add((1, c, v)) || !seen.Add((2, box, v)))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
