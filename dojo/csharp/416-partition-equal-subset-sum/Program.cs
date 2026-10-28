using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(true, s.CanPartition([1, 5, 11, 5])));
Test("odd sum", () => Equal(false, s.CanPartition([1, 2, 3, 5])));
Test("no element reuse", () => Equal(false, s.CanPartition([1, 2, 5])));
Test("equal pair", () => Equal(true, s.CanPartition([100, 100])));
return Finish();
