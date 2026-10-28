using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("diagonal", () => Equal(2, s.ShortestPathBinaryMatrix([[0, 1], [1, 0]])));
Test("single", () => Equal(1, s.ShortestPathBinaryMatrix([[0]])));
Test("blocked start", () => Equal(-1, s.ShortestPathBinaryMatrix([[1, 0], [0, 0]])));
Test("disconnected", () => Equal(-1, s.ShortestPathBinaryMatrix([[0, 0, 0], [1, 1, 1], [0, 0, 0]])));
return Finish();
