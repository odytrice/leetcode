using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(true, s.WordBreak("leetcode", new[] { "leet", "code" })));
Test("reuse", () => Equal(true, s.WordBreak("applepenapple", new[] { "apple", "pen" })));
Test("impossible suffix", () => Equal(false, s.WordBreak("catsandog", new[] { "cats", "dog", "sand", "and", "cat" })));
Test("non-greedy split", () => Equal(true, s.WordBreak("aaaaaaa", new[] { "aaaa", "aaa" })));
return Finish();
