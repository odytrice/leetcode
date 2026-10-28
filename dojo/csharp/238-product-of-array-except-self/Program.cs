using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Sequence(new[] { 24, 12, 8, 6 }, s.ProductExceptSelf([1, 2, 3, 4])));
Test("one zero", () => Sequence(new[] { 0, 0, 9, 0, 0 }, s.ProductExceptSelf([-1, 1, 0, -3, 3])));
Test("two zeros", () => Sequence(new[] { 0, 0, 0 }, s.ProductExceptSelf([0, 2, 0])));
return Finish();
