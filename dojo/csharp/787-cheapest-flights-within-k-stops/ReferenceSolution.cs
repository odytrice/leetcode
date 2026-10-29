public class ReferenceSolution : Solution
{
    // O(k * E) time. Bellman-Ford limited to k + 1 rounds, one per flight taken.
    public override int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var dist = Enumerable.Repeat(int.MaxValue, n).ToArray();
        dist[src] = 0;
        for (int edges = 0; edges <= k; edges += 1)
        {
            // Read only the previous round, so one round uses at most one new edge.
            var next = (int[])dist.Clone();
            foreach (var f in flights)
            {
                if (dist[f[0]] != int.MaxValue)
                {
                    next[f[1]] = Math.Min(next[f[1]], dist[f[0]] + f[2]);
                }
            }
            dist = next;
        }
        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
}
