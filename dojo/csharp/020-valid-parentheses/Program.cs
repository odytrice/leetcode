using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("nested", () => Equal(true, s.IsValid("([]){}")));
Test("crossed", () => Equal(false, s.IsValid("([)]")));
Test("unclosed", () => Equal(false, s.IsValid("(")));
Test("unopened", () => Equal(false, s.IsValid(")")));
return Finish();
