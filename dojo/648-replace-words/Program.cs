using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal("the cat was rat by the bat", s.ReplaceWords(new[] { "cat", "bat", "rat" }, "the cattle was rattled by the battery")));
Test("shortest root", () => Equal("a a b", s.ReplaceWords(new[] { "aaa", "a", "aa" }, "aaaa aa b")));
Test("exact and absent", () => Equal("cat dog", s.ReplaceWords(new[] { "cat" }, "cat dog")));
return Finish();
