using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 1, 2 }, s.TwoSum([2, 7, 11, 15], 9)));
Test("negative", () => Sequence(new[] { 1, 3 }, s.TwoSum([-3, 0, 4], 1)));
Test("duplicates", () => Sequence(new[] { 1, 2 }, s.TwoSum([2, 2], 4)));
return Finish();
