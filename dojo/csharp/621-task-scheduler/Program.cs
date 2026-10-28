using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(8, s.LeastInterval("AAABBB".ToCharArray(), 2)));
Test("no cooldown", () => Equal(6, s.LeastInterval("AAABBB".ToCharArray(), 0)));
Test("single type", () => Equal(7, s.LeastInterval("AAA".ToCharArray(), 2)));
Test("enough filler", () => Equal(6, s.LeastInterval("ABCABC".ToCharArray(), 1)));
return Finish();
