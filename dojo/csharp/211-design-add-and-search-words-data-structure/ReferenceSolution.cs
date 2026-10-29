public class ReferenceSolution : WordDictionary
{
    // A trie. A '.' in a search tries every child at that position.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        // End marks that a whole word stops at this node, not just a prefix.
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
            // Every character matched; the word counts only if one ends here.
            if (i == word.Length)
            {
                return n.End;
            }
            // A wildcard matches any child, so try each until one succeeds.
            if (word[i] == '.')
            {
                return n.Children.Values.Any(child => Match(child, i + 1));
            }
            // A normal letter has only one child to follow.
            return n.Children.TryGetValue(word[i], out var next) && Match(next, i + 1);
        }

        return Match(root, 0);
    }
}
