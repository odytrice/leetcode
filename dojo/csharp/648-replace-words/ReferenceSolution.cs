public class ReferenceSolution : Solution
{
    // O(total characters) time. A trie of roots; each word stops at the first root it passes.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        public bool End;
    }

    public override string ReplaceWords(IList<string> dictionary, string sentence)
    {
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
                if (!n.Children.TryGetValue(word[i], out var next))
                {
                    break;
                }
                n = next;
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
