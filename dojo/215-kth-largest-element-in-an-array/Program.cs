using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(5, s.FindKthLargest([3, 2, 1, 5, 6, 4], 2)));
Test("duplicates", () => Equal(4, s.FindKthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4)));
Test("negative", () => Equal(-3, s.FindKthLargest([-1, -3, -2], 3)));
return Finish();
