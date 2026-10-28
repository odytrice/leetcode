using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(true, s.CheckSubarraySum([23, 2, 4, 6, 7], 6)));
Test("absent", () => Equal(false, s.CheckSubarraySum([23, 2, 6, 4, 7], 13)));
Test("too short", () => Equal(false, s.CheckSubarraySum([6], 6)));
Test("zero sum", () => Equal(true, s.CheckSubarraySum([0, 0], 7)));
return Finish();
