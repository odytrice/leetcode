using static TestSupport;
var s = args.Contains("--reference") ? new ReferenceSolution() : new Solution();
Test("example", () => Equal(15, s.ShipWithinDays([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 5)));
Test("one day", () => Equal(6, s.ShipWithinDays([1, 2, 3], 1)));
Test("one per day", () => Equal(3, s.ShipWithinDays([1, 2, 3], 3)));
return Finish();
