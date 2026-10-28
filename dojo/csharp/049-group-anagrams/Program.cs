using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Rows(new string[][] { ["eat", "tea", "ate"], ["tan", "nat"], ["bat"] }, s.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]), true));
Test("empty strings", () => Rows(new string[][] { ["", ""] }, s.GroupAnagrams(["", ""]), true));
Test("letter counts", () => Rows(new string[][] { ["ab", "ba"], ["aab"] }, s.GroupAnagrams(["ab", "aab", "ba"]), true));
return Finish();
