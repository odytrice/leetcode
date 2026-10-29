public class ReferenceSolution : Solution
{
    // Trie of the words, then one DFS from each cell that follows the trie.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        public string? Word;
    }

    public override IList<string> FindWords(char[][] board, string[] words)
    {
        var root = new Node();
        foreach (string word in words)
        {
            var n = root;
            foreach (char c in word)
            {
                if (!n.Children.TryGetValue(c, out var next))
                {
                    next = new();
                    n.Children[c] = next;
                }
                n = next;
            }
            n.Word = word;
        }

        int rows = board.Length;
        int cols = board[0].Length;
        var result = new List<string>();

        void Search(int r, int c, Node parent)
        {
            if (r < 0 || c < 0 || r >= rows || c >= cols)
            {
                return;
            }
            char ch = board[r][c];
            if (!parent.Children.TryGetValue(ch, out var n))
            {
                return;
            }
            // Clear the word once found so it is reported only once.
            if (n.Word != null)
            {
                result.Add(n.Word);
                n.Word = null;
            }
            board[r][c] = '\0';
            Search(r - 1, c, n);
            Search(r + 1, c, n);
            Search(r, c - 1, n);
            Search(r, c + 1, n);
            board[r][c] = ch;
            // Prune branches with nothing left to find.
            if (n.Word == null && n.Children.Count == 0)
            {
                parent.Children.Remove(ch);
            }
        }

        for (int r = 0; r < rows; r += 1)
        {
            for (int c = 0; c < cols; c += 1)
            {
                Search(r, c, root);
            }
        }
        return result;
    }
}
