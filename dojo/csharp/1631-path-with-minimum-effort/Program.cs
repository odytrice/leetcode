using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.MinimumEffortPath([[1, 2, 2], [3, 8, 2], [5, 3, 5]])));
Test("single", () => Equal(0, s.MinimumEffortPath([[99]])));
Test("max not sum", () => Equal(1, s.MinimumEffortPath([[1, 2, 3, 4]])));
Test("detour", () => Equal(0, s.MinimumEffortPath([[1, 100, 1], [1, 100, 1], [1, 1, 1]])));
return Finish();
