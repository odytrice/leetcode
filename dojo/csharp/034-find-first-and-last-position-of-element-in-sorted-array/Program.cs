using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 3, 4 }, s.SearchRange([5, 7, 7, 8, 8, 10], 8)));
Test("absent", () => Sequence(new[] { -1, -1 }, s.SearchRange([1, 3], 2)));
Test("empty", () => Sequence(new[] { -1, -1 }, s.SearchRange([], 0)));
Test("all equal", () => Sequence(new[] { 0, 2 }, s.SearchRange([2, 2, 2], 2)));
return Finish();
