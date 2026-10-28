public class ReferenceSolution : Solution
{
    public override bool Exist(char[][] board, string word)
    {
        int rows = board.Length, cols = board[0].Length;
        bool Search(int r, int c, int index)
        {
            if (r < 0 || c < 0 || r >= rows || c >= cols || board[r][c] != word[index]) return false;
            if (index == word.Length - 1) return true;
            char saved = board[r][c]; board[r][c] = '\0';
            bool found = Search(r - 1, c, index + 1) || Search(r + 1, c, index + 1) || Search(r, c - 1, index + 1) || Search(r, c + 1, index + 1);
            board[r][c] = saved; return found;
        }
        for (int r = 0; r < rows; r++) for (int c = 0; c < cols; c++) if (Search(r, c, 0)) return true;
        return false;
    }
}
