using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(1, s.EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]])));
Test("duplicates", () => Equal(2, s.EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]])));
Test("touching", () => Equal(0, s.EraseOverlapIntervals([[1, 2], [2, 3]])));
return Finish();
