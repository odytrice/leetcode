using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(4, s.LengthOfLIS([10, 9, 2, 5, 3, 7, 101, 18])));
Test("equal", () => Equal(1, s.LengthOfLIS([7, 7, 7])));
Test("decreasing", () => Equal(1, s.LengthOfLIS([3, 2, 1])));
Test("replace tails", () => Equal(4, s.LengthOfLIS([0, 1, 0, 3, 2, 3])));
return Finish();
