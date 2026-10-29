public class ReferenceSolution : Solution
{
    // O(n * alpha(n)) time. The first edge whose ends are already connected closes the cycle.
    public override int[] FindRedundantConnection(int[][] edges)
    {
        // Nodes are numbered 1 to n, so allocate one extra slot.
        var parent = Enumerable.Range(0, edges.Length + 1).ToArray();
        var size = Enumerable.Repeat(1, parent.Length).ToArray();

        // Path halving keeps the trees shallow.
        int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        foreach (var e in edges)
        {
            int a = Find(e[0]);
            int b = Find(e[1]);
            // Both ends are already connected, so this edge closes the cycle.
            if (a == b)
            {
                return e;
            }
            // Union by size: hang the smaller tree under the larger.
            if (size[a] < size[b])
            {
                (a, b) = (b, a);
            }
            parent[b] = a;
            size[a] += size[b];
        }
        // The input always has one redundant edge, so this is never reached.
        throw new ArgumentException();
    }
}
