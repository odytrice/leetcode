using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("small slope", () => Rows(new int[][] { [0, 1], [1, 0], [1, 1] }, s.PacificAtlantic([[1, 2], [4, 3]])));
Test("single cell", () => Rows(new int[][] { [0, 0] }, s.PacificAtlantic([[7]])));
Test("plateau", () => Rows(new int[][] { [0, 0], [0, 1], [1, 0], [1, 1] }, s.PacificAtlantic([[1, 1], [1, 1]])));
return Finish();
