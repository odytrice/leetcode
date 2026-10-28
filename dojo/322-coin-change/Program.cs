using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(3, s.CoinChange([1, 2, 5], 11)));
Test("impossible", () => Equal(-1, s.CoinChange([2], 3)));
Test("zero", () => Equal(0, s.CoinChange([1], 0)));
Test("greedy fails", () => Equal(2, s.CoinChange([1, 3, 4], 6)));
return Finish();
