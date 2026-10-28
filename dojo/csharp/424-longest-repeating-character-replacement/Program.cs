using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(4, s.CharacterReplacement("AABABBA", 1)));
Test("whole string", () => Equal(4, s.CharacterReplacement("ABAB", 2)));
Test("no replacements", () => Equal(2, s.CharacterReplacement("ABBA", 0)));
return Finish();
