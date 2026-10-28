using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.NumDecodings("226")));
Test("leading zero", () => Equal(0, s.NumDecodings("06")));
Test("valid zeros", () => Equal(1, s.NumDecodings("1010")));
Test("invalid zero", () => Equal(0, s.NumDecodings("100")));
Test("pair too large", () => Equal(1, s.NumDecodings("27")));
return Finish();
