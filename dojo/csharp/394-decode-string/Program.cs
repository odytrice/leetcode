using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("nested", () => Equal("accaccacc", s.DecodeString("3[a2[c]]")));
Test("adjacent", () => Equal("abcabccdcdcdef", s.DecodeString("2[abc]3[cd]ef")));
Test("multiple digits", () => Equal(new string('a', 12), s.DecodeString("12[a]")));
return Finish();
