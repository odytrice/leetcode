using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(20, s.MinCostConnectPoints([[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]])));
Test("single", () => Equal(0, s.MinCostConnectPoints([[4, -2]])));
Test("negative coordinates", () => Equal(18, s.MinCostConnectPoints([[3, 12], [-2, 5], [-4, 1]])));
Test("coordinate limits", () => Equal(4_000_000, s.MinCostConnectPoints([[-1_000_000, -1_000_000], [1_000_000, 1_000_000]])));
Test("seeded cases against Kruskal", () =>
{
    var random = new Random(1584);
    for (int trial = 0; trial < 100; trial++)
    {
        int n = random.Next(1, 9); var points = new List<int[]>(); var seen = new HashSet<(int, int)>();
        while (points.Count < n) { int x = random.Next(-20, 21), y = random.Next(-20, 21); if (seen.Add((x, y))) points.Add([x, y]); }
        var edges = new List<(int Cost, int A, int B)>();
        for (int a = 0; a < n; a++) for (int b = a + 1; b < n; b++) edges.Add((Math.Abs(points[a][0] - points[b][0]) + Math.Abs(points[a][1] - points[b][1]), a, b));
        var component = Enumerable.Range(0, n).ToArray(); int expected = 0;
        foreach (var edge in edges.OrderBy(e => e.Cost))
        {
            int from = component[edge.A], to = component[edge.B]; if (from == to) continue;
            expected += edge.Cost;
            for (int i = 0; i < n; i++) if (component[i] == from) component[i] = to;
        }
        Equal(expected, s.MinCostConnectPoints(points.ToArray()));
    }
});
return Finish();
