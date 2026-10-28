using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
char[][] Board() => new[] { "ABCE", "SFCS", "ADEE" }.Select(x => x.ToCharArray()).ToArray();
Test("found and restored", () => { var b = Board(); Equal(true, s.Exist(b, "ABCCED")); Sequence(new[] { "ABCE", "SFCS", "ADEE" }, b.Select(x => new string(x))); });
Test("no cell reuse", () => Equal(false, s.Exist(Board(), "ABCB")));
Test("backtracking", () => Equal(true, s.Exist(Board(), "SEE")));
Test("single", () => Equal(true, s.Exist([['a']], "a")));
return Finish();
