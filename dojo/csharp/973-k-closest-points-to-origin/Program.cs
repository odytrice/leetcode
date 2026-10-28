using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new int[][] { [-2, 2] }, s.KClosest([[1, 3], [-2, 2]], 1)));
Test("all points", () => Rows(new int[][] { [1, 2], [3, 4] }, s.KClosest([[1, 2], [3, 4]], 2)));
Test("duplicates", () => Rows(new int[][] { [0, 0], [0, 0] }, s.KClosest([[0, 0], [0, 0], [1, 1]], 2)));
return Finish();
