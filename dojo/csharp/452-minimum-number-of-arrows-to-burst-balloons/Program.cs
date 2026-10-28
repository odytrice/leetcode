using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.FindMinArrowShots([[10, 16], [2, 8], [1, 6], [7, 12]])));
Test("touching", () => Equal(1, s.FindMinArrowShots([[1, 2], [2, 3]])));
Test("integer extremes", () => Equal(2, s.FindMinArrowShots([[int.MinValue, -1], [0, int.MaxValue]])));
return Finish();
