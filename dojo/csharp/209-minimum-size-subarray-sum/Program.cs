using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.MinSubArrayLen(7, [2, 3, 1, 2, 4, 3])));
Test("one element", () => Equal(1, s.MinSubArrayLen(4, [1, 4, 4])));
Test("unreachable", () => Equal(0, s.MinSubArrayLen(11, [1, 1, 1, 1])));
return Finish();
