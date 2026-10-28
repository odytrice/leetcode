using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("two", () => Rows(new int[][] { [1, 2], [2, 1] }, s.Permute([1, 2])));
Test("single", () => Rows(new int[][] { [0] }, s.Permute([0])));
Test("three", () => Rows(new int[][] { [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1] }, s.Permute([1, 2, 3])));
return Finish();
