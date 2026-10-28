using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("rotated", () => Equal(1, s.FindMin([3, 4, 5, 1, 2])));
Test("unrotated", () => Equal(1, s.FindMin([1, 2, 3])));
Test("single", () => Equal(-5, s.FindMin([-5])));
return Finish();
