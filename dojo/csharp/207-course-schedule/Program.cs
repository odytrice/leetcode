using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("possible", () => Equal(true, s.CanFinish(2, [[1, 0]])));
Test("cycle", () => Equal(false, s.CanFinish(2, [[1, 0], [0, 1]])));
Test("disconnected cycle", () => Equal(false, s.CanFinish(4, [[1, 0], [2, 3], [3, 2]])));
Test("no edges", () => Equal(true, s.CanFinish(3, [])));
return Finish();
