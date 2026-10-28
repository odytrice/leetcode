using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(2, s.FindCircleNum([[1, 1, 0], [1, 1, 0], [0, 0, 1]])));
Test("isolated", () => Equal(3, s.FindCircleNum([[1, 0, 0], [0, 1, 0], [0, 0, 1]])));
Test("transitive", () => Equal(1, s.FindCircleNum([[1, 1, 0], [1, 1, 1], [0, 1, 1]])));
return Finish();
