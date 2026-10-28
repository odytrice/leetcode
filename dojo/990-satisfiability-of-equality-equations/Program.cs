using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("contradiction", () => Equal(false, s.EquationsPossible(["a==b", "b!=a"])));
Test("transitive and reordered", () => Equal(false, s.EquationsPossible(["a!=c", "a==b", "b==c"])));
Test("consistent", () => Equal(true, s.EquationsPossible(["a==b", "b!=c"])));
Test("self inequality", () => Equal(false, s.EquationsPossible(["a!=a"])));
return Finish();
