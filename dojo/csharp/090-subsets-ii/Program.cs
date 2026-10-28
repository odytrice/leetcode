using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new int[][] { [], [1], [2], [1, 2], [2, 2], [1, 2, 2] }, s.SubsetsWithDup([1, 2, 2]), true));
Test("all same", () => Rows(new int[][] { [], [0], [0, 0] }, s.SubsetsWithDup([0, 0]), true));
Test("unsorted", () => Rows(new int[][] { [], [-1], [2], [-1, 2] }, s.SubsetsWithDup([2, -1]), true));
return Finish();
