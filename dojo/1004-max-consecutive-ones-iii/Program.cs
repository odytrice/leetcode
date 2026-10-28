using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(6, s.LongestOnes([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2)));
Test("no flips", () => Equal(2, s.LongestOnes([1, 1, 0, 1], 0)));
Test("all zeros", () => Equal(2, s.LongestOnes([0, 0, 0], 2)));
return Finish();
