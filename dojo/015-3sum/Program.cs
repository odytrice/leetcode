using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new int[][] { [-1, -1, 2], [-1, 0, 1] }, s.ThreeSum([-1, 0, 1, 2, -1, -4]), true));
Test("duplicates", () => Rows(new int[][] { [0, 0, 0] }, s.ThreeSum([0, 0, 0, 0]), true));
Test("no answer", () => Equal(0, s.ThreeSum([1, 2, 3]).Count));
return Finish();
