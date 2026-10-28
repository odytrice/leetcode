using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("one stop", () => Equal(200, s.FindCheapestPrice(3, [[0, 1, 100], [1, 2, 100], [0, 2, 500]], 0, 2, 1)));
Test("no stops", () => Equal(500, s.FindCheapestPrice(3, [[0, 1, 100], [1, 2, 100], [0, 2, 500]], 0, 2, 0)));
Test("unreachable", () => Equal(-1, s.FindCheapestPrice(3, [[0, 1, 100]], 0, 2, 2)));
Test("cheaper route exceeds stop limit", () => Equal(6, s.FindCheapestPrice(4, [[0, 1, 1], [1, 2, 1], [2, 3, 1], [0, 2, 5]], 0, 3, 1)));
Test("seeded cases against bounded path enumeration", () =>
{
    var random = new Random(787);
    for (int trial = 0; trial < 100; trial++)
    {
        int n = random.Next(2, 6), k = random.Next(n);
        var flights = new List<int[]>();
        for (int u = 0; u < n; u++) for (int v = 0; v < n; v++) if (u != v && random.Next(3) == 0) flights.Add([u, v, random.Next(1, 20)]);
        int best = int.MaxValue;
        void Search(int u, int remaining, int cost)
        {
            if (u == n - 1) { best = Math.Min(best, cost); return; }
            if (remaining == 0) return;
            foreach (var f in flights) if (f[0] == u) Search(f[1], remaining - 1, cost + f[2]);
        }
        Search(0, k + 1, 0);
        Equal(best == int.MaxValue ? -1 : best, s.FindCheapestPrice(n, flights.ToArray(), 0, n - 1, k));
    }
});
return Finish();
