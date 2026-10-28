using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new int[][] { [2, 2, 3], [7] }, s.CombinationSum([2, 3, 6, 7], 7), true));
Test("multiple combinations", () => Rows(new int[][] { [2, 2, 2, 2], [2, 3, 3], [3, 5] }, s.CombinationSum([2, 3, 5], 8), true));
Test("impossible", () => Equal(0, s.CombinationSum([2], 1).Count));
return Finish();
