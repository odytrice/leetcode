using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
void Verify(int n, int[][] edges)
{
    var order = s.FindOrder(n, edges); Set(Enumerable.Range(0, n), order);
    var positions = new int[n]; for (int i = 0; i < n; i++) positions[order[i]] = i;
    foreach (var p in edges) Check(positions[p[1]] < positions[p[0]], "Prerequisite order violated");
}
Test("diamond", () => Verify(4, [[1, 0], [2, 0], [3, 1], [3, 2]]));
Test("cycle", () => Equal(0, s.FindOrder(2, [[1, 0], [0, 1]]).Length));
Test("isolated courses", () => Verify(3, []));
return Finish();
