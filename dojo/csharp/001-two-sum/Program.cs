using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Set(new[] { 0, 1 }, s.TwoSum([2, 7, 11, 15], 9)));
Test("duplicate values", () => Set(new[] { 0, 1 }, s.TwoSum([3, 3], 6)));
Test("negative values", () => Set(new[] { 1, 2 }, s.TwoSum([4, -2, -3], -5)));
return Finish();
