using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("two values", () => Rows(new int[][] { [], [1], [2], [1, 2] }, s.Subsets([1, 2]), true));
Test("single", () => Rows(new int[][] { [], [0] }, s.Subsets([0]), true));
Test("three values", () => { var actual = s.Subsets([-1, 0, 1]); Equal(8, actual.Count); Equal(8, actual.Select(x => string.Join(',', x.Order())).Distinct().Count()); Check(actual.All(x => x.Distinct().Count() == x.Count && x.All(v => v is -1 or 0 or 1))); });
return Finish();
