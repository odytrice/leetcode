using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Set(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }, s.LetterCombinations("23")));
Test("empty", () => Equal(0, s.LetterCombinations("").Count));
Test("four-letter digit", () => Set(new[] { "p", "q", "r", "s" }, s.LetterCombinations("7")));
return Finish();
