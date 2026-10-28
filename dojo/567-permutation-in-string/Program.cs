using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("present", () => Equal(true, s.CheckInclusion("ab", "eidbaooo")));
Test("absent", () => Equal(false, s.CheckInclusion("ab", "eidboaoo")));
Test("multiplicities", () => Equal(false, s.CheckInclusion("aab", "abb")));
Test("pattern longer", () => Equal(false, s.CheckInclusion("abc", "ab")));
return Finish();
