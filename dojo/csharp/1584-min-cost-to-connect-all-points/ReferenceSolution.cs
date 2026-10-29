public class ReferenceSolution : Solution
{
    // Dense Prim: O(n^2) time, O(n) space, without materializing all edges.
    public override int MinCostConnectPoints(int[][] points)
    {
        int n = points.Length;
        int total = 0;
        var used = new bool[n];
        // best[i] is the cheapest edge linking point i to the tree built so far.
        var best = Enumerable.Repeat(int.MaxValue, n).ToArray();
        // Point 0 starts the tree at no cost.
        best[0] = 0;
        for (int step = 0; step < n; step += 1)
        {
            // Pick the cheapest point not yet in the tree.
            int u = -1;
            for (int i = 0; i < n; i += 1)
            {
                if (!used[i] && (u == -1 || best[i] < best[u]))
                {
                    u = i;
                }
            }
            // Add the point to the tree and pay for the edge that links it.
            used[u] = true;
            total += best[u];

            // Its edges may offer a cheaper link to the remaining points.
            for (int v = 0; v < n; v += 1)
            {
                if (!used[v])
                {
                    int distance = Math.Abs(points[u][0] - points[v][0]) + Math.Abs(points[u][1] - points[v][1]);
                    best[v] = Math.Min(best[v], distance);
                }
            }
        }
        return total;
    }
}
