using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.LongestCommonSubsequence("abcde", "ace")));
Test("disjoint", () => Equal(0, s.LongestCommonSubsequence("abc", "def")));
Test("repeated letters", () => Equal(2, s.LongestCommonSubsequence("aaaa", "aa")));
Test("order matters", () => Equal(1, s.LongestCommonSubsequence("abc", "cba")));
return Finish();
