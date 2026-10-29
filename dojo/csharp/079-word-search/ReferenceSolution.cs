public class ReferenceSolution : Solution
{
    // O(cells * 4^len) time. Mark the current cell while searching, then restore it.
    public override bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        bool Search(int r, int c, int index)
        {
            // Off the board, already on this path, or the wrong letter: this branch fails.
            if (r < 0 || c < 0 || r >= rows || c >= cols || board[r][c] != word[index])
            {
                return false;
            }
            // The last letter matched, so the whole word is found.
            if (index == word.Length - 1)
            {
                return true;
            }
            // Blank the cell so this path cannot use it twice.
            char saved = board[r][c];
            board[r][c] = '\0';
            bool found = Search(r - 1, c, index + 1)
                || Search(r + 1, c, index + 1)
                || Search(r, c - 1, index + 1)
                || Search(r, c + 1, index + 1);
            // Restore the letter so other paths can use it.
            board[r][c] = saved;
            return found;
        }

        // Try every cell as the first letter.
        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                if (Search(r, c, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
