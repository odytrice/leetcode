using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.FindMaxLength([0, 1, 0])));
Test("all one value", () => Equal(0, s.FindMaxLength([1, 1, 1])));
Test("earliest prefix", () => Equal(6, s.FindMaxLength([0, 0, 1, 0, 1, 1, 0])));
return Finish();
