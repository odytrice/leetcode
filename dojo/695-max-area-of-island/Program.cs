using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.MaxAreaOfIsland([[1, 1, 0], [0, 1, 0], [1, 0, 1]])));
Test("water", () => Equal(0, s.MaxAreaOfIsland([[0, 0]])));
Test("diagonal", () => Equal(1, s.MaxAreaOfIsland([[1, 0], [0, 1]])));
return Finish();
