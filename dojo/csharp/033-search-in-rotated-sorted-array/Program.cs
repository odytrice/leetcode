using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("rotated", () => Equal(4, s.Search([4, 5, 6, 7, 0, 1, 2], 0)));
Test("absent", () => Equal(-1, s.Search([4, 5, 6, 7, 0, 1, 2], 3)));
Test("unrotated", () => Equal(2, s.Search([1, 2, 3], 3)));
Test("single", () => Equal(0, s.Search([1], 1)));
return Finish();
