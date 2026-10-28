using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(4, s.LongestConsecutive([100, 4, 200, 1, 3, 2])));
Test("duplicates and negatives", () => Equal(4, s.LongestConsecutive([0, -1, 1, 2, 2])));
Test("empty", () => Equal(0, s.LongestConsecutive([])));
return Finish();
