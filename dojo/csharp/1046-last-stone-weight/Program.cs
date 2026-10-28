using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(1, s.LastStoneWeight([2, 7, 4, 1, 8, 1])));
Test("equal pair", () => Equal(0, s.LastStoneWeight([3, 3])));
Test("single", () => Equal(7, s.LastStoneWeight([7])));
return Finish();
