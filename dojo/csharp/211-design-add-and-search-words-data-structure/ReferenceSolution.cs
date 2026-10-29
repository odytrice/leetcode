public class ReferenceSolution : WordDictionary
{
    // A trie. A '.' in a search tries every child at that position.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        public bool End;
    }

    private readonly Node root = new();

    public override void AddWord(string word)
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
        n.End = true;
    }

    public override bool Search(string word)
    {
        bool Match(Node n, int i)
        {
            if (i == word.Length)
            {
                return n.End;
            }
            if (word[i] == '.')
            {
                return n.Children.Values.Any(child => Match(child, i + 1));
            }
            return n.Children.TryGetValue(word[i], out var next) && Match(next, i + 1);
        }

        return Match(root, 0);
    }
}
