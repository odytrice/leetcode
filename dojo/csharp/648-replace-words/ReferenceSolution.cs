public class ReferenceSolution : Solution
{
    private class Node { public readonly Dictionary<char, Node> Children = new(); public bool End; }
    public override string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var root = new Node();
        foreach (string word in dictionary)
        {
            var n = root;
            foreach (char c in word) { if (!n.Children.TryGetValue(c, out var next)) n.Children[c] = next = new(); n = next; }
            n.End = true;
        }
        string Replace(string word)
        {
            var n = root;
            for (int i = 0; i < word.Length; i++)
            { if (!n.Children.TryGetValue(word[i], out var next)) break; n = next; if (n.End) return word[..(i + 1)]; }
            return word;
        }
        return string.Join(' ', sentence.Split(' ').Select(Replace));
    }
}
