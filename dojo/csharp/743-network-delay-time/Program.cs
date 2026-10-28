using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.NetworkDelayTime([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2)));
Test("directed unreachable", () => Equal(-1, s.NetworkDelayTime([[1, 2, 1]], 2, 2)));
Test("improved route", () => Equal(2, s.NetworkDelayTime([[1, 2, 10], [1, 3, 1], [3, 2, 1]], 3, 1)));
Test("zero weight", () => Equal(0, s.NetworkDelayTime([[1, 2, 0]], 2, 1)));
return Finish();
