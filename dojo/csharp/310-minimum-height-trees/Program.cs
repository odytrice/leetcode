using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("star", () => Set(new[] { 1 }, s.FindMinHeightTrees(4, [[1, 0], [1, 2], [1, 3]])));
Test("two centers", () => Set(new[] { 1, 2 }, s.FindMinHeightTrees(4, [[0, 1], [1, 2], [2, 3]])));
Test("single", () => Set(new[] { 0 }, s.FindMinHeightTrees(1, [])));
return Finish();
