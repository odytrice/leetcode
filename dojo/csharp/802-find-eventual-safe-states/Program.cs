using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 2, 4, 5, 6 }, s.EventualSafeNodes([[1, 2], [2, 3], [5], [0], [5], [], []])));
Test("self loop", () => Sequence(new[] { 1 }, s.EventualSafeNodes([[0], []])));
Test("all terminal", () => Sequence(new[] { 0, 1 }, s.EventualSafeNodes([[], []])));
return Finish();
