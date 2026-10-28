public class ReferenceSolution : Solution
{
    public override int MinCostConnectPoints(int[][] points)
    {
        // Dense Prim: O(n^2) time, O(n) space, without materializing all edges.
        int n = points.Length, total = 0; var used = new bool[n]; var best = Enumerable.Repeat(int.MaxValue, n).ToArray(); best[0] = 0;
        for (int step = 0; step < n; step++)
        {
            int u = -1;
            for (int i = 0; i < n; i++) if (!used[i] && (u == -1 || best[i] < best[u])) u = i;
            used[u] = true; total += best[u];
            for (int v = 0; v < n; v++) if (!used[v])
                best[v] = Math.Min(best[v], Math.Abs(points[u][0] - points[v][0]) + Math.Abs(points[u][1] - points[v][1]));
        }
        return total;
    }
}
