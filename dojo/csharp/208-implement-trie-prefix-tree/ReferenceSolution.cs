public class ReferenceSolution : Trie
{
    // O(length) per operation. Each node maps a character to its child.
    private class Node
    {
        public readonly Dictionary<char, Node> Children = new();
        public bool End;
    }

    private readonly Node root = new();

    public override void Insert(string word)
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

    // Returns the node at the end of text, or null when the path breaks off.
    private Node? Find(string text)
    {
        var n = root;
        foreach (char c in text)
        {
            if (!n.Children.TryGetValue(c, out var next))
            {
                return null;
            }
            n = next;
        }
        return n;
    }

    public override bool Search(string word)
    {
        return Find(word)?.End == true;
    }

    public override bool StartsWith(string prefix)
    {
        return Find(prefix) != null;
    }
}
