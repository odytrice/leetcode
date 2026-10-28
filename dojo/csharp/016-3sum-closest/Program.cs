using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.ThreeSumClosest([-1, 2, 1, -4], 1)));
Test("zeros", () => Equal(0, s.ThreeSumClosest([0, 0, 0], 1)));
Test("exact", () => Equal(3, s.ThreeSumClosest([1, 1, 1, 0], 3)));
return Finish();
