public class ReferenceSolution : Trie
{
    private class Node { public readonly Dictionary<char, Node> Children = new(); public bool End; }
    private readonly Node root = new();
    public override void Insert(string word)
    {
        var n = root;
        foreach (char c in word) { if (!n.Children.TryGetValue(c, out var next)) n.Children[c] = next = new(); n = next; }
        n.End = true;
    }
    private Node? Find(string text)
    {
        var n = root;
        foreach (char c in text) { if (!n.Children.TryGetValue(c, out var next)) return null; n = next; }
        return n;
    }
    public override bool Search(string word) => Find(word)?.End == true;
    public override bool StartsWith(string prefix) => Find(prefix) != null;
}
