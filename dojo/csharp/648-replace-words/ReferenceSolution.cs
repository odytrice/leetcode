public class ReferenceSolution : Solution
{
    // O(total characters) time. A trie of roots; each word stops at the first root it passes.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        // End marks that a root word stops at this node.
        public bool End;
    }

    public override string ReplaceWords(IList<string> dictionary, string sentence)
    {
        // Build the trie from all the roots.
        var root = new Node();
        foreach (string word in dictionary)
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

        string Replace(string word)
        {
            var n = root;
            for (int i = 0; i < word.Length; i += 1)
            {
                // No root continues this way, so the word stays as it is.
                if (!n.Children.TryGetValue(word[i], out var next))
                {
                    break;
                }
                n = next;
                // The first root reached is the shortest, so use it right away.
                if (n.End)
                {
                    return word[..(i + 1)];
                }
            }
            return word;
        }

        return string.Join(' ', sentence.Split(' ').Select(Replace));
    }
}
