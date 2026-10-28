using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(4, s.OrangesRotting([[2, 1, 1], [1, 1, 0], [0, 1, 1]])));
Test("unreachable", () => Equal(-1, s.OrangesRotting([[2, 1, 1], [0, 1, 1], [1, 0, 1]])));
Test("no fresh", () => Equal(0, s.OrangesRotting([[0, 2]])));
Test("multiple sources", () => Equal(1, s.OrangesRotting([[2, 1, 2]])));
return Finish();
