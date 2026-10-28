using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(49, s.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7])));
Test("two lines", () => Equal(1, s.MaxArea([1, 1])));
Test("zero heights", () => Equal(0, s.MaxArea([0, 0, 0])));
return Finish();
