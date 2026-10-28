using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("found", () => Equal(2, s.SearchInsert([1, 3, 5, 6], 5)));
Test("between", () => Equal(1, s.SearchInsert([1, 3, 5, 6], 2)));
Test("after", () => Equal(4, s.SearchInsert([1, 3, 5, 6], 7)));
Test("before", () => Equal(0, s.SearchInsert([1], 0)));
return Finish();
