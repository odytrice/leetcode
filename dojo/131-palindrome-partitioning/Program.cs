using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new string[][] { ["a", "a", "b"], ["aa", "b"] }, s.Partition("aab")));
Test("single", () => Rows(new string[][] { ["a"] }, s.Partition("a")));
Test("whole palindrome", () => Rows(new string[][] { ["a", "b", "a"], ["aba"] }, s.Partition("aba")));
return Finish();
