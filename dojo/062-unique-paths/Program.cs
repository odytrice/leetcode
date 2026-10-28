using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(28, s.UniquePaths(3, 7)));
Test("one row", () => Equal(1, s.UniquePaths(1, 100)));
Test("one column", () => Equal(1, s.UniquePaths(100, 1)));
Test("square", () => Equal(6, s.UniquePaths(3, 3)));
return Finish();
