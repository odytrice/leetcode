using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("triangle", () => Sequence(new[] { 2, 3 }, s.FindRedundantConnection([[1, 2], [1, 3], [2, 3]])));
Test("cycle before final edge", () => Sequence(new[] { 1, 4 }, s.FindRedundantConnection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]])));
Test("input order tie break", () => Sequence(new[] { 1, 2 }, s.FindRedundantConnection([[2, 3], [1, 3], [1, 2]])));
return Finish();
