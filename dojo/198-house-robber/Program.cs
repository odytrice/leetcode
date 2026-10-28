using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(12, s.Rob([2, 7, 9, 3, 1])));
Test("skip large neighbor", () => Equal(4, s.Rob([2, 1, 1, 2])));
Test("single", () => Equal(5, s.Rob([5])));
Test("zeros", () => Equal(0, s.Rob([0, 0])));
return Finish();
