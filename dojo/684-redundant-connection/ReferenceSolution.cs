public class ReferenceSolution : Solution
{
    public override int[] FindRedundantConnection(int[][] edges)
    {
        var parent = Enumerable.Range(0, edges.Length + 1).ToArray(); var size = Enumerable.Repeat(1, parent.Length).ToArray();
        int Find(int x) { while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; } return x; }
        foreach (var e in edges)
        {
            int a = Find(e[0]), b = Find(e[1]); if (a == b) return e;
            if (size[a] < size[b]) (a, b) = (b, a); parent[b] = a; size[a] += size[b];
        }
        throw new ArgumentException();
    }
}
